namespace Encrypt.Ui
{
    partial class HashChanger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashChanger));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCopyRow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuExportToCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWindowsLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeWindowsLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAction = new System.Windows.Forms.Panel();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartMD5 = new System.Windows.Forms.Button();
            this.labelTotalItem = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.labelItem = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.dgvMD5 = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMD5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.contextMenuCopyRow,
            this.contextMenuExportToCSV,
            this.contextMenuOpenFile});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.menuToolStripMenuItem.Text = "File";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Image = global::Encrypt.Properties.Resources.icons8_home_office;
            this.newSessionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newSessionToolStripMenuItem.Text = "Menu";
            // 
            // contextMenuCopyRow
            // 
            this.contextMenuCopyRow.Name = "contextMenuCopyRow";
            this.contextMenuCopyRow.Size = new System.Drawing.Size(216, 26);
            this.contextMenuCopyRow.Text = "Copy Selected Row ";
            this.contextMenuCopyRow.Click += new System.EventHandler(this.contextMenuCopyRow_Click);
            // 
            // contextMenuExportToCSV
            // 
            this.contextMenuExportToCSV.Name = "contextMenuExportToCSV";
            this.contextMenuExportToCSV.Size = new System.Drawing.Size(216, 26);
            this.contextMenuExportToCSV.Text = "Export All to .CSV";
            this.contextMenuExportToCSV.Click += new System.EventHandler(this.contextMenuExportToCSV_Click);
            // 
            // contextMenuOpenFile
            // 
            this.contextMenuOpenFile.Name = "contextMenuOpenFile";
            this.contextMenuOpenFile.Size = new System.Drawing.Size(216, 26);
            this.contextMenuOpenFile.Text = "Open File";
            this.contextMenuOpenFile.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolboxToolStripMenuItem,
            this.fullscreenToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.viewToolStripMenuItem.Text = "View ";
            // 
            // toolboxToolStripMenuItem
            // 
            this.toolboxToolStripMenuItem.Name = "toolboxToolStripMenuItem";
            this.toolboxToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.toolboxToolStripMenuItem.Text = "Toolbox";
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.propertiesToolStripMenuItem.Text = "Properties ";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetWindowsLayoutToolStripMenuItem,
            this.changeWindowsLayoutToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // resetWindowsLayoutToolStripMenuItem
            // 
            this.resetWindowsLayoutToolStripMenuItem.Name = "resetWindowsLayoutToolStripMenuItem";
            this.resetWindowsLayoutToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.resetWindowsLayoutToolStripMenuItem.Text = "Reset Windows Layout ";
            // 
            // changeWindowsLayoutToolStripMenuItem
            // 
            this.changeWindowsLayoutToolStripMenuItem.Name = "changeWindowsLayoutToolStripMenuItem";
            this.changeWindowsLayoutToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.changeWindowsLayoutToolStripMenuItem.Text = "Change Windows Layout ";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.productInfoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.aboutToolStripMenuItem.Text = "About ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.helpToolStripMenuItem.Text = "Help ";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // productInfoToolStripMenuItem
            // 
            this.productInfoToolStripMenuItem.Name = "productInfoToolStripMenuItem";
            this.productInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.productInfoToolStripMenuItem.Text = "Product Info";
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(224)))), ((int)(((byte)(254)))));
            this.panelAction.Controls.Add(this.btnRemoveSelected);
            this.panelAction.Controls.Add(this.label2);
            this.panelAction.Controls.Add(this.btnAddFiles);
            this.panelAction.Controls.Add(this.label1);
            this.panelAction.Controls.Add(this.btnStartMD5);
            this.panelAction.Controls.Add(this.labelTotalItem);
            this.panelAction.Controls.Add(this.btnRemoveAll);
            this.panelAction.Controls.Add(this.labelItem);
            this.panelAction.Controls.Add(this.progressBarStatus);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 423);
            this.panelAction.Margin = new System.Windows.Forms.Padding(4);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(1255, 115);
            this.panelAction.TabIndex = 13;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(325, 16);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(204, 43);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove Selected Files";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1005, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "total:";
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFiles.Location = new System.Drawing.Point(10, 16);
            this.btnAddFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(135, 43);
            this.btnAddFiles.TabIndex = 1;
            this.btnAddFiles.Text = "Add Files";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1005, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "item:";
            // 
            // btnStartMD5
            // 
            this.btnStartMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMD5.Location = new System.Drawing.Point(153, 16);
            this.btnStartMD5.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartMD5.Name = "btnStartMD5";
            this.btnStartMD5.Size = new System.Drawing.Size(164, 43);
            this.btnStartMD5.TabIndex = 2;
            this.btnStartMD5.Text = "Start Change MD5";
            this.btnStartMD5.UseVisualStyleBackColor = true;
            this.btnStartMD5.Click += new System.EventHandler(this.btnStartMD5_Click);
            // 
            // labelTotalItem
            // 
            this.labelTotalItem.AutoSize = true;
            this.labelTotalItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItem.Location = new System.Drawing.Point(1043, 39);
            this.labelTotalItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalItem.Name = "labelTotalItem";
            this.labelTotalItem.Size = new System.Drawing.Size(19, 20);
            this.labelTotalItem.TabIndex = 8;
            this.labelTotalItem.Text = "0";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAll.Location = new System.Drawing.Point(537, 16);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(164, 43);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "Remove All Files";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.Location = new System.Drawing.Point(1041, 16);
            this.labelItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(19, 20);
            this.labelItem.TabIndex = 6;
            this.labelItem.Text = "0";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(709, 16);
            this.progressBarStatus.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(288, 43);
            this.progressBarStatus.TabIndex = 5;
            // 
            // dgvMD5
            // 
            this.dgvMD5.AllowUserToAddRows = false;
            this.dgvMD5.AllowUserToDeleteRows = false;
            this.dgvMD5.AllowUserToResizeRows = false;
            this.dgvMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMD5.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMD5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMD5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMD5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.oldMD5,
            this.newMD5,
            this.status});
            this.dgvMD5.Location = new System.Drawing.Point(10, 32);
            this.dgvMD5.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMD5.Name = "dgvMD5";
            this.dgvMD5.RowHeadersVisible = false;
            this.dgvMD5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMD5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMD5.Size = new System.Drawing.Size(1232, 383);
            this.dgvMD5.TabIndex = 12;
            this.dgvMD5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMD5_MouseClick);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.FillWeight = 148.4587F;
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 270;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // oldMD5
            // 
            this.oldMD5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oldMD5.DefaultCellStyle = dataGridViewCellStyle2;
            this.oldMD5.FillWeight = 103.6357F;
            this.oldMD5.HeaderText = "Old MD5";
            this.oldMD5.MinimumWidth = 220;
            this.oldMD5.Name = "oldMD5";
            this.oldMD5.ReadOnly = true;
            this.oldMD5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.oldMD5.Width = 220;
            // 
            // newMD5
            // 
            this.newMD5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.newMD5.DefaultCellStyle = dataGridViewCellStyle3;
            this.newMD5.FillWeight = 110.9225F;
            this.newMD5.HeaderText = "New MD5";
            this.newMD5.MinimumWidth = 220;
            this.newMD5.Name = "newMD5";
            this.newMD5.ReadOnly = true;
            this.newMD5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newMD5.Width = 220;
            // 
            // status
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle4;
            this.status.FillWeight = 36.9831F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.Width = 75;
            // 
            // HashChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1255, 538);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.dgvMD5);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HashChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashChanger";
            this.Load += new System.EventHandler(this.HashChanger_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMD5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWindowsLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeWindowsLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartMD5;
        private System.Windows.Forms.Label labelTotalItem;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.DataGridView dgvMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn newMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCopyRow;
        private System.Windows.Forms.ToolStripMenuItem contextMenuExportToCSV;
        private System.Windows.Forms.ToolStripMenuItem contextMenuOpenFile;
    }
}