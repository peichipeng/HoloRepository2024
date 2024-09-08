using System;
using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class VoiceControl : UserControl
    {
        public VoiceControl()
        {
            InitializeComponent();

            GlobalStateManager.Instance.OnModeChanged += UpdateUI;
            UpdateUI(GlobalStateManager.Instance.IsKeyboard);
        }

        private void keyboardPicture_Click(object sender, EventArgs e)
        {
            ToggleMode();
        }

        private void voicePicture_Click(object sender, EventArgs e)
        {
            ToggleMode();
        }

        private void ToggleMode()
        {
            GlobalStateManager.Instance.IsKeyboard = !GlobalStateManager.Instance.IsKeyboard;
        }

        public void UpdateUI(bool isKeyboard)
        {
            if (isKeyboard)
            {
                keyboardPicture.Image = Properties.Resources.keyboard_blue;
                voicePicture.Image = Properties.Resources.microphone_gray;
            }
            else
            {
                keyboardPicture.Image = Properties.Resources.keyboard_gray;
                voicePicture.Image = Properties.Resources.microphone_red;
            }
        }
    }
}
