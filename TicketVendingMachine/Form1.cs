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
    public partial class Form1 : Form
    {
        void showDestination()
        {
            cbDestination.Items.Add("Sai Gon");
            cbDestination.Items.Add("Ha Noi");
            cbDestination.Items.Add("Da Lat");
            cbDestination.Items.Add("Thanh Hoa");
            cbDestination.Items.Add("Soc Trang");
            cbDestination.Items.Add("Nha Trang");
            cbDestination.Items.Add("Vung Tau");
            cbDestination.Items.Add("Phan Thiet");
        }
        public Form1()
        {
            InitializeComponent();
        }
        void enable()
        {
            cbDestination.Enabled = false;
            bStart.Enabled = false;
            bFinish.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showDestination();
            enable();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bStart.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            if (rbCre.Checked == true)
            {
               if(cbDestination.Text =="Select a destination")
               {
                    MessageBox.Show("Please choose a destination above");                  
               }
               else
               {
                    Credit credit = new Credit(cbDestination.Text);
                    credit.Value = cbDestination.Text;
                    credit.ShowDialog();
               }
            
            }
            else
            {
                if (String.IsNullOrEmpty(cbDestination.Text))
                {
                    MessageBox.Show("Please choose your destination you want to come");
                }
                else
                {
                    QR_code_linking_to_bank qr = new QR_code_linking_to_bank(cbDestination.Text);
                    qr.Value = cbDestination.Text;
                    qr.ShowDialog();
                }
               
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            cbDestination.Enabled = true;
            bFinish.Enabled = true;
        }

        private void rbQR_CheckedChanged(object sender, EventArgs e)
        {
            bStart.Enabled = true;
        }

        private void rbDW_CheckedChanged(object sender, EventArgs e)
        {
            bStart.Enabled = true;
        }
    }
}
