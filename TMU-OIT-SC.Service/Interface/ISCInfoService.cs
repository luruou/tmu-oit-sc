using TMU_OIT_SC.Model.ViewModels;

namespace TMU_OIT_SC.Service.Interface
{
    public interface ISCInfoService
    {
        public Task<SCInfoViewModel> GetAsync(string scID);
        public Task<IEnumerable<SCInfoViewModel>> GetAllAsync();
    }
}
