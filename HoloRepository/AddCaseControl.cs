using Dicom;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class AddCaseControl : UserControl
    {
        private List<string> imagePaths = new List<string>();
        public List<OrganSlicePanel> organSlicePanels = new List<OrganSlicePanel>();
        private int selectedIndex;

        private List<string> organData = new List<string>();
        private Dictionary<string, int> organNameDictionary = new Dictionary<string, int>();
        private DatabaseConnection dbConnection;

        private int donorId;

        private int? organId;

        public AddCaseControl(int donorId, int? organId = null)
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
        }

        private void LoadOrganListData()
        {
            try
            {
                string sql = "SELECT organ_name_id, organ_name FROM organname";
                using (NpgsqlDataReader reader = dbConnection.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string organName = reader.GetString(1);
                        organData.Add(organName);
                        organNameDictionary[organName] = id;
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
            AdjustLabelWidth(caseNo, labelText, rightAlignX: 1290); // Assume 300 is the fixed X coordinate for the right edge
        }

        private void AdjustLabelWidth(Label label, string text, int rightAlignX)
        {
            using (Graphics g = label.CreateGraphics())
            {
                // Measure the text width
                SizeF textSize = g.MeasureString(text, label.Font);

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
                roundedListBox.ImageDeleted += RoundedListBox_ImageDeleted;
            }
        }

        public List<string> GetImagePaths()
        {
            return imagePaths;
        }

        private void RoundedListBox_ImageDeleted(object sender, string deletedFileName)
        {
            // Find the full path corresponding to the deleted file name
            string deletedImagePath = imagePaths.FirstOrDefault(path => path.EndsWith(deletedFileName, StringComparison.InvariantCultureIgnoreCase));

            if (deletedImagePath != null)
            {
                imagePaths.Remove(deletedImagePath);
                Debug.WriteLine($"Deleted image path: {deletedImagePath}");
            }
            else
            {
                Debug.WriteLine($"Image path for file {deletedFileName} was not found in the list.");
            }
        }

        private void ImportDICOMButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(organNameTextBox.Text))
            {
                MessageBox.Show("Please enter an organ name before importing DICOM files.");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
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
                        imagePaths.Add(filePath);
                    }
                }
            }
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
                imagePaths.Clear();
            }
        }

        private void AddOrganSlicesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(organNameTextBox.Text))
            {
                MessageBox.Show("Please enter an organ name before importing DICOM files.");
                return;
            }

            int sliceIndex = organSlicePanels.Count + 1;

            using (AddOrganSlice addOrganSlice = new(donorId, organNameTextBox.Text, sliceIndex))
            {
                addOrganSlice.StartPosition = FormStartPosition.CenterParent;

                List<Image> images = new();
                foreach (string path in imagePaths)
                {
                    images.Add(new Bitmap(path));
                }
                addOrganSlice.SetImageList(images, 0);

                if (addOrganSlice.ShowDialog() == DialogResult.OK)
                {
                    // Selected Image and Description
                    Image OrganSlice = addOrganSlice.OrganSliceImage;
                    Image selectedImage = addOrganSlice.SelectedImage;
                    string description = addOrganSlice.Description;
                    string organSlicePath = addOrganSlice.OrganSliceImagePath;
                    selectedIndex = addOrganSlice.SelectedIndex;

                    // Display the new organ slice
                    DisplayNewOrganSlice(organSlicePath, selectedImage, OrganSlice, description);
                }
            }
        }


        private void DisplayNewOrganSlice(string imagePath, Image image, Image OrganSliceImage, string description)
        {
            int currentIndex = organSlicePanels.Count + 1;
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
            organSlicePanel.SetOrganSlice(OrganSliceImage, imagePath);
            organSlicePanel.SetCTImage(image);
            organSlicePanel.SetDescription(description);
            organSlicePanel.SetOrganSliceLabel($"{donorId}-{organNameTextBox.Text}-{currentIndex:D4}-{DateTime.Now:yyyyMMdd}");

            int fixedControlsCount = 4;

            organSlicesPanel.Controls.Add(organSlicePanel);
            organSlicesPanel.Controls.SetChildIndex(organSlicePanel, organSlicesPanel.Controls.Count - fixedControlsCount - 1);
            organSlicePanels.Add(organSlicePanel);
        }

        private void CancelAddOrganButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                parentForm.Close();
            }
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

            var selectedTags = multiTags1.SelectedTagIds;
            if (selectedTags == null || selectedTags.Count == 0)
            {
                MessageBox.Show("No tags selected.");
                return;
            }

            var DICOMPath = imagePaths;
            if (DICOMPath == null || DICOMPath.Count == 0)
            {
                MessageBox.Show("No DICOM file selected.");
                return;
            }

            // Check for existing organ record
            if (btnSave.Text == "Add")
            {
                try
                {
                    string checkOrganQuery = "SELECT organ_id FROM organ WHERE donor_id = @donorId AND organ_name_id = @organNameId";
                    using (var connection = dbConnection.GetConnection())
                    using (var command = new NpgsqlCommand(checkOrganQuery, connection))
                    {
                        command.Parameters.AddWithValue("@donorId", donorId);
                        command.Parameters.AddWithValue("@organNameId", organNameId);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show("A record with the same donor ID and organ name already exists.");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking existing records: " + ex.Message);
                    return;
                }
            }

            try
            {
                // Begin transaction
                using (var connection = dbConnection.GetConnection())
                using (var transaction = connection.BeginTransaction())
                {
                    int organId;
                    bool isUpdate = false;

                    // Check if the organ already exists using donorId and organId
                    if (this.organId.HasValue)
                    {
                        string checkOrganQuery = "SELECT organ_id FROM organ WHERE donor_id = @donorId AND organ_id = @organId";
                        using (var checkCommand = new NpgsqlCommand(checkOrganQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@donorId", donorId);
                            checkCommand.Parameters.AddWithValue("@organId", this.organId.Value);
                            object result = checkCommand.ExecuteScalar();
                            if (result != null)
                            {
                                organId = Convert.ToInt32(result);
                                isUpdate = true;
                            }
                            else
                            {
                                // Insert into organ table
                                string insertOrganQuery = "INSERT INTO organ (donor_id, organ_name_id) VALUES (@donorId, @organNameId) RETURNING organ_id";
                                using (var command = new NpgsqlCommand(insertOrganQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@donorId", donorId);
                                    command.Parameters.AddWithValue("@organNameId", organNameId);
                                    organId = (int)command.ExecuteScalar();
                                }
                            }
                        }
                    }
                    else
                    {
                        // Insert into organ table
                        string insertOrganQuery = "INSERT INTO organ (donor_id, organ_name_id) VALUES (@donorId, @organNameId) RETURNING organ_id";
                        using (var command = new NpgsqlCommand(insertOrganQuery, connection))
                        {
                            command.Parameters.AddWithValue("@donorId", donorId);
                            command.Parameters.AddWithValue("@organNameId", organNameId);
                            organId = (int)command.ExecuteScalar();
                        }
                    }

                    if (isUpdate)
                    {
                        // Delete existing tags
                        string deleteTagQuery = "DELETE FROM organtag WHERE organ_id = @organId";
                        using (var deleteTagCommand = new NpgsqlCommand(deleteTagQuery, connection))
                        {
                            deleteTagCommand.Parameters.AddWithValue("@organId", organId);
                            deleteTagCommand.ExecuteNonQuery();
                        }

                        // Delete existing DICOM files and slices
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

                    // Insert into organtag table
                    string insertTagQuery = "INSERT INTO organtag (organ_id, tag_id) VALUES (@organId, @tagId)";
                    string tagPreview = string.Join(", ", selectedTags);
                    Debug.WriteLine($"Selected tags: {tagPreview}");
                    foreach (var tagId in selectedTags)
                    {
                        using (var command = new NpgsqlCommand(insertTagQuery, connection))
                        {
                            command.Parameters.AddWithValue("@organId", organId);
                            command.Parameters.AddWithValue("@tagId", tagId);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Insert into dicomfile table
                    string insertDICOMQuery = "INSERT INTO dicomfile (organ_id, dicom_path) VALUES (@organId, @dicomPath) RETURNING dicom_id";
                    Dictionary<string, int> dicomIdMap = new Dictionary<string, int>();
                    foreach (var dicomPath in DICOMPath)
                    {
                        int dicomId;
                        using (var command = new NpgsqlCommand(insertDICOMQuery, connection))
                        {
                            command.Parameters.AddWithValue("@organId", organId);
                            command.Parameters.AddWithValue("@dicomPath", dicomPath);
                            dicomId = (int)command.ExecuteScalar();
                        }
                        dicomIdMap[dicomPath] = dicomId;
                    }

                    List<string> insertedPaths = new List<string>();

                    // Insert into sliceimage
                    string insertSliceImageQuery = "INSERT INTO sliceimage (organ_id, dicom_id, additional_info, image_path) VALUES (@organId, @dicomId, @Description, @slicePath)";
                    foreach (var panel in organSlicePanels)
                    {
                        if (dicomIdMap.TryGetValue(imagePaths[panel.SelectedIndex], out int dicomId))
                        {
                            // Assume the panel already contains the correct new path
                            using (var command = new NpgsqlCommand(insertSliceImageQuery, connection))
                            {
                                command.Parameters.AddWithValue("@organId", organId);
                                command.Parameters.AddWithValue("@dicomId", dicomId);
                                command.Parameters.AddWithValue("@Description", panel.Description);
                                command.Parameters.AddWithValue("@slicePath", panel.OrganSlicePath); // Use updated path
                                command.ExecuteNonQuery();

                                insertedPaths.Add(panel.OrganSlicePath);
                            }
                        }
                    }

                    try
                    {
                        foreach (string insertedPath in insertedPaths)
                        {
                            string directoryPath = Path.GetDirectoryName(insertedPath);

                            if (!string.IsNullOrEmpty(directoryPath))
                            {
                                // Get all files in the directory
                                string[] allFilesInDirectory = Directory.GetFiles(directoryPath);

                                foreach (string filePath in allFilesInDirectory)
                                {
                                    // If the file is not in the inserted paths list, delete it
                                    if (!insertedPaths.Contains(filePath))
                                    {
                                        File.Delete(filePath);
                                        Debug.WriteLine($"Deleted unused file: {filePath}");
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting unused files: " + ex.Message);
                    }

                    // Commit transaction
                    transaction.Commit();

                    if (Toggle.IsOn)
                    {
                        Show3DModelFormWindow(organId);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Show3DModelFormWindow(int organId)
        {
            Form parentForm = this.FindForm();
            if (parentForm == null)
                return;

            // Create overlay form
            OverlayForm overlay = new OverlayForm
            {
                Location = parentForm.Location,
                Size = parentForm.Size
            };

            // Display overlay form
            overlay.Show(parentForm);

            // Create 3DModelFormWindow
            using (_3DModelFormWindow form = new _3DModelFormWindow(organId))
            {
                // Set 3DModelFormWindow to the center of parent window
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(
                    parentForm.Left + (parentForm.Width - form.Width) / 2,
                    parentForm.Top + (parentForm.Height - form.Height) / 2);

                // Ensure the 3DModelFormWindow is TopMost
                form.TopMost = true;

                // Subscribe to the ConstructClicked event
                form.ConstructClicked += (s, e) =>
                {
                    using (var connection = dbConnection.GetConnection())
                    {
                        using (var transaction = connection.BeginTransaction())
                        {
                            string insertModel3dQuery = "INSERT INTO model3d (organ_id, model_path) VALUES (@organId, @modelPath)";
                            using (var command = new NpgsqlCommand(insertModel3dQuery, connection))
                            {
                                command.Parameters.AddWithValue("@organId", organId);
                                command.Parameters.AddWithValue("@modelPath", DBNull.Value); // model_path: null
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                    }

                    MessageBox.Show("Model constructed successfully.");
                    overlay.Close();
                    form.Close();
                };

                // Show 3DModelFormWindow as dialog
                form.ShowDialog(parentForm);

                // Close overlay form after dialog is closed
                overlay.Close();
            }
        }



        private void LoadOrganData()
        {
            try
            {
                string organQuery = "SELECT organ_name_id FROM organ WHERE donor_id = @donorId AND organ_id = @organId";
                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(organQuery, connection))
                {
                    command.Parameters.AddWithValue("@donorId", donorId);
                    command.Parameters.AddWithValue("@organId", organId);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int organNameId = Convert.ToInt32(result);

                        string organNameQuery = "SELECT organ_name FROM organname WHERE organ_name_id = @organNameId";
                        using (var organNameCommand = new NpgsqlCommand(organNameQuery, connection))
                        {
                            organNameCommand.Parameters.AddWithValue("@organNameId", organNameId);
                            string organName = Convert.ToString(organNameCommand.ExecuteScalar());

                            if (string.IsNullOrEmpty(organName))
                            {
                                throw new Exception("Organ name not found for the given organNameId.");
                            }

                            organNameTextBox.Text = organName;
                        }

                        // Load DICOM files
                        string dicomQuery = "SELECT dicom_id, dicom_path FROM dicomfile WHERE organ_id = @organId";
                        Dictionary<int, string> dicomIdToPathMap = new Dictionary<int, string>();
                        using (var dicomCommand = new NpgsqlCommand(dicomQuery, connection))
                        {
                            dicomCommand.Parameters.AddWithValue("@organId", organId);
                            using (var reader = dicomCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int dicomId = reader.GetInt32(0);
                                    string dicomPath = reader.GetString(1);
                                    dicomIdToPathMap[dicomId] = dicomPath;
                                    imagePaths.Add(dicomPath);
                                    fileListBox.Items.Add(Path.GetFileName(dicomPath));
                                    Debug.WriteLine($"Loaded dicomPath: {dicomPath}");
                                }
                            }
                        }

                        // Load Slice Images
                        string sliceQuery = "SELECT dicom_id, image_path, additional_info FROM sliceimage WHERE organ_id = @organId";
                        using (var sliceCommand = new NpgsqlCommand(sliceQuery, connection))
                        {
                            sliceCommand.Parameters.AddWithValue("@organId", organId);
                            using (var reader = sliceCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int dicomId = reader.GetInt32(0);
                                    string sliceImagePath = reader.GetString(1);
                                    string additionalInfo = reader.GetString(2);

                                    if (dicomIdToPathMap.TryGetValue(dicomId, out string dicomPath))
                                    {
                                        try
                                        {
                                            // Load DICOM pictures
                                            using (FileStream dicomStream = new FileStream(dicomPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                            {
                                                Image dicomImage = Image.FromStream(dicomStream).Clone() as Image;

                                                // Load slice pictures
                                                using (FileStream sliceStream = new FileStream(sliceImagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                                                {
                                                    Image sliceImage = Image.FromStream(sliceStream).Clone() as Image;

                                                    // Display in the control
                                                    DisplayNewOrganSlice(sliceImagePath, dicomImage, sliceImage, additionalInfo);
                                                    Debug.WriteLine($"Displayed sliceImagePath: {sliceImagePath}, dicomId: {dicomId}, additionalInfo: {additionalInfo}");
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            // Error handling
                                            Debug.WriteLine($"Error loading image: {ex.Message}");
                                        }
                                    }
                                    else
                                    {
                                        Debug.WriteLine($"dicomId: {dicomId} not found in dicomIdToPathMap");
                                    }
                                }
                            }
                        }

                        // Load Tags
                        string tagQuery = "SELECT tag_id FROM organtag WHERE organ_id = @organId";
                        using (var tagCommand = new NpgsqlCommand(tagQuery, connection))
                        {
                            tagCommand.Parameters.AddWithValue("@organId", organId);
                            using (var reader = tagCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int tagId = reader.GetInt32(0);
                                    multiTags1.AddSelectedTagId(tagId);
                                }
                            }
                        }
                        string model3dQuery = "SELECT * FROM model3d WHERE organ_id = @organId";
                        using (var model3dCommand = new NpgsqlCommand(model3dQuery, connection))
                        {
                            model3dCommand.Parameters.AddWithValue("@organId", organId);
                            object model3dResult = model3dCommand.ExecuteScalar();
                            Toggle.IsOn = model3dResult != null;
                        }
                        AddOrganTitle.Text = "Update an Organ";
                        btnSave.Text = "Save";
                    }
                    else
                    {
                        MessageBox.Show("No matching organ found for the provided donorId and organId.");
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

        public void RemoveOrganSlicePanel(OrganSlicePanel panel)
        {
            if (organSlicePanels.Contains(panel))
            {
                organSlicePanels.Remove(panel);
                Debug.WriteLine($"Removed OrganSlicePanel with path: {panel.OrganSlicePath}");
            }
        }

    }
}
