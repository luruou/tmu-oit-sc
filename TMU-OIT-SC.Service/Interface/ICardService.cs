using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Service.Interface
{
    public interface ICardService
    {
        public Task<string> GetStudentCardIDAsync(string stdNo);
    }
}
