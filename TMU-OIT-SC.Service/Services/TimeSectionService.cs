using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class TimeSectionService : ITimeSectionService
    {
        private IDBFactory _db;

        public TimeSectionService(IDBFactory db)
        {
            this._db = db;
        }
        /// <summary>
        /// 取得課表時間
        /// 1	第一節	08:10-09:00	01	08:10	09:00
        /// 2	第二節	09:10-10:00	02	09:10	10:00
        /// 3	第三節	10:10-11:00	03	10:10	11:00
        /// 4	第四節	11:10-12:00	04	11:10	12:00
        /// 5	中午M	12:10-13:00	0M	12:10	13:00
        /// 6	第五節	13:10-14:00	05	13:10	14:00
        /// 7	第六節	14:10-15:00	06	14:10	15:00
        /// 8	第七節	15:10-16:00	07	15:10	16:00
        /// 9	第八節	16:10-17:00	08	16:10	17:00
        /// 10	第九節	17:10-18:00	09	17:10	18:00
        /// 11	第A節	18:20-19:10	0A	18:20	19:10
        /// 12	第B節	19:15-20:05	0B	19:15	20:05
        /// 13	第C節	20:15-21:05	0C	20:15	21:05
        /// 14	第D節	21:10-22:00	0D	21:10	22:00
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TimeSection>> GetTimeSectionAsync()
        {
            string sql = @"
SELECT 
SECTION Section,
SECTION_NAME SectionName, 
TIME_RANGE TimeRange,
INPUT_FORMAT [Format],
SUBSTRING(TIME_RANGE,1,5) [Start],
SUBSTRING(TIME_RANGE,7,5) [End]
FROM [ACERACADEMIC].[TMUDB].[dbo].TKET150
";
            return await this._db.TMUSC().QueryAsync<TimeSection>(sql);
        }
    }
}
