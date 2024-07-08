using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.CasePageControls
{
    public partial class AddDonorInfo : UserControl
    {
        public AddDonorInfo()
        {
            InitializeComponent();
        }
        public void OnUpdateBtnClicked(object? sender, DonorInfoEventArgs e)
        {
            MessageBox.Show("hey");
            title.Text = "Update Donor's Basic Information";
            ID.Text = e.donorInfo["id"];
        }
    }
}
