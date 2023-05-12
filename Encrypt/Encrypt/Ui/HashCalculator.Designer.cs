namespace Encrypt.Ui
{
    partial class HashCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.TxtSHA512 = new System.Windows.Forms.TextBox();
            this.ChkSHA512 = new System.Windows.Forms.CheckBox();
            this.TxtSHA256 = new System.Windows.Forms.TextBox();
            this.ChkSHA256 = new System.Windows.Forms.CheckBox();
            this.TxtSHA1 = new System.Windows.Forms.TextBox();
            this.ChkSHA1 = new System.Windows.Forms.CheckBox();
            this.TxtMD5 = new System.Windows.Forms.TextBox();
            this.ChkMD5 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCheck = new System.Windows.Forms.TextBox();
            this.CmdCompute = new System.Windows.Forms.Button();
            this.CmdBrowsePath = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
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
            this.menuStrip1.TabIndex = 4;
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
            // TxtPath
            // 
            this.TxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPath.Location = new System.Drawing.Point(74, 112);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(543, 22);
            this.TxtPath.TabIndex = 5;
            this.TxtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // TxtSHA512
            // 
            this.TxtSHA512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSHA512.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSHA512.Location = new System.Drawing.Point(131, 274);
            this.TxtSHA512.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSHA512.Name = "TxtSHA512";
            this.TxtSHA512.ReadOnly = true;
            this.TxtSHA512.Size = new System.Drawing.Size(599, 23);
            this.TxtSHA512.TabIndex = 18;
            this.TxtSHA512.TextChanged += new System.EventHandler(this.TxtSHA512_TextChanged);
            // 
            // ChkSHA512
            // 
            this.ChkSHA512.AutoSize = true;
            this.ChkSHA512.Checked = true;
            this.ChkSHA512.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSHA512.Location = new System.Drawing.Point(16, 278);
            this.ChkSHA512.Margin = new System.Windows.Forms.Padding(4);
            this.ChkSHA512.Name = "ChkSHA512";
            this.ChkSHA512.Size = new System.Drawing.Size(82, 21);
            this.ChkSHA512.TabIndex = 17;
            this.ChkSHA512.Text = "SHA512";
            this.ChkSHA512.UseVisualStyleBackColor = true;
            // 
            // TxtSHA256
            // 
            this.TxtSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSHA256.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSHA256.Location = new System.Drawing.Point(131, 242);
            this.TxtSHA256.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSHA256.Name = "TxtSHA256";
            this.TxtSHA256.ReadOnly = true;
            this.TxtSHA256.Size = new System.Drawing.Size(599, 23);
            this.TxtSHA256.TabIndex = 16;
            this.TxtSHA256.TextChanged += new System.EventHandler(this.TxtSHA256_TextChanged);
            // 
            // ChkSHA256
            // 
            this.ChkSHA256.AutoSize = true;
            this.ChkSHA256.Checked = true;
            this.ChkSHA256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSHA256.Location = new System.Drawing.Point(16, 246);
            this.ChkSHA256.Margin = new System.Windows.Forms.Padding(4);
            this.ChkSHA256.Name = "ChkSHA256";
            this.ChkSHA256.Size = new System.Drawing.Size(82, 21);
            this.ChkSHA256.TabIndex = 15;
            this.ChkSHA256.Text = "SHA256";
            this.ChkSHA256.UseVisualStyleBackColor = true;
            // 
            // TxtSHA1
            // 
            this.TxtSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSHA1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSHA1.Location = new System.Drawing.Point(131, 210);
            this.TxtSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSHA1.Name = "TxtSHA1";
            this.TxtSHA1.ReadOnly = true;
            this.TxtSHA1.Size = new System.Drawing.Size(599, 23);
            this.TxtSHA1.TabIndex = 14;
            this.TxtSHA1.TextChanged += new System.EventHandler(this.TxtSHA1_TextChanged);
            // 
            // ChkSHA1
            // 
            this.ChkSHA1.AutoSize = true;
            this.ChkSHA1.Checked = true;
            this.ChkSHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSHA1.Location = new System.Drawing.Point(16, 214);
            this.ChkSHA1.Margin = new System.Windows.Forms.Padding(4);
            this.ChkSHA1.Name = "ChkSHA1";
            this.ChkSHA1.Size = new System.Drawing.Size(66, 21);
            this.ChkSHA1.TabIndex = 13;
            this.ChkSHA1.Text = "SHA1";
            this.ChkSHA1.UseVisualStyleBackColor = true;
            // 
            // TxtMD5
            // 
            this.TxtMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMD5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMD5.Location = new System.Drawing.Point(131, 178);
            this.TxtMD5.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMD5.Name = "TxtMD5";
            this.TxtMD5.ReadOnly = true;
            this.TxtMD5.Size = new System.Drawing.Size(599, 23);
            this.TxtMD5.TabIndex = 12;
            this.TxtMD5.TextChanged += new System.EventHandler(this.TxtMD5_TextChanged);
            // 
            // ChkMD5
            // 
            this.ChkMD5.AutoSize = true;
            this.ChkMD5.Checked = true;
            this.ChkMD5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkMD5.Location = new System.Drawing.Point(16, 182);
            this.ChkMD5.Margin = new System.Windows.Forms.Padding(4);
            this.ChkMD5.Name = "ChkMD5";
            this.ChkMD5.Size = new System.Drawing.Size(59, 21);
            this.ChkMD5.TabIndex = 11;
            this.ChkMD5.Text = "MD5";
            this.ChkMD5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Paste an hash here to compare with the above results:";
            // 
            // TxtCheck
            // 
            this.TxtCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCheck.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCheck.Location = new System.Drawing.Point(13, 380);
            this.TxtCheck.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCheck.Name = "TxtCheck";
            this.TxtCheck.Size = new System.Drawing.Size(713, 23);
            this.TxtCheck.TabIndex = 19;
            this.TxtCheck.TextChanged += new System.EventHandler(this.TxtCheck_TextChanged);
            // 
            // CmdCompute
            // 
            this.CmdCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCompute.Image = global::Encrypt.Properties.Resources.calculator;
            this.CmdCompute.Location = new System.Drawing.Point(689, 106);
            this.CmdCompute.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCompute.Name = "CmdCompute";
            this.CmdCompute.Size = new System.Drawing.Size(33, 28);
            this.CmdCompute.TabIndex = 7;
            this.CmdCompute.UseVisualStyleBackColor = true;
            this.CmdCompute.Click += new System.EventHandler(this.CmdCompute_Click);
            // 
            // CmdBrowsePath
            // 
            this.CmdBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdBrowsePath.Image = global::Encrypt.Properties.Resources.browse;
            this.CmdBrowsePath.Location = new System.Drawing.Point(652, 106);
            this.CmdBrowsePath.Margin = new System.Windows.Forms.Padding(4);
            this.CmdBrowsePath.Name = "CmdBrowsePath";
            this.CmdBrowsePath.Size = new System.Drawing.Size(33, 28);
            this.CmdBrowsePath.TabIndex = 6;
            this.CmdBrowsePath.UseVisualStyleBackColor = true;
            this.CmdBrowsePath.Click += new System.EventHandler(this.CmdBrowsePath_Click);
            // 
            // HashCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1255, 538);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCheck);
            this.Controls.Add(this.TxtSHA512);
            this.Controls.Add(this.ChkSHA512);
            this.Controls.Add(this.TxtSHA256);
            this.Controls.Add(this.ChkSHA256);
            this.Controls.Add(this.TxtSHA1);
            this.Controls.Add(this.ChkSHA1);
            this.Controls.Add(this.TxtMD5);
            this.Controls.Add(this.ChkMD5);
            this.Controls.Add(this.CmdCompute);
            this.Controls.Add(this.CmdBrowsePath);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HashCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Calculator";
            this.Load += new System.EventHandler(this.HashCalculator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button CmdBrowsePath;
        private System.Windows.Forms.Button CmdCompute;
        private System.Windows.Forms.TextBox TxtSHA512;
        private System.Windows.Forms.CheckBox ChkSHA512;
        private System.Windows.Forms.TextBox TxtSHA256;
        private System.Windows.Forms.CheckBox ChkSHA256;
        private System.Windows.Forms.TextBox TxtSHA1;
        private System.Windows.Forms.CheckBox ChkSHA1;
        private System.Windows.Forms.TextBox TxtMD5;
        private System.Windows.Forms.CheckBox ChkMD5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCheck;
    }
}