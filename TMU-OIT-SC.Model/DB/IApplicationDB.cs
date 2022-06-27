using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.DB
{
    public interface IApplicationDB
    {
        public string ConnectionString { get; set; }
        public bool Exit(string sql, object param = null);
        public Task<bool> ExitAsync(string sql, object param = null);
        public IEnumerable<T> Query<T>(string sql, object param = null);
        public Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null);
        public T QueryFirst<T>(string sql, object param = null);
        public Task<T> QueryFirstAsync<T>(string sql, object param = null);
        public int Execute(string sql, object param = null);
        public Task<int> ExecuteAsync(string sql, object param = null);
        public int Execute(object transaction, string sql, object param = null);
        public Task<int> ExecuteAsync(object transaction, string sql, object param = null);
    }
}
