namespace HoloRepository
{
    partial class BasicInfo
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
            footerContainer = new Panel();
            nextBtn = new RoundedButton();
            cancelBtn = new RoundedButton();
            panel1 = new Panel();
            contentContainer = new Panel();
            footerContainer.SuspendLayout();
            SuspendLayout();
            // 
            // footerContainer
            // 
            footerContainer.Controls.Add(nextBtn);
            footerContainer.Controls.Add(cancelBtn);
            footerContainer.Dock = DockStyle.Bottom;
            footerContainer.Location = new Point(0, 516);
            footerContainer.Name = "footerContainer";
            footerContainer.Size = new Size(1143, 145);
            footerContainer.TabIndex = 1;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.BackColor = Color.FromArgb(51, 129, 202);
            nextBtn.BorderRadius = 15;
            nextBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(922, 27);
            nextBtn.Margin = new Padding(3, 3, 20, 3);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(116, 51);
            nextBtn.TabIndex = 5;
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
            cancelBtn.Location = new Point(103, 27);
            cancelBtn.Margin = new Padding(20, 3, 3, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(116, 51);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 40);
            panel1.TabIndex = 2;
            // 
            // contentContainer
            // 
            contentContainer.Dock = DockStyle.Fill;
            contentContainer.Location = new Point(0, 40);
            contentContainer.Name = "contentContainer";
            contentContainer.Size = new Size(1143, 476);
            contentContainer.TabIndex = 16;
            contentContainer.Paint += panelContainer_Paint;
            // 
            // BasicInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentContainer);
            Controls.Add(panel1);
            Controls.Add(footerContainer);
            Name = "BasicInfo";
            Size = new Size(1143, 661);
            Load += BasicInfo_Load;
            footerContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel footerContainer;
        private Panel panel1;
        public Panel contentContainer;
        private RoundedButton nextBtn;
        private RoundedButton cancelBtn;
    }
}
