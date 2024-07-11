using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace HoloRepository
{
    public class RoundedListBox : ListBox
    {
        public event EventHandler<string> ImageDeleted;
        public int BorderRadius { get; set; } = 20;
        private readonly Image deleteButtonImage;
        private const int DeleteButtonSize = 20;
        private const int DeleteButtonMargin = 5;
        private Color lineColor = SystemColors.ControlLight;
        private int lineHeight = 1;

        public RoundedListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;

            // Get the base directory of the application source
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            // Construct the full path to the image file
            string absoluteImagePath = Path.Combine(projectDirectory, "DeleteButton.png");

            if (File.Exists(absoluteImagePath))
            {
                deleteButtonImage = Image.FromFile(absoluteImagePath);
            }
            else
            {
                throw new FileNotFoundException($"DeleteButton.png not found, path is {absoluteImagePath}");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            graphicsPath.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            graphicsPath.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            graphicsPath.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            graphicsPath.CloseFigure();

            Region = new Region(graphicsPath);

            using Brush brush = new SolidBrush(BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brush, graphicsPath);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (DesignMode || e.Index < 0)
            {
                return;
            }

            if (e.Index >= this.Items.Count)
            {
                return;
            }

            object item = this.Items[e.Index];
            string itemText = item?.ToString() ?? string.Empty;

            Rectangle bounds = e.Bounds;
            bounds.Width -= DeleteButtonSize + DeleteButtonMargin;
            bounds.Inflate(-10, -10);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                using (Brush brush = new SolidBrush(SystemColors.Highlight))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }
            else
            {
                using (Brush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }

            e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), bounds, StringFormat.GenericDefault);

            if (deleteButtonImage != null)
            {
                Rectangle deleteButtonBounds = new Rectangle(
                    e.Bounds.Right - DeleteButtonSize - DeleteButtonMargin,
                    e.Bounds.Top + (e.Bounds.Height - DeleteButtonSize) / 2,
                    DeleteButtonSize, DeleteButtonSize);

                e.Graphics.DrawImage(deleteButtonImage, deleteButtonBounds);
            }

            int lineLength = e.Bounds.Width - 15;

            using (Pen pen = new Pen(lineColor, lineHeight))
            {
                e.Graphics.DrawLine(pen,
                                    e.Bounds.Left + 5, e.Bounds.Bottom - 1,
                                    e.Bounds.Left + 5 + lineLength, e.Bounds.Bottom - 1);
            }
        }


        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.ItemHeight = Font.Height + 20;
            }
            base.OnMeasureItem(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    Rectangle deleteButtonBounds = new Rectangle(
                        ClientRectangle.Width - DeleteButtonSize - DeleteButtonMargin,
                        GetItemRectangle(i).Top + (GetItemRectangle(i).Height - DeleteButtonSize) / 2,
                        DeleteButtonSize, DeleteButtonSize);

                    if (deleteButtonBounds.Contains(e.Location))
                    {
                        string deletedImagePath = (string)Items[i];
                        ImageDeleted?.Invoke(this, deletedImagePath);

                        Items.RemoveAt(i);

                        Invalidate();
                        break;
                    }
                }
            }
        }
    }
}