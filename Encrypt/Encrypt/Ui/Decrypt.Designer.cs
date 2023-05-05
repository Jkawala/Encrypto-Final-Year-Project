namespace Encrypt
{
    partial class DecryptFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptFile));
            this.label1 = new System.Windows.Forms.Label();
            this.encryptedFileTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptionIVTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptedFileTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse your local files to Decrypt a File:";
            // 
            // encryptedFileTextBox
            // 
            this.encryptedFileTextBox.Location = new System.Drawing.Point(363, 78);
            this.encryptedFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.encryptedFileTextBox.Name = "encryptedFileTextBox";
            this.encryptedFileTextBox.Size = new System.Drawing.Size(425, 22);
            this.encryptedFileTextBox.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(363, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(214, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Include Subdirectories ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(795, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add your Key";
            // 
            // decryptionKeyTextBox
            // 
            this.decryptionKeyTextBox.Location = new System.Drawing.Point(152, 157);
            this.decryptionKeyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.decryptionKeyTextBox.Name = "decryptionKeyTextBox";
            this.decryptionKeyTextBox.Size = new System.Drawing.Size(425, 22);
            this.decryptionKeyTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add your decryption IV:";
            // 
            // decryptionIVTextBox
            // 
            this.decryptionIVTextBox.Location = new System.Drawing.Point(211, 200);
            this.decryptionIVTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.decryptionIVTextBox.Name = "decryptionIVTextBox";
            this.decryptionIVTextBox.Size = new System.Drawing.Size(425, 22);
            this.decryptionIVTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Decrypted File ";
            // 
            // decryptedFileTextBox
            // 
            this.decryptedFileTextBox.Location = new System.Drawing.Point(162, 242);
            this.decryptedFileTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.decryptedFileTextBox.Name = "decryptedFileTextBox";
            this.decryptedFileTextBox.Size = new System.Drawing.Size(425, 22);
            this.decryptedFileTextBox.TabIndex = 9;
            this.decryptedFileTextBox.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(15, 286);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(99, 23);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "Decrypt File";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
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
            this.menuStrip1.TabIndex = 11;
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
            // DecryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1255, 538);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.decryptedFileTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptionIVTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptionKeyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.encryptedFileTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypt Tool";
            this.Load += new System.EventHandler(this.Decrypt_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox encryptedFileTextBox;
        private global::System.Windows.Forms.CheckBox checkBox1;
        private global::System.Windows.Forms.Button button1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox decryptionKeyTextBox;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.TextBox decryptionIVTextBox;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.TextBox decryptedFileTextBox;
        private global::System.Windows.Forms.Button decryptButton;
        private global::System.Windows.Forms.MenuStrip menuStrip1;
        private global::System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem menToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
    }
}