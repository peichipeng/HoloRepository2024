using HoloRepository;

public class PopupWindow : Form
{
    public string Result { get; private set; } = string.Empty;
    private Form? parentForm;
    private OverlayForm? overlay;
    private MainForm? mainForm;
    private bool isSubscribed = false;

    public void SetResult(string result)
    {
        Result = result;
    }

    public PopupWindow()
    {
        InitializeComponent();
        this.Load += PopupWindow_Load;
        this.FormClosed += PopupWindow_FormClosed;
        this.HandleCreated += PopupWindow_HandleCreated;
        this.HandleDestroyed += PopupWindow_HandleDestroyed;
    }

    public PopupWindow(string text, Form parentForm)
    {
        InitializeComponent();

        this.parentForm = parentForm ?? throw new ArgumentNullException(nameof(parentForm), "Parent form cannot be null.");

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

        this.Load += PopupWindow_Load;
        this.FormClosed += PopupWindow_FormClosed;
        this.HandleCreated += PopupWindow_HandleCreated;
        this.HandleDestroyed += PopupWindow_HandleDestroyed;
    }

    private void PopupWindow_Load(object? sender, EventArgs e)
    {
        mainForm = (MainForm)Application.OpenForms[0];
        if (!isSubscribed)
        {
            GlobalEventManager.OnGlobalTranscriptionReceived += OnTranscriptionReceived;
            isSubscribed = true;
        }
    }

    private void PopupWindow_FormClosed(object? sender, FormClosedEventArgs e)
    {
        if (mainForm != null && isSubscribed)
        {
            GlobalEventManager.OnGlobalTranscriptionReceived -= OnTranscriptionReceived;
            isSubscribed = false;
        }
        overlay?.Dispose();
    }

    private void PopupWindow_HandleCreated(object? sender, EventArgs e)
    {
    }

    private void PopupWindow_HandleDestroyed(object? sender, EventArgs e)
    {
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
        PopupTitle.Size = new Size(376, 32);
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
        ClientSize = new Size(500, 300);
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

    private RoundedButton? PopupYesButton;
    private RoundedButton? PopupNoButton;
    private Label PopupTitle;

    private void PopupYesButton_Click(object? sender, EventArgs e)
    {
        Result = "Yes";
        DialogResult = DialogResult.Yes;
        this.Close();
    }

    private void PopupNoButton_Click(object? sender, EventArgs e)
    {
        Result = "No";
        DialogResult = DialogResult.No;
        this.Close();
    }

    public void OnTranscriptionReceived(string transcription)
    {
        if (InvokeRequired)
        {
            Invoke(new Action<string>(OnTranscriptionReceived), transcription);
            return;
        }

        if (transcription.ToLower().Contains("yes"))
        {
            Result = "Yes";
            this.Close();
        }
        else if (transcription.ToLower().Contains("no"))
        {
            Result = "No";
            this.Close();
        }
    }
}
