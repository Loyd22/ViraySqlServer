using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using digiBookModel;

namespace digiBookDataLayer
{
    public class sqldbdata
    {
        string connectionString = "Data Source=YEL\\SQLEXPRESS;Initial Catalog=Digibook;Integrated Security=True;";

        public List<bookss> GetBooks()
        {
            List<bookss> books = new List<bookss>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string selectStatement = "SELECT Title, Author, Summary FROM Books";
                SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

                sqlConnection.Open();

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string title = reader["Title"].ToString();
                        string author = reader["Author"].ToString();
                        string summary = reader["Summary"].ToString();

                        bookss readBook = new bookss();
                        readBook.title = title;
                        readBook.author = author;
                        readBook.summary = summary;

                        books.Add(readBook);
                    }
                }
            }

            return books;
        }
    }
}

