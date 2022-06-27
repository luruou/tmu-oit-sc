using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Common.Enum
{
    public enum HttpVerbs
    {
        /// <summary>
        /// 擷取要求之URI所識別的資訊或實體。
        /// </summary>
        Get = 1,
        /// <summary>
        /// 公布新實體至URI做為新增項目。
        /// </summary>
        Post = 2,
        /// <summary>
        /// 要求刪除指定的URI。
        /// </summary>
        Delete = 8,
        /// <summary>
        /// 取代URI所識別的實體。
        /// </summary>
        Put = 4,
        /// <summary>
        /// 要求將要求實體中所描述的一組變更套用到要求URI所識別的資源。
        /// </summary>
        Patch = 32,
        /// <summary>
        /// 擷取要求之URI所識別的資訊或實體的訊息標頭。
        /// </summary>
        Head = 16,
        /// <summary>
        /// 表示要求通訊選項的相關資訊，該選項由要求URI所識別的要求/回應鏈結提供使用。
        /// </summary>
        Options = 64
    }
}
