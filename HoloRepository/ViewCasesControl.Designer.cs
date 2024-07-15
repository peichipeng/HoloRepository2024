namespace HoloRepository
{
    partial class ViewCasesControl
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
            pageNameLabel = new Label();
            addCaseBtn = new RoundedButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(325, 17);
            pageNameLabel.Margin = new Padding(14, 0, 2, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(196, 39);
            pageNameLabel.TabIndex = 54;
            pageNameLabel.Text = "View Cases";
            // 
            // addCaseBtn
            // 
            addCaseBtn.Anchor = AnchorStyles.Top;
            addCaseBtn.BackColor = Color.FromArgb(51, 129, 202);
            addCaseBtn.BorderRadius = 15;
            addCaseBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addCaseBtn.ForeColor = Color.White;
            addCaseBtn.Location = new Point(598, 63);
            addCaseBtn.Margin = new Padding(2, 2, 14, 2);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(143, 25);
            addCaseBtn.TabIndex = 74;
            addCaseBtn.Text = "+ Add a Case";
            addCaseBtn.UseVisualStyleBackColor = false;
            addCaseBtn.Click += addCaseBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(257, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 75;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewCasesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(addCaseBtn);
            Controls.Add(pageNameLabel);
            Name = "ViewCasesControl";
            Size = new Size(846, 415);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageNameLabel;
        private RoundedButton addCaseBtn;
        private Button button1;
    }
}
