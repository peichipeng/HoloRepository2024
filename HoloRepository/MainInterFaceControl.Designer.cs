namespace HoloRepository
{
    partial class MainInterFaceControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterFaceControl));
            btnLocation = new PictureBox();
            shadowPanel1 = new ShadowPanel();
            btnDelete = new PictureBox();
            btnUpdate = new PictureBox();
            btnCT = new PictureBox();
            btn3D = new PictureBox();
            btnRotation = new PictureBox();
            btnZoomOut = new PictureBox();
            btnZoomIn = new PictureBox();
            panel1 = new Panel();
            btnConstruct = new RoundedButton();
            notFoundLabel = new Label();
            slicePicture = new PictureBox();
            donorInfoPanel = new ShadowPanel();
            userGuideBtn = new PictureBox();
            organSlicePanel = new Panel();
            CTPanel = new RoundedPanel();
            btnClose = new PictureBox();
            sliderControl1 = new SliderControl();
            DICOMFilePicture = new PictureBox();
            btnBack3D = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnLocation).BeginInit();
            shadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn3D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRotation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnZoomOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnZoomIn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slicePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGuideBtn).BeginInit();
            CTPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DICOMFilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack3D).BeginInit();
            SuspendLayout();
            // 
            // btnLocation
            // 
            btnLocation.Anchor = AnchorStyles.Top;
            btnLocation.BackColor = Color.Transparent;
            btnLocation.Cursor = Cursors.Hand;
            btnLocation.Image = (Image)resources.GetObject("btnLocation.Image");
            btnLocation.Location = new Point(10, 18);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(25, 25);
            btnLocation.SizeMode = PictureBoxSizeMode.Zoom;
            btnLocation.TabIndex = 78;
            btnLocation.TabStop = false;
            // 
            // shadowPanel1
            // 
            shadowPanel1.Anchor = AnchorStyles.None;
            shadowPanel1.BackColor = Color.WhiteSmoke;
            shadowPanel1.BorderColor = Color.Black;
            shadowPanel1.BorderRadius = 10;
            shadowPanel1.BorderWidth = 0;
            shadowPanel1.Controls.Add(btnDelete);
            shadowPanel1.Controls.Add(btnUpdate);
            shadowPanel1.Controls.Add(btnCT);
            shadowPanel1.Controls.Add(btn3D);
            shadowPanel1.Controls.Add(btnRotation);
            shadowPanel1.Controls.Add(btnZoomOut);
            shadowPanel1.Controls.Add(btnZoomIn);
            shadowPanel1.Controls.Add(btnLocation);
            shadowPanel1.Location = new Point(13, 18);
            shadowPanel1.Margin = new Padding(2, 2, 2, 2);
            shadowPanel1.Name = "shadowPanel1";
            shadowPanel1.Padding = new Padding(6, 6, 6, 6);
            shadowPanel1.Size = new Size(45, 326);
            shadowPanel1.TabIndex = 79;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(10, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(25, 25);
            btnDelete.SizeMode = PictureBoxSizeMode.Zoom;
            btnDelete.TabIndex = 85;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(10, 247);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(25, 25);
            btnUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            btnUpdate.TabIndex = 84;
            btnUpdate.TabStop = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCT
            // 
            btnCT.Anchor = AnchorStyles.Top;
            btnCT.BackColor = Color.Transparent;
            btnCT.Cursor = Cursors.Hand;
            btnCT.Image = (Image)resources.GetObject("btnCT.Image");
            btnCT.Location = new Point(10, 209);
            btnCT.Name = "btnCT";
            btnCT.Size = new Size(25, 25);
            btnCT.SizeMode = PictureBoxSizeMode.Zoom;
            btnCT.TabIndex = 83;
            btnCT.TabStop = false;
            btnCT.Click += btnCT_Click;
            // 
            // btn3D
            // 
            btn3D.Anchor = AnchorStyles.Top;
            btn3D.BackColor = Color.Transparent;
            btn3D.Cursor = Cursors.Hand;
            btn3D.Image = (Image)resources.GetObject("btn3D.Image");
            btn3D.Location = new Point(10, 171);
            btn3D.Name = "btn3D";
            btn3D.Size = new Size(25, 25);
            btn3D.SizeMode = PictureBoxSizeMode.Zoom;
            btn3D.TabIndex = 82;
            btn3D.TabStop = false;
            btn3D.Click += btn3D_Click;
            // 
            // btnRotation
            // 
            btnRotation.Anchor = AnchorStyles.Top;
            btnRotation.BackColor = Color.Transparent;
            btnRotation.Cursor = Cursors.Hand;
            btnRotation.Image = (Image)resources.GetObject("btnRotation.Image");
            btnRotation.Location = new Point(10, 132);
            btnRotation.Name = "btnRotation";
            btnRotation.Size = new Size(25, 25);
            btnRotation.SizeMode = PictureBoxSizeMode.Zoom;
            btnRotation.TabIndex = 81;
            btnRotation.TabStop = false;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Anchor = AnchorStyles.Top;
            btnZoomOut.BackColor = Color.Transparent;
            btnZoomOut.Cursor = Cursors.Hand;
            btnZoomOut.Image = (Image)resources.GetObject("btnZoomOut.Image");
            btnZoomOut.Location = new Point(10, 94);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(25, 25);
            btnZoomOut.SizeMode = PictureBoxSizeMode.Zoom;
            btnZoomOut.TabIndex = 80;
            btnZoomOut.TabStop = false;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Anchor = AnchorStyles.Top;
            btnZoomIn.BackColor = Color.Transparent;
            btnZoomIn.Cursor = Cursors.Hand;
            btnZoomIn.Image = (Image)resources.GetObject("btnZoomIn.Image");
            btnZoomIn.Location = new Point(10, 56);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(25, 25);
            btnZoomIn.SizeMode = PictureBoxSizeMode.Zoom;
            btnZoomIn.TabIndex = 79;
            btnZoomIn.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnConstruct);
            panel1.Controls.Add(notFoundLabel);
            panel1.Controls.Add(slicePicture);
            panel1.Location = new Point(97, 18);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 310);
            panel1.TabIndex = 80;
            // 
            // btnConstruct
            // 
            btnConstruct.Anchor = AnchorStyles.None;
            btnConstruct.BackColor = Color.FromArgb(238, 238, 238);
            btnConstruct.BorderRadius = 15;
            btnConstruct.Cursor = Cursors.Hand;
            btnConstruct.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnConstruct.ForeColor = Color.Black;
            btnConstruct.Location = new Point(211, 160);
            btnConstruct.Margin = new Padding(1, 1, 9, 1);
            btnConstruct.Name = "btnConstruct";
            btnConstruct.Size = new Size(191, 28);
            btnConstruct.TabIndex = 83;
            btnConstruct.Text = "+ &Construct 3D Model";
            btnConstruct.UseVisualStyleBackColor = false;
            btnConstruct.Click += btn3D_Click;
            // 
            // notFoundLabel
            // 
            notFoundLabel.AutoSize = true;
            notFoundLabel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            notFoundLabel.Location = new Point(159, 112);
            notFoundLabel.Margin = new Padding(2, 0, 2, 0);
            notFoundLabel.Name = "notFoundLabel";
            notFoundLabel.Size = new Size(278, 24);
            notFoundLabel.TabIndex = 1;
            notFoundLabel.Text = "No 3D model found for this case";
            // 
            // slicePicture
            // 
            slicePicture.Dock = DockStyle.Fill;
            slicePicture.Location = new Point(0, 0);
            slicePicture.Margin = new Padding(2, 2, 2, 2);
            slicePicture.Name = "slicePicture";
            slicePicture.Size = new Size(613, 310);
            slicePicture.SizeMode = PictureBoxSizeMode.Zoom;
            slicePicture.TabIndex = 0;
            slicePicture.TabStop = false;
            // 
            // donorInfoPanel
            // 
            donorInfoPanel.Anchor = AnchorStyles.None;
            donorInfoPanel.AutoSize = true;
            donorInfoPanel.BackColor = Color.White;
            donorInfoPanel.BorderColor = Color.LightGray;
            donorInfoPanel.BorderRadius = 10;
            donorInfoPanel.BorderWidth = 2;
            donorInfoPanel.Location = new Point(613, 18);
            donorInfoPanel.Margin = new Padding(2, 2, 2, 2);
            donorInfoPanel.Name = "donorInfoPanel";
            donorInfoPanel.Padding = new Padding(6, 6, 6, 6);
            donorInfoPanel.Size = new Size(179, 106);
            donorInfoPanel.TabIndex = 0;
            // 
            // userGuideBtn
            // 
            userGuideBtn.Anchor = AnchorStyles.None;
            userGuideBtn.BackColor = Color.Transparent;
            userGuideBtn.Cursor = Cursors.Hand;
            userGuideBtn.Image = (Image)resources.GetObject("userGuideBtn.Image");
            userGuideBtn.Location = new Point(13, 399);
            userGuideBtn.Name = "userGuideBtn";
            userGuideBtn.Size = new Size(19, 19);
            userGuideBtn.SizeMode = PictureBoxSizeMode.Zoom;
            userGuideBtn.TabIndex = 86;
            userGuideBtn.TabStop = false;
            userGuideBtn.Click += userGuideBtn_Click;
            // 
            // organSlicePanel
            // 
            organSlicePanel.Anchor = AnchorStyles.None;
            organSlicePanel.BackColor = Color.Transparent;
            organSlicePanel.Location = new Point(104, 332);
            organSlicePanel.Margin = new Padding(2, 2, 2, 2);
            organSlicePanel.Name = "organSlicePanel";
            organSlicePanel.Size = new Size(597, 94);
            organSlicePanel.TabIndex = 90;
            // 
            // CTPanel
            // 
            CTPanel.Anchor = AnchorStyles.None;
            CTPanel.BorderColor = Color.LightGray;
            CTPanel.BorderRadius = 10;
            CTPanel.BorderWidth = 2;
            CTPanel.Controls.Add(btnClose);
            CTPanel.Controls.Add(sliderControl1);
            CTPanel.Controls.Add(DICOMFilePicture);
            CTPanel.Location = new Point(67, 18);
            CTPanel.Margin = new Padding(2, 2, 2, 2);
            CTPanel.Name = "CTPanel";
            CTPanel.Size = new Size(305, 236);
            CTPanel.TabIndex = 91;
            CTPanel.Visible = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(292, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(10, 9);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 78;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // sliderControl1
            // 
            sliderControl1.Location = new Point(19, 9);
            sliderControl1.Margin = new Padding(1, 1, 1, 1);
            sliderControl1.Name = "sliderControl1";
            sliderControl1.NumberOfImages = 0;
            sliderControl1.Size = new Size(269, 17);
            sliderControl1.TabIndex = 2;
            sliderControl1.Text = "sliderControl1";
            // 
            // DICOMFilePicture
            // 
            DICOMFilePicture.Location = new Point(10, 28);
            DICOMFilePicture.Margin = new Padding(1, 1, 1, 1);
            DICOMFilePicture.Name = "DICOMFilePicture";
            DICOMFilePicture.Size = new Size(284, 199);
            DICOMFilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            DICOMFilePicture.TabIndex = 1;
            DICOMFilePicture.TabStop = false;
            // 
            // btnBack3D
            // 
            btnBack3D.Anchor = AnchorStyles.Top;
            btnBack3D.BackColor = Color.Transparent;
            btnBack3D.Cursor = Cursors.Hand;
            btnBack3D.Image = (Image)resources.GetObject("btnBack3D.Image");
            btnBack3D.Location = new Point(701, 366);
            btnBack3D.Name = "btnBack3D";
            btnBack3D.Size = new Size(25, 25);
            btnBack3D.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack3D.TabIndex = 86;
            btnBack3D.TabStop = false;
            btnBack3D.Visible = false;
            btnBack3D.Click += btnBack3D_Click;
            // 
            // MainInterFaceControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnBack3D);
            Controls.Add(CTPanel);
            Controls.Add(organSlicePanel);
            Controls.Add(userGuideBtn);
            Controls.Add(donorInfoPanel);
            Controls.Add(panel1);
            Controls.Add(shadowPanel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainInterFaceControl";
            Size = new Size(794, 438);
            ((System.ComponentModel.ISupportInitialize)btnLocation).EndInit();
            shadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCT).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn3D).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRotation).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnZoomOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnZoomIn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slicePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)userGuideBtn).EndInit();
            CTPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)DICOMFilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack3D).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btnLocation;
        private ShadowPanel shadowPanel1;
        private PictureBox btnZoomOut;
        private PictureBox btnZoomIn;
        private PictureBox btnRotation;
        private PictureBox btn3D;
        private PictureBox btnCT;
        private PictureBox btnUpdate;
        private PictureBox btnDelete;
        private Panel panel1;
        public ShadowPanel donorInfoPanel;
        private PictureBox leftArrow;
        private PictureBox rightArrow;
        private PictureBox userGuideBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel organSlicePanel;
        private PictureBox slicePicture;
        private RoundedPanel CTPanel;
        private SliderControl sliderControl1;
        private PictureBox DICOMFilePicture;
        private PictureBox btnClose;
        private Label notFoundLabel;
        private RoundedButton btnConstruct;
        private PictureBox btnBack3D;
    }
}
