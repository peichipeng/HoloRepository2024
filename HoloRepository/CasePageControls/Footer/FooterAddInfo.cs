using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.CasePageControls.Footer
{
    public partial class FooterAddInfo : UserControl
    {
        private BasicInfo basicInfo;
        public FooterAddInfo()
        {
            InitializeComponent();
            // basicInfo = new BasicInfo();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            FooterOverview footerOverview = new FooterOverview();
            basicInfo.addFooter(footerOverview);
        }
    }
}
