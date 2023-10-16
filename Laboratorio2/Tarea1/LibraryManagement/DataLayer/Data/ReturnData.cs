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
    public class ReturnData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable booksTable = new DataTable();

        public DataTable GetAllReturn()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "select d.idDevoluciones, p.clientePrestamo, l.nombreLibro,  d.fechaDevolucionReal, d.idPrestamo from devoluciones as d\r\ninner join prestamos as p on d.idPrestamo = p.idPrestamo\r\ninner join libros as l on p.idLibro = l.idLibro";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

     
        public void AddReturn(Return Return)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Devoluciones ( idPrestamo, FechaDevolucionReal) " +
                                      "VALUES ( @IdLoan, @ActualReturnDate)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdLoan", Return.IdLoan);
            _sqlCommand.Parameters.AddWithValue("@ActualReturnDate", Return.ActualReturnDate);


            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void UpdateReturn(Return Return)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE Devoluciones " +
                                      "SET FechaDevolucionEstimada = @EstimatedReturnDate, FechaDevolucionReal = @ActualReturnDate";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@EstimatedReturnDate", Return.IdLoan);
            _sqlCommand.Parameters.AddWithValue("@ActualReturnDate", Return.ActualReturnDate);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeleteReturn(Return Return)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM devoluciones WHERE idDevoluciones  = @Id";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Id", Return.IdReturn);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
    }


}
