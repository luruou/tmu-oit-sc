using TMU_OIT_SC.Model.Models;

namespace TMU_OIT_SC.Service.Interface
{
    public interface IClassService
    {

        public Task<IEnumerable<ClassInfo>> GetClassInfoAsync(string scID, DateTime date);

        //public Stream GetTeacherPhoto(string empID);
    }
}
