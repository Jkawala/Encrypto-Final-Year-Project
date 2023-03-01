using System;
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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        
    

        
        

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectSearchDirButton_Click(object sender, EventArgs e)
        {
            if (containingCheckBox.Checked) //If a folder is selected, the search directory can be accessed 
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.SelectedPath = searchDirTextBox.Text;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    searchDirTextBox.Text = dlg.SelectedPath;
                }
            }

        }

        private void searchDirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void containingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (containingCheckBox.Checked)
            {
                searchDirTextBox.Enabled = true;
                
               //allow the search box to be accessed 
            }
            else
            {
                searchDirTextBox.Enabled = false;
                

            }
        }
    }
}
