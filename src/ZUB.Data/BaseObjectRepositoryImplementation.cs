using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;
using Npgsql;
using System.Data.Common;
using Dapper;

namespace ZUB.Data
{
    public class DapperBORImplementation<T> : IBaseObjectRepository<T> where T : BaseObject
    {
        private DbConnection _dbConn = new NpgsqlConnection(Settings.ConnectionString);
        private Mapping Mapping { get; }

        public DapperBORImplementation(Mapping mapping)
        {
            _dbConn.Open();
            Mapping = mapping;
        }

        public IEnumerable<T> GetAll()
        {
            //_dbConn.Open();

            var ret = _dbConn.Query<T>($"SELECT * FROM \"{typeof(T).Name}\"");
            _dbConn.Close();
            _dbConn.Dispose();
            return ret;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
