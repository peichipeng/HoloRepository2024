using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class _3DModelFormWindow : Form
    {
        public event EventHandler ConstructClicked;
        private CheckTable checkTable;
        private int? organId;
        private List<OrganSlicePanel> organSlicePanels;

        public _3DModelFormWindow(int? organId, List<OrganSlicePanel> organSlicePanels)
        {
            this.organId = organId;
            this.organSlicePanels = organSlicePanels;
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            checkTable = new CheckTable(organId, organSlicePanels)
            {
                Location = new Point(60, 106),
                Size = new Size(1032, 358),
                BackColor = Color.White,
                Name = "checkTable",
                TabIndex = 0
            };

            this.Controls.Add(checkTable);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConstructButton_Click(object sender, EventArgs e)
        {
            ConstructClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
