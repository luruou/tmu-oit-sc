using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class CardService : ICardService
    {

        private IDBFactory _db;

        public CardService(IDBFactory db)
        {
            this._db = db;
        }

        public async Task<string> GetStudentCardIDAsync(string stdNo)
        {
            return await _db.CardManage().QueryFirstAsync<string>("SELECT card_physical_id FROM [CardManage].[dbo].[StdCard_Data] WHERE std_no = @StdNo AND isEzcard_Cancel IS NULL", new { StdNo = stdNo });
        }
    }
}
