using System.Collections.Generic;
using api.interfaces;
using api.models;
using MySql.Data.MySqlClient;

namespace api.database
{
    public class ReadBook
    {
        public List<Book> GetAllBooks()
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();
            string stm = "SELECT * FROM books";
            MySqlCommand cmd = new MySqlCommand(stm, con);

            List<Book> allBooks = new List<Book>();
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    allBooks.Add(new Book() { Id = rdr.GetInt32(0), Title = rdr.GetString(1), Author = rdr.GetString(2) });
                }

            }
            con.Close();
            return allBooks;
        }
    }
}