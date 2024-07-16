namespace HoloRepository.AddCase
{
    partial class CaseOrganFramework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseOrganFramework));
            header = new Panel();
            deleteCaseBtn = new PictureBox();
            caseNoLabel = new Label();
            divider = new MaterialSkin.Controls.MaterialDivider();
            pageNameLabel = new Label();
            caseOrganContainer = new Panel();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deleteCaseBtn).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(deleteCaseBtn);
            header.Controls.Add(caseNoLabel);
            header.Controls.Add(divider);
            header.Controls.Add(pageNameLabel);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(800, 64);
            header.TabIndex = 0;
            // 
            // deleteCaseBtn
            // 
            deleteCaseBtn.Anchor = AnchorStyles.None;
            deleteCaseBtn.BackColor = Color.Transparent;
            deleteCaseBtn.Image = (Image)resources.GetObject("deleteCaseBtn.Image");
            deleteCaseBtn.Location = new Point(515, 13);
            deleteCaseBtn.Name = "deleteCaseBtn";
            deleteCaseBtn.Size = new Size(26, 24);
            deleteCaseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            deleteCaseBtn.TabIndex = 55;
            deleteCaseBtn.TabStop = false;
            deleteCaseBtn.Click += deleteCaseBtn_Click;
            // 
            // caseNoLabel
            // 
            caseNoLabel.Anchor = AnchorStyles.Top;
            caseNoLabel.AutoSize = true;
            caseNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            caseNoLabel.ForeColor = Color.Black;
            caseNoLabel.Location = new Point(603, 35);
            caseNoLabel.Margin = new Padding(2, 0, 2, 0);
            caseNoLabel.Name = "caseNoLabel";
            caseNoLabel.Size = new Size(128, 21);
            caseNoLabel.TabIndex = 54;
            caseNoLabel.Text = "Case 123456789";
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top;
            divider.BackColor = Color.DarkGray;
            divider.Depth = 0;
            divider.Location = new Point(69, 58);
            divider.Margin = new Padding(2);
            divider.MouseState = MaterialSkin.MouseState.HOVER;
            divider.Name = "divider";
            divider.Size = new Size(662, 1);
            divider.TabIndex = 53;
            divider.Text = "materialDivider1";
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Microsoft YaHei UI", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(68, 13);
            pageNameLabel.Margin = new Padding(14, 0, 2, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(190, 40);
            pageNameLabel.TabIndex = 52;
            pageNameLabel.Text = "Add a Case";
            // 
            // caseOrganContainer
            // 
            caseOrganContainer.Dock = DockStyle.Fill;
            caseOrganContainer.Location = new Point(0, 64);
            caseOrganContainer.Name = "caseOrganContainer";
            caseOrganContainer.Size = new Size(800, 222);
            caseOrganContainer.TabIndex = 1;
            // 
            // CaseOrganFramework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(caseOrganContainer);
            Controls.Add(header);
            Name = "CaseOrganFramework";
            Size = new Size(800, 286);
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deleteCaseBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        public Panel caseOrganContainer;
        private Label caseNoLabel;
        private MaterialSkin.Controls.MaterialDivider divider;
        public Label pageNameLabel;
        private PictureBox deleteCaseBtn;
    }
}
