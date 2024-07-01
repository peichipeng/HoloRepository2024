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
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 50.25F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(196, 127);
            Title.Margin = new Padding(5, 0, 5, 0);
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
            AddCaseButton.Location = new Point(495, 275);
            AddCaseButton.Margin = new Padding(5, 4, 5, 4);
            AddCaseButton.Name = "AddCaseButton";
            AddCaseButton.Size = new Size(292, 55);
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
            ViewCasesButton.Location = new Point(495, 364);
            ViewCasesButton.Margin = new Padding(5, 4, 5, 4);
            ViewCasesButton.Name = "ViewCasesButton";
            ViewCasesButton.Size = new Size(292, 55);
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
            UserGuideButton.Location = new Point(495, 453);
            UserGuideButton.Margin = new Padding(5, 4, 5, 4);
            UserGuideButton.Name = "UserGuideButton";
            UserGuideButton.Size = new Size(292, 55);
            UserGuideButton.TabIndex = 3;
            UserGuideButton.Text = "User Guide";
            UserGuideButton.UseVisualStyleBackColor = false;
            UserGuideButton.Click += UserGuideButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(AddCaseButton);
            mainPanel.Controls.Add(Title);
            mainPanel.Controls.Add(UserGuideButton);
            mainPanel.Controls.Add(ViewCasesButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(5, 4, 5, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1257, 635);
            mainPanel.TabIndex = 4;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 635);
            Controls.Add(mainPanel);
            Margin = new Padding(5, 4, 5, 4);
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
    }
}