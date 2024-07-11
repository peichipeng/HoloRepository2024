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
    public partial class CaseView : UserControl
    {
        public CaseView(Dictionary<string, string> donorInfo)
        {
            InitializeComponent();
            ageLabel.Text = donorInfo["age"];
            idLabel.Text = donorInfo["id"];
            causeOfDeathLabel.Text = donorInfo["causeOfDeath"];
            dodLabel.Text = donorInfo["dod"];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> donorInfo = new Dictionary<string, string>
            {
                {"id", idLabel.Text },
                {"dod", dodLabel.Text},
                {"age", ageLabel.Text},
                {"causeOfDeath", causeOfDeathLabel.Text}
            };
            //MessageBox.Show(this.Parent.Parent.Parent.Name);
            Control addCaseContainer = this.Parent?.Parent?.Parent;
            UserControl updateDonorInfo = new DonorInfo(donorInfo);
            updateDonorInfo.Dock = DockStyle.Fill;

            var container = addCaseContainer as Panel;
            container.Controls.Clear();
            container.Controls.Add(updateDonorInfo);
        }

        private void updateBtn_MouseEnter(object sender, EventArgs e)
        {
            updateBtn.BackColor = Color.Gainsboro;
        }

        private void updateBtn_MouseLeave(object sender, EventArgs e)
        {
            updateBtn.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrganPanel organPanel = new OrganPanel("kidney");
            flowLayoutPanel1.Controls.Add(organPanel);
        }
    }
}
