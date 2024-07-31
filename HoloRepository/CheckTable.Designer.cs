namespace HoloRepository
{
    partial class CheckTable
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
            SelectAll = new CheckBox();
            HeadLine1 = new LineControl();
            HeadLine2 = new LineControl();
            panel1 = new Panel();
            FILENAME = new Label();
            kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectAll
            // 
            SelectAll.Anchor = AnchorStyles.None;
            SelectAll.AutoSize = true;
            SelectAll.Location = new Point(13, 14);
            SelectAll.Name = "SelectAll";
            SelectAll.Size = new Size(22, 21);
            SelectAll.TabIndex = 0;
            SelectAll.UseVisualStyleBackColor = true;
            SelectAll.CheckedChanged += SelectAll_CheckedChanged;
            // 
            // HeadLine1
            // 
            HeadLine1.LineColor = Color.DarkGray;
            HeadLine1.LineWidth = 1;
            HeadLine1.Location = new Point(0, 43);
            HeadLine1.Name = "HeadLine1";
            HeadLine1.Size = new Size(1006, 10);
            HeadLine1.TabIndex = 1;
            HeadLine1.Text = "lineControl1";
            // 
            // HeadLine2
            // 
            HeadLine2.LineColor = Color.DarkGray;
            HeadLine2.LineWidth = 1;
            HeadLine2.Location = new Point(0, -4);
            HeadLine2.Name = "HeadLine2";
            HeadLine2.Size = new Size(1006, 10);
            HeadLine2.TabIndex = 2;
            HeadLine2.Text = "lineControl1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(FILENAME);
            panel1.Controls.Add(kryptonBorderEdge1);
            panel1.Controls.Add(SelectAll);
            panel1.Controls.Add(HeadLine2);
            panel1.Controls.Add(HeadLine1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 49);
            panel1.TabIndex = 3;
            // 
            // FILENAME
            // 
            FILENAME.Anchor = AnchorStyles.None;
            FILENAME.AutoSize = true;
            FILENAME.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FILENAME.Location = new Point(55, 9);
            FILENAME.Name = "FILENAME";
            FILENAME.Size = new Size(99, 31);
            FILENAME.TabIndex = 4;
            FILENAME.Text = "FILENAME";
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Anchor = AnchorStyles.None;
            kryptonBorderEdge1.Location = new Point(47, 9);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Orientation = Orientation.Vertical;
            kryptonBorderEdge1.Size = new Size(1, 31);
            kryptonBorderEdge1.StateCommon.Color1 = Color.DarkGray;
            kryptonBorderEdge1.StateCommon.Color2 = Color.DarkGray;
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1006, 147);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // CheckTable
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(243, 243, 243);
            Controls.Add(flowLayoutPanel1);
            Name = "CheckTable";
            Size = new Size(1006, 148);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox SelectAll;
        private LineControl HeadLine1;
        private LineControl HeadLine2;
        private Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Label FILENAME;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
