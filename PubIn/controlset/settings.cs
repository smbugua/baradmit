using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubIn.connect;
using PubIn.admin;

namespace PubIn.controlset
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.insertBatch(eventname.Text);
            MessageBox.Show("EVENT HAS BEEN ADDED SUCCESSFULLY");
            this.Hide();
            barscanner b = new barscanner();
            b.BringToFront();
            dashboard d = new dashboard();
            d.Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.insertColor(color.Text);
            MessageBox.Show("COLOUR HAS BEEN ADDED SUCCESSFULLY");
            this.Hide();
            barscanner b = new barscanner();
            b.BringToFront();
            dashboard d = new dashboard();
            d.Reset();

        }
    }
}
