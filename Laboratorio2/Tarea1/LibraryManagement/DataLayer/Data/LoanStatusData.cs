using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class LoanStatusData
    {
        Connection _connection = new Connection();
        DataTable loanStatusTable = new DataTable();
        SqlCommand _sqlCommand = new SqlCommand();
        SqlDataReader _readerRows;
        
        public DataTable GetLoanStatus()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM estadoPrestamo";
            _sqlCommand.CommandType = CommandType.Text;
            _readerRows= _sqlCommand.ExecuteReader();
            loanStatusTable.Load( _readerRows );
            _sqlCommand.Connection = _connection.CloseConnection();
            return loanStatusTable;
        }
    }
}
