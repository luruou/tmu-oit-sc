using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Model.ViewModels;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class ShuttleBusService : IShuttleBusService
    {
        private IDBFactory _db;
        public ShuttleBusService(IDBFactory db)
        {
            this._db = db;
        }

        public async Task<ShuttleBusViewModel> GetAsync(string scID)
        {
            ShuttleBusViewModel model = await this._db.TMUSC().QueryFirstAsync<ShuttleBusViewModel>(@"SELECT b.*
  FROM[TMUSC].[dbo].[SCInfo] s JOIN[TMUSC].[dbo].[ShuttleBusRoute] b
  ON s.BusRoute = b.ID WHERE s.SCID = @SCID", new { SCID = scID });
            model.Times = (await this._db.TMUSC().QueryAsync<ShuttleBusTime>("SELECT * FROM [TMUSC].[dbo].[ShuttleBusTime] WHERE [RouteID] = @RouteID", new { RouteID = model.ID })).ToList();

            return model;
        }

        public Task<IEnumerable<ShuttleBusTime>> GetTimesAsync(int route)
        {
            return this._db.TMUSC().QueryAsync<ShuttleBusTime>("SELECT * FROM [TMUSC].[dbo].[ShuttleBusTime] WHERE [Route] = @Route", new { Route = route });
        }
    }
}
