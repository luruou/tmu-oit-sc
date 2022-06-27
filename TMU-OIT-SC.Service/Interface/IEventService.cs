using TMU_OIT_SC.Model.ViewModels;

namespace TMU_OIT_SC.Service.Interface
{
    public interface IEventService
    {
        public Task<IEnumerable<EventViewModel>> GetAsync(string scID);
        public Task<IEnumerable<EventViewModel>> GetAsync(string scID,DateTime date);
    }
}
