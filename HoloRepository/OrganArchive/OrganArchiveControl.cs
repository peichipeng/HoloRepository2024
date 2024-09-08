namespace HoloRepository
{
    public partial class OrganArchiveControl : UserControl
    {
        private DatabaseConnection dbConnection;
        private Button invisibleButton;
        public OrganArchiveControl()
        {
            this.Load += OrganArchiveControl_Load;
            dbConnection = new DatabaseConnection();
            InitializeComponent();
            LoadInitialPanel();
            InitializeInvisibleButton();
        }

        private void InitializeInvisibleButton()
        {
            invisibleButton = new Button
            {
                Size = new Size(0, 0),
                Location = new Point(-100, -100),
                TabStop = false
            };
            this.Controls.Add(invisibleButton);
        }

        private void OrganArchiveControl_Load(object sender, EventArgs e)
        {
            invisibleButton.Focus();
        }

        private void LoadInitialPanel()
        {
            var organNames = LoadOrganNames();
            foreach (var (organId, organName) in organNames)
            {
                AddOrganArchive3DPanel(organName);
            }
        }

        private void CustomTabControl_TabChanged(object sender, string tabName)
        {
            OrganDisplayPanel.Controls.Clear();
            if (tabName == "In Progress")
            {
                LoadInProgressOrgans();
            }
            else if (tabName == "3D Available")
            {
                var organNames = LoadOrganNames();
                foreach (var (organId, organName) in organNames)
                {
                    AddOrganArchive3DPanel(organName);
                }
            }
        }

        private void LoadInProgressOrgans()
        {
            var organs = LoadOrgans();
            foreach (var (organId, donorId) in organs)
            {
                AddOrganArchiveSlicePanel(donorId, organId);
            }
        }

        private void AddOrganArchiveSlicePanel(int donorId, int organId)
        {
            OrganArchiveSlicePanel organArchiveSlicePanel = new(donorId, organId);
            OrganDisplayPanel.Controls.Add(organArchiveSlicePanel);
        }

        private void AddOrganArchive3DPanel(string organName)
        {
            OrganArchive3DPanel organArchive3DPanel = new OrganArchive3DPanel(organName);
            OrganDisplayPanel.Controls.Add(organArchive3DPanel);
        }

        private List<(int organId, string organName)> LoadOrganNames()
        {
            var organNames = new List<(int organId, string organName)>();
            string query = "SELECT organ_name_id, organ_name FROM organname";

            try
            {
                using (var reader = dbConnection.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        organNames.Add((id, name));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organ names: " + ex.Message);
            }

            return organNames;
        }

        private List<(int organId, int donorId)> LoadOrgans()
        {
            var organs = new List<(int organId, int donorId)>();
            string query = "SELECT organ_id, donor_id FROM organ WHERE organ_id NOT IN (SELECT organ_id FROM model3d)";

            try
            {
                using (var reader = dbConnection.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        int organId = reader.GetInt32(0);
                        int donorId = reader.GetInt32(1);
                        organs.Add((organId, donorId));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organs: " + ex.Message);
            }

            return organs;
        }

        private void OrganArchiveSearchBox_TextChanged(object sender, EventArgs e)
        {
            placeholder.Visible = false;
            string[] orTerms = OrganArchiveSearchBox.Text.ToLower().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (Control control in OrganDisplayPanel.Controls)
            {
                bool matchFound = false;

                foreach (string orTerm in orTerms)
                {
                    string[] andTerms = orTerm.Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);

                    if (control is OrganArchive3DPanel organArchive3DPanel)
                    {
                        bool currentMatch = andTerms.All(term =>
                            organArchive3DPanel.ListPanel.Controls.OfType<_3DPanel>().Any(subControl =>
                                subControl.GetDonorId().ToLower().Contains(term.Trim()) ||
                                organArchive3DPanel.GetOrganName().ToLower().Contains(term.Trim())));

                        if (currentMatch)
                        {
                            matchFound = true;
                            break;
                        }
                    }
                    else if (control is OrganArchiveSlicePanel organArchiveSlicePanel)
                    {
                        bool currentMatch = andTerms.All(term =>
                            organArchiveSlicePanel.GetDonorID().ToLower().Contains(term.Trim()) ||
                            organArchiveSlicePanel.GetOrganName().ToLower().Contains(term.Trim()) ||
                            organArchiveSlicePanel.GetNumOrgans().ToLower().Contains(term.Trim()) ||
                            organArchiveSlicePanel.GetDateDeath().ToLower().Contains(term.Trim()) ||
                            organArchiveSlicePanel.GetAge().ToLower().Contains(term.Trim()) ||
                            organArchiveSlicePanel.GetCauseOD().ToLower().Contains(term.Trim()));

                        if (currentMatch)
                        {
                            matchFound = true;
                            break;
                        }
                    }
                }

                control.Visible = matchFound;
            }
        }


        private void placeholder_Click(object sender, EventArgs e)
        {
            OrganArchiveSearchBox.Focus();
        }

        private void OrganArchiveSearchBox_GotFocus(object sender, EventArgs e)
        {
            // Hide the placeholder when the TextBox gains focus
            placeholder.Visible = false;
            OrganArchiveSearchBox.ForeColor = Color.Black;
        }

        private void OrganArchiveSearchBox_LostFocus(object sender, EventArgs e)
        {
            // Show the placeholder if TextBox is empty when it loses focus
            if (string.IsNullOrWhiteSpace(OrganArchiveSearchBox.Text))
            {
                placeholder.Visible = true;
            }
        }

    }
}
