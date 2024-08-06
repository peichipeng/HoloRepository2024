﻿using HoloRepository.AddCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class OrganArchiveSlicePanel : UserControl
    {
        private int donorId;

        private int organId;

        private string organName;

        private List<string> organSlices;
        private DatabaseConnection dbConnection;

        public OrganArchiveSlicePanel(int donorId, int organId)
        {
            this.donorId = donorId;
            this.organId = organId;
            InitializeComponent();
            this.dbConnection = new DatabaseConnection();
            organSlices = new List<string>();
            LoadOrganData(donorId, organId);
            AddOrganPanel();
        }

        private void AddOrganPanel()
        {
            OrganPanel organPanel = new OrganPanel(organId, organName, organSlices)
            {
                Dock = DockStyle.Fill // Adjust Dock as needed
            };
            organPanel.organNameLabel.Visible = false;
            organPanel.downArrow.Visible = false;

            OrganSlicesImagePanel.Controls.Add(organPanel);
        }

        private void LoadOrganData(int donorId, int organId)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // Load organ data
                    string organQuery = @"
                        SELECT o.organ_name_id, oname.organ_name, COUNT(s.slice_id) AS slice_count, d.date_of_death, d.age, d.cause_of_death
                        FROM organ o
                        LEFT JOIN organname oname ON o.organ_name_id = oname.organ_name_id
                        LEFT JOIN sliceimage s ON o.organ_id = s.organ_id
                        LEFT JOIN donor d ON o.donor_id = d.donor_id
                        WHERE o.donor_id = @donorId AND o.organ_id = @organId
                        GROUP BY o.organ_name_id, oname.organ_name, d.date_of_death, d.age, d.cause_of_death";

                    using (var command = new NpgsqlCommand(organQuery, connection))
                    {
                        command.Parameters.AddWithValue("@donorId", donorId);
                        command.Parameters.AddWithValue("@organId", organId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                organName = reader.GetString(reader.GetOrdinal("organ_name"));
                                int numberOfSlices = reader.GetInt32(reader.GetOrdinal("slice_count"));
                                DateTime? dateOfDeath = reader.IsDBNull(reader.GetOrdinal("date_of_death"))
                                    ? (DateTime?)null
                                    : reader.GetDateTime(reader.GetOrdinal("date_of_death"));
                                int? age = reader.IsDBNull(reader.GetOrdinal("age")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("age"));
                                string? causeOfDeath = reader.IsDBNull(reader.GetOrdinal("cause_of_death"))
                                    ? null
                                    : reader.GetString(reader.GetOrdinal("cause_of_death"));

                                // Update labels
                                OrganName.Text = $"{organName}";
                                DonorId.Text = $"Donor ID: {donorId}";
                                numOfSlices.Text = $"Number of Slices: {numberOfSlices}";
                                DateDeath.Text = $"Date of Death: {dateOfDeath?.ToString("yyyy-MM-dd") ?? "N/A"}";
                                Age.Text = $"Age: {age?.ToString() ?? "N/A"}";
                                CauseOD.Text = $"Cause of Death: {causeOfDeath ?? "N/A"}";
                            }
                            else
                            {
                                MessageBox.Show("No data found for the specified donor and organ.");
                            }
                        }
                    }

                    // Load slice images
                    string sliceQuery = "SELECT image_path FROM sliceimage WHERE organ_id = @organId";
                    using (var sliceCommand = new NpgsqlCommand(sliceQuery, connection))
                    {
                        sliceCommand.Parameters.AddWithValue("@organId", organId);
                        using (var sliceReader = sliceCommand.ExecuteReader())
                        {
                            while (sliceReader.Read())
                            {
                                string imagePath = sliceReader.GetString(sliceReader.GetOrdinal("image_path"));
                                organSlices.Add(imagePath);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading organ data: " + ex.Message);
            }
        }

        public string GetDonorID()
        {
            return donorId.ToString();
        }

        public string GetOrganName()
        {
            return organName.ToString();
        }

        public string GetNumOrgans()
        {
            return numOfSlices.Text;
        }

        public string GetDateDeath()
        {
            return DateDeath.Text;
        }

        public string GetAge()
        {
            return Age.Text;
        }

        public string GetCauseOD()
        {
            return CauseOD.Text;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                var parentForm = this.FindForm();

                if (parentForm != null)
                {
                    parentForm.Controls.Clear();

                    var addCaseControl = new AddCaseControl(donorId, organId);

                    parentForm.Controls.Add(addCaseControl);

                    addCaseControl.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurs when clicking update：{ex.Message}");
            }
        }
    }
}
