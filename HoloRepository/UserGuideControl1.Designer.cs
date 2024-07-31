namespace HoloRepository
{
    partial class UserGuideControl1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            btnUpload = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(537, 675);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(368, 200);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(466, 443);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // UserGuideControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox);
            Controls.Add(btnUpload);
            Margin = new Padding(6);
            Name = "UserGuideControl";
            Size = new Size(1425, 957);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpload;
        private PictureBox pictureBox;
    }
}
