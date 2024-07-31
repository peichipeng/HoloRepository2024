namespace HoloRepository
{
    partial class CheckTableContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckTableContent));
            SelectBox = new CheckBox();
            divider = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            arrowPictureBox = new PictureBox();
            organSliceTitle = new Label();
            organSlicePictureBox = new PictureBox();
            CTPictureBox = new PictureBox();
            additionalInfoTitle = new Label();
            contentPanel = new Panel();
            additionalInfoContent = new TextBox();
            borderLine = new LineControl();
            border = new LineControl();
            ((System.ComponentModel.ISupportInitialize)arrowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)organSlicePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CTPictureBox).BeginInit();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SelectBox
            // 
            SelectBox.AutoSize = true;
            SelectBox.Location = new Point(13, 15);
            SelectBox.Name = "SelectBox";
            SelectBox.Size = new Size(22, 21);
            SelectBox.TabIndex = 0;
            SelectBox.UseVisualStyleBackColor = true;
            SelectBox.CheckedChanged += SelectBox_CheckedChanged;
            // 
            // divider
            // 
            divider.Location = new Point(47, 9);
            divider.Name = "divider";
            divider.Orientation = Orientation.Vertical;
            divider.Size = new Size(1, 248);
            divider.StateCommon.Color1 = Color.LightGray;
            divider.StateCommon.Color2 = Color.LightGray;
            divider.Text = "kryptonBorderEdge1";
            // 
            // arrowPictureBox
            // 
            arrowPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            arrowPictureBox.Image = (Image)resources.GetObject("arrowPictureBox.Image");
            arrowPictureBox.Location = new Point(55, 13);
            arrowPictureBox.Name = "arrowPictureBox";
            arrowPictureBox.Size = new Size(22, 22);
            arrowPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            arrowPictureBox.TabIndex = 1;
            arrowPictureBox.TabStop = false;
            arrowPictureBox.Click += arrowPictureBox_Click;
            arrowPictureBox.Paint += arrowPictureBox_Paint;
            // 
            // organSliceTitle
            // 
            organSliceTitle.AutoSize = true;
            organSliceTitle.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            organSliceTitle.Location = new Point(83, 10);
            organSliceTitle.Name = "organSliceTitle";
            organSliceTitle.Size = new Size(371, 31);
            organSliceTitle.TabIndex = 3;
            organSliceTitle.Text = "123456789-kidney-0001-2024xxxx.png";
            // 
            // organSlicePictureBox
            // 
            organSlicePictureBox.Location = new Point(3, 3);
            organSlicePictureBox.Name = "organSlicePictureBox";
            organSlicePictureBox.Size = new Size(282, 207);
            organSlicePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            organSlicePictureBox.TabIndex = 4;
            organSlicePictureBox.TabStop = false;
            // 
            // CTPictureBox
            // 
            CTPictureBox.Location = new Point(304, 3);
            CTPictureBox.Name = "CTPictureBox";
            CTPictureBox.Size = new Size(282, 207);
            CTPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CTPictureBox.TabIndex = 5;
            CTPictureBox.TabStop = false;
            // 
            // additionalInfoTitle
            // 
            additionalInfoTitle.AutoSize = true;
            additionalInfoTitle.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            additionalInfoTitle.Location = new Point(604, 5);
            additionalInfoTitle.Name = "additionalInfoTitle";
            additionalInfoTitle.Size = new Size(219, 31);
            additionalInfoTitle.TabIndex = 6;
            additionalInfoTitle.Text = "Additional Information";
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(additionalInfoContent);
            contentPanel.Controls.Add(organSlicePictureBox);
            contentPanel.Controls.Add(CTPictureBox);
            contentPanel.Controls.Add(additionalInfoTitle);
            contentPanel.Location = new Point(55, 44);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(948, 213);
            contentPanel.TabIndex = 9;
            // 
            // additionalInfoContent
            // 
            additionalInfoContent.BorderStyle = BorderStyle.None;
            additionalInfoContent.Location = new Point(604, 39);
            additionalInfoContent.Multiline = true;
            additionalInfoContent.Name = "additionalInfoContent";
            additionalInfoContent.Size = new Size(327, 160);
            additionalInfoContent.TabIndex = 7;
            // 
            // borderLine
            // 
            borderLine.LineColor = Color.DarkGray;
            borderLine.LineWidth = 1;
            borderLine.Location = new Point(0, 263);
            borderLine.Name = "borderLine";
            borderLine.Size = new Size(1008, 10);
            borderLine.TabIndex = 10;
            borderLine.Text = "lineControl1";
            // 
            // border
            // 
            border.LineColor = Color.DarkGray;
            border.LineWidth = 1;
            border.Location = new Point(0, 38);
            border.Name = "border";
            border.Size = new Size(1008, 19);
            border.TabIndex = 12;
            border.Text = "lineControl1";
            // 
            // CheckTableContent
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(border);
            Controls.Add(borderLine);
            Controls.Add(contentPanel);
            Controls.Add(organSliceTitle);
            Controls.Add(arrowPictureBox);
            Controls.Add(divider);
            Controls.Add(SelectBox);
            Margin = new Padding(0);
            Name = "CheckTableContent";
            Size = new Size(1006, 271);
            ((System.ComponentModel.ISupportInitialize)arrowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)organSlicePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CTPictureBox).EndInit();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckBox SelectBox;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge divider;
        private PictureBox arrowPictureBox;
        private Label organSliceTitle;
        private PictureBox organSlicePictureBox;
        private PictureBox CTPictureBox;
        private Label additionalInfoTitle;
        private Panel contentPanel;
        private LineControl borderLine;
        private TextBox additionalInfoContent;
        private LineControl border;
    }
}
