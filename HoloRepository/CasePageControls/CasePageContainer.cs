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
    public partial class CasePageContainer : UserControl
    {
        public CasePageContainer()
        {
            InitializeComponent();
            
            //AddDonorInfo addDonorInfo = new AddDonorInfo();
            //addContent(addDonorInfo);
            AddCase test = new AddCase();
            addContent(test);
        }
        private void addContent(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
    }
    
}
