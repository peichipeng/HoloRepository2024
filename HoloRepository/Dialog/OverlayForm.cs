using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository.Dialog
{
    public class OverlayForm : Form
    {
        public OverlayForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.Black;
            Opacity = 0.5;
            ShowInTaskbar = false;
            TopMost = true;
        }

        public void ShowOverlay(Form owner)
        {
            Bounds = owner.Bounds;
            Owner = owner;
            Show(owner);
        }

        public void HideOverlay()
        {
            Hide();
        }
    }
}
