namespace HoloRepository
{
    partial class InfoPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoPanel));
            organNameLabel = new Label();
            tagLabel = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            overallPanel = new FlowLayoutPanel();
            organNamePanel = new Panel();
            tagPanel = new FlowLayoutPanel();
            displayPanel = new Panel();
            CoDPanel = new Panel();
            CoDLabel = new Label();
            agePanel = new Panel();
            ageLabel = new Label();
            DoDPanel = new Panel();
            DoDLabel = new Label();
            donorIdPanel = new Panel();
            donorIdLabel = new Label();
            resizePanel = new Panel();
            btnResize = new PictureBox();
            overallPanel.SuspendLayout();
            organNamePanel.SuspendLayout();
            tagPanel.SuspendLayout();
            displayPanel.SuspendLayout();
            CoDPanel.SuspendLayout();
            agePanel.SuspendLayout();
            DoDPanel.SuspendLayout();
            donorIdPanel.SuspendLayout();
            resizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnResize).BeginInit();
            SuspendLayout();
            // 
            // organNameLabel
            // 
            organNameLabel.AutoSize = true;
            organNameLabel.Font = new Font("Poppins", 12F, FontStyle.Italic, GraphicsUnit.Point);
            organNameLabel.Location = new Point(4, 6);
            organNameLabel.Name = "organNameLabel";
            organNameLabel.Size = new Size(93, 42);
            organNameLabel.TabIndex = 0;
            organNameLabel.Text = "Organ";
            // 
            // tagLabel
            // 
            tagLabel.AlwaysActive = false;
            tagLabel.Enabled = false;
            tagLabel.Location = new Point(3, 3);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new Size(162, 42);
            tagLabel.StateActive.Back.Color1 = Color.WhiteSmoke;
            tagLabel.StateActive.Border.Color1 = Color.FromArgb(165, 165, 165);
            tagLabel.StateActive.Border.Color2 = Color.FromArgb(165, 165, 165);
            tagLabel.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            tagLabel.StateActive.Border.Rounding = 5;
            tagLabel.StateActive.Border.Width = 1;
            tagLabel.StateActive.Content.Color1 = Color.Black;
            tagLabel.StateActive.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tagLabel.StateCommon.Back.Color1 = Color.WhiteSmoke;
            tagLabel.StateCommon.Border.Color1 = Color.FromArgb(165, 165, 165);
            tagLabel.StateCommon.Border.Color2 = Color.FromArgb(165, 165, 165);
            tagLabel.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            tagLabel.StateCommon.Border.Rounding = 5;
            tagLabel.StateCommon.Border.Width = 1;
            tagLabel.StateCommon.Content.Color1 = Color.Black;
            tagLabel.StateCommon.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tagLabel.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tagLabel.StateDisabled.Border.Color1 = Color.FromArgb(165, 165, 165);
            tagLabel.StateDisabled.Border.Color2 = Color.FromArgb(165, 165, 165);
            tagLabel.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            tagLabel.StateDisabled.Border.Rounding = 5;
            tagLabel.StateDisabled.Border.Width = 1;
            tagLabel.StateDisabled.Content.Color1 = Color.Black;
            tagLabel.StateDisabled.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tagLabel.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tagLabel.StateNormal.Border.Color1 = Color.FromArgb(165, 165, 165);
            tagLabel.StateNormal.Border.Color2 = Color.FromArgb(165, 165, 165);
            tagLabel.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            tagLabel.StateNormal.Border.Rounding = 5;
            tagLabel.StateNormal.Border.Width = 1;
            tagLabel.StateNormal.Content.Color1 = Color.Black;
            tagLabel.StateNormal.Content.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tagLabel.TabIndex = 1;
            tagLabel.Text = "kryptonTextBox1";
            // 
            // overallPanel
            // 
            overallPanel.AutoSize = true;
            overallPanel.Controls.Add(organNamePanel);
            overallPanel.Controls.Add(tagPanel);
            overallPanel.Controls.Add(displayPanel);
            overallPanel.Controls.Add(resizePanel);
            overallPanel.Dock = DockStyle.Fill;
            overallPanel.FlowDirection = FlowDirection.TopDown;
            overallPanel.Location = new Point(0, 0);
            overallPanel.Name = "overallPanel";
            overallPanel.Size = new Size(288, 315);
            overallPanel.TabIndex = 2;
            // 
            // organNamePanel
            // 
            organNamePanel.Controls.Add(organNameLabel);
            organNamePanel.Location = new Point(0, 0);
            organNamePanel.Margin = new Padding(0);
            organNamePanel.Name = "organNamePanel";
            organNamePanel.Size = new Size(285, 51);
            organNamePanel.TabIndex = 3;
            // 
            // tagPanel
            // 
            tagPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tagPanel.Controls.Add(tagLabel);
            tagPanel.Location = new Point(3, 54);
            tagPanel.Name = "tagPanel";
            tagPanel.Size = new Size(282, 44);
            tagPanel.TabIndex = 7;
            // 
            // displayPanel
            // 
            displayPanel.AutoSize = true;
            displayPanel.Controls.Add(CoDPanel);
            displayPanel.Controls.Add(agePanel);
            displayPanel.Controls.Add(DoDPanel);
            displayPanel.Controls.Add(donorIdPanel);
            displayPanel.Location = new Point(0, 101);
            displayPanel.Margin = new Padding(0);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(288, 171);
            displayPanel.TabIndex = 5;
            displayPanel.Visible = false;
            // 
            // CoDPanel
            // 
            CoDPanel.AutoSize = true;
            CoDPanel.Controls.Add(CoDLabel);
            CoDPanel.Location = new Point(0, 126);
            CoDPanel.Name = "CoDPanel";
            CoDPanel.Size = new Size(285, 42);
            CoDPanel.TabIndex = 7;
            // 
            // CoDLabel
            // 
            CoDLabel.AutoSize = true;
            CoDLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CoDLabel.Location = new Point(4, 6);
            CoDLabel.Name = "CoDLabel";
            CoDLabel.Size = new Size(159, 31);
            CoDLabel.TabIndex = 0;
            CoDLabel.Text = "Cause of Death:";
            // 
            // agePanel
            // 
            agePanel.Controls.Add(ageLabel);
            agePanel.Location = new Point(0, 85);
            agePanel.Name = "agePanel";
            agePanel.Size = new Size(285, 42);
            agePanel.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.Location = new Point(4, 6);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(53, 31);
            ageLabel.TabIndex = 0;
            ageLabel.Text = "Age:";
            // 
            // DoDPanel
            // 
            DoDPanel.Controls.Add(DoDLabel);
            DoDPanel.Location = new Point(0, 44);
            DoDPanel.Name = "DoDPanel";
            DoDPanel.Size = new Size(285, 42);
            DoDPanel.TabIndex = 5;
            // 
            // DoDLabel
            // 
            DoDLabel.AutoSize = true;
            DoDLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DoDLabel.Location = new Point(4, 6);
            DoDLabel.Name = "DoDLabel";
            DoDLabel.Size = new Size(144, 31);
            DoDLabel.TabIndex = 0;
            DoDLabel.Text = "Date of Death:";
            // 
            // donorIdPanel
            // 
            donorIdPanel.Controls.Add(donorIdLabel);
            donorIdPanel.Location = new Point(0, 3);
            donorIdPanel.Name = "donorIdPanel";
            donorIdPanel.Size = new Size(285, 42);
            donorIdPanel.TabIndex = 4;
            // 
            // donorIdLabel
            // 
            donorIdLabel.AutoSize = true;
            donorIdLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            donorIdLabel.Location = new Point(4, 6);
            donorIdLabel.Name = "donorIdLabel";
            donorIdLabel.Size = new Size(96, 31);
            donorIdLabel.TabIndex = 0;
            donorIdLabel.Text = "Donor ID:";
            // 
            // resizePanel
            // 
            resizePanel.Controls.Add(btnResize);
            resizePanel.Location = new Point(0, 272);
            resizePanel.Margin = new Padding(0);
            resizePanel.Name = "resizePanel";
            resizePanel.Size = new Size(285, 35);
            resizePanel.TabIndex = 6;
            // 
            // btnResize
            // 
            btnResize.Anchor = AnchorStyles.Top;
            btnResize.BackColor = Color.Transparent;
            btnResize.Cursor = Cursors.Hand;
            btnResize.Image = (Image)resources.GetObject("btnResize.Image");
            btnResize.Location = new Point(122, 5);
            btnResize.Margin = new Padding(5);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(40, 25);
            btnResize.SizeMode = PictureBoxSizeMode.Zoom;
            btnResize.TabIndex = 86;
            btnResize.TabStop = false;
            btnResize.Click += btnResize_Click;
            // 
            // InfoPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(overallPanel);
            Name = "InfoPanel";
            Size = new Size(288, 315);
            overallPanel.ResumeLayout(false);
            overallPanel.PerformLayout();
            organNamePanel.ResumeLayout(false);
            organNamePanel.PerformLayout();
            tagPanel.ResumeLayout(false);
            tagPanel.PerformLayout();
            displayPanel.ResumeLayout(false);
            displayPanel.PerformLayout();
            CoDPanel.ResumeLayout(false);
            CoDPanel.PerformLayout();
            agePanel.ResumeLayout(false);
            agePanel.PerformLayout();
            DoDPanel.ResumeLayout(false);
            DoDPanel.PerformLayout();
            donorIdPanel.ResumeLayout(false);
            donorIdPanel.PerformLayout();
            resizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnResize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label organNameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tagLabel;
        private FlowLayoutPanel overallPanel;
        private Panel organNamePanel;
        private Panel displayPanel;
        private Panel DoDPanel;
        private Label DoDLabel;
        private Panel donorIdPanel;
        private Label donorIdLabel;
        private Panel CoDPanel;
        private Label CoDLabel;
        private Panel agePanel;
        private Label ageLabel;
        private Panel resizePanel;
        private PictureBox btnResize;
        private FlowLayoutPanel tagPanel;
    }
}
