using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HoloRepository
{
    public partial class CheckTable : UserControl
    {
        private List<CheckTableContent> checkTableContents;
        private DatabaseConnection dbConnection;
        private int? organId;
        private bool internalCheckChange = false;

        public CheckTable(int? organId)
        {
            this.organId = organId;
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
                string query = "SELECT dicom_id, image_path, additional_info FROM sliceimage WHERE organ_id = @organId";
                var parameters = new Dictionary<string, object>
                {
                    { "@organId", organId.Value }
                };

                try
                {
                    using (var reader = dbConnection.ExecuteReader(query, parameters))
                    {
                        while (reader.Read())
                        {
                            int dicomId = reader.GetInt32(0);
                            string imagePath = reader.GetString(1);
                            string additionalInfo = reader.GetString(2);

                            // Load images (assuming imagePath points to a valid image file)
                            Image organSlice = Image.FromFile(imagePath);
                            Image dicomImage = LoadDicomImage(dicomId); // Implement this method to load DICOM image

                            var checkTableContent = new CheckTableContent();
                            checkTableContent.SetImageInfo(organSlice, dicomImage, additionalInfo);
                            checkTableContents.Add(checkTableContent);
                            flowLayoutPanel1.Controls.Add(checkTableContent);

                            // Subscribe to the CheckedChanged event of each CheckBox
                            checkTableContent.SelectBox.CheckedChanged += CheckTableContent_SelectBox_CheckedChanged;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
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

        private Image LoadDicomImage(int dicomId)
        {
            Image CTImage = null;
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
                        CTImage = Image.FromFile(dicomPath);
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
