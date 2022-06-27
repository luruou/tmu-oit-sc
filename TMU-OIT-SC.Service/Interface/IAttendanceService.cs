using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMU_OIT_SC.Model.Models;

namespace TMU_OIT_SC.Service.Interface
{
    public interface IAttendanceService
    {
        public Task<int> CreateAsync(Attendance attendance);
    }
}
