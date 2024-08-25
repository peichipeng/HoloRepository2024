namespace HoloRepository.AddCase
{
    partial class CaseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseView));
            updateBtn = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            addOrganBtn = new RoundedButton();
            label8 = new Label();
            causeOfDeathLabel = new Label();
            ageLabel = new Label();
            dodLabel = new Label();
            idLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)updateBtn).BeginInit();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.Anchor = AnchorStyles.Top;
            updateBtn.BackColor = Color.Transparent;
            updateBtn.Image = (Image)resources.GetObject("updateBtn.Image");
            updateBtn.Location = new Point(536, 3);
            updateBtn.Margin = new Padding(5);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(38, 46);
            updateBtn.SizeMode = PictureBoxSizeMode.Zoom;
            updateBtn.TabIndex = 75;
            updateBtn.TabStop = false;
            updateBtn.Click += updateBtn_Click;
            updateBtn.MouseEnter += updateBtn_MouseEnter;
            updateBtn.MouseLeave += updateBtn_MouseLeave;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(80, 299);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1097, 451);
            flowLayoutPanel1.TabIndex = 74;
            // 
            // materialDivider2
            // 
            materialDivider2.Anchor = AnchorStyles.Top;
            materialDivider2.BackColor = Color.LightGray;
            materialDivider2.Depth = 0;
            materialDivider2.Location = new Point(108, 280);
            materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(1040, 2);
            materialDivider2.TabIndex = 73;
            materialDivider2.Text = "materialDivider2";
            // 
            // addOrganBtn
            // 
            addOrganBtn.Anchor = AnchorStyles.Top;
            addOrganBtn.BackColor = Color.FromArgb(51, 129, 202);
            addOrganBtn.BorderRadius = 15;
            addOrganBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addOrganBtn.ForeColor = Color.White;
            addOrganBtn.Location = new Point(924, 234);
            addOrganBtn.Margin = new Padding(3, 3, 22, 3);
            addOrganBtn.Name = "addOrganBtn";
            addOrganBtn.Size = new Size(225, 40);
            addOrganBtn.TabIndex = 72;
            addOrganBtn.Text = "+ &Add an Organ";
            addOrganBtn.UseVisualStyleBackColor = false;
            addOrganBtn.Click += addOrganBtn_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(112, 234);
            label8.Name = "label8";
            label8.Size = new Size(102, 36);
            label8.TabIndex = 71;
            label8.Text = "Organs";
            // 
            // causeOfDeathLabel
            // 
            causeOfDeathLabel.Anchor = AnchorStyles.Top;
            causeOfDeathLabel.AutoSize = true;
            causeOfDeathLabel.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            causeOfDeathLabel.ForeColor = Color.Black;
            causeOfDeathLabel.Location = new Point(349, 184);
            causeOfDeathLabel.Name = "causeOfDeathLabel";
            causeOfDeathLabel.Size = new Size(0, 28);
            causeOfDeathLabel.TabIndex = 70;
            // 
            // ageLabel
            // 
            ageLabel.Anchor = AnchorStyles.Top;
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.ForeColor = Color.Black;
            ageLabel.Location = new Point(349, 142);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(0, 28);
            ageLabel.TabIndex = 69;
            // 
            // dodLabel
            // 
            dodLabel.Anchor = AnchorStyles.Top;
            dodLabel.AutoSize = true;
            dodLabel.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dodLabel.ForeColor = Color.Black;
            dodLabel.Location = new Point(349, 102);
            dodLabel.Name = "dodLabel";
            dodLabel.Size = new Size(0, 28);
            dodLabel.TabIndex = 68;
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top;
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI Semilight", 10F, FontStyle.Regular, GraphicsUnit.Point);
            idLabel.ForeColor = Color.Black;
            idLabel.Location = new Point(349, 61);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(0, 28);
            idLabel.TabIndex = 67;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(112, 184);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 66;
            label4.Text = "Cause of death";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(112, 142);
            label5.Name = "label5";
            label5.Size = new Size(47, 28);
            label5.TabIndex = 65;
            label5.Text = "Age";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(112, 102);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 64;
            label3.Text = "Date of death";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(112, 61);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 63;
            label2.Text = "Donor ID";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(112, 13);
            label6.Name = "label6";
            label6.Size = new Size(332, 36);
            label6.TabIndex = 62;
            label6.Text = "Donor's Basic Information";
            // 
            // CaseView
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(updateBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(materialDivider2);
            Controls.Add(addOrganBtn);
            Controls.Add(label8);
            Controls.Add(causeOfDeathLabel);
            Controls.Add(ageLabel);
            Controls.Add(dodLabel);
            Controls.Add(idLabel);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Margin = new Padding(5);
            Name = "CaseView";
            Size = new Size(1257, 754);
            ((System.ComponentModel.ISupportInitialize)updateBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox updateBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private RoundedButton addOrganBtn;
        private Label label8;
        private Label causeOfDeathLabel;
        private Label ageLabel;
        private Label dodLabel;
        private Label idLabel;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label6;
    }
}
