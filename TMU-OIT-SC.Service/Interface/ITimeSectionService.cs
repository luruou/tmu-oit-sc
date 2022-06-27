using TMU_OIT_SC.Model.Models;

namespace TMU_OIT_SC.Service.Interface
{
    public interface ITimeSectionService
    {
        public Task<IEnumerable<TimeSection>> GetTimeSectionAsync();
    }
}
