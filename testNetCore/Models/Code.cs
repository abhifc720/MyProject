using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Code
    {
        public long Id { get; set; }
        public long PromotionId { get; set; }
        public long MemberId { get; set; }
        public string Type { get; set; }
        public string Code1 { get; set; }
        public string Grouping { get; set; }
        public DateTime? DateUsed { get; set; }
        public bool? Valid { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
