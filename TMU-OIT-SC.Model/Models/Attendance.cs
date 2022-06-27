using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.Models
{
    public class Attendance
    {
        public string EventID { get; set; } = string.Empty;
        public int EventType { get; set; }
        public string UserID { get; set; } = string.Empty;
        public DateTime SignDateTime { get; set; }
        public bool SignIn { get; set; } 
    }
}
