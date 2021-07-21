using Dapper;
using ProjetoAula.Infra.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Infra.Lib
{
    public class DataCore<TEntity> where TEntity : class
    {
        private SqlConnection _conn = new SqlConnection(ConnectionString.Sql);
        public void Execute(string sql, object model)
        {
            using(var conn = _conn)
            {
                conn.Open();
                conn.Execute(sql, model);
            }
        }
        public IEnumerable<TEntity> Query(string sql, object model)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<TEntity>(sql, model);
            }
        }
        public IEnumerable<TEntity> Query(string sql)
        {
            using (var conn = _conn)
            {
                conn.Open();
                return conn.Query<TEntity>(sql);
            }
        }
    }
}
