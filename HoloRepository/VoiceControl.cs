using System;
using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class VoiceControl : UserControl
    {
        // 新增字段用于动画
        private Panel movingPanel;
        private System.Windows.Forms.Timer animationTimer; // 使用完整的命名空间路径
        private bool isMovingToPictureBox2 = true;
        private int animationStep = 0;
        private const int totalSteps = 30; // 动画的步数

        public VoiceControl()
        {
            InitializeComponent();
            InitializeAnimationComponents();
        }

        private void InitializeAnimationComponents()
        {
            // 初始化动画组件
            movingPanel = new Panel
            {
                BackColor = Color.FromArgb(150, 150, 150), // 半透明灰色
                Size = pictureBox1.Size,
                Location = pictureBox1.Location,
                Visible = false
            };
            Controls.Add(movingPanel);
            movingPanel.BringToFront();

            animationTimer = new System.Windows.Forms.Timer // 使用完整的命名空间路径
            {
                Interval = 20 // 20 毫秒的间隔，保证动画平滑
            };
            animationTimer.Tick += AnimationTimer_Tick;

            // 注册点击事件
            this.Click += VoiceControl_Click;
        }

        private void VoiceControl_Click(object sender, EventArgs e)
        {
            // 启动动画
            movingPanel.Visible = true;
            animationStep = 0;
            isMovingToPictureBox2 = !isMovingToPictureBox2; // 切换方向
            animationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // 计算新的位置和大小
            float t = (float)animationStep / totalSteps;
            int x, y, width, height;

            if (isMovingToPictureBox2)
            {
                // 从 pictureBox1 移动到 pictureBox2
                x = (int)(pictureBox1.Left + t * (pictureBox2.Left - pictureBox1.Left));
                y = (int)(pictureBox1.Top + t * (pictureBox2.Top - pictureBox1.Top));
                width = (int)(pictureBox1.Width + t * (pictureBox2.Width - pictureBox1.Width));
                height = (int)(pictureBox1.Height + t * (pictureBox2.Height - pictureBox1.Height));
            }
            else
            {
                // 从 pictureBox2 移动到 pictureBox1
                x = (int)(pictureBox2.Left + t * (pictureBox1.Left - pictureBox2.Left));
                y = (int)(pictureBox2.Top + t * (pictureBox1.Top - pictureBox2.Top));
                width = (int)(pictureBox2.Width + t * (pictureBox1.Width - pictureBox2.Width));
                height = (int)(pictureBox2.Height + t * (pictureBox1.Height - pictureBox2.Height));
            }

            movingPanel.Bounds = new Rectangle(x, y, width, height);

            // 增加动画步数
            animationStep++;

            // 动画结束
            if (animationStep > totalSteps)
            {
                animationTimer.Stop();
                movingPanel.Visible = false;
            }
        }
    }
}
