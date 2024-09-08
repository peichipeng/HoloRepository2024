namespace HoloRepository
{
    partial class HomePageControl
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
            userGuideBtn = new RoundedButton();
            organArchiveBtn = new RoundedButton();
            viewCasesBtn = new RoundedButton();
            addCaseBtn = new RoundedButton();
            Title = new Label();
            SuspendLayout();
            // 
            // userGuideBtn
            // 
            userGuideBtn.Anchor = AnchorStyles.None;
            userGuideBtn.BackColor = Color.FromArgb(238, 238, 238);
            userGuideBtn.BorderRadius = 15;
            userGuideBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userGuideBtn.ForeColor = Color.Black;
            userGuideBtn.Location = new Point(533, 552);
            userGuideBtn.Margin = new Padding(2, 2, 14, 2);
            userGuideBtn.Name = "userGuideBtn";
            userGuideBtn.Size = new Size(263, 55);
            userGuideBtn.TabIndex = 82;
            userGuideBtn.Text = "&User Guide";
            userGuideBtn.UseVisualStyleBackColor = false;
            userGuideBtn.Click += userGuideBtn_Click;
            // 
            // organArchiveBtn
            // 
            organArchiveBtn.Anchor = AnchorStyles.None;
            organArchiveBtn.BackColor = Color.FromArgb(51, 129, 202);
            organArchiveBtn.BorderRadius = 15;
            organArchiveBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            organArchiveBtn.ForeColor = Color.White;
            organArchiveBtn.Location = new Point(533, 473);
            organArchiveBtn.Margin = new Padding(2, 2, 14, 2);
            organArchiveBtn.Name = "organArchiveBtn";
            organArchiveBtn.Size = new Size(263, 55);
            organArchiveBtn.TabIndex = 81;
            organArchiveBtn.Text = "&Organ Archive";
            organArchiveBtn.UseVisualStyleBackColor = false;
            organArchiveBtn.Click += organArchiveBtn_Click;
            // 
            // viewCasesBtn
            // 
            viewCasesBtn.Anchor = AnchorStyles.None;
            viewCasesBtn.BackColor = Color.FromArgb(51, 129, 202);
            viewCasesBtn.BorderRadius = 15;
            viewCasesBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            viewCasesBtn.ForeColor = Color.White;
            viewCasesBtn.Location = new Point(533, 393);
            viewCasesBtn.Margin = new Padding(2, 2, 14, 2);
            viewCasesBtn.Name = "viewCasesBtn";
            viewCasesBtn.Size = new Size(263, 55);
            viewCasesBtn.TabIndex = 80;
            viewCasesBtn.Text = "&View Cases";
            viewCasesBtn.UseVisualStyleBackColor = false;
            viewCasesBtn.Click += viewCasesBtn_Click;
            // 
            // addCaseBtn
            // 
            addCaseBtn.Anchor = AnchorStyles.None;
            addCaseBtn.BackColor = Color.FromArgb(51, 129, 202);
            addCaseBtn.BorderRadius = 15;
            addCaseBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addCaseBtn.ForeColor = Color.White;
            addCaseBtn.Location = new Point(533, 314);
            addCaseBtn.Margin = new Padding(2, 2, 14, 2);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(263, 55);
            addCaseBtn.TabIndex = 79;
            addCaseBtn.Text = "&Add a Case";
            addCaseBtn.UseVisualStyleBackColor = false;
            addCaseBtn.Click += addCaseBtn_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 42F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(319, 156);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(691, 101);
            Title.TabIndex = 77;
            Title.Text = "HoloRepository";
            // 
            // HomePageControl
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(userGuideBtn);
            Controls.Add(organArchiveBtn);
            Controls.Add(viewCasesBtn);
            Controls.Add(addCaseBtn);
            Controls.Add(Title);
            Margin = new Padding(5);
            Name = "HomePageControl";
            Size = new Size(1329, 700);
            Load += HomePageControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton userGuideBtn;
        private RoundedButton organArchiveBtn;
        private RoundedButton viewCasesBtn;
        private RoundedButton addCaseBtn;
        private Button tempBtn;
        private Label Title;
    }
}