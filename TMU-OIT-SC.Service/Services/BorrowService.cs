using AutoMapper;
using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class BorrowService : IBorrowService
    {
        private IDBFactory _db;

        public BorrowService(IDBFactory db)
        {
            this._db = db;
        }

        /// <summary>
        /// 取得場地借用資訊
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task<IEnumerable<BorrowInfo>> GetBorrowInfoAsync(string scID, DateTime date)
        {
            string sql = @"SELECT 
M.borrow_id BorrowID,
M.borrow_date BorrowDate,
M.user_name UserName,
M.user_id UserID,
M.user_email UserEmail,
M.unit_id UnitID,
M.place_id PlaceID,
M.borrow_content Content,
M.memo Memo,
M.thesection Section,
p.place_name PlaceName,
pa.place_area_id PlaceAreaID,
pa.place_area_name PlaceAreaName,
br.borrow_reason Reason, 
M.status Status,
bs.statusname StatusName
FROM  dbo.borrow_M AS M LEFT OUTER JOIN
dbo.place AS p ON p.place_id = M.place_id LEFT OUTER JOIN
dbo.place_area AS pa ON pa.place_area_id = p.place_area_id LEFT OUTER JOIN
dbo.borrow_status AS bs ON M.status = bs.statusid LEFT OUTER JOIN
dbo.borrow_reason AS br ON br.borrow_reason_id = M.borrow_reason_id LEFT OUTER JOIN
[ACERACADEMIC].[TMUDB].[dbo].TKET015 t ON M.place_id = t.place_id
WHERE bs.statusid in (2,3,7,9)
  AND t.CLSSRM_ID = @SCID AND borrow_date = @DATE";
            return await this._db.TMUBS().QueryAsync<BorrowInfo>(sql, new { SCID = scID, DATE = date.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") });
        }
    }
}
