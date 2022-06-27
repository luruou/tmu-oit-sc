using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMU_OIT_SC.Model.Models;

namespace TMU_OIT_SC.Model.ViewModels
{
    public class ShuttleBusViewModel
    {
        public int ID { get; set; }
        public string RouteName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<ShuttleBusTime> Times { get; set; } = new List<ShuttleBusTime>();
    }
}
