using HoloRepository.ViewCases;

namespace HoloRepository
{
    partial class ViewCasesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCasesControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            addCaseBtn = new RoundedButton();
            contextMenu = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            caseDataBindingSource = new BindingSource(components);
            tablePanel = new Panel();
            caseTable = new DataGridView();
            donorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dODDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            paginationPanel = new FlowLayoutPanel();
            panel = new Panel();
            greyRightArrow = new PictureBox();
            blackRightArrow = new PictureBox();
            greyLeftArrow = new PictureBox();
            blackLeftArrow = new PictureBox();
            searchIcon = new PictureBox();
            pageNameLabel = new Label();
            searchBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)caseDataBindingSource).BeginInit();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)caseTable).BeginInit();
            panel2.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)greyRightArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blackRightArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greyLeftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blackLeftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            SuspendLayout();
            // 
            // addCaseBtn
            // 
            addCaseBtn.Anchor = AnchorStyles.Top;
            addCaseBtn.BackColor = Color.FromArgb(51, 129, 202);
            addCaseBtn.BorderRadius = 15;
            addCaseBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addCaseBtn.ForeColor = Color.White;
            addCaseBtn.Location = new Point(1018, 118);
            addCaseBtn.Margin = new Padding(3, 3, 22, 3);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(196, 51);
            addCaseBtn.TabIndex = 74;
            addCaseBtn.Text = "+ &Add a Case";
            addCaseBtn.UseVisualStyleBackColor = false;
            addCaseBtn.Click += addCaseBtn_Click;
            // 
            // contextMenu
            // 
            contextMenu.ImageScalingSize = new Size(24, 24);
            contextMenu.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, toolStripSeparator1, deleteToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.RenderMode = ToolStripRenderMode.Professional;
            contextMenu.Size = new Size(145, 74);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.ForeColor = Color.Black;
            viewToolStripMenuItem.Image = (Image)resources.GetObject("viewToolStripMenuItem.Image");
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(144, 32);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(141, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(207, 73, 73);
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(144, 32);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // caseDataBindingSource
            // 
            caseDataBindingSource.DataSource = typeof(CaseData);
            // 
            // tablePanel
            // 
            tablePanel.Anchor = AnchorStyles.Top;
            tablePanel.Controls.Add(caseTable);
            tablePanel.Controls.Add(panel2);
            tablePanel.Location = new Point(149, 192);
            tablePanel.Margin = new Padding(5, 5, 5, 5);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(1065, 638);
            tablePanel.TabIndex = 77;
            // 
            // caseTable
            // 
            caseTable.AllowUserToAddRows = false;
            caseTable.AllowUserToDeleteRows = false;
            caseTable.AllowUserToResizeColumns = false;
            caseTable.AllowUserToResizeRows = false;
            caseTable.AutoGenerateColumns = false;
            caseTable.BackgroundColor = Color.White;
            caseTable.BorderStyle = BorderStyle.None;
            caseTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            caseTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            caseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            caseTable.ColumnHeadersHeight = 32;
            caseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            caseTable.Columns.AddRange(new DataGridViewColumn[] { donorIdDataGridViewTextBoxColumn, dODDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            caseTable.ContextMenuStrip = contextMenu;
            caseTable.DataSource = caseDataBindingSource;
            caseTable.EnableHeadersVisualStyles = false;
            caseTable.GridColor = Color.Silver;
            caseTable.Location = new Point(0, 0);
            caseTable.Margin = new Padding(5, 5, 5, 5);
            caseTable.MultiSelect = false;
            caseTable.Name = "caseTable";
            caseTable.ReadOnly = true;
            caseTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            caseTable.RowHeadersVisible = false;
            caseTable.RowHeadersWidth = 62;
            caseTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            caseTable.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            caseTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            caseTable.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
            caseTable.RowTemplate.Height = 30;
            caseTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            caseTable.Size = new Size(1065, 538);
            caseTable.TabIndex = 78;
            caseTable.CellDoubleClick += caseTable_CellDoubleClick;
            caseTable.CellFormatting += caseTable_CellFormatting;
            caseTable.CellMouseClick += caseTable_CellMouseClick;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            donorIdDataGridViewTextBoxColumn.HeaderText = "DONOR ID";
            donorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            donorIdDataGridViewTextBoxColumn.ReadOnly = true;
            donorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // dODDataGridViewTextBoxColumn
            // 
            dODDataGridViewTextBoxColumn.DataPropertyName = "DOD";
            dODDataGridViewTextBoxColumn.HeaderText = "DATE OF DEATH";
            dODDataGridViewTextBoxColumn.MinimumWidth = 8;
            dODDataGridViewTextBoxColumn.Name = "dODDataGridViewTextBoxColumn";
            dODDataGridViewTextBoxColumn.ReadOnly = true;
            dODDataGridViewTextBoxColumn.Width = 120;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "AGE";
            ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            ageDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "CauseOfDeath";
            dataGridViewTextBoxColumn1.FillWeight = 150F;
            dataGridViewTextBoxColumn1.HeaderText = "CAUSE OF DEATH";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "Organs";
            dataGridViewTextBoxColumn2.FillWeight = 120F;
            dataGridViewTextBoxColumn2.HeaderText = "ORGANS";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(paginationPanel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 537);
            panel2.Margin = new Padding(5, 5, 5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1065, 101);
            panel2.TabIndex = 77;
            // 
            // paginationPanel
            // 
            paginationPanel.Anchor = AnchorStyles.Top;
            paginationPanel.AutoSize = true;
            paginationPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            paginationPanel.BackColor = Color.Transparent;
            paginationPanel.Location = new Point(215, 10);
            paginationPanel.Margin = new Padding(5, 5, 5, 5);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(0, 0);
            paginationPanel.TabIndex = 78;
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.Controls.Add(greyRightArrow);
            panel.Controls.Add(blackRightArrow);
            panel.Controls.Add(greyLeftArrow);
            panel.Controls.Add(blackLeftArrow);
            panel.Controls.Add(searchIcon);
            panel.Controls.Add(pageNameLabel);
            panel.Controls.Add(searchBox);
            panel.Controls.Add(tablePanel);
            panel.Controls.Add(addCaseBtn);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(5, 5, 5, 5);
            panel.Name = "panel";
            panel.Size = new Size(1329, 664);
            panel.TabIndex = 78;
            // 
            // greyRightArrow
            // 
            greyRightArrow.Image = (Image)resources.GetObject("greyRightArrow.Image");
            greyRightArrow.Location = new Point(66, 363);
            greyRightArrow.Margin = new Padding(0, 14, 5, 5);
            greyRightArrow.Name = "greyRightArrow";
            greyRightArrow.Size = new Size(25, 26);
            greyRightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            greyRightArrow.TabIndex = 86;
            greyRightArrow.TabStop = false;
            greyRightArrow.Visible = false;
            // 
            // blackRightArrow
            // 
            blackRightArrow.Image = (Image)resources.GetObject("blackRightArrow.Image");
            blackRightArrow.Location = new Point(86, 440);
            blackRightArrow.Margin = new Padding(0, 16, 5, 5);
            blackRightArrow.Name = "blackRightArrow";
            blackRightArrow.Size = new Size(25, 26);
            blackRightArrow.SizeMode = PictureBoxSizeMode.Zoom;
            blackRightArrow.TabIndex = 85;
            blackRightArrow.TabStop = false;
            blackRightArrow.Visible = false;
            blackRightArrow.Click += blackRightArrow_Click;
            // 
            // greyLeftArrow
            // 
            greyLeftArrow.Image = (Image)resources.GetObject("greyLeftArrow.Image");
            greyLeftArrow.Location = new Point(36, 478);
            greyLeftArrow.Margin = new Padding(5, 16, 0, 5);
            greyLeftArrow.Name = "greyLeftArrow";
            greyLeftArrow.Size = new Size(25, 26);
            greyLeftArrow.SizeMode = PictureBoxSizeMode.Zoom;
            greyLeftArrow.TabIndex = 82;
            greyLeftArrow.TabStop = false;
            greyLeftArrow.Visible = false;
            // 
            // blackLeftArrow
            // 
            blackLeftArrow.Image = (Image)resources.GetObject("blackLeftArrow.Image");
            blackLeftArrow.Location = new Point(36, 538);
            blackLeftArrow.Margin = new Padding(5, 16, 0, 5);
            blackLeftArrow.Name = "blackLeftArrow";
            blackLeftArrow.Size = new Size(25, 26);
            blackLeftArrow.SizeMode = PictureBoxSizeMode.Zoom;
            blackLeftArrow.TabIndex = 81;
            blackLeftArrow.TabStop = false;
            blackLeftArrow.Visible = false;
            blackLeftArrow.Click += blackLeftArrow_Click;
            // 
            // searchIcon
            // 
            searchIcon.Anchor = AnchorStyles.Top;
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(149, 118);
            searchIcon.Margin = new Padding(5, 5, 5, 5);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(25, 26);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 80;
            searchIcon.TabStop = false;
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Microsoft YaHei UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(523, 40);
            pageNameLabel.Margin = new Padding(22, 0, 3, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(270, 58);
            pageNameLabel.TabIndex = 79;
            pageNameLabel.Text = "View Cases";
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top;
            searchBox.Location = new Point(149, 118);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(836, 35);
            searchBox.StateCommon.Border.Color1 = Color.LightGray;
            searchBox.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            searchBox.StateCommon.Border.Rounding = 3;
            searchBox.StateCommon.Border.Width = 1;
            searchBox.StateCommon.Content.Color1 = Color.DarkGray;
            searchBox.StateCommon.Content.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.StateCommon.Content.Padding = new Padding(30, 5, -1, -1);
            searchBox.TabIndex = 78;
            searchBox.Text = "Search Cases";
            searchBox.TextChanged += searchBox_TextChanged;
            searchBox.Enter += searchBox_Enter;
            searchBox.Leave += searchBox_Leave;
            // 
            // ViewCasesControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Margin = new Padding(5, 5, 5, 5);
            Name = "ViewCasesControl";
            Size = new Size(1329, 664);
            Load += ViewCasesControl_Load;
            contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)caseDataBindingSource).EndInit();
            tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)caseTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)greyRightArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)blackRightArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)greyLeftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)blackLeftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RoundedButton addCaseBtn;
        private Panel tablePanel;
        private Panel panel;
        private DataGridViewTextBoxColumn causeOfDeathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn organsDataGridViewTextBoxColumn;
        private BindingSource caseDataBindingSource;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private FlowLayoutPanel paginationPanel;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox searchBox;
        public Label pageNameLabel;
        private DataGridView caseTable;
        private PictureBox searchIcon;
        private DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dODDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private PictureBox blackLeftArrow;
        private PictureBox greyLeftArrow;
        private PictureBox blackRightArrow;
        private PictureBox greyRightArrow;
        private Panel panel2;
    }
}
