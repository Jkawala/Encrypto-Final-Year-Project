using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt.Ui
{
    public partial class MyComputer : Form
    {
        public MyComputer()
        {
            InitializeComponent();
        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this will clear all the cookies created by the page.

            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
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

        private void selectSearchDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = searchDirTextBox.Text;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                searchDirTextBox.Text = dlg.SelectedPath;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Clear the results list
            resultsList.Items.Clear();

            startButton.Enabled = false;
            stopButton.Enabled = true;

        }
    }
}
