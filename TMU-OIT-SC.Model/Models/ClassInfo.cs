using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.Models
{
    public class ClassInfo
    {
        /// <summary>
        /// 教室代碼
        /// </summary>
        public string SCID { get; set; } = string.Empty;
        /// <summary>
        /// 週次
        /// </summary>
        public string Weeks { get; set; } = string.Empty;
        /// <summary>
        /// 日期
        /// </summary>
        public string ClsDate { get; set; } = string.Empty;
        /// <summary>
        /// 星期
        /// </summary>
        public string Week { get; set; } = string.Empty;
        /// <summary>
        /// 學年期
        /// </summary>
        public string Smtr { get; set; } = string.Empty;
        /// <summary>
        /// 課號
        /// </summary>
        public string CosID { get; set; } = string.Empty;
        /// <summary>
        /// 班別
        /// </summary>
        public string ClassID { get; set; } = string.Empty;
        /// <summary>
        /// 中文課名
        /// </summary>
        public string Lesson { get; set; } = string.Empty;
        /// <summary>
        /// 授課主題
        /// </summary>
        public string TeachTheme { get; set; } = string.Empty;
        public string TeachThemeE { get; set; } = string.Empty;
        /// <summary>
        /// 授課大綱
        /// </summary>
        public string TeachScheme { get; set; } = string.Empty;
        public string TeachSchemeE { get; set; } = string.Empty;
        /// <summary>
        /// 課堂時間
        /// 1 08:00	
        /// 2 09:00	
        /// 3 10:00	
        /// 4 11:00
        /// 5 12:00	
        /// 6 13:00	
        /// 7 14:00	
        /// 8 15:00	
        /// 9 16:00	
        ///10 17:00	
        ///11 18:00	
        ///12 19:00	
        ///13 20:00	
        ///14 21:00
        /// </summary>
        public int Section { get; set; }
        /// <summary>
        /// 週次
        /// </summary>
        public int Seq { get; set; }

        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Student> Students { get; set; } = new List<Student>();

    }

    public class Teacher
    {
        public string ID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string NameE { get; set; } = string.Empty;
        public string ImageBase64 { get; set; } = string.Empty;
    }

    public class Student
    {
        public string StdNo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string NameE { get; set; } = string.Empty;

        public string CardID { get; set; } = string.Empty;
        //public string ImageUrl { get; set; }
    }
}
