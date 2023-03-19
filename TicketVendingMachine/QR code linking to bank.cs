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
    public partial class QR_code_linking_to_bank : Form
    {
        public QR_code_linking_to_bank()
        {
            InitializeComponent();
        }

        public QR_code_linking_to_bank(string value)
        {
            InitializeComponent();
            tSelection.Text = value;
        }

        public string Value { get; set; } 

        void showBank()
        {
            cbBank.Items.Add("Vietcombank");
            cbBank.Items.Add("BIDV");
            cbBank.Items.Add("Sacombank");
            cbBank.Items.Add("Vietinbank");
            cbBank.Items.Add("TP bank");
        }
        private void QR_code_linking_to_bank_Load(object sender, EventArgs e)
        {
            showBank();
            tSelection.Enabled = false;
            tPrice.Enabled = false;
            tSelection.Text = Value;
            if (Value == "Sai Gon")
            {
                tPrice.Text = "5.000.000 VND";
            }
            else if (Value == "Ha Noi")
            {
                tPrice.Text = "4.500.000 VND";
            }
            else if (Value == "Da Lat")
            {
                tPrice.Text = "5.500.000 VND";
            }
            else if (Value == "Thanh Hoa")
            {
                tPrice.Text = "4.000.000 VND";
            }
            else if (Value == "Vung Tau" || Value == "Phan Thiet")
            {
                tPrice.Text = "4.800.000 VND";
            }
            else if (Value == "Nha Trang")
            {
                tPrice.Text = "4.300.000 VND";
            }
            else
            {
                tPrice.Text = "3.500.000 VND";
            }


          
        }

        

        private void bFinish_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbBank.Text))
            {
                MessageBox.Show("Please input your bank");
            }
            else if(String.IsNullOrEmpty(tCodeBank.Text))
            {
                MessageBox.Show("Please input your Code Bank");
            }
            else
            {
                Ticket t = new Ticket();
                t.destination = tSelection.Text;
                t.price = tPrice.Text;
                t.ShowDialog();
            }
        }
    }
}
