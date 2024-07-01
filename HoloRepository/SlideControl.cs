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
            SetStyle(ControlStyles.Selectable, true); // 可选中

            // 初始化圆形位置为控件中间
            circleX = (Width - CircleSize) / 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 绘制滑轨
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
            // 绘制圆形
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
                // 检查鼠标是否在圆形内
                int circleY = (Height - CircleSize) / 2;
                Rectangle circleRect = new Rectangle(circleX, circleY, CircleSize, CircleSize);

                if (circleRect.Contains(e.Location))
                {
                    Capture = true; // 捕获鼠标
                    UpdateCirclePosition(e.X); // 更新圆形位置
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left && Capture)
            {
                UpdateCirclePosition(e.X); // 拖动时更新圆形位置
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Capture = false; // 释放鼠标捕获
        }

        private void UpdateCirclePosition(int mouseX)
        {
            // 限制圆形移动范围在滑轨内
            circleX = Math.Max(0, Math.Min(mouseX - CircleSize / 2, Width - CircleSize));
            Invalidate(); // 重新绘制控件
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // 重新计算圆形的位置以确保其在滑轨内
            circleX = Math.Max(0, Math.Min(circleX, Width - CircleSize));
            Invalidate();
        }
    }
}
