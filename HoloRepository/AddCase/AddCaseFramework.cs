using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.AddCase
{
    public partial class AddCaseFramework : UserControl
    {
        private DonorInfo donorInfoPage;
        public AddCaseFramework(string route)
        {
            InitializeComponent();
            donorInfoPage = new DonorInfo();
            LoadControl(donorInfoPage);
        }

        public void LoadControl(UserControl userControl)
        {
            addCaseContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            addCaseContainer.Controls.Add(userControl);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> donorInfo = new Dictionary<string, string>
            {
                {"id", donorInfoPage.donorID.Text },
                {"dod", donorInfoPage.DOD.Text},
                {"age", donorInfoPage.age.Text},
                {"causeOfDeath", donorInfoPage.causeOfDeath.Text}
            };
            LoadControl(new CaseOrganFramework("case", donorInfo)); 
        }
    }
}
