namespace HoloRepository
{
    partial class AddOrganSlice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            sliderControl1 = new SliderControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(21, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 397);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // sliderControl1
            // 
            sliderControl1.Location = new Point(625, 28);
            sliderControl1.Name = "sliderControl1";
            sliderControl1.Size = new Size(367, 34);
            sliderControl1.TabIndex = 2;
            sliderControl1.Text = "sliderControl1";
            // 
            // AddOrganSlice
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 698);
            Controls.Add(sliderControl1);
            Controls.Add(pictureBox1);
            Name = "AddOrganSlice";
            Text = "AddOrganSlice";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private SliderControl sliderControl1;
    }
}