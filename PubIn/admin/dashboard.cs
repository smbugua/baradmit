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
            panel5.Controls.Clear();
            panel5.Controls.Add(b);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
            slidepanel.Top = button1.Top;
            barscanner b = new barscanner();
            panel5.Controls.Clear();
            panel5.Controls.Add(b);
            b.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
            slidepanel.Top = button2.Top;
            tickets t = new tickets();
            panel5.Controls.Clear();
            panel5.Controls.Add(t);
            t.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button4.Height;
            slidepanel.Top = button4.Top;
            settings s = new settings();
            panel5.Controls.Clear();
            panel5.Controls.Add(s);
            s.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button3.Height;
            slidepanel.Top = button3.Top;
            createusers cu = new createusers();
            panel5.Controls.Clear();
            panel5.Controls.Add(cu);
            cu.BringToFront();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button5.Height;
            slidepanel.Top = button5.Top;
            panel5.Controls.Clear();
            reportsmodule rm = new reportsmodule();
            panel5.Controls.Add(rm);
            rm.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
