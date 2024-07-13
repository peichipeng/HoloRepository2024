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
            title.Text = "Update Donor's Basic";
            donorID.Text = donorInfo["id"];
            age.Text = donorInfo["age"];
            DOD.Text = donorInfo["dod"];
            causeOfDeath.Text = donorInfo["causeOfDeath"];
        }

        public bool IsIdValid()
        {
            string inputId = donorID.Text;
            int id;

            if (string.IsNullOrEmpty(inputId))
            {
                idErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            if (!int.TryParse(inputId, out id))
            {
                idErrorLabel.Text = "Invalid ID. Please enter a valid number.";
                return false;
            }

            idErrorLabel.Text = "";
            return true;
        }

        public bool IsAgeValid()
        {
            string inputAge = age.Text;

            if (string.IsNullOrEmpty(inputAge))
            {
                ageErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            if (!int.TryParse(inputAge, out int parsedAge))
            {
                ageErrorLabel.Text = "Invalid age. Please enter a valid number.";
                return false;
            }

            // Clear the error message if the age is valid
            ageErrorLabel.Text = "";
            return true;
        }

        public bool IsCauseValid()
        {
            if (string.IsNullOrEmpty(causeOfDeath.Text))
            {
                causeErrorLabel.Text = requiredFieldMsg;
                return false;
            }

            causeErrorLabel.Text = "";
            return true;
        }

        public bool IsDateValid()
        {
            string dateString = DOD.Text;
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

            DateTime parsedDate;
            if (!DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
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
            if (DOD.Text == "DD/MM/YYYY")
            {
                DOD.Text = "";
                DOD.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void DOD_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DOD.Text))
            {
                DOD.StateCommon.Content.Color1 = Color.Gray;
                DOD.Text = "DD/MM/YYYY";
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

            int cursorPosition = DOD.SelectionStart;

            if (DOD.Text.Length == 2 || DOD.Text.Length == 5)
            {
                DOD.Text = DOD.Text.Insert(cursorPosition, "/");
                cursorPosition++;
                DOD.SelectionStart = cursorPosition;
            }
        }

        private void DOD_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Back && DOD.Text.Length > 0)
            {
                int cursorPosition = DOD.SelectionStart;

                // Check if deleting a slash
                if (cursorPosition > 0 && DOD.Text[cursorPosition - 1] == '/')
                {
                    deleting = true;
                }
            }
        }

        private void donorID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(donorID.Text))
            {
                IsIdValid();
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(age.Text))
            {
                IsAgeValid();
            }
        }
    }
}
