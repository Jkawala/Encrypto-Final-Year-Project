﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void searchDirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

           Encrypt f3 = new Encrypt();

            f3.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Options f3 = new Options();

            f3.Show();
        }

        private void newSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }
    }
}
