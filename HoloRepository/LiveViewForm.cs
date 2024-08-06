using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class LiveViewForm : Form
    {
        private IntPtr cameraRef;
        private System.Windows.Forms.Timer liveViewTimer;
        private Bitmap liveViewBitmap;
        private PictureBox liveViewPictureBox;
        private Button captureButton;
        public Image LiveViewImage { get; private set; }
        public string CapturedImagePath { get; private set; }

        public LiveViewForm(IntPtr cameraRef)
        {
            InitializeComponent();
            this.cameraRef = cameraRef;
            InitializeLiveView();
        }

        private void InitializeLiveView()
        {
            uint device = EDSDK.kEdsEvfOutputDevice_PC;
            uint err = EDSDK.EdsSetPropertyData(cameraRef, EDSDK.kEdsPropID_Evf_OutputDevice, 0, sizeof(uint), Marshal.UnsafeAddrOfPinnedArrayElement(new[] { device }, 0));
            if (err != EDSDK.EDS_ERR_OK)
            {
                LogMessage("Failed to set EVF output device: " + err);
                MessageBox.Show("Failed to set EVF output device: " + err);
                return;
            }
            Thread.Sleep(500);

            err = EDSDK.EdsSendCommand(cameraRef, EDSDK.kEdsCameraCommand_StartLiveView, 1);
            if (err != EDSDK.EDS_ERR_OK)
            {
                LogMessage("Failed to start live view: " + err);
                MessageBox.Show("Failed to start live view: " + err);
                return;
            }

            liveViewTimer = new System.Windows.Forms.Timer();
            liveViewTimer.Interval = 100;
            liveViewTimer.Tick += LiveViewTimer_Tick;
            liveViewTimer.Start();
        }

        private void LiveViewTimer_Tick(object sender, EventArgs e)
        {
            LogMessage("LiveViewTimer_Tick triggered");
            IntPtr streamRef;
            uint err = EDSDK.EdsCreateMemoryStream(0, out streamRef);
            if (err != EDSDK.EDS_ERR_OK)
            {
                LogMessage("Failed to create memory stream: " + err);
                MessageBox.Show("Failed to create memory stream: " + err);
                return;
            }

            IntPtr evfImageRef;
            err = EDSDK.EdsCreateEvfImageRef(streamRef, out evfImageRef);
            if (err != EDSDK.EDS_ERR_OK)
            {
                LogMessage("Failed to create EVF image reference: " + err);
                MessageBox.Show("Failed to create EVF image reference: " + err);
                EDSDK.EdsRelease(streamRef);
                return;
            }

            err = EDSDK.EdsDownloadEvfImage(cameraRef, evfImageRef);
            if (err == EDSDK.EDS_ERR_OK)
            {
                LogMessage("EVF image downloaded successfully");
                IntPtr buffer;
                uint bufferSize;
                EDSDK.EdsGetPointer(streamRef, out buffer);
                EDSDK.EdsGetLength(streamRef, out bufferSize);

                byte[] imgData = new byte[bufferSize];
                Marshal.Copy(buffer, imgData, 0, (int)bufferSize);

                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    liveViewBitmap = new Bitmap(ms);
                    liveViewPictureBox.Image = liveViewBitmap;
                }
            }
            else if (err == 41218) // EDS_ERR_OBJECT_NOTREADY
            {
                LogMessage("EVF image not ready, retrying...");
                // Retry logic or delay can be added here
            }
            else
            {
                LogMessage("Failed to download EVF image: " + err);
                MessageBox.Show("Failed to download EVF image: " + err);
            }

            EDSDK.EdsRelease(evfImageRef);
            EDSDK.EdsRelease(streamRef);
        }

        private void LogMessage(string message)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now}: {message}{Environment.NewLine}");
        }


        private void LiveViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (liveViewTimer != null)
            {
                liveViewTimer.Stop();
            }
            EDSDK.EdsSendCommand(cameraRef, EDSDK.kEdsCameraCommand_EndLiveView, 0);
        }
    }
}
