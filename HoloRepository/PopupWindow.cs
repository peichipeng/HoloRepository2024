﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository
{
    public partial class PopupWindow : Form
    {
        private OverlayForm overlay;
        public PopupWindow()
        {
            // For cancellation
            InitializeComponent();
        }
        public PopupWindow(string text, Form parentForm)
        {
            InitializeComponent();

            overlay = new OverlayForm
            {
                Location = parentForm.Location,
                Size = parentForm.Size
            };
            overlay.Show(parentForm);

            PopupTitle.Text = text;
            PopupTitle.Location = new Point(Width / 2 - PopupTitle.Width / 2, 100);
            this.Location = new Point(parentForm.Left + (parentForm.Width - this.Width) / 2, parentForm.Top + (parentForm.Height - this.Height) / 2);
            this.TopMost = true;
        }
        private void InitializeComponent()
        {
            PopupTitle = new Label();
            PopupYesButton = new RoundedButton();
            PopupNoButton = new RoundedButton();
            SuspendLayout();
            // 
            // PopupTitle
            // 
            PopupTitle.AutoSize = true;
            PopupTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PopupTitle.Location = new Point(64, 102);
            PopupTitle.Name = "PopupTitle";
            PopupTitle.Size = new Size(560, 48);
            PopupTitle.TabIndex = 0;
            PopupTitle.Text = "Are you sure you want to cancel?";
            // 
            // PopupYesButton
            // 
            PopupYesButton.BackColor = Color.FromArgb(224, 224, 224);
            PopupYesButton.BorderRadius = 20;
            PopupYesButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PopupYesButton.Location = new Point(143, 167);
            PopupYesButton.Name = "PopupYesButton";
            PopupYesButton.Size = new Size(80, 40);
            PopupYesButton.TabIndex = 1;
            PopupYesButton.Text = "Yes";
            PopupYesButton.UseVisualStyleBackColor = false;
            PopupYesButton.Click += PopupYesButton_Click;
            // 
            // PopupNoButton
            // 
            PopupNoButton.BackColor = Color.FromArgb(51, 129, 202);
            PopupNoButton.BorderRadius = 20;
            PopupNoButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PopupNoButton.ForeColor = Color.White;
            PopupNoButton.Location = new Point(277, 167);
            PopupNoButton.Name = "PopupNoButton";
            PopupNoButton.Size = new Size(80, 40);
            PopupNoButton.TabIndex = 2;
            PopupNoButton.Text = "No";
            PopupNoButton.UseVisualStyleBackColor = false;
            PopupNoButton.Click += PopupNoButton_Click;
            // 
            // PopupWindow
            // 
            BackColor = Color.White;
            ClientSize = new Size(632, 288);
            ControlBox = false;
            Controls.Add(PopupNoButton);
            Controls.Add(PopupYesButton);
            Controls.Add(PopupTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupWindow";
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
            PerformLayout();
        }

        private RoundedButton PopupYesButton;
        private RoundedButton PopupNoButton;
        private Label PopupTitle;

        private void PopupYesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
            WindowClosed();
        }

        private void PopupNoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
            WindowClosed();
        }

        private void WindowClosed()
        {
            overlay.Dispose();
        }
    }
}
