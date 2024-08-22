﻿using Npgsql;
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

        private DatabaseConnection dbConnection;
        public DonorInfo()
        {
            dbConnection = new DatabaseConnection();
            InitializeComponent();
        }

        // Update donor's basic information page
        public DonorInfo(Dictionary<string, string> donorInfo)
        {
            dbConnection = new DatabaseConnection();
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
            // needs to be modified to meet the database connection class
            // need to check if the donorid exists
            try
            {
                string insertQuery = "INSERT INTO donor (donor_id, age, date_of_death, cause_of_death) VALUES (@donorId, @age, @dod, @causeOfDeath)";
                dbConnection.ExecuteNonQuery(insertQuery, new Dictionary<string, object>
                    {
                        { "@donorId", donorId },
                        { "@age", age },
                        { "@dod", dod },
                        { "@causeOfDeath", causeOfDeath }
                    });
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
            }
        }

        public async void UpdateDonorInfo()
        {
            try
            {
                string sql;
                var parameters = new Dictionary<string, object>
                {
                    { "@donorId", donorId },
                    { "@age", age },
                    { "@dod", dod },
                    { "@causeOfDeath", causeOfDeath }
                };
                if (originalId == donorId)
                {
                    sql = "UPDATE donor SET age = @age, date_of_death = @dod, cause_of_death = @causeOfDeath WHERE donor_id = @donorId";
                }
                else
                {
                    sql = "UPDATE donor SET donor_id = @donorId, age = @age, date_of_death = @dod, cause_of_death = @causeOfDeath WHERE donor_id = @originalId";
                    parameters.Add("@originalId", originalId);
                }
                await Task.Run(() => dbConnection.ExecuteNonQuery(sql, parameters));
                
                if (Parent.Parent is AddCaseFramework framework)
                {
                    if (framework.destination == "addCase")
                    {
                        framework.LoadControl(new CasePage("addCase", donorId));
                    } else
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
            //MessageBox.Show(formattedDate);

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
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ageTxt.Text))
            {
                IsAgeValid();
            }
        }
    }
}
