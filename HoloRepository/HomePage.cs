namespace HoloRepository
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void AddCaseButton_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseControl());
        }

        private void ViewCasesButton_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewCasesControl());
        }

        private void UserGuideButton_Click(object sender, EventArgs e)
        {
            LoadControl(new UserGuideControl());
        }

        private void LoadControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }
    }
}
