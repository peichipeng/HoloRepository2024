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
    public partial class AddCaseControl : UserControl
    {
        private List<string> imagePaths = new List<string>();
        private List<OrganSlicePanel> organSlicePanels = new List<OrganSlicePanel>();  // 保存所有的 OrganSlicePanel
        private int selectedIndex;
        private List<string> organData = new List<string> { "Heart", "Liver", "Kidney", "Lung", "Brain" };

        public AddCaseControl()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Subscribe to the ImageDeleted event
            if (fileListBox is RoundedListBox roundedListBox)
            {
                roundedListBox.ImageDeleted += RoundedListBox_ImageDeleted;
            }
        }

        public List<string> GetImagePaths()
        {
            return imagePaths;
        }

        private void RoundedListBox_ImageDeleted(object sender, string deletedFileName)
        {
            // Find the full path corresponding to the deleted file name
            string deletedImagePath = imagePaths.FirstOrDefault(path => path.EndsWith(deletedFileName, StringComparison.InvariantCultureIgnoreCase));

            if (deletedImagePath != null)
            {
                imagePaths.Remove(deletedImagePath);
                Debug.WriteLine($"Deleted image path: {deletedImagePath}");
            }
            else
            {
                Debug.WriteLine($"Image path for file {deletedFileName} was not found in the list.");
            }
        }

        private void ImportDICOMButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Process each selected image file
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Add file name to ListBox
                        string fileName = Path.GetFileName(filePath);
                        fileListBox.Items.Add(fileName);

                        // Add file path to list
                        imagePaths.Add(filePath);
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
                imagePaths.Clear();
            }
        }

        private void AddOrganSlicesButton_Click(object sender, EventArgs e)
        {
            using (AddOrganSlice addOrganSlice = new())
            {
                addOrganSlice.StartPosition = FormStartPosition.CenterParent;

                List<Image> images = new();
                foreach (string path in imagePaths)
                {
                    images.Add(new Bitmap(path));
                }
                addOrganSlice.SetImageList(images, 0);

                if (addOrganSlice.ShowDialog() == DialogResult.OK)
                {
                    // Selected Image and Description
                    Image OrganSlice = addOrganSlice.OrganSliceImage;
                    Image selectedImage = addOrganSlice.SelectedImage;
                    string description = addOrganSlice.Description;
                    selectedIndex = addOrganSlice.SelectedIndex;

                    // Display the new organ slice
                    DisplayNewOrganSlice(selectedImage, OrganSlice, description);
                }
            }
        }


        private void DisplayNewOrganSlice(Image image, Image OrganSliceImage, string description)
        {
            // Create a new OrganSlicePanel
            OrganSlicePanel organSlicePanel = new OrganSlicePanel
            {
                Width = organSlicesPanel.Width,
                Height = 543,
                BorderStyle = BorderStyle.None,
                Margin = new Padding(10),
                SelectedIndex = selectedIndex
            };

            // Set image and description
            organSlicePanel.SetOrganSlice(OrganSliceImage);
            organSlicePanel.SetCTImage(image);
            organSlicePanel.SetDescription(description, selectedIndex);

            int fixedControlsCount = 3;

            organSlicesPanel.Controls.Add(organSlicePanel);
            organSlicesPanel.Controls.SetChildIndex(organSlicePanel, organSlicesPanel.Controls.Count - fixedControlsCount - 1);
            organSlicePanels.Add(organSlicePanel);
        }

        private void CancelAddOrganButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void OrganNameTextBox_GotFocus(object sender, EventArgs e)
        {
            ShowOrganListBox();
        }

        private void OrganNameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (!organListBox.Focused)
            {
                if (!organListBox.Items.Contains(organNameTextBox.Text))
                {
                    organNameTextBox.Clear();
                }
                organListBox.Visible = false;
            }
        }
        private void OrganNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = organNameTextBox.Text.ToLower();
            var filteredData = organData.Where(d => d.ToLower().Contains(query)).ToList();

            organListBox.Items.Clear();
            organListBox.Items.AddRange(filteredData.ToArray());

            organListBox.Visible = filteredData.Any();
        }

        private void OrganNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (organListBox.Items.Count > 0)
                {
                    organNameTextBox.Text = organListBox.Items[0].ToString();
                    organListBox.Visible = false;
                }
                else
                {
                    organNameTextBox.Clear();
                    organNameTextBox.Parent.Focus();  // 确保TextBox失去焦点
                }
                e.Handled = true;
                e.SuppressKeyPress = true; // 防止“叮”声
            }
        }


        private void ShowOrganListBox()
        {
            this.organListBox.BringToFront();
            this.organListBox.Visible = true;
        }

        private void OrganListBox_Click(object sender, EventArgs e)
        {
            if (organListBox.SelectedItem != null)
            {
                organNameTextBox.Text = organListBox.SelectedItem.ToString();
                organListBox.Visible = false;
            }
        }

    }
}
