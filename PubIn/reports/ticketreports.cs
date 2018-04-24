using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubIn.connect;

namespace PubIn.reports
{
    public partial class ticketreports : Form
    {
        public ticketreports()
        {
            InitializeComponent();
            DBConnect db = new DBConnect();
            db.PopulateEvents(eventname);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketreports_Load(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.TicketData(ticketgridview);
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.TicketDataFilter(ticketgridview,eventname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.TicketData(ticketgridview);
        }

        private void eventname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
