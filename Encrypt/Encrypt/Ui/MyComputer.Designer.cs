namespace Encrypt.Ui
{
    partial class MyComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyComputer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unicodeRadioButton = new System.Windows.Forms.RadioButton();
            this.asciiRadioButton = new System.Windows.Forms.RadioButton();
            this.containingTextBox = new System.Windows.Forms.TextBox();
            this.containingCheckBox = new System.Windows.Forms.CheckBox();
            this.olderThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.newerThanCheckBox = new System.Windows.Forms.CheckBox();
            this.olderThanCheckBox = new System.Windows.Forms.CheckBox();
            this.newerThanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.includeSubDirsCheckBox = new System.Windows.Forms.CheckBox();
            this.selectSearchDirButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchDirTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.resultsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delimeterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.writeResultsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1255, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.menuToolStripMenuItem.Text = "File ";
            // 
            // menToolStripMenuItem
            // 
            this.menToolStripMenuItem.Image = global::Encrypt.Properties.Resources.icons8_home_office;
            this.menToolStripMenuItem.Name = "menToolStripMenuItem";
            this.menToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.menToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Encrypt.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.viewToolStripMenuItem.Text = "View ";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.settingToolStripMenuItem.Text = "Setting";
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.helpToolStripMenuItem.Text = "Help ";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // productInfoToolStripMenuItem
            // 
            this.productInfoToolStripMenuItem.Name = "productInfoToolStripMenuItem";
            this.productInfoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.productInfoToolStripMenuItem.Text = "Product Info";
            this.productInfoToolStripMenuItem.Click += new System.EventHandler(this.productInfoToolStripMenuItem_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(771, 498);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 28);
            this.stopButton.TabIndex = 16;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(663, 498);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.unicodeRadioButton);
            this.groupBox1.Controls.Add(this.asciiRadioButton);
            this.groupBox1.Controls.Add(this.containingTextBox);
            this.groupBox1.Controls.Add(this.containingCheckBox);
            this.groupBox1.Controls.Add(this.olderThanDateTimePicker);
            this.groupBox1.Controls.Add(this.newerThanCheckBox);
            this.groupBox1.Controls.Add(this.olderThanCheckBox);
            this.groupBox1.Controls.Add(this.newerThanDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(20, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(650, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restrictions";
            // 
            // unicodeRadioButton
            // 
            this.unicodeRadioButton.AutoSize = true;
            this.unicodeRadioButton.Enabled = false;
            this.unicodeRadioButton.Location = new System.Drawing.Point(425, 119);
            this.unicodeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.unicodeRadioButton.Name = "unicodeRadioButton";
            this.unicodeRadioButton.Size = new System.Drawing.Size(81, 21);
            this.unicodeRadioButton.TabIndex = 7;
            this.unicodeRadioButton.TabStop = true;
            this.unicodeRadioButton.Text = "Unicode";
            this.unicodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // asciiRadioButton
            // 
            this.asciiRadioButton.AutoSize = true;
            this.asciiRadioButton.Enabled = false;
            this.asciiRadioButton.Location = new System.Drawing.Point(348, 119);
            this.asciiRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.asciiRadioButton.Name = "asciiRadioButton";
            this.asciiRadioButton.Size = new System.Drawing.Size(62, 21);
            this.asciiRadioButton.TabIndex = 6;
            this.asciiRadioButton.TabStop = true;
            this.asciiRadioButton.Text = "ASCII";
            this.asciiRadioButton.UseVisualStyleBackColor = true;
            // 
            // containingTextBox
            // 
            this.containingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containingTextBox.Enabled = false;
            this.containingTextBox.Location = new System.Drawing.Point(348, 87);
            this.containingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.containingTextBox.Name = "containingTextBox";
            this.containingTextBox.Size = new System.Drawing.Size(293, 22);
            this.containingTextBox.TabIndex = 5;
            // 
            // containingCheckBox
            // 
            this.containingCheckBox.AutoSize = true;
            this.containingCheckBox.Location = new System.Drawing.Point(8, 90);
            this.containingCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.containingCheckBox.Name = "containingCheckBox";
            this.containingCheckBox.Size = new System.Drawing.Size(298, 21);
            this.containingCheckBox.TabIndex = 4;
            this.containingCheckBox.Text = "Files containing the string (case sensitive):";
            this.containingCheckBox.UseVisualStyleBackColor = true;
            // 
            // olderThanDateTimePicker
            // 
            this.olderThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.olderThanDateTimePicker.Enabled = false;
            this.olderThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.olderThanDateTimePicker.Location = new System.Drawing.Point(348, 55);
            this.olderThanDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.olderThanDateTimePicker.Name = "olderThanDateTimePicker";
            this.olderThanDateTimePicker.Size = new System.Drawing.Size(163, 22);
            this.olderThanDateTimePicker.TabIndex = 3;
            // 
            // newerThanCheckBox
            // 
            this.newerThanCheckBox.AutoSize = true;
            this.newerThanCheckBox.Location = new System.Drawing.Point(8, 27);
            this.newerThanCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.newerThanCheckBox.Name = "newerThanCheckBox";
            this.newerThanCheckBox.Size = new System.Drawing.Size(137, 21);
            this.newerThanCheckBox.TabIndex = 0;
            this.newerThanCheckBox.Text = "Files newer than:";
            this.newerThanCheckBox.UseVisualStyleBackColor = true;
            // 
            // olderThanCheckBox
            // 
            this.olderThanCheckBox.AutoSize = true;
            this.olderThanCheckBox.Location = new System.Drawing.Point(8, 59);
            this.olderThanCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.olderThanCheckBox.Name = "olderThanCheckBox";
            this.olderThanCheckBox.Size = new System.Drawing.Size(131, 21);
            this.olderThanCheckBox.TabIndex = 2;
            this.olderThanCheckBox.Text = "Files older than:";
            this.olderThanCheckBox.UseVisualStyleBackColor = true;
            // 
            // newerThanDateTimePicker
            // 
            this.newerThanDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.newerThanDateTimePicker.Enabled = false;
            this.newerThanDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newerThanDateTimePicker.Location = new System.Drawing.Point(348, 23);
            this.newerThanDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.newerThanDateTimePicker.Name = "newerThanDateTimePicker";
            this.newerThanDateTimePicker.Size = new System.Drawing.Size(163, 22);
            this.newerThanDateTimePicker.TabIndex = 1;
            // 
            // includeSubDirsCheckBox
            // 
            this.includeSubDirsCheckBox.AutoSize = true;
            this.includeSubDirsCheckBox.Location = new System.Drawing.Point(158, 91);
            this.includeSubDirsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.includeSubDirsCheckBox.Name = "includeSubDirsCheckBox";
            this.includeSubDirsCheckBox.Size = new System.Drawing.Size(168, 21);
            this.includeSubDirsCheckBox.TabIndex = 12;
            this.includeSubDirsCheckBox.Text = "Include subdirectories";
            this.includeSubDirsCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectSearchDirButton
            // 
            this.selectSearchDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectSearchDirButton.Location = new System.Drawing.Point(638, 59);
            this.selectSearchDirButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectSearchDirButton.Name = "selectSearchDirButton";
            this.selectSearchDirButton.Size = new System.Drawing.Size(32, 26);
            this.selectSearchDirButton.TabIndex = 11;
            this.selectSearchDirButton.Text = "...";
            this.selectSearchDirButton.UseVisualStyleBackColor = true;
            this.selectSearchDirButton.Click += new System.EventHandler(this.selectSearchDirButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search directory:";
            // 
            // searchDirTextBox
            // 
            this.searchDirTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchDirTextBox.Location = new System.Drawing.Point(158, 59);
            this.searchDirTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchDirTextBox.Name = "searchDirTextBox";
            this.searchDirTextBox.Size = new System.Drawing.Size(471, 22);
            this.searchDirTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filename (may include wildcards, not case sensitive):";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.Location = new System.Drawing.Point(1026, 60);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(192, 22);
            this.fileNameTextBox.TabIndex = 14;
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.resultsList.FullRowSelect = true;
            this.resultsList.HideSelection = false;
            this.resultsList.Location = new System.Drawing.Point(20, 275);
            this.resultsList.Margin = new System.Windows.Forms.Padding(4);
            this.resultsList.MultiSelect = false;
            this.resultsList.Name = "resultsList";
            this.resultsList.ShowItemToolTips = true;
            this.resultsList.Size = new System.Drawing.Size(635, 251);
            this.resultsList.TabIndex = 18;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last modified";
            this.columnHeader3.Width = 120;
            // 
            // delimeterTextBox
            // 
            this.delimeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delimeterTextBox.Location = new System.Drawing.Point(1030, 457);
            this.delimeterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.delimeterTextBox.MaxLength = 4;
            this.delimeterTextBox.Name = "delimeterTextBox";
            this.delimeterTextBox.Size = new System.Drawing.Size(49, 22);
            this.delimeterTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Delimeter for text file (may include escapes \\r,\\n,\\t):";
            // 
            // writeResultsButton
            // 
            this.writeResultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.writeResultsButton.Location = new System.Drawing.Point(879, 498);
            this.writeResultsButton.Margin = new System.Windows.Forms.Padding(4);
            this.writeResultsButton.Name = "writeResultsButton";
            this.writeResultsButton.Size = new System.Drawing.Size(200, 28);
            this.writeResultsButton.TabIndex = 21;
            this.writeResultsButton.Text = "Write results to text file...";
            this.writeResultsButton.UseVisualStyleBackColor = true;
            // 
            // MyComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1255, 538);
            this.Controls.Add(this.delimeterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.writeResultsButton);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.includeSubDirsCheckBox);
            this.Controls.Add(this.selectSearchDirButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchDirTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analyse Computer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton unicodeRadioButton;
        private System.Windows.Forms.RadioButton asciiRadioButton;
        private System.Windows.Forms.TextBox containingTextBox;
        private System.Windows.Forms.CheckBox containingCheckBox;
        private System.Windows.Forms.DateTimePicker olderThanDateTimePicker;
        private System.Windows.Forms.CheckBox newerThanCheckBox;
        private System.Windows.Forms.CheckBox olderThanCheckBox;
        private System.Windows.Forms.DateTimePicker newerThanDateTimePicker;
        private System.Windows.Forms.CheckBox includeSubDirsCheckBox;
        private System.Windows.Forms.Button selectSearchDirButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchDirTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox delimeterTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button writeResultsButton;
    }
}