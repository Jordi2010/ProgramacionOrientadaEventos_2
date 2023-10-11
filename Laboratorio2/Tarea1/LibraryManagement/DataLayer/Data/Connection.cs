﻿using System;
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
        SqlConnection _connection = new SqlConnection( /*la conexion va aqui*/ );

         public SqlConnection OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)  
            _connection.Open();
            return _connection;
        }

        public SqlConnection CloseConnection()
        {
            if(_connection.State == ConnectionState.Open)
                _connection.Close();
            return _connection;
        }

    }
}
