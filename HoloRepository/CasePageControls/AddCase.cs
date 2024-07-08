using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.CasePageControls
{
    public partial class AddCase : UserControl
    {
        public event EventHandler<DonorInfoEventArgs> UpdateBtnClicked;
        public AddCase()
        {
            InitializeComponent();
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> donorInfo = new Dictionary<string, string> 
            {
                {"id", idLabel.Text },
                {"dod", dodLabel.Text },
                {"age", ageLabel.Text},
                {"causeOfDeath", causeOfDeathLabel.Text }
            };

            DonorInfoEventArgs args = new DonorInfoEventArgs(donorInfo);

            AddDonorInfo addDonorInfo = new AddDonorInfo();
            addDonorInfo.Dock = DockStyle.Fill;
            //MessageBox.Show($"Parent Control: {this.Parent.Parent.Parent.Name}");
            this.Parent.Parent.Parent.Controls.Add(addDonorInfo);
            addDonorInfo.BringToFront();
            OnUpdateBtnClicked(args);
        }

        protected virtual void OnUpdateBtnClicked(DonorInfoEventArgs e)
        {
            //MessageBox.Show(e.donorInfo["age"]);
            UpdateBtnClicked?.Invoke(this, e);
        }

        private void editBtn_MouseEnter(object sender, EventArgs e)
        {
            updateBtn.BackColor = Color.WhiteSmoke;
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            updateBtn.BackColor = Color.Transparent;
        }
        
    }
    // Define custom eventargs
    public class DonorInfoEventArgs: EventArgs
    {
        public Dictionary<string, string> donorInfo { get; set; }

        public DonorInfoEventArgs(Dictionary<string, string> donorInfo)
        {
            this.donorInfo = donorInfo;
        }
    }
}
