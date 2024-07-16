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
            DICOMTitle = new Label();
            ImportDICOMButton = new RoundedButton();
            RemoveAllButton = new RoundedButton();
            panel1 = new Panel();
            organSlicesPanel = new FlowLayoutPanel();
            AddOrganSlicePanel = new Panel();
            AddOrganSlicesButton = new RoundedButton();
            TagsTitle = new Label();
            multiTags1 = new MultiTags();
            fileListBox = new RoundedListBox();
            OrganSlicesTitle = new Label();
            panel1.SuspendLayout();
            organSlicesPanel.SuspendLayout();
            AddOrganSlicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // DICOMTitle
            // 
            DICOMTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DICOMTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DICOMTitle.Location = new Point(108, 31);
            DICOMTitle.Margin = new Padding(5, 0, 5, 0);
            DICOMTitle.Name = "DICOMTitle";
            DICOMTitle.Size = new Size(216, 42);
            DICOMTitle.TabIndex = 3;
            DICOMTitle.Text = "DICOM Files";
            // 
            // ImportDICOMButton
            // 
            ImportDICOMButton.Anchor = AnchorStyles.Top;
            ImportDICOMButton.BackColor = Color.FromArgb(51, 129, 202);
            ImportDICOMButton.BorderRadius = 10;
            ImportDICOMButton.FlatAppearance.BorderSize = 0;
            ImportDICOMButton.FlatStyle = FlatStyle.Flat;
            ImportDICOMButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImportDICOMButton.ForeColor = Color.White;
            ImportDICOMButton.Location = new Point(783, 32);
            ImportDICOMButton.Margin = new Padding(5, 4, 5, 4);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(152, 47);
            ImportDICOMButton.TabIndex = 4;
            ImportDICOMButton.Text = "+ Import";
            ImportDICOMButton.UseVisualStyleBackColor = false;
            ImportDICOMButton.Click += ImportDICOMButton_Click;
            // 
            // RemoveAllButton
            // 
            RemoveAllButton.Anchor = AnchorStyles.Top;
            RemoveAllButton.BackColor = Color.FromArgb(180, 63, 63);
            RemoveAllButton.BorderRadius = 10;
            RemoveAllButton.FlatAppearance.BorderSize = 0;
            RemoveAllButton.FlatStyle = FlatStyle.Flat;
            RemoveAllButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveAllButton.ForeColor = Color.White;
            RemoveAllButton.Location = new Point(978, 32);
            RemoveAllButton.Margin = new Padding(5, 4, 5, 4);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(170, 47);
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
            panel1.Controls.Add(organSlicesPanel);
            panel1.Controls.Add(fileListBox);
            panel1.Controls.Add(OrganSlicesTitle);
            panel1.Controls.Add(ImportDICOMButton);
            panel1.Controls.Add(RemoveAllButton);
            panel1.Controls.Add(DICOMTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 6, 5, 6);
            panel1.Size = new Size(1257, 765);
            panel1.TabIndex = 7;
            // 
            // organSlicesPanel
            // 
            organSlicesPanel.Anchor = AnchorStyles.Top;
            organSlicesPanel.Controls.Add(AddOrganSlicePanel);
            organSlicesPanel.Controls.Add(TagsTitle);
            organSlicesPanel.Controls.Add(multiTags1);
            organSlicesPanel.FlowDirection = FlowDirection.TopDown;
            organSlicesPanel.Location = new Point(104, 422);
            organSlicesPanel.Name = "organSlicesPanel";
            organSlicesPanel.Size = new Size(1049, 308);
            organSlicesPanel.TabIndex = 21;
            // 
            // AddOrganSlicePanel
            // 
            AddOrganSlicePanel.Controls.Add(AddOrganSlicesButton);
            AddOrganSlicePanel.Location = new Point(3, 3);
            AddOrganSlicePanel.Name = "AddOrganSlicePanel";
            AddOrganSlicePanel.Size = new Size(1041, 53);
            AddOrganSlicePanel.TabIndex = 22;
            // 
            // AddOrganSlicesButton
            // 
            AddOrganSlicesButton.Anchor = AnchorStyles.Right;
            AddOrganSlicesButton.BackColor = Color.FromArgb(51, 129, 202);
            AddOrganSlicesButton.BorderRadius = 10;
            AddOrganSlicesButton.FlatAppearance.BorderSize = 0;
            AddOrganSlicesButton.FlatStyle = FlatStyle.Flat;
            AddOrganSlicesButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddOrganSlicesButton.ForeColor = Color.White;
            AddOrganSlicesButton.Location = new Point(777, 4);
            AddOrganSlicesButton.Margin = new Padding(5, 4, 5, 4);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(262, 47);
            AddOrganSlicesButton.TabIndex = 8;
            AddOrganSlicesButton.Text = "+ Add an organ slice";
            AddOrganSlicesButton.UseVisualStyleBackColor = false;
            AddOrganSlicesButton.Click += AddOrganSlicesButton_Click;
            // 
            // TagsTitle
            // 
            TagsTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(5, 59);
            TagsTitle.Margin = new Padding(5, 0, 5, 10);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(1037, 42);
            TagsTitle.TabIndex = 9;
            TagsTitle.Text = "Tags for Classification";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(5, 115);
            multiTags1.Margin = new Padding(5, 4, 5, 4);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(1037, 174);
            multiTags1.TabIndex = 16;
            // 
            // fileListBox
            // 
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 2;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(108, 101);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(1040, 238);
            fileListBox.TabIndex = 20;
            // 
            // OrganSlicesTitle
            // 
            OrganSlicesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrganSlicesTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSlicesTitle.Location = new Point(108, 362);
            OrganSlicesTitle.Margin = new Padding(5, 0, 5, 0);
            OrganSlicesTitle.Name = "OrganSlicesTitle";
            OrganSlicesTitle.Size = new Size(392, 42);
            OrganSlicesTitle.TabIndex = 7;
            OrganSlicesTitle.Text = "Organ Slice Image Files";
            // 
            // AddCaseControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddCaseControl";
            Size = new Size(1257, 765);
            panel1.ResumeLayout(false);
            organSlicesPanel.ResumeLayout(false);
            AddOrganSlicePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DICOMTitle;
        private Panel panel1;
        private RoundedButton ImportDICOMButton;
        private RoundedButton RemoveAllButton;
        private Label OrganSlicesTitle;
        private RoundedButton AddOrganSlicesButton;
        private Label TagsTitle;
        private MultiTags multiTags1;
        private RoundedListBox fileListBox;
        private FlowLayoutPanel organSlicesPanel;
        private Panel AddOrganSlicePanel;
    }
}