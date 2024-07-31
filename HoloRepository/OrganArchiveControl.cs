using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HoloRepository
{
    public partial class OrganArchiveControl : UserControl
    {
        private DatabaseConnection dbConnection;
        public OrganArchiveControl()
        {
            dbConnection = new DatabaseConnection();
            InitializeComponent();
            LoadInitialPanel();
            OrganArchiveSearchBox.TextChanged += OrganArchiveSearchBox_TextChanged;
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
            string searchText = OrganArchiveSearchBox.Text.ToLower();
            foreach (Control control in OrganDisplayPanel.Controls)
            {
                if (control is OrganArchive3DPanel organArchive3DPanel)
                {
                    bool matchFound = false;
                    foreach (Control subControl in organArchive3DPanel.ListPanel.Controls)
                    {
                        if (subControl is _3DPanel threeDPanel)
                        {
                            string donorId = threeDPanel.GetDonorId().ToLower();
                            string organName = organArchive3DPanel.GetOrganName().ToLower();
                            if (donorId.Contains(searchText) || organName.Contains(searchText))
                            {
                                matchFound = true;
                                break;
                            }
                        }
                    }
                    organArchive3DPanel.Visible = matchFound;
                }
                else if (control is OrganArchiveSlicePanel organArchiveSlicePanel)
                {
                    bool matchFound = false;
                    string donorId = organArchiveSlicePanel.GetDonorID().ToLower();
                    string organName = organArchiveSlicePanel.GetOrganName().ToLower();
                    string numSlices = organArchiveSlicePanel.GetNumOrgans().ToLower();
                    string dateDeath = organArchiveSlicePanel.GetDateDeath().ToLower();
                    string age = organArchiveSlicePanel.GetAge().ToLower();
                    string causeOD = organArchiveSlicePanel.GetCauseOD().ToLower();
                    if (donorId.Contains(searchText) || organName.Contains(searchText) || numSlices.Contains(searchText) || dateDeath.Contains(searchText) || age.Contains(searchText) || causeOD.Contains(searchText))
                    {
                        matchFound = true;
                    }
                    organArchiveSlicePanel.Visible = matchFound;
                }
            }
        }
    }
}
