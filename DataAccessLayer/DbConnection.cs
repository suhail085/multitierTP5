using CommanLayer.Models;
using Microsoft.Data.SqlClient;
using System;

namespace DataAccessLayer
{
    public class DbConnection
    {
        public SqlConnection cnn;
        public DbConnection()
        {
            cnn = new SqlConnection(Connection.Connectionstr);
        }
    }
}
