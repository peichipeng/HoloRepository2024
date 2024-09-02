using HoloRepository.AddCase;
using HoloRepository.ContextMenu;
using HoloRepository.ViewCases;
using Microsoft.VisualBasic.Devices;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        private List<CaseData> filteredCasesAll = new List<CaseData>();
        private List<CaseData> filteredCasesByTime = new List<CaseData>();

        private List<ComboBoxItems> comboBoxItems = new List<ComboBoxItems>();

        private int totalPages;
        private int selectedPage = 1;
        private int pageSize = 10;
        private Color selectedPageButtonColor = SystemColors.MenuHighlight;
        private DatabaseConnection dbConnection;
        private MainForm mainForm;

        public ViewCasesControl()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn options = new DataGridViewTextBoxColumn();
            options.Name = "options";
            options.HeaderText = "";
            options.Width = 50;
            caseTable.Columns.Add(options);

            searchBox.AutoSize = false;
            searchBox.Size = new Size(searchBox.Width, addCaseBtn.Height);

            contextMenu.Renderer = new MenuRenderer();

            LoadComboBox();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.Parent?.Parent is MainForm mainForm)
            {
                this.mainForm = mainForm;
                GlobalEventManager.OnGlobalTranscriptionReceived += OnTranscriptionReceived;
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (mainForm != null)
            {
                GlobalEventManager.OnGlobalTranscriptionReceived -= OnTranscriptionReceived;
            }
            base.OnHandleDestroyed(e);
        }

        private void OnTranscriptionReceived(string transcription)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ProcessVoiceCommand), transcription);
            }
            else
            {
                ProcessVoiceCommand(transcription);
            }
        }
        public void ProcessVoiceCommand(string transcription)
        {
            if (transcription.ToLower().Contains("add a case"))
            {
                addCaseBtn_Click(this, EventArgs.Empty);
            }
        }

        private void addCaseBtn_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is MainForm homePage)
            {
                homePage.LoadControl(new AddCaseFramework("viewCases", "addCase"));
            }
        }

        private void ViewCasesControl_Load(object sender, EventArgs e)
        {
            LoadCaseData();
        }

        private void LoadComboBox()
        {
            timeIntervalCmb.Items.Clear();

            // Initialize data
            comboBoxItems.Add(new ComboBoxItems() { ID = "01", TimeInterval = "All", Action = ShowAllData });
            comboBoxItems.Add(new ComboBoxItems() { ID = "02", TimeInterval = "Last 7 days", Action = ShowLast7DaysData });
            comboBoxItems.Add(new ComboBoxItems() { ID = "03", TimeInterval = "Last 30 days", Action = ShowLast30DaysData });

            timeIntervalCmb.DataSource = comboBoxItems;
            timeIntervalCmb.ValueMember = "ID";
            timeIntervalCmb.DisplayMember = "TimeInterval";

            timeIntervalCmb.SelectedValue = "02"; // Select the time range whose ID is 02
        }

        private async void LoadCaseData()
        {
            var dataSource = DataRetrieval.CreateDataSource();

            string queryCases = "SELECT * FROM donor ORDER BY timestamp DESC";

            await using (var caseReader = await DataRetrieval.ExecuteQuery(queryCases, dataSource))
            {
                while (await caseReader.ReadAsync())
                {
                    // Data retrieved from donor table
                    int donorId = caseReader.GetInt32(0);
                    int age = caseReader.GetInt32(1);
                    DateTime DOD = caseReader.GetDateTime(2);
                    string causeOfDeath = caseReader.GetString(3);
                    DateTime accessTime = caseReader.GetDateTime(4);

                    string organs = "";

                    string queryOrgans = $"SELECT organ_id, organ_name_id FROM organ WHERE donor_id = {donorId} ORDER BY organ_id DESC";

                    List<string> organList = new List<string>();

                    await using (var organReader = await DataRetrieval.ExecuteQuery(queryOrgans, dataSource))
                    {
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

                                await using (var nameReader = await DataRetrieval.ExecuteQuery(queryOrganName, dataSource))
                                {
                                    while (await nameReader.ReadAsync())
                                    {
                                        organName = nameReader.GetFieldValue<string>(0);
                                        organList.Add(organName);
                                    }
                                }
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
                        CauseOfDeath = causeOfDeath,
                        Organs = organs,
                        AccessTime = accessTime,
                    });
                }
            }

            filteredCasesAll = cases;
            ShowLast7DaysData();
        }

        private void LoadCaseTable()
        {
            caseDataBindingSource.Clear();

            int endIndex;
            if (totalPages == selectedPage)
            {
                endIndex = filteredCasesByTime.Count;
            }
            else
            {
                endIndex = selectedPage * 10;
            }

            if (totalPages != 0)
            {
                for (int i = (selectedPage - 1) * 10; i < endIndex; i++)
                {
                    caseDataBindingSource.Add(filteredCasesByTime[i]);
                }
            }
        }

        private void LoadPagination()
        {
            totalPages = (int)Math.Ceiling((double)filteredCasesByTime.Count / pageSize);

            paginationPanel.Controls.Clear();

            if (totalPages > 7)
            {
                for (int i = 0; i < 5; i++)
                {
                    var pageBtn = PageNoBtn(i);

                    paginationPanel.Controls.Add(pageBtn);
                }
                paginationPanel.Controls.Add(Ellipsis());
                paginationPanel.Controls.Add(PageNoBtn(totalPages - 1));
            }
            else
            {
                for (int i = 0; i < totalPages; i++)
                {
                    var pageBtn = PageNoBtn(i);

                    paginationPanel.Controls.Add(pageBtn);
                }
            }

            SetSelectedPageBtnColor();
            ResetNavigationArrows();

            int newPaginationXPosition = (panel2.Width - paginationPanel.Width) / 2;

            paginationPanel.Location = new Point(newPaginationXPosition, 10);
        }

        private void pageBtn_Click(object sender, EventArgs e)
        {
            var clickedBtn = (Button)sender;
            string buttonText = clickedBtn.Text;

            if (int.TryParse(buttonText, out selectedPage))
            {
                LoadCaseTable();
            }
            ChangePaginationLayout();
        }

        private void ChangePaginationLayout()
        {
            if (totalPages <= 7)
            {
                SetSelectedPageBtnColor();
                ResetNavigationArrows();
                return;
            }

            paginationPanel.Controls.Clear();

            // There is afterimage here...
            if (selectedPage < 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    var btn = PageNoBtn(i);
                    paginationPanel.Controls.Add(btn);
                }
                paginationPanel.Controls.Add(Ellipsis());
                paginationPanel.Controls.Add(PageNoBtn(totalPages - 1));
            }
            else if (selectedPage > totalPages - 4)
            {
                var btn = PageNoBtn(0);
                paginationPanel.Controls.Add(btn);
                paginationPanel.Controls.Add(Ellipsis());

                for (int i = 2; i < 7; i++)
                {
                    btn = PageNoBtn(totalPages + i - 7);
                    paginationPanel.Controls.Add(btn);
                }
            }
            else
            {
                var btn = PageNoBtn(0);
                paginationPanel.Controls.Add(btn);
                paginationPanel.Controls.Add(Ellipsis());
                for (int i = 2; i > -1; i--)
                {
                    paginationPanel.Controls.Add(PageNoBtn(selectedPage - i));
                }
                paginationPanel.Controls.Add(Ellipsis());
                paginationPanel.Controls.Add(PageNoBtn(totalPages - 1));
            }
            SetSelectedPageBtnColor();
            ResetNavigationArrows();
            /*
            if (previousPage < 5)
            {
                if (nextPage == 5)
                {
                    if (totalPages != 8)
                    {
                        paginationPanel.Controls.RemoveAt(1);
                        var label = EllipsisLabel();
                        paginationPanel.Controls.Add(label);
                        paginationPanel.Controls.SetChildIndex(label, 1);

                        paginationPanel.Controls.RemoveAt(2);
                        var btn = PageNoBtn(5);
                        paginationPanel.Controls.Add(btn);
                        paginationPanel.Controls.SetChildIndex(btn, 4);
                    } else { 
                    }
                    /*
                    for (int i = 2; i < 5; i++)
                    {
                        if (paginationPanel.Controls[i] is Button btn)
                        {
                            string updatedPageNo = (i + 2).ToString();
                            btn.Text = updatedPageNo;
                        }
                    }
                }
                if (nextPage == totalPages)
                {
                    paginationPanel.Controls.RemoveAt(1);
                    var label = EllipsisLabel();
                    paginationPanel.Controls.Add(label);
                    paginationPanel.Controls.SetChildIndex(label, 1);

                    for (int i = 2; i < 6; i++)
                    {
                        paginationPanel.Controls.RemoveAt(i);
                        var btn = PageNoBtn(totalPages + i - 7);
                        paginationPanel.Controls.Add(btn);
                        paginationPanel.Controls.SetChildIndex(btn, i);
                    }
                }
            }*/
        }

        private void SetSelectedPageBtnColor()
        {
            foreach (Control control in paginationPanel.Controls)
            {
                if (control is Button btn)
                {
                    if (btn.Text == $"{selectedPage}")
                    {
                        btn.ForeColor = selectedPageButtonColor;
                    }
                    else
                    {
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void ResetNavigationArrows()
        {
            foreach (Control control in paginationPanel.Controls)
            {
                if (control is PictureBox)
                {
                    paginationPanel.Controls.Remove(control);
                }
            }

            if (selectedPage <= 1)
            {
                greyLeftArrow.Visible = true;

                paginationPanel.Controls.Add(greyLeftArrow);
                paginationPanel.Controls.SetChildIndex(greyLeftArrow, 0);

                blackLeftArrow.Visible = false;
            }
            else
            {
                blackLeftArrow.Visible = true;
                paginationPanel.Controls.Add(blackLeftArrow);
                paginationPanel.Controls.SetChildIndex(blackLeftArrow, 0);

                greyLeftArrow.Visible = false;
            }

            if (totalPages <= 1 || selectedPage == totalPages)
            {
                greyRightArrow.Visible = true;

                paginationPanel.Controls.Add(greyRightArrow);
                paginationPanel.Controls.SetChildIndex(greyRightArrow, paginationPanel.Controls.Count);

                blackRightArrow.Visible = false;
            }
            else
            {
                blackRightArrow.Visible = true;

                paginationPanel.Controls.Add(blackRightArrow);
                paginationPanel.Controls.SetChildIndex(blackRightArrow, paginationPanel.Controls.Count);

                greyRightArrow.Visible = false;
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
                    homePage.AddControl(new AddCaseFramework("viewCases", "caseOverview", donorId));
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
                        filteredCasesAll.Remove(caseData);
                        filteredCasesByTime.Remove(caseData);

                        LoadCaseTable();
                        // Code for deleting the case
                        var dbConnection = new DatabaseConnection();

                        string deleteQuery = $"DELETE FROM donor WHERE donor_id = {donorId}";
                        dbConnection.ExecuteNonQuery(deleteQuery);
                    }
                }
            }
        }

        public Button Ellipsis()
        {
            var ellipsis = new Button
            {
                Text = "...",
                Width = 30,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            ellipsis.FlatStyle = FlatStyle.Flat;
            ellipsis.FlatAppearance.BorderSize = 0;
            ellipsis.Enabled = false;

            return ellipsis;
        }

        public Button PageNoBtn(int index)
        {
            var pageBtn = new Button
            {
                Text = $"{index + 1}",
                Width = 30,
                Height = 30
            };
            pageBtn.FlatStyle = FlatStyle.Flat;
            pageBtn.FlatAppearance.BorderSize = 0;
            pageBtn.Click += pageBtn_Click;

            return pageBtn;
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Cases")
            {
                searchBox.Text = "";
                searchBox.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                searchBox.StateCommon.Content.Color1 = Color.Gray;
                searchBox.Text = "Search Cases";
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = searchBox.Text;

            if (string.IsNullOrEmpty(keyword) || searchBox.StateCommon.Content.Color1 == Color.Gray)
            {
                filteredCasesAll = cases;
            }
            else
            {
                // Split the keyword into groups based on '&', removing any empty or whitespace-only groups
                var groups = keyword.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(g => g.Trim())
                                    .Where(g => !string.IsNullOrEmpty(g));

                filteredCasesAll = cases.Where(c =>
                    // For each group, split further by spaces, removing any empty or whitespace-only terms
                    groups.All(group =>
                    {
                        var terms = group.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(t => t.Trim())
                                         .Where(t => !string.IsNullOrEmpty(t));
                        // Within each group, any term must be present (OR logic)
                        return terms.Any(term =>
                            c.DonorId.ToString().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                            c.DOD.ToString().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                            c.Age.ToString().Contains(term, StringComparison.OrdinalIgnoreCase) ||
                            c.CauseOfDeath.Contains(term, StringComparison.OrdinalIgnoreCase) ||
                            c.Organs.Contains(term, StringComparison.OrdinalIgnoreCase)
                        );
                    })
                ).ToList();

                selectedPage = 1;
            }
            HandleComboBoxSelectionChange();
        }

        private void caseTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = ". . .";
                e.CellStyle.ForeColor = Color.Black;
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
                        homePage.AddControl(new AddCaseFramework("viewCases", "caseOverview", donorId));
                    }

                }
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

        private void blackRightArrow_Click(object sender, EventArgs e)
        {
            selectedPage += 1;
            LoadCaseTable();
            ChangePaginationLayout();
        }

        private void blackLeftArrow_Click(object sender, EventArgs e)
        {
            selectedPage -= 1;
            LoadCaseTable();
            ChangePaginationLayout();
        }

        private void ShowAllData()
        {
            filteredCasesByTime = filteredCasesAll;
            LoadPagination();
            LoadCaseTable();
        }

        private void ShowLast7DaysData()
        {
            FilterCasesByDateRange(DateTime.Now.AddDays(-7));
            LoadPagination();
            LoadCaseTable();
        }

        private void ShowLast30DaysData()
        {
            FilterCasesByDateRange(DateTime.Now.AddDays(-30));
            LoadPagination();
            LoadCaseTable();
        }

        private void FilterCasesByDateRange(DateTime startDate)
        {
            DateTime now = DateTime.Now;
            filteredCasesByTime = filteredCasesAll.Where(c => c.AccessTime >= startDate && c.AccessTime <= now).ToList();
        }

        private void timeIntervalCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleComboBoxSelectionChange();
        }

        private void HandleComboBoxSelectionChange()
        {
            ComboBoxItems obj = timeIntervalCmb.SelectedItem as ComboBoxItems;

            if (obj != null)
            {
                obj.Action.Invoke();
            }
        }
    }
}