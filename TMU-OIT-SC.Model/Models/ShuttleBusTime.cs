using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.Models
{
    public class ShuttleBusTime
    {
        public int ID { get; set; }
        public int RouteID { get; set; }
        public string Time { get; set; } = string.Empty;
        public int WeekDay { get; set; }
    }
}
