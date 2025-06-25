using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace BookshopManagementSystem
{
    public partial class Form4 : Form
    {
        private List<Book> books;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            books = Database.GetBooks();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";

            for (int i = 1; i <= 10; i++)
            {
                cmbQuantity.Items.Add(i);
            }

            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            cmbQuantity.SelectedIndexChanged += cmbQuantity_SelectedIndexChanged;
        }

        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceAndTotal();
        }

        private void cmbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePriceAndTotal();
        }

        private void UpdatePriceAndTotal()
        {
            if (cmbBooks.SelectedItem != null && cmbQuantity.SelectedItem != null)
            {
                Book selectedBook = (Book)cmbBooks.SelectedItem;
                int quantity = Convert.ToInt32(cmbQuantity.SelectedItem);
                double price = selectedBook.Price;
                double total = price * quantity;

                lblShowPrice.Text = $"Rs. {price:N2}";
                lblShowTotal.Text = $"Rs. {total:N2}";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedItem == null || cmbQuantity.SelectedItem == null)
            {
                MessageBox.Show("Please select book and quantity.");
                return;
            }

            MessageBox.Show("✅ Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPay_Click_1(object sender, EventArgs e)

        {
            if (cmbBooks.SelectedItem == null || cmbQuantity.SelectedItem == null)
            {
                MessageBox.Show("❌ Please select a book and quantity first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book selectedBook = (Book)cmbBooks.SelectedItem;
            int quantity = Convert.ToInt32(cmbQuantity.SelectedItem);
            double totalPrice = selectedBook.Price * quantity;

     
            Form5 paymentForm = new Form5(selectedBook.Title, quantity, totalPrice);
            paymentForm.ShowDialog();
        }

    }
}
