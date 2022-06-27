using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private IRefConfigService _configService;
        public ConfigController(IRefConfigService configService)
        {
            this._configService = configService;
        }


        [HttpGet]
        [Route("Weather/{key}")]
        public async Task<RefConfig> Weather(string key)
        {
            //foreach (var value in values)
            return await this._configService.GetWeatherValueAsync(key);
        }


    }
}
