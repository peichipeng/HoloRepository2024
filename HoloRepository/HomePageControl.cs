using HoloRepository.AddCase;
using HoloRepository.UserGuide;
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

        public void AddControl(UserControl userControl)
        {
            if (this.Parent.Parent is MainForm mainForm)
            {
                mainForm.AddControl(userControl);
            }
        }

        public void addCaseBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
            //LoadControl(new AddCaseControl());
        }

        public void viewCasesBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewCasesControl());
        }

        public void organArchiveBtn_Click(object sender, EventArgs e)
        {

        }

        public void userGuideBtn_Click(object sender, EventArgs e)
        {
            AddControl(new UserGuideHome());
        }

        private void tempBtn_Click(object sender, EventArgs e)
        {
            //LoadControl(new AddCaseFramework("home", "addCase"));
        }
    }
}
