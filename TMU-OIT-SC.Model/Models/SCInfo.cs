using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.Models
{
    public class SCInfo
    {
        /// <summary>
        /// 智慧教室ID
        /// </summary>
        public string SCID { get; set; } = string.Empty;
        /// <summary>
        /// 鄉鎮市區
        /// </summary>
        public string Location { get; set; } = string.Empty;
        /// <summary>
        /// 接駁車路線ID
        /// </summary>
        public int BusRoute { get; set; }
        public string Comment { get; set; } = string.Empty;

    }
}
