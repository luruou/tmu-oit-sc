using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.DB
{
    public interface IDBFactory
    {
        public IApplicationDB Northwind();
        public IApplicationDB TMUSC();
        public IApplicationDB TMUBS();
        public IApplicationDB CardManage();
    }
}
