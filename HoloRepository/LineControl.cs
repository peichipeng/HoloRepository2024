using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public class LineControl : Control
    {
        private Color lineColor = Color.Black; // Default line color
        private int lineWidth = 1; // Default line width

        public LineControl()
        {
            DoubleBuffered = true;
        }

        // Line color
        public Color LineColor
        {
            get { return lineColor; }
            set
            {
                lineColor = value;
                Invalidate();
            }
        }

        // Line width
        public int LineWidth
        {
            get { return lineWidth; }
            set
            {
                lineWidth = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // using line width and color to paint the line
            using (Pen pen = new Pen(lineColor, lineWidth))
            {
                e.Graphics.DrawLine(pen, 0, Height / 2, Width, Height / 2);
            }
        }
    }
}