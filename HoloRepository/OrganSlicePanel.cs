using System;
using System.Windows.Forms;
using System.Drawing;

namespace HoloRepository
{
    public partial class OrganSlicePanel : UserControl
    {
        private PictureBox OrganSliceBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox;
        private Label AdditionalInfoLabel;
        private Label MatchedSliceLabel;
        private PictureBox CTBox;
        private Label OrganSliceLabel;
        private IconButton EditButton;
        private IconButton BinButton;
        private LineControl lineControl1;

        public int SelectedIndex { get; set; }

        public OrganSlicePanel()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeComponent()
        {
            OrganSliceBox = new PictureBox();
            lineControl1 = new LineControl();
            textBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            AdditionalInfoLabel = new Label();
            MatchedSliceLabel = new Label();
            CTBox = new PictureBox();
            OrganSliceLabel = new Label();
            EditButton = new IconButton();
            BinButton = new IconButton();
            ((System.ComponentModel.ISupportInitialize)OrganSliceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTBox).BeginInit();
            SuspendLayout();
            // 
            // OrganSliceBox
            // 
            OrganSliceBox.Location = new Point(12, 71);
            OrganSliceBox.Name = "OrganSliceBox";
            OrganSliceBox.Size = new Size(772, 476);
            OrganSliceBox.SizeMode = PictureBoxSizeMode.Zoom;
            OrganSliceBox.TabIndex = 0;
            OrganSliceBox.TabStop = false;
            // 
            // lineControl1
            // 
            lineControl1.LineColor = Color.DarkGray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(3, 0);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(1237, 21);
            lineControl1.TabIndex = 2;
            lineControl1.Text = "lineControl1";
            // 
            // textBox
            // 
            textBox.Location = new Point(813, 112);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(406, 127);
            textBox.StateActive.Border.Color1 = Color.Silver;
            textBox.StateActive.Border.Color2 = Color.Silver;
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
            AdditionalInfoLabel.Location = new Point(813, 70);
            AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            AdditionalInfoLabel.Size = new Size(273, 39);
            AdditionalInfoLabel.TabIndex = 4;
            AdditionalInfoLabel.Text = "Additional Information";
            // 
            // MatchedSliceLabel
            // 
            MatchedSliceLabel.AutoSize = true;
            MatchedSliceLabel.Font = new Font("Poppins SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            MatchedSliceLabel.Location = new Point(813, 247);
            MatchedSliceLabel.Name = "MatchedSliceLabel";
            MatchedSliceLabel.Size = new Size(153, 39);
            MatchedSliceLabel.TabIndex = 5;
            MatchedSliceLabel.Text = "Matched CT";
            // 
            // CTBox
            // 
            CTBox.Location = new Point(813, 290);
            CTBox.Name = "CTBox";
            CTBox.Size = new Size(406, 257);
            CTBox.SizeMode = PictureBoxSizeMode.Zoom;
            CTBox.TabIndex = 6;
            CTBox.TabStop = false;
            // 
            // OrganSliceLabel
            // 
            OrganSliceLabel.AutoSize = true;
            OrganSliceLabel.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OrganSliceLabel.Location = new Point(12, 23);
            OrganSliceLabel.Name = "OrganSliceLabel";
            OrganSliceLabel.Size = new Size(440, 39);
            OrganSliceLabel.TabIndex = 7;
            OrganSliceLabel.Text = "123456789-kidney-0001-20240614.png";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Transparent;
            EditButton.Cursor = Cursors.Hand;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.ImageFileName = "EditButton.png";
            EditButton.Location = new Point(1130, 23);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(30, 30);
            EditButton.TabIndex = 8;
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // BinButton
            // 
            BinButton.BackColor = Color.Transparent;
            BinButton.FlatAppearance.BorderSize = 0;
            BinButton.FlatStyle = FlatStyle.Flat;
            BinButton.ImageFileName = "BinButton.png";
            BinButton.Location = new Point(1189, 23);
            BinButton.Name = "BinButton";
            BinButton.Size = new Size(30, 30);
            BinButton.TabIndex = 9;
            BinButton.UseVisualStyleBackColor = false;
            BinButton.Click += BinButton_Click;
            // 
            // OrganSlicePanel
            // 
            BackColor = Color.White;
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
            Size = new Size(1240, 560);
            ((System.ComponentModel.ISupportInitialize)OrganSliceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InitializeCustomComponents()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(10);
        }

        public void SetOrganSlice(Image image)
        {
            OrganSliceBox.Image = image;
        }

        public void SetCTImage(Image image)
        {
            CTBox.Image = image;
        }

        public void SetDescription(string description, int index)
        {
            textBox.Text = description;
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
                deleteWindow.Location = new Point(
                    parentForm.Left + (parentForm.Width - deleteWindow.Width) / 2,
                    parentForm.Top + (parentForm.Height - deleteWindow.Height) / 2);

                // Ensure the DeleteWindow is TopMost
                deleteWindow.TopMost = true;

                DialogResult result = deleteWindow.ShowDialog(parentForm);

                overlay.Close();

                if (result == DialogResult.Yes)
                {
                    // Hanlde delete event: remove the current organSlicePanel
                    this.Parent.Controls.Remove(this);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddCaseControl addCaseControl = FindParentControlOfType<AddCaseControl>();
            if (addCaseControl == null)
            {
                return;
            }
            using (AddOrganSlice changeOrganSlice = new AddOrganSlice())
            {
                changeOrganSlice.StartPosition = FormStartPosition.CenterParent;

                List<string> imagePaths = addCaseControl.GetImagePaths();
                List<Image> images = new();
                foreach (string path in imagePaths)
                {
                    images.Add(new Bitmap(path));
                }
                changeOrganSlice.SetImageList(images, SelectedIndex);

                changeOrganSlice.HideOverlayPanel(1);

                changeOrganSlice.SetOrganSlice(OrganSliceBox.Image);

                changeOrganSlice.SetDescription(textBox.Text);

                changeOrganSlice.ChangeButtonText("Save");

                changeOrganSlice.SetFormTitle("Change organ slice");

                changeOrganSlice.OrganSliceUpdated += (organSliceImage, selectedImage, description, selectedIndex) =>
                {
                    SetCTImage(selectedImage);
                    SetOrganSlice(organSliceImage);
                    SetDescription(description, selectedIndex);
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

    }
}
