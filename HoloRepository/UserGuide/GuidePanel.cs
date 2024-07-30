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

namespace HoloRepository.UserGuide
{
    public partial class GuidePanel : UserControl
    {
        private UserControl guideControl;
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.LightGray;
        public int BorderThickness { get; set; } = 1;

        public GuidePanel(GuidePanelData data)
        {
            InitializeComponent();

            guideControl = data.GuideControl;

            guideTitleLabel.Text = data.GuideTitle;
            guideDescriptionLabel.Text = data.GuideDescription;

            // Get the base directory path of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            DirectoryInfo baseDirInfo = new DirectoryInfo(baseDirectory);
            DirectoryInfo parentDir = baseDirInfo.Parent.Parent.Parent; // Move up three levels

            string imagePath = Path.Combine(parentDir.FullName, "UserGuide", "Icons", data.ImageName);
            Image image = Image.FromFile(imagePath);
            imageContainer.Image = image;
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

        private void GuidePanel_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent is MainForm mainForm)
            {
                mainForm.AddControl(guideControl);
            }
        }
    }
}
