using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HoloRepository.AddCase
{
    public partial class CaseOrganFramework : UserControl
    {
        private string pageName;
        private int passedData;
        public CaseOrganFramework(string name, int data)
        {
            InitializeComponent();
            this.pageName = name;
            this.passedData = data;
            this.Load += CaseOrganFramework_Load;
        }

        private void CaseOrganFramework_Load(object sender, EventArgs e)
        {
            if (this.pageName == "addCase")
            {
                pageNameLabel.Text = "Add a Case";
                caseNoLabel.Text = $"Case {passedData}";
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width, 35);
                LoadControl(new CaseView(passedData));
            }
            if (this.pageName == "caseOverview")
            {
                if (Parent.Parent is AddCaseFramework framework)
                {
                    framework.HideFooterBtns();
                }
                pageNameLabel.Text = "Case Overview";
                caseNoLabel.Text = $"Case {passedData}";
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width, 35);
                LoadControl(new CaseView(passedData));
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
