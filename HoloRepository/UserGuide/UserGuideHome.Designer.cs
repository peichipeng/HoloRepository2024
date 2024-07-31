namespace HoloRepository.UserGuide
{
    partial class UserGuideHome
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
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.Size = new Size(178, 39);
            pageNameLabel.Text = "User Guide";
            // 
            // searchBox
            // 
            searchBox.StateCommon.Border.Color1 = Color.LightGray;
            searchBox.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            searchBox.StateCommon.Border.Rounding = 3;
            searchBox.StateCommon.Border.Width = 1;
            searchBox.StateCommon.Content.Color1 = Color.DarkGray;
            searchBox.StateCommon.Content.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.StateCommon.Content.Padding = new Padding(30, 5, -1, -1);
            // 
            // UserGuideHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "UserGuideHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
