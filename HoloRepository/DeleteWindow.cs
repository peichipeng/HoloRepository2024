using System;
using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class DeleteWindow : Form
    {
        private System.Windows.Forms.Timer fadeInTimer;
        private const int fadeInDuration = 200; // Total duration of fade-in effect in milliseconds
        private const int frameInterval = 10; // Interval for each frame in milliseconds
        private readonly int steps;
        private int currentStep;

        public DeleteWindow()
        {
            InitializeComponent();
            InitializeCustomComponents();
            InitializeCustomEvents();
            steps = fadeInDuration / frameInterval;

            this.StartPosition = FormStartPosition.Manual;
        }

        private void InitializeCustomComponents()
        {
            // Initialize the Timer
            fadeInTimer = new System.Windows.Forms.Timer();
            fadeInTimer.Interval = frameInterval;
            fadeInTimer.Tick += FadeInTimer_Tick;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            StartFadeInEffect();
        }

        private void StartFadeInEffect()
        {
            this.Opacity = 0;
            currentStep = 0;
            fadeInTimer.Start();
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            currentStep++;
            this.Opacity = (double)currentStep / steps;

            if (currentStep >= steps)
            {
                fadeInTimer.Stop();
            }
        }

        private void InitializeCustomEvents()
        {
            DeleteYesButton.Click += DeleteYesButton_Click;
            DeleteNoButton.Click += DeleteNoButton_Click;
        }

        private void DeleteYesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void DeleteNoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void InitializeComponent()
        {
            DeleteTitle = new Label();
            DeleteYesButton = new RoundedButton();
            DeleteNoButton = new RoundedButton();
            SuspendLayout();
            // 
            // DeleteTitle
            // 
            DeleteTitle.AutoSize = true;
            DeleteTitle.Font = new Font("Poppins", 20F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteTitle.Location = new Point(87, 140);
            DeleteTitle.Name = "DeleteTitle";
            DeleteTitle.Size = new Size(692, 70);
            DeleteTitle.TabIndex = 0;
            DeleteTitle.Text = "Are you sure you want to delete?";
            // 
            // DeleteYesButton
            // 
            DeleteYesButton.BackColor = Color.FromArgb(224, 224, 224);
            DeleteYesButton.BorderRadius = 20;
            DeleteYesButton.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteYesButton.Location = new Point(271, 262);
            DeleteYesButton.Name = "DeleteYesButton";
            DeleteYesButton.Size = new Size(125, 62);
            DeleteYesButton.TabIndex = 1;
            DeleteYesButton.Text = "Yes";
            DeleteYesButton.UseVisualStyleBackColor = false;
            // 
            // DeleteNoButton
            // 
            DeleteNoButton.BackColor = Color.FromArgb(51, 129, 202);
            DeleteNoButton.BorderRadius = 20;
            DeleteNoButton.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteNoButton.ForeColor = Color.White;
            DeleteNoButton.Location = new Point(478, 262);
            DeleteNoButton.Name = "DeleteNoButton";
            DeleteNoButton.Size = new Size(125, 62);
            DeleteNoButton.TabIndex = 2;
            DeleteNoButton.Text = "No";
            DeleteNoButton.UseVisualStyleBackColor = false;
            DeleteNoButton.Click += PopupNoButton_Click;
            // 
            // DeleteWindow
            // 
            ClientSize = new Size(866, 465);
            ControlBox = false;
            Controls.Add(DeleteNoButton);
            Controls.Add(DeleteYesButton);
            Controls.Add(DeleteTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        private RoundedButton DeleteYesButton;
        private RoundedButton DeleteNoButton;
        private Label DeleteTitle;

        private void PopupNoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
