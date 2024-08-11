namespace HoloRepository
{
    partial class OrganArchive3DPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganArchive3DPanel));
            leftArrow = new PictureBox();
            rightArrow = new PictureBox();
            ListPanel = new FlowLayoutPanel();
            OrganName = new Label();
            ((System.ComponentModel.ISupportInitialize)leftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).BeginInit();
            SuspendLayout();
            // 
            // leftArrow
            // 
            leftArrow.BackColor = Color.Transparent;
            leftArrow.Image = (Image)resources.GetObject("leftArrow.Image");
            leftArrow.Location = new Point(5, 108);
            leftArrow.Margin = new Padding(5);
            leftArrow.Name = "leftArrow";
            leftArrow.Size = new Size(41, 93);
            leftArrow.SizeMode = PictureBoxSizeMode.Zoom;
            leftArrow.TabIndex = 2;
            leftArrow.TabStop = false;
            leftArrow.Click += leftArrow_Click;
            // 
            // rightArrow
            // 
            rightArrow.BackColor = Color.Transparent;
            rightArrow.Image = (Image)resources.GetObject("rightArrow.Image");
            rightArrow.Location = new Point(1060, 108);
            rightArrow.Margin = new Padding(5);
            rightArrow.Name = "rightArrow";
            rightArrow.Size = new Size(41, 93);
            rightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            rightArrow.TabIndex = 3;
            rightArrow.TabStop = false;
            rightArrow.Click += rightArrow_Click;
            // 
            // ListPanel
            // 
            ListPanel.Location = new Point(54, 63);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(998, 187);
            ListPanel.TabIndex = 4;
            // 
            // OrganName
            // 
            OrganName.AutoSize = true;
            OrganName.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrganName.Location = new Point(27, 18);
            OrganName.Name = "OrganName";
            OrganName.Size = new Size(174, 42);
            OrganName.TabIndex = 0;
            OrganName.Text = "Organ Name";
            // 
            // OrganArchive3DPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListPanel);
            Controls.Add(rightArrow);
            Controls.Add(leftArrow);
            Controls.Add(OrganName);
            Name = "OrganArchive3DPanel";
            Size = new Size(1110, 268);
            ((System.ComponentModel.ISupportInitialize)leftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox leftArrow;
        private PictureBox rightArrow;
        public FlowLayoutPanel ListPanel;
        private Label OrganName;
    }
}
