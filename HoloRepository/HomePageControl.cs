using HoloRepository.AddCase;
using HoloRepository.UserGuide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class HomePageControl : UserControl
    {
        private MainForm mainForm;

        public HomePageControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.Parent?.Parent is MainForm mainForm)
            {
                this.mainForm = mainForm;
                mainForm.OnTranscriptionReceived += OnTranscriptionReceived;
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.OnTranscriptionReceived -= OnTranscriptionReceived;
            }
            base.OnHandleDestroyed(e);
        }

        private void OnTranscriptionReceived(string transcription)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ProcessVoiceCommand), transcription);
            }
            else
            {
                ProcessVoiceCommand(transcription);
            }
        }

        public void LoadControl(UserControl userControl)
        {
            if (this.Parent?.Parent is MainForm mainForm)
            {
                mainForm.LoadControl(userControl);
            }
        }

        public void AddControl(UserControl userControl)
        {
            if (this.Parent?.Parent is MainForm mainForm)
            {
                mainForm.AddControl(userControl);
            }
        }

        private void addCaseBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
        }

        private void viewCasesBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewCasesControl());
        }

        private void organArchiveBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new OrganArchiveControl());
        }

        private void userGuideBtn_Click(object sender, EventArgs e)
        {
            AddControl(new UserGuideHome());
        }

        private void tempBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
        }

        private void btnUpdateOrgan_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseControl(12, 51));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new MainInterFaceControl(this, 123456, 18));
        }

        private void HomePageControl_Load(object sender, EventArgs e)
        {

        }

        public void ProcessVoiceCommand(string transcription)
        {
            if (transcription.ToLower().Contains("add a case"))
            {
                addCaseBtn_Click(this, EventArgs.Empty);
            }
            else if (transcription.ToLower().Contains("view cases"))
            {
                viewCasesBtn_Click(this, EventArgs.Empty);
            }
            else if (transcription.ToLower().Contains("organ archive"))
            {
                organArchiveBtn_Click(this, EventArgs.Empty);
            }
            else if (transcription.ToLower().Contains("user guide"))
            {
                userGuideBtn_Click(this, EventArgs.Empty);
            }
        }
    }
}
