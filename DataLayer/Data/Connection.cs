using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class Connection
    {
        private SqlConnection _connection = new SqlConnection(@"aqui la coonexion");

        public SqlConnection OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();

            return _connection;
        }

        public SqlConnection CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();

            return _connection;
        }
    }
}
