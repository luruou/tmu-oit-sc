using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private IAttendanceService _classAttendanceService;
        public AttendanceController(IAttendanceService classAttendanceService)
        {
            this._classAttendanceService = classAttendanceService;
        }


        [HttpPost]
        [Route("Sign")]
        public async Task Sign([FromBody] Attendance value)
        {
            //foreach (var value in values)
                await this._classAttendanceService.CreateAsync(value);
        }
    }
}
