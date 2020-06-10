using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreDapperSample.Database
{
    public class DBHelper : IDBHelper
    {
        private string connectionString;

        public DBHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbConnection OpenConnection()
        {
            var cn = new NpgsqlConnection(connectionString);
            return cn;
        }
    }
}
