using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using digiBookModel;

namespace digiBookDataLayer
{
    public class sqldbdata
    {
        private static string connectionString = "Data Source=YEL\\SQLEXPRESS;Initial Catalog=Digibook;Integrated Security=True;";

        public static List<bookss> GetBooksFromDatabase()
        {
            List<bookss> books = new List<bookss>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Title, Author, Summary FROM Books";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookss book = new bookss
                        {
                            title = reader["Title"].ToString(),
                            author = reader["Author"].ToString(),
                            summary = reader["Summary"].ToString()
                        };
                        books.Add(book);
                    }
                }
            }

            return books;
        }
    }
}
