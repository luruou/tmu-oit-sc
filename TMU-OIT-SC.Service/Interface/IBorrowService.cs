using TMU_OIT_SC.Model.Models;

namespace TMU_OIT_SC.Service.Interface
{
    public interface IBorrowService
    {
        public Task<IEnumerable<BorrowInfo>> GetBorrowInfoAsync(string scID, DateTime date);
    }
}
