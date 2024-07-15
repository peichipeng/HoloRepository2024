namespace HoloRepository
{
    partial class HomePage1
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
            AddBtn = new Button();
            AddCaseButton = new Button();
            Title = new Label();
            UserGuideButton = new Button();
            ViewCasesButton = new Button();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(118, 173);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(90, 38);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "temp";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // AddCaseButton
            // 
            AddCaseButton.Anchor = AnchorStyles.None;
            AddCaseButton.BackColor = Color.CornflowerBlue;
            AddCaseButton.FlatStyle = FlatStyle.Flat;
            AddCaseButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddCaseButton.ForeColor = SystemColors.ButtonFace;
            AddCaseButton.Location = new Point(304, 177);
            AddCaseButton.Margin = new Padding(5, 4, 5, 4);
            AddCaseButton.Name = "AddCaseButton";
            AddCaseButton.Size = new Size(186, 34);
            AddCaseButton.TabIndex = 7;
            AddCaseButton.Text = "Add a Case";
            AddCaseButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(132, 15);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(551, 81);
            Title.TabIndex = 6;
            Title.Text = "HoloRepository";
            // 
            // UserGuideButton
            // 
            UserGuideButton.Anchor = AnchorStyles.None;
            UserGuideButton.BackColor = Color.CornflowerBlue;
            UserGuideButton.FlatStyle = FlatStyle.Flat;
            UserGuideButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserGuideButton.ForeColor = Color.Transparent;
            UserGuideButton.Location = new Point(304, 318);
            UserGuideButton.Margin = new Padding(5, 4, 5, 4);
            UserGuideButton.Name = "UserGuideButton";
            UserGuideButton.Size = new Size(186, 34);
            UserGuideButton.TabIndex = 9;
            UserGuideButton.Text = "User Guide";
            UserGuideButton.UseVisualStyleBackColor = false;
            // 
            // ViewCasesButton
            // 
            ViewCasesButton.Anchor = AnchorStyles.None;
            ViewCasesButton.BackColor = Color.CornflowerBlue;
            ViewCasesButton.FlatStyle = FlatStyle.Flat;
            ViewCasesButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ViewCasesButton.ForeColor = SystemColors.ButtonFace;
            ViewCasesButton.Location = new Point(304, 249);
            ViewCasesButton.Margin = new Padding(5, 4, 5, 4);
            ViewCasesButton.Name = "ViewCasesButton";
            ViewCasesButton.Size = new Size(186, 34);
            ViewCasesButton.TabIndex = 8;
            ViewCasesButton.Text = "View Cases";
            ViewCasesButton.UseVisualStyleBackColor = false;
            // 
            // HomePage1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddBtn);
            Controls.Add(AddCaseButton);
            Controls.Add(Title);
            Controls.Add(UserGuideButton);
            Controls.Add(ViewCasesButton);
            Name = "HomePage1";
            Size = new Size(800, 367);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private Button AddCaseButton;
        private Label Title;
        private Button UserGuideButton;
        private Button ViewCasesButton;
    }
}
