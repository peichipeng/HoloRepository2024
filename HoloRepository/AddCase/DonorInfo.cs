﻿using HoloRepository.AddCase.PrimaryKeyErrorForm;
using HoloRepository.ViewCases;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.AddCase
{
    public partial class DonorInfo : UserControl
    {
        public int originalId;
        public int donorId;
        private int age;
        private string causeOfDeath;
        private DateTime dod;

        private bool deleting = false;
        private string requiredFieldMsg = "Required field.";
        public DonorInfo()
        {
            InitializeComponent();
        }

        // Update donor's basic information page
        public DonorInfo(Dictionary<string, string> donorInfo)
        {
            InitializeComponent();
            originalId = int.Parse(donorInfo["id"]);

            title.Text = "Update Donor's Basic";
            donorIdTxt.Text = donorInfo["id"];
            ageTxt.Text = donorInfo["age"];
            dodTxt.Text = donorInfo["dod"];
            causeOfDeathTxt.Text = donorInfo["causeOfDeath"];
            dodTxt.StateCommon.Content.Color1 = Color.Black;
        }

        public async void AddDonorInfo()
        {
            // need to check if the donorid exists
            try
            {
                var dbConnection = new DatabaseConnection();
                await using var conn = new NpgsqlConnection(dbConnection.ConnectionString);
                await conn.OpenAsync();

                await using var cmd = new NpgsqlCommand("INSERT INTO donor (donor_id, age, date_of_death, cause_of_death) VALUES ($1, $2, $3, $4)", conn)
                {
                    Parameters =
                    {
                        new() { Value = donorId },
                        new() { Value = age },
                        new() { Value = dod },
                        new() { Value = causeOfDeath }
                    }
                };
                await cmd.ExecuteNonQueryAsync();

                if (Parent.Parent is AddCaseFramework framework)
                {
                    framework.LoadControl(new CasePage("addCase", donorId));
                }
            }
            catch (PostgresException e)
            {
                if (e.SqlState == "23505")
                {
                    // need to add error handling for existing donor id
                    MessageBox.Show("duplicate primary key");
                    
                }
                else
                {
                    MessageBox.Show($"Error: {e.Message}");
                }
            }
        }

        public async void UpdateDonorInfo()
        {
            try
            {
                var dbConnection = new DatabaseConnection();
                await using var conn = new NpgsqlConnection(dbConnection.ConnectionString);
                await conn.OpenAsync();

                string sql;
                if (originalId == donorId)
                {
                    sql = "UPDATE donor SET age = @age, date_of_death = @dod, cause_of_death = @causeOfDeath, timestamp = @time WHERE donor_id = @donorId";
                }
                else
                {
                    sql = "UPDATE donor SET donor_id = @donorId, age = @age, date_of_death = @dod, cause_of_death = @causeOfDeath, timestamp = @time WHERE donor_id = @originalId";
                }
                await using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@donorId", donorId);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@dod", dod);
                cmd.Parameters.AddWithValue("@causeOfDeath", causeOfDeath);
                cmd.Parameters.AddWithValue("@time", DateTime.Now);

                if (originalId != donorId)
                {
                    cmd.Parameters.AddWithValue("@originalId", originalId);
                }

                await cmd.ExecuteNonQueryAsync();

                if (Parent.Parent is AddCaseFramework framework)
                {
                    if (framework.destination == "addCase")
                    {
                        framework.LoadControl(new CasePage("addCase", donorId));
                    }
                    else
                    {
                        framework.LoadControl(new CasePage("caseOverview", donorId));
                    }
                }
            }
            catch (PostgresException e)
            {
                if (e.SqlState == "23505")
                {
                    // need to add error handling for existing donor id
                    MessageBox.Show("duplicate primary key");
                }
            }
        }

        public bool ValidateAndConvertData()
        {
            bool checkId = IsIdValid();
            bool checkDod = IsDateValid();
            bool checkAge = IsAgeValid();
            bool checkCause = IsCauseValid();

            //string formattedDate = dod.ToString("yyyy-MM-dd");

            return checkId && checkDod && checkAge && checkCause;
        }

        private bool IsIdValid()
        {
            string inputId = donorIdTxt.Text;

            if (string.IsNullOrEmpty(inputId))
            {
                idErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            if (!int.TryParse(inputId, out donorId))
            {
                idErrorLabel.Text = "Invalid ID. Please enter a valid number.";
                return false;
            }

            if (originalId == 0)
            {
                if (RecordExists())
                {
                    idErrorLabel.Text = "A donor with the provided ID already exists in the system.";
                    return false;
                }
            } else if (originalId != donorId)
            {
                if (RecordExists())
                {
                    idErrorLabel.Text = "The updated donor ID already exists in the system.";
                    return false;
                }
            }

            idErrorLabel.Text = "";
            return true;
        }

        private bool IsAgeValid()
        {
            string inputAge = ageTxt.Text;

            if (string.IsNullOrEmpty(inputAge))
            {
                ageErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            if (!int.TryParse(inputAge, out age))
            {
                ageErrorLabel.Text = "Invalid age. Please enter a valid number.";
                return false;
            }

            if (age < 0)
            {
                ageErrorLabel.Text = "Age cannot be negative.";
                return false;
            }

            // Clear the error message if the age is valid
            ageErrorLabel.Text = "";
            return true;
        }

        private bool IsCauseValid()
        {
            if (string.IsNullOrEmpty(causeOfDeathTxt.Text))
            {
                causeErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            causeOfDeath = causeOfDeathTxt.Text;
            causeErrorLabel.Text = "";
            return true;
        }

        private bool IsDateValid()
        {
            string dateString = dodTxt.Text;
            string format = "dd/MM/yyyy";

            string formatErrorMsg = "Invalid format. Please enter the date in the format DD/MM/YYYY.";
            string invalidDateMsg = "Invalid date of death. Please enter a valid date.";
            string futureDateMsg = "The date of death cannot be in the future.";

            if (string.IsNullOrEmpty(dateString) || dateString == "DD/MM/YYYY")
            {
                dodErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            // Regular expression to match DD/MM/YYYY format
            string pattern = @"^\d{2}/\d{2}/\d{4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(dateString, pattern))
            {
                dodErrorLabel.Text = formatErrorMsg;
                return false; // Date is in incorrect format
            }

            if (!DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dod))
            {
                dodErrorLabel.Text = invalidDateMsg;
                return false; // Date is not valid
            }

            if (dod > DateTime.Now)
            {
                dodErrorLabel.Text = futureDateMsg;
                return false; // Date is in the future
            }

            // Clear error message if the date is valid
            dodErrorLabel.Text = "";
            return true; // Date is valid
        }

        private void DOD_Enter(object sender, EventArgs e)
        {
            if (dodTxt.Text == "DD/MM/YYYY")
            {
                dodTxt.Text = "";
                dodTxt.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void DOD_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dodTxt.Text))
            {
                dodTxt.StateCommon.Content.Color1 = Color.Gray;
                dodTxt.Text = "DD/MM/YYYY";

                dodErrorLabel.Text = "";
            }
            else
            {
                IsDateValid();
            }
        }

        private void DOD_TextChanged(object sender, EventArgs e)
        {
            if (deleting)
            {
                deleting = false;
                return;
            }

            int cursorPosition = dodTxt.SelectionStart;

            if (dodTxt.Text.Length == 2 || dodTxt.Text.Length == 5)
            {
                dodTxt.Text = dodTxt.Text.Insert(cursorPosition, "/");
                cursorPosition++;
                dodTxt.SelectionStart = cursorPosition;
            }
        }

        private void DOD_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back && dodTxt.Text.Length > 0)
            {
                int cursorPosition = dodTxt.SelectionStart;

                // Check if deleting a slash
                if (cursorPosition > 0 && dodTxt.Text[cursorPosition - 1] == '/')
                {
                    deleting = true;
                }
            }
        }

        private void donorID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(donorIdTxt.Text))
            {
                IsIdValid();
            } else
            {
                idErrorLabel.Text = "";
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ageTxt.Text))
            {
                IsAgeValid();
            } else
            {
                ageErrorLabel.Text = "";
            }
        }

        private void causeOfDeathTxt_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(causeOfDeathTxt.Text))
            {
                IsCauseValid();
            } else
            {
                causeErrorLabel.Text = "";
            }
        }

        private bool RecordExists()
        {
            var dbConnection = new DatabaseConnection();
            string query = $"SELECT COUNT(*) FROM donor WHERE donor_id = {donorId}";

            using (var conn = new NpgsqlConnection(dbConnection.ConnectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
            {
                conn.Open();

                long count = (long)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}
