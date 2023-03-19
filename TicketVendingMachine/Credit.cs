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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }


        public Credit(string value)
        {
            InitializeComponent();
            tSelectionCre.Text = value;
        }

        public string Value { get; set; }


        private void Credit_Load(object sender, EventArgs e)
        {
            formLoad();
        }
        void formLoad()
        {
            tSelectionCre.Enabled = false;
            tPriceCre.Enabled = false;
            tSelectionCre.Text = Value;

            if (Value == "Sai Gon")
            {
                tPriceCre.Text = "5.000.000 VND";
            }
            else if (Value == "Ha Noi")
            {
                tPriceCre.Text = "4.500.000 VND";
            }
            else if (Value == "Da Lat")
            {
                tPriceCre.Text = "5.500.000 VND";
            }
            else if (Value == "Thanh Hoa")
            {
                tPriceCre.Text = "4.000.000 VND";
            }
            else if (Value == "Vung Tau" || Value == "Phan Thiet")
            {
                tPriceCre.Text = "4.800.000 VND";
            }
            else if (Value == "Nha Trang")
            {
                tPriceCre.Text = "4.300.000 VND";
            }
            else
            {
                tPriceCre.Text = "3.500.000 VND";
            }
        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            t.destination = tSelectionCre.Text;
            t.price = tPriceCre.Text;
            t.ShowDialog();
        }
    }
}
