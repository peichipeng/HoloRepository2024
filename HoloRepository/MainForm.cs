
using HoloRepository.AddCase;

namespace HoloRepository
{
    public partial class MainForm : Form
    {
        private bool isSpeechMode = false;
        public MainForm()
        {
            InitializeComponent();
            LoadControl(new HomePageControl());
        }
        public void LoadControl(UserControl userControl)
        {
            mainContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(userControl);
        }
        
        private void mainContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            OnContentChanged();
        }

        public void OnContentChanged()
        {
            // Please don't remove the following code snippet when changing the control. (but can still comment it out)
            if (mainContainer.Controls.Count > 0)
            {
                var control = mainContainer.Controls[0];

                if (control is AddCaseFramework caseFramework)
                {
                    if (caseFramework.addCaseContainer.Controls.Count > 0 &&
                        caseFramework.addCaseContainer.Controls[0] is CasePage casePage &&
                        casePage.pageName == "caseOverview")
                    {
                        modeSwitch.Visible = false;
                    }
                    else
                    {
                        modeSwitch.Visible = true;
                    }
                }
                else if (control is ViewCasesControl || control is HomePageControl)
                {
                    modeSwitch.Visible = true;
                }
                else
                {
                    modeSwitch.Visible = false;
                }
            }
        }

        private void modeSwitch_Click(object sender, EventArgs e)
        {
            isSpeechMode = !isSpeechMode;
            if (isSpeechMode)
            {
                modeSwitch.BackColor = Color.IndianRed;
            } else
            {
                modeSwitch.BackColor = SystemColors.Control;
            }
        }
    }
}
