using Npgsql;
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
    public partial class CaseView : UserControl
    {
        public int donorId;
        public CaseView()
        {
            InitializeComponent();
            this.donorId = donorId;
            this.Load += CaseView_Load;
        }

        private void CaseView_Load(object sender, EventArgs e)
        {
            if (this.Parent.Parent is CasePage framework)
            {
                this.donorId = framework.donorId;
            }
            LoadData();
        }

        private async void LoadData()
        {
            var dbConnection = new DatabaseConnection();

            string queryInfo = $"SELECT age, date_of_death, cause_of_death FROM donor WHERE donor_id = {donorId}";
            var reader = dbConnection.ExecuteReader(queryInfo);
            while (await reader.ReadAsync())
            {
                ageLabel.Text = reader.GetFieldValue<int>(0).ToString();
                idLabel.Text = donorId.ToString();
                causeOfDeathLabel.Text = reader.GetFieldValue<string>(2);
                dodLabel.Text = reader.GetFieldValue<DateTime>(1).ToString("dd/MM/yyyy");
            }

            string queryOrgans = $"SELECT organ_id, organ_name_id, organ_side FROM organ WHERE donor_id = {donorId} ORDER BY organ_id DESC";
            reader = dbConnection.ExecuteReader(queryOrgans);

            // Iterate through all the organs from the donor
            while (await reader.ReadAsync())
            {
                int organId = reader.GetFieldValue<int>(0);

                string organSide = "";
                if (!reader.IsDBNull(2))
                {
                    organSide = reader.GetFieldValue<string>(2);
                }

                int organNameId;
                string organName = "";
                // Check if the organNameId is null
                if (!reader.IsDBNull(1))
                {
                    organNameId = reader.GetFieldValue<int>(1);

                    // Retrieve the organ name
                    string queryOrganName = $"SELECT organ_name FROM organname WHERE organ_name_id = {organNameId}";
                    var readerName = dbConnection.ExecuteReader(queryOrganName);

                    while (await readerName.ReadAsync())
                    {
                        organName = readerName.GetFieldValue<string>(0);
                    }
                }

                // Specify which side of the organ it is
                if (organSide != "")
                    organName += " - " + organSide;

                // Retrieve the corresponding organ slices
                string queryOrganSlices = $"SELECT image_path FROM sliceimage WHERE organ_id = {organId}";
                var readerSlice = dbConnection.ExecuteReader(queryOrganSlices);
                List<string> sliceList = new List<string>();
                while (await readerSlice.ReadAsync())
                {
                    sliceList.Add(readerSlice.GetFieldValue<string>(0));
                }
                OrganPanel organPanel = new OrganPanel(organId, organName, sliceList);
                flowLayoutPanel1.Controls.Add(organPanel);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> donorInfo = new Dictionary<string, string>
            {
                {"id", idLabel.Text },
                {"dod", dodLabel.Text},
                {"age", ageLabel.Text},
                {"causeOfDeath", causeOfDeathLabel.Text}
            };
            if (this.Parent.Parent.Parent.Parent is AddCaseFramework framework)
            {
                framework.LoadControl(new DonorInfo(donorInfo));
                framework.nextBtn.Text = "Save";
                framework.ShowFooterBtns();
            }
        }

        private void updateBtn_MouseEnter(object sender, EventArgs e)
        {
            updateBtn.BackColor = Color.Gainsboro;
        }

        private void updateBtn_MouseLeave(object sender, EventArgs e)
        {
            updateBtn.BackColor = Color.Transparent;
        }

        // The button for adding an organ
        private void addOrganBtn_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent is AddCaseFramework caseFramework)
            {
                var addCaseControl = new AddCaseControl(donorId);

                caseFramework.LoadControl(addCaseControl);
            }
        }

        public void ProcessVoiceCommand(string transcription)
        {
            transcription = transcription.ToLower().Trim();

            MessageBox.Show(transcription, "transcription");
            if (transcription.Contains("update"))
            {
                updateBtn_Click(this, EventArgs.Empty);
            }
            else if (transcription.Contains("add an organ"))
            {
                addOrganBtn_Click(this, EventArgs.Empty);
            }
        }
    }
}
