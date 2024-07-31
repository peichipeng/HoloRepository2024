namespace HoloRepository.AddCase
{
    partial class CasePage
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
            headerContainer = new Panel();
            caseOrganContainer = new Panel();
            SuspendLayout();
            // 
            // headerContainer
            // 
            headerContainer.Dock = DockStyle.Top;
            headerContainer.Location = new Point(0, 0);
            headerContainer.Name = "headerContainer";
            headerContainer.Size = new Size(800, 64);
            headerContainer.TabIndex = 0;
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
            Controls.Add(headerContainer);
            Name = "CaseOrganFramework";
            Size = new Size(800, 286);
            ResumeLayout(false);
        }

        #endregion

        public Panel headerContainer;
        public Panel caseOrganContainer;
    }
}
