using System;
using System.Windows.Forms;
using System.Configuration;

namespace BookshopManagementSystem
{
    public partial class Form5 : Form
    {
        private string _book;
        private int _quantity;
        private double _totalPrice;

        public Form5(string book, int quantity, double totalPrice)
        {
            InitializeComponent();
            _book = book;
            _quantity = quantity;
            _totalPrice = totalPrice;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Set order summary
            lblOrderSummary.Text = $"You ordered {_quantity} x '{_book}' books for Rs. {_totalPrice}.00";

            txtCardNumber.Visible = false;
            txtCardName.Visible = false;
            txtExpiry.Visible = false;
            lblCardInfo.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
      
            txtCardNumber.Visible = false;
            txtCardName.Visible = false;
            txtExpiry.Visible = false;
            lblCardInfo.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
        }

        private void rdbCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.Visible = true;
            txtCardName.Visible = true;
            txtExpiry.Visible = true;
            lblCardInfo.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rdbCash.Checked)
            {
                MessageBox.Show("✅ Cash on Delivery selected.\n\nOrder Confirmed!", "Success");
            }
            else if (rdbCard.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCardName.Text) ||
                    string.IsNullOrWhiteSpace(txtExpiry.Text))
                {
                    MessageBox.Show("⚠️ Please fill in all card details.");
                }
                else
                {
                    MessageBox.Show("✅ Payment by Card successful!\n\nOrder Confirmed!", "Success");
                }
            }
            else
            {
                MessageBox.Show("⚠️ Please select a payment method.");
            }
        }
    }
}
