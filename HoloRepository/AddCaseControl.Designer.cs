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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCaseControl));
            AddOrganTitle = new Label();
            DICOMTitle = new Label();
            ImportDICOMButton = new RoundedButton();
            RemoveAllButton = new RoundedButton();
            panel1 = new Panel();
            sideListBox = new ListBox();
            SideBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            caseNo = new Label();
            organListBox = new ListBox();
            organNameTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            OrganNameLabel = new Label();
            organSlicesPanel = new FlowLayoutPanel();
            addOrganSlicePanel = new Panel();
            AddOrganSlicesButton = new RoundedButton();
            panel2 = new Panel();
            HelpInfo = new Label();
            updateBtn = new PictureBox();
            TagsTitle = new Label();
            multiTags1 = new MultiTags();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new RoundedButton();
            panel3 = new Panel();
            Toggle = new Toggle();
            ConstructLabel = new Label();
            btnCancel = new RoundedButton();
            fileListBox = new RoundedListBox();
            lineControl1 = new LineControl();
            OrganSlicesTitle = new Label();
            panel1.SuspendLayout();
            organSlicesPanel.SuspendLayout();
            addOrganSlicePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateBtn).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // AddOrganTitle
            // 
            AddOrganTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            AddOrganTitle.AutoSize = true;
            AddOrganTitle.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddOrganTitle.Location = new Point(39, 34);
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
            DICOMTitle.Location = new Point(39, 184);
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
            ImportDICOMButton.Location = new Point(592, 181);
            ImportDICOMButton.Margin = new Padding(3, 2, 3, 2);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(97, 29);
            ImportDICOMButton.TabIndex = 4;
            ImportDICOMButton.Text = "+ &Import";
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
            RemoveAllButton.Location = new Point(720, 181);
            RemoveAllButton.Margin = new Padding(3, 2, 3, 2);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(108, 29);
            RemoveAllButton.TabIndex = 6;
            RemoveAllButton.Text = "&Remove All";
            RemoveAllButton.UseVisualStyleBackColor = false;
            RemoveAllButton.Click += RemoveAllButton_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(sideListBox);
            panel1.Controls.Add(SideBox);
            panel1.Controls.Add(caseNo);
            panel1.Controls.Add(organListBox);
            panel1.Controls.Add(organNameTextBox);
            panel1.Controls.Add(OrganNameLabel);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3, 4, 3, 4);
            panel1.Size = new Size(907, 598);
            panel1.TabIndex = 7;
            // 
            // sideListBox
            // 
            sideListBox.Anchor = AnchorStyles.Top;
            sideListBox.FormattingEnabled = true;
            sideListBox.ItemHeight = 15;
            sideListBox.Location = new Point(230, 163);
            sideListBox.Margin = new Padding(2, 2, 2, 2);
            sideListBox.Name = "sideListBox";
            sideListBox.Size = new Size(67, 79);
            sideListBox.TabIndex = 61;
            sideListBox.UseWaitCursor = true;
            sideListBox.Visible = false;
            sideListBox.Click += SideListBox_Click;
            // 
            // SideBox
            // 
            SideBox.Anchor = AnchorStyles.Top;
            SideBox.Location = new Point(230, 139);
            SideBox.Margin = new Padding(2, 2, 2, 2);
            SideBox.Multiline = true;
            SideBox.Name = "SideBox";
            SideBox.Size = new Size(66, 25);
            SideBox.StateActive.Back.Color1 = Color.White;
            SideBox.StateActive.Border.Color1 = Color.Silver;
            SideBox.StateActive.Border.Color2 = Color.Silver;
            SideBox.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            SideBox.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            SideBox.StateActive.Border.Rounding = 5;
            SideBox.TabIndex = 60;
            SideBox.Visible = false;
            SideBox.GotFocus += SideBox_GotFocus;
            SideBox.LostFocus += SideBox_LostFocus;
            // 
            // caseNo
            // 
            caseNo.Anchor = AnchorStyles.Top;
            caseNo.AutoSize = true;
            caseNo.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            caseNo.ForeColor = Color.Black;
            caseNo.Location = new Point(706, 44);
            caseNo.Margin = new Padding(2, 0, 2, 0);
            caseNo.Name = "caseNo";
            caseNo.Size = new Size(128, 21);
            caseNo.TabIndex = 59;
            caseNo.Text = "Case 123456789";
            caseNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // organListBox
            // 
            organListBox.Anchor = AnchorStyles.Top;
            organListBox.FormattingEnabled = true;
            organListBox.ItemHeight = 15;
            organListBox.Location = new Point(39, 163);
            organListBox.Margin = new Padding(2, 2, 2, 2);
            organListBox.Name = "organListBox";
            organListBox.Size = new Size(171, 79);
            organListBox.TabIndex = 24;
            organListBox.Visible = false;
            organListBox.Click += OrganListBox_Click;
            // 
            // organNameTextBox
            // 
            organNameTextBox.Anchor = AnchorStyles.Top;
            organNameTextBox.Location = new Point(39, 139);
            organNameTextBox.Margin = new Padding(2, 2, 2, 2);
            organNameTextBox.Multiline = true;
            organNameTextBox.Name = "organNameTextBox";
            organNameTextBox.Size = new Size(170, 25);
            organNameTextBox.StateActive.Back.Color1 = Color.White;
            organNameTextBox.StateActive.Border.Color1 = Color.Silver;
            organNameTextBox.StateActive.Border.Color2 = Color.Silver;
            organNameTextBox.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            organNameTextBox.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            organNameTextBox.StateActive.Border.Rounding = 5;
            organNameTextBox.TabIndex = 23;
            organNameTextBox.TextChanged += OrganNameTextBox_TextChanged;
            organNameTextBox.GotFocus += OrganNameTextBox_GotFocus;
            organNameTextBox.KeyDown += OrganNameTextBox_KeyDown;
            organNameTextBox.LostFocus += OrganNameTextBox_LostFocus;
            // 
            // OrganNameLabel
            // 
            OrganNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrganNameLabel.AutoSize = true;
            OrganNameLabel.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrganNameLabel.Location = new Point(39, 98);
            OrganNameLabel.Name = "OrganNameLabel";
            OrganNameLabel.Size = new Size(147, 28);
            OrganNameLabel.TabIndex = 22;
            OrganNameLabel.Text = "Organ Name";
            // 
            // organSlicesPanel
            // 
            organSlicesPanel.Anchor = AnchorStyles.Top;
            organSlicesPanel.AutoSize = true;
            organSlicesPanel.Controls.Add(addOrganSlicePanel);
            organSlicesPanel.Controls.Add(panel2);
            organSlicesPanel.Controls.Add(multiTags1);
            organSlicesPanel.Controls.Add(tableLayoutPanel1);
            organSlicesPanel.FlowDirection = FlowDirection.TopDown;
            organSlicesPanel.Location = new Point(39, 426);
            organSlicesPanel.Margin = new Padding(2, 2, 2, 2);
            organSlicesPanel.Name = "organSlicesPanel";
            organSlicesPanel.Size = new Size(791, 290);
            organSlicesPanel.TabIndex = 21;
            // 
            // addOrganSlicePanel
            // 
            addOrganSlicePanel.Controls.Add(AddOrganSlicesButton);
            addOrganSlicePanel.Location = new Point(2, 2);
            addOrganSlicePanel.Margin = new Padding(2, 2, 2, 2);
            addOrganSlicePanel.Name = "addOrganSlicePanel";
            addOrganSlicePanel.Size = new Size(787, 34);
            addOrganSlicePanel.TabIndex = 22;
            // 
            // AddOrganSlicesButton
            // 
            AddOrganSlicesButton.Anchor = AnchorStyles.None;
            AddOrganSlicesButton.BackColor = Color.FromArgb(51, 129, 202);
            AddOrganSlicesButton.BorderRadius = 10;
            AddOrganSlicesButton.FlatAppearance.BorderSize = 0;
            AddOrganSlicesButton.FlatStyle = FlatStyle.Flat;
            AddOrganSlicesButton.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddOrganSlicesButton.ForeColor = Color.White;
            AddOrganSlicesButton.Location = new Point(613, 2);
            AddOrganSlicesButton.Margin = new Padding(3, 2, 3, 2);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(167, 29);
            AddOrganSlicesButton.TabIndex = 8;
            AddOrganSlicesButton.Text = "+ &Add an organ slice";
            AddOrganSlicesButton.UseVisualStyleBackColor = false;
            AddOrganSlicesButton.Click += AddOrganSlicesButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(HelpInfo);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(TagsTitle);
            panel2.Location = new Point(2, 40);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 36);
            panel2.TabIndex = 22;
            // 
            // HelpInfo
            // 
            HelpInfo.Anchor = AnchorStyles.None;
            HelpInfo.AutoSize = true;
            HelpInfo.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            HelpInfo.ForeColor = Color.Gray;
            HelpInfo.Location = new Point(263, 9);
            HelpInfo.Margin = new Padding(2, 0, 2, 0);
            HelpInfo.Name = "HelpInfo";
            HelpInfo.Size = new Size(219, 20);
            HelpInfo.TabIndex = 77;
            HelpInfo.Text = "Add tags with disease names, ...";
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.None;
            updateBtn.BackColor = Color.Transparent;
            updateBtn.Image = (Image)resources.GetObject("updateBtn.Image");
            updateBtn.Location = new Point(236, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(24, 29);
            updateBtn.SizeMode = PictureBoxSizeMode.Zoom;
            updateBtn.TabIndex = 76;
            updateBtn.TabStop = false;
            // 
            // TagsTitle
            // 
            TagsTitle.Anchor = AnchorStyles.None;
            TagsTitle.AutoSize = true;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(2, 6);
            TagsTitle.Margin = new Padding(3, 0, 3, 6);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(244, 28);
            TagsTitle.TabIndex = 9;
            TagsTitle.Text = "Tags for Classification";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(3, 80);
            multiTags1.Margin = new Padding(3, 2, 3, 2);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(785, 110);
            multiTags1.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 0, 1);
            tableLayoutPanel1.Location = new Point(2, 194);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(787, 94);
            tableLayoutPanel1.TabIndex = 62;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(51, 129, 202);
            btnSave.BorderRadius = 10;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(725, 56);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(59, 29);
            btnSave.TabIndex = 61;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.Controls.Add(Toggle);
            panel3.Controls.Add(ConstructLabel);
            panel3.Location = new Point(2, 9);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 29);
            panel3.TabIndex = 63;
            // 
            // Toggle
            // 
            Toggle.Anchor = AnchorStyles.Left;
            Toggle.BorderColor = Color.LightGray;
            Toggle.ForeColor = Color.White;
            Toggle.IsOn = false;
            Toggle.Location = new Point(2, 2);
            Toggle.Margin = new Padding(2, 2, 2, 2);
            Toggle.Name = "Toggle";
            Toggle.OffColor = Color.DarkGray;
            Toggle.OffText = "";
            Toggle.OnColor = Color.FromArgb(94, 148, 255);
            Toggle.OnText = "";
            Toggle.Size = new Size(48, 26);
            Toggle.TabIndex = 61;
            Toggle.Text = "toggle1";
            Toggle.TextEnabled = true;
            // 
            // ConstructLabel
            // 
            ConstructLabel.Anchor = AnchorStyles.None;
            ConstructLabel.AutoSize = true;
            ConstructLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConstructLabel.Location = new Point(57, 5);
            ConstructLabel.Name = "ConstructLabel";
            ConstructLabel.Size = new Size(174, 22);
            ConstructLabel.TabIndex = 62;
            ConstructLabel.Text = "Construct 3D Model";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left;
            btnCancel.BackColor = Color.FromArgb(180, 63, 63);
            btnCancel.BorderRadius = 10;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(3, 56);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(71, 29);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // fileListBox
            // 
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 2;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(39, 225);
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
            lineControl1.Location = new Point(39, 76);
            lineControl1.Margin = new Padding(3, 2, 3, 2);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(785, 9);
            lineControl1.TabIndex = 17;
            lineControl1.Text = "lineControl1";
            // 
            // OrganSlicesTitle
            // 
            OrganSlicesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            OrganSlicesTitle.AutoSize = true;
            OrganSlicesTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSlicesTitle.Location = new Point(39, 398);
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
            Size = new Size(907, 598);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            organSlicesPanel.ResumeLayout(false);
            addOrganSlicePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateBtn).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void OrganNameTextBox_TextChanged1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label AddOrganTitle;
        private Label DICOMTitle;
        private Panel panel1;
        private RoundedButton ImportDICOMButton;
        private RoundedButton RemoveAllButton;
        private Label OrganSlicesTitle;
        private Label TagsTitle;
        private MultiTags multiTags1;
        private LineControl lineControl1;
        private RoundedListBox fileListBox;
        private FlowLayoutPanel organSlicesPanel;
        private Panel addOrganSlicePanel;
        private Panel panel2;
        private RoundedButton AddOrganSlicesButton;
        private Label HelpInfo;
        private PictureBox updateBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox organNameTextBox;
        private Label OrganNameLabel;
        private ListBox organListBox;
        private Label caseNo;
        private Toggle Toggle;
        private Label ConstructLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private RoundedButton btnSave;
        private RoundedButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox SideBox;
        private ListBox sideListBox;
    }
}