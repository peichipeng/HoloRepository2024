using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HoloRepository
{
    public class Toggle : Control
    {
        private float diameter;
        private MyRectangle rect;
        private RectangleF circle;
        private bool isOn;
        private float artis;
        private Color borderColor;
        private bool textEnabled;
        private string OnTex = "";
        private string OffTex = "";
        private Color OnCol;
        private Color OffCol;
        private System.Windows.Forms.Timer painTicker = new System.Windows.Forms.Timer();
        public event SliderChangedEventHandler SliderValueChanged;

        public Toggle()
        {
            this.Cursor = Cursors.Hand;
            this.DoubleBuffered = true;
            this.artis = 4f;
            this.diameter = 30f;
            this.textEnabled = true;
            this.rect = new MyRectangle(2f * this.diameter, this.diameter + 2f, this.diameter / 2f, 1f, 1f);
            this.circle = new RectangleF(1f, 1f, this.diameter, this.diameter);
            this.isOn = false;
            this.borderColor = Color.LightGray;
            this.painTicker.Tick += new EventHandler(this.painTicker_Tick);
            this.painTicker.Interval = 1;
            this.OnCol = Color.FromArgb(94, 148, 255);
            this.OffCol = Color.DarkGray;
            this.ForeColor = Color.White;
            this.OnTex = "On";
            this.OffTex = "Off";
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnEnabledChanged(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isOn = !this.isOn;
                this.IsOn = this.isOn;
                base.OnMouseClick(e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            float progress = (this.circle.X - 1) / (this.Width - this.diameter - 2);
            int R = (int)(this.OffCol.R + (this.OnCol.R - this.OffCol.R) * progress);
            int G = (int)(this.OffCol.G + (this.OnCol.G - this.OffCol.G) * progress);
            int B = (int)(this.OffCol.B + (this.OnCol.B - this.OffCol.B) * progress);
            Color currentBackColor = Color.FromArgb(R, G, B);

            if (base.Enabled)
            {
                using (SolidBrush brush = new SolidBrush(currentBackColor))
                {
                    e.Graphics.FillPath(brush, this.rect.Path);
                }
                using (Pen pen = new Pen(this.borderColor, 2f))
                {
                    e.Graphics.DrawPath(pen, this.rect.Path);
                }
                if (this.textEnabled)
                {
                    using (Font font = new Font("Century Gothic", (8.2f * this.diameter) / 30f, FontStyle.Bold))
                    {
                        SolidBrush b = new SolidBrush(this.ForeColor);
                        int height = TextRenderer.MeasureText(this.OnTex, font).Height;
                        float num2 = (this.diameter - height) / 2f;
                        e.Graphics.DrawString(this.OnTex, font, b, 5f, num2 + 1f);
                        height = TextRenderer.MeasureText(this.OffTex, font).Height;
                        num2 = (this.diameter - height) / 2f;
                        e.Graphics.DrawString(this.OffTex, font, b, this.diameter + 2f, num2 + 1f);
                    }
                    using (SolidBrush brush2 = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillEllipse(brush2, this.circle);
                    }
                    using (Pen pen = new Pen(Color.LightGray, 1.2f))
                    {
                        e.Graphics.DrawEllipse(pen, this.circle);
                    }
                }
                else
                {
                    using (SolidBrush brush3 = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillPath(brush3, this.rect.Path);
                        e.Graphics.FillEllipse(brush3, this.circle);
                        e.Graphics.DrawEllipse(Pens.DarkGray, this.circle);
                    }
                }
            }
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.Width = (base.Height - 2) * 2;
            this.diameter = base.Width / 2;
            this.artis = (4f * this.diameter) / 30f;
            this.rect = new MyRectangle(2f * this.diameter, this.diameter + 2f, this.diameter / 2f, 1f, 1f);
            this.circle = new RectangleF(!this.isOn ? 1f : ((base.Width - this.diameter) - 1f), 1f, this.diameter, this.diameter);
            base.OnResize(e);
        }

        private void painTicker_Tick(object sender, EventArgs e)
        {
            float targetX = this.isOn ? (base.Width - this.diameter - 1f) : 1f;
            float direction = this.isOn ? 1f : -1f;
            float newX = this.circle.X + direction * this.artis;

            if ((direction == 1f && newX >= targetX) || (direction == -1f && newX <= targetX))
            {
                newX = targetX;
                this.painTicker.Stop();
            }

            this.circle = new RectangleF(newX, 1f, this.diameter, this.diameter);
            this.Invalidate();
        }

        public bool TextEnabled
        {
            get => this.textEnabled;
            set
            {
                this.textEnabled = value;
                base.Invalidate();
            }
        }

        public bool IsOn
        {
            get => this.isOn;
            set
            {
                this.painTicker.Stop();
                this.isOn = value;
                this.painTicker.Start();
                this.SliderValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public Color BorderColor
        {
            get => this.borderColor;
            set
            {
                this.borderColor = value;
                base.Invalidate();
            }
        }

        protected override Size DefaultSize => new Size(60, 35);

        public delegate void SliderChangedEventHandler(object sender, EventArgs e);

        public string OnText
        {
            get => this.OnTex;
            set
            {
                this.OnTex = value;
                this.Invalidate();
            }
        }

        public string OffText
        {
            get => this.OffTex;
            set
            {
                this.OffTex = value;
                base.Invalidate();
            }
        }

        public Color OnColor
        {
            get => this.OnCol;
            set
            {
                this.OnCol = value;
                base.Invalidate();
            }
        }

        public Color OffColor
        {
            get => this.OffCol;
            set
            {
                this.OffCol = value;
                base.Invalidate();
            }
        }
    }
}