using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoloRepository
{
    public partial class PopupWindow : Form
    {
        public PopupWindow()
        {
            InitializeComponent();
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
            PopupTitle.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point);
            PopupTitle.Location = new Point(83, 140);
            PopupTitle.Name = "PopupTitle";
            PopupTitle.Size = new Size(701, 70);
            PopupTitle.TabIndex = 0;
            PopupTitle.Text = "Are you sure you want to cancel?";
            // 
            // PopupYesButton
            // 
            PopupYesButton.BackColor = Color.FromArgb(224, 224, 224);
            PopupYesButton.BorderRadius = 20;
            PopupYesButton.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PopupYesButton.Location = new Point(267, 262);
            PopupYesButton.Name = "PopupYesButton";
            PopupYesButton.Size = new Size(125, 62);
            PopupYesButton.TabIndex = 1;
            PopupYesButton.Text = "Yes";
            PopupYesButton.UseVisualStyleBackColor = false;
            // 
            // PopupNoButton
            // 
            PopupNoButton.BackColor = Color.FromArgb(51, 129, 202);
            PopupNoButton.BorderRadius = 20;
            PopupNoButton.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PopupNoButton.ForeColor = Color.White;
            PopupNoButton.Location = new Point(474, 262);
            PopupNoButton.Name = "PopupNoButton";
            PopupNoButton.Size = new Size(125, 62);
            PopupNoButton.TabIndex = 2;
            PopupNoButton.Text = "No";
            PopupNoButton.UseVisualStyleBackColor = false;
            // 
            // PopupWindow
            // 
            ClientSize = new Size(866, 465);
            ControlBox = false;
            Controls.Add(PopupNoButton);
            Controls.Add(PopupYesButton);
            Controls.Add(PopupTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopupWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        private RoundedButton PopupYesButton;
        private RoundedButton PopupNoButton;
        private Label PopupTitle;
    }
}
