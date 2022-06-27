using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Model.ViewModels;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SCController : ControllerBase
    {
        private ISCInfoService _scInfoService;
        private IEventService _eventService;

        public SCController(ISCInfoService scInfoService, IEventService eventService)
        {
            this._scInfoService = scInfoService;
            this._eventService = eventService;
        }
        /// <summary>
        /// 所有教室列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("List")]
        public async Task<IEnumerable<SCInfoViewModel>> List()
        {
            return await this._scInfoService.GetAllAsync();
        }

        /// <summary>
        /// 教室詳細內容
        /// </summary>
        /// <param name="scID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Detail/{scID}")]
        public async Task<SCInfoViewModel> Detail(string scID)
        {
            return await this._scInfoService.GetAsync(scID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Event")]
        public async Task<IEnumerable<EventViewModel>> Event([FromBody] EventParameter value)
        {
            return await this._eventService.GetAsync(value.SCID, value.Date);
        }



        public class EventParameter
        {
            public string SCID { get; set; } = string.Empty;
            public DateTime Date { get; set; }
        }
    }
}
