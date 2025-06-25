using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;


namespace BookshopManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RefreshGrid();

        }
        private static List<Book> books = new List<Book>();

        private void RefreshGrid()
        {
            try
            {
                List<Book> books = Database.GetBooks(); // Always fetch fresh list
                dgvBooks.DataSource = null;
                dgvBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form3 addForm = new Form3();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Database.AddBook(addForm.NewBook); // Add new book to DB
                RefreshGrid();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.CurrentRow != null && dgvBooks.CurrentRow.DataBoundItem is Book selectedBook)
                {
                    Form3 editForm = new Form3(selectedBook, selectedBook.Id);

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        Database.UpdateBook(editForm.NewBook, selectedBook.Id);
                        RefreshGrid(); // Refresh DataGridView
                        MessageBox.Show("Book updated successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing: " + ex.Message);
            }
        }



        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.CurrentRow != null && dgvBooks.CurrentRow.DataBoundItem is Book selectedBook)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Database.DeleteBook(selectedBook.Id);
                        RefreshGrid(); // Refresh DataGridView
                        MessageBox.Show("Book deleted successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting: " + ex.Message);
            }
        }

        private DialogResult ShowConfirmationDialog(string message)
        {
            return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnOpenCart_Click(object sender, EventArgs e)
        {
            {
                Form4 cartForm = new Form4();
                cartForm.ShowDialog(); // or cartForm.Show() if you want it non-blocking
            }
        }

    }
}
