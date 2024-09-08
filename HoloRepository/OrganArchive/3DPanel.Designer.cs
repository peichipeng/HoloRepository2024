namespace HoloRepository
{
    partial class _3DPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_3DPanel));
            sliceImages = new PictureBox();
            organNameLabel = new Label();
            placeholderLabel = new Label();
            contextMenu = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            downArrow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sliceImages).BeginInit();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)downArrow).BeginInit();
            SuspendLayout();
            // 
            // sliceImages
            // 
            sliceImages.BackColor = Color.Transparent;
            sliceImages.BorderStyle = BorderStyle.FixedSingle;
            sliceImages.Cursor = Cursors.Hand;
            sliceImages.Location = new Point(26, 19);
            sliceImages.Margin = new Padding(5);
            sliceImages.Name = "sliceImages";
            sliceImages.Size = new Size(169, 107);
            sliceImages.SizeMode = PictureBoxSizeMode.Zoom;
            sliceImages.TabIndex = 0;
            sliceImages.TabStop = false;
            sliceImages.Click += sliceImages_Click;
            // 
            // organNameLabel
            // 
            organNameLabel.AutoSize = true;
            organNameLabel.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            organNameLabel.ForeColor = Color.Black;
            organNameLabel.Image = (Image)resources.GetObject("organNameLabel.Image");
            organNameLabel.ImageAlign = ContentAlignment.MiddleRight;
            organNameLabel.Location = new Point(44, 135);
            organNameLabel.Name = "organNameLabel";
            organNameLabel.Size = new Size(97, 21);
            organNameLabel.TabIndex = 64;
            organNameLabel.Text = "organ name";
            organNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            organNameLabel.MouseDown += organNameLabel_MouseDown;
            // 
            // placeholderLabel
            // 
            placeholderLabel.Anchor = AnchorStyles.Top;
            placeholderLabel.AutoSize = true;
            placeholderLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            placeholderLabel.Location = new Point(81, 59);
            placeholderLabel.Margin = new Padding(5, 0, 5, 0);
            placeholderLabel.Name = "placeholderLabel";
            placeholderLabel.Size = new Size(48, 21);
            placeholderLabel.TabIndex = 65;
            placeholderLabel.Text = "None";
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(24, 24);
            contextMenu.Items.AddRange(new ToolStripItem[] { updateToolStripMenuItem, toolStripSeparator1, deleteToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.RenderMode = ToolStripRenderMode.Professional;
            contextMenu.Size = new Size(153, 74);
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.ForeColor = Color.FromArgb(51, 129, 202);
            updateToolStripMenuItem.Image = (Image)resources.GetObject("updateToolStripMenuItem.Image");
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(152, 32);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += UpdateToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(149, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(207, 73, 73);
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(152, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // downArrow
            // 
            downArrow.ContextMenuStrip = contextMenu;
            downArrow.Image = (Image)resources.GetObject("downArrow.Image");
            downArrow.Location = new Point(149, 131);
            downArrow.Margin = new Padding(5);
            downArrow.Name = "downArrow";
            downArrow.Size = new Size(27, 30);
            downArrow.SizeMode = PictureBoxSizeMode.Zoom;
            downArrow.TabIndex = 66;
            downArrow.TabStop = false;
            downArrow.MouseDown += downArrow_MouseDown;
            // 
            // _3DPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(downArrow);
            Controls.Add(placeholderLabel);
            Controls.Add(organNameLabel);
            Controls.Add(sliceImages);
            Margin = new Padding(14, 11, 14, 11);
            Name = "_3DPanel";
            Size = new Size(220, 169);
            ((System.ComponentModel.ISupportInitialize)sliceImages).EndInit();
            contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)downArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sliceImages;
        public Label organNameLabel;
        private Label placeholderLabel;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        public PictureBox downArrow;
    }
}
