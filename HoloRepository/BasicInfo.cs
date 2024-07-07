using HoloRepository.CasePageControls;
using HoloRepository.CasePageControls.Footer;
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
    public partial class BasicInfo : UserControl
    {
        public BasicInfo()
        {
            InitializeComponent();
            AddDonorInfo addDonorInfo = new AddDonorInfo();
            addContent(addDonorInfo);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void BasicInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addContent(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentContainer.Controls.Clear();
            contentContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void addFooter(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            footerContainer.Controls.Clear();
            footerContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            //nextBtn.Visible = false;
            //saveBtn.Visible = true;
            if (nextBtn.Text == "Next")
            {
                nextBtn.Text = "Save";
                addSliceBtn caseOverview = new addSliceBtn();
                addContent(caseOverview);

            }
        }
    }
}
