using Npgsql;

namespace HoloRepository
{
    public partial class OrganArchive3DPanel : UserControl
    {
        private string organName;
        private DatabaseConnection dbConnection;
        private int startIndex = 0; // The starting index for displaying 3D panels
        private const int panelsToShow = 4; // Number of panels to show at once

        public OrganArchive3DPanel(string organName)
        {
            this.organName = organName;
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            SetOrganName(organName);
            LoadAndAdd3DPanels();
            CheckVisibility();
        }

        private void LoadAndAdd3DPanels()
        {
            var organs = GetOrgansWith3DModels();
            foreach (var organ in organs)
            {
                if (organ.organName == organName)
                {
                    Add3DPanel(organ.donorId, organ.organId);
                }
            }
            UpdatePanelVisibility(); // Update visibility after adding panels
        }

        private void Add3DPanel(int donorId, int organId)
        {
            _3DPanel threeDPanel = new _3DPanel(organId, donorId, new List<string>());
            ListPanel.Controls.Add(threeDPanel);
        }

        private List<(int organId, int donorId, string organName)> GetOrgansWith3DModels()
        {
            var organs = new List<(int organId, int donorId, string organName)>();

            string query = @"
                SELECT m.organ_id, o.donor_id, n.organ_name 
                FROM model3d m 
                JOIN organ o ON m.organ_id = o.organ_id 
                JOIN organname n ON o.organ_name_id = n.organ_name_id";

            try
            {
                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int organId = reader.GetInt32(0);
                        int donorId = reader.GetInt32(1);
                        string organName = reader.GetString(2);
                        organs.Add((organId, donorId, organName));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organs with 3D models: " + ex.Message);
            }

            return organs;
        }

        public void SetOrganName(string organName)
        {
            OrganName.Text = organName;
        }

        public string GetOrganName()
        {
            string txtOrganName = OrganName.Text;
            return txtOrganName;
        }

        private void CheckVisibility()
        {
            if (ListPanel.Controls.Count == 0)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
        }

        private void UpdatePanelVisibility()
        {
            for (int i = 0; i < ListPanel.Controls.Count; i++)
            {
                ListPanel.Controls[i].Visible = i >= startIndex && i < startIndex + panelsToShow;
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (startIndex > 0)
            {
                startIndex--;
                UpdatePanelVisibility();
            }
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (startIndex < ListPanel.Controls.Count - panelsToShow)
            {
                startIndex++;
                UpdatePanelVisibility();
            }
        }
    }
}
