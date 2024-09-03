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

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HoloRepository
{
    public partial class HomePageControl : UserControl
    {
        public HomePageControl()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                addCaseBtn_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void LoadControl(UserControl userControl)
        {
            if (this.Parent.Parent is MainForm mainForm)
            {
                mainForm.LoadControl(userControl);
            }
        }

        public void AddControl(UserControl userControl)
        {
            if (this.Parent.Parent is MainForm mainForm)
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
            LoadControl(new AddOrganControl(12, 51));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadControl(new MainInterFaceControl(this, 12345, 32));
        }

        private void HomePageControl_Load(object sender, EventArgs e)
        {

        }
    }
}
