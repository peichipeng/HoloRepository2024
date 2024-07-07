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
            DICOMFilePicture = new PictureBox();
            sliderControl1 = new SliderControl();
            OrganSlicePanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DICOMFilePicture).BeginInit();
            OrganSlicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DICOMFilePicture
            // 
            DICOMFilePicture.BorderStyle = BorderStyle.FixedSingle;
            DICOMFilePicture.Cursor = Cursors.Hand;
            DICOMFilePicture.Location = new Point(21, 46);
            DICOMFilePicture.Name = "DICOMFilePicture";
            DICOMFilePicture.Size = new Size(385, 403);
            DICOMFilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            DICOMFilePicture.TabIndex = 1;
            DICOMFilePicture.TabStop = false;
            DICOMFilePicture.Click += pictureBox1_Click;
            // 
            // sliderControl1
            // 
            sliderControl1.Location = new Point(39, 4);
            sliderControl1.Name = "sliderControl1";
            sliderControl1.NumberOfImages = 0;
            sliderControl1.Size = new Size(369, 35);
            sliderControl1.TabIndex = 2;
            sliderControl1.Text = "sliderControl1";
            sliderControl1.ImageSelected += SliderControl1_ImageSelected;
            // 
            // OrganSlicePanel
            // 
            OrganSlicePanel.Controls.Add(sliderControl1);
            OrganSlicePanel.Controls.Add(DICOMFilePicture);
            OrganSlicePanel.Location = new Point(513, 18);
            OrganSlicePanel.Margin = new Padding(4, 4, 4, 4);
            OrganSlicePanel.Name = "OrganSlicePanel";
            OrganSlicePanel.Size = new Size(429, 450);
            OrganSlicePanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(41, 18);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 449);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(87, 254);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(358, 62);
            label1.TabIndex = 5;
            label1.Text = "Click on to capture the image \r\n         of the organ slice";
            // 
            // AddOrganSlice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 815);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(OrganSlicePanel);
            Name = "AddOrganSlice";
            Text = "Add an organ slice";
            ((System.ComponentModel.ISupportInitialize)DICOMFilePicture).EndInit();
            OrganSlicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox DICOMFilePicture;
        private SliderControl sliderControl1;
        private Panel OrganSlicePanel;
        private PictureBox pictureBox1;
        private Label label1;
    }
}