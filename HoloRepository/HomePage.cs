
using HoloRepository.AddCase;

namespace HoloRepository
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void LoadHomePage ()
        {
            mainContainer.Controls.Clear();
        }

        public void LoadControl(UserControl userControl)
        {
            mainContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(userControl);
        }
        private void addCaseBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseControl());
        }
        private void viewCasesBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewCasesControl());
        }
        private void organArchiveBtn_Click(object sender, EventArgs e)
        {

        }
        private void userGuideBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new UserGuideControl());
        }
        private void tempBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
        }
    }
}
