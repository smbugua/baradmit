using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubIn.reports;

namespace PubIn.controlset
{
    public partial class reportsmodule : UserControl
    {
        public reportsmodule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reporter tr = new reporter();
            this.Hide();
            tr.Show();
        }
    }
}
