using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HoloRepository.ContextMenu
{
    class MenuRenderer : ToolStripProfessionalRenderer
    {
        public Color leftColumnColor;

        public MenuRenderer() : base(new MenuColorTable())
        {
            //leftColumnColor = SystemColors.Control;
        }
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                // Fill the background with the specified color when the item is selected
                e.Graphics.FillRectangle(new SolidBrush(Color.Gainsboro), e.Item.ContentRectangle);
            }
            else
            {
                // Use the default background color when the item is not selected
                base.OnRenderMenuItemBackground(e);
            }
        }

        // still need to modify this
        /*
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 10;
                Rectangle rect = new Rectangle(Point.Empty, e.ToolStrip.Size);
                path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                e.Graphics.DrawPath(new Pen(Color.LightGray, 2), path);
            }
        }*/
    }
}
