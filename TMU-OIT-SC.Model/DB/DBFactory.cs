using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.DB
{
    public class DBFactory : IDBFactory
    {
        private readonly IConfiguration _configuration;
        public DBFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IApplicationDB Northwind()
        {
            return new SqlDB(_configuration.GetConnectionString("Northwind"));
        }

        public IApplicationDB TMUSC()
        {
            return new SqlDB(_configuration.GetConnectionString("TMUSC"));
        }
        public IApplicationDB TMUBS()
        {
            return new SqlDB(_configuration.GetConnectionString("TMUBS"));
        }

        public IApplicationDB CardManage()
        {
            return new SqlDB(_configuration.GetConnectionString("CardManage"));
        }
    }
}
