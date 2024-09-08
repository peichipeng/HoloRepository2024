namespace HoloRepository
{
    public class CustomTabControl : UserControl
    {
        private Label tab3DAvailable;
        private Label tabInProgress;
        private LineControl underlineControl;
        private LineControl fullUnderlineControl;
        public event EventHandler<string> TabChanged;
        public string SelectedTab { get; private set; }

        private Color selectedColor = ColorTranslator.FromHtml("#3381CA");
        private Color unselectedColor = Color.Gray;

        public CustomTabControl()
        {
            InitializeComponent();
            // Set the default option
            Tab3DAvailable_Click(tab3DAvailable, EventArgs.Empty);
        }

        private void InitializeComponent()
        {
            tab3DAvailable = new Label();
            tabInProgress = new Label();
            underlineControl = new LineControl();
            fullUnderlineControl = new LineControl();
            SuspendLayout();
            // 
            // tab3DAvailable
            // 
            tab3DAvailable.AutoSize = true;
            tab3DAvailable.Cursor = Cursors.Hand;
            tab3DAvailable.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tab3DAvailable.Location = new Point(14, 12);
            tab3DAvailable.Margin = new Padding(4, 0, 4, 0);
            tab3DAvailable.Name = "tab3DAvailable";
            tab3DAvailable.Size = new Size(170, 42);
            tab3DAvailable.TabIndex = 0;
            tab3DAvailable.Text = "3D Available";
            tab3DAvailable.Click += Tab3DAvailable_Click;
            // 
            // tabInProgress
            // 
            tabInProgress.AutoSize = true;
            tabInProgress.Cursor = Cursors.Hand;
            tabInProgress.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabInProgress.Location = new Point(200, 12);
            tabInProgress.Margin = new Padding(4, 0, 4, 0);
            tabInProgress.Name = "tabInProgress";
            tabInProgress.Size = new Size(154, 42);
            tabInProgress.TabIndex = 1;
            tabInProgress.Text = "In Progress";
            tabInProgress.Click += TabInProgress_Click;
            // 
            // underlineControl
            // 
            underlineControl.LineColor = Color.Silver;
            underlineControl.LineWidth = 4;
            underlineControl.Location = new Point(14, 50);
            underlineControl.Margin = new Padding(0);
            underlineControl.Name = "underlineControl";
            underlineControl.Size = new Size(165, 10);
            underlineControl.TabIndex = 2;
            // 
            // fullUnderlineControl
            // 
            fullUnderlineControl.Anchor = AnchorStyles.Top;
            fullUnderlineControl.LineColor = Color.Silver;
            fullUnderlineControl.LineWidth = 2;
            fullUnderlineControl.Location = new Point(-240, 60);
            fullUnderlineControl.Margin = new Padding(0);
            fullUnderlineControl.Name = "fullUnderlineControl";
            fullUnderlineControl.Size = new Size(2000, 1);
            fullUnderlineControl.TabIndex = 3;
            fullUnderlineControl.BringToFront();
            // 
            // CustomTabControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tab3DAvailable);
            Controls.Add(tabInProgress);
            Controls.Add(fullUnderlineControl);
            Controls.Add(underlineControl);
            Margin = new Padding(4);
            Name = "CustomTabControl";
            Size = new Size(600, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        private void Tab3DAvailable_Click(object sender, EventArgs e)
        {
            tab3DAvailable.ForeColor = selectedColor;
            tabInProgress.ForeColor = unselectedColor;
            underlineControl.LineColor = selectedColor;
            underlineControl.Location = new Point(tab3DAvailable.Left, 54); // Ensure the underline is at the same y position
            underlineControl.Size = new Size(tab3DAvailable.Width, underlineControl.Height);
            underlineControl.BringToFront(); // Make sure underlineControl is on top
            SelectedTab = "3D Available";
            TabChanged?.Invoke(this, SelectedTab);
            tab3DAvailable.Invalidate();
            tabInProgress.Invalidate();
            underlineControl.Invalidate();
        }

        private void TabInProgress_Click(object sender, EventArgs e)
        {
            tab3DAvailable.ForeColor = unselectedColor;
            tabInProgress.ForeColor = selectedColor;
            underlineControl.LineColor = selectedColor;
            underlineControl.Location = new Point(tabInProgress.Left, 54); // Ensure the underline is at the same y position
            underlineControl.Size = new Size(tabInProgress.Width, underlineControl.Height);
            underlineControl.BringToFront(); // Make sure underlineControl is on top
            SelectedTab = "In Progress";
            TabChanged?.Invoke(this, SelectedTab);
            tab3DAvailable.Invalidate();
            tabInProgress.Invalidate();
            underlineControl.Invalidate();
        }
    }
}
