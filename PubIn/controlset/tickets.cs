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
using MySql.Data.MySqlClient;

namespace PubIn.controlset
{
    public partial class tickets : UserControl
    {
        public tickets()
        {
            InitializeComponent();
            DBConnect db = new DBConnect();
            db.PopulateEvents(eventid);
            db.populateColors(colorid);
        }



        private void button1_Click(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();
            string eventname = this.eventid.Text.ToString();
            string colorname = this.colorid.Text.ToString();
            string no = this.nooftickets.Text;
            int n = db.CountTickets();
            for (int i = 0; i < Convert.ToInt32(no); i++)
            {
                db.InsertTickets(eventname, "101"+n + i, colorname);
            }
            //MessageBox.Show("TICKETS HAVE BEEN SAVED SUCCESSFULLY");
            this.Hide();
            dashboard d = new dashboard();
            d.Reset();
            d.Notifier("TICKETS HAVE BEEN SAVED SUCCESSFULLY");


        }

       
    }
}
