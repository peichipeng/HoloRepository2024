namespace HoloRepository.CasePageControls.Footer
{
    partial class FooterAddInfo
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
            nextBtn = new RoundedButton();
            cancelBtn = new RoundedButton();
            SuspendLayout();
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.BackColor = Color.FromArgb(51, 129, 202);
            nextBtn.BorderRadius = 15;
            nextBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(956, 62);
            nextBtn.Margin = new Padding(3, 3, 20, 3);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(116, 51);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.None;
            cancelBtn.BackColor = Color.FromArgb(180, 63, 63);
            cancelBtn.BorderRadius = 15;
            cancelBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(71, 62);
            cancelBtn.Margin = new Padding(20, 3, 3, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(116, 51);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // FooterAddInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nextBtn);
            Controls.Add(cancelBtn);
            Name = "FooterAddInfo";
            Size = new Size(1143, 175);
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton nextBtn;
        private RoundedButton cancelBtn;
    }
}
