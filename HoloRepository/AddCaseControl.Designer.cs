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
            AddOrganTitle.Location = new Point(56, 45);
            AddOrganTitle.Name = "AddOrganTitle";
            AddOrganTitle.Size = new Size(206, 36);
            AddOrganTitle.TabIndex = 0;
            AddOrganTitle.Text = "Add an Organ";
            // 
            // DICOMTitle
            // 
            DICOMTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DICOMTitle.AutoSize = true;
            DICOMTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DICOMTitle.Location = new Point(56, 115);
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
            ImportDICOMButton.Location = new Point(600, 110);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(139, 49);
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
            fileListBox.ForeColor = Color.Black;
            fileListBox.FormattingEnabled = true;
            fileListBox.ItemHeight = 24;
            fileListBox.Location = new Point(61, 160);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(785, 157);
            fileListBox.TabIndex = 5;
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
            RemoveAllButton.Location = new Point(733, 110);
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
            panel1.Controls.Add(fileListBox);
            panel1.Controls.Add(RemoveAllButton);
            panel1.Controls.Add(AddOrganTitle);
            panel1.Controls.Add(DICOMTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 6, 4, 6);
            panel1.Size = new Size(1296, 997);
            panel1.TabIndex = 7;
            // 
            // lineControl2
            // 
            lineControl2.Anchor = AnchorStyles.Top;
            lineControl2.LineColor = Color.Silver;
            lineControl2.LineWidth = 1;
            lineControl2.Location = new Point(61, 371);
            lineControl2.Name = "lineControl2";
            lineControl2.Size = new Size(785, 10);
            lineControl2.TabIndex = 18;
            lineControl2.Text = "lineControl2";
            // 
            // lineControl1
            // 
            lineControl1.Anchor = AnchorStyles.Top;
            lineControl1.LineColor = Color.Gray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(61, 94);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(785, 10);
            lineControl1.TabIndex = 17;
            lineControl1.Text = "lineControl1";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Top;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(61, 474);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(785, 124);
            multiTags1.TabIndex = 16;
            // 
            // CancelAddOrganButton
            // 
            CancelAddOrganButton.Anchor = AnchorStyles.Top;
            CancelAddOrganButton.Location = new Point(61, 635);
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
            CancelAddOrganButton.Size = new Size(76, 35);
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
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top;
            SaveButton.BackColor = Color.FromArgb(51, 129, 202);
            SaveButton.BorderRadius = 10;
            SaveButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(771, 635);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 35);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // TagsTitle
            // 
            TagsTitle.Anchor = AnchorStyles.Top;
            TagsTitle.AutoSize = true;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(56, 432);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(244, 28);
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
            AddOrganSlicesButton.Location = new Point(679, 396);
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
            OrganSlicesTitle.Location = new Point(56, 340);
            OrganSlicesTitle.Name = "OrganSlicesTitle";
            OrganSlicesTitle.Size = new Size(256, 28);
            OrganSlicesTitle.TabIndex = 7;
            OrganSlicesTitle.Text = "Organ Slice Image Files";
            // 
            // AddCaseControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "AddCaseControl";
            Size = new Size(907, 678);
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
        private RoundedListBox fileListBox;
        private Label OrganSlicesTitle;
        private RoundedButton AddOrganSlicesButton;
        private Label TagsTitle;
        private RoundedButton CancelButton;
        private RoundedButton SaveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CancelAddOrganButton;
        private MultiTags multiTags1;
        private LineControl lineControl1;
        private LineControl lineControl2;
    }
}