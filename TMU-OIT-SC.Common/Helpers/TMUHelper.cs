using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Common.Helpers
{
    public class TMUHelper
    {
        /// <summary>
        /// 學年
        /// </summary>
        public static string CurrentYear
        {
            get
            {
                return GetSmtr(DateTime.Now)[..3];
            }
        }
        /// <summary>
        /// 學年度學期
        /// </summary>
        public static string CurrentSmtr
        {
            get
            {
                return GetSmtr(DateTime.Now);
            }
        }

        public static string GetSmtr(DateTime date)
        {
            string value;
            if (date.Month >= 7)
                value = (date.Year - 1911).ToString() + "1";
            else if (date.Month >= 1)
                value = (date.Year - 1911 - 1).ToString() + "2";
            else
                value = (date.Year - 1911 - 1).ToString() + "1";

            return value;
        }
    }
}
