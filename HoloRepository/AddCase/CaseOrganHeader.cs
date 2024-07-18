using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace HoloRepository.AddCase
{
    public partial class CaseOrganHeader : UserControl
    {
        private int donorId;
        public CaseOrganHeader(string pageName, int donorId)
        {
            InitializeComponent();

            this.donorId = donorId;
            caseNoLabel.Text = $"Case {donorId}";

            if (pageName == "caseOverview")
            {
                pageNameLabel.Text = "Case Overview";
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width - deleteCaseBtn.Width - 2, 35);
                deleteCaseBtn.Location = new Point(divider.Location.X + divider.Size.Width - deleteCaseBtn.Width, 32);
                deleteCaseBtn.Visible = true;

                /*
                Control parent = this.Parent;
                while (parent != null && !(parent is MainForm))
                {
                    parent = parent.Parent;
                }

                if (parent is MainForm mainForm)
                {
                    mainForm.modeSwitch.Visible = false;
                }*/
            }
            else
            {
                deleteCaseBtn.Visible = false;
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width, 35);
                if (pageName == "addCase")
                {
                    pageNameLabel.Text = "Add a Case";
                } else if (pageName == "addOrgan")
                {
                    pageNameLabel.Text = "Add an Organ";
                } else
                {
                    pageNameLabel.Text = "Update an Organ";
                }
            }

            /*
            if (pageName == "addCase")
            {
                pageNameLabel.Text = "Add a Case";
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width, 35);
            }
            if (pageName == "caseOverview")
            {
                pageNameLabel.Text = "Case Overview";
                caseNoLabel.Location = new Point(divider.Location.X + divider.Size.Width - caseNoLabel.Size.Width - deleteCaseBtn.Width - 2, 35);
                deleteCaseBtn.Location = new Point(divider.Location.X + divider.Size.Width - deleteCaseBtn.Width, 32);
                deleteCaseBtn.Visible = true;
            }*/
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

                    Control parent = this.Parent;
                    while (parent != null && !(parent is MainForm))
                    {
                        parent = parent.Parent;
                    }

                    if (parent is MainForm homePage)
                    {
                        homePage.LoadControl(new ViewCasesControl());
                    }
                }
            }
        }
    }
}
