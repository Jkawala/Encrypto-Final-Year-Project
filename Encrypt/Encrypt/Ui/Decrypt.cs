using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Encrypt
{
    public partial class DecryptFile : Form
    {
        public DecryptFile()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                encryptedFileTextBox.Text = openFileDialog.FileName;
            } 
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(encryptedFileTextBox.Text) || string.IsNullOrWhiteSpace(decryptedFileTextBox.Text) || string.IsNullOrWhiteSpace(decryptionKeyTextBox.Text) || string.IsNullOrWhiteSpace(decryptionIVTextBox.Text))
            {
                MessageBox.Show("Please try again and enter all the required information");
                return;
            }

          

            byte[] key = new byte[32]; // 256 bits
            byte[] IV = new byte[16]; //128 bits

            Aes aesAlg = Aes.Create();
            aesAlg.KeySize = 256;

            aesAlg.Key = key;
            aesAlg.IV = IV;

            FileStream encryptedFileStream = new FileStream(encryptedFileTextBox.Text, FileMode.Open, FileAccess.Read);
            FileStream decryptedFileStream = new FileStream(decryptedFileTextBox.Text, FileMode.Create, FileAccess.Write);

            CryptoStream cryptoStream = new CryptoStream(encryptedFileStream, aesAlg.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                decryptedFileStream.Write(buffer, 0, bytesRead);
            }

            cryptoStream.Close();
            decryptedFileStream.Close();
            encryptedFileStream.Close();

            MessageBox.Show("File decrypted successfully.");

        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                decryptedFileTextBox.Text = saveFileDialog.FileName;
            }
        }

        private void Decrypt_Load(object sender, EventArgs e)
        {

        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }
    }
}
