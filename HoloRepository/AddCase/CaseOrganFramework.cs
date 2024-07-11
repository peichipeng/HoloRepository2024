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
    public partial class CaseOrganFramework : UserControl
    {
        public CaseOrganFramework(string name, Dictionary<string, string> donorInfo)
        {
            InitializeComponent();
            // pageName.Text = name;
            if (name == "case")
            {
                pageNameLabel.Text = "Add a Case";
                caseNoLabel.Text = $"Case {donorInfo["id"]}";
                LoadControl(new CaseView(donorInfo));
            }
        }
        private void LoadControl(UserControl userControl)
        {
            caseOrganContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            caseOrganContainer.Controls.Add(userControl);
        }
    }
}
