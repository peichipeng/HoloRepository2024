namespace HoloRepository
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            AddCaseButton = new Button();
            ViewCasesButton = new Button();
            UserGuideButton = new Button();
            mainPanel = new Panel();
            AddBtn = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(249, 115);
            Title.Margin = new Padding(8, 0, 8, 0);
            Title.Name = "Title";
            Title.Size = new Size(830, 122);
            Title.TabIndex = 0;
            Title.Text = "HoloRepository";
            // 
            // AddCaseButton
            // 
            AddCaseButton.Anchor = AnchorStyles.None;
            AddCaseButton.BackColor = Color.CornflowerBlue;
            AddCaseButton.FlatStyle = FlatStyle.Flat;
            AddCaseButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddCaseButton.ForeColor = SystemColors.ButtonFace;
            AddCaseButton.Location = new Point(518, 375);
            AddCaseButton.Margin = new Padding(8, 6, 8, 6);
            AddCaseButton.Name = "AddCaseButton";
            AddCaseButton.Size = new Size(292, 54);
            AddCaseButton.TabIndex = 1;
            AddCaseButton.Text = "Add a Case";
            AddCaseButton.UseVisualStyleBackColor = false;
            AddCaseButton.Click += AddCaseButton_Click;
            // 
            // ViewCasesButton
            // 
            ViewCasesButton.Anchor = AnchorStyles.None;
            ViewCasesButton.BackColor = Color.CornflowerBlue;
            ViewCasesButton.FlatStyle = FlatStyle.Flat;
            ViewCasesButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ViewCasesButton.ForeColor = SystemColors.ButtonFace;
            ViewCasesButton.Location = new Point(518, 490);
            ViewCasesButton.Margin = new Padding(8, 6, 8, 6);
            ViewCasesButton.Name = "ViewCasesButton";
            ViewCasesButton.Size = new Size(292, 54);
            ViewCasesButton.TabIndex = 2;
            ViewCasesButton.Text = "View Cases";
            ViewCasesButton.UseVisualStyleBackColor = false;
            ViewCasesButton.Click += ViewCasesButton_Click;
            // 
            // UserGuideButton
            // 
            UserGuideButton.Anchor = AnchorStyles.None;
            UserGuideButton.BackColor = Color.CornflowerBlue;
            UserGuideButton.FlatStyle = FlatStyle.Flat;
            UserGuideButton.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserGuideButton.ForeColor = Color.Transparent;
            UserGuideButton.Location = new Point(518, 600);
            UserGuideButton.Margin = new Padding(8, 6, 8, 6);
            UserGuideButton.Name = "UserGuideButton";
            UserGuideButton.Size = new Size(292, 54);
            UserGuideButton.TabIndex = 3;
            UserGuideButton.Text = "User Guide";
            UserGuideButton.UseVisualStyleBackColor = false;
            UserGuideButton.Click += UserGuideButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(AddBtn);
            mainPanel.Controls.Add(AddCaseButton);
            mainPanel.Controls.Add(Title);
            mainPanel.Controls.Add(UserGuideButton);
            mainPanel.Controls.Add(ViewCasesButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(6, 3, 6, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1329, 712);
            mainPanel.TabIndex = 4;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.None;
            AddBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.Location = new Point(226, 368);
            AddBtn.Margin = new Padding(5);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(141, 61);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "temp";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 712);
            Controls.Add(mainPanel);
            Margin = new Padding(6, 3, 6, 3);
            Name = "HomePage";
            Text = "HoloRepository";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Button AddCaseButton;
        private Button ViewCasesButton;
        private Button UserGuideButton;
        private Panel mainPanel;
        private Button AddBtn;
    }
}