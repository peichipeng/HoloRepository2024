namespace HoloRepository
{
    partial class AddOrganControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrganControl));
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
            AddOrganTitle.Location = new Point(62, 54);
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
            DICOMTitle.Location = new Point(62, 295);
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
            ImportDICOMButton.Location = new Point(930, 290);
            ImportDICOMButton.Margin = new Padding(5, 4, 5, 4);
            ImportDICOMButton.Name = "ImportDICOMButton";
            ImportDICOMButton.Size = new Size(152, 47);
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
            RemoveAllButton.Location = new Point(1132, 290);
            RemoveAllButton.Margin = new Padding(5, 4, 5, 4);
            RemoveAllButton.Name = "RemoveAllButton";
            RemoveAllButton.Size = new Size(170, 47);
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
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5, 6, 5, 6);
            panel1.Size = new Size(1425, 957);
            panel1.TabIndex = 7;
            // 
            // sideListBox
            // 
            sideListBox.Anchor = AnchorStyles.Top;
            sideListBox.FormattingEnabled = true;
            sideListBox.ItemHeight = 24;
            sideListBox.Location = new Point(362, 261);
            sideListBox.Name = "sideListBox";
            sideListBox.Size = new Size(103, 124);
            sideListBox.TabIndex = 61;
            sideListBox.UseWaitCursor = true;
            sideListBox.Visible = false;
            sideListBox.Click += SideListBox_Click;
            // 
            // SideBox
            // 
            SideBox.Anchor = AnchorStyles.Top;
            SideBox.Location = new Point(362, 222);
            SideBox.Multiline = true;
            SideBox.Name = "SideBox";
            SideBox.Size = new Size(103, 40);
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
            caseNo.Location = new Point(1109, 71);
            caseNo.Name = "caseNo";
            caseNo.Size = new Size(187, 32);
            caseNo.TabIndex = 59;
            caseNo.Text = "Case 123456789";
            caseNo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // organListBox
            // 
            organListBox.Anchor = AnchorStyles.Top;
            organListBox.FormattingEnabled = true;
            organListBox.ItemHeight = 24;
            organListBox.Location = new Point(62, 261);
            organListBox.Name = "organListBox";
            organListBox.Size = new Size(267, 124);
            organListBox.TabIndex = 24;
            organListBox.Visible = false;
            organListBox.Click += OrganListBox_Click;
            // 
            // organNameTextBox
            // 
            organNameTextBox.Anchor = AnchorStyles.Top;
            organNameTextBox.Location = new Point(62, 222);
            organNameTextBox.Multiline = true;
            organNameTextBox.Name = "organNameTextBox";
            organNameTextBox.Size = new Size(267, 40);
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
            OrganNameLabel.Location = new Point(62, 157);
            OrganNameLabel.Margin = new Padding(5, 0, 5, 0);
            OrganNameLabel.Name = "OrganNameLabel";
            OrganNameLabel.Size = new Size(223, 42);
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
            organSlicesPanel.Location = new Point(62, 682);
            organSlicesPanel.Name = "organSlicesPanel";
            organSlicesPanel.Size = new Size(1243, 462);
            organSlicesPanel.TabIndex = 21;
            // 
            // addOrganSlicePanel
            // 
            addOrganSlicePanel.Controls.Add(AddOrganSlicesButton);
            addOrganSlicePanel.Location = new Point(3, 3);
            addOrganSlicePanel.Name = "addOrganSlicePanel";
            addOrganSlicePanel.Size = new Size(1237, 55);
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
            AddOrganSlicesButton.Location = new Point(964, 4);
            AddOrganSlicesButton.Margin = new Padding(5, 4, 5, 4);
            AddOrganSlicesButton.Name = "AddOrganSlicesButton";
            AddOrganSlicesButton.Size = new Size(262, 47);
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
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1237, 57);
            panel2.TabIndex = 22;
            // 
            // HelpInfo
            // 
            HelpInfo.Anchor = AnchorStyles.None;
            HelpInfo.AutoSize = true;
            HelpInfo.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            HelpInfo.ForeColor = Color.Gray;
            HelpInfo.Location = new Point(414, 15);
            HelpInfo.Name = "HelpInfo";
            HelpInfo.Size = new Size(313, 27);
            HelpInfo.TabIndex = 77;
            HelpInfo.Text = "Add tags with disease names, ...";
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.None;
            updateBtn.BackColor = Color.Transparent;
            updateBtn.Image = (Image)resources.GetObject("updateBtn.Image");
            updateBtn.Location = new Point(371, 5);
            updateBtn.Margin = new Padding(5);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(38, 46);
            updateBtn.SizeMode = PictureBoxSizeMode.Zoom;
            updateBtn.TabIndex = 76;
            updateBtn.TabStop = false;
            // 
            // TagsTitle
            // 
            TagsTitle.Anchor = AnchorStyles.None;
            TagsTitle.AutoSize = true;
            TagsTitle.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TagsTitle.Location = new Point(3, 9);
            TagsTitle.Margin = new Padding(5, 0, 5, 10);
            TagsTitle.Name = "TagsTitle";
            TagsTitle.Size = new Size(372, 42);
            TagsTitle.TabIndex = 9;
            TagsTitle.Text = "Tags for Classification";
            // 
            // multiTags1
            // 
            multiTags1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiTags1.BorderStyle = BorderStyle.FixedSingle;
            multiTags1.Location = new Point(5, 128);
            multiTags1.Margin = new Padding(5, 4, 5, 4);
            multiTags1.Name = "multiTags1";
            multiTags1.Size = new Size(1233, 174);
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
            tableLayoutPanel1.Location = new Point(3, 309);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1237, 150);
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
            btnSave.Location = new Point(1139, 89);
            btnSave.Margin = new Padding(5, 4, 5, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 47);
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
            panel3.Location = new Point(3, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 46);
            panel3.TabIndex = 63;
            // 
            // Toggle
            // 
            Toggle.Anchor = AnchorStyles.Left;
            Toggle.BorderColor = Color.LightGray;
            Toggle.ForeColor = Color.White;
            Toggle.IsOn = false;
            Toggle.Location = new Point(3, 3);
            Toggle.Name = "Toggle";
            Toggle.OffColor = Color.DarkGray;
            Toggle.OffText = "";
            Toggle.OnColor = Color.FromArgb(94, 148, 255);
            Toggle.OnText = "";
            Toggle.Size = new Size(78, 41);
            Toggle.TabIndex = 61;
            Toggle.Text = "toggle1";
            Toggle.TextEnabled = true;
            // 
            // ConstructLabel
            // 
            ConstructLabel.Anchor = AnchorStyles.None;
            ConstructLabel.AutoSize = true;
            ConstructLabel.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ConstructLabel.Location = new Point(89, 8);
            ConstructLabel.Margin = new Padding(5, 0, 5, 0);
            ConstructLabel.Name = "ConstructLabel";
            ConstructLabel.Size = new Size(258, 31);
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
            btnCancel.Location = new Point(5, 89);
            btnCancel.Margin = new Padding(5, 4, 5, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 47);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // fileListBox
            // 
            fileListBox.Anchor = AnchorStyles.Top;
            fileListBox.BorderRadius = 2;
            fileListBox.DrawMode = DrawMode.OwnerDrawVariable;
            fileListBox.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            fileListBox.FormattingEnabled = true;
            fileListBox.Location = new Point(62, 360);
            fileListBox.Name = "fileListBox";
            fileListBox.Size = new Size(1240, 238);
            fileListBox.TabIndex = 20;
            // 
            // lineControl1
            // 
            lineControl1.Anchor = AnchorStyles.Top;
            lineControl1.LineColor = Color.Gray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(62, 122);
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
            OrganSlicesTitle.Location = new Point(62, 637);
            OrganSlicesTitle.Margin = new Padding(5, 0, 5, 0);
            OrganSlicesTitle.Name = "OrganSlicesTitle";
            OrganSlicesTitle.Size = new Size(392, 42);
            OrganSlicesTitle.TabIndex = 7;
            OrganSlicesTitle.Text = "Organ Slice Image Files";
            // 
            // AddOrganControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddOrganControl";
            Size = new Size(1425, 957);
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