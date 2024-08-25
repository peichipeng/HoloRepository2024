﻿namespace HoloRepository
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
            btnUpdateOrgan = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // userGuideBtn
            // 
            userGuideBtn.Anchor = AnchorStyles.None;
            userGuideBtn.BackColor = Color.FromArgb(238, 238, 238);
            userGuideBtn.BorderRadius = 15;
            userGuideBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userGuideBtn.ForeColor = Color.Black;
            userGuideBtn.Location = new Point(323, 331);
            userGuideBtn.Margin = new Padding(2, 2, 14, 2);
            userGuideBtn.Name = "userGuideBtn";
            userGuideBtn.Size = new Size(201, 36);
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
            organArchiveBtn.Location = new Point(323, 283);
            organArchiveBtn.Margin = new Padding(2, 2, 14, 2);
            organArchiveBtn.Name = "organArchiveBtn";
            organArchiveBtn.Size = new Size(201, 36);
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
            viewCasesBtn.Location = new Point(323, 235);
            viewCasesBtn.Margin = new Padding(2, 2, 14, 2);
            viewCasesBtn.Name = "viewCasesBtn";
            viewCasesBtn.Size = new Size(201, 36);
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
            addCaseBtn.Location = new Point(323, 187);
            addCaseBtn.Margin = new Padding(2, 2, 14, 2);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(201, 36);
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
            Title.Location = new Point(192, 68);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(463, 68);
            Title.TabIndex = 77;
            Title.Text = "HoloRepository";
            // 
            // btnUpdateOrgan
            // 
            btnUpdateOrgan.Anchor = AnchorStyles.None;
            btnUpdateOrgan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateOrgan.Location = new Point(100, 279);
            btnUpdateOrgan.Margin = new Padding(2);
            btnUpdateOrgan.Name = "btnUpdateOrgan";
            btnUpdateOrgan.Size = new Size(80, 27);
            btnUpdateOrgan.TabIndex = 83;
            btnUpdateOrgan.Text = "Update";
            btnUpdateOrgan.UseVisualStyleBackColor = true;
            btnUpdateOrgan.Click += btnUpdateOrgan_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(88, 235);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(81, 23);
            button2.TabIndex = 85;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HomePageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button2);
            Controls.Add(btnUpdateOrgan);
            Controls.Add(userGuideBtn);
            Controls.Add(organArchiveBtn);
            Controls.Add(viewCasesBtn);
            Controls.Add(addCaseBtn);
            Controls.Add(Title);
            Name = "HomePageControl";
            Size = new Size(846, 435);
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
        private Button btnUpdateOrgan;
        private Button button2;
    }
}