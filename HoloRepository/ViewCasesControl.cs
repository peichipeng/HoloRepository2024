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
    public partial class ViewCasesControl : UserControl
    {
        public ViewCasesControl()
        {
            InitializeComponent();
        }

        private void addCaseBtn_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is MainForm homePage)
            {
                homePage.LoadControl(new AddCaseFramework("viewCases", "addCase"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> donorInfo = new Dictionary<string, string>
                    {
                        {"id", "1234" },
                        {"dod", "04/04/2024"},
                        {"age", "34"},
                        {"causeOfDeath", "cancer"}
                    };
            if (this.Parent.Parent is MainForm homePage)
            {
                homePage.LoadControl(new AddCaseFramework("viewCases", "caseOverview", 21));
            }
        }
    }
}
