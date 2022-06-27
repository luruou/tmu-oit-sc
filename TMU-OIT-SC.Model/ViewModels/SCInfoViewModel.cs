using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.ViewModels
{
    public class SCInfoViewModel
    {
        /// <summary>
        /// 智慧教室ID
        /// </summary>
        public string SCID { get; set; } = string.Empty;

        /// <summary>
        /// 教室名稱
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// 教室名稱(English)
        /// </summary>
        public string NameE { get; set; } = string.Empty;
        /// <summary>
        /// 鄉鎮市區
        /// </summary>
        public string Location { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        /// <summary>
        /// 場地借用ID
        /// </summary>
        public int PlaceID { get; set; }
        /// <summary>
        /// 接駁車路線ID
        /// </summary>
        public int BusRoute { get; set; }


        public IEnumerable<SCWebAPIViewModel> WebAPIs { get; set; } = new List<SCWebAPIViewModel>();  
    }

    public class SCWebAPIViewModel
    {
        public string APIKey { get; set; } = string.Empty;
        public string APIUrl { get; set; } = string.Empty;
        public string APIParameter { get; set; } = string.Empty;
 
    }

}
