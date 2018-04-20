using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubIn.admin
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            slidepanel.Height = button1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button4.Height;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
