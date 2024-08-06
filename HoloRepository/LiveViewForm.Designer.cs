namespace HoloRepository
{
    partial class LiveViewForm
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

        private void InitializeComponent()
        {
            this.liveViewPictureBox = new System.Windows.Forms.PictureBox();
            this.captureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.liveViewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // liveViewPictureBox
            // 
            this.liveViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liveViewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.liveViewPictureBox.Name = "liveViewPictureBox";
            this.liveViewPictureBox.Size = new System.Drawing.Size(800, 400);
            this.liveViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.liveViewPictureBox.TabIndex = 0;
            this.liveViewPictureBox.TabStop = false;
            // 
            // LiveViewForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liveViewPictureBox);
            this.Controls.Add(this.captureButton);
            this.Name = "LiveViewForm";
            this.Text = "Live View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LiveViewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.liveViewPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}