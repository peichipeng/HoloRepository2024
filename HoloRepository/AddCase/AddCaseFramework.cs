using ComponentFactory.Krypton.Toolkit;
using System;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using static HoloRepository.AddOrganControl;

namespace HoloRepository.AddCase
{
    public partial class AddCaseFramework : UserControl
    {
        private DonorInfo donorInfoPage;
        private string accessedFrom; // This variable is for the cancel button
        public string destination;
        private MainForm mainForm;

        private System.Windows.Forms.Timer timer;
        private string currentTranscription;
        private PopupWindow? _currentPopup;

        // This constructor is for adding a case
        public AddCaseFramework(string route, string destination)
        {
            this.accessedFrom = route;
            this.destination = destination;
            InitializeComponent();
            donorInfoPage = new DonorInfo();
            LoadControl(donorInfoPage);

            GlobalEventManager.OnGlobalTranscriptionReceived += OnTranscriptionReceived;
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
            else if (userControl is AddOrganControl addCaseControl)
            {
                // Back event trigger
                addCaseControl.OnCancelConfirmed += () =>
                {
                    LoadControl(new CasePage("caseOverview", addCaseControl.GetDonorID()));
                    panel1.Visible = true;
                };

                addCaseControl.OnSaveCompleted = donorId =>
                {
                    //var caseView = new CaseView { donorId = donorId };
                    //LoadControl(caseView);

                    if (this.destination == "addCase")
                    {
                        LoadControl(new CasePage("addCase", donorId));
                    }
                    else
                    {
                        LoadControl(new CasePage("caseOverview", donorId));
                    }
                    panel1.Visible = true;
                };

                panel1.Visible = false;
            }
            else
            {
                ShowFooterBtns();
            }

            MainForm mainForm = FindMainForm(this);

            if (mainForm != null)
            {
                mainForm.OnContentChanged("case"); // This is for deciding if the microphone should appear
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
            else if (addCaseContainer.Controls[0] is AddOrganControl organPage)
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
            HandleCancelBtn_Click();
        }

        private void HandleCancelBtn_Click()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HandleCancelBtn_Click));
                return;
            }

            MainForm mainForm = (MainForm)Application.OpenForms[0];
            Form? parentForm = this.ParentForm;

            if (parentForm != null)
            {
                _currentPopup = new PopupWindow("Are you sure you want to cancel?", parentForm);
                _currentPopup.FormClosed += Popup_FormClosed;
                GlobalEventManager.OnGlobalTranscriptionReceived += _currentPopup.OnTranscriptionReceived;
                _currentPopup.Show(parentForm);
            }
        }


        private void Popup_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (_currentPopup != null)
            {
                var result = _currentPopup.Result;
                if (result == "Yes")
                {
                    HandleCancelYes();
                }
                else if (result == "No")
                {
                    HandleCancelNo();
                }

                MainForm mainForm = (MainForm)Application.OpenForms[0];
                GlobalEventManager.OnGlobalTranscriptionReceived -= _currentPopup.OnTranscriptionReceived;
                _currentPopup = null;
            }
        }

        public void HandleCancelYes()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HandleCancelYes));
                return;
            }
            GlobalEventManager.OnGlobalTranscriptionReceived -= OnTranscriptionReceived;
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
            }
            else if (addCaseContainer.Controls[0] is CasePage casePage)
            {
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
            }
            else if (addCaseContainer.Controls[0] is AddOrganControl organPage)
            {

            }
        }

        public void HandleCancelNo()
        {
        
        }

        public void ProcessVoiceCommand(string transcription)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ProcessVoiceCommand), transcription);
                return;
            }

            if (this.IsDisposed || !this.IsHandleCreated)
            {
                return;
            }

            transcription = transcription.ToLower().Trim();

            if (transcription.Contains("cancel"))
            {
                HandleCancelBtn_Click();
                return;
            }

            foreach (Control control in addCaseContainer.Controls)
            {
                if (control is AddOrganControl addCaseControl)
                {
                    if (transcription.Contains("save"))
                    {
                        addCaseControl.ProcessVoiceCommand(transcription);
                        return;
                    }
                }
            }

            if (nextBtn.Text.Equals("&Save", StringComparison.OrdinalIgnoreCase))
            {
                if (transcription.Contains("save"))
                {
                    MainForm mainForm = (MainForm)Application.OpenForms[0];
                    mainForm.StopNER();
                    nextBtn_Click(this, EventArgs.Empty);
                    return;
                }
            }
            else if (nextBtn.Text.Equals("&Next", StringComparison.OrdinalIgnoreCase))
            {
                if (transcription.Contains("next"))
                {
                    MainForm mainForm = (MainForm)Application.OpenForms[0];
                    mainForm.StopNER();
                    nextBtn_Click(this, EventArgs.Empty);
                    return;
                }
            }

            if (_currentPopup != null)
            {
                if (transcription.Contains("yes"))
                {
                    _currentPopup.SetResult("Yes");
                    if (_currentPopup.InvokeRequired)
                    {
                        _currentPopup.Invoke(new Action(() =>
                        {
                            _currentPopup.Refresh();
                            _currentPopup.Close();
                        }));
                    }
                    else
                    {
                        _currentPopup.Refresh();
                        _currentPopup.Close();
                    }

                }
                else if (transcription.Contains("no"))
                {
                    _currentPopup.SetResult("No");
                    if (_currentPopup.InvokeRequired)
                    {
                        _currentPopup.Invoke(new Action(() =>
                        {
                            _currentPopup.Refresh();
                            _currentPopup.Close();
                        }));
                    }
                    else
                    {
                        _currentPopup.Refresh();
                        _currentPopup.Close();
                    }
                }
            }

            foreach (Control control in addCaseContainer.Controls)
            {
                if (control is DonorInfo donorInfoPage)
                {
                    donorInfoPage.ProcessVoiceCommand(transcription);
                }
                else if (control is CasePage casePage)
                {
                    foreach (Control casePageControl in casePage.Controls)
                    {
                        if (casePageControl is Panel panel)
                        {
                            foreach (Control panelControl in panel.Controls)
                            {
                                if (panelControl is CaseView caseView)
                                {
                                    caseView.ProcessVoiceCommand(transcription);
                                }
                            }
                        }
                    }
                }
                else if (control is AddOrganControl addCaseControl)
                {
                    addCaseControl.ProcessVoiceCommand(transcription);
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

        private void OnTranscriptionReceived(string transcription)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(OnTranscriptionReceived), transcription);
                return;
            }
            ProcessVoiceCommand(transcription);
        }

        private void AddCaseFramework_Load(object sender, EventArgs e)
        {

        }
    }
}
