using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HoloRepository
{
    public class RoundedButton : Button
    {
        // 属性：圆角半径
        public int BorderRadius { get; set; } = 15;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 创建圆角路径
            GraphicsPath graphicsPath = new();
            graphicsPath.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            graphicsPath.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            graphicsPath.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            graphicsPath.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            graphicsPath.CloseFigure();

            // 设置按钮区域为圆角路径
            Region = new Region(graphicsPath);

            // 绘制按钮背景
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, graphicsPath);
            }

            // 绘制按钮文本
            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // 不绘制背景，以避免闪烁
        }
    }
}