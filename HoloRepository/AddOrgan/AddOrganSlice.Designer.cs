namespace HoloRepository
{
    partial class AddOrganSlice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DICOMFilePicture = new PictureBox();
            sliderControl1 = new SliderControl();
            OrganSlicePanel = new RoundedPanel();
            Add = new RoundedButton();
            roundedPanel1 = new RoundedPanel();
            OrganSliceDescription = new CustomLabel();
            OrganSlicePicture = new PictureBox();
            DescriptionBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)DICOMFilePicture).BeginInit();
            OrganSlicePanel.SuspendLayout();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrganSlicePicture).BeginInit();
            SuspendLayout();
            // 
            // DICOMFilePicture
            // 
            DICOMFilePicture.BorderStyle = BorderStyle.FixedSingle;
            DICOMFilePicture.Location = new Point(30, 45);
            DICOMFilePicture.Margin = new Padding(2);
            DICOMFilePicture.Name = "DICOMFilePicture";
            DICOMFilePicture.Size = new Size(422, 312);
            DICOMFilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            DICOMFilePicture.TabIndex = 1;
            DICOMFilePicture.TabStop = false;
            // 
            // sliderControl1
            // 
            sliderControl1.Location = new Point(30, 14);
            sliderControl1.Margin = new Padding(2);
            sliderControl1.Name = "sliderControl1";
            sliderControl1.NumberOfImages = 0;
            sliderControl1.Size = new Size(423, 27);
            sliderControl1.TabIndex = 2;
            sliderControl1.Text = "sliderControl1";
            sliderControl1.ImageSelected += SliderControl1_ImageSelected;
            // 
            // OrganSlicePanel
            // 
            OrganSlicePanel.Anchor = AnchorStyles.Top;
            OrganSlicePanel.BorderColor = Color.Gray;
            OrganSlicePanel.BorderRadius = 5;
            OrganSlicePanel.BorderWidth = 2;
            OrganSlicePanel.Controls.Add(sliderControl1);
            OrganSlicePanel.Controls.Add(DICOMFilePicture);
            OrganSlicePanel.Location = new Point(562, 14);
            OrganSlicePanel.Name = "OrganSlicePanel";
            OrganSlicePanel.Size = new Size(478, 378);
            OrganSlicePanel.TabIndex = 3;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top;
            Add.BackColor = Color.CornflowerBlue;
            Add.BorderRadius = 10;
            Add.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = Color.White;
            Add.Location = new Point(910, 662);
            Add.Name = "Add";
            Add.Size = new Size(130, 52);
            Add.TabIndex = 6;
            Add.Text = "&Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.Anchor = AnchorStyles.Top;
            roundedPanel1.BorderColor = Color.Gray;
            roundedPanel1.BorderRadius = 5;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(OrganSliceDescription);
            roundedPanel1.Controls.Add(OrganSlicePicture);
            roundedPanel1.Location = new Point(36, 18);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(478, 378);
            roundedPanel1.TabIndex = 7;
            // 
            // OrganSliceDescription
            // 
            OrganSliceDescription.CustomFont = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSliceDescription.CustomForeColor = Color.Gray;
            OrganSliceDescription.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrganSliceDescription.Lines = new string[] { "Click on to capture the image ", "of the organ slice" };
            OrganSliceDescription.Location = new Point(46, 222);
            OrganSliceDescription.Name = "OrganSliceDescription";
            OrganSliceDescription.Size = new Size(388, 99);
            OrganSliceDescription.TabIndex = 8;
            OrganSliceDescription.Text = "customLabel1";
            // 
            // OrganSlicePicture
            // 
            OrganSlicePicture.Location = new Point(3, 3);
            OrganSlicePicture.Name = "OrganSlicePicture";
            OrganSlicePicture.Size = new Size(472, 372);
            OrganSlicePicture.SizeMode = PictureBoxSizeMode.Zoom;
            OrganSlicePicture.TabIndex = 8;
            OrganSlicePicture.TabStop = false;
            OrganSlicePicture.Click += OrganSlicePicture_Click;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Anchor = AnchorStyles.Top;
            DescriptionBox.Location = new Point(39, 426);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            DescriptionBox.Size = new Size(1006, 206);
            DescriptionBox.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            DescriptionBox.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            DescriptionBox.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            DescriptionBox.StateCommon.Border.Rounding = 5;
            DescriptionBox.StateCommon.Border.Width = 1;
            DescriptionBox.StateCommon.Content.Color1 = Color.DimGray;
            DescriptionBox.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBox.TabIndex = 8;
            DescriptionBox.Text = "Describe additional information about the organ slice ...";
            // 
            // AddOrganSlice
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1078, 738);
            Controls.Add(DescriptionBox);
            Controls.Add(roundedPanel1);
            Controls.Add(Add);
            Controls.Add(OrganSlicePanel);
            Name = "AddOrganSlice";
            Text = "Add an organ slice";
            ((System.ComponentModel.ISupportInitialize)DICOMFilePicture).EndInit();
            OrganSlicePanel.ResumeLayout(false);
            roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrganSlicePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox DICOMFilePicture;
        private SliderControl sliderControl1;
        private RoundedButton Add;
        private RoundedPanel OrganSlicePanel;
        private RoundedPanel roundedPanel1;
        private PictureBox OrganSlicePicture;
        private CustomLabel OrganSliceDescription;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox DescriptionBox;
    }
}