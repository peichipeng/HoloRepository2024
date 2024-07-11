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
            panel1 = new Panel();
            caseNoLabel = new Label();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            pageNameLabel = new Label();
            caseOrganContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(caseNoLabel);
            panel1.Controls.Add(materialDivider1);
            panel1.Controls.Add(pageNameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 0;
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
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Top;
            materialDivider1.BackColor = Color.DarkGray;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(69, 58);
            materialDivider1.Margin = new Padding(2);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(662, 1);
            materialDivider1.TabIndex = 53;
            materialDivider1.Text = "materialDivider1";
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(69, 12);
            pageNameLabel.Margin = new Padding(14, 0, 2, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(191, 39);
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
            Controls.Add(panel1);
            Name = "CaseOrganFramework";
            Size = new Size(800, 286);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel caseOrganContainer;
        private Label caseNoLabel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label pageNameLabel;
    }
}
