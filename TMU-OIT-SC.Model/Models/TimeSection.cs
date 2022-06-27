using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMU_OIT_SC.Model.Models
{
    public class TimeSection
    {
        public int Section { get; set; }
        public string SectionName { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public string TimeRange { get; set; } = string.Empty;
        public string Start { get; set; } = string.Empty;
        public string End { get; set; } = string.Empty;
    }
}
