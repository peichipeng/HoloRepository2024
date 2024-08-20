using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class CheckTableContent : UserControl
    {
        private System.Windows.Forms.Timer animationTimer;
        private float currentAngle = 0;
        private float targetAngle = 0;
        private float rotationStep = 5;
        private bool isShow = false;
        private int expandedHeight = 271;
        private int collapsedHeight = 50;
        private float animationDuration = 300;
        private int animationStep = 10;
        private DateTime animationStartTime;

        public CheckTableContent()
        {
            InitializeComponent();

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 16;
            animationTimer.Tick += AnimationTimer_Tick;

            this.Height = collapsedHeight;
            border.Visible = true;
            contentPanel.Height = 0;
            currentAngle = 0;
        }

        public void SetImageInfo(Image organSlice, Image dicomImage, string additionalInfo)
        {
            organSlicePictureBox.Image = organSlice;
            CTPictureBox.Image = dicomImage;
            additionalInfoContent.Text = additionalInfo;
        }

        public void SetTitle(string title)
        {
            organSliceTitle.Text = title;
        }

        private void SelectBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectBox.Checked)
            {
                this.BackColor = Color.FromArgb(243, 250, 255);
                additionalInfoContent.BackColor = Color.FromArgb(243, 250, 255);
            }
            else
            {
                this.BackColor = Color.White;
                additionalInfoContent.BackColor = Color.White;
            }
        }

        private void arrowPictureBox_Click(object sender, EventArgs e)
        {
            if (animationTimer.Enabled)
                return;

            if (isShow)
            {
                targetAngle -= 90;
            }
            else
            {
                targetAngle += 90;
            }

            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            float elapsed = (float)(DateTime.Now - animationStartTime).TotalMilliseconds;
            float progress = Math.Min(elapsed / animationDuration, 1);

            if (!isShow)
            {
                currentAngle = 90 * progress;
                contentPanel.Height = (int)(collapsedHeight + (expandedHeight - collapsedHeight) * progress);
            }
            else
            {
                currentAngle = 90 * (1 - progress);
                contentPanel.Height = (int)(expandedHeight - (expandedHeight - collapsedHeight) * progress);
            }

            if (progress >= 1)
            {
                animationTimer.Stop();
                isShow = !isShow;

                if (!isShow)
                {
                    this.Height = collapsedHeight;
                    border.Visible = true;
                }
                else
                {
                    this.Height = expandedHeight;
                    border.Visible = false;
                }
            }

            arrowPictureBox.Invalidate();
        }

        private void arrowPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (arrowPictureBox.Image != null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.Clear(arrowPictureBox.BackColor);

                int centerX = arrowPictureBox.Width / 2;
                int centerY = arrowPictureBox.Height / 2;

                e.Graphics.TranslateTransform(centerX, centerY);
                e.Graphics.RotateTransform(currentAngle); // 根据 currentAngle 旋转
                e.Graphics.TranslateTransform(-centerX, -centerY);

                e.Graphics.DrawImage(arrowPictureBox.Image, new Rectangle(0, 0, arrowPictureBox.Width, arrowPictureBox.Height));
            }
        }

    }
}