using ComponentFactory.Krypton.Toolkit;
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
        private string accessedFrom; // This variable is for the cancel button
        public string destination;

        // This constructor is for adding a case
        public AddCaseFramework(string route, string destination)
        {
            this.accessedFrom = route;
            this.destination = destination;
            InitializeComponent();
            donorInfoPage = new DonorInfo();
            LoadControl(donorInfoPage);
        }

        public AddCaseFramework(string route, string destination, int data)
        {
            this.accessedFrom = route;
            this.destination = destination;
            InitializeComponent();
            if (destination == "caseOverview")
            {
                //HideFooterBtns();
                LoadControl(new CaseOrganFramework(destination, data));
            }
        }

        public void ShowFooterBtns()
        {
            nextBtn.Visible = true;
            cancelBtn.Visible = true;
            nextBtn.Text = "Save";
        }

        public void HideFooterBtns()
        {
            nextBtn.Visible = false;
            cancelBtn.Visible = false;
        }

        public void LoadControl(UserControl userControl)
        {
            addCaseContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            addCaseContainer.Controls.Add(userControl);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (addCaseContainer.Controls[0] is DonorInfo donorInfoPage)
            {
                if (donorInfoPage.ValidateAndConvertData())
                {
                    if (donorInfoPage.title.Text == "Add Donor's Basic")
                    {
                        donorInfoPage.AddDonorInfo(); // If on the add info page, insert the record into the database
                        nextBtn.Text = "Save";
                    }
                    else
                    {
                        donorInfoPage.UpdateDonorInfo();
                    }
                    /*
                    int donorId = donorInfoPage.donorId;
                    if (accessedFrom == "viewCases")
                    {
                        LoadControl(new CaseOrganFramework("caseOverview", donorId));
                    }
                    else
                    {
                        LoadControl(new CaseOrganFramework("addCase", donorId));
                        nextBtn.Text = "save";
                    }*/
                }
                /*
                Dictionary<string, string> donorInfo = new Dictionary<string, string>
                {
                    {"id", donorInfoPage.donorIdTxt.Text },
                    {"dod", donorInfoPage.dodTxt.Text},
                    {"age", donorInfoPage.ageTxt.Text},
                    {"causeOfDeath", donorInfoPage.causeOfDeathTxt.Text}
                };
                if (donorInfoPage.title.Text == "Add Donor's Basic")
                {
                    MessageBox.Show("add");
                }
                else
                {
                    MessageBox.Show("update");
                }
                // If the update donor information page is loaded from the case overview page
                if (accessedFrom == "viewCases")
                {
                    LoadControl(new CaseOrganFramework("caseOverview", donorInfo));
                    HideFooterBtns();
                } else
                {
                    LoadControl(new CaseOrganFramework("addCase", donorInfo));
                    nextBtn.Text = "save";
                }*/

            }
            else if (addCaseContainer.Controls[0] is CaseOrganFramework caseOrganPage)
            {
                if (caseOrganPage.pageNameLabel.Text == "Add a Case")
                {
                    if (this.Parent.Parent is HomePage homePage)
                    {
                        homePage.LoadControl(new ViewCasesControl());
                    }
                }
            }
        }

        public string InspectControls()
        {
            string userControls = string.Empty;

            foreach (Control control in addCaseContainer.Controls)
            {
                userControls += control.Name;
            }
            return userControls;
        }
    }
}
