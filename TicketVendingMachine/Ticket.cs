using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendingMachine
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(string value)
        {
            InitializeComponent();
            tDestination.Text  = value;
            tPrice.Text = value;
        }

        public string destination { get; set; }

        public string price { get; set; }

        void formEnable()
        {
            tDestination.Enabled = false;
            tIDuser.Enabled = false;
            tIDticket.Enabled = false;
            tPrice.Enabled = false;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            formEnable();
            tDestination.Text = destination;
            tPrice.Text = price;
        }
    }
}
