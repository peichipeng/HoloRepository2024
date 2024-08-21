using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FellowOakDicom.Imaging;
using FellowOakDicom;
using Npgsql;
using SixLabors.ImageSharp;

namespace HoloRepository
{
    public partial class CheckTable : UserControl
    {
        private List<CheckTableContent> checkTableContents;
        private DatabaseConnection dbConnection;
        private int? organId;
        private List<OrganSlicePanel> organSlicePanels;
        private bool internalCheckChange = false;

        public CheckTable(int? organId, List<OrganSlicePanel> organSlicePanels)
        {
            this.organId = organId;
            this.organSlicePanels = organSlicePanels;
            InitializeComponent();
            InitializeCustomComponents();
            LoadCheckTableContents();
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (internalCheckChange) return;

            bool isChecked = SelectAll.Checked;
            foreach (var checkTableContent in checkTableContents)
            {
                checkTableContent.SelectBox.Checked = isChecked;
            }
        }

        private void InitializeCustomComponents()
        {
            dbConnection = new DatabaseConnection();
            SelectAll.CheckedChanged += SelectAll_CheckedChanged;
        }

        private void LoadCheckTableContents()
        {
            checkTableContents = new List<CheckTableContent>();

            if (organId.HasValue)
            {
                LoadFromDatabase();
            }
            else
            {
                LoadFromPanels();
            }
        }

        private async Task LoadFromDatabase()
        {
            string query = "SELECT dicom_id, image_path, additional_info FROM sliceimage WHERE organ_id = @organId";
            var parameters = new Dictionary<string, object> { { "@organId", organId.Value } };

            try
            {
                using (var reader = dbConnection.ExecuteReader(query, parameters))
                {
                    while (reader.Read())
                    {
                        int dicomId = reader.GetInt32(0);
                        string imagePath = reader.GetString(1);
                        string additionalInfo = reader.GetString(2);

                        System.Drawing.Image organSlice = System.Drawing.Image.FromFile(imagePath);
                        System.Drawing.Image dicomImage = await LoadDicomImage(dicomId);

                        var checkTableContent = new CheckTableContent();
                        checkTableContent.SetImageInfo(organSlice, dicomImage, additionalInfo);
                        checkTableContent.SetTitle(Path.GetFileName(imagePath));

                        checkTableContents.Add(checkTableContent);
                        flowLayoutPanel1.Controls.Add(checkTableContent);

                        checkTableContent.SelectBox.CheckedChanged += CheckTableContent_SelectBox_CheckedChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from database: " + ex.Message);
            }
        }

        private void LoadFromPanels()
        {
            foreach (var panel in organSlicePanels)
            {
                System.Drawing.Image organSlice = panel.OrganSliceImage;
                System.Drawing.Image dicomImage = panel.DicomImage;
                string additionalInfo = panel.Description;

                var checkTableContent = new CheckTableContent();
                checkTableContent.SetImageInfo(organSlice, dicomImage, additionalInfo);
                checkTableContent.SetTitle(Path.GetFileName(panel.OrganSlicePath));

                checkTableContents.Add(checkTableContent);
                flowLayoutPanel1.Controls.Add(checkTableContent);

                checkTableContent.SelectBox.CheckedChanged += CheckTableContent_SelectBox_CheckedChanged;
            }
        }


        private void CheckTableContent_SelectBox_CheckedChanged(object sender, EventArgs e)
        {
            if (internalCheckChange) return;

            bool allChecked = checkTableContents.All(c => c.SelectBox.Checked);
            bool noneChecked = checkTableContents.All(c => !c.SelectBox.Checked);

            internalCheckChange = true;
            SelectAll.Checked = allChecked;
            internalCheckChange = false;
        }

        private async Task<System.Drawing.Image> LoadDicomImage(int dicomId)
        {
            System.Drawing.Image CTImage = null;
            var connection = dbConnection.GetConnection();

            try
            {
                string query = "SELECT dicom_path FROM dicomfile WHERE dicom_id = @dicomId";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dicomId", dicomId);
                    var result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string dicomPath = result.ToString();
                        if (File.Exists(dicomPath))
                        {
                            try
                            {
                                var dicomFile = await DicomFile.OpenAsync(dicomPath);
                                var dicomImage = new DicomImage(dicomFile.Dataset);

                                using (var imageSharpImage = dicomImage.RenderImage().AsSharpImage())
                                using (var memoryStream = new MemoryStream())
                                {
                                    imageSharpImage.SaveAsBmp(memoryStream);
                                    memoryStream.Seek(0, SeekOrigin.Begin);
                                    CTImage = new Bitmap(memoryStream);
                                }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DICOM image: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return CTImage; // Placeholder
        }

    }
}
