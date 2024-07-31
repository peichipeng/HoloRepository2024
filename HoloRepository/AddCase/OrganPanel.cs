using HoloRepository.ContextMenu;
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

namespace HoloRepository.AddCase
{
    public partial class OrganPanel : UserControl
    {
        private int organId;
        private string organName;
        private List<string> organSlices;
        private int imageShown;
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.LightGray;
        public int BorderThickness { get; set; } = 1;
        public OrganPanel(int organId, string name, List<string> organSlices)
        {
            InitializeComponent();

            this.organId = organId;

            if (name == "")
            {
                this.organName = "Unknown";
            }
            else
            {
                this.organName = name;
            }
            this.organSlices = organSlices;

            sliceImages.Controls.Add(leftArrow);
            sliceImages.Controls.Add(rightArrow);
            int leftArrowYPosition = (sliceImages.Height - leftArrow.Height) / 2;
            int rightArrowXPosition = sliceImages.Width - rightArrow.Width;
            leftArrow.Location = new Point(0, leftArrowYPosition);
            rightArrow.Location = new Point(rightArrowXPosition, leftArrowYPosition);

            int X = (sliceImages.Width - placeholderLabel.Width) / 2;
            int Y = (sliceImages.Height - placeholderLabel.Height) / 2;

            placeholderLabel.Location = new Point(X, Y);

            contextMenu.Renderer = new MenuRenderer();

            setOrganPanel();
        }

        private void setOrganPanel()
        {
            organNameLabel.Text = organName;
            organNameLabel.Location = new Point(this.Width / 2 - organNameLabel.Width / 2, 210);
            downArrow.Location = new Point(organNameLabel.Location.X + organNameLabel.Width - 2, 210);

            try
            {
                if (organSlices.Count > 0) // need to add some text if there are no images available
                {
                    placeholderLabel.Visible = false;
                    // Load the image from file path
                    Image image = Image.FromFile(organSlices[0]);

                    // Assign the loaded image to PictureBox
                    sliceImages.Image = image;
                    imageShown = 0;
                }
                else
                {
                    sliceImages.Image = null;
                    placeholderLabel.Visible = true;
                    placeholderLabel.Location = new Point(this.Width / 2 - placeholderLabel.Width / 2, 100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                // Optionally handle the exception here
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 0.8F);

            using (GraphicsPath pathSurface = GetRoundedRectanglePath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetRoundedRectanglePath(rectBorder, BorderRadius - 1F))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
            using (Pen penBorder = new Pen(BorderColor, BorderThickness))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                graphics.DrawPath(penSurface, pathSurface);
                graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // starting at 180 degree angle with the range of travel of 90 degrees
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void leftArrow_MouseEnter(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                leftArrow.BackColor = Color.LightGray;
            }
        }

        private void leftArrow_MouseLeave(object sender, EventArgs e)
        {
            leftArrow.BackColor = Color.Transparent;
        }

        private void rightArrow_MouseEnter(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                rightArrow.BackColor = Color.LightGray;
            }
        }

        private void rightArrow_MouseLeave(object sender, EventArgs e)
        {
            rightArrow.BackColor = Color.Transparent;
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                if (imageShown == 0)
                {
                    imageShown = organSlices.Count - 1;
                }
                else
                {
                    imageShown = imageShown - 1;
                }
                Image image = Image.FromFile(organSlices[imageShown]);
                sliceImages.Image = image;
            }
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                if (imageShown == organSlices.Count - 1)
                {
                    imageShown = 0;
                }
                else
                {
                    imageShown = imageShown + 1;
                }
                Image image = Image.FromFile(organSlices[imageShown]);
                sliceImages.Image = image;
            }
        }

        private void organNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            contextMenu.Show(organNameLabel, e.Location);
        }

        private void downArrow_MouseDown(object sender, MouseEventArgs e)
        {
            contextMenu.Show(downArrow, e.Location);
        }

        // The button for updating the organ
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent is AddCaseFramework caseFramework)
            {
                caseFramework.nextBtn.Text = "Update";

                // The organ ID is available as a field in this class
                caseFramework.LoadControl(new AddCaseControl(12));
            }
        }

        // The button for deleting the organ
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var popup = new PopupWindow("Are you sure you want to delete?", this.ParentForm))
            {
                var result = popup.ShowDialog(this.ParentForm);

                if (result == DialogResult.Yes)
                {
                    this.Parent.Controls.Remove(this);

                    // Code for deleting the organ
                    var dbConnection = new DatabaseConnection();

                    string deleteQuery = $"DELETE FROM organ WHERE organ_id = {organId}";
                    dbConnection.ExecuteNonQuery(deleteQuery);
                }
            }
        }
    }
}
