using HoloRepository.UserGuide.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.UserGuide
{
    public partial class UserGuideHome : BaseUserGuideControl
    {
        private List<GuidePanelData> guideData = new List<GuidePanelData>();
        public UserGuideHome()
        {
            InitializeComponent();

            SetGuideData();
            SetPanels();
        }

        private void SetGuideData()
        {
            guideData.Add(new GuidePanelData
            {
                GuideTitle = "Getting Started",
                GuideDescription = "Instructions on how to use this app",
                ImageName = "GettingStarted.png",
                GuideControl = new GettingStartedPage()
            });

            guideData.Add(new GuidePanelData
            {
                GuideTitle = "Key Concepts",
                GuideDescription = "Explanations of the key concepts in this app",
                ImageName = "KeyConcepts.png",
                GuideControl = new KeyConceptsPage()
            });

            guideData.Add(new GuidePanelData
            {
                GuideTitle = "Keyboard Shortcuts",
                GuideDescription = "Keyboard shortcuts of all the functions",
                ImageName = "Keyboard.png",
                GuideControl = new KeyboardShortcutsPage()
            });
        }

        private void SetPanels()
        {
            int controlsPerRow = 2;
            int padding = 20;

            for (int i = 0; i < guideData.Count; i++)
            {
                var panel = new GuidePanel(guideData[i]);

                int startX = (this.Width - padding) / 2 - panel.Width;
                int startY = 140;

                int row = i / controlsPerRow;
                int col = i % controlsPerRow;

                int x = startX + col * (panel.Width + padding);
                int y = startY + row * (panel.Height + padding);

                panel.Location = new Point(x, y);
                panel.Anchor = AnchorStyles.Top;

                this.Controls.Add(panel);
            }
        }
    }
}
