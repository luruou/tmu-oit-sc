using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMU_OIT_SC.Model.Enum;

namespace TMU_OIT_SC.Model.ViewModels
{
    public class EventViewModel
    {
        public string EventID { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string ContentE { get; set; } = string.Empty;
        public string Memo { get; set; } = string.Empty;
        public string MemoE { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
        public string ReasonE { get; set; } = string.Empty;
        /// <summary>
        /// 場地狀態
        /// </summary>
        public int Status { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string StatusNameE { get; set; } = string.Empty;

        [EnumDataType(typeof(EventType))]
        public EventType Type { get; set; }


        /// <summary>
        /// 節次順序
        /// </summary>
        public int Section { get; set; }
        /// <summary>
        /// 課堂節次名稱
        /// </summary>
        public string SectionName { get; set; } = string.Empty;
        /// <summary>
        /// 節次代碼
        /// </summary>
        public string Format { get; set; } = string.Empty;
        /// <summary>
        /// 時段
        /// </summary>
        public string TimeRange { get; set; } = string.Empty;
        /// <summary>
        /// 課堂起始時間
        /// </summary>
        public string Start { get; set; } = string.Empty;
        /// <summary>
        /// 課堂結束時間
        /// </summary>
        public string End { get; set; } = string.Empty;

        public string SignInStart { get; set; } = string.Empty;
        public string SignInEnd { get; set; } = string.Empty;
        public string SignOutStart { get; set; } = string.Empty;
        public string SignOutEnd { get; set; } = string.Empty;


        public List<EventUserViewModel> Users { get; set; } = new List<EventUserViewModel>();
        public List<EventUserViewModel> SubUsers { get; set; } = new List<EventUserViewModel>();


        //public string Smtr { get; set; } = string.Empty;
        //public string CosID { get; set; } = string.Empty;
        //public string ClassID { get; set; } = string.Empty;
    }

    public class EventUserViewModel
    {
        public string UserID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string NameE { get; set; } = string.Empty;
        public string ImageBase64 { get; set; } = string.Empty;
        public string CardID { get; set; } = string.Empty;
    }
}
