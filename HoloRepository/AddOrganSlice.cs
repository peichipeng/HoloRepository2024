using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HoloRepository
{
    public partial class AddOrganSlice : Form
    {
        private int donorId;
        private string organName;
        private int sliceIndex;
        private string organSide;

        private List<Image> imageList = new List<Image>();
        public List<Image> ImageList => imageList;
        private SliderControl sliderControl;
        private Panel overlayPanel;
        private const string placeholderText = "Describe additional information about the organ slice ...";
        public Image OrganSliceImage { get; private set; }
        public Image SelectedImage { get; private set; }
        public string Description { get; private set; }

        public int SelectedIndex { get; private set; }

        public event Action<Image, Image, string, int> OrganSliceUpdated;

        public string OrganSliceImagePath { get; private set; }


        public AddOrganSlice(int donorId, string organName, int sliceIndex, string organSide)
        {
            InitializeComponent();
            InitializeOverlayPanel();

            this.donorId = donorId;
            this.organName = organName;
            this.sliceIndex = sliceIndex;

            sliderControl1.Visible = false;
            DICOMFilePicture.Visible = false;

            DescriptionBox.GotFocus += DescriptionBox_GotFocus;
            DescriptionBox.LostFocus += DescriptionBox_LostFocus;
        }

        private void DescriptionBox_GotFocus(object sender, EventArgs e)
        {
            if (DescriptionBox.Text == placeholderText)
            {
                DescriptionBox.Text = "";
            }
        }

        private void DescriptionBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DescriptionBox.Text))
            {
                DescriptionBox.Text = placeholderText;
            }
        }

        public void SetImageList(List<Image> images, int index)
        {
            imageList = images;
            sliderControl1.NumberOfImages = imageList.Count;

            if (imageList.Count > 0)
            {
                DICOMFilePicture.Image = imageList[index >= 0 && index < imageList.Count ? index : 0];
                sliderControl1.SetSelectedIndex(index);
            }
        }

        private void InitializeOverlayPanel()
        {
            overlayPanel = new Panel
            {
                BackColor = Color.FromArgb(128, 255, 255, 255),
                Location = new Point(562, 15),
                Size = new Size(480, 377),
                Visible = true
            };

            overlayPanel.Anchor = AnchorStyles.Top;

            // Click
            overlayPanel.Click += OverlayPanel_Click;

            // Paint
            overlayPanel.Paint += OverlayPanel_Paint;

            Controls.Add(overlayPanel);
            overlayPanel.BringToFront();
        }

        private void OverlayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Border color and width
            Color borderColor = Color.Gray;
            int borderWidth = 2;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int radius = 5;
                int diameter = radius * 2;
                int width = overlayPanel.Width - borderWidth;
                int height = overlayPanel.Height - borderWidth;
                GraphicsPath path = new GraphicsPath();

                path.AddArc(borderWidth / 2, borderWidth / 2, diameter, diameter, 180, 90);
                path.AddArc(width - diameter, borderWidth / 2, diameter, diameter, 270, 90);
                path.AddArc(width - diameter, height - diameter, diameter, diameter, 0, 90);
                path.AddArc(borderWidth / 2, height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                g.DrawPath(pen, path);
            }

            string labelText = "Click on to choose one CT scan to\nmatch the organ slice";
            Font labelFont = new Font("Microsoft YaHei UI", 12.0f, FontStyle.Bold);
            Color labelColor = Color.Gray;

            using (SolidBrush brush = new SolidBrush(labelColor))
            {
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                float lineHeight = labelFont.Height * 1.5f;

                float y = 225;
                RectangleF rect = new RectangleF(20, y, 450, 300);


                string[] lines = labelText.Split(new string[] { "\n" }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length; i++)
                {
                    float lineY = rect.Top + i * lineHeight;
                    RectangleF lineRect = new RectangleF(rect.Left, lineY, rect.Width, lineHeight);
                    g.DrawString(lines[i], labelFont, brush, lineRect, stringFormat);
                }
            }
        }

        private void OverlayPanel_Click(object sender, EventArgs e)
        {
            HideOverlayPanel(0);
        }

        public void HideOverlayPanel(int hideNum)
        {
            // Hide overlay panel
            overlayPanel.Visible = false;

            // Display SliderControl and PictureBox
            sliderControl1.Visible = true;
            DICOMFilePicture.Visible = true;
            if (hideNum == 1)
            {
                OrganSliceDescription.Visible = false;
            }
        }

        private void UpdateSliderControlLayout()
        {
            int sliderWidth = 234;
            int panelWidth = OrganSlicePanel.Width;
            int sliderX = (panelWidth - sliderWidth) / 2;

            sliderControl1.Location = new Point(sliderX, 3);
        }

        private void SliderControl1_ImageSelected(object sender, int index)
        {
            if (index >= 0 && index < imageList.Count)
            {
                DICOMFilePicture.Image = imageList[index];
                SelectedIndex = index;
            }
        }

        public void SetOrganSlice(Image image, string imagePath)
        {
            OrganSlicePicture.SizeMode = PictureBoxSizeMode.Zoom;
            OrganSlicePicture.Image = image;
            OrganSliceImagePath = imagePath;
        }

        public void SetDescription(string description)
        {
            DescriptionBox.Text = description;
        }

        public void SetFormTitle(string title)
        {
            this.Text = title;
        }


        public void ChangeButtonText(string text)
        {
            Add.Text = text;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (OrganSlicePicture.Image == null)
            {
                MessageBox.Show("Please select an organ slice first");
                return;
            }

            try
            {
                // Set the OrganSliceImage and other properties
                OrganSliceImage = OrganSlicePicture.Image;
                SelectedImage = DICOMFilePicture.Image;
                Description = DescriptionBox.Text;
                SelectedIndex = imageList.IndexOf(DICOMFilePicture.Image);

                // Define the new directory path
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string dataDirectory = @"data"; // Relative path for storing images
                string donorDirectory = Path.Combine(baseDirectory, dataDirectory, donorId.ToString());

                // Ensure the directories exist
                if (!Directory.Exists(donorDirectory))
                {
                    Directory.CreateDirectory(donorDirectory);
                }

                string organDirectory = Path.Combine(donorDirectory, organName);
                if (!Directory.Exists(organDirectory))
                {
                    Directory.CreateDirectory(organDirectory);
                }

                if (!string.IsNullOrEmpty(organSide))
                {
                    organDirectory = Path.Combine(organDirectory, organSide);
                    if (!Directory.Exists(organDirectory))
                    {
                        Directory.CreateDirectory(organDirectory);
                    }
                }

                // Define the new file name
                string newFileName = $"{donorId}-{organName}-{sliceIndex:D4}-{DateTime.Now:yyyyMMdd}.jpg";
                string destinationFilePath = Path.Combine(organDirectory, newFileName);

                // Copy the image to the new location
                if (!string.IsNullOrEmpty(OrganSliceImagePath))
                {
                    File.Copy(OrganSliceImagePath, destinationFilePath, true); // true to overwrite if exists

                    string relativePath = Path.GetRelativePath(baseDirectory, destinationFilePath);
                    OrganSliceImagePath = relativePath; // Update to relative path
                }

                OrganSliceUpdated?.Invoke(OrganSliceImage, SelectedImage, Description, SelectedIndex);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when saving the picture: {ex.Message}");
            }
        }

        private void OrganSlicePicture_Click(object sender, EventArgs e)
        {
            // Define the directory path and date format
            string directoryPath = @"C:\Users\linqing.zhao\Desktop\Pictures";
            string datePrefix = DateTime.Now.ToString("yyyy_MM_dd"); // Use current date
            string filePattern = $"{datePrefix}_*.jpg";

            try
            {
                // Get all files matching the pattern in the directory
                string[] files = Directory.GetFiles(directoryPath, filePattern);

                if (files.Length == 0)
                {
                    MessageBox.Show("No images found with the specified pattern.");
                    return;
                }

                // Extract numerical suffix and find the file with the maximum suffix
                string maxFilePath = files
                    .Select(f => new { FilePath = f, Number = GetImageNumber(Path.GetFileNameWithoutExtension(f)) })
                    .OrderByDescending(f => f.Number)
                    .FirstOrDefault()?.FilePath;

                if (maxFilePath != null)
                {
                    // Load and display the selected image
                    Image selectedImage = new Bitmap(maxFilePath);
                    OrganSlicePicture.Image = selectedImage;
                    OrganSliceImagePath = maxFilePath;

                    OrganSlicePicture.SizeMode = PictureBoxSizeMode.Zoom;
                    OrganSliceDescription.Visible = false;
                }
                else
                {
                    MessageBox.Show("No suitable images found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }


        // Helper method to extract the numerical suffix from the filename
        private int GetImageNumber(string filename)
        {
            // Assumes filename format: yyyy_MM_dd_XXXX
            string[] parts = filename.Split('_');
            if (parts.Length > 3 && int.TryParse(parts[3], out int number))
            {
                return number;
            }
            return -1; // Return -1 if parsing fails
        }
    }

}