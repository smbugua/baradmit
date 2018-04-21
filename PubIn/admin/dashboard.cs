using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubIn.controlset;

namespace PubIn.admin
{
    public partial class dashboard : Form
    {
        public dashboard()
        {

            InitializeComponent();
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;
            barscanner b = new barscanner();
            b.BringToFront();
            tickets t = new tickets();
            t.Hide();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;
            barscanner b = new barscanner();
            b.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
            slidepanel.Top = button2.Top;
            tickets t = new tickets();
            t.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button4.Height;
            slidepanel.Top = button4.Top;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button3.Height;
            slidepanel.Top = button3.Top;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button5.Height;
            slidepanel.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tickets1_Load(object sender, EventArgs e)
        {

        }
    }
}
