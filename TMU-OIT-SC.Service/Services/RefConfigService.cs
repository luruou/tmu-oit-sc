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
    public class RefConfigService : IRefConfigService
    {

        private IDBFactory _db;

        public RefConfigService(IDBFactory db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<RefConfig>> GetConfigAsync(string type)
        {
            return await _db.TMUSC().QueryAsync<RefConfig>("SELECT [ConfigType],[Key],[Value] FROM [TMUSC].[dbo].[RefConfig] WHERE ConfigType = @ConfigType", new { ConfigType = type });
        }

        public async Task<RefConfig> GetWeatherValueAsync(string key)
        {
            return await _db.TMUSC().QueryFirstAsync<RefConfig>(@"SELECT [ConfigType],[Key],[Value] FROM [TMUSC].[dbo].[RefConfig] WHERE ConfigType = 'Weather' AND [Key] = @key", new { Key = key });
        }
    }
}
