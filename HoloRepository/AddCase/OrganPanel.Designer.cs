﻿namespace HoloRepository.AddCase
{
    partial class OrganPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganPanel));
            sliceImages = new PictureBox();
            leftArrow = new PictureBox();
            rightArrow = new PictureBox();
            organNameLabel = new Label();
            placeholderLabel = new Label();
            contextMenu = new ContextMenuStrip(components);
            updateToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            downArrow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sliceImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).BeginInit();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)downArrow).BeginInit();
            SuspendLayout();
            // 
            // sliceImages
            // 
            sliceImages.BackColor = Color.Transparent;
            sliceImages.Location = new Point(24, 19);
            sliceImages.Margin = new Padding(5, 5, 5, 5);
            sliceImages.Name = "sliceImages";
            sliceImages.Size = new Size(437, 314);
            sliceImages.SizeMode = PictureBoxSizeMode.Zoom;
            sliceImages.TabIndex = 0;
            sliceImages.TabStop = false;
            // 
            // leftArrow
            // 
            leftArrow.BackColor = Color.Transparent;
            leftArrow.Image = (Image)resources.GetObject("leftArrow.Image");
            leftArrow.Location = new Point(24, 128);
            leftArrow.Margin = new Padding(5, 5, 5, 5);
            leftArrow.Name = "leftArrow";
            leftArrow.Size = new Size(41, 93);
            leftArrow.SizeMode = PictureBoxSizeMode.Zoom;
            leftArrow.TabIndex = 1;
            leftArrow.TabStop = false;
            leftArrow.Click += leftArrow_Click;
            leftArrow.MouseEnter += leftArrow_MouseEnter;
            leftArrow.MouseLeave += leftArrow_MouseLeave;
            // 
            // rightArrow
            // 
            rightArrow.BackColor = Color.Transparent;
            rightArrow.Image = (Image)resources.GetObject("rightArrow.Image");
            rightArrow.Location = new Point(420, 128);
            rightArrow.Margin = new Padding(5, 5, 5, 5);
            rightArrow.Name = "rightArrow";
            rightArrow.Size = new Size(41, 93);
            rightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            rightArrow.TabIndex = 2;
            rightArrow.TabStop = false;
            rightArrow.Click += rightArrow_Click;
            rightArrow.MouseEnter += rightArrow_MouseEnter;
            rightArrow.MouseLeave += rightArrow_MouseLeave;
            // 
            // organNameLabel
            // 
            organNameLabel.Anchor = AnchorStyles.None;
            organNameLabel.AutoSize = true;
            organNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            organNameLabel.ForeColor = Color.Black;
            organNameLabel.Image = (Image)resources.GetObject("organNameLabel.Image");
            organNameLabel.ImageAlign = ContentAlignment.MiddleRight;
            organNameLabel.Location = new Point(149, 338);
            organNameLabel.Name = "organNameLabel";
            organNameLabel.Size = new Size(117, 28);
            organNameLabel.TabIndex = 64;
            organNameLabel.Text = "organ name";
            organNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            organNameLabel.MouseDown += organNameLabel_MouseDown;
            // 
            // placeholderLabel
            // 
            placeholderLabel.Anchor = AnchorStyles.Top;
            placeholderLabel.AutoSize = true;
            placeholderLabel.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeholderLabel.Location = new Point(74, 160);
            placeholderLabel.Margin = new Padding(5, 0, 5, 0);
            placeholderLabel.Name = "placeholderLabel";
            placeholderLabel.Size = new Size(311, 36);
            placeholderLabel.TabIndex = 65;
            placeholderLabel.Text = "No Slice Images Available.";
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
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
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
            downArrow.Location = new Point(273, 338);
            downArrow.Margin = new Padding(5, 5, 5, 5);
            downArrow.Name = "downArrow";
            downArrow.Size = new Size(27, 30);
            downArrow.SizeMode = PictureBoxSizeMode.Zoom;
            downArrow.TabIndex = 66;
            downArrow.TabStop = false;
            downArrow.MouseDown += downArrow_MouseDown;
            // 
            // OrganPanel
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(downArrow);
            Controls.Add(placeholderLabel);
            Controls.Add(organNameLabel);
            Controls.Add(rightArrow);
            Controls.Add(leftArrow);
            Controls.Add(sliceImages);
            Margin = new Padding(24, 11, 24, 11);
            Name = "OrganPanel";
            Size = new Size(484, 384);
            ((System.ComponentModel.ISupportInitialize)sliceImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightArrow).EndInit();
            contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)downArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sliceImages;
        private PictureBox leftArrow;
        private PictureBox rightArrow;
        public Label organNameLabel;
        private Label placeholderLabel;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        public PictureBox downArrow;
    }
}
