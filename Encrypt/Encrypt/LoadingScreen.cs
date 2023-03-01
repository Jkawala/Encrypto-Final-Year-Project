using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//A pixal loading Introducing the user to the application
namespace Encrypt
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        //A timer autamtically starts when the user opens the page 
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Width += 4; //The picture box is set as a progress bar 

                if (pictureBox1.Width >= 600) //If the progress bar reaches 600 width, a new page will appear
                {

                    timer1.Stop(); //Timer stops and Menu page shows. Hides the loading screen 
                    Main f2 = new Main();

                    f2.Show();

                    this.Hide();

                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
