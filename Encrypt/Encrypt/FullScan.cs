using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encrypt.Model.Engine;
using System.IO;
namespace Encrypt
{
    public partial class FullScan : Form
    {
        

        public FullScan()
        {
            InitializeComponent();
        }
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this will clear all the cookies created by the page.

            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void FullScan_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search for all text files on the C:\ drive
            string[] files = Directory.GetFiles(@"C:\", "*.txt", SearchOption.AllDirectories);

            // Build the report
            StringBuilder report = new StringBuilder();
            report.AppendLine("Text files found on the computer:");

            foreach (string file in files)
            {
                report.AppendLine(file);
            }
            try
            {
                // Code that may throw System.UnauthorizedAccessException
            }
            catch (System.UnauthorizedAccessException)
            {
                // Handle the exception or ignore it
            }

            // Display the report in a message box
            MessageBox.Show(report.ToString(), "Search Results");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
