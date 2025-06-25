using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace BookshopManagementSystem
{
    public partial class Form3 : Form
    {
        public Book NewBook { get; set; }
        private bool isEditMode = false;
        private int bookBeingEditedId = -1; 


        public Form3()
        {
            InitializeComponent();
        }

 
        public Form3(Book bookToEdit, int bookId) : this()
        {
            isEditMode = true;
            bookBeingEditedId = bookId;
            NewBook = bookToEdit;  // Assign first!

            txtTitle.Text = NewBook.Title;
            txtAuthor.Text = NewBook.Author;
            txtPrice.Text = NewBook.Price.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
     
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            double price;
            if (!double.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive number.");
                return;
            }

          
            if (isEditMode)
            {
                // Update existing book in edit mode
                NewBook.Id = bookBeingEditedId; // Set the book's ID for update
                NewBook.Title = txtTitle.Text;
                NewBook.Author = txtAuthor.Text;
                NewBook.Price = price;
            }
            else
            {
                // Add a new book
                NewBook = new Book()
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Price = price
                };
            }

       
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel button click event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
