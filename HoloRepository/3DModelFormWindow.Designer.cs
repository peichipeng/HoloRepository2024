namespace HoloRepository
{
    partial class _3DModelFormWindow
    {
        private System.ComponentModel.IContainer components = null;
        private Label ContructLabel;
        private ListView fileListView; // 新增控件
        private Panel detailPanel; // 新增控件
        private Label detailLabel; // 新增控件
        private PictureBox pictureBox1; // 新增控件
        private PictureBox pictureBox2; // 新增控件

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3DModelFormWindow));
            ContructLabel = new Label();
            btnClose = new PictureBox();
            ConstructButton = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // ContructLabel
            // 
            ContructLabel.AutoSize = true;
            ContructLabel.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ContructLabel.Location = new Point(23, 30);
            ContructLabel.Name = "ContructLabel";
            ContructLabel.Size = new Size(389, 64);
            ContructLabel.TabIndex = 0;
            ContructLabel.Text = "Construct 3D Model";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top;
            btnClose.BackColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1075, 30);
            btnClose.Margin = new Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 30);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 77;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // ConstructButton
            // 
            ConstructButton.BackColor = Color.FromArgb(51, 129, 202);
            ConstructButton.BorderRadius = 10;
            ConstructButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConstructButton.ForeColor = Color.White;
            ConstructButton.Location = new Point(964, 519);
            ConstructButton.Name = "ConstructButton";
            ConstructButton.Size = new Size(136, 49);
            ConstructButton.TabIndex = 78;
            ConstructButton.Text = "Construct";
            ConstructButton.UseVisualStyleBackColor = false;
            ConstructButton.Click += ConstructButton_Click;
            // 
            // _3DModelFormWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 602);
            ControlBox = false;
            Controls.Add(ConstructButton);
            Controls.Add(btnClose);
            Controls.Add(ContructLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_3DModelFormWindow";
            Text = "_3DModelFormWindow";
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckTable checkTable1;
        private PictureBox btnClose;
        private RoundedButton ConstructButton;
    }
}
