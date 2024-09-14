namespace HoloRepository
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            header = new Panel();
            voiceControl1 = new VoiceControl();
            blackHomeBtn = new PictureBox();
            previousPageBtn = new PictureBox();
            breadcrumbPanel = new FlowLayoutPanel();
            homeBtn = new PictureBox();
            arrow = new PictureBox();
            page1 = new Button();
            mainContainer = new Panel();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blackHomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)previousPageBtn).BeginInit();
            breadcrumbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrow).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(voiceControl1);
            header.Controls.Add(blackHomeBtn);
            header.Controls.Add(previousPageBtn);
            header.Controls.Add(breadcrumbPanel);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(846, 47);
            header.TabIndex = 0;
            // 
            // voiceControl1
            // 
            voiceControl1.Anchor = AnchorStyles.None;
            voiceControl1.BackColor = Color.Transparent;
            voiceControl1.Location = new Point(692, 3);
            voiceControl1.Margin = new Padding(1);
            voiceControl1.Name = "voiceControl1";
            voiceControl1.Size = new Size(93, 43);
            voiceControl1.TabIndex = 87;
            // 
            // blackHomeBtn
            // 
            blackHomeBtn.Anchor = AnchorStyles.Top;
            blackHomeBtn.Image = (Image)resources.GetObject("blackHomeBtn.Image");
            blackHomeBtn.Location = new Point(789, 4);
            blackHomeBtn.Name = "blackHomeBtn";
            blackHomeBtn.Size = new Size(25, 25);
            blackHomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            blackHomeBtn.TabIndex = 18;
            blackHomeBtn.TabStop = false;
            blackHomeBtn.Click += blackHomeBtn_Click;
            // 
            // previousPageBtn
            // 
            previousPageBtn.Anchor = AnchorStyles.Top;
            previousPageBtn.Image = (Image)resources.GetObject("previousPageBtn.Image");
            previousPageBtn.Location = new Point(417, 0);
            previousPageBtn.Name = "previousPageBtn";
            previousPageBtn.Size = new Size(25, 25);
            previousPageBtn.SizeMode = PictureBoxSizeMode.Zoom;
            previousPageBtn.TabIndex = 0;
            previousPageBtn.TabStop = false;
            previousPageBtn.Click += previousPageBtn_Click;
            // 
            // breadcrumbPanel
            // 
            breadcrumbPanel.Anchor = AnchorStyles.Top;
            breadcrumbPanel.AutoSize = true;
            breadcrumbPanel.BackColor = Color.Transparent;
            breadcrumbPanel.Controls.Add(homeBtn);
            breadcrumbPanel.Controls.Add(arrow);
            breadcrumbPanel.Controls.Add(page1);
            breadcrumbPanel.Location = new Point(31, 0);
            breadcrumbPanel.Name = "breadcrumbPanel";
            breadcrumbPanel.Size = new Size(380, 39);
            breadcrumbPanel.TabIndex = 17;
            breadcrumbPanel.Visible = false;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.None;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.Location = new Point(3, 12);
            homeBtn.Margin = new Padding(3, 4, 5, 3);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(16, 16);
            homeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            homeBtn.TabIndex = 0;
            homeBtn.TabStop = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // arrow
            // 
            arrow.Image = (Image)resources.GetObject("arrow.Image");
            arrow.Location = new Point(24, 6);
            arrow.Margin = new Padding(0, 6, 0, 3);
            arrow.Name = "arrow";
            arrow.Size = new Size(16, 16);
            arrow.SizeMode = PictureBoxSizeMode.Zoom;
            arrow.TabIndex = 0;
            arrow.TabStop = false;
            // 
            // page1
            // 
            page1.AutoSize = true;
            page1.FlatAppearance.BorderSize = 0;
            page1.FlatStyle = FlatStyle.Flat;
            page1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            page1.Location = new Point(40, 1);
            page1.Margin = new Padding(0, 1, 0, 0);
            page1.Name = "page1";
            page1.Size = new Size(77, 38);
            page1.TabIndex = 0;
            page1.Text = "page1";
            page1.UseVisualStyleBackColor = false;
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 47);
            mainContainer.Margin = new Padding(1, 8, 3, 3);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(846, 418);
            mainContainer.TabIndex = 1;
            mainContainer.ControlAdded += mainContainer_ControlAdded;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 465);
            Controls.Add(mainContainer);
            Controls.Add(header);
            Margin = new Padding(4, 2, 4, 2);
            Name = "MainForm";
            Text = "HoloRepository";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blackHomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)previousPageBtn).EndInit();
            breadcrumbPanel.ResumeLayout(false);
            breadcrumbPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)homeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel mainContainer;
        private FlowLayoutPanel breadcrumbPanel;
        private PictureBox homeBtn;
        private PictureBox arrow;
        private Button page1;
        private PictureBox previousPageBtn;
        private PictureBox blackHomeBtn;
        private VoiceControl voiceControl1;
    }
}