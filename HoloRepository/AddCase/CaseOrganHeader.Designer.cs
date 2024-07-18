namespace HoloRepository.AddCase
{
    partial class CaseOrganHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseOrganHeader));
            deleteCaseBtn = new PictureBox();
            caseNoLabel = new Label();
            divider = new MaterialSkin.Controls.MaterialDivider();
            pageNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)deleteCaseBtn).BeginInit();
            SuspendLayout();
            // 
            // deleteCaseBtn
            // 
            deleteCaseBtn.Anchor = AnchorStyles.None;
            deleteCaseBtn.BackColor = Color.Transparent;
            deleteCaseBtn.Image = (Image)resources.GetObject("deleteCaseBtn.Image");
            deleteCaseBtn.Location = new Point(516, 13);
            deleteCaseBtn.Name = "deleteCaseBtn";
            deleteCaseBtn.Size = new Size(26, 24);
            deleteCaseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            deleteCaseBtn.TabIndex = 59;
            deleteCaseBtn.TabStop = false;
            deleteCaseBtn.Click += deleteCaseBtn_Click;
            // 
            // caseNoLabel
            // 
            caseNoLabel.Anchor = AnchorStyles.Top;
            caseNoLabel.AutoSize = true;
            caseNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            caseNoLabel.ForeColor = Color.Black;
            caseNoLabel.Location = new Point(604, 35);
            caseNoLabel.Margin = new Padding(2, 0, 2, 0);
            caseNoLabel.Name = "caseNoLabel";
            caseNoLabel.Size = new Size(128, 21);
            caseNoLabel.TabIndex = 58;
            caseNoLabel.Text = "Case 123456789";
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top;
            divider.BackColor = Color.DarkGray;
            divider.Depth = 0;
            divider.Location = new Point(70, 58);
            divider.Margin = new Padding(2);
            divider.MouseState = MaterialSkin.MouseState.HOVER;
            divider.Name = "divider";
            divider.Size = new Size(662, 1);
            divider.TabIndex = 57;
            divider.Text = "materialDivider1";
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Microsoft YaHei UI", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(69, 13);
            pageNameLabel.Margin = new Padding(14, 0, 2, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(190, 40);
            pageNameLabel.TabIndex = 56;
            pageNameLabel.Text = "Add a Case";
            // 
            // CaseOrganHeader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteCaseBtn);
            Controls.Add(caseNoLabel);
            Controls.Add(divider);
            Controls.Add(pageNameLabel);
            Name = "CaseOrganHeader";
            Size = new Size(800, 64);
            ((System.ComponentModel.ISupportInitialize)deleteCaseBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox deleteCaseBtn;
        private Label caseNoLabel;
        private MaterialSkin.Controls.MaterialDivider divider;
        public Label pageNameLabel;
    }
}
