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
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.AccessibleDescription = "";
            kryptonTextBox1.AlwaysActive = false;
            kryptonTextBox1.Location = new Point(262, 266);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonTextBox1.Size = new Size(405, 81);
            kryptonTextBox1.StateActive.Back.Color1 = Color.White;
            kryptonTextBox1.StateActive.Border.Color1 = Color.FromArgb(201, 201, 201);
            kryptonTextBox1.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateActive.Border.Rounding = 5;
            kryptonTextBox1.StateActive.Border.Width = 1;
            kryptonTextBox1.StateActive.Content.Color1 = Color.Black;
            kryptonTextBox1.StateActive.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBox1.StateActive.Content.Padding = new Padding(4, 8, 4, 8);
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Transparent;
            kryptonTextBox1.StateCommon.Content.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonTextBox1.StateNormal.Back.Color1 = Color.White;
            kryptonTextBox1.StateNormal.Border.Color1 = Color.FromArgb(201, 201, 201);
            kryptonTextBox1.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateNormal.Border.Rounding = 5;
            kryptonTextBox1.StateNormal.Border.Width = 1;
            kryptonTextBox1.StateNormal.Content.Color1 = Color.DimGray;
            kryptonTextBox1.StateNormal.Content.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBox1.StateNormal.Content.Padding = new Padding(4, 8, 4, 8);
            kryptonTextBox1.TabIndex = 0;
            kryptonTextBox1.Text = "Describe additional information about the organ slice ...\r\n\r\n";
            // 
            // UserGuideControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonTextBox1);
            Margin = new Padding(4);
            Name = "UserGuideControl";
            Size = new Size(907, 598);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}
