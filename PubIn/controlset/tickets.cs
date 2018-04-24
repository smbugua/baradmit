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
            int eventidvalue = Convert.ToInt32(this.eventid.SelectedValue);
            int coloridvalue = Convert.ToInt32(this.colorid.SelectedValue);
            string no = this.nooftickets.Text;
            DBConnect db = new DBConnect();
            for (int i = 0; i < Convert.ToInt32(no); i++)
            {
                db.InsertTickets(eventidvalue, "event" + i, coloridvalue);
            }
            MessageBox.Show("TICKETS HAVE BEEN SAVED SUCCESSFULLY");
            dashboard d = new dashboard();
            d.reset();


        }

       
    }
}
