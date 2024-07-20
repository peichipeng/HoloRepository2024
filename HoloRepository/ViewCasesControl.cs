using HoloRepository.AddCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace HoloRepository
{
    public partial class ViewCasesControl : UserControl
    {
        private List<CaseData> cases = new List<CaseData>();

        public ViewCasesControl()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn options = new DataGridViewTextBoxColumn();
            options.Name = "options";
            options.HeaderText = "";
            options.Width = 50;
            caseTable.Columns.Add(options);

            tablePanel.Location = new Point((panel1.Width - tablePanel.Width) / 2, 120);
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

        private void ViewCasesControl_Load(object sender, EventArgs e)
        {
            LoadCaseData();

            foreach (DataGridViewRow row in caseTable.Rows)
            {
                row.Cells["options"].Value = ". . .";
                row.Cells["options"].Style.ForeColor = Color.Gray;
            }
        }

        private async void LoadCaseData()
        {
            var dbConnection = new DatabaseConnection();

            string queryCases = "SELECT * FROM donor";
            var caseReader = dbConnection.ExecuteReader(queryCases);
            while (await caseReader.ReadAsync())
            {
                int donorId = caseReader.GetInt32(0);
                DateTime DOD = caseReader.GetDateTime(2);
                int age = caseReader.GetInt32(1);
                string causeOfDeath = caseReader.GetString(3);
                string organs = "";

                string queryOrgans = $"SELECT organ_id, organ_name_id FROM organ WHERE donor_id = {donorId} ORDER BY organ_id DESC";
                var organReader = dbConnection.ExecuteReader(queryOrgans);

                List<string> organList = new List<string>();

                // Iterate through all the organs from the case
                while (await organReader.ReadAsync())
                {
                    int organId = organReader.GetFieldValue<int>(0);

                    int organNameId;
                    string organName = "";

                    // Check if the organNameId is null
                    if (!organReader.IsDBNull(1))
                    {
                        organNameId = organReader.GetFieldValue<int>(1);

                        // Retrieve the organ name
                        string queryOrganName = $"SELECT organ_name FROM organname WHERE organ_name_id = {organNameId}";
                        var readerName = dbConnection.ExecuteReader(queryOrganName);

                        while (await readerName.ReadAsync())
                        {
                            organName = readerName.GetFieldValue<string>(0);
                            organList.Add(organName);
                        }
                    }
                }

                for (int i = 0; i < organList.Count; i++)
                {
                    if (i != organList.Count - 1)
                    {
                        organs += organList[i] + " / ";
                    }
                    else
                    {
                        organs += organList[i];
                    }
                }
                cases.Add(new CaseData
                {
                    DonorId = donorId,
                    DOD = DOD,
                    Age = age,
                    causeOfDeath = causeOfDeath,
                    organs = organs,
                });
            }
            cases.Reverse(); // Show the recently added case as the first row
            LoadCaseTable();
        }

        private void LoadCaseTable()
        {
            caseDataBindingSource.Clear();
            for (int i = 0; i < 10; i++)
            {
                caseDataBindingSource.Add(cases[i]);
            }
        }

        private void caseTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = ". . .";
                e.CellStyle.ForeColor = Color.Gray;
            }
        }

        private void caseTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the click is on the "options" column
            if (e.ColumnIndex == caseTable.Columns["options"].Index && e.RowIndex >= 0)
            {
                // Show the context menu
                var relativeMousePosition = tablePanel.PointToClient(Cursor.Position);
                caseTable.ContextMenuStrip.Show(caseTable, relativeMousePosition);
                caseTable.ContextMenuStrip.Visible = true;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRow = caseTable.CurrentRow;
            if (currentRow != null)
            {
                var caseData = currentRow.DataBoundItem as CaseData;
                int donorId = caseData.DonorId;

                if (this.Parent.Parent is MainForm homePage)
                {
                    homePage.LoadControl(new AddCaseFramework("viewCases", "caseOverview", donorId));
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentRow = caseTable.CurrentRow;
            if (currentRow != null)
            {
                var caseData = currentRow.DataBoundItem as CaseData;
                int donorId = caseData.DonorId;

                using (var popup = new PopupWindow("Are you sure you want to delete?", this.ParentForm))
                {
                    var result = popup.ShowDialog(this.ParentForm);

                    if (result == DialogResult.Yes)
                    {
                        cases.Remove(caseData);
                        LoadCaseTable();
                        // Code for deleting the case
                        var dbConnection = new DatabaseConnection();

                        string deleteQuery = $"DELETE FROM donor WHERE donor_id = {donorId}";
                        dbConnection.ExecuteNonQuery(deleteQuery);
                    }
                }
            }
        }

        private void caseTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < caseTable.Rows.Count)
            {
                DataGridViewRow row = caseTable.Rows[e.RowIndex];

                if (row.DataBoundItem is CaseData selectedCase)
                {
                    int donorId = selectedCase.DonorId;

                    if (this.Parent.Parent is MainForm homePage)
                    {
                        homePage.LoadControl(new AddCaseFramework("viewCases", "caseOverview", donorId));
                    }

                }
            }
        }
    }
}
