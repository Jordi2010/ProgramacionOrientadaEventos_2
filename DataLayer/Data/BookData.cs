using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class BookData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable booksTable = new DataTable();

        public DataTable GetAllBook()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM Libros";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public void AddBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Libros ( Editorial, Titulo, Isbn, Genero) " +
                                      "VALUES ( @Publisher, @Title, @Isbn, @Genre)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
            _sqlCommand.Parameters.AddWithValue("@Title", book.Title);
            _sqlCommand.Parameters.AddWithValue("@Isbn", book.Isbn);
            _sqlCommand.Parameters.AddWithValue("@Genre", book.Genre);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void UpdateBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE Libros " +
                                      "SET Editorial = @Publisher, Titulo = @Title, Isbn = @Isbn, Genero = @Genre, id_autor = @IdAuthor, id_estado = @IdStatus " +
                                      "WHERE id_libro = @IdBook";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
            _sqlCommand.Parameters.AddWithValue("@Title", book.Title);
            _sqlCommand.Parameters.AddWithValue("@Isbn", book.Isbn);
            _sqlCommand.Parameters.AddWithValue("@Genre", book.Genre);
            _sqlCommand.Parameters.AddWithValue("@IdAuthor", book.IdAuthor);
            _sqlCommand.Parameters.AddWithValue("@IdStatus", book.IdStatus);
            _sqlCommand.Parameters.AddWithValue("@IdBook", book.IdBook);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void DeleteBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM Libros WHERE id_libro = @Id";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Id", book.IdBook);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

    }
}
