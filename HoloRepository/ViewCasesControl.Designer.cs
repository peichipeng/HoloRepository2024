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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCasesControl));
            pageNameLabel = new Label();
            addCaseBtn = new RoundedButton();
            button1 = new Button();
            caseTable = new DataGridView();
            donorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dODDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            causeOfDeathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            organsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenu = new ContextMenuStrip(components);
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            caseDataBindingSource = new BindingSource(components);
            tablePanel = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)caseTable).BeginInit();
            contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)caseDataBindingSource).BeginInit();
            tablePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pageNameLabel
            // 
            pageNameLabel.Anchor = AnchorStyles.Top;
            pageNameLabel.AutoSize = true;
            pageNameLabel.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point);
            pageNameLabel.Location = new Point(293, 20);
            pageNameLabel.Margin = new Padding(14, 0, 2, 0);
            pageNameLabel.Name = "pageNameLabel";
            pageNameLabel.Size = new Size(196, 39);
            pageNameLabel.TabIndex = 54;
            pageNameLabel.Text = "View Cases";
            // 
            // addCaseBtn
            // 
            addCaseBtn.Anchor = AnchorStyles.Top;
            addCaseBtn.BackColor = Color.FromArgb(51, 129, 202);
            addCaseBtn.BorderRadius = 15;
            addCaseBtn.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point);
            addCaseBtn.ForeColor = Color.White;
            addCaseBtn.Location = new Point(589, 63);
            addCaseBtn.Margin = new Padding(2, 2, 14, 2);
            addCaseBtn.Name = "addCaseBtn";
            addCaseBtn.Size = new Size(143, 25);
            addCaseBtn.TabIndex = 74;
            addCaseBtn.Text = "+ Add a Case";
            addCaseBtn.UseVisualStyleBackColor = false;
            addCaseBtn.Click += addCaseBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(120, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 75;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            caseTable.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            caseTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            caseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            caseTable.ColumnHeadersHeight = 30;
            caseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            caseTable.Columns.AddRange(new DataGridViewColumn[] { donorIdDataGridViewTextBoxColumn, dODDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, causeOfDeathDataGridViewTextBoxColumn, organsDataGridViewTextBoxColumn });
            caseTable.ContextMenuStrip = contextMenu;
            caseTable.DataSource = caseDataBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            caseTable.DefaultCellStyle = dataGridViewCellStyle2;
            caseTable.Dock = DockStyle.Fill;
            caseTable.EnableHeadersVisualStyles = false;
            caseTable.GridColor = Color.Silver;
            caseTable.Location = new Point(0, 0);
            caseTable.MultiSelect = false;
            caseTable.Name = "caseTable";
            caseTable.ReadOnly = true;
            caseTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            caseTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            caseTable.RowHeadersVisible = false;
            caseTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            caseTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            caseTable.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            caseTable.RowTemplate.Height = 27;
            caseTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            caseTable.Size = new Size(678, 399);
            caseTable.TabIndex = 76;
            caseTable.CellDoubleClick += caseTable_CellDoubleClick;
            caseTable.CellFormatting += caseTable_CellFormatting;
            caseTable.CellMouseClick += caseTable_CellMouseClick;
            // 
            // donorIdDataGridViewTextBoxColumn
            // 
            donorIdDataGridViewTextBoxColumn.DataPropertyName = "DonorId";
            donorIdDataGridViewTextBoxColumn.HeaderText = "DONOR ID";
            donorIdDataGridViewTextBoxColumn.Name = "donorIdDataGridViewTextBoxColumn";
            donorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dODDataGridViewTextBoxColumn
            // 
            dODDataGridViewTextBoxColumn.DataPropertyName = "DOD";
            dODDataGridViewTextBoxColumn.HeaderText = "DATE OF DEATH";
            dODDataGridViewTextBoxColumn.Name = "dODDataGridViewTextBoxColumn";
            dODDataGridViewTextBoxColumn.ReadOnly = true;
            dODDataGridViewTextBoxColumn.Width = 120;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "AGE";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            ageDataGridViewTextBoxColumn.Width = 70;
            // 
            // causeOfDeathDataGridViewTextBoxColumn
            // 
            causeOfDeathDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            causeOfDeathDataGridViewTextBoxColumn.DataPropertyName = "causeOfDeath";
            causeOfDeathDataGridViewTextBoxColumn.FillWeight = 180F;
            causeOfDeathDataGridViewTextBoxColumn.HeaderText = "CAUSE OF DEATH";
            causeOfDeathDataGridViewTextBoxColumn.MinimumWidth = 180;
            causeOfDeathDataGridViewTextBoxColumn.Name = "causeOfDeathDataGridViewTextBoxColumn";
            causeOfDeathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // organsDataGridViewTextBoxColumn
            // 
            organsDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            organsDataGridViewTextBoxColumn.DataPropertyName = "organs";
            organsDataGridViewTextBoxColumn.FillWeight = 150F;
            organsDataGridViewTextBoxColumn.HeaderText = "ORGANS";
            organsDataGridViewTextBoxColumn.MinimumWidth = 150;
            organsDataGridViewTextBoxColumn.Name = "organsDataGridViewTextBoxColumn";
            organsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem, toolStripSeparator1, deleteToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.RenderMode = ToolStripRenderMode.Professional;
            contextMenu.Size = new Size(108, 54);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.ForeColor = Color.Black;
            viewToolStripMenuItem.Image = (Image)resources.GetObject("viewToolStripMenuItem.Image");
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(107, 22);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(104, 6);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(207, 73, 73);
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
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
            tablePanel.Controls.Add(panel2);
            tablePanel.Controls.Add(caseTable);
            tablePanel.Location = new Point(72, 120);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(678, 399);
            tablePanel.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(678, 81);
            panel2.TabIndex = 77;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tablePanel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(addCaseBtn);
            panel1.Controls.Add(pageNameLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 415);
            panel1.TabIndex = 78;
            // 
            // ViewCasesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ViewCasesControl";
            Size = new Size(800, 415);
            Load += ViewCasesControl_Load;
            ((System.ComponentModel.ISupportInitialize)caseTable).EndInit();
            contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)caseDataBindingSource).EndInit();
            tablePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label pageNameLabel;
        private RoundedButton addCaseBtn;
        private Button button1;
        private DataGridView caseTable;
        private Panel tablePanel;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn donorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dODDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn causeOfDeathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn organsDataGridViewTextBoxColumn;
        private BindingSource caseDataBindingSource;
        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
