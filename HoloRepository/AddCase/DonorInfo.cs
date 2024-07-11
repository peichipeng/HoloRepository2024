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
    public partial class DonorInfo : UserControl
    {
        public DonorInfo()
        {
            InitializeComponent();
        }

        // Add the code for updating the donor info
        public DonorInfo(Dictionary<string, string> donorInfo)
        {
            InitializeComponent();
            title.Text = "Update Donor's Basic";
            donorID.Text = donorInfo["id"];
            age.Text = donorInfo["age"];
            DOD.Text = donorInfo["dod"];
            causeOfDeath.Text = donorInfo["causeOfDeath"];
        }

    }
}
