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
            blackHomeBtn = new PictureBox();
            previousPageBtn = new PictureBox();
            breadcrumbPanel = new FlowLayoutPanel();
            homeBtn = new PictureBox();
            arrow = new PictureBox();
            page1 = new Button();
            modeSwitch = new Button();
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
            header.Controls.Add(blackHomeBtn);
            header.Controls.Add(previousPageBtn);
            header.Controls.Add(breadcrumbPanel);
            header.Controls.Add(modeSwitch);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Margin = new Padding(5);
            header.Name = "header";
            header.Size = new Size(1329, 48);
            header.TabIndex = 0;
            // 
            // blackHomeBtn
            // 
            blackHomeBtn.Anchor = AnchorStyles.Top;
            blackHomeBtn.Image = (Image)resources.GetObject("blackHomeBtn.Image");
            blackHomeBtn.Location = new Point(1240, 6);
            blackHomeBtn.Margin = new Padding(5);
            blackHomeBtn.Name = "blackHomeBtn";
            blackHomeBtn.Size = new Size(39, 40);
            blackHomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            blackHomeBtn.TabIndex = 18;
            blackHomeBtn.TabStop = false;
            blackHomeBtn.Click += blackHomeBtn_Click;
            // 
            // previousPageBtn
            // 
            previousPageBtn.Anchor = AnchorStyles.Top;
            previousPageBtn.Image = (Image)resources.GetObject("previousPageBtn.Image");
            previousPageBtn.Location = new Point(655, 0);
            previousPageBtn.Margin = new Padding(5);
            previousPageBtn.Name = "previousPageBtn";
            previousPageBtn.Size = new Size(39, 40);
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
            breadcrumbPanel.Location = new Point(49, 0);
            breadcrumbPanel.Margin = new Padding(5);
            breadcrumbPanel.Name = "breadcrumbPanel";
            breadcrumbPanel.Size = new Size(597, 63);
            breadcrumbPanel.TabIndex = 17;
            breadcrumbPanel.Visible = false;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.None;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.Location = new Point(5, 19);
            homeBtn.Margin = new Padding(5, 6, 8, 5);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(25, 26);
            homeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            homeBtn.TabIndex = 0;
            homeBtn.TabStop = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // arrow
            // 
            arrow.Image = (Image)resources.GetObject("arrow.Image");
            arrow.Location = new Point(38, 10);
            arrow.Margin = new Padding(0, 10, 0, 5);
            arrow.Name = "arrow";
            arrow.Size = new Size(25, 26);
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
            page1.Location = new Point(63, 2);
            page1.Margin = new Padding(0, 2, 0, 0);
            page1.Name = "page1";
            page1.Size = new Size(121, 61);
            page1.TabIndex = 0;
            page1.Text = "page1";
            page1.UseVisualStyleBackColor = false;
            // 
            // modeSwitch
            // 
            modeSwitch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            modeSwitch.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            modeSwitch.Location = new Point(933, 0);
            modeSwitch.Margin = new Padding(5);
            modeSwitch.Name = "modeSwitch";
            modeSwitch.Size = new Size(176, 43);
            modeSwitch.TabIndex = 16;
            modeSwitch.Text = "Microphone";
            modeSwitch.UseVisualStyleBackColor = true;
            modeSwitch.Click += modeSwitch_Click;
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 48);
            mainContainer.Margin = new Padding(2, 13, 5, 5);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1329, 696);
            mainContainer.TabIndex = 1;
            mainContainer.ControlAdded += mainContainer_ControlAdded;
            mainContainer.ControlRemoved += mainContainer_ControlRemoved;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1329, 744);
            Controls.Add(mainContainer);
            Controls.Add(header);
            Margin = new Padding(6, 3, 6, 3);
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
        public Button modeSwitch;
        private FlowLayoutPanel breadcrumbPanel;
        private PictureBox homeBtn;
        private PictureBox arrow;
        private Button page1;
        private PictureBox previousPageBtn;
        private PictureBox blackHomeBtn;
    }
}