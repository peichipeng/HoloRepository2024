using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using FellowOakDicom.Imaging;
using FellowOakDicom;
using SixLabors.ImageSharp;

namespace HoloRepository
{
    public partial class OrganSlicePanel : UserControl
    {
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox;
        private Label AdditionalInfoLabel;
        private Label MatchedSliceLabel;
        private PictureBox CTBox;
        private Label OrganSliceLabel;
        private PictureBox EditButton;
        private PictureBox BinButton;
        private LineControl lineControl1;

        private int selectedIndex;
        public int DicomId { get; set; }
        public string Description { get; set; }
        public string OrganSlicePath { get; set; }
        public int OrderIndex { get; set; }

        public System.Drawing.Image OrganSliceImage
        {
            get { return OrganSliceBox.Image; }
        }

        public System.Drawing.Image DicomImage
        {
            get { return CTBox.Image; }
        }


        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                Debug.WriteLine($"SelectedIndex changed to: {selectedIndex}");
            }
        }

        public OrganSlicePanel()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganSlicePanel));
            OrganSliceBox = new PictureBox();
            lineControl1 = new LineControl();
            textBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            AdditionalInfoLabel = new Label();
            MatchedSliceLabel = new Label();
            CTBox = new PictureBox();
            OrganSliceLabel = new Label();
            EditButton = new PictureBox();
            BinButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OrganSliceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinButton).BeginInit();
            SuspendLayout();
            // 
            // OrganSliceBox
            // 
            OrganSliceBox.Location = new System.Drawing.Point(12, 71);
            OrganSliceBox.Name = "OrganSliceBox";
            OrganSliceBox.Size = new System.Drawing.Size(772, 476);
            OrganSliceBox.SizeMode = PictureBoxSizeMode.Zoom;
            OrganSliceBox.TabIndex = 0;
            OrganSliceBox.TabStop = false;
            // 
            // lineControl1
            // 
            lineControl1.LineColor = System.Drawing.Color.DarkGray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new System.Drawing.Point(3, 0);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new System.Drawing.Size(1237, 21);
            lineControl1.TabIndex = 2;
            lineControl1.Text = "lineControl1";
            // 
            // textBox
            // 
            textBox.Location = new System.Drawing.Point(813, 112);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new System.Drawing.Size(427, 127);
            textBox.StateActive.Border.Color1 = System.Drawing.Color.Silver;
            textBox.StateActive.Border.Color2 = System.Drawing.Color.Silver;
            textBox.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            textBox.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            textBox.StateActive.Border.Rounding = 5;
            textBox.TabIndex = 3;
            textBox.Text = "kryptonTextBox1";
            // 
            // AdditionalInfoLabel
            // 
            AdditionalInfoLabel.AutoSize = true;
            AdditionalInfoLabel.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AdditionalInfoLabel.Location = new System.Drawing.Point(813, 70);
            AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            AdditionalInfoLabel.Size = new System.Drawing.Size(273, 39);
            AdditionalInfoLabel.TabIndex = 4;
            AdditionalInfoLabel.Text = "Additional Information";
            // 
            // MatchedSliceLabel
            // 
            MatchedSliceLabel.AutoSize = true;
            MatchedSliceLabel.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            MatchedSliceLabel.Location = new System.Drawing.Point(813, 247);
            MatchedSliceLabel.Name = "MatchedSliceLabel";
            MatchedSliceLabel.Size = new System.Drawing.Size(153, 39);
            MatchedSliceLabel.TabIndex = 5;
            MatchedSliceLabel.Text = "Matched CT";
            // 
            // CTBox
            // 
            CTBox.Location = new System.Drawing.Point(813, 290);
            CTBox.Name = "CTBox";
            CTBox.Size = new System.Drawing.Size(427, 257);
            CTBox.SizeMode = PictureBoxSizeMode.Zoom;
            CTBox.TabIndex = 6;
            CTBox.TabStop = false;
            // 
            // OrganSliceLabel
            // 
            OrganSliceLabel.AutoSize = true;
            OrganSliceLabel.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OrganSliceLabel.Location = new System.Drawing.Point(12, 23);
            OrganSliceLabel.Name = "OrganSliceLabel";
            OrganSliceLabel.Size = new System.Drawing.Size(440, 39);
            OrganSliceLabel.TabIndex = 7;
            OrganSliceLabel.Text = "123456789-kidney-0001-20240614.png";
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top;
            EditButton.BackColor = System.Drawing.Color.Transparent;
            EditButton.Image = (System.Drawing.Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new System.Drawing.Point(1158, 23);
            EditButton.Margin = new Padding(5);
            EditButton.Name = "EditButton";
            EditButton.Size = new System.Drawing.Size(30, 30);
            EditButton.SizeMode = PictureBoxSizeMode.Zoom;
            EditButton.TabIndex = 76;
            EditButton.TabStop = false;
            EditButton.Click += EditButton_Click;
            // 
            // BinButton
            // 
            BinButton.Anchor = AnchorStyles.Top;
            BinButton.BackColor = System.Drawing.Color.Transparent;
            BinButton.Image = (System.Drawing.Image)resources.GetObject("BinButton.Image");
            BinButton.Location = new System.Drawing.Point(1210, 23);
            BinButton.Margin = new Padding(5);
            BinButton.Name = "BinButton";
            BinButton.Size = new System.Drawing.Size(30, 30);
            BinButton.SizeMode = PictureBoxSizeMode.Zoom;
            BinButton.TabIndex = 77;
            BinButton.TabStop = false;
            BinButton.Click += BinButton_Click;
            // 
            // OrganSlicePanel
            // 
            BackColor = System.Drawing.Color.White;
            Controls.Add(BinButton);
            Controls.Add(EditButton);
            Controls.Add(OrganSliceLabel);
            Controls.Add(CTBox);
            Controls.Add(MatchedSliceLabel);
            Controls.Add(AdditionalInfoLabel);
            Controls.Add(textBox);
            Controls.Add(lineControl1);
            Controls.Add(OrganSliceBox);
            Name = "OrganSlicePanel";
            Size = new System.Drawing.Size(1240, 560);
            ((System.ComponentModel.ISupportInitialize)OrganSliceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeCustomComponents()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(10);
        }

        public void SetOrganSlice(string imagePath)
        {
            try
            {
                // Optionally set the path for future reference
                OrganSlicePath = imagePath;

                using var sliceStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var memoryStream = new MemoryStream();
                sliceStream.CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
                OrganSliceBox.Image = System.Drawing.Image.FromStream(memoryStream);
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show($"Argument exception while setting image: {argEx.Message}");
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"I/O exception while setting image: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while setting the image: {ex.Message}");
            }
        }

        public void SetCTImage(System.Drawing.Image image)
        {
            if (CTBox.Image != null)
            {
                CTBox.Image.Dispose();
            }

            CTBox.Image = image;
        }

        public void SetDescription(string description)
        {
            textBox.Text = description;
            Description = description;
        }

        public void SetOrganSliceLabel(string fileName)
        {
            OrganSliceLabel.Text = fileName;
        }

        private void BinButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm == null)
                return;

            OverlayForm overlay = new OverlayForm
            {
                Location = parentForm.Location,
                Size = parentForm.Size
            };

            // Display overlay panel
            overlay.Show(parentForm);

            // Create DeleteWindow
            using (DeleteWindow deleteWindow = new DeleteWindow())
            {
                // Set DeleteWindow to the center of parent window
                deleteWindow.StartPosition = FormStartPosition.Manual;
                deleteWindow.Location = new System.Drawing.Point(
                    parentForm.Left + (parentForm.Width - deleteWindow.Width) / 2,
                    parentForm.Top + (parentForm.Height - deleteWindow.Height) / 2);

                // Ensure the DeleteWindow is TopMost
                deleteWindow.TopMost = true;

                DialogResult result = deleteWindow.ShowDialog(parentForm);

                overlay.Close();

                if (result == DialogResult.Yes)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        if (this.Parent != null)
                        {
                            AddOrganControl addCaseControl = FindParentControlOfType<AddOrganControl>();
                            if (addCaseControl != null)
                            {
                                // Remove the current OrganSlicePanel
                                addCaseControl.RemoveOrganSlicePanel(this);
                                this.Parent.Controls.Remove(this);

                                // Update OrganSliceLabels for remaining panels
                                UpdateOrganSliceLabels(addCaseControl);
                            }
                        }
                        else
                        {
                            Debug.WriteLine("Parent is null during removal.");
                        }
                    });
                }
            }
        }

        private void UpdateOrganSliceLabels(AddOrganControl addCaseControl)
        {
            for (int i = 0; i < addCaseControl.organSlicePanels.Count; i++)
            {
                var panel = addCaseControl.organSlicePanels[i];
                int currentIndex = i + 1; // 1-based index
                string newFileName = $"{addCaseControl.GetDonorID()}-{addCaseControl.GetOrganName()}-{currentIndex:D4}-{DateTime.Now:yyyyMMdd}.jpg";
                panel.SetOrganSliceLabel(newFileName);
            }
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            AddOrganControl addCaseControl = FindParentControlOfType<AddOrganControl>();
            if (addCaseControl == null)
            {
                return;
            }
            string organSide = addCaseControl.GetOrganSide();
            using (AddOrganSlice changeOrganSlice = new AddOrganSlice(addCaseControl.GetDonorID(), addCaseControl.GetOrganName(), this.OrderIndex, organSide))
            {
                changeOrganSlice.StartPosition = FormStartPosition.CenterParent;

                List<string> imagePaths = addCaseControl.GetDICOMPaths();
                List<System.Drawing.Image> images = new();
                foreach (string path in imagePaths)
                {
                    try
                    {
                        var file = await DicomFile.OpenAsync(path);
                        var dicomImage = new DicomImage(file.Dataset);
                        using (var image = dicomImage.RenderImage().AsSharpImage())
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                image.SaveAsBmp(memoryStream);
                                memoryStream.Seek(0, SeekOrigin.Begin);
                                var bitmap = new Bitmap(memoryStream);
                                images.Add(bitmap);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Cannot handle the DICOM file: {ex.Message}");
                    }
                }
                changeOrganSlice.SetImageList(images, SelectedIndex);

                changeOrganSlice.HideOverlayPanel(1);

                changeOrganSlice.SetOrganSlice(OrganSlicePath);

                changeOrganSlice.SetDescription(textBox.Text);

                changeOrganSlice.ChangeButtonText("Save");

                changeOrganSlice.SetFormTitle("Change organ slice");

                // Listen for OrganSliceUpdated event and update image name label
                changeOrganSlice.OrganSliceUpdated += (organSliceImage, selectedImage, description, selectedIndex) =>
                {
                    SetCTImage(selectedImage);
                    SetOrganSlice(changeOrganSlice.OrganSliceImagePath);
                    SetDescription(description);
                    SelectedIndex = selectedIndex;
                };


                changeOrganSlice.ShowDialog();
            }
        }

        private T FindParentControlOfType<T>() where T : Control
        {
            Control current = this;
            while (current.Parent != null)
            {
                if (current.Parent is T parent)
                {
                    return parent;
                }
                current = current.Parent;
            }
            return null;
        }

        public PictureBox OrganSliceBox;
    }
}
