namespace HoloRepository
{
    partial class VoiceControl
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
            voicePicture = new PictureBox();
            keyboardPicture = new PictureBox();
            kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)voicePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)keyboardPicture).BeginInit();
            SuspendLayout();
            // 
            // voicePicture
            // 
            voicePicture.BackColor = Color.FromArgb(226, 226, 226);
            voicePicture.Cursor = Cursors.Hand;
            voicePicture.Image = Properties.Resources.microphone_gray;
            voicePicture.Location = new Point(82, 8);
            voicePicture.Name = "voicePicture";
            voicePicture.Size = new Size(52, 49);
            voicePicture.SizeMode = PictureBoxSizeMode.Zoom;
            voicePicture.TabIndex = 1;
            voicePicture.TabStop = false;
            voicePicture.Click += voicePicture_Click;
            // 
            // keyboardPicture
            // 
            keyboardPicture.BackColor = Color.FromArgb(226, 226, 226);
            keyboardPicture.Cursor = Cursors.Hand;
            keyboardPicture.Image = Properties.Resources.keyboard_blue;
            keyboardPicture.Location = new Point(4, 3);
            keyboardPicture.Name = "keyboardPicture";
            keyboardPicture.Size = new Size(78, 58);
            keyboardPicture.SizeMode = PictureBoxSizeMode.Zoom;
            keyboardPicture.TabIndex = 2;
            keyboardPicture.TabStop = false;
            keyboardPicture.Click += keyboardPicture_Click;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Enabled = false;
            kryptonTextBox1.Location = new Point(0, 0);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(139, 65);
            kryptonTextBox1.StateActive.Back.Color1 = Color.FromArgb(226, 226, 226);
            kryptonTextBox1.StateActive.Border.Color1 = Color.Transparent;
            kryptonTextBox1.StateActive.Border.Color2 = Color.Transparent;
            kryptonTextBox1.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateActive.Border.Rounding = 10;
            kryptonTextBox1.StateCommon.Back.Color1 = Color.FromArgb(226, 226, 226);
            kryptonTextBox1.StateCommon.Border.Color1 = Color.Transparent;
            kryptonTextBox1.StateCommon.Border.Color2 = Color.Transparent;
            kryptonTextBox1.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 10;
            kryptonTextBox1.StateDisabled.Back.Color1 = Color.FromArgb(226, 226, 226);
            kryptonTextBox1.StateDisabled.Border.Color1 = Color.Transparent;
            kryptonTextBox1.StateDisabled.Border.Color2 = Color.Transparent;
            kryptonTextBox1.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateDisabled.Border.Rounding = 10;
            kryptonTextBox1.StateNormal.Back.Color1 = Color.FromArgb(226, 226, 226);
            kryptonTextBox1.StateNormal.Border.Color1 = Color.Transparent;
            kryptonTextBox1.StateNormal.Border.Color2 = Color.Transparent;
            kryptonTextBox1.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateNormal.Border.Rounding = 10;
            kryptonTextBox1.TabIndex = 3;
            // 
            // VoiceControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(voicePicture);
            Controls.Add(keyboardPicture);
            Controls.Add(kryptonTextBox1);
            Name = "VoiceControl";
            Size = new Size(140, 68);
            ((System.ComponentModel.ISupportInitialize)voicePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)keyboardPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox voicePicture;
        private PictureBox keyboardPicture;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}
