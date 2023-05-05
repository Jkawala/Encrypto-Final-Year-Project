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
namespace Encrypt
    //Main Menu Form/Form 2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the Main form and hide the current form
            this.Hide(); 

            Main f2 = new Main();

            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show the Options form and hide the current form
            this.Hide(); 

            Options f3 = new Options();

            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Show the FullScan form and hide the current form
            this.Hide(); 

            FullScan fullScan = new FullScan();
                fullScan.Show();

        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the FullScan form and hide the current form
            this.Hide(); 

            Main f2 = new Main();

            f2.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolboxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "Created by James Kawala\n" +
             "A digital forensic tool that analyses different aspects of a systes.\n" +
             "GitHub: https://github.com/wholetthedogsoutside/ \n\n" +
             "This project was done through research and online resources.");
        }
    }
}


