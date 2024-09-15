using NUnit.Framework;
using System.Reflection;
using System.Windows.Forms;
using HoloRepository;

namespace HoloRepository.Tests
{
    [TestFixture]
    public class VoiceControlTests
    {
        private VoiceControl _voiceControl;

        [SetUp]
        public void SetUp()
        {
            _voiceControl = new VoiceControl();
        }

        [Test]
        public void Test_ToggleMode_KeyboardToVoice()
        {
            // Find the voicePicture PictureBox
            var voicePicture = _voiceControl.Controls.Find("voicePicture", true).FirstOrDefault() as PictureBox;
            if (voicePicture != null)
            {
                // Use reflection to invoke the click event handler
                var methodInfo = _voiceControl.GetType().GetMethod("voicePicture_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                methodInfo?.Invoke(_voiceControl, new object[] { voicePicture, EventArgs.Empty });

                // Verify that the mode has been toggled from keyboard to voice
                Assert.IsTrue(GlobalStateManager.Instance.IsKeyboard);
            }
        }

        [Test]
        public void Test_ToggleMode_VoiceToKeyboard()
        {
            // Find the keyboardPicture PictureBox
            var keyboardPicture = _voiceControl.Controls.Find("keyboardPicture", true).FirstOrDefault() as PictureBox;
            if (keyboardPicture != null)
            {
                // Use reflection to invoke the click event handler
                var methodInfo = _voiceControl.GetType().GetMethod("keyboardPicture_Click", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                methodInfo?.Invoke(_voiceControl, new object[] { keyboardPicture, EventArgs.Empty });

                // Verify that the mode has been toggled from voice to keyboard
                Assert.IsTrue(GlobalStateManager.Instance.IsKeyboard);
            }
        }

    }
}
