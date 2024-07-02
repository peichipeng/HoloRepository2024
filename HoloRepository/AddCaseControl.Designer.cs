namespace HoloRepository
{
    partial class AddCaseControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddCaseTitle = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            DICOMTitle = new Label();
            ImportDICOMButton = new RoundedButton();
            fileListBox = new RoundedListBox();
            RemoveAllButton = new RoundedButton();
            panel1 = new Panel();
            AddOrganSlicesButton = new RoundedButton();
            OrganSlicesTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddCaseTitle
            // 
            AddCaseTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            AddCaseTitle.AutoSize = true;
            AddCaseTitle.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddCaseTitle.Location = new Point(362, 23);
            AddCaseTitle.Name = "AddCaseTitle";
            AddCaseTitle.Size = new Size(166, 36);
            AddCaseTitle.TabIndex = 0;
            AddCaseTitle.Text = "Add a Case";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Location = new Point(284, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(654, 508);
            button1.Name = "button1";
            button1.Size = new Size(105, 28);
            button1.TabIndex = 2;
            button1.Text = "Add Picture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DICOMTitle
            // 
            DICOMTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DICOMTitle.AutoSize = true;
            DICOMTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DICOMTitle.Location = new Point(57, 81);
            DICOMTitle.Name = "DICOMTitle";
            DICOMTitle.Size = new Size(141, 28);
            DICOMTitle.TabIndex = 3;
            DICOMTitle.Text = "DICOM Files";
            // 
            // ImportDICOMButton
            // 
            ImportDICOMButton.Anchor = AnchorStyles.Top;
            ImportDICOMButton.BackColor = Color.CornflowerBlue;
            ImportDICOMButton.BorderRadius = 15;
            ImportDICOMButton.FlatAppearance.BorderSize = 0;
            ImportDICOMButton.FlatStyle = FlatStyle.Flat;
            ImportDICOMButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImportDICOMButton.ForeColor = Color.White;
            ImportDICOMButton.Location = new Point(592, 77);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(97, 33);
            ImportDICOMButton.TabIndex = 4;
            ImportDICOMButton.Text = "+ Import";
            ImportDICOMButton.UseVisualStyleBackColor = false;
            ImportDICOMButton.Click += ImportDICOMButton_Click;
            // 
            // fileListBox
            // 
            fileListBox.AllowDrop = true;
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 20;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 24;
            fileListBox.Location = new Point(79, 626);
            fileListBox.Name = "fileListBox";
            fileListBox.SelectionMode = SelectionMode.None;
            fileListBox.Size = new Size(785, 157);
            fileListBox.TabIndex = 5;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Anchor = AnchorStyles.Top;
            RemoveAllButton.BackColor = Color.IndianRed;
            RemoveAllButton.BorderRadius = 15;
            RemoveAllButton.FlatAppearance.BorderSize = 0;
            RemoveAllButton.FlatStyle = FlatStyle.Flat;
            RemoveAllButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveAllButton.ForeColor = Color.White;
            RemoveAllButton.Location = new Point(725, 77);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(113, 33);
            RemoveAllButton.TabIndex = 6;
            RemoveAllButton.Text = "Remove All";
            RemoveAllButton.UseVisualStyleBackColor = false;
            RemoveAllButton.Click += RemoveAllButton_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AddOrganSlicesButton);
            panel1.Controls.Add(OrganSlicesTitle);
            panel1.Controls.Add(ImportDICOMButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(fileListBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RemoveAllButton);
            panel1.Controls.Add(AddCaseTitle);
            panel1.Controls.Add(DICOMTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(907, 678);
            panel1.TabIndex = 7;
            // 
            // AddOrganSlicesButton
            // 
            AddOrganSlicesButton.Anchor = AnchorStyles.Top;
            AddOrganSlicesButton.BackColor = Color.CornflowerBlue;
            AddOrganSlicesButton.BorderRadius = 15;
            AddOrganSlicesButton.FlatAppearance.BorderSize = 0;
            AddOrganSlicesButton.FlatStyle = FlatStyle.Flat;
            AddOrganSlicesButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddOrganSlicesButton.ForeColor = Color.White;
            AddOrganSlicesButton.Location = new Point(671, 307);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(167, 33);
            AddOrganSlicesButton.TabIndex = 8;
            AddOrganSlicesButton.Text = "+ Add an organ slice";
            AddOrganSlicesButton.UseVisualStyleBackColor = false;
            AddOrganSlicesButton.Click += AddOrganSlicesButton_Click;
            // 
            // OrganSlicesTitle
            // 
            OrganSlicesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrganSlicesTitle.AutoSize = true;
            OrganSlicesTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSlicesTitle.Location = new Point(57, 307);
            OrganSlicesTitle.Name = "OrganSlicesTitle";
            OrganSlicesTitle.Size = new Size(142, 28);
            OrganSlicesTitle.TabIndex = 7;
            OrganSlicesTitle.Text = "Organ Slices";
            // 
            // AddCaseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddCaseControl";
            Size = new Size(907, 678);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddCaseTitle;
        private PictureBox pictureBox1;
        private Button button1;
        private Label DICOMTitle;
        private Panel panel1;
        private RoundedButton ImportDICOMButton;
        private RoundedButton RemoveAllButton;
        private RoundedListBox fileListBox;
        private Label OrganSlicesTitle;
        private RoundedButton AddOrganSlicesButton;
    }
}