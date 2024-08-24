using HoloRepository.AddCase;
using HoloRepository.UserGuide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HoloRepository
{
    public partial class HomePageControl : UserControl
    {
        //private Process _unityProcess;
        //private IntPtr _unityHWND;

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern bool SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        //private const int GWL_STYLE = -16;
        //private const int WS_VISIBLE = 0x10000000;
        //private const int WS_CHILD = 0x40000000;
        public HomePageControl()
        {
            InitializeComponent();
            StartUnity();
        }

        public void LoadControl(UserControl userControl)
        {
            if (this.Parent.Parent is MainForm mainForm)
            {
                mainForm.LoadControl(userControl);
            }
        }

        public void AddControl(UserControl userControl)
        {
            if (this.Parent.Parent is MainForm mainForm)
            {
                mainForm.AddControl(userControl);
            }
        }

        private void addCaseBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
            //LoadControl(new AddCaseControl());
        }

        private void viewCasesBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new ViewCasesControl());
        }

        private void organArchiveBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new OrganArchiveControl());
        }

        private void userGuideBtn_Click(object sender, EventArgs e)
        {
            AddControl(new UserGuideHome());
        }

        private void tempBtn_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseFramework("home", "addCase"));
        }

        private void btnUpdateOrgan_Click(object sender, EventArgs e)
        {
            LoadControl(new AddCaseControl(12, 33));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _3DModelFormWindow modelFormWindow = new _3DModelFormWindow(33);
            modelFormWindow.Show();
        }

        private void StartUnity()
        {
            string relativePath = "3d_viewer\\HoloRepositoryPortable2021.exe";
            string fullPath = Path.Combine(Application.StartupPath, relativePath);

            IntPtr panelHWND = panel1.Handle;
            string customArgument = "C:\\Users\\pei-chi.peng\\Downloads\\kidney_test_0000.glb";

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = fullPath,
                Arguments = $"-parentHWND {panelHWND.ToInt64()} delayed #{customArgument}",
                WindowStyle = ProcessWindowStyle.Hidden,
            };

            Process.Start(startInfo);
            //_unityProcess = Process.Start(startInfo);

            //if (_unityProcess != null)
            //{
            //    _unityProcess.WaitForInputIdle();

            //    //_unityHWND = FindWindow(null, null); // Replace with actual window title of Unity build

            //    if (_unityHWND != IntPtr.Zero)
            //    {
            //        //SetParent(_unityHWND, panelHWND);

            //        //// Set the Unity window style to be a child of the panel
            //        //SetWindowLong(_unityHWND, GWL_STYLE, WS_VISIBLE | WS_CHILD);

            //        //// Resize the Unity window to fit the panel
            //        //MoveWindow(_unityHWND, 0, 0, panel1.Width, panel1.Height, true);

            //        //// Optionally handle resizing of the panel
            //        //panel1.Resize += (s, e) =>
            //        //{
            //        //    MoveWindow(_unityHWND, 0, 0, panel1.Width, panel1.Height, true);
            //        //};
            //    }
            //    else
            //    {
            //        //MessageBox.Show("Unity window not found!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Failed to start Unity process.");
            //}
        }
    }
}
