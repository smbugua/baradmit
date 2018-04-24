using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PubIn.admin;
using PubIn.connect;

namespace PubIn.reports
{
    public partial class reporter : Form
    {
        public reporter()
        {
            InitializeComponent();
            DBConnect db = new DBConnect();
            db.TicketData(datagrid);
            db.populateColors(colorname);
            db.PopulateEvents(eventname);
        }

        private void reporter_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.TicketData(datagrid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            db.TicketDataFilter(datagrid, eventname);
        }
    }
}
