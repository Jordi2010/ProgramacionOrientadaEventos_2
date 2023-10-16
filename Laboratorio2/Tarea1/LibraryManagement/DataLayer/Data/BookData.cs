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
            _sqlCommand.CommandText = "SELECT l.idLibro, l.editorialLibro, l.nombreLibro, l.isbnLibro, l.generoLibro, a.nombre, s.estadoLibro, l.idAutor, l.idestadoLibro " +
                "FROM libros as l inner join autores as a on l.idAutor = a.idAutor " +
                "inner join estadoLibro as s on l.idestadoLibro = s.idestadoLibro";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable getFilterBook() {
            DataTable bookFilterTable = new DataTable();
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM libros where idestadoLibro = 1";
            _sqlCommand.CommandType= CommandType.Text;
            _readerRows= _sqlCommand.ExecuteReader();
            bookFilterTable.Load(_readerRows);
            _sqlCommand.Connection = _connection.CloseConnection();

            return bookFilterTable;
        }

        public void AddBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO libros (editorialLibro, nombreLibro, isbnLibro, generoLibro, idAutor, idestadoLibro) " +
                                      "VALUES ( @Publisher, @Title, @Isbn, @Genre, @idAutor,@idestadoLibro)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
            _sqlCommand.Parameters.AddWithValue("@Title", book.Title);
            _sqlCommand.Parameters.AddWithValue("@Isbn", book.Isbn);
            _sqlCommand.Parameters.AddWithValue("@Genre", book.Genre);

            _sqlCommand.Parameters.AddWithValue("@idAutor", book.IdAuthor);
            _sqlCommand.Parameters.AddWithValue("@idestadoLibro", book.IdStatus);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void UpdateBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE libros SET editorialLibro = @Publisher, nombreLibro = @Title, isbnLibro = @Isbn, generoLibro = @Genre, idAutor = @IdAuthor, idestadoLibro = @IdStatus WHERE idLibro = @IdBook";
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
        public void UpdateBookStatus(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE libros SET  idestadoLibro = @IdStatus WHERE idLibro = @IdBook";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdStatus", book.IdStatus);
            _sqlCommand.Parameters.AddWithValue("@IdBook", book.IdBook);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void DeleteBook(Book book)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM Libros WHERE idLibro = @Id";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Id", book.IdBook);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

    }
}
