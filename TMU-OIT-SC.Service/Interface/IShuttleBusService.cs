using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Model.ViewModels;

namespace TMU_OIT_SC.Service.Interface
{
    public interface IShuttleBusService
    {
        public Task<ShuttleBusViewModel> GetAsync(string scID);
    }
}
