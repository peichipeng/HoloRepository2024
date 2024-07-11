using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HoloRepository
{
    public partial class AddOrganSlice : Form
    {
        private List<Image> imageList = new List<Image>();
        private SliderControl sliderControl;
        private Panel overlayPanel;
        private const string placeholderText = "Describe additional information about the organ slice ...";

        public AddOrganSlice()
        {
            InitializeComponent();
            InitializeOverlayPanel();

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

        public void SetImageList(List<Image> images)
        {
            imageList = images;

            sliderControl1.NumberOfImages = imageList.Count;

            if (imageList.Count > 0)
            {
                DICOMFilePicture.Image = imageList[0];
            }
        }

        private void InitializeOverlayPanel()
        {
            overlayPanel = new Panel
            {
                BackColor = Color.FromArgb(128, 255, 255, 255),
                Location = new Point(562,15),
                Size = new Size(480,377),
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
            // Hide overlay panel
            overlayPanel.Visible = false;

            // Display SliderControl and PictureBox
            sliderControl1.Visible = true;
            DICOMFilePicture.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    imageList.Clear();

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        Image selectedImage;
                        try
                        {
                            selectedImage = new Bitmap(filePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}");
                            continue;
                        }
                        imageList.Add(selectedImage);
                    }

                    sliderControl1.NumberOfImages = imageList.Count;

                    UpdateSliderControlLayout();

                    if (imageList.Count > 0)
                    {
                        ShowImage(imageList[0]);
                    }
                }
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
            }
        }


        private void ShowImage(Image image)
        {
            if (image != null)
            {
                DICOMFilePicture.Image = image;
            }
            else
            {
                MessageBox.Show("Image is null.");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrganSlicePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        Image selectedImage = new Bitmap(filePath);
                        OrganSlicePicture.Image = selectedImage;

                        OrganSlicePicture.SizeMode = PictureBoxSizeMode.Zoom;

                        OrganSliceDescription.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
                else
                {
                    OrganSliceDescription.Visible = true;
                }
            }
        }


    }
}
