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
            header = new Panel();
            modeSwitch = new Button();
            mainContainer = new Panel();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(modeSwitch);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(846, 30);
            header.TabIndex = 0;
            // 
            // modeSwitch
            // 
            modeSwitch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            modeSwitch.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            modeSwitch.Location = new Point(594, 0);
            modeSwitch.Name = "modeSwitch";
            modeSwitch.Size = new Size(112, 27);
            modeSwitch.TabIndex = 16;
            modeSwitch.Text = "Microphone";
            modeSwitch.UseVisualStyleBackColor = true;
            modeSwitch.Click += modeSwitch_Click;
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 30);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(846, 415);
            mainContainer.TabIndex = 1;
            mainContainer.ControlAdded += mainContainer_ControlAdded;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 445);
            Controls.Add(mainContainer);
            Controls.Add(header);
            Margin = new Padding(4, 2, 4, 2);
            Name = "MainForm";
            Text = "HoloRepository";
            header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel mainContainer;
        public Button modeSwitch;
    }
}