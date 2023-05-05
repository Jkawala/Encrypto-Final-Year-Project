﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Encrypt.Ui
{
    public partial class HashChanger : Form
    {
        public int currentRowIndex = 0;
        public bool running = false;

        public HashChanger()
        {
            InitializeComponent();
        }

        private void HashChanger_Load(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(dgvMD5.Rows[currentRowIndex].Cells[0].Value.ToString());
            }
            catch { }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFile = new OpenFileDialog();
            selectFile.Multiselect = true;
            bool flag = selectFile.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                int totalFiles = selectFile.FileNames.Length;
                labelItem.Text = "0";
                labelTotalItem.Text = totalFiles.ToString();
                progressBarStatus.Value = 0;
                progressBarStatus.Maximum = totalFiles;
                Thread t = new Thread(() => checkMD5(selectFile.FileNames));
                t.IsBackground = true;
                t.Start();
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMD5.SelectedRows)
            {
                dgvMD5.Rows.RemoveAt(row.Index);
            }
            dgvMD5.ClearSelection();
            labelItem.Text = "0";
            labelTotalItem.Text = dgvMD5.RowCount.ToString();
        }

        private void btnStartMD5_Click(object sender, EventArgs e)
        {
            if (btnStartMD5.Text == "Stop Change MD5")
            {
                btnStartMD5.Text = "Start Change MD5";
                running = false;
                return;
            }
            running = true;
            int totalFiles = dgvMD5.RowCount;
            string[] fileNames = new string[totalFiles];
            for (int i = 0; i < totalFiles; i++)
            {
                fileNames[i] = dgvMD5.Rows[i].Cells[0].Value.ToString();
            }
            labelItem.Text = "0";
            labelTotalItem.Text = totalFiles.ToString();
            progressBarStatus.Value = 0;
            progressBarStatus.Maximum = totalFiles;
            btnStartMD5.Enabled = false;
            btnStartMD5.Text = "Stop Change MD5";
            Thread t = new Thread(() => changeMD5(fileNames));
            t.IsBackground = true;
            t.Start();
        }

        private void changeMD5(string[] fileNames)
        {
            Random random = new Random();
            Thread.Sleep(1000);
            this.Invoke((MethodInvoker)delegate ()
            {
                this.btnStartMD5.Enabled = true;
            });

            for (int i = 0; i < fileNames.Length; i++)
            {
                if (!running)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        this.btnStartMD5.Text = "Start Change MD5";
                        running = false;
                    });
                    break;
                }
                int num = random.Next(2, 7);
                byte[] extraByte = new byte[num];
                for (int j = 0; j < num; j++)
                {
                    extraByte[j] = (byte)0;
                }
                long fileSize = new FileInfo(fileNames[i]).Length;
                if (fileSize == 0L)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        this.dgvMD5.Rows[i].Cells[3].Value = "Empty";
                    });
                }
                else
                {
                    using (FileStream fileStream = new FileStream(fileNames[i], FileMode.Append))
                    {
                        fileStream.Write(extraByte, 0, extraByte.Length);
                    }
                    int bufferSize = fileSize > 1048576L ? 1048576 : 4096;
                    string md5hash = "";
                    using (MD5 md = MD5.Create())
                    {
                        using (FileStream fileStream2 = new FileStream(fileNames[i], FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize))
                        {
                            md5hash = BitConverter.ToString(md.ComputeHash(fileStream2)).Replace("-", "");
                        }
                    }
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        bool flag2 = this.dgvMD5.Rows[i].Cells[2].Value.ToString() != "";
                        if (flag2)
                        {
                            this.dgvMD5.Rows[i].Cells[1].Value = this.dgvMD5.Rows[i].Cells[2].Value;
                        }
                        this.labelItem.Text = (i + 1).ToString();
                        this.progressBarStatus.Value = i + 1;
                        this.dgvMD5.Rows[i].Cells[2].Value = md5hash;
                        this.dgvMD5.Rows[i].Cells[3].Value = "OK";
                    });
                }
            }
            this.Invoke((MethodInvoker)delegate ()
            {
                this.btnStartMD5.Text = "Start Change MD5";
                running = false;
            });
        }

        private void checkMD5(string[] fileNames)
        {
            int index = 0;
            foreach (string name in fileNames)
            {
                string md5hash = "";
                long fileSize = new FileInfo(name).Length;
                int bufferSize = fileSize > 1048576L ? 1048576 : 4096;
                using (MD5 md = MD5.Create())
                {
                    using (FileStream fileStream = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize))
                    {
                        md5hash = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "");
                    }
                }
                index++;
                this.Invoke((MethodInvoker)delegate ()
                {
                    this.labelItem.Text = index.ToString();
                    this.progressBarStatus.Value = index;
                    this.dgvMD5.Rows.Add(new object[] { name, md5hash, "", "idle" });
                    this.dgvMD5.Rows[0].Selected = false;
                });
            }
        }

        private void contextMenuCopyRow_Click(object sender, EventArgs e)
        {
            string rowData = "";
            for (int i = 0; i < dgvMD5.RowCount; i++)
            {
                var rows = dgvMD5.Rows[i];
                if (rows.Selected)
                {
                    rowData += string.Format("{0}\t{1}\t{2}\r\n", rows.Cells[0].Value, rows.Cells[1].Value, rows.Cells[2].Value);
                }
            }
            Clipboard.SetText(rowData);
        }

        private void contextMenuExportToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                string rowData = "";
                for (int i = 0; i < dgvMD5.RowCount; i++)
                {
                    var rows = dgvMD5.Rows[i];
                    rowData += string.Format("{0},{1},{2}\r\n", rows.Cells[0].Value, rows.Cells[1].Value, rows.Cells[2].Value);
                }
                File.WriteAllText(savefile.FileName, rowData);
            }
        }

        private void dgvMD5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                currentRowIndex = dgvMD5.HitTest(e.X, e.Y).RowIndex;
                if (currentRowIndex > -1 && dgvMD5.Rows[currentRowIndex].Selected)
                {
                    contextMenuCopyRow.Enabled = true;
                    contextMenuOpenFile.Enabled = true;
                   
                }
                else if (dgvMD5.RowCount > 0)
                {
                    contextMenuCopyRow.Enabled = false;
                    contextMenuOpenFile.Enabled = false;
                   
                }
            }
        }
    }
}
