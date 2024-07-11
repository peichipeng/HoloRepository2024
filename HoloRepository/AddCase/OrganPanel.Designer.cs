namespace HoloRepository.AddCase
{
    partial class OrganPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganPanel));
            sliceImages = new PictureBox();
            leftArrow = new PictureBox();
            rightArrow = new PictureBox();
            organName = new Label();
            ((System.ComponentModel.ISupportInitialize)sliceImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).BeginInit();
            SuspendLayout();
            // 
            // sliceImages
            // 
            sliceImages.BackColor = Color.Transparent;
            sliceImages.Image = (Image)resources.GetObject("sliceImages.Image");
            sliceImages.Location = new Point(15, 12);
            sliceImages.Name = "sliceImages";
            sliceImages.Size = new Size(278, 196);
            sliceImages.SizeMode = PictureBoxSizeMode.Zoom;
            sliceImages.TabIndex = 0;
            sliceImages.TabStop = false;
            // 
            // leftArrow
            // 
            leftArrow.BackColor = Color.Transparent;
            leftArrow.Image = (Image)resources.GetObject("leftArrow.Image");
            leftArrow.Location = new Point(15, 80);
            leftArrow.Name = "leftArrow";
            leftArrow.Size = new Size(26, 58);
            leftArrow.SizeMode = PictureBoxSizeMode.Zoom;
            leftArrow.TabIndex = 1;
            leftArrow.TabStop = false;
            leftArrow.MouseEnter += leftArrow_MouseEnter;
            leftArrow.MouseLeave += leftArrow_MouseLeave;
            // 
            // rightArrow
            // 
            rightArrow.BackColor = Color.Transparent;
            rightArrow.Image = (Image)resources.GetObject("rightArrow.Image");
            rightArrow.Location = new Point(267, 80);
            rightArrow.Name = "rightArrow";
            rightArrow.Size = new Size(26, 58);
            rightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            rightArrow.TabIndex = 2;
            rightArrow.TabStop = false;
            rightArrow.MouseEnter += rightArrow_MouseEnter;
            rightArrow.MouseLeave += rightArrow_MouseLeave;
            // 
            // organName
            // 
            organName.Anchor = AnchorStyles.Top;
            organName.AutoSize = true;
            organName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            organName.ForeColor = Color.Black;
            organName.Location = new Point(117, 211);
            organName.Margin = new Padding(2, 0, 2, 0);
            organName.Name = "organName";
            organName.Size = new Size(66, 19);
            organName.TabIndex = 64;
            organName.Text = "Donor ID";
            // 
            // OrganPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(organName);
            Controls.Add(rightArrow);
            Controls.Add(leftArrow);
            Controls.Add(sliceImages);
            Margin = new Padding(15, 7, 15, 7);
            Name = "OrganPanel";
            Size = new Size(308, 240);
            ((System.ComponentModel.ISupportInitialize)sliceImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sliceImages;
        private PictureBox leftArrow;
        private PictureBox rightArrow;
        private Label organName;
    }
}
