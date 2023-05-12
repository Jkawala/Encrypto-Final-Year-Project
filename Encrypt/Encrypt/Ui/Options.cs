using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encrypt.Ui;
using System.Diagnostics;

namespace Encrypt
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();

            //Hide the second groupbox as soon as the application loads
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    

        
        

        

        private void selectSearchDirButton_Click(object sender, EventArgs e)
        {
          

        }

        private void searchDirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void containingCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ForensicrB_CheckedChanged(object sender, EventArgs e)
        {
            //Show the 2nd groupbox/ three options when the main radio button is selected
            groupBox2.Visible = true;
            groupBox4.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if the a radio button is selected, the system will take it to a new windows form
            if (QuickScanrB.Checked)
            {
                this.Hide();

                FullScan fullScan = new FullScan();
                fullScan.Show();
            }

            else if (SystemFolderrB.Checked)
            {
                this.Hide();
                SearchSpecific searchSpecific = new SearchSpecific();
                searchSpecific.ShowDialog();
                this.Close();
               
            }

            else if (ComputerrB.Checked)
            {
                this.Hide();
                MyComputer myComputer = new MyComputer();
                myComputer.ShowDialog();
                this.Close();

            }

            else if (rbRegistryAnalysis.Checked)
            {
                // Open the Registry Editor
                Process.Start("regedit.exe");
            }

            else if (rbNetworkAnalysis.Checked)
            {
                this.Hide();
                NetworkAnalysis networkAnalysis = new NetworkAnalysis();
                networkAnalysis.ShowDialog();
                this.Close();
            }
            else if (RBMd5.Checked)
            {
                DialogResult result = MessageBox.Show("Click Yes to calculate MD5 or click No to change an MD5 file", "MD5 Options", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    // User clicked "Calculate MD5" option, take them to another form
                    this.Hide();
                    HashCalculator hashCalculator= new HashCalculator();
                    hashCalculator.ShowDialog();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    // User clicked "Change to MD5" option, take them to another page
                    this.Hide();
                    HashChanger hashChanger = new HashChanger();
                    hashChanger.ShowDialog();
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    // User clicked "Cancel" option, do nothing
                }
            }
            else if (rBEncrypt.Checked)
            {
                // User clicked "Calculate MD5" option, take them to another form
                this.Hide();
                EncryptFile encryptFile = new EncryptFile();
                encryptFile.ShowDialog();
                this.Close();
            }
            else if (rBDecrypt.Checked)
            {
                // User clicked "Calculate MD5" option, take them to another form
                this.Hide();
                DecryptFile DecryptFile = new DecryptFile();
                DecryptFile.ShowDialog();
                this.Close();
            }
            else if (rBAnalyseFiles.Checked)
            {
                // User clicked "Calculate MD5" option, take them to another form
             
            }
            else
            {
                MessageBox.Show("Please select an option before clicking Process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SystemFolderrB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbNetworkAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void RBMd5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void QuickScanrB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBEncryptionAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            //Show the 4th groupbox/ three options when the main radio button is selected
            groupBox4.Visible = true;
            groupBox2.Visible = false;
        }

        private void rbRegistryAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "A digital forensic tool that analyses different aspects of a systems.\n" +
           "If there is an error with the repository please visit the link below\n" +
           "GitHub: https://github.com/wholetthedogsoutside/ \n\n");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string feedback = Microsoft.VisualBasic.Interaction.InputBox("Please enter your feedback:", "Feedback", "");
            if (feedback != "")
            {
                MessageBox.Show("Thank you for your feedback!");
                // You can add code here to send the feedback to a database or an email address.
            }
            else
            {
                MessageBox.Show("Failed to get Feedback form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
          "Created by James Kawala\n" +
          "A digital forensic tool that analyses different aspects of a systems.\n" +
          "GitHub: https://github.com/wholetthedogsoutside/ \n\n" +
          "This project was done through research and online resources.");
        }
    }
    }

