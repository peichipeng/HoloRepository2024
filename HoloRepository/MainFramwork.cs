using HoloRepository.AddCase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class MainFramwork : UserControl
    {
        public MainFramwork()
        {
            InitializeComponent();
        }

        public MainFramwork(string route)
        {
            InitializeComponent();
            if (route == "add")
            {
                LoadControl(new AddCaseFramework("donor"));
            } 
        }
        private void LoadControl(UserControl userControl)
        {
            mainContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(userControl);
        }
    }
}
