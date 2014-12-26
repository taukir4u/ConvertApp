using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_App
{
    public partial class ConvertAppUI : Form
    {
        public ConvertAppUI()
        {
            InitializeComponent();
        }

        private string customerName;
        private int numberOfTickets;
        private int totalPrice;

        public void TakeInput()
        {
            customerName = customerNameTextBox.Text;
            numberOfTickets = Convert.ToInt32(numberOfTicketsTextBox.Text);
        }

        public bool CheckIsTextBoxBlank()
        {
            if (customerNameTextBox.Text == ""|| numberOfTicketsTextBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            
            bool chk=CheckIsTextBoxBlank();
            if(chk==true)
            {
                TakeInput();
                numberOfTicketsTextBox.Clear();
                customerNameTextBox.Clear();
                totalPrice = numberOfTickets * 10;

                MessageBox.Show("Please ,  " + customerName + " pay " + totalPrice + " taka for your purchase ticket for " + numberOfTickets);
            }
            else
            {
                MessageBox.Show("please input value on text box");
            }
            
            
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Customer Name :: " + customerName + "\n" + "Number of Unit :: " + numberOfTickets + "\n" +
                            "Total Price :: " + totalPrice);


        }
    }
}
