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
    }
}
