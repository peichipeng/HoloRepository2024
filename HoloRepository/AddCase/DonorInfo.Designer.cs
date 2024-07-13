namespace HoloRepository.AddCase
{
    partial class DonorInfo
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
            causeOfDeath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            age = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            DOD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            donorID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            title = new Label();
            label1 = new Label();
            dodErrorLabel = new Label();
            idErrorLabel = new Label();
            ageErrorLabel = new Label();
            causeErrorLabel = new Label();
            SuspendLayout();
            // 
            // causeOfDeath
            // 
            causeOfDeath.Anchor = AnchorStyles.None;
            causeOfDeath.Location = new Point(181, 219);
            causeOfDeath.Margin = new Padding(2);
            causeOfDeath.Name = "causeOfDeath";
            causeOfDeath.Size = new Size(246, 29);
            causeOfDeath.StateCommon.Border.Color1 = Color.LightGray;
            causeOfDeath.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            causeOfDeath.StateCommon.Border.Rounding = 5;
            causeOfDeath.StateCommon.Border.Width = 2;
            causeOfDeath.StateCommon.Content.Color1 = Color.Black;
            causeOfDeath.TabIndex = 33;
            // 
            // age
            // 
            age.Anchor = AnchorStyles.None;
            age.Location = new Point(181, 188);
            age.Margin = new Padding(2);
            age.Name = "age";
            age.Size = new Size(246, 29);
            age.StateCommon.Border.Color1 = Color.LightGray;
            age.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            age.StateCommon.Border.Rounding = 5;
            age.StateCommon.Border.Width = 2;
            age.StateCommon.Content.Color1 = Color.Black;
            age.TabIndex = 32;
            age.Leave += age_Leave;
            // 
            // DOD
            // 
            DOD.Anchor = AnchorStyles.None;
            DOD.Location = new Point(181, 157);
            DOD.Margin = new Padding(2);
            DOD.Name = "DOD";
            DOD.Size = new Size(246, 29);
            DOD.StateCommon.Border.Color1 = Color.LightGray;
            DOD.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            DOD.StateCommon.Border.Rounding = 5;
            DOD.StateCommon.Border.Width = 2;
            DOD.StateCommon.Content.Color1 = Color.Gray;
            DOD.TabIndex = 31;
            DOD.Text = "DD/MM/YYYY";
            DOD.TextChanged += DOD_TextChanged;
            DOD.Enter += DOD_Enter;
            DOD.KeyDown += DOD_KeyDown;
            DOD.Leave += DOD_Leave;
            // 
            // donorID
            // 
            donorID.Anchor = AnchorStyles.None;
            donorID.Location = new Point(181, 126);
            donorID.Margin = new Padding(2);
            donorID.Name = "donorID";
            donorID.Size = new Size(246, 29);
            donorID.StateCommon.Border.Color1 = Color.LightGray;
            donorID.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            donorID.StateCommon.Border.Rounding = 5;
            donorID.StateCommon.Border.Width = 2;
            donorID.StateCommon.Content.Color1 = Color.Black;
            donorID.TabIndex = 30;
            donorID.Leave += donorID_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(71, 225);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 19);
            label4.TabIndex = 29;
            label4.Text = "Cause of death";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(71, 194);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(33, 19);
            label5.TabIndex = 28;
            label5.Text = "Age";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(71, 163);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 27;
            label3.Text = "Date of death";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(71, 132);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 26;
            label2.Text = "Donor ID";
            // 
            // title
            // 
            title.Anchor = AnchorStyles.None;
            title.AutoSize = true;
            title.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(66, 22);
            title.Margin = new Padding(14, 0, 2, 0);
            title.Name = "title";
            title.Size = new Size(304, 39);
            title.TabIndex = 25;
            title.Text = "Add Donor's Basic";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 68);
            label1.Margin = new Padding(14, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 39);
            label1.TabIndex = 34;
            label1.Text = "Information";
            // 
            // dodErrorLabel
            // 
            dodErrorLabel.Anchor = AnchorStyles.None;
            dodErrorLabel.AutoSize = true;
            dodErrorLabel.ForeColor = Color.Red;
            dodErrorLabel.Location = new Point(432, 165);
            dodErrorLabel.Name = "dodErrorLabel";
            dodErrorLabel.Size = new Size(0, 15);
            dodErrorLabel.TabIndex = 35;
            // 
            // idErrorLabel
            // 
            idErrorLabel.Anchor = AnchorStyles.None;
            idErrorLabel.AutoSize = true;
            idErrorLabel.ForeColor = Color.Red;
            idErrorLabel.Location = new Point(432, 134);
            idErrorLabel.Name = "idErrorLabel";
            idErrorLabel.Size = new Size(0, 15);
            idErrorLabel.TabIndex = 36;
            // 
            // ageErrorLabel
            // 
            ageErrorLabel.Anchor = AnchorStyles.None;
            ageErrorLabel.AutoSize = true;
            ageErrorLabel.ForeColor = Color.Red;
            ageErrorLabel.Location = new Point(432, 196);
            ageErrorLabel.Name = "ageErrorLabel";
            ageErrorLabel.Size = new Size(0, 15);
            ageErrorLabel.TabIndex = 37;
            // 
            // causeErrorLabel
            // 
            causeErrorLabel.Anchor = AnchorStyles.None;
            causeErrorLabel.AutoSize = true;
            causeErrorLabel.ForeColor = Color.Red;
            causeErrorLabel.Location = new Point(432, 227);
            causeErrorLabel.Name = "causeErrorLabel";
            causeErrorLabel.Size = new Size(0, 15);
            causeErrorLabel.TabIndex = 38;
            // 
            // DonorInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(causeErrorLabel);
            Controls.Add(ageErrorLabel);
            Controls.Add(idErrorLabel);
            Controls.Add(dodErrorLabel);
            Controls.Add(label1);
            Controls.Add(causeOfDeath);
            Controls.Add(age);
            Controls.Add(DOD);
            Controls.Add(donorID);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(title);
            Name = "DonorInfo";
            Size = new Size(800, 266);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox causeOfDeath;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox age;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox DOD;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox donorID;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label title;
        private Label label1;
        private Label dodErrorLabel;
        private Label idErrorLabel;
        private Label ageErrorLabel;
        private Label causeErrorLabel;
    }
}
