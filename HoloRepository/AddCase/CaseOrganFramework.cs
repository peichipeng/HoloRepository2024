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
        public int donorId;

        // The constructor for viewing the case
        public CaseOrganFramework(string name, int data)
        {
            InitializeComponent();
            this.pageName = name;
            this.donorId = data;
            this.Load += CaseOrganFramework_Load;
        }

        private void CaseOrganFramework_Load(object sender, EventArgs e)
        {
            if (this.pageName == "addCase")
            {
                pageNameLabel.Text = "Add a Case";
                caseNoLabel.Text = $"Case {donorId}";
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width, 35);
                LoadControl(new CaseView());
            }
            if (this.pageName == "caseOverview")
            {
                if (Parent.Parent is AddCaseFramework framework)
                {
                    framework.HideFooterBtns();
                }
                pageNameLabel.Text = "Case Overview";
                caseNoLabel.Text = $"Case {donorId}";
                //caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width, 35);
                LoadControl(new CaseView());
            }
        }

        public void LoadControl(UserControl userControl)
        {
            if (userControl is CaseView && this.pageName == "caseOverview")
            {
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width - deleteCaseBtn.Width - 2, 35);
                deleteCaseBtn.Location = new Point(divider.Location.X + divider.Size.Width - deleteCaseBtn.Width, 32);
                deleteCaseBtn.Visible = true;
            }
            else
            {
                deleteCaseBtn.Visible = false;
            }
            caseOrganContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            caseOrganContainer.Controls.Add(userControl);
        }

        private void deleteCaseBtn_Click(object sender, EventArgs e)
        {
            using (var popup = new PopupWindow("Are you sure you want to delete?", this.ParentForm))
            {
                var result = popup.ShowDialog(this.ParentForm);

                if (result == DialogResult.Yes)
                {
                    // Code for deleting the case
                    var dbConnection = new DatabaseConnection();

                    string deleteQuery = $"DELETE FROM donor WHERE donor_id = {donorId}";
                    dbConnection.ExecuteNonQuery(deleteQuery);
                    if (this.Parent.Parent.Parent.Parent is HomePage homePage)
                    {
                        homePage.LoadControl(new ViewCasesControl());
                    }
                }
            }
        }
    }
}
