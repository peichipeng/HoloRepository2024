using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public class CustomLabel : Control
    {
        private string[] lines;
        private Font font;
        private Color foreColor;
        private StringFormat stringFormat;

        public CustomLabel()
        {
            lines = new string[0];
            font = new Font("Microsoft YaHei UI", 9.0f, FontStyle.Regular);
            foreColor = Color.Black;
            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        public string[] Lines
        {
            get { return lines; }
            set
            {
                lines = value;
                Refresh();
            }
        }

        public Font CustomFont
        {
            get { return font; }
            set
            {
                font = value;
                Refresh();
            }
        }

        public Color CustomForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (SolidBrush brush = new SolidBrush(foreColor))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    float y = i * (font.Height * 1.5f); // 调整行间距为字体高度的1.5倍
                    RectangleF rect = new RectangleF(0, y, ClientSize.Width, font.Height * 1.5f);

                    e.Graphics.DrawString(lines[i], font, brush, rect, stringFormat);
                }
            }
        }
    }
}