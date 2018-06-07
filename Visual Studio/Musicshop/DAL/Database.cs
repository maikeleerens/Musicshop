using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Musicshop.DAL
{
    public class Database
    {
        private static readonly string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\musicshop.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionstring);

                return connection;
            }
        }
    }
}