namespace HoloRepository
{
    partial class OrganArchiveSlicePanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganArchiveSlicePanel));
            OrganSlicesImagePanel = new Panel();
            OrganName = new Label();
            numOfSlices = new Label();
            DonorId = new Label();
            DateDeath = new Label();
            Age = new Label();
            CauseOD = new Label();
            EditButton = new PictureBox();
            BinButton = new PictureBox();
            lineControl1 = new LineControl();
            ((System.ComponentModel.ISupportInitialize)EditButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinButton).BeginInit();
            SuspendLayout();
            // 
            // OrganSlicesImagePanel
            // 
            OrganSlicesImagePanel.Location = new Point(23, 18);
            OrganSlicesImagePanel.Name = "OrganSlicesImagePanel";
            OrganSlicesImagePanel.Size = new Size(484, 343);
            OrganSlicesImagePanel.TabIndex = 0;
            // 
            // OrganName
            // 
            OrganName.AutoSize = true;
            OrganName.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OrganName.Location = new Point(551, 18);
            OrganName.Name = "OrganName";
            OrganName.Size = new Size(175, 42);
            OrganName.TabIndex = 1;
            OrganName.Text = "Organ Name";
            // 
            // numOfSlices
            // 
            numOfSlices.AutoSize = true;
            numOfSlices.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            numOfSlices.Location = new Point(551, 94);
            numOfSlices.Name = "numOfSlices";
            numOfSlices.Size = new Size(275, 39);
            numOfSlices.TabIndex = 2;
            numOfSlices.Text = "Number of organ slices:";
            // 
            // DonorId
            // 
            DonorId.AutoSize = true;
            DonorId.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DonorId.Location = new Point(551, 142);
            DonorId.Name = "DonorId";
            DonorId.Size = new Size(115, 39);
            DonorId.TabIndex = 3;
            DonorId.Text = "Donor ID:";
            // 
            // DateDeath
            // 
            DateDeath.AutoSize = true;
            DateDeath.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DateDeath.Location = new Point(551, 190);
            DateDeath.Name = "DateDeath";
            DateDeath.Size = new Size(175, 39);
            DateDeath.TabIndex = 4;
            DateDeath.Text = "Date of Death:";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Age.Location = new Point(551, 240);
            Age.Name = "Age";
            Age.Size = new Size(66, 39);
            Age.TabIndex = 5;
            Age.Text = "Age:";
            // 
            // CauseOD
            // 
            CauseOD.AutoSize = true;
            CauseOD.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CauseOD.Location = new Point(551, 294);
            CauseOD.Name = "CauseOD";
            CauseOD.Size = new Size(193, 39);
            CauseOD.TabIndex = 6;
            CauseOD.Text = "Cause of Death:";
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top;
            EditButton.BackColor = Color.Transparent;
            EditButton.Cursor = Cursors.Hand;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new Point(991, 18);
            EditButton.Margin = new Padding(5);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(30, 30);
            EditButton.SizeMode = PictureBoxSizeMode.Zoom;
            EditButton.TabIndex = 77;
            EditButton.TabStop = false;
            EditButton.Click += EditButton_Click;
            // 
            // BinButton
            // 
            BinButton.Anchor = AnchorStyles.Top;
            BinButton.BackColor = Color.Transparent;
            BinButton.Image = (Image)resources.GetObject("BinButton.Image");
            BinButton.Location = new Point(1049, 18);
            BinButton.Margin = new Padding(5);
            BinButton.Name = "BinButton";
            BinButton.Size = new Size(30, 30);
            BinButton.SizeMode = PictureBoxSizeMode.Zoom;
            BinButton.TabIndex = 78;
            BinButton.TabStop = false;
            // 
            // lineControl1
            // 
            lineControl1.LineColor = Color.LightGray;
            lineControl1.LineWidth = 1;
            lineControl1.Location = new Point(0, 384);
            lineControl1.Name = "lineControl1";
            lineControl1.Size = new Size(1104, 10);
            lineControl1.TabIndex = 79;
            lineControl1.Text = "lineControl1";
            // 
            // OrganArchiveSlicePanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lineControl1);
            Controls.Add(BinButton);
            Controls.Add(EditButton);
            Controls.Add(CauseOD);
            Controls.Add(Age);
            Controls.Add(DateDeath);
            Controls.Add(DonorId);
            Controls.Add(numOfSlices);
            Controls.Add(OrganName);
            Controls.Add(OrganSlicesImagePanel);
            Name = "OrganArchiveSlicePanel";
            Size = new Size(1104, 390);
            ((System.ComponentModel.ISupportInitialize)EditButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel OrganSlicesImagePanel;
        private Label OrganName;
        private Label numOfSlices;
        private Label DonorId;
        private Label DateDeath;
        private Label Age;
        private Label CauseOD;
        private PictureBox EditButton;
        private PictureBox BinButton;
        private LineControl lineControl1;
    }
}
