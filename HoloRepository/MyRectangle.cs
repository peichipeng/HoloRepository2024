using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace HoloRepository
{
    internal class MyRectangle
    {
        private Point location;
        private float radius;
        private GraphicsPath grPath;
        private float x;
        private float y;
        private float width;
        private float height;

        public MyRectangle() { }

        public MyRectangle(float width, float height, float radius, float x = 0f, float y = 0f)
        {
            this.location = new Point(0, 0);
            this.radius = radius;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.grPath = new GraphicsPath();

            if (radius <= 0f)
            {
                this.grPath.AddRectangle(new RectangleF(x, y, width, height));
            }
            else
            {
                float diameter = 2f * radius;
                RectangleF ef = new RectangleF(x, y, diameter, diameter);
                RectangleF ef2 = new RectangleF((width - diameter) - 1f, x, diameter, diameter);
                RectangleF ef3 = new RectangleF(x, (height - diameter) - 1f, diameter, diameter);
                RectangleF ef4 = new RectangleF((width - diameter) - 1f, (height - diameter) - 1f, diameter, diameter);

                this.grPath.AddArc(ef, 180f, 90f);
                this.grPath.AddArc(ef2, 270f, 90f);
                this.grPath.AddArc(ef4, 0f, 90f);
                this.grPath.AddArc(ef3, 90f, 90f);
                this.grPath.CloseAllFigures();
            }
        }

        public GraphicsPath Path => this.grPath;

        public float Radius
        {
            get => this.radius;
            set => this.radius = value;
        }
    }
}
