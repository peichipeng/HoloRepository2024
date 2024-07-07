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
            AddCaseTitle.Location = new Point(517, 34);
            AddCaseTitle.Margin = new Padding(4, 0, 4, 0);
            AddCaseTitle.Name = "AddCaseTitle";
            AddCaseTitle.Size = new Size(252, 54);
            AddCaseTitle.TabIndex = 0;
            AddCaseTitle.Text = "Add a Case";
            AddCaseTitle.Click += AddCaseTitle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Location = new Point(406, 1303);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 415);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(934, 1476);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(150, 41);
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
            DICOMTitle.Location = new Point(81, 849);
            DICOMTitle.Margin = new Padding(4, 0, 4, 0);
            DICOMTitle.Name = "DICOMTitle";
            DICOMTitle.Size = new Size(216, 42);
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
            ImportDICOMButton.Location = new Point(846, 843);
            ImportDICOMButton.Margin = new Padding(4);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(139, 49);
            ImportDICOMButton.TabIndex = 4;
            ImportDICOMButton.Text = "+ Import";
            ImportDICOMButton.UseVisualStyleBackColor = false;
            ImportDICOMButton.Click += ImportDICOMButton_Click;
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
            RemoveAllButton.Location = new Point(1036, 843);
            RemoveAllButton.Margin = new Padding(4);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(161, 49);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RemoveAllButton);
            panel1.Controls.Add(AddCaseTitle);
            panel1.Controls.Add(DICOMTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 6, 4, 6);
            panel1.Size = new Size(1296, 997);
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
            AddOrganSlicesButton.Location = new Point(959, 1181);
            AddOrganSlicesButton.Margin = new Padding(4);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(239, 49);
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
            OrganSlicesTitle.Location = new Point(81, 1181);
            OrganSlicesTitle.Margin = new Padding(4, 0, 4, 0);
            OrganSlicesTitle.Name = "OrganSlicesTitle";
            OrganSlicesTitle.Size = new Size(217, 42);
            OrganSlicesTitle.TabIndex = 7;
            OrganSlicesTitle.Text = "Organ Slices";
            // 
            // AddCaseControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "AddCaseControl";
            Size = new Size(1296, 997);
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