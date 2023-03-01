namespace Encrypt
{
    partial class Encrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encrypt));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputFile = new System.Windows.Forms.Label();
            this.textBox_EncrptFolder = new System.Windows.Forms.TextBox();
            this.button_EncryptFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptionIVTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.menuToolStripMenuItem.Text = "File ";
            // 
            // menToolStripMenuItem
            // 
            this.menToolStripMenuItem.Image = global::Encrypt.Properties.Resources.icons8_home_office;
            this.menToolStripMenuItem.Name = "menToolStripMenuItem";
            this.menToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.menToolStripMenuItem.Text = "Menu";
            this.menToolStripMenuItem.Click += new System.EventHandler(this.menToolStripMenuItem_Click);
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
            // InputFile
            // 
            this.InputFile.AutoSize = true;
            this.InputFile.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.InputFile.Location = new System.Drawing.Point(12, 76);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(336, 16);
            this.InputFile.TabIndex = 4;
            this.InputFile.Text = "Browse a local file and encrypt the File:";
            // 
            // textBox_EncrptFolder
            // 
            this.textBox_EncrptFolder.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.textBox_EncrptFolder.Location = new System.Drawing.Point(343, 73);
            this.textBox_EncrptFolder.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_EncrptFolder.Name = "textBox_EncrptFolder";
            this.textBox_EncrptFolder.Size = new System.Drawing.Size(425, 22);
            this.textBox_EncrptFolder.TabIndex = 5;
            this.textBox_EncrptFolder.Text = "c:\\EncryptFolder";
            this.textBox_EncrptFolder.TextChanged += new System.EventHandler(this.textBox_EncrptFolder_TextChanged);
            // 
            // button_EncryptFolder
            // 
            this.button_EncryptFolder.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.button_EncryptFolder.Location = new System.Drawing.Point(775, 76);
            this.button_EncryptFolder.Name = "button_EncryptFolder";
            this.button_EncryptFolder.Size = new System.Drawing.Size(75, 23);
            this.button_EncryptFolder.TabIndex = 6;
            this.button_EncryptFolder.Text = "Search";
            this.button_EncryptFolder.UseVisualStyleBackColor = true;
            this.button_EncryptFolder.Click += new System.EventHandler(this.button_EncryptFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add your Encryption Key:";
            // 
            // encryptionKeyTextBox
            // 
            this.encryptionKeyTextBox.Location = new System.Drawing.Point(218, 135);
            this.encryptionKeyTextBox.Name = "encryptionKeyTextBox";
            this.encryptionKeyTextBox.Size = new System.Drawing.Size(425, 22);
            this.encryptionKeyTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add your Encryption IV:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // encryptionIVTextBox
            // 
            this.encryptionIVTextBox.Location = new System.Drawing.Point(210, 179);
            this.encryptionIVTextBox.Name = "encryptionIVTextBox";
            this.encryptionIVTextBox.Size = new System.Drawing.Size(425, 22);
            this.encryptionIVTextBox.TabIndex = 10;
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.encryptButton.Location = new System.Drawing.Point(15, 246);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(197, 34);
            this.encryptButton.TabIndex = 11;
            this.encryptButton.Text = "Encrypt File ";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output of the file (where you want it saved):";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(300, 214);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(419, 22);
            this.outputFileTextBox.TabIndex = 13;
            this.outputFileTextBox.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(343, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(213, 20);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Include subdirectories ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(215, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "(Dont Forget to write down your encryption key)";
            // 
            // Encrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1255, 538);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptionIVTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptionKeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_EncryptFolder);
            this.Controls.Add(this.textBox_EncrptFolder);
            this.Controls.Add(this.InputFile);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.Label InputFile;
        private System.Windows.Forms.TextBox textBox_EncrptFolder;
        private System.Windows.Forms.Button button_EncryptFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptionKeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptionIVTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
    }
}