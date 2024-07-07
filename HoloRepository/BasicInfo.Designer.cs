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
            panel2 = new Panel();
            saveBtn = new RoundedButton();
            nextBtn = new RoundedButton();
            cancelBtn = new RoundedButton();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            DOD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            age = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            causeOfDeath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(saveBtn);
            panel2.Controls.Add(nextBtn);
            panel2.Controls.Add(cancelBtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 486);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 175);
            panel2.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.BackColor = Color.FromArgb(51, 129, 202);
            saveBtn.BorderRadius = 15;
            saveBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(960, 62);
            saveBtn.Margin = new Padding(3, 3, 20, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(116, 51);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Visible = false;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.None;
            nextBtn.BackColor = Color.FromArgb(51, 129, 202);
            nextBtn.BorderRadius = 15;
            nextBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(960, 62);
            nextBtn.Margin = new Padding(3, 3, 20, 3);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(116, 51);
            nextBtn.TabIndex = 1;
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
            cancelBtn.Location = new Point(75, 62);
            cancelBtn.Margin = new Padding(20, 3, 3, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(116, 51);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += roundedButton1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 43);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 121);
            label1.Margin = new Padding(20, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(458, 116);
            label1.TabIndex = 3;
            label1.Text = "Add Donor's Basic\r\nInformation\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 279);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 4;
            label2.Text = "Donor ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(75, 322);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 6;
            label3.Text = "Date of death";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(75, 408);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 10;
            label4.Text = "Cause of death";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(75, 365);
            label5.Name = "label5";
            label5.Size = new Size(47, 28);
            label5.TabIndex = 8;
            label5.Text = "Age";
            // 
            // ID
            // 
            ID.Location = new Point(232, 274);
            ID.Name = "ID";
            ID.Size = new Size(351, 37);
            ID.StateCommon.Border.Color1 = Color.LightGray;
            ID.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            ID.StateCommon.Border.Rounding = 5;
            ID.StateCommon.Border.Width = 2;
            ID.StateCommon.Content.Color1 = Color.Gray;
            ID.TabIndex = 12;
            // 
            // DOD
            // 
            DOD.Location = new Point(232, 318);
            DOD.Name = "DOD";
            DOD.Size = new Size(351, 37);
            DOD.StateCommon.Border.Color1 = Color.LightGray;
            DOD.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            DOD.StateCommon.Border.Rounding = 5;
            DOD.StateCommon.Border.Width = 2;
            DOD.StateCommon.Content.Color1 = Color.Gray;
            DOD.TabIndex = 13;
            // 
            // age
            // 
            age.Location = new Point(232, 362);
            age.Name = "age";
            age.Size = new Size(351, 37);
            age.StateCommon.Border.Color1 = Color.LightGray;
            age.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            age.StateCommon.Border.Rounding = 5;
            age.StateCommon.Border.Width = 2;
            age.StateCommon.Content.Color1 = Color.Gray;
            age.TabIndex = 14;
            // 
            // causeOfDeath
            // 
            causeOfDeath.Location = new Point(232, 406);
            causeOfDeath.Name = "causeOfDeath";
            causeOfDeath.Size = new Size(351, 37);
            causeOfDeath.StateCommon.Border.Color1 = Color.LightGray;
            causeOfDeath.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            causeOfDeath.StateCommon.Border.Rounding = 5;
            causeOfDeath.StateCommon.Border.Width = 2;
            causeOfDeath.StateCommon.Content.Color1 = Color.Gray;
            causeOfDeath.TabIndex = 15;
            // 
            // BasicInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(causeOfDeath);
            Controls.Add(age);
            Controls.Add(DOD);
            Controls.Add(ID);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "BasicInfo";
            Size = new Size(1143, 661);
            Load += BasicInfo_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private RoundedButton cancelBtn;
        private RoundedButton nextBtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RoundedButton saveBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DOD;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox age;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox causeOfDeath;
    }
}
