namespace HoloRepository.UserGuide
{
    partial class GuidePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuidePanel));
            imageContainer = new PictureBox();
            guideTitleLabel = new Label();
            seeDetailsLabel = new Label();
            guideDescriptionLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imageContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageContainer
            // 
            imageContainer.Location = new Point(6, 13);
            imageContainer.Name = "imageContainer";
            imageContainer.Size = new Size(65, 65);
            imageContainer.SizeMode = PictureBoxSizeMode.Zoom;
            imageContainer.TabIndex = 0;
            imageContainer.TabStop = false;
            // 
            // guideTitleLabel
            // 
            guideTitleLabel.Anchor = AnchorStyles.Top;
            guideTitleLabel.AutoSize = true;
            guideTitleLabel.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            guideTitleLabel.ForeColor = Color.Black;
            guideTitleLabel.Location = new Point(73, 16);
            guideTitleLabel.Margin = new Padding(2, 0, 2, 0);
            guideTitleLabel.Name = "guideTitleLabel";
            guideTitleLabel.Size = new Size(217, 23);
            guideTitleLabel.TabIndex = 63;
            guideTitleLabel.Text = "Donor's Basic Information";
            // 
            // seeDetailsLabel
            // 
            seeDetailsLabel.Anchor = AnchorStyles.Top;
            seeDetailsLabel.AutoSize = true;
            seeDetailsLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            seeDetailsLabel.ForeColor = Color.Black;
            seeDetailsLabel.Location = new Point(19, 92);
            seeDetailsLabel.Margin = new Padding(2, 0, 2, 0);
            seeDetailsLabel.Name = "seeDetailsLabel";
            seeDetailsLabel.Size = new Size(73, 17);
            seeDetailsLabel.TabIndex = 65;
            seeDetailsLabel.Text = "See Details";
            // 
            // guideDescriptionLabel
            // 
            guideDescriptionLabel.Anchor = AnchorStyles.Top;
            guideDescriptionLabel.AutoSize = true;
            guideDescriptionLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            guideDescriptionLabel.ForeColor = Color.DimGray;
            guideDescriptionLabel.Location = new Point(76, 51);
            guideDescriptionLabel.Margin = new Padding(2, 0, 2, 0);
            guideDescriptionLabel.MaximumSize = new Size(230, 0);
            guideDescriptionLabel.Name = "guideDescriptionLabel";
            guideDescriptionLabel.Size = new Size(63, 13);
            guideDescriptionLabel.TabIndex = 66;
            guideDescriptionLabel.Text = "See Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // GuidePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(guideDescriptionLabel);
            Controls.Add(seeDetailsLabel);
            Controls.Add(guideTitleLabel);
            Controls.Add(imageContainer);
            Name = "GuidePanel";
            Size = new Size(310, 120);
            Click += GuidePanel_Click;
            ((System.ComponentModel.ISupportInitialize)imageContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imageContainer;
        private Label guideTitleLabel;
        private Label seeDetailsLabel;
        private Label guideDescriptionLabel;
        private PictureBox pictureBox1;
    }
}
