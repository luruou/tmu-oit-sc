using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TMU_OIT_SC.Model.DB
{
    public class SqlDB : IApplicationDB
    {
        public string ConnectionString { get; set; }

        public SqlDB(string conectionString)
        {
            this.ConnectionString = conectionString;
        }

        public int Execute(object transaction, string sql, object param = null)
        {
            return ((SqlTransaction)transaction).Connection.Execute(sql, param, (SqlTransaction)transaction);
        }

        public int Execute(string sql, object param = null)
        {
            try
            {
                int result;
                using (SqlConnection conn = new(this.ConnectionString))
                {
                    result = conn.Execute(sql, param);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exit(string sql, object param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string sql, object param = null)
        {

            try
            {
                IEnumerable<T> result;
                using (SqlConnection conn = new(this.ConnectionString))
                {
                    result = conn.Query<T>(sql, param);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T QueryFirst<T>(string sql, object param = null)
        {
            try
            {
                T result;
                using (SqlConnection conn = new(this.ConnectionString))
                {
                    result = conn.QueryFirstOrDefault<T>(sql, param);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<bool> ExitAsync(string sql, object param = null)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null)
        {
            try
            {
                IEnumerable<T> result;
                using (SqlConnection conn = new(this.ConnectionString))
                {
                    result = await conn.QueryAsync<T>(sql, param);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> QueryFirstAsync<T>(string sql, object param = null)
        {
            try
            {
                T result;
                using (SqlConnection conn = new(this.ConnectionString))
                {
                    result = await conn.QueryFirstOrDefaultAsync<T>(sql, param);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> ExecuteAsync(string sql, object param = null)
        {
            try
            {
                int result;
                using (SqlConnection conn = new(this.ConnectionString))
                {
                    result = await conn.ExecuteAsync(sql, param);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> ExecuteAsync(object transaction, string sql, object param = null)
        {
            var result = await ((SqlTransaction)transaction).Connection.ExecuteAsync(sql, param, (SqlTransaction)transaction);
            return result;
        }
    }
}
