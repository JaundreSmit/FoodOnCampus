using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOnCampus
{
    public partial class frmPayment : Form
    {
        public decimal Data { get; set; }
        public bool Payed;

        public static bool IsValidCreditCardNumber(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber) || !cardNumber.All(char.IsDigit))
                return false;

            char firstDigit = cardNumber[0];
            int length = cardNumber.Length;
            bool isValidType = false;
            switch (firstDigit)
            {
                case '3':
                    isValidType = (length == 15) && (cardNumber[1] == '4' || cardNumber[1] == '7');
                    break;
                case '4':
                    isValidType = (length == 13 || length == 16);
                    break;
                case '5':
                    isValidType = (length == 16) && (cardNumber[1] >= '1' && cardNumber[1] <= '5');
                    break;
            }

            if (!isValidType)
                return false;

            int sum = 0;
            for (int i = length - 1; i >= 0; i--)
            {
                int digit = cardNumber[i] - '0';
                if ((length - i) % 2 == 0)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9;
                }
                sum += digit;
            }
            return sum % 10 == 0;
        }

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            //show form in center of window
            this.CenterToScreen();


            Payed = false;
            lblAmount.Text = "R"+Data;
            cbxTip.SelectedIndex = 0;
        }

        private void cbxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTip.SelectedIndex)
            {
                case -1:
                    lblAmount.Text = "R" + Data.ToString("0.00"); ;
                    break;
                case 0:
                    lblAmount.Text = "R" + Data.ToString("0.00"); ;
                    break;
                case 1:
                    lblAmount.Text = "R" + (Data * Convert.ToDecimal(1.05)).ToString("0.00"); 
                    break;
                case 2:
                    lblAmount.Text = "R" + (Data * Convert.ToDecimal(1.1)).ToString("0.00");
                    break;
                case 3:
                    lblAmount.Text = "R" + (Data * Convert.ToDecimal(1.15)).ToString("0.00");
                    break;
                case 4:
                    lblAmount.Text = "R" + (Data * Convert.ToDecimal(1.2)).ToString("0.00");
                    break;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(IsValidCreditCardNumber(tbxNumber.Text))
            {
                MessageBox.Show("Payment successful, your order will now be processed");
                Payed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid card number");
                tbxNumber.Text = "";
            }
        }
    }
}
