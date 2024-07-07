namespace HoloRepository.CasePageControls
{
    partial class AddDonorInfo
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
            ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // causeOfDeath
            // 
            causeOfDeath.Anchor = AnchorStyles.None;
            causeOfDeath.Location = new Point(253, 343);
            causeOfDeath.Name = "causeOfDeath";
            causeOfDeath.Size = new Size(351, 37);
            causeOfDeath.StateCommon.Border.Color1 = Color.LightGray;
            causeOfDeath.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            causeOfDeath.StateCommon.Border.Rounding = 5;
            causeOfDeath.StateCommon.Border.Width = 2;
            causeOfDeath.StateCommon.Content.Color1 = Color.Gray;
            causeOfDeath.TabIndex = 24;
            // 
            // age
            // 
            age.Anchor = AnchorStyles.None;
            age.Location = new Point(253, 299);
            age.Name = "age";
            age.Size = new Size(351, 37);
            age.StateCommon.Border.Color1 = Color.LightGray;
            age.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            age.StateCommon.Border.Rounding = 5;
            age.StateCommon.Border.Width = 2;
            age.StateCommon.Content.Color1 = Color.Gray;
            age.TabIndex = 23;
            // 
            // DOD
            // 
            DOD.Anchor = AnchorStyles.None;
            DOD.Location = new Point(253, 255);
            DOD.Name = "DOD";
            DOD.Size = new Size(351, 37);
            DOD.StateCommon.Border.Color1 = Color.LightGray;
            DOD.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            DOD.StateCommon.Border.Rounding = 5;
            DOD.StateCommon.Border.Width = 2;
            DOD.StateCommon.Content.Color1 = Color.Gray;
            DOD.TabIndex = 22;
            // 
            // ID
            // 
            ID.Anchor = AnchorStyles.None;
            ID.Location = new Point(253, 211);
            ID.Name = "ID";
            ID.Size = new Size(351, 37);
            ID.StateCommon.Border.Color1 = Color.LightGray;
            ID.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            ID.StateCommon.Border.Rounding = 5;
            ID.StateCommon.Border.Width = 2;
            ID.StateCommon.Content.Color1 = Color.Gray;
            ID.TabIndex = 21;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(96, 345);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 20;
            label4.Text = "Cause of death";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(96, 302);
            label5.Name = "label5";
            label5.Size = new Size(47, 28);
            label5.TabIndex = 19;
            label5.Text = "Age";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(96, 259);
            label3.Name = "label3";
            label3.Size = new Size(131, 28);
            label3.TabIndex = 18;
            label3.Text = "Date of death";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(96, 216);
            label2.Name = "label2";
            label2.Size = new Size(92, 28);
            label2.TabIndex = 17;
            label2.Text = "Donor ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 58);
            label1.Margin = new Padding(20, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(458, 116);
            label1.TabIndex = 16;
            label1.Text = "Add Donor's Basic\r\nInformation\r\n";
            // 
            // AddDonorInfo
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
            Name = "AddDonorInfo";
            Size = new Size(1143, 443);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox causeOfDeath;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox age;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DOD;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ID;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
