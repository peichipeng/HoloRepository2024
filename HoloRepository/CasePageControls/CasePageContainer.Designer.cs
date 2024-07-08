namespace HoloRepository.CasePageControls
{
    partial class CasePageContainer
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
            panel1 = new Panel();
            label9 = new Label();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            label1 = new Label();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(materialDivider1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 107);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(856, 61);
            label9.Name = "label9";
            label9.Size = new Size(187, 32);
            label9.TabIndex = 51;
            label9.Text = "Case 123456789";
            // 
            // materialDivider1
            // 
            materialDivider1.Anchor = AnchorStyles.Top;
            materialDivider1.BackColor = Color.DarkGray;
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(99, 96);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(945, 2);
            materialDivider1.TabIndex = 50;
            materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 20);
            label1.Margin = new Padding(20, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 58);
            label1.TabIndex = 49;
            label1.Text = "Add a Case";
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 107);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1143, 369);
            contentPanel.TabIndex = 1;
            // 
            // CasePageContainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            Name = "CasePageContainer";
            Size = new Size(1143, 476);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel contentPanel;
        private Label label9;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private Label label1;
    }
}
