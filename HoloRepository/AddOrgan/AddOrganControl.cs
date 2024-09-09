using Newtonsoft.Json;
using FellowOakDicom.Imaging;
using FellowOakDicom;
using Npgsql;
using System.Data;
using System.Diagnostics;
using SixLabors.ImageSharp;

namespace HoloRepository
{
    public partial class AddOrganControl : UserControl
    {
        public event Action OnCancelConfirmed;
        private List<string> DICOMPaths = new List<string>();
        public List<OrganSlicePanel> organSlicePanels = new List<OrganSlicePanel>();
        private int selectedIndex;

        private List<string> organData = new List<string>();
        private Dictionary<string, int> organNameDictionary = new Dictionary<string, int>();
        private Dictionary<string, bool> organHasSideDictionary = new Dictionary<string, bool>();
        private DatabaseConnection dbConnection;
        // Back event trigger
        public Action<int> OnSaveCompleted;

        private int donorId;

        private int? organId;

        public AddOrganControl(int donorId, int? organId = null)
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.donorId = donorId;
            this.organId = organId;
            SetCaseNoLabel();
            LoadOrganListData();

            if (organId.HasValue)
            {
                LoadOrganData();
            }
            this.Load += AddOrganControl_Load;
        }

        private void AddOrganControl_Load(object sender, EventArgs e)
        {
            ShowAllParents(this);
        }

        private void ShowAllParents(Control control)
        {
            // Traverse through all parent controls
            while (control != null)
            {
                // Display each parent control's type and name
                MessageBox.Show($"Parent Control: {control.GetType().Name}, Name: {control.Name}");
                // Move to the next parent control
                control = control.Parent;
            }
        }

        private void LoadOrganListData()
        {
            try
            {
                string sql = "SELECT organ_name_id, organ_name, has_side FROM organname";
                using (NpgsqlDataReader reader = dbConnection.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string organName = reader.GetString(1);
                        bool hasSide = reader.GetBoolean(2);
                        organData.Add(organName);
                        organNameDictionary[organName] = id;

                        organHasSideDictionary[organName] = hasSide;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void SetCaseNoLabel()
        {
            // Set the label text
            string labelText = $"Case {donorId}";
            caseNo.Text = labelText;

            // Ensure the text is right-aligned
            caseNo.TextAlign = ContentAlignment.MiddleRight;

            // Adjust label width to ensure the right edge is fixed
            AdjustLabelWidth(caseNo, labelText, rightAlignX: 1300);
        }

        private void AdjustLabelWidth(Label label, string text, int rightAlignX)
        {
            using (Graphics g = label.CreateGraphics())
            {
                // Measure the text width
                System.Drawing.SizeF textSize = g.MeasureString(text, label.Font);

                // Calculate the new width based on the fixed right edge
                int newWidth = rightAlignX - label.Location.X;

                // Adjust the label's width
                label.Width = (int)Math.Ceiling(textSize.Width);

                // Adjust the label's X position to keep the right edge fixed
                label.Left = rightAlignX - label.Width;
            }
        }


        private void InitializeCustomComponents()
        {
            dbConnection = new DatabaseConnection();
            // Subscribe to the ImageDeleted event
            if (fileListBox is RoundedListBox roundedListBox)
            {
                roundedListBox.ImageDeleted += RoundedListBox_DICOMDeleted;
            }
        }

        public List<string> GetDICOMPaths()
        {
            return DICOMPaths;
        }

        private void RoundedListBox_DICOMDeleted(object sender, string deletedFileName)
        {
            // Find the full path corresponding to the deleted file name
            string deletedImagePath = DICOMPaths.FirstOrDefault(path => path.EndsWith(deletedFileName, StringComparison.InvariantCultureIgnoreCase));

            if (deletedImagePath != null)
            {
                DICOMPaths.Remove(deletedImagePath);
                Debug.WriteLine($"Deleted image path: {deletedImagePath}");
            }
            else
            {
                Debug.WriteLine($"Image path for file {deletedFileName} was not found in the list.");
            }
        }

        private void ImportDICOMButton_Click(object sender, EventArgs e)
        {
            if (!IsSideBoxValid())
            {
                MessageBox.Show("Please select a side for this organ.");
                return;
            }
            if (string.IsNullOrWhiteSpace(organNameTextBox.Text))
            {
                MessageBox.Show("Please enter an organ name before importing DICOM files.");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "DICOM files (*.dcm)|*.dcm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Process each selected image file
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Add file name to ListBox
                        string fileName = Path.GetFileName(filePath);
                        fileListBox.Items.Add(fileName);

                        // Add file path to list
                        DICOMPaths.Add(filePath);
                    }
                }
            }
        }

        private bool IsSideBoxValid()
        {
            string organName = organNameTextBox.Text;
            if (organHasSideDictionary.TryGetValue(organName, out bool requiresSide) && requiresSide)
            {
                return !string.IsNullOrEmpty(SideBox.Text);
            }
            return true;
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove all DICOM files?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fileListBox.Items.Clear();
                DICOMPaths.Clear();
            }
        }

        private async void AddOrganSlicesButton_Click(object sender, EventArgs e)
        {
            if (!IsSideBoxValid())
            {
                MessageBox.Show("Please select a side for this organ.");
                return;
            }
            if (string.IsNullOrWhiteSpace(organNameTextBox.Text))
            {
                MessageBox.Show("Please enter an organ name before importing DICOM files.");
                return;
            }

            int sliceIndex = organSlicePanels.Count + 1;
            string organName = organNameTextBox.Text;
            string organSide = SideBox.Text;
            string organNameWithSide = string.IsNullOrEmpty(organSide) ? organName : $"{organName}({organSide})";

            using (AddOrganSlice addOrganSlice = new(donorId, organNameWithSide, sliceIndex, organSide))
            {
                addOrganSlice.StartPosition = FormStartPosition.CenterParent;

                List<System.Drawing.Image> images = new();
                foreach (string path in DICOMPaths)
                {
                    try
                    {
                        var file = await DicomFile.OpenAsync(path);
                        var dicomImage = new DicomImage(file.Dataset);
                        using (var image = dicomImage.RenderImage().AsSharpImage())
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                image.SaveAsBmp(memoryStream);
                                memoryStream.Seek(0, SeekOrigin.Begin);
                                var bitmap = new Bitmap(memoryStream);
                                images.Add(bitmap);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Cannot handle the DICOM file: {ex.Message}");
                    }
                }
                addOrganSlice.SetImageList(images, 0);

                if (addOrganSlice.ShowDialog() == DialogResult.OK)
                {
                    // Selected Image and Description
                    System.Drawing.Image OrganSlice = addOrganSlice.OrganSliceImage;
                    System.Drawing.Image selectedImage = addOrganSlice.SelectedImage;
                    string description = addOrganSlice.Description;
                    string organSlicePath = addOrganSlice.OrganSliceImagePath;
                    selectedIndex = addOrganSlice.SelectedIndex;

                    // Display the new organ slice
                    DisplayNewOrganSlice(organSlicePath, selectedImage, OrganSlice, description);
                }
            }
        }


        private void DisplayNewOrganSlice(string imagePath, System.Drawing.Image image, System.Drawing.Image OrganSliceImage, string description)
        {
            int currentIndex = organSlicePanels.Count + 1;
            string organName = organNameTextBox.Text;
            string organSide = SideBox.Text;
            string organNameWithSide = string.IsNullOrEmpty(organSide) ? organName : $"{organName}({organSide})";

            // Create a new OrganSlicePanel
            OrganSlicePanel organSlicePanel = new OrganSlicePanel
            {
                Width = organSlicesPanel.Width,
                Height = 543,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(10),
                SelectedIndex = selectedIndex,
                Description = description,
                OrganSlicePath = imagePath,
                OrderIndex = currentIndex
            };

            // Set image and description
            organSlicePanel.SetOrganSlice(imagePath);
            organSlicePanel.SetCTImage(image);
            organSlicePanel.SetDescription(description);
            organSlicePanel.SetOrganSliceLabel($"{donorId}-{organNameWithSide}-{currentIndex:D4}-{DateTime.Now:yyyyMMdd}");

            int fixedControlsCount = 4;

            organSlicesPanel.Controls.Add(organSlicePanel);
            organSlicesPanel.Controls.SetChildIndex(organSlicePanel, organSlicesPanel.Controls.Count - fixedControlsCount - 1);
            organSlicePanels.Add(organSlicePanel);
        }

        private void OrganNameTextBox_GotFocus(object sender, EventArgs e)
        {
            ShowOrganListBox();
        }

        private void OrganNameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (!organListBox.Focused)
            {
                if (!organListBox.Items.Contains(organNameTextBox.Text))
                {
                    organNameTextBox.Clear();
                }
                organListBox.Visible = false;
            }
        }
        private void OrganNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = organNameTextBox.Text.ToLower();
            var filteredData = organData.Where(d => d.ToLower().Contains(query)).ToList();

            organListBox.Items.Clear();
            organListBox.Items.AddRange(filteredData.ToArray());

            organListBox.Visible = filteredData.Any();

            if (filteredData.Count == 1 && organHasSideDictionary.TryGetValue(filteredData[0], out bool hasSide) && hasSide)
            {
                SideBox.Visible = true;
            }
            else
            {
                SideBox.Visible = false;
                sideListBox.Visible = false;
            }
        }

        private void SideBox_GotFocus(object sender, EventArgs e)
        {
            ShowSideListBox();
        }

        private void SideBox_LostFocus(object sender, EventArgs e)
        {
            if (!sideListBox.Focused)
            {
                sideListBox.Visible = false;
            }
        }
        private void ShowSideListBox()
        {
            sideListBox.Items.Clear();
            sideListBox.Items.AddRange(new string[] { "Left", "Right" });

            sideListBox.BringToFront();
            sideListBox.Visible = true;
        }

        private void SideListBox_Click(object sender, EventArgs e)
        {
            if (sideListBox.SelectedItem != null)
            {
                SideBox.Text = sideListBox.SelectedItem.ToString();
                sideListBox.Visible = false;
            }
        }


        private void OrganNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (organListBox.Items.Count > 0)
                {
                    organNameTextBox.Text = organListBox.Items[0].ToString();
                    organListBox.Visible = false;
                }
                else
                {
                    organNameTextBox.Clear();
                    organNameTextBox.Parent.Focus();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void ShowOrganListBox()
        {
            organListBox.Items.Clear();
            organListBox.Items.AddRange(organData.ToArray());

            this.organListBox.BringToFront();
            this.organListBox.Visible = true;
        }

        private void OrganListBox_Click(object sender, EventArgs e)
        {
            if (organListBox.SelectedItem != null)
            {
                organNameTextBox.Text = organListBox.SelectedItem.ToString();
                organListBox.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string organName = organNameTextBox.Text;

            if (string.IsNullOrEmpty(organName))
            {
                MessageBox.Show("Organ name cannot be empty.");
                return;
            }

            if (!organNameDictionary.TryGetValue(organName, out int organNameId))
            {
                MessageBox.Show("Organ name not found in the database.");
                return;
            }

            string organSide = null;
            if (SideBox.Visible && SideBox.Text != null)
            {
                organSide = SideBox.Text;
            }

            var selectedTags = multiTags1.SelectedTagIds;

            var DICOMPath = DICOMPaths;
            if (DICOMPath == null || DICOMPath.Count == 0)
            {
                MessageBox.Show("No DICOM file selected.");
                return;
            }

            if (Toggle.IsOn)
            {
                Show3DModelFormWindow(newOrganId =>
                {
                    SaveDataToDatabase(newOrganId, organNameId, organSide, selectedTags, DICOMPath);
                    InsertIntoModel3DTable(newOrganId);
                    MessageBox.Show("Model constructed successfully.");
                    // Back event trigger
                    OnSaveCompleted?.Invoke(donorId);
                });
            }
            else
            {
                int newOrganId = GetOrInsertOrganId(organNameId, organSide);
                SaveDataToDatabase(newOrganId, organNameId, organSide, selectedTags, DICOMPath);
                MessageBox.Show("Data saved successfully.");
                // Back event trigger
                OnSaveCompleted?.Invoke(donorId);
            }
        }

        private void InsertIntoModel3DTable(int organId)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                using (var transaction = connection.BeginTransaction())
                {
                    Debug.WriteLine($"Inserting organId: {organId} into model3d table.");
                    string insertModel3dQuery = "INSERT INTO model3d (organ_id, model_path) VALUES (@organId, @modelPath)";
                    using (var command = new NpgsqlCommand(insertModel3dQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@organId", organId);
                        command.Parameters.AddWithValue("@modelPath", DBNull.Value); // model_path 设为 null
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting into model3d table: " + ex.Message);
            }
        }

        private int GetOrInsertOrganId(int organNameId, string organSide)
        {
            if (!organId.HasValue)
            {
                using (var connection = dbConnection.GetConnection())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (var transaction = connection.BeginTransaction())
                    {
                        string insertOrganQuery = "INSERT INTO organ (donor_id, organ_name_id, organ_side) VALUES (@donorId, @organNameId, @organSide) RETURNING organ_id";
                        using (var command = new NpgsqlCommand(insertOrganQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@donorId", donorId);
                            command.Parameters.AddWithValue("@organNameId", organNameId);
                            command.Parameters.AddWithValue("@organSide", (object)organSide ?? DBNull.Value);

                            organId = (int)command.ExecuteScalar();
                        }
                        transaction.Commit();
                    }
                }
            }
            return organId.Value;
        }

        private void Show3DModelFormWindow(Action<int> onConstruct)
        {
            Form parentForm = this.FindForm();
            if (parentForm == null)
                return;

            using (_3DModelFormWindow form = new _3DModelFormWindow(null, organSlicePanels))
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.TopMost = true;

                form.ConstructClicked += (s, e) =>
                {
                    int newOrganId = GetOrInsertOrganId(organNameDictionary[organNameTextBox.Text], SideBox.Text); // Ensure organId is correctly obtained
                    onConstruct?.Invoke(newOrganId);
                    form.Close();
                };

                form.ShowDialog(parentForm);
            }
        }


        private void SaveDataToDatabase(int organId, int organNameId, string organSide, List<int> selectedTags, List<string> DICOMPath)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                using (var transaction = connection.BeginTransaction())
                {
                    bool isUpdate = false;

                    if (this.organId.HasValue)
                    {
                        string checkOrganQuery = "SELECT organ_id, organ_name_id, organ_side FROM organ WHERE donor_id = @donorId AND organ_id = @organId";
                        using (var checkCommand = new NpgsqlCommand(checkOrganQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@donorId", donorId);
                            checkCommand.Parameters.AddWithValue("@organId", this.organId.Value);

                            using (var reader = checkCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int currentOrganNameId = reader.GetInt32(1);
                                    string currentOrganSide = reader.IsDBNull(2) ? null : reader.GetString(2);

                                    if (currentOrganNameId != organNameId || !string.Equals(currentOrganSide, organSide, StringComparison.OrdinalIgnoreCase))
                                    {
                                        reader.Close();
                                        UpdateOrgan(connection, organId, organNameId, organSide);
                                    }
                                    isUpdate = true;
                                }
                                else
                                {
                                    reader.Close();
                                    organId = InsertNewOrgan(connection, organNameId, organSide);
                                }
                            }
                        }
                    }
                    else
                    {
                        organId = InsertNewOrgan(connection, organNameId, organSide);
                    }

                    if (isUpdate)
                    {
                        ClearExistingOrganData(connection, organId);
                    }

                    InsertTags(connection, organId, selectedTags);
                    InsertDICOMFiles(connection, organId, DICOMPath, out var dicomIdMap);
                    InsertSliceImages(connection, organId, dicomIdMap);

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int InsertNewOrgan(NpgsqlConnection connection, int organNameId, string organSide)
        {
            // Insert new organ record
            string insertOrganQuery = "INSERT INTO organ (donor_id, organ_name_id, organ_side) VALUES (@donorId, @organNameId, @organSide) RETURNING organ_id";
            using (var command = new NpgsqlCommand(insertOrganQuery, connection))
            {
                command.Parameters.AddWithValue("@donorId", donorId);
                command.Parameters.AddWithValue("@organNameId", organNameId);
                command.Parameters.AddWithValue("@organSide", (object)organSide ?? DBNull.Value);
                return (int)command.ExecuteScalar();
            }
        }

        private void UpdateOrgan(NpgsqlConnection connection, int organId, int organNameId, string organSide)
        {
            // Update existing organ record
            string updateOrganQuery = "UPDATE organ SET organ_name_id = @organNameId, organ_side = @organSide WHERE organ_id = @organId";
            using (var updateCommand = new NpgsqlCommand(updateOrganQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@organNameId", organNameId);
                updateCommand.Parameters.AddWithValue("@organSide", (object)organSide ?? DBNull.Value);
                updateCommand.Parameters.AddWithValue("@organId", organId);
                updateCommand.ExecuteNonQuery();
            }
        }

        private void ClearExistingOrganData(NpgsqlConnection connection, int organId)
        {
            // Clear existing tags, DICOM files, slices, and 3D models
            string deleteTagQuery = "DELETE FROM organtag WHERE organ_id = @organId";
            using (var deleteTagCommand = new NpgsqlCommand(deleteTagQuery, connection))
            {
                deleteTagCommand.Parameters.AddWithValue("@organId", organId);
                deleteTagCommand.ExecuteNonQuery();
            }

            string deleteSliceQuery = "DELETE FROM sliceimage WHERE organ_id = @organId";
            using (var deleteSliceCommand = new NpgsqlCommand(deleteSliceQuery, connection))
            {
                deleteSliceCommand.Parameters.AddWithValue("@organId", organId);
                deleteSliceCommand.ExecuteNonQuery();
            }

            string deleteDICOMQuery = "DELETE FROM dicomfile WHERE organ_id = @organId";
            using (var deleteDICOMCommand = new NpgsqlCommand(deleteDICOMQuery, connection))
            {
                deleteDICOMCommand.Parameters.AddWithValue("@organId", organId);
                deleteDICOMCommand.ExecuteNonQuery();
            }

            string delete3DQuery = "DELETE FROM model3d WHERE organ_id = @organId";
            using (var delete3DCommand = new NpgsqlCommand(delete3DQuery, connection))
            {
                delete3DCommand.Parameters.AddWithValue("@organId", organId);
                delete3DCommand.ExecuteNonQuery();
            }
        }

        private void InsertTags(NpgsqlConnection connection, int organId, List<int> selectedTags)
        {
            // Insert new tags
            string insertTagQuery = "INSERT INTO organtag (organ_id, tag_id) VALUES (@organId, @tagId)";
            foreach (var tagId in selectedTags)
            {
                using (var command = new NpgsqlCommand(insertTagQuery, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);
                    command.Parameters.AddWithValue("@tagId", tagId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertDICOMFiles(NpgsqlConnection connection, int organId, List<string> DICOMPath, out Dictionary<string, int> dicomIdMap)
        {
            // Initialize the dictionary to map original paths to their corresponding dicom IDs
            dicomIdMap = new Dictionary<string, int>();

            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Define the target directory for DICOM files
            string dicomFileDirectory = Path.Combine(baseDirectory, "data", "DICOMFile");
            Directory.CreateDirectory(dicomFileDirectory); // Create the directory if it doesn't exist

            // SQL query to insert the DICOM file paths into the database
            string insertDICOMQuery = "INSERT INTO dicomfile (organ_id, dicom_path) VALUES (@organId, @dicomPath) RETURNING dicom_id";

            // Iterate through each DICOM path in the list
            foreach (var dicomPath in DICOMPath)
            {
                try
                {
                    // Define the destination file path (same name as the original file)
                    string destinationFilePath = Path.Combine(dicomFileDirectory, Path.GetFileName(dicomPath));

                    // Copy the DICOM file to the target directory
                    File.Copy(dicomPath, destinationFilePath, overwrite: true);

                    // Get the relative path to the base directory for storage in the database
                    string relativeDICOMPath = Path.GetRelativePath(baseDirectory, destinationFilePath);

                    int dicomId;
                    // Insert the new DICOM path into the database
                    using (var command = new NpgsqlCommand(insertDICOMQuery, connection))
                    {
                        command.Parameters.AddWithValue("@organId", organId);
                        command.Parameters.AddWithValue("@dicomPath", relativeDICOMPath);
                        dicomId = (int)command.ExecuteScalar();
                    }

                    // Map the original path to the returned DICOM ID
                    dicomIdMap[dicomPath] = dicomId;
                }
                catch (Exception ex)
                {
                    // Log or handle exceptions as needed
                    MessageBox.Show($"Error processing DICOM file {dicomPath}: {ex.Message}");
                }
            }
        }

        private void InsertSliceImages(NpgsqlConnection connection, int organId, Dictionary<string, int> dicomIdMap)
        {
            // Insert slice images
            string insertSliceImageQuery = "INSERT INTO sliceimage (organ_id, dicom_id, additional_info, image_path) VALUES (@organId, @dicomId, @Description, @slicePath)";
            foreach (var panel in organSlicePanels)
            {
                if (dicomIdMap.TryGetValue(DICOMPaths[panel.SelectedIndex], out int dicomId))
                {
                    using (var command = new NpgsqlCommand(insertSliceImageQuery, connection))
                    {
                        command.Parameters.AddWithValue("@organId", organId);
                        command.Parameters.AddWithValue("@dicomId", dicomId);
                        command.Parameters.AddWithValue("@Description", panel.Description);
                        command.Parameters.AddWithValue("@slicePath", panel.OrganSlicePath);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private async void LoadOrganData()
        {
            try
            {
                // Check organ_name_id and organ_side
                string organQuery = "SELECT organ_name_id, organ_side FROM organ WHERE donor_id = @donorId AND organ_id = @organId";
                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(organQuery, connection))
                {
                    command.Parameters.AddWithValue("@donorId", donorId);
                    command.Parameters.AddWithValue("@organId", organId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int organNameId = reader.GetInt32(0);
                            string organSide = reader.IsDBNull(1) ? null : reader.GetString(1);

                            // Use a separate connection to get organ name
                            string organNameQuery = "SELECT organ_name FROM organname WHERE organ_name_id = @organNameId";
                            using (var organNameConnection = dbConnection.GetConnection())
                            using (var organNameCommand = new NpgsqlCommand(organNameQuery, organNameConnection))
                            {
                                organNameCommand.Parameters.AddWithValue("@organNameId", organNameId);
                                string organName = Convert.ToString(organNameCommand.ExecuteScalar());

                                if (string.IsNullOrEmpty(organName))
                                {
                                    throw new Exception("Cannot find the corresponding organ name");
                                }

                                organNameTextBox.Text = organName;
                            }

                            // Load DICOM file path
                            string dicomQuery = "SELECT dicom_id, dicom_path FROM dicomfile WHERE organ_id = @organId";
                            Dictionary<int, string> dicomIdToPathMap = new Dictionary<int, string>();
                            using (var dicomConnection = dbConnection.GetConnection())
                            using (var dicomCommand = new NpgsqlCommand(dicomQuery, dicomConnection))
                            {
                                dicomCommand.Parameters.AddWithValue("@organId", organId);
                                using (var dicomReader = dicomCommand.ExecuteReader())
                                {
                                    while (dicomReader.Read())
                                    {
                                        int dicomId = dicomReader.GetInt32(0);
                                        string dicomPath = dicomReader.GetString(1);
                                        dicomIdToPathMap[dicomId] = dicomPath;
                                        DICOMPaths.Add(dicomPath);
                                        fileListBox.Items.Add(Path.GetFileName(dicomPath));
                                        Debug.WriteLine($"Load DICOM path: {dicomPath}");
                                    }
                                }
                            }

                            // Load slice images
                            string sliceQuery = "SELECT dicom_id, image_path, additional_info FROM sliceimage WHERE organ_id = @organId";
                            using (var sliceConnection = dbConnection.GetConnection())
                            using (var sliceCommand = new NpgsqlCommand(sliceQuery, sliceConnection))
                            {
                                sliceCommand.Parameters.AddWithValue("@organId", organId);
                                using (var sliceReader = sliceCommand.ExecuteReader())
                                {
                                    while (sliceReader.Read())
                                    {
                                        int dicomId = sliceReader.GetInt32(0);
                                        string sliceImagePath = sliceReader.GetString(1);
                                        string additionalInfo = sliceReader.GetString(2);

                                        if (dicomIdToPathMap.TryGetValue(dicomId, out string dicomPath))
                                        {
                                            try
                                            {
                                                // Load and render the DICOM image
                                                var dicomFile = await DicomFile.OpenAsync(dicomPath);
                                                var dicomImage = new DicomImage(dicomFile.Dataset);
                                                Bitmap dicomBitmap;

                                                using (var imageSharpImage = dicomImage.RenderImage().AsSharpImage())
                                                using (var memoryStream = new MemoryStream())
                                                {
                                                    imageSharpImage.SaveAsBmp(memoryStream);
                                                    memoryStream.Seek(0, SeekOrigin.Begin);
                                                    dicomBitmap = new Bitmap(memoryStream);
                                                }

                                                // Load the slice image
                                                System.Drawing.Image sliceImage;
                                                using (var sliceStream = new FileStream(sliceImagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                                {
                                                    using (var memoryStream = new MemoryStream())
                                                    {
                                                        sliceStream.CopyTo(memoryStream);
                                                        memoryStream.Seek(0, SeekOrigin.Begin);
                                                        sliceImage = System.Drawing.Image.FromStream(memoryStream);
                                                    }
                                                }

                                                selectedIndex = DICOMPaths.IndexOf(dicomPath);

                                                DisplayNewOrganSlice(sliceImagePath, dicomBitmap, sliceImage, additionalInfo);
                                            }
                                            catch (Exception ex)
                                            {
                                                Debug.WriteLine($"Error when loading picture files: {ex.Message}");
                                            }
                                        }
                                        else
                                        {
                                            Debug.WriteLine($"DICOM ID: {dicomId} didn't find");
                                        }
                                    }
                                }
                            }

                            // Load tags
                            string tagQuery = "SELECT tag_id FROM organtag WHERE organ_id = @organId";
                            using (var tagConnection = dbConnection.GetConnection())
                            using (var tagCommand = new NpgsqlCommand(tagQuery, tagConnection))
                            {
                                tagCommand.Parameters.AddWithValue("@organId", organId);
                                using (var tagReader = tagCommand.ExecuteReader())
                                {
                                    while (tagReader.Read())
                                    {
                                        int tagId = tagReader.GetInt32(0);
                                        multiTags1.AddSelectedTagId(tagId);
                                    }
                                }
                            }

                            // Check availability of 3D model
                            string model3dQuery = "SELECT * FROM model3d WHERE organ_id = @organId";
                            using (var model3dConnection = dbConnection.GetConnection())
                            using (var model3dCommand = new NpgsqlCommand(model3dQuery, model3dConnection))
                            {
                                model3dCommand.Parameters.AddWithValue("@organId", organId);
                                object model3dResult = model3dCommand.ExecuteScalar();
                                Toggle.IsOn = model3dResult != null;
                            }

                            // Set organ side text
                            if (!string.IsNullOrEmpty(organSide))
                            {
                                SideBox.Text = organSide; // If organ_side exists, set the value of SideBox
                            }

                            AddOrganTitle.Text = "Update an Organ";
                        }
                        else
                        {
                            MessageBox.Show("No matching organ found for the provided donorId and organId.");
                        }
                    }
                }
                organListBox.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organ data: " + ex.Message);
            }
        }

        public int GetDonorID()
        {
            return donorId;
        }

        public string GetOrganName()
        {
            return organNameTextBox.Text;
        }

        public string GetOrganSide()
        {
            return SideBox.Text;
        }

        public void RemoveOrganSlicePanel(OrganSlicePanel panel)
        {
            if (organSlicePanels.Contains(panel))
            {
                organSlicePanels.Remove(panel);
                Debug.WriteLine($"Removed OrganSlicePanel with path: {panel.OrganSlicePath}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (PopupWindow popup = new PopupWindow("Are you sure you want to cancel?", this.FindForm()))
            {
                if (popup.ShowDialog() == DialogResult.Yes)
                {
                    OnCancelConfirmed?.Invoke();
                }
            }
        }

        public void ProcessVoiceCommand(string transcription)
        {
            if (transcription.ToLower().Contains("add an organ slice"))
            {
                AddOrganSlicesButton_Click(this, EventArgs.Empty);
            }
            if (transcription.ToLower().Contains("save"))
            {
                btnSave_Click(this, EventArgs.Empty);
            }
        }
    }
}
