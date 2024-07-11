using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HoloRepository
{
    public class RoundedPanel : Panel
    {
        private Color borderColor = Color.Gray;
        private int borderWidth = 2;
        private int borderRadius = 5;

        public RoundedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                int diameter = borderRadius * 2;
                int width = ClientSize.Width - 1;
                int height = ClientSize.Height - 1;

                GraphicsPath path = new GraphicsPath();
                path.AddArc(new Rectangle(0, 0, diameter, diameter), 180, 90);
                path.AddArc(new Rectangle(width - diameter, 0, diameter, diameter), 270, 90);
                path.AddArc(new Rectangle(width - diameter, height - diameter, diameter, diameter), 0, 90);
                path.AddArc(new Rectangle(0, height - diameter, diameter, diameter), 90, 90);
                path.CloseFigure();

                g.DrawPath(pen, path);
            }
        }
    }
}