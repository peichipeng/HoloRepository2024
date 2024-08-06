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
            LoadControl(new CasePage(destination, data));
        }

        public void ShowFooterBtns()
        {
            nextBtn.Visible = true;
            cancelBtn.Visible = true;
            //nextBtn.Text = "Save";
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

            if (userControl is CasePage casePage)
            {
                if (casePage.pageName == "caseOverview")
                {
                    HideFooterBtns();
                }
                else
                {
                    ShowFooterBtns();
                }
            }
            else if (userControl is AddCaseControl)
            {
                panel1.Visible = false;
            }
            else
            {
                ShowFooterBtns();
            }

            MainForm mainForm = FindMainForm(this);

            if (mainForm != null)
            {
                mainForm.OnContentChanged(); // This is for deciding if the microphone should appear
            }
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
                        nextBtn.Text = "Save"; // needs to make sure this happens only if there is no duplicate primary key
                    }
                    else
                    {
                        donorInfoPage.UpdateDonorInfo();
                    }
                }
            }
            else if (addCaseContainer.Controls[0] is CasePage casePage)
            {
                if (casePage.headerContainer.Controls[0] is CaseOrganHeader header)
                {
                    // If on the add a case page
                    if (header.pageNameLabel.Text == "Add a Case")
                    {
                        if (this.Parent.Parent is MainForm homePage)
                        {
                            homePage.LoadControl(new ViewCasesControl());
                        }
                    }
                }
            }
            else if (addCaseContainer.Controls[0] is AddCaseControl organPage)
            {
                // Add the logic here to determine whether the user is on the add or update organ page
                // and add functions to upsert the organ

                // Set the button back to 'save'
                HideFooterBtns();

                // Go back to the previous page (replace the donorId below)
                //LoadControl(new CaseOrganFramework(destination, caseOrganPage.donorId));
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = FindMainForm(this);

            using (var popup = new PopupWindow("Are you sure you want to cancel?", this.ParentForm))
            {

                var result = popup.ShowDialog(this.ParentForm);

                if (result == DialogResult.Yes)
                {
                    // When the user is on the add/ update donor info page
                    if (addCaseContainer.Controls[0] is DonorInfo donorInfoPage)
                    {
                        if (donorInfoPage.title.Text == "Add Donor's Basic")
                        {
                            if (accessedFrom == "home")
                            {
                                mainForm.LoadControl(new HomePageControl());
                            }
                            else if (accessedFrom == "viewCases")
                            {
                                mainForm.LoadControl(new ViewCasesControl());
                            }
                        }
                        else
                        {
                            int originalId = donorInfoPage.originalId;
                            LoadControl(new CasePage(destination, originalId));
                        }
                    } else if (addCaseContainer.Controls[0] is CasePage casePage)
                    {
                        // Remove all the records related to the donor
                        var dbConnection = new DatabaseConnection();

                        string deleteQuery = $"DELETE FROM donor WHERE donor_id = {casePage.donorId}";
                        dbConnection.ExecuteNonQuery(deleteQuery);

                        if (accessedFrom == "home")
                        {
                            mainForm.LoadControl(new HomePageControl());
                        }
                        else if (accessedFrom == "viewCases")
                        {
                            mainForm.LoadControl(new ViewCasesControl());
                        }
                    } else if (addCaseContainer.Controls[0] is AddCaseControl organPage)
                    {

                    }
                }
            }
        }
        private MainForm FindMainForm(Control control)
        {
            while (control != null && !(control is MainForm))
            {
                control = control.Parent;
            }
            return control as MainForm;
        }
    }
}
