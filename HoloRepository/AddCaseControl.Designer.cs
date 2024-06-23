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
            ImportDICOMButton = new Button();
            fileListBox = new ListBox();
            RemoveAllButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddCaseTitle
            // 
            AddCaseTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            AddCaseTitle.AutoSize = true;
            AddCaseTitle.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddCaseTitle.Location = new Point(380, 30);
            AddCaseTitle.Name = "AddCaseTitle";
            AddCaseTitle.Size = new Size(166, 36);
            AddCaseTitle.TabIndex = 0;
            AddCaseTitle.Text = "Add a Case";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(298, 317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(437, 619);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DICOMTitle
            // 
            DICOMTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DICOMTitle.AutoSize = true;
            DICOMTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DICOMTitle.Location = new Point(12, 15);
            DICOMTitle.Name = "DICOMTitle";
            DICOMTitle.Size = new Size(141, 28);
            DICOMTitle.TabIndex = 3;
            DICOMTitle.Text = "DICOM Files";
            // 
            // ImportDICOMButton
            // 
            ImportDICOMButton.Anchor = AnchorStyles.None;
            ImportDICOMButton.BackColor = Color.CornflowerBlue;
            ImportDICOMButton.FlatAppearance.BorderSize = 0;
            ImportDICOMButton.FlatStyle = FlatStyle.Flat;
            ImportDICOMButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImportDICOMButton.ForeColor = Color.White;
            ImportDICOMButton.Location = new Point(543, 15);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(97, 28);
            ImportDICOMButton.TabIndex = 4;
            ImportDICOMButton.Text = "+ Import";
            ImportDICOMButton.UseVisualStyleBackColor = false;
            ImportDICOMButton.Click += ImportDICOMButton_Click;
            // 
            // fileListBox
            // 
            fileListBox.AllowDrop = true;
            fileListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 17;
            fileListBox.Location = new Point(74, 149);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(785, 140);
            fileListBox.TabIndex = 5;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Anchor = AnchorStyles.None;
            RemoveAllButton.BackColor = Color.IndianRed;
            RemoveAllButton.FlatAppearance.BorderSize = 0;
            RemoveAllButton.FlatStyle = FlatStyle.Flat;
            RemoveAllButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveAllButton.ForeColor = Color.White;
            RemoveAllButton.Location = new Point(659, 16);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(113, 28);
            RemoveAllButton.TabIndex = 6;
            RemoveAllButton.Text = "Remove All";
            RemoveAllButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(ImportDICOMButton);
            panel1.Controls.Add(RemoveAllButton);
            panel1.Controls.Add(DICOMTitle);
            panel1.Location = new Point(74, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 57);
            panel1.TabIndex = 7;
            // 
            // AddCaseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(fileListBox);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(AddCaseTitle);
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
        private Button ImportDICOMButton;
        private ListBox fileListBox;
        private Button RemoveAllButton;
        private Panel panel1;
    }
}