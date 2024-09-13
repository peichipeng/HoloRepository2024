﻿using System;
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
    public partial class BaseUserGuideControl : UserControl
    {
        public BaseUserGuideControl()
        {
            InitializeComponent();

            searchBox.Location = new Point((this.Width - searchBox.Width) / 2, searchBox.Location.Y);
            searchIcon.Location = new Point(searchBox.Location.X + 8, searchBox.Location.Y + 8);
        }

        private void pageNameLabel_ClientSizeChanged(object sender, EventArgs e)
        {
            pageNameLabel.Location = new Point((this.Width - pageNameLabel.Width) / 2, pageNameLabel.Location.Y);
        }
    }
}
