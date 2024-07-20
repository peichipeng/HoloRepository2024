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
        public string pageName;
        public int donorId;

        public CaseOrganFramework(string name, int data)
        {
            InitializeComponent();
            this.pageName = name;
            this.donorId = data;
            this.Load += CaseOrganFramework_Load;
        }

        private void CaseOrganFramework_Load(object sender, EventArgs e)
        {
            if (this.pageName == "caseOverview")
            {
                if (Parent.Parent is AddCaseFramework framework)
                {
                    framework.HideFooterBtns();
                }
            }
            LoadControls();
        }

        public void LoadControls()
        {
            // Load the header control
            headerContainer.Controls.Clear();
            UserControl header = new CaseOrganHeader(this.pageName, this.donorId);
            header.Dock = DockStyle.Fill;
            headerContainer.Controls.Add(header);

            // Load content
            UserControl content = new CaseView();
            caseOrganContainer.Controls.Clear();
            content.Dock = DockStyle.Fill;
            caseOrganContainer.Controls.Add(content);
        }
    }
}