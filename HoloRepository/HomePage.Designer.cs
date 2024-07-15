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
            header = new Panel();
            mainContainer = new Panel();
            userGuideBtn = new RoundedButton();
            organArchiveBtn = new RoundedButton();
            viewCasesBtn = new RoundedButton();
            addCaseBtn = new RoundedButton();
            tempBtn = new Button();
            Title = new Label();
            mainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(846, 30);
            header.TabIndex = 0;
            // 
            // mainContainer
            // 
            mainContainer.Controls.Add(userGuideBtn);
            mainContainer.Controls.Add(organArchiveBtn);
            mainContainer.Controls.Add(viewCasesBtn);
            mainContainer.Controls.Add(addCaseBtn);
            mainContainer.Controls.Add(tempBtn);
            mainContainer.Controls.Add(Title);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 30);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(846, 415);
            mainContainer.TabIndex = 1;
            // 
            // userGuideBtn
            // 
            userGuideBtn.Anchor = AnchorStyles.None;
            userGuideBtn.BackColor = Color.FromArgb(238, 238, 238);
            userGuideBtn.BorderRadius = 15;
            userGuideBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userGuideBtn.ForeColor = Color.Black;
            userGuideBtn.Location = new Point(323, 327);
            userGuideBtn.Margin = new Padding(2, 2, 14, 2);
            userGuideBtn.Name = "userGuideBtn";
            userGuideBtn.Size = new Size(201, 36);
            userGuideBtn.TabIndex = 76;
            userGuideBtn.Text = "User Guide";
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
            organArchiveBtn.Location = new Point(323, 279);
            organArchiveBtn.Margin = new Padding(2, 2, 14, 2);
            organArchiveBtn.Name = "organArchiveBtn";
            organArchiveBtn.Size = new Size(201, 36);
            organArchiveBtn.TabIndex = 75;
            organArchiveBtn.Text = "Organ Archive";
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
            viewCasesBtn.Location = new Point(323, 231);
            viewCasesBtn.Margin = new Padding(2, 2, 14, 2);
            viewCasesBtn.Name = "viewCasesBtn";
            viewCasesBtn.Size = new Size(201, 36);
            viewCasesBtn.TabIndex = 74;
            viewCasesBtn.Text = "View Cases";
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
            addCaseBtn.Location = new Point(323, 183);
            addCaseBtn.Margin = new Padding(2, 2, 14, 2);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(201, 36);
            addCaseBtn.TabIndex = 73;
            addCaseBtn.Text = " Add a Case";
            addCaseBtn.UseVisualStyleBackColor = false;
            addCaseBtn.Click += addCaseBtn_Click;
            // 
            // tempBtn
            // 
            tempBtn.Anchor = AnchorStyles.None;
            tempBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tempBtn.Location = new Point(141, 202);
            tempBtn.Name = "tempBtn";
            tempBtn.Size = new Size(90, 38);
            tempBtn.TabIndex = 15;
            tempBtn.Text = "temp";
            tempBtn.UseVisualStyleBackColor = true;
            tempBtn.Click += this.tempBtn_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 42F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(192, 64);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(463, 68);
            Title.TabIndex = 11;
            Title.Text = "HoloRepository";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 445);
            Controls.Add(mainContainer);
            Controls.Add(header);
            Margin = new Padding(4, 2, 4, 2);
            Name = "HomePage";
            Text = "HoloRepository";
            mainContainer.ResumeLayout(false);
            mainContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel mainContainer;
        private Button tempBtn;
        private Label Title;
        private RoundedButton addCaseBtn;
        private RoundedButton userGuideBtn;
        private RoundedButton organArchiveBtn;
        private RoundedButton viewCasesBtn;
    }
}