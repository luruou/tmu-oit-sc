using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.Models
{
    public class BorrowInfo
    {
        public string BorrowID { get; set; } = string.Empty;
        public DateTime BorrowDate { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserID { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public string UnitID { get; set; } = string.Empty;
        public int PlaceID { get; set; }
        public string Content { get; set; } = string.Empty;
        public string Memo { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;
        public string PlaceName { get; set; } = string.Empty;
        public int PlaceAreaID { get; set; }
        public string PlaceAreaName { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string StatusName { get; set; } = string.Empty;
    }
}
