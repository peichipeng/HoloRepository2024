namespace HoloRepository
{
    partial class UserGuideControl
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Items.AddRange(new object[] { "1213", "123", "123", "123" });
            listBox1.Location = new Point(375, 288);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(425, 292);
            listBox1.TabIndex = 0;
            // 
            // UserGuideControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "UserGuideControl";
            Size = new Size(1425, 957);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}
