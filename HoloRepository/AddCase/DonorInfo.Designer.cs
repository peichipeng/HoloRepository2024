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
            causeOfDeathTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ageTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            dodTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            donorIdTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
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
            // causeOfDeathTxt
            // 
            causeOfDeathTxt.Anchor = AnchorStyles.None;
            causeOfDeathTxt.Location = new Point(181, 219);
            causeOfDeathTxt.Margin = new Padding(2);
            causeOfDeathTxt.Name = "causeOfDeathTxt";
            causeOfDeathTxt.Size = new Size(246, 29);
            causeOfDeathTxt.StateCommon.Border.Color1 = Color.LightGray;
            causeOfDeathTxt.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            causeOfDeathTxt.StateCommon.Border.Rounding = 5;
            causeOfDeathTxt.StateCommon.Border.Width = 2;
            causeOfDeathTxt.StateCommon.Content.Color1 = Color.Black;
            causeOfDeathTxt.TabIndex = 33;
            // 
            // ageTxt
            // 
            ageTxt.Anchor = AnchorStyles.None;
            ageTxt.Location = new Point(181, 188);
            ageTxt.Margin = new Padding(2);
            ageTxt.Name = "ageTxt";
            ageTxt.Size = new Size(246, 29);
            ageTxt.StateCommon.Border.Color1 = Color.LightGray;
            ageTxt.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            ageTxt.StateCommon.Border.Rounding = 5;
            ageTxt.StateCommon.Border.Width = 2;
            ageTxt.StateCommon.Content.Color1 = Color.Black;
            ageTxt.TabIndex = 32;
            ageTxt.Leave += age_Leave;
            // 
            // dodTxt
            // 
            dodTxt.Anchor = AnchorStyles.None;
            dodTxt.Location = new Point(181, 157);
            dodTxt.Margin = new Padding(2);
            dodTxt.Name = "dodTxt";
            dodTxt.Size = new Size(246, 29);
            dodTxt.StateCommon.Border.Color1 = Color.LightGray;
            dodTxt.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            dodTxt.StateCommon.Border.Rounding = 5;
            dodTxt.StateCommon.Border.Width = 2;
            dodTxt.StateCommon.Content.Color1 = Color.Gray;
            dodTxt.TabIndex = 31;
            dodTxt.Text = "DD/MM/YYYY";
            dodTxt.TextChanged += DOD_TextChanged;
            dodTxt.Enter += DOD_Enter;
            dodTxt.KeyDown += DOD_KeyDown;
            dodTxt.Leave += DOD_Leave;
            // 
            // donorIdTxt
            // 
            donorIdTxt.Anchor = AnchorStyles.None;
            donorIdTxt.Location = new Point(181, 126);
            donorIdTxt.Margin = new Padding(2);
            donorIdTxt.Name = "donorIdTxt";
            donorIdTxt.Size = new Size(246, 29);
            donorIdTxt.StateCommon.Border.Color1 = Color.LightGray;
            donorIdTxt.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            donorIdTxt.StateCommon.Border.Rounding = 5;
            donorIdTxt.StateCommon.Border.Width = 2;
            donorIdTxt.StateCommon.Content.Color1 = Color.Black;
            donorIdTxt.TabIndex = 30;
            donorIdTxt.Leave += donorID_Leave;
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
            Controls.Add(causeOfDeathTxt);
            Controls.Add(ageTxt);
            Controls.Add(dodTxt);
            Controls.Add(donorIdTxt);
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

        public ComponentFactory.Krypton.Toolkit.KryptonTextBox causeOfDeathTxt;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox ageTxt;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox dodTxt;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox donorIdTxt;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        public Label title;
        private Label label1;
        private Label dodErrorLabel;
        private Label idErrorLabel;
        private Label ageErrorLabel;
        private Label causeErrorLabel;
    }
}
