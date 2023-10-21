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
    public class LoanData
    {
        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable booksTable = new DataTable();

        public DataTable GetAllLoan()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "select p.idPrestamo, l.nombreLibro, p.clientePrestamo,ep.estadoPrestamo, p.fechaDevolucionEstimada, p.fechaPrestamo, p.idLibro, p.idestadoPrestamo from prestamos as p\r\ninner join estadoPrestamo as ep on p.idestadoPrestamo = ep.idestadoPrestamo\r\ninner join libros as l on p.idLibro = l.idLibro";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable GetClientNameByLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT p.idPrestamo, l.nombreLibro, p.clientePrestamo, ep.estadoPrestamo FROM prestamos AS p " +
                                    "INNER JOIN estadoPrestamo AS ep ON p.idestadoPrestamo = ep.idestadoPrestamo " +
                                    "INNER JOIN libros AS l ON p.idLibro = l.idLibro " +
                                    "WHERE p.idPrestamo = @IdLoan";

            _sqlCommand.CommandType = CommandType.Text;

            // Crea un parámetro para el ID del préstamo
            SqlParameter idLoanParam = new SqlParameter("@IdLoan", loan.IdLoan);
            idLoanParam.Value = loan.IdLoan;
            _sqlCommand.Parameters.Add(idLoanParam);

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public DataTable GetFilterLoan()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "select p.idPrestamo, l.nombreLibro, p.clientePrestamo,ep.estadoPrestamo, p.fechaDevolucionEstimada, p.fechaPrestamo, p.idLibro, p.idestadoPrestamo from prestamos as p\r\ninner join estadoPrestamo as ep on p.idestadoPrestamo = ep.idestadoPrestamo\r\ninner join libros as l on p.idLibro = l.idLibro where p.idestadoPrestamo = 2 ";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            booksTable.Load(_readerRows);

            _connection.CloseConnection();

            return booksTable;
        }

        public void AddLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Prestamos (idLibro,clientePrestamo, fechaPrestamo, fechaDevolucionEstimada,idestadoPrestamo) " +
                                      "VALUES (@IdBook, @Customer, @LoanDate,@ReturnEstimatedDate,@IdLoanStatus)";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdBook", loan.IdBook);
            _sqlCommand.Parameters.AddWithValue("@Customer", loan.Customer);
            _sqlCommand.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
            _sqlCommand.Parameters.AddWithValue("@ReturnEstimatedDate", loan.ReturnEstimatedDate);
            _sqlCommand.Parameters.AddWithValue("@IdLoanStatus", loan.IdLoanStatus);


            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();

        }

        public void UpdateLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE Prestamos " +
                                      "SET Cliente = @Customer, FechaPrestamo = @LoanDate";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Customer", loan.Customer);
            _sqlCommand.Parameters.AddWithValue("@LoanDate", loan.LoanDate);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void UpdateStatusLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "update prestamos set idestadoPrestamo = @IdLoanStatus where idPrestamo = @IdLoan";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@IdLoanStatus", loan.IdLoanStatus);
            _sqlCommand.Parameters.AddWithValue("@IdLoan", loan.IdLoan);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();

        }

        public void DeleteLoan(Loan loan)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM Prestamos WHERE idPrestamo = @Id";
            _sqlCommand.CommandType = CommandType.Text;

            _sqlCommand.Parameters.AddWithValue("@Id", loan.IdLoan);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}
