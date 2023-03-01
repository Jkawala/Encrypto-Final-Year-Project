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
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void Encrypt_Load(object sender, EventArgs e)
        {

        }

        private void textBox_EncrptFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_EncryptFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_EncrptFolder.Text = openFileDialog.FileName;

            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_EncrptFolder.Text) || string.IsNullOrWhiteSpace(outputFileTextBox.Text) || string.IsNullOrWhiteSpace(encryptionKeyTextBox.Text) || string.IsNullOrWhiteSpace(encryptionIVTextBox.Text))
            {
                MessageBox.Show("Please enter all the required information.");
                return;
            }

            byte[] key = new byte[32]; // 256 bits
            byte[] IV = new byte[16]; //128 bits

            Aes aesAlg = Aes.Create();
            aesAlg.KeySize = 256;
           
            aesAlg.Key = key;
            aesAlg.IV = IV;

            FileStream inputFileStream = new FileStream(textBox_EncrptFolder.Text, FileMode.Open, FileAccess.Read);
            FileStream outputFileStream = new FileStream(outputFileTextBox.Text, FileMode.Create, FileAccess.Write);

            CryptoStream cryptoStream = new CryptoStream(outputFileStream, aesAlg.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] buffer = new byte[4096];
            int bytesRead; 
            while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                cryptoStream.Write(buffer, 0, bytesRead);
            }

            cryptoStream.Close();
            outputFileStream.Close();
            inputFileStream.Close();

            MessageBox.Show("File has been encrypted succesffuly.");
        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFileTextBox.Text = saveFileDialog.FileName;
            } 
        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }
    }
}
