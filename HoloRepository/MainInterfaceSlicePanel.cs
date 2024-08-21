using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FellowOakDicom.Imaging;
using FellowOakDicom;
using SixLabors.ImageSharp;
using Npgsql;

namespace HoloRepository
{
    public partial class MainInterfaceSlicePanel : UserControl
    {
        private List<PictureBox> pictureBoxList;
        private DatabaseConnection dbConnection;
        private System.Drawing.Image plusImage;

        private int donorId;
        private int organId;

        private int startIndex = 0; // The starting index for displaying 3D panels
        private List<System.Drawing.Image> sliceImages = new List<System.Drawing.Image>(); // List of preloaded images
        private Dictionary<System.Drawing.Image, string> imageInfoMap = new Dictionary<System.Drawing.Image, string>();
        private const int maxPictureBoxes = 3;

        public event Action<System.Drawing.Image, string> PictureBoxClicked;

        public MainInterfaceSlicePanel(int donorId, int organId)
        {
            InitializeComponent();
            this.donorId = donorId;
            this.organId = organId;
            dbConnection = new DatabaseConnection();

            plusImage = CreatePlusImage();

            pictureBoxList = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3 };
            LoadSlices(donorId, organId); // Preload images into memory
            UpdatePictureBoxes();         // Display the first set of images
            CheckVisibility();

            // Click event for every picture box
            foreach (var pictureBox in pictureBoxList)
            {
                pictureBox.Click += PictureBox_Click;
            }
        }

        private void LoadSlices(int donorId, int organId)
        {
            string query = @"
                SELECT image_path, additional_info
                FROM sliceimage 
                WHERE organ_id = @organId
                ORDER BY slice_id"; // Assuming there is a slice_id to order the slices

            var parameters = new Dictionary<string, object>
            {
                { "@organId", organId }
            };

            try
            {
                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string imagePath = reader.GetString(0);
                            string additionalInfo = reader.GetString(1);

                            // Preload the image into memory
                            if (System.IO.File.Exists(imagePath))
                            {
                                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                                sliceImages.Add(image);
                                imageInfoMap[image] = additionalInfo;
                            }
                            else
                            {
                                MessageBox.Show($"Image not found: {imagePath}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slices: " + ex.Message);
            }
        }

        private void UpdatePictureBoxes()
        {
            // Load plus picture into picture box when startindex = 0
            if (startIndex == 0)
            {
                pictureBoxList[0].Image = plusImage; 
                pictureBoxList[0].Tag = null;

                // Load organ slice pictures from second picture box
                for (int i = 1; i < maxPictureBoxes; i++)
                {
                    if (i - 1 + startIndex < sliceImages.Count)
                    {
                        pictureBoxList[i].Image = sliceImages[i - 1 + startIndex];
                        pictureBoxList[i].Tag = sliceImages[i - 1 + startIndex];
                    }
                    else
                    {
                        pictureBoxList[i].Image = null;
                        pictureBoxList[i].Tag = null;
                    }
                }
            }
            else
            {
                for (int i = 0; i < maxPictureBoxes; i++)
                {
                    if (i + startIndex - 1 < sliceImages.Count)
                    {
                        pictureBoxList[i].Image = sliceImages[i + startIndex - 1];
                        pictureBoxList[i].Tag = sliceImages[i + startIndex - 1];
                    }
                    else
                    {
                        pictureBoxList[i].Image = null;
                        pictureBoxList[i].Tag = null;
                    }
                }
            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox == pictureBoxList[0] && clickedPictureBox.Image != null && clickedPictureBox.Image == plusImage)
            {
                ShowAddOrganSliceDialog();
            }
            else if (clickedPictureBox != null && clickedPictureBox.Tag is System.Drawing.Image image)
            {
                if (imageInfoMap.TryGetValue(image, out string additionalInfo))
                {
                    PictureBoxClicked?.Invoke(image, additionalInfo);
                }
                else
                {
                    PictureBoxClicked?.Invoke(image, "No description yet");
                }
            }
        }

        private void CheckVisibility()
        {
            this.Visible = sliceImages.Count > 0;
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (startIndex < sliceImages.Count - (maxPictureBoxes - 1))
            {
                startIndex++;
                UpdatePictureBoxes();
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (startIndex > 0)
            {
                startIndex--;
                UpdatePictureBoxes();
            }
        }

        private System.Drawing.Image CreatePlusImage()
        {
            int width = 100;
            int height = 100;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(System.Drawing.Color.White);
                Pen pen = new Pen(System.Drawing.Color.Gray, 5);

                int centerX = width / 2;
                int centerY = height / 2;
                int lineLength = 30;

                g.DrawLine(pen, centerX - lineLength / 2, centerY, centerX + lineLength / 2, centerY);

                g.DrawLine(pen, centerX, centerY - lineLength / 2, centerX, centerY + lineLength / 2);
            }

            return bmp;
        }

        private async void ShowAddOrganSliceDialog()
        {
            string organName = string.Empty;
            string organSide = string.Empty;
            int sliceIndex = sliceImages.Count + 1;

            // Search organ_name and organ_side
            try
            {
                string organQuery = @"
                    SELECT o.organ_name_id, o.organ_side, n.organ_name
                    FROM organ o
                    JOIN organname n ON o.organ_name_id = n.organ_name_id
                    WHERE o.organ_id = @organId";

                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(organQuery, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            organName = reader.GetString(reader.GetOrdinal("organ_name"));

                            // Check whether organ side is null or not
                            if (!reader.IsDBNull(reader.GetOrdinal("organ_side")))
                            {
                                organSide = reader.GetString(reader.GetOrdinal("organ_side"));
                            }
                            else
                            {
                                organSide = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving organ information: " + ex.Message);
                return;
            }

            List<System.Drawing.Image> dicomImages = new List<System.Drawing.Image>();
            Dictionary<int, int> dicomIdMap = new Dictionary<int, int>();
            try
            {
                string dicomQuery = @"
                    SELECT dicom_id, dicom_path 
                    FROM dicomfile 
                    WHERE organ_id = @organId
                    ORDER BY dicom_id"; // Assuming there is a dicom_id to order the files

                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(dicomQuery, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int dicomId = reader.GetInt32(0);
                            string dicomPath = reader.GetString(1);

                            // Pre load DICOM files into memory
                            if (System.IO.File.Exists(dicomPath))
                            {
                                try
                                {
                                    // Load and render DICOM as Bitmap
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

                                    dicomImages.Add(dicomBitmap);
                                    dicomIdMap[dicomImages.Count - 1] = dicomId;  // Map index to dicomId
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error processing DICOM file: {dicomPath}. Details: {ex.Message}");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"DICOM file not found: {dicomPath}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DICOM files: " + ex.Message);
                return;
            }

            AddOrganSlice addOrganSliceForm = new AddOrganSlice(donorId, organName, sliceIndex, organSide);

            addOrganSliceForm.SetImageList(dicomImages, 0);

            addOrganSliceForm.OrganSliceUpdated += (organSliceImage, selectedImage, description, index) =>
            {
                string imagePath = addOrganSliceForm.OrganSliceImagePath;

                if (dicomIdMap.TryGetValue(index, out int selectedDicomId))
                {
                    InsertSliceImageToDatabase(organId, selectedDicomId, description, imagePath);
                }
                else
                {
                    MessageBox.Show($"Error: No DICOM ID found for index {index}.", "DICOM ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sliceImages.Add(organSliceImage);
                UpdatePictureBoxes();
            };

            addOrganSliceForm.ShowDialog();
        }

        private void InsertSliceImageToDatabase(int organId, int dicomId, string description, string imagePath)
        {
            try
            {
                string query = @"
            INSERT INTO sliceimage (organ_id, dicom_id, additional_info, image_path)
            VALUES (@organId, @dicomId, @additionalInfo, @imagePath)";

                using (var connection = dbConnection.GetConnection())
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@organId", organId);
                        command.Parameters.AddWithValue("@dicomId", dicomId);
                        command.Parameters.AddWithValue("@additionalInfo", description);
                        command.Parameters.AddWithValue("@imagePath", imagePath);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Slice image inserted into the database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting slice image into the database: {ex.Message}");
            }
        }


    }
}
