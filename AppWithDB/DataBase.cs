﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppWithDB
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = CARAT; Initial Catalog = demoPractice; Integrated Security = True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) { sqlConnection.Open(); }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) { sqlConnection.Close(); }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection; 
        }
    }
}
