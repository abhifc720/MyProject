using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class MemberPromotion
    {
        public long Id { get; set; }
        public long MemberId { get; set; }
        public long PromotionId { get; set; }
        public long? ShareId { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
