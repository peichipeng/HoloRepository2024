using System;
using System.Drawing;
using System.Windows.Forms;
using Dicom;
using Dicom.Imaging;

namespace HoloRepository
{
    public partial class UserGuideControl : UserControl
    {
        public UserGuideControl()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "DICOM Files|*.dcm",
                Title = "Select a DICOM File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                DisplayDicomImage(filePath);
            }
        }

        private void DisplayDicomImage(string filePath)
        {
            try
            {
                DicomImage dicomImage = new DicomImage(filePath);
                var renderedImage = dicomImage.RenderImage();
                var bitmap = renderedImage.As<Bitmap>();
                pictureBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying DICOM image: {ex.Message}");
            }
        }
    }
}
