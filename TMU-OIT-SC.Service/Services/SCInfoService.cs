using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.ViewModels;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class SCInfoService : ISCInfoService
    {

        private IDBFactory _db;
        public SCInfoService(IDBFactory db)
        {
            this._db = db;
        }
        public async Task<SCInfoViewModel> GetAsync(string scID)
        {
            var model = await this._db.TMUSC().QueryFirstAsync<SCInfoViewModel>(@"SELECT S.*, T.COS_ROOMNAME [Name], T.COS_ROOMNAME_E NameE, T.place_id PlaceID FROM [TMUSC].[dbo].[SCInfo] S
LEFT JOIN [ACERACADEMIC].[TMUDB].[dbo].TKET015 T ON T.CLSSRM_ID = S.SCID
WHERE SCID = @SCID ", new { SCID = scID });

            model.WebAPIs = await this._db.TMUSC().QueryAsync<SCWebAPIViewModel>(@"SELECT * FROM [TMUSC].[dbo].[SCWebAPI] WHERE SCID = @SCID ", new { SCID = scID });


            return model;
        }

        public async Task<IEnumerable<SCInfoViewModel>> GetAllAsync()
        {
            return await this._db.TMUSC().QueryAsync<SCInfoViewModel>(@"SELECT S.*, T.COS_ROOMNAME [Name], T.COS_ROOMNAME_E NameE, T.place_id PlaceID FROM [TMUSC].[dbo].[SCInfo] S
LEFT JOIN [ACERACADEMIC].[TMUDB].[dbo].TKET015 T ON T.CLSSRM_ID = S.SCID");
        }
    }
}
