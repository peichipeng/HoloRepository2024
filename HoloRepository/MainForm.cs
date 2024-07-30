
using HoloRepository.AddCase;
using HoloRepository.UserGuide;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HoloRepository
{
    public partial class MainForm : Form
    {
        private bool isSpeechMode = false;
        private Process? _pythonProcess;
        private StreamWriter? _pythonInput;
        private StreamReader? _pythonOutput;
        private Thread? _outputThread;

        public MainForm()
        {
            InitializeComponent();
            LoadControl(new HomePageControl());
            InitializePythonProcess();
        }

        private void InitializePythonProcess()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string pythonExePath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\..\env\python.exe"));
            string pythonScriptPath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\transcription.py"));

            if (!File.Exists(pythonExePath))
            {
                MessageBox.Show($"Python interpreter not found at {pythonExePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(pythonScriptPath))
            {
                MessageBox.Show($"Python script not found at {pythonScriptPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var startInfo = new ProcessStartInfo
            {
                FileName = pythonExePath,
                Arguments = $"\"{pythonScriptPath}\"",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            _pythonProcess = new Process { StartInfo = startInfo };
            try
            {
                _pythonProcess.Start();
                _pythonInput = _pythonProcess.StandardInput;
                _pythonOutput = _pythonProcess.StandardOutput;

                _outputThread = new Thread(() =>
                {
                    while (!_pythonOutput.EndOfStream)
                    {
                        var output = _pythonOutput.ReadLine();
                        if (!string.IsNullOrEmpty(output))
                        {
                            Invoke(new Action(() => ProcessTranscription(output)));
                        }
                    }
                });
                _outputThread.IsBackground = true;
                _outputThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start Python script: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessTranscription(string transcription)
        {
            if (mainContainer.Controls.Count > 0 && mainContainer.Controls[0] is HomePageControl homePageControl)
            {
                if (transcription.ToLower().Contains("add a case"))
                {
                    homePageControl.addCaseBtn_Click(this, EventArgs.Empty);
                }
                else if (transcription.ToLower().Contains("view cases"))
                {
                    homePageControl.viewCasesBtn_Click(this, EventArgs.Empty);
                }
                else if (transcription.ToLower().Contains("organ archive"))
                {
                    homePageControl.organArchiveBtn_Click(this, EventArgs.Empty);
                }
                else if (transcription.ToLower().Contains("user guide"))
                {
                    homePageControl.userGuideBtn_Click(this, EventArgs.Empty);
                }
            }
        }

        public void LoadControl(UserControl userControl)
        {
            mainContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(userControl);
        }

        public void AddControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void mainContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            OnContentChanged();
        }

        public void OnContentChanged()
        {
            int controlsCount = mainContainer.Controls.Count;

            // Please don't remove the following code snippet when changing the control.
            if (mainContainer.Controls.OfType<UserGuideHome>().Any())
            {
                modeSwitch.Visible = false;
                breadcrumbPanel.Visible = false;

                previousPageBtn.Location = new Point(breadcrumbPanel.Location.X, blackHomeBtn.Location.Y);
                previousPageBtn.Visible = true;
                blackHomeBtn.Visible = true;
            }
            else if (controlsCount > 0)
            {
                previousPageBtn.Visible = false;
                blackHomeBtn.Visible = false;
                var control = mainContainer.Controls[controlsCount - 1];

                if (control is AddCaseFramework caseFramework)
                {
                    if (caseFramework.addCaseContainer.Controls.Count > 0 &&
                        caseFramework.addCaseContainer.Controls[0] is CasePage casePage &&
                        casePage.pageName == "caseOverview")
                    {
                        modeSwitch.Visible = false;

                        breadcrumbPanel.Visible = true;
                        LoadBreadcrumb();
                    }
                    else
                    {
                        modeSwitch.Visible = true;
                        breadcrumbPanel.Visible = false;
                    }
                }
                else if (control is ViewCasesControl)
                {
                    modeSwitch.Visible = true;

                    breadcrumbPanel.Visible = true;
                    LoadBreadcrumb();
                }
                else if (control is HomePageControl)
                {
                    modeSwitch.Visible = true;
                    breadcrumbPanel.Visible = false;
                }
                else
                {
                    modeSwitch.Visible = false;
                    breadcrumbPanel.Visible = false;
                }
            }
        }

        private void modeSwitch_Click(object sender, EventArgs e)
        {
            isSpeechMode = !isSpeechMode;
            if (isSpeechMode)
            {
                modeSwitch.BackColor = Color.IndianRed;
                StartTranscription();
            }
            else
            {
                modeSwitch.BackColor = SystemColors.Control;
                StopTranscription();
            }
        }

        private void StartTranscription()
        {
            if (_pythonInput != null)
            {
                _pythonInput.WriteLine("start_transcription");
            }
            else
            {
                MessageBox.Show("Failed to start transcription. Python process is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopTranscription()
        {
            if (_pythonInput != null)
            {
                _pythonInput.WriteLine("stop_transcription");
            }
            else
            {
                MessageBox.Show("Failed to stop transcription. Python process is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSpeechMode)
            {
                StopTranscription();
            }

            if (_pythonProcess != null && !_pythonProcess.HasExited)
            {
                _pythonProcess.Kill();
                _pythonProcess.Dispose();
            }
        }

        // Retrieve the page name of the control
        private string pageName(Control control)
        {
            string pageBtnName = "";
            if (control is ViewCasesControl)
            {
                pageBtnName = "View Cases";
            }
            else if (control is AddCaseFramework framework)
            {
                if (framework.addCaseContainer.Controls[0] is CasePage casePage)
                {
                    pageBtnName = $"Case {casePage.donorId}";
                }
            }

            return pageBtnName;
        }

        private void LoadBreadcrumb()
        {
            breadcrumbPanel.Controls.Clear();
            breadcrumbPanel.Controls.AddRange(new Control[] { homeBtn, BreadcrumbArrow() });

            for (int i = mainContainer.Controls.Count - 2; i > -1; i--)
            {
                breadcrumbPanel.Controls.Add(PreviousPageBtn(pageName(mainContainer.Controls[i])));
                breadcrumbPanel.Controls.Add(BreadcrumbArrow());
            }
            Control controlAdded = mainContainer.Controls[mainContainer.Controls.Count - 1];
            string newPageName = pageName(controlAdded);
            breadcrumbPanel.Controls.Add(CurrentPageLabel(newPageName));
        }

        private PictureBox BreadcrumbArrow()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            arrow = new PictureBox();
            arrow.Image = (Image)resources.GetObject("arrow.Image");
            arrow.Margin = new Padding(0, 6, 0, 3);
            arrow.Size = new Size(16, 16);
            arrow.SizeMode = PictureBoxSizeMode.Zoom;
            arrow.TabIndex = 0;
            arrow.TabStop = false;
            return arrow;
        }

        private Label CurrentPageLabel(string pageName)
        {
            var label = new Label
            {
                Text = pageName,
                AutoSize = true,
                Margin = new Padding(3, 5, 0, 0),
                Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            };
            return label;
        }

        private Button PreviousPageBtn(string text)
        {
            var pageBtn = new Button
            {
                AutoSize = true,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point),
                Margin = new Padding(0, 0, 0, 0),
                Size = new Size(55, 27),
                TabIndex = 0,
                UseVisualStyleBackColor = true,
                ForeColor = Color.FromArgb(165, 165, 165),
                Text = text
            };
            pageBtn.Click += pageBtn_Click;
            return pageBtn;
        }

        private void pageBtn_Click(object sender, EventArgs e)
        {
            var clickedBtn = (Button)sender;
            string buttonText = clickedBtn.Text;

            int controlIndex = breadcrumbPanel.Controls.IndexOf(clickedBtn) / 2;

            // Remove the pages no longer needed
            for (int i = mainContainer.Controls.Count - controlIndex; i > -1; i--)
            {
                mainContainer.Controls.RemoveAt(i);
            }

            if (buttonText == "View Cases")
            {
                AddControl(new ViewCasesControl());
            }
            else
            {
                // If the button of case overview page was clicked
                string[] words = buttonText.Split(' ');
                int donorId = int.Parse(words[1]);
                AddControl(new AddCaseFramework("viewCases", "caseOverview", donorId));
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new HomePageControl());
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            mainContainer.Controls.RemoveAt(0);
        }

        private void mainContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            OnContentChanged();
        }

        private void blackHomeBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new HomePageControl());
        }
    }
}
