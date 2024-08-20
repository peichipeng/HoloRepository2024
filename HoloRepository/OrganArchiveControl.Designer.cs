namespace HoloRepository
{
    partial class OrganArchiveControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganArchiveControl));
            OrganArchivePanel = new Panel();
            placeholder = new Label();
            OrganDisplayPanel = new FlowLayoutPanel();
            TabControl = new CustomTabControl();
            SearchIcon = new PictureBox();
            OrganArchiveSearchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            OrganArchiveTitle = new Label();
            OrganArchivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
            SuspendLayout();
            // 
            // OrganArchivePanel
            // 
            OrganArchivePanel.Controls.Add(placeholder);
            OrganArchivePanel.Controls.Add(OrganDisplayPanel);
            OrganArchivePanel.Controls.Add(TabControl);
            OrganArchivePanel.Controls.Add(SearchIcon);
            OrganArchivePanel.Controls.Add(OrganArchiveSearchBox);
            OrganArchivePanel.Controls.Add(OrganArchiveTitle);
            OrganArchivePanel.Dock = DockStyle.Fill;
            OrganArchivePanel.Location = new Point(0, 0);
            OrganArchivePanel.Name = "OrganArchivePanel";
            OrganArchivePanel.Size = new Size(1425, 1300);
            OrganArchivePanel.TabIndex = 0;
            // 
            // placeholder
            // 
            placeholder.Anchor = AnchorStyles.Top;
            placeholder.AutoSize = true;
            placeholder.ForeColor = Color.Gray;
            placeholder.Location = new Point(353, 156);
            placeholder.Name = "placeholder";
            placeholder.Size = new Size(120, 24);
            placeholder.TabIndex = 5;
            placeholder.Text = "Search Cases";
            placeholder.Click += placeholder_Click;
            // 
            // OrganDisplayPanel
            // 
            OrganDisplayPanel.Anchor = AnchorStyles.Top;
            OrganDisplayPanel.AutoScroll = true;
            OrganDisplayPanel.FlowDirection = FlowDirection.TopDown;
            OrganDisplayPanel.Location = new Point(160, 302);
            OrganDisplayPanel.Name = "OrganDisplayPanel";
            OrganDisplayPanel.Size = new Size(1144, 995);
            OrganDisplayPanel.TabIndex = 4;
            OrganDisplayPanel.WrapContents = false;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top;
            TabControl.Location = new Point(160, 224);
            TabControl.Margin = new Padding(4);
            TabControl.Name = "TabControl";
            TabControl.Size = new Size(1104, 71);
            TabControl.TabIndex = 3;
            TabControl.TabChanged += CustomTabControl_TabChanged;
            // 
            // SearchIcon
            // 
            SearchIcon.Anchor = AnchorStyles.Top;
            SearchIcon.BackgroundImage = (Image)resources.GetObject("SearchIcon.BackgroundImage");
            SearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            SearchIcon.Location = new Point(317, 151);
            SearchIcon.Name = "SearchIcon";
            SearchIcon.Size = new Size(33, 33);
            SearchIcon.TabIndex = 2;
            SearchIcon.TabStop = false;
            // 
            // OrganArchiveSearchBox
            // 
            OrganArchiveSearchBox.Anchor = AnchorStyles.Top;
            OrganArchiveSearchBox.Location = new Point(311, 145);
            OrganArchiveSearchBox.Name = "OrganArchiveSearchBox";
            OrganArchiveSearchBox.Size = new Size(831, 46);
            OrganArchiveSearchBox.StateActive.Border.Color1 = Color.Silver;
            OrganArchiveSearchBox.StateActive.Border.Color2 = Color.Silver;
            OrganArchiveSearchBox.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            OrganArchiveSearchBox.StateActive.Border.Rounding = 5;
            OrganArchiveSearchBox.StateActive.Content.Padding = new Padding(40, 8, 8, 8);
            OrganArchiveSearchBox.TabIndex = 1;
            OrganArchiveSearchBox.TextChanged += OrganArchiveSearchBox_TextChanged;
            OrganArchiveSearchBox.GotFocus += OrganArchiveSearchBox_GotFocus;
            OrganArchiveSearchBox.LostFocus += OrganArchiveSearchBox_LostFocus;
            // 
            // OrganArchiveTitle
            // 
            OrganArchiveTitle.Anchor = AnchorStyles.Top;
            OrganArchiveTitle.AutoSize = true;
            OrganArchiveTitle.Font = new Font("Poppins SemiBold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            OrganArchiveTitle.Location = new Point(504, 39);
            OrganArchiveTitle.Name = "OrganArchiveTitle";
            OrganArchiveTitle.Size = new Size(417, 92);
            OrganArchiveTitle.TabIndex = 0;
            OrganArchiveTitle.Text = "Organ Archive";
            // 
            // OrganArchiveControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(OrganArchivePanel);
            Name = "OrganArchiveControl";
            Size = new Size(1425, 1300);
            OrganArchivePanel.ResumeLayout(false);
            OrganArchivePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel OrganArchivePanel;
        private Label OrganArchiveTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox OrganArchiveSearchBox;
        private PictureBox SearchIcon;
        private CustomTabControl TabControl;
        private FlowLayoutPanel OrganDisplayPanel;
        private Label placeholder;
    }
}
