using FellowOakDicom.Imaging;
using FellowOakDicom;
using SixLabors.ImageSharp;
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
    public partial class MainInterFaceControl : UserControl
    {
        private List<System.Drawing.Image> dicomImages;
        private DatabaseConnection dbConnection;
        private bool modelExists = false;
        private int donorId;
        private int organId;
        private Control parentControl;

        public MainInterFaceControl(Control parentControl, int donorId, int organId)
        {
            InitializeComponent();
            this.parentControl = parentControl;
            this.donorId = donorId;
            this.organId = organId;
            dbConnection = new DatabaseConnection();

            CheckModel3DExists(organId);

            LoadInfoPanel(donorId, organId);
            LoadSlicePanel(donorId, organId);

            sliderControl1.ImageSelected += SliderControl1_ImageSelected;
        }

        private void CheckModel3DExists(int organId)
        {
            try
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM model3d
                    WHERE organ_id = @organId";

                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);
                    modelExists = (long)command.ExecuteScalar() > 0;

                    notFoundLabel.Visible = !modelExists;
                    btnConstruct.Visible = !modelExists;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking model3d existence: {ex.Message}");
            }
        }

        private void LoadInfoPanel(int donorId, int organId)
        {
            InfoPanel InfoPanel = new InfoPanel(donorId, organId);

            InfoPanel.Dock = DockStyle.Fill;

            InfoPanel.SizeChanged += InfoPanel_SizeChanged;

            donorInfoPanel.Controls.Add(InfoPanel);

            AdjustDonorInfoPanelHeight();
        }

        private void LoadSlicePanel(int donorId, int organId)
        {
            // Create MainInterfaceSlicePanel and pass donorId and organId to it
            MainInterfaceSlicePanel slicePanel = new MainInterfaceSlicePanel(donorId, organId);

            slicePanel.PictureBoxClicked += SlicePanel_PictureBoxClicked;

            // Set attributes
            slicePanel.Dock = DockStyle.Fill;

            organSlicePanel.Controls.Add(slicePanel);
        }

        private void InfoPanel_SizeChanged(object sender, EventArgs e)
        {
            AdjustDonorInfoPanelHeight();
        }

        private void AdjustDonorInfoPanelHeight()
        {
            int totalHeight = 0;

            // Calculate total height
            foreach (Control ctrl in donorInfoPanel.Controls)
            {
                totalHeight += ctrl.Height;
            }

            // Set the height of donorInfoPanel as total height
            donorInfoPanel.Height = totalHeight;

            donorInfoPanel.Refresh();
        }

        private void SlicePanel_PictureBoxClicked(System.Drawing.Image selectedImage, string additionalInfo)
        {
            slicePicture.Image = selectedImage;
            donorInfoPanel.Controls.OfType<InfoPanel>().FirstOrDefault().SetDescription(additionalInfo);
            notFoundLabel.Visible = false;
            btnConstruct.Visible = false;
            btnBack3D.Visible = true;
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            CTPanel.Visible = true;

            LoadDICOMFiles(organId);
        }

        private async void LoadDICOMFiles(int organId)
        {
            dicomImages = new List<System.Drawing.Image>();

            try
            {
                string dicomQuery = @"
                    SELECT dicom_path 
                    FROM dicomfile 
                    WHERE organ_id = @organId
                    ORDER BY dicom_id";

                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(dicomQuery, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string dicomPath = reader.GetString(0);

                            if (System.IO.File.Exists(dicomPath))
                            {
                                try
                                {
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

                if (dicomImages.Count > 0)
                {
                    DICOMFilePicture.Image = dicomImages[0];

                    sliderControl1.NumberOfImages = dicomImages.Count;
                    sliderControl1.SetSelectedIndex(0);
                }
                else
                {
                    MessageBox.Show("No DICOM files found for the specified organ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading DICOM files: {ex.Message}");
            }
        }

        private void SliderControl1_ImageSelected(object sender, int index)
        {
            if (index >= 0 && index < dicomImages.Count)
            {
                DICOMFilePicture.Image = dicomImages[index];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CTPanel.Visible = false;
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm == null)
                return;

            List<OrganSlicePanel> organSlicePanels = new List<OrganSlicePanel>();

            // Create and display overlay form
            OverlayForm overlay = new OverlayForm
            {
                Location = parentForm.Location,
                Size = parentForm.Size
            };

            overlay.Show(parentForm);

            // Create 3DModelFormWindow instance
            _3DModelFormWindow modelForm = new _3DModelFormWindow(organId, organSlicePanels)
            {
                StartPosition = FormStartPosition.CenterParent,
                TopMost = true
            };

            modelForm.ConstructClicked += (s, ev) =>
            {
                InsertIntoModel3DTable(organId);

                MessageBox.Show("Model constructed successfully.");

                notFoundLabel.Visible = false;
                btnConstruct.Visible = false;

                // Close the window
                modelForm.Close();
            };

            modelForm.ShowDialog(parentForm);

            overlay.Close();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var parentForm = this.FindForm();

                if (parentForm != null)
                {
                    parentForm.Controls.Clear();

                    var addCaseControl = new AddOrganControl(donorId, organId);

                    parentForm.Controls.Add(addCaseControl);

                    addCaseControl.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurs when clicking update: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm == null)
            {
                MessageBox.Show("The control is not part of a form.");
                return;
            }

            // Create and display overlay form
            OverlayForm overlay = new OverlayForm
            {
                Location = parentForm.Location,
                Size = parentForm.Size
            };
            overlay.Show(parentForm);

            // Create and display DeleteWindow
            using (DeleteWindow deleteWindow = new DeleteWindow())
            {
                deleteWindow.StartPosition = FormStartPosition.CenterParent;
                deleteWindow.TopMost = true;

                deleteWindow.BringToFront();

                if (deleteWindow.ShowDialog(parentForm) == DialogResult.Yes)
                {
                    DeleteOrganRecords(organId);
                }
            }

            overlay.Close();
        }



        private void DeleteOrganRecords(int organId)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                using (var transaction = connection.BeginTransaction())
                {
                    string deleteQuery = @"
                        DELETE FROM dicomfile WHERE organ_id = @organId;
                        DELETE FROM model3d WHERE organ_id = @organId;
                        DELETE FROM sliceimage WHERE organ_id = @organId;
                        DELETE FROM organtag WHERE organ_id = @organId;
                        DELETE FROM organ WHERE organ_id = @organId;";

                    using (var command = new NpgsqlCommand(deleteQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@organId", organId);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting records: {ex.Message}");
            }
        }

        private void btnBack3D_Click(object sender, EventArgs e)
        {
            var infoPanel = donorInfoPanel.Controls.OfType<InfoPanel>().FirstOrDefault();
            if (infoPanel != null)
            {
                infoPanel.CollapsePanels();
            }
            if (modelExists)
            {
                slicePicture.Image = null;
            }
            else
            {
                slicePicture.Image = null;
            }
            donorInfoPanel.Controls.OfType<InfoPanel>().FirstOrDefault().SetDescription("No description yet");
            notFoundLabel.Visible = !modelExists;
            btnConstruct.Visible = !modelExists;
            btnBack3D.Visible = false;
        }
    }
}
