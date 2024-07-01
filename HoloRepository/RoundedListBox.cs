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
        public int BorderRadius { get; set; } = 20;
        private readonly Image deleteButtonImage;
        private const int DeleteButtonSize = 20;
        private const int DeleteButtonMargin = 5;
        private Color lineColor = SystemColors.ControlLight;
        private int lineHeight = 1;

        public RoundedListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;

            string absoluteImagePath = @"C:\Users\10927\source\repos\HoloRepository\HoloRepository\DeleteButton.png";

            if (File.Exists(absoluteImagePath))
            {
                deleteButtonImage = Image.FromFile(absoluteImagePath);
            }
            else
            {
                throw new FileNotFoundException($"DeleteButton.png 文件未找到。路径：{absoluteImagePath}");
            }
        }

        // 重写 OnPaint 以绘制圆角
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // 调用基类的绘制方法

            // 创建圆角路径
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            graphicsPath.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            graphicsPath.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            graphicsPath.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            graphicsPath.CloseFigure();

            // 设置 ListBox 的区域为圆角形状
            Region = new Region(graphicsPath);

            // 填充背景
            using Brush brush = new SolidBrush(BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(brush, graphicsPath);
        }


        // 重写 OnDrawItem 以增加项之间的空间和调整内边距
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // 跳过设计器模式下的绘制
            if (DesignMode || e.Index < 0)
            {
                return;
            }

            if (e.Index >= this.Items.Count)
            {
                return;
            }

            // 获取当前项的文本，并处理可能的 null 值
            object item = this.Items[e.Index];
            string itemText = item?.ToString() ?? string.Empty;

            // 设置文本绘制区域，增加内边距
            Rectangle bounds = e.Bounds;
            bounds.Width -= DeleteButtonSize + DeleteButtonMargin;
            bounds.Inflate(-10, -10); // 调整内边距
            e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), bounds, StringFormat.GenericDefault);

            if (deleteButtonImage != null)
            {
                Rectangle deleteButtonBounds = new Rectangle(
                    e.Bounds.Right - DeleteButtonSize - DeleteButtonMargin,
                    e.Bounds.Top + (e.Bounds.Height - DeleteButtonSize) / 2,
                    DeleteButtonSize, DeleteButtonSize);

                e.Graphics.DrawImage(deleteButtonImage, deleteButtonBounds);
            }

            int lineLength = e.Bounds.Width - 15; // 横线长度

            using (Pen pen = new Pen(lineColor, lineHeight))
            {
                e.Graphics.DrawLine(pen,
                                    e.Bounds.Left + 5, e.Bounds.Bottom - 1,
                                    e.Bounds.Left + 5 + lineLength, e.Bounds.Bottom - 1);
            }
        }

        // 重写 MeasureItem 以调整项的高度
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.ItemHeight = Font.Height + 20; // 增加项的高度
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
                        Items.RemoveAt(i);

                        Invalidate();
                        break;
                    }
                }
            }
        }
    }
}