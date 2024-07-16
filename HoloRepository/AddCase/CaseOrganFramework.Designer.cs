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
            header = new Panel();
            caseNoLabel = new Label();
            divider = new MaterialSkin.Controls.MaterialDivider();
            pageNameLabel = new Label();
            caseOrganContainer = new Panel();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(caseNoLabel);
            header.Controls.Add(divider);
            header.Controls.Add(pageNameLabel);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(5);
            header.Name = "header";
            header.Size = new Size(1257, 102);
            header.TabIndex = 0;
            // 
            // caseNoLabel
            // 
            caseNoLabel.Anchor = AnchorStyles.Top;
            caseNoLabel.AutoSize = true;
            caseNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            caseNoLabel.ForeColor = Color.Black;
            caseNoLabel.Location = new Point(948, 56);
            caseNoLabel.Name = "caseNoLabel";
            caseNoLabel.Size = new Size(187, 32);
            caseNoLabel.TabIndex = 54;
            caseNoLabel.Text = "Case 123456789";
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top;
            divider.BackColor = Color.DarkGray;
            divider.Depth = 0;
            divider.Location = new Point(108, 97);
            divider.MouseState = MaterialSkin.MouseState.HOVER;
            divider.Name = "divider";
            divider.Size = new Size(1040, 2);
            divider.TabIndex = 53;
            divider.Text = "materialDivider1";
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(108, 19);
            pageNameLabel.Margin = new Padding(22, 0, 3, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(290, 58);
            pageNameLabel.TabIndex = 52;
            pageNameLabel.Text = "Add a Case";
            // 
            // caseOrganContainer
            // 
            caseOrganContainer.Dock = DockStyle.Fill;
            caseOrganContainer.Location = new Point(0, 102);
            caseOrganContainer.Margin = new Padding(5);
            caseOrganContainer.Name = "caseOrganContainer";
            caseOrganContainer.Size = new Size(1257, 356);
            caseOrganContainer.TabIndex = 1;
            // 
            // CaseOrganFramework
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(caseOrganContainer);
            Controls.Add(header);
            Margin = new Padding(5);
            Name = "CaseOrganFramework";
            Size = new Size(1257, 458);
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        public Panel caseOrganContainer;
        private Label caseNoLabel;
        private MaterialSkin.Controls.MaterialDivider divider;
        public Label pageNameLabel;
    }
}
