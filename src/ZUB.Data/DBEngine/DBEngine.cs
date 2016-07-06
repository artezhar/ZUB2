using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;
using Dapper;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Data
{
    public class DBEngine
    {
        private IDbConnection db_conn;
        public string DatabaseName { get { return db_conn?.Database; } }

        public DBEngine(string connectionString, DbType dbType = DbType.POSTGRES)//переделать так, чтоб не линковать ВСЕГДА npgsql
        {
            switch (dbType)
            {
                case DbType.POSTGRES:
                    {
                        db_conn = new NpgsqlConnection(connectionString);
                        break;
                    }
                default: { throw new NotImplementedException(); }
            }
        }



    }
}
