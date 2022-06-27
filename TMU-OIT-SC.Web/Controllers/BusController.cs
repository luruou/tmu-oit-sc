using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMU_OIT_SC.Model.ViewModels;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {

        private IShuttleBusService _shuttleBusService;

        public BusController( IShuttleBusService shuttleBusService)
        {
            this._shuttleBusService = shuttleBusService;
        }
        /// <summary>
        /// 接駁車資訊
        /// </summary>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Time/{scID}")]
        public async Task<ShuttleBusViewModel> BusTime(string scID)
        {
            return await this._shuttleBusService.GetAsync(scID);
        }
    }
}
