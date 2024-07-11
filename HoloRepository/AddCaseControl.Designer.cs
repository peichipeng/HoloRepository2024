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
            AddOrganTitle = new Label();
            DICOMTitle = new Label();
            ImportDICOMButton = new RoundedButton();
            RemoveAllButton = new RoundedButton();
            panel1 = new Panel();
            fileListBox = new RoundedListBox();
            lineControl2 = new LineControl();
            lineControl1 = new LineControl();
            multiTags1 = new MultiTags();
            CancelAddOrganButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            CancelButton = new RoundedButton();
            SaveButton = new RoundedButton();
            TagsTitle = new Label();
            AddOrganSlicesButton = new RoundedButton();
            OrganSlicesTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddOrganTitle
            // 
            AddOrganTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            AddOrganTitle.AutoSize = true;
            AddOrganTitle.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrganTitle.Location = new Point(88, 64);
            AddOrganTitle.Margin = new Padding(5, 0, 5, 0);
            AddOrganTitle.Name = "AddOrganTitle";
            AddOrganTitle.Size = new Size(312, 54);
            AddOrganTitle.TabIndex = 0;
            AddOrganTitle.Text = "Add an Organ";
            // 
            // DICOMTitle
            // 
            DICOMTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DICOMTitle.AutoSize = true;
            DICOMTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DICOMTitle.Location = new Point(88, 162);
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
            ImportDICOMButton.Location = new Point(943, 155);
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
            RemoveAllButton.Location = new Point(1152, 155);
            RemoveAllButton.Margin = new Padding(5, 4, 5, 4);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(178, 47);
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
            panel1.Controls.Add(fileListBox);
            panel1.Controls.Add(lineControl2);
            panel1.Controls.Add(lineControl1);
            panel1.Controls.Add(multiTags1);
            panel1.Controls.Add(CancelAddOrganButton);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(TagsTitle);
            panel1.Controls.Add(AddOrganSlicesButton);
            panel1.Controls.Add(OrganSlicesTitle);
            panel1.Controls.Add(ImportDICOMButton);
            panel1.Controls.Add(RemoveAllButton);
            panel1.Controls.Add(AddOrganTitle);
            panel1.Controls.Add(DICOMTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 6, 5, 6);
            panel1.Size = new Size(1425, 957);
            panel1.TabIndex = 7;
            // 
            // fileListBox
            // 
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 2;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(96, 225);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(1240, 238);
            fileListBox.TabIndex = 20;
            // 
            // lineControl2
            // 
            lineControl2.Anchor = AnchorStyles.Top;
            lineControl2.LineColor = Color.Silver;
            lineControl2.LineWidth = 1;
            lineControl2.Location = new Point(96, 524);
            lineControl2.Margin = new Padding(5, 4, 5, 4);
            lineControl2.Name = "lineControl2";
            lineControl2.Size = new Size(1234, 14);
            lineControl2.TabIndex = 18;
            lineControl2.Text = "lineControl2";
            // 
            // lineControl1
            // 
            lineControl1.Anchor = AnchorStyles.Top;
            lineControl1.LineColor = Color.Gray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(96, 133);
            lineControl1.Margin = new Padding(5, 4, 5, 4);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(1234, 14);
            lineControl1.TabIndex = 17;
            lineControl1.Text = "lineControl1";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Top;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(96, 669);
            multiTags1.Margin = new Padding(5, 4, 5, 4);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(1232, 174);
            multiTags1.TabIndex = 16;
            // 
            // CancelAddOrganButton
            // 
            CancelAddOrganButton.Anchor = AnchorStyles.Top;
            CancelAddOrganButton.Location = new Point(96, 896);
            CancelAddOrganButton.Margin = new Padding(5, 4, 5, 4);
            CancelAddOrganButton.Name = "CancelAddOrganButton";
            CancelAddOrganButton.OverrideDefault.Back.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.OverrideDefault.Back.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.OverrideDefault.Back.ColorAngle = 45F;
            CancelAddOrganButton.OverrideDefault.Border.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.OverrideDefault.Border.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.OverrideDefault.Border.ColorAngle = 45F;
            CancelAddOrganButton.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelAddOrganButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CancelAddOrganButton.OverrideDefault.Border.Rounding = 5;
            CancelAddOrganButton.OverrideDefault.Border.Width = 1;
            CancelAddOrganButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            CancelAddOrganButton.Size = new Size(119, 49);
            CancelAddOrganButton.StateCommon.Back.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StateCommon.Back.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StateCommon.Back.ColorAngle = 45F;
            CancelAddOrganButton.StateCommon.Border.Color1 = Color.Transparent;
            CancelAddOrganButton.StateCommon.Border.Color2 = Color.Transparent;
            CancelAddOrganButton.StateCommon.Border.ColorAngle = 45F;
            CancelAddOrganButton.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelAddOrganButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CancelAddOrganButton.StateCommon.Border.Rounding = 5;
            CancelAddOrganButton.StateCommon.Border.Width = 1;
            CancelAddOrganButton.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelAddOrganButton.StateCommon.Content.ShortText.Color2 = Color.White;
            CancelAddOrganButton.StateCommon.Content.ShortText.Font = new Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelAddOrganButton.StatePressed.Back.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StatePressed.Back.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StatePressed.Back.ColorAngle = 135F;
            CancelAddOrganButton.StatePressed.Border.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StatePressed.Border.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StatePressed.Border.ColorAngle = 135F;
            CancelAddOrganButton.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelAddOrganButton.StatePressed.Border.Rounding = 5;
            CancelAddOrganButton.StatePressed.Border.Width = 1;
            CancelAddOrganButton.StateTracking.Back.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StateTracking.Back.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StateTracking.Back.ColorAngle = 45F;
            CancelAddOrganButton.StateTracking.Border.Color1 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StateTracking.Border.Color2 = Color.FromArgb(180, 63, 63);
            CancelAddOrganButton.StateTracking.Border.ColorAngle = 45F;
            CancelAddOrganButton.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelAddOrganButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CancelAddOrganButton.StateTracking.Border.Rounding = 5;
            CancelAddOrganButton.StateTracking.Border.Width = 1;
            CancelAddOrganButton.TabIndex = 15;
            CancelAddOrganButton.Values.Text = "Cancel";
            CancelAddOrganButton.Click += CancelAddOrganButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BorderRadius = 15;
            CancelButton.Location = new Point(0, 0);
            CancelButton.Margin = new Padding(5, 4, 5, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(118, 32);
            CancelButton.TabIndex = 19;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top;
            SaveButton.BackColor = Color.FromArgb(51, 129, 202);
            SaveButton.BorderRadius = 10;
            SaveButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(1212, 896);
            SaveButton.Margin = new Padding(5, 4, 5, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(118, 49);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // TagsTitle
            // 
            TagsTitle.Anchor = AnchorStyles.Top;
            TagsTitle.AutoSize = true;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(88, 610);
            TagsTitle.Margin = new Padding(5, 0, 5, 0);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(372, 42);
            TagsTitle.TabIndex = 9;
            TagsTitle.Text = "Tags for Classification";
            // 
            // AddOrganSlicesButton
            // 
            AddOrganSlicesButton.Anchor = AnchorStyles.Top;
            AddOrganSlicesButton.BackColor = Color.FromArgb(51, 129, 202);
            AddOrganSlicesButton.BorderRadius = 10;
            AddOrganSlicesButton.FlatAppearance.BorderSize = 0;
            AddOrganSlicesButton.FlatStyle = FlatStyle.Flat;
            AddOrganSlicesButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddOrganSlicesButton.ForeColor = Color.White;
            AddOrganSlicesButton.Location = new Point(1067, 559);
            AddOrganSlicesButton.Margin = new Padding(5, 4, 5, 4);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(262, 47);
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
            OrganSlicesTitle.Location = new Point(88, 480);
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
            Size = new Size(1425, 957);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddOrganTitle;
        private Label DICOMTitle;
        private Panel panel1;
        private RoundedButton ImportDICOMButton;
        private RoundedButton RemoveAllButton;
        private Label OrganSlicesTitle;
        private RoundedButton AddOrganSlicesButton;
        private Label TagsTitle;
        private RoundedButton CancelButton;
        private RoundedButton SaveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CancelAddOrganButton;
        private MultiTags multiTags1;
        private LineControl lineControl1;
        private LineControl lineControl2;
        private RoundedListBox fileListBox;
    }
}