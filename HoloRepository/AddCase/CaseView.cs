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
        private int donorId;
        public CaseView(int donorId)
        {
            InitializeComponent();
            this.donorId = donorId;
            LoadData();
        }

        private async void LoadData()
        {
            var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=HoloRepository";
            var dbConnection = new DatabaseConnection(connectionString);

            string queryInfo = $"SELECT age, date_of_death, cause_of_death FROM donor WHERE donor_id = {donorId}";
            var reader = dbConnection.ExecuteReader(queryInfo);
            while (await reader.ReadAsync())
            {
                ageLabel.Text = reader.GetFieldValue<int>(0).ToString();
                idLabel.Text = donorId.ToString();
                causeOfDeathLabel.Text = reader.GetFieldValue<string>(2);
                dodLabel.Text = reader.GetFieldValue<DateTime>(1).ToString("dd/MM/yyyy");
            }

            string queryOrgans = $"SELECT organ_id, organ_name_id FROM organ WHERE donor_id = {donorId}";
            reader = dbConnection.ExecuteReader(queryOrgans);

            while (await reader.ReadAsync())
            {
                int organId = reader.GetFieldValue<int>(0);
                int organNameId = reader.GetFieldValue<int>(1);
                //MessageBox.Show(organId.ToString() + organNameId.ToString());
                
                // Retrieve the organ name
                string queryOrganName = $"SELECT organ_name FROM organname WHERE organ_name_id = {organNameId}";
                var readerName = dbConnection.ExecuteReader(queryOrganName);
                string organName = "";
                while (await readerName.ReadAsync())
                {
                    organName = readerName.GetFieldValue<string>(0);
                }
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

        private async void LoadOrgans()
        {
            var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=HoloRepository";
            await using var conn = new NpgsqlConnection(connectionString);
            await conn.OpenAsync();

            string query = $"SELECT age, date_of_death, cause_of_death FROM donor WHERE donor_id = {donorId}";
            await using var cmd = new NpgsqlCommand(query, conn);

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                ageLabel.Text = reader.GetFieldValue<int>(0).ToString();
                idLabel.Text = donorId.ToString();
                causeOfDeathLabel.Text = reader.GetFieldValue<string>(2);
                dodLabel.Text = reader.GetFieldValue<DateTime>(1).ToString("dd/MM/yyyy");
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

        private void button1_Click(object sender, EventArgs e)
        {
            //OrganPanel organPanel = new OrganPanel("kidney");
            //flowLayoutPanel1.Controls.Add(organPanel);
        }
    }
}
