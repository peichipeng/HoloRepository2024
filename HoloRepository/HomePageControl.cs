using HoloRepository.AddCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class HomePageControl : UserControl
    {
        public HomePageControl()
        {
            InitializeComponent();
        }

        public void LoadControl(UserControl userControl)
        {
            if (this.Parent.Parent is MainForm mainForm)
            {
                mainForm.LoadControl(userControl);
            }
        }

        private void addCaseBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseControl(12));
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
            LoadControl(new UserGuideControl());
        }

        private void tempBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
        }

        private void btnUpdateOrgan_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseControl(12, 33));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3DModelFormWindow modelFormWindow = new _3DModelFormWindow(33);
            modelFormWindow.Show();
        }
    }
}
