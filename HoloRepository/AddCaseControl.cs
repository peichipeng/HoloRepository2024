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
    public partial class AddCaseControl : UserControl
    {

        public AddCaseControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = openFileDialog.FileName;

                // Display image in pictureBox
                pictureBox1.Image = new Bitmap(filePath);
            }
        }

        private void ImportDICOMButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get selected file names and add to list box
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        fileListBox.Items.Add(Path.GetFileName(fileName));
                    }
                }
            }
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to remove all DICOM files?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fileListBox.Items.Clear();
            }
        }

        private void AddOrganSlicesButton_Click(object sender, EventArgs e)
        {
            using (AddOrganSlice addOrganSlice = new())
            {
                addOrganSlice.StartPosition = FormStartPosition.CenterParent;

                addOrganSlice.ShowDialog();
            }
        }

        private void AddCaseTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
