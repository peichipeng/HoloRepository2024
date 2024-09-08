using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HoloRepository
{
    [ToolboxItem(true)]
    public class ShadowPanel : Panel
    {
        private int borderRadius = 10;
        private int borderWidth = 2;
        private Color borderColor = Color.Black;

        public ShadowPanel()
        {
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            this.Padding = new Padding(10);
            this.SetStyle(ControlStyles.Opaque, true);
        }

        [Category("Appearance")]
        [Description("The radius of the border corners.")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The width of the border.")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; Invalidate(); }
        }

        [Category("Appearance")]
        [Description("The color of the border.")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 调整圆角半径以防止失真
            int adjustedRadius = Math.Min(borderRadius, Math.Min(ClientRectangle.Width, ClientRectangle.Height) / 2);

            // 绘制带圆角的矩形
            Rectangle rect = this.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            GraphicsPath path = GetRoundedRectanglePath(rect, adjustedRadius);

            // 清除外部区域（使外部透明）
            Region = new Region(path);
            g.Clear(Parent.BackColor); // 用父控件的背景颜色清除外部区域

            // 填充Panel背景（仅限圆角内部区域）
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillPath(brush, path);
            }

            // 绘制边框
            if (borderWidth > 0)
            {
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    pen.Alignment = PenAlignment.Inset;
                    g.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            GraphicsPath path = new GraphicsPath();

            // 左上角的弧形
            path.AddArc(arc, 180, 90);

            // 右上角的弧形
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // 右下角的弧形
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // 左下角的弧形
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
