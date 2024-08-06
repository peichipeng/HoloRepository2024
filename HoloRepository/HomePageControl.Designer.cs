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
            btnUpdateOrgan = new Button();
            button1 = new Button();
            voiceControl1 = new VoiceControl();
            btnLaunchEOSUtility = new Button();
            SuspendLayout();
            // 
            // userGuideBtn
            // 
            userGuideBtn.Anchor = AnchorStyles.None;
            userGuideBtn.BackColor = Color.FromArgb(238, 238, 238);
            userGuideBtn.BorderRadius = 15;
            userGuideBtn.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            userGuideBtn.ForeColor = Color.Black;
            userGuideBtn.Location = new Point(323, 323);
            userGuideBtn.Margin = new Padding(2, 2, 14, 2);
            userGuideBtn.Name = "userGuideBtn";
            userGuideBtn.Size = new Size(201, 36);
            userGuideBtn.TabIndex = 82;
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
            organArchiveBtn.Location = new Point(323, 273);
            organArchiveBtn.Margin = new Padding(2, 2, 14, 2);
            organArchiveBtn.Name = "organArchiveBtn";
            organArchiveBtn.Size = new Size(201, 36);
            organArchiveBtn.TabIndex = 81;
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
            viewCasesBtn.Location = new Point(323, 225);
            viewCasesBtn.Margin = new Padding(2, 2, 14, 2);
            viewCasesBtn.Name = "viewCasesBtn";
            viewCasesBtn.Size = new Size(201, 36);
            viewCasesBtn.TabIndex = 80;
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
            addCaseBtn.Location = new Point(323, 177);
            addCaseBtn.Margin = new Padding(2, 2, 14, 2);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(201, 36);
            addCaseBtn.TabIndex = 79;
            addCaseBtn.Text = " Add a Case";
            addCaseBtn.UseVisualStyleBackColor = false;
            addCaseBtn.Click += addCaseBtn_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Tahoma", 42F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(192, 58);
            Title.Margin = new Padding(5, 0, 5, 0);
            Title.Name = "Title";
            Title.Size = new Size(691, 101);
            Title.TabIndex = 77;
            Title.Text = "HoloRepository";
            // 
            // btnUpdateOrgan
            // 
            btnUpdateOrgan.Anchor = AnchorStyles.Top;
            btnUpdateOrgan.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateOrgan.Location = new Point(178, 398);
            btnUpdateOrgan.Name = "btnUpdateOrgan";
            btnUpdateOrgan.Size = new Size(139, 64);
            btnUpdateOrgan.TabIndex = 83;
            btnUpdateOrgan.Text = "Update";
            btnUpdateOrgan.UseVisualStyleBackColor = true;
            btnUpdateOrgan.Click += btnUpdateOrgan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(184, 508);
            button1.Name = "button1";
            button1.Size = new Size(122, 49);
            button1.TabIndex = 84;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // voiceControl1
            // 
            voiceControl1.BackColor = Color.Transparent;
            voiceControl1.Location = new Point(56, 197);
            voiceControl1.Name = "voiceControl1";
            voiceControl1.Size = new Size(332, 115);
            voiceControl1.TabIndex = 85;
            // 
            // btnLaunchEOSUtility
            // 
            btnLaunchEOSUtility.Location = new Point(1008, 352);
            btnLaunchEOSUtility.Name = "btnLaunchEOSUtility";
            btnLaunchEOSUtility.Size = new Size(112, 34);
            btnLaunchEOSUtility.TabIndex = 86;
            btnLaunchEOSUtility.Text = "button2";
            btnLaunchEOSUtility.UseVisualStyleBackColor = true;
            btnLaunchEOSUtility.Click += button2_Click;
            // 
            // HomePageControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLaunchEOSUtility);
            Controls.Add(voiceControl1);
            Controls.Add(button1);
            Controls.Add(btnUpdateOrgan);
            Controls.Add(userGuideBtn);
            Controls.Add(organArchiveBtn);
            Controls.Add(viewCasesBtn);
            Controls.Add(addCaseBtn);
            Controls.Add(Title);
            Margin = new Padding(5);
            Name = "HomePageControl";
            Size = new Size(1329, 664);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton userGuideBtn;
        private RoundedButton organArchiveBtn;
        private RoundedButton viewCasesBtn;
        private RoundedButton addCaseBtn;
        private Label Title;
        private Button btnUpdateOrgan;
        private Button button1;
        private VoiceControl voiceControl1;
        private Button btnLaunchEOSUtility;
    }
}
