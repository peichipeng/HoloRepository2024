namespace HoloRepository.AddCase
{
    partial class AddCaseFramework
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
            nextBtn = new RoundedButton();
            cancelBtn = new RoundedButton();
            addCaseContainer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(nextBtn);
            panel1.Controls.Add(cancelBtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 311);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 0;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.BackColor = Color.FromArgb(51, 129, 202);
            nextBtn.BorderRadius = 15;
            nextBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(646, 9);
            nextBtn.Margin = new Padding(2, 2, 14, 2);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(81, 31);
            nextBtn.TabIndex = 7;
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
            cancelBtn.Location = new Point(73, 9);
            cancelBtn.Margin = new Padding(14, 2, 2, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(81, 31);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // addCaseContainer
            // 
            addCaseContainer.Dock = DockStyle.Fill;
            addCaseContainer.Location = new Point(0, 0);
            addCaseContainer.Name = "addCaseContainer";
            addCaseContainer.Size = new Size(800, 311);
            addCaseContainer.TabIndex = 1;
            // 
            // AddCaseFramework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addCaseContainer);
            Controls.Add(panel1);
            Name = "AddCaseFramework";
            Size = new Size(800, 373);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel addCaseContainer;
        public RoundedButton nextBtn;
        private RoundedButton cancelBtn;
    }
}
