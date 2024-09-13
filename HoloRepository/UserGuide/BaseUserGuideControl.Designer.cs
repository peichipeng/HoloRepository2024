namespace HoloRepository.UserGuide
{
    partial class BaseUserGuideControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseUserGuideControl));
            searchIcon = new PictureBox();
            pageNameLabel = new Label();
            searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            SuspendLayout();
            // 
            // searchIcon
            // 
            searchIcon.Anchor = AnchorStyles.Top;
            searchIcon.BackColor = Color.Transparent;
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(266, 123);
            searchIcon.Margin = new Padding(5);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(25, 25);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 83;
            searchIcon.TabStop = false;
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(515, 29);
            pageNameLabel.Margin = new Padding(22, 0, 3, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(270, 58);
            pageNameLabel.TabIndex = 82;
            pageNameLabel.Text = "View Cases";
            pageNameLabel.ClientSizeChanged += pageNameLabel_ClientSizeChanged;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top;
            searchBox.Location = new Point(259, 117);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(800, 35);
            searchBox.StateCommon.Border.Color1 = Color.LightGray;
            searchBox.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            searchBox.StateCommon.Border.Rounding = 3;
            searchBox.StateCommon.Border.Width = 1;
            searchBox.StateCommon.Content.Color1 = Color.DarkGray;
            searchBox.StateCommon.Content.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.StateCommon.Content.Padding = new Padding(30, 5, -1, -1);
            searchBox.TabIndex = 81;
            searchBox.Text = "Search Keywords";
            // 
            // BaseUserGuideControl
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(searchIcon);
            Controls.Add(pageNameLabel);
            Controls.Add(searchBox);
            Margin = new Padding(5);
            Name = "BaseUserGuideControl";
            Size = new Size(1329, 682);
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox searchIcon;
        public Label pageNameLabel;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
    }
}
