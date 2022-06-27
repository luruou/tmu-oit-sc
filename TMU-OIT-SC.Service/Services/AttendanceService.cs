using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class AttendanceService : IAttendanceService
    {
        private IDBFactory _db;

        public AttendanceService(IDBFactory db)
        {
            this._db = db;
        }
        public async Task<int> CreateAsync(Attendance attendance)
        {
            return await _db.TMUSC().ExecuteAsync(@"INSERT INTO [dbo].[Attendance]
           ([EventID],[EventType],[UserID],[SignDateTime],[SignIn], [CreatedDate])
     VALUES 
 (@EventID,@EventType,@UserID,@SignDateTime,@SignIn, getdate())", attendance);
        }
    }
}
