using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;


namespace BookshopManagementSystem
{
    public static class Database
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        public static List<Book> GetBooks()
        {
            {
                List<Book> books = new List<Book>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Books";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Id = Convert.ToInt32(reader["Id"]), // ✅ Add this line
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                            Price = Convert.ToDouble(reader["Price"])
                        });
                    }
                }
                return books;
            }
        }

        public static void AddBook(Book book)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Books (Title, Author, Price) VALUES (@Title, @Author, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Price", book.Price);

                conn.Open(); cmd.ExecuteNonQuery();
                // no need to return anything here
            }
        }

        public static void UpdateBook(Book book, int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Books SET Title = @Title, Author = @Author, Price = @Price WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteBook(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Start the transaction
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    // Delete the book
                    string deleteQuery = "DELETE FROM Books WHERE Id = @Id";
                    SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn, transaction);
                    cmdDelete.Parameters.AddWithValue("@Id", id);
                    cmdDelete.ExecuteNonQuery();

                    // Reset the auto-increment ID
                    string resetIdentityQuery = "DBCC CHECKIDENT('Books', RESEED, 0)";
                    SqlCommand cmdResetIdentity = new SqlCommand(resetIdentityQuery, conn, transaction);
                    cmdResetIdentity.ExecuteNonQuery();

                    // Commit the transaction
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message);
                }
            }
        }

    }
}