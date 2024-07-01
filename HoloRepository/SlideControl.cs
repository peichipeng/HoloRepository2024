using System;
using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public class SliderControl : Control
    {
        private const int TrackHeight = 8;
        private const int CircleSize = 20;

        private int circleX;
        private Color circleColor = ColorTranslator.FromHtml("#3A8EDC");
        private Color trackColor = SystemColors.ControlDark;
        private Color activeTrackColor = ColorTranslator.FromHtml("#3381CA");

        public SliderControl()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.Selectable, true);

            circleX = (Width - CircleSize) / 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int trackY = (Height - TrackHeight) / 2;
            Rectangle trackRect = new Rectangle(CircleSize / 2, trackY, Width - CircleSize, TrackHeight);

            using (var trackBrush = new SolidBrush(trackColor))
            {
                e.Graphics.FillRectangle(trackBrush, trackRect);
            }

            int circleLeft = circleX + CircleSize / 2;
            int activeTrackWidth = circleLeft - CircleSize / 2;

            if (activeTrackWidth > 0)
            {
                Rectangle activeTrackRect = new Rectangle(CircleSize / 2, trackY, activeTrackWidth, TrackHeight);
                using (var activeTrackBrush = new SolidBrush(activeTrackColor))
                {
                    e.Graphics.FillRectangle(activeTrackBrush, activeTrackRect);
                }
            }

            int circleY = (Height - CircleSize) / 2;
            using (var circleBrush = new SolidBrush(circleColor))
            {
                e.Graphics.FillEllipse(circleBrush, circleX, circleY, CircleSize, CircleSize);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {

                int circleY = (Height - CircleSize) / 2;
                Rectangle circleRect = new Rectangle(circleX, circleY, CircleSize, CircleSize);

                if (circleRect.Contains(e.Location))
                {
                    Capture = true;
                    UpdateCirclePosition(e.X);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left && Capture)
            {
                UpdateCirclePosition(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Capture = false;
        }

        private void UpdateCirclePosition(int mouseX)
        {

            circleX = Math.Max(0, Math.Min(mouseX - CircleSize / 2, Width - CircleSize));
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            circleX = Math.Max(0, Math.Min(circleX, Width - CircleSize));
            Invalidate();
        }
    }
}
