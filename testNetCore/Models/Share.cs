using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Share
    {
        public long Id { get; set; }
        public long PromotionMemberId { get; set; }
        public long PromotionId { get; set; }
        public string Guid { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public string Source { get; set; }
        public string Emailaddress { get; set; }
        public bool? Completed { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
