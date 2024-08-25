using System;
using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class VoiceControl : UserControl
    {
        private bool isKeyboard = true;
        public event Action<bool>? OnModeChanged;
        public VoiceControl()
        {
            InitializeComponent();
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
            isKeyboard = !isKeyboard;

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

            OnModeChanged?.Invoke(isKeyboard);
        }
    }
}
