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
            organSlicesPanel = new FlowLayoutPanel();
            AddOrganSlicesButton = new RoundedButton();
            TagsTitle = new Label();
            multiTags1 = new MultiTags();
            tableLayoutPanel1 = new TableLayoutPanel();
            CancelAddOrganButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            SaveButton = new RoundedButton();
            fileListBox = new RoundedListBox();
            lineControl1 = new LineControl();
            OrganSlicesTitle = new Label();
            panel1.SuspendLayout();
            organSlicesPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panel1.Controls.Add(lineControl1);
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
            // organSlicesPanel
            // 
            organSlicesPanel.Anchor = AnchorStyles.Top;
            organSlicesPanel.AutoSize = true;
            organSlicesPanel.Controls.Add(AddOrganSlicesButton);
            organSlicesPanel.Controls.Add(TagsTitle);
            organSlicesPanel.Controls.Add(multiTags1);
            organSlicesPanel.Controls.Add(tableLayoutPanel1);
            organSlicesPanel.FlowDirection = FlowDirection.TopDown;
            organSlicesPanel.Location = new Point(83, 546);
            organSlicesPanel.Name = "organSlicesPanel";
            organSlicesPanel.Size = new Size(1255, 411);
            organSlicesPanel.TabIndex = 21;
            // 
            // AddOrganSlicesButton
            // 
            AddOrganSlicesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddOrganSlicesButton.BackColor = Color.FromArgb(51, 129, 202);
            AddOrganSlicesButton.BorderRadius = 10;
            AddOrganSlicesButton.FlatAppearance.BorderSize = 0;
            AddOrganSlicesButton.FlatStyle = FlatStyle.Flat;
            AddOrganSlicesButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddOrganSlicesButton.ForeColor = Color.White;
            AddOrganSlicesButton.Location = new Point(988, 4);
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
            TagsTitle.AutoSize = true;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(5, 55);
            TagsTitle.Margin = new Padding(5, 0, 5, 10);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(1245, 42);
            TagsTitle.TabIndex = 9;
            TagsTitle.Text = "Tags for Classification";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(5, 111);
            multiTags1.Margin = new Padding(5, 4, 5, 4);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(1245, 174);
            multiTags1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CancelAddOrganButton, 0, 1);
            tableLayoutPanel1.Controls.Add(SaveButton, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 299);
            tableLayoutPanel1.Margin = new Padding(3, 10, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1249, 109);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CancelAddOrganButton
            // 
            CancelAddOrganButton.Location = new Point(5, 58);
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
            CancelAddOrganButton.Size = new Size(119, 46);
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
            SaveButton.BackColor = Color.FromArgb(51, 129, 202);
            SaveButton.BorderRadius = 10;
            SaveButton.Dock = DockStyle.Right;
            SaveButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(1126, 58);
            SaveButton.Margin = new Padding(5, 4, 5, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(118, 47);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // fileListBox
            // 
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 2;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(83, 225);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(1240, 238);
            fileListBox.TabIndex = 20;
            // 
            // lineControl1
            // 
            lineControl1.Anchor = AnchorStyles.Top;
            lineControl1.LineColor = Color.Gray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(83, 133);
            lineControl1.Margin = new Padding(5, 4, 5, 4);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(1234, 14);
            lineControl1.TabIndex = 17;
            lineControl1.Text = "lineControl1";
            // 
            // OrganSlicesTitle
            // 
            OrganSlicesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrganSlicesTitle.AutoSize = true;
            OrganSlicesTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSlicesTitle.Location = new Point(84, 488);
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
            organSlicesPanel.ResumeLayout(false);
            organSlicesPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private RoundedButton SaveButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton CancelAddOrganButton;
        private MultiTags multiTags1;
        private LineControl lineControl1;
        private RoundedListBox fileListBox;
        private FlowLayoutPanel organSlicesPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}