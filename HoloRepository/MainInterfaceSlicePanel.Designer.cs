namespace HoloRepository
{
    partial class MainInterfaceSlicePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterfaceSlicePanel));
            leftArrow = new PictureBox();
            rightArrow = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)leftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // leftArrow
            // 
            leftArrow.BackColor = Color.Transparent;
            leftArrow.Cursor = Cursors.Hand;
            leftArrow.Image = (Image)resources.GetObject("leftArrow.Image");
            leftArrow.Location = new Point(92, 33);
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
            rightArrow.Cursor = Cursors.Hand;
            rightArrow.Image = (Image)resources.GetObject("rightArrow.Image");
            rightArrow.Location = new Point(805, 33);
            rightArrow.Margin = new Padding(5);
            rightArrow.Name = "rightArrow";
            rightArrow.Size = new Size(41, 93);
            rightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            rightArrow.TabIndex = 3;
            rightArrow.TabStop = false;
            rightArrow.Click += rightArrow_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(154, 12);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(370, 12);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 89;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(587, 12);
            pictureBox3.Margin = new Padding(5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(194, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 90;
            pictureBox3.TabStop = false;
            // 
            // MainInterfaceSlicePanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rightArrow);
            Controls.Add(leftArrow);
            Name = "MainInterfaceSlicePanel";
            Size = new Size(938, 150);
            ((System.ComponentModel.ISupportInitialize)leftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox leftArrow;
        private PictureBox rightArrow;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
