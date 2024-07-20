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
            // AddOrganTitle
            // 
            AddOrganTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            AddOrganTitle.AutoSize = true;
            AddOrganTitle.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrganTitle.Location = new Point(3, 40);
            AddOrganTitle.Name = "AddOrganTitle";
            AddOrganTitle.Size = new Size(206, 36);
            AddOrganTitle.TabIndex = 0;
            AddOrganTitle.Text = "Add an Organ";
            // 
            // DICOMTitle
            // 
            DICOMTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DICOMTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            DICOMTitle.Location = new Point(3, 101);
            DICOMTitle.Name = "DICOMTitle";
            DICOMTitle.Size = new Size(141, 28);
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
            ImportDICOMButton.Location = new Point(547, 97);
            ImportDICOMButton.Margin = new Padding(3, 2, 3, 2);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(97, 29);
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
            RemoveAllButton.Location = new Point(680, 97);
            RemoveAllButton.Margin = new Padding(3, 2, 3, 2);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(108, 29);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(800, 598);
            panel1.TabIndex = 7;
            // 
            // organSlicesPanel
            // 
            organSlicesPanel.Anchor = AnchorStyles.Top;
            organSlicesPanel.Controls.Add(AddOrganSlicePanel);
            organSlicesPanel.Controls.Add(TagsTitle);
            organSlicesPanel.Controls.Add(multiTags1);
            organSlicesPanel.FlowDirection = FlowDirection.TopDown;
            organSlicesPanel.Location = new Point(0, 341);
            organSlicesPanel.Margin = new Padding(2, 2, 2, 2);
            organSlicesPanel.Name = "organSlicesPanel";
            organSlicesPanel.Size = new Size(799, 257);
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
            AddOrganSlicesButton.Location = new Point(629, 2);
            AddOrganSlicesButton.Margin = new Padding(3, 2, 3, 2);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(167, 29);
            AddOrganSlicesButton.TabIndex = 8;
            AddOrganSlicesButton.Text = "+ Add an organ slice";
            AddOrganSlicesButton.UseVisualStyleBackColor = false;
            AddOrganSlicesButton.Click += AddOrganSlicesButton_Click;
            // 
            // TagsTitle
            // 
            TagsTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(3, 33);
            TagsTitle.Margin = new Padding(3, 0, 3, 6);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(793, 28);
            TagsTitle.TabIndex = 9;
            TagsTitle.Text = "Tags for Classification";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(3, 69);
            multiTags1.Margin = new Padding(3, 2, 3, 2);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(793, 110);
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
            tableLayoutPanel1.Location = new Point(2, 187);
            tableLayoutPanel1.Margin = new Padding(2, 6, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(795, 68);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // CancelAddOrganButton
            // 
            CancelAddOrganButton.Location = new Point(3, 36);
            CancelAddOrganButton.Margin = new Padding(3, 2, 3, 2);
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
            CancelAddOrganButton.Size = new Size(76, 29);
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
            CancelAddOrganButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            SaveButton.Location = new Point(717, 36);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 30);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // fileListBox
            // 
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 2;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(0, 141);
            fileListBox.Margin = new Padding(2, 2, 2, 2);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(791, 150);
            fileListBox.TabIndex = 20;
            // 
            // lineControl1
            // 
            lineControl1.Anchor = AnchorStyles.Top;
            lineControl1.LineColor = Color.Gray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(0, 83);
            lineControl1.Margin = new Padding(3, 2, 3, 2);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(785, 9);
            lineControl1.TabIndex = 17;
            lineControl1.Text = "lineControl1";
            // 
            // OrganSlicesTitle
            // 
            OrganSlicesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrganSlicesTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSlicesTitle.Location = new Point(0, 305);
            OrganSlicesTitle.Name = "OrganSlicesTitle";
            OrganSlicesTitle.Size = new Size(256, 28);
            OrganSlicesTitle.TabIndex = 7;
            OrganSlicesTitle.Text = "Organ Slice Image Files";
            // 
            // AddCaseControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCaseControl";
            Size = new Size(800, 598);
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