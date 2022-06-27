using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.DB
{
    public class OracleDB : IApplicationDB
    {
        public string ConnectionString { get; set; }

        public OracleDB(string conectionString)
        {
            this.ConnectionString = conectionString;
        }
        public int Execute(object transaction, string sql, object param = null)
        {
            throw new NotImplementedException();
            //return ((OracleTransaction)transaction).Connection.Execute(sql, param, (OracleTransaction)transaction);
        }

        public int Execute(string sql, object param = null)
        {
            throw new NotImplementedException();
            //try
            //{
            //    int result;
            //    using (OracleConnection conn = new OracleConnection(this.ConnectionString))
            //    {
            //        result = conn.Execute(sql, param);
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public bool Exit(string sql, object param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string sql, object param = null)
        {
            throw new NotImplementedException();
            //try
            //{
            //    IEnumerable<T> result;
            //    using (OracleConnection conn = new OracleConnection(this.ConnectionString))
            //    {
            //        result = conn.Query<T>(sql, param);
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public T QueryFirst<T>(string sql, object param = null)
        {
            throw new NotImplementedException();
            //try
            //{
            //    T result;
            //    using (OracleConnection conn = new OracleConnection(this.ConnectionString))
            //    {
            //        result = conn.QueryFirstOrDefault<T>(sql, param);
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public Task<bool> ExitAsync(string sql, object param = null)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null)
        {
            throw new NotImplementedException();
            //try
            //{
            //    IEnumerable<T> result;
            //    using (OracleConnection conn = new OracleConnection(this.ConnectionString))
            //    {
            //        result = await conn.QueryAsync<T>(sql, param);
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public async Task<T> QueryFirstAsync<T>(string sql, object param = null)
        {
            throw new NotImplementedException();
            //try
            //{
            //    T result;
            //    using (OracleConnection conn = new OracleConnection(this.ConnectionString))
            //    {
            //        result = await conn.QueryFirstOrDefaultAsync<T>(sql, param);
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public async Task<int> ExecuteAsync(string sql, object param = null)
        {
            throw new NotImplementedException();
            //try
            //{
            //    int result;
            //    using (OracleConnection conn = new OracleConnection(this.ConnectionString))
            //    {
            //        result = await conn.ExecuteAsync(sql, param);
            //    }
            //    return result;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public async Task<int> ExecuteAsync(object transaction, string sql, object param = null)
        {
            throw new NotImplementedException();
            //var result = await ((OracleTransaction)transaction).Connection.ExecuteAsync(sql, param, (OracleTransaction)transaction);
            //return result;
        }
    }
}
