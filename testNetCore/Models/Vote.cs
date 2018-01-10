using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Vote
    {
        public long Id { get; set; }
        public long EntryId { get; set; }
        public long MemberId { get; set; }
        public long PromotionId { get; set; }
        public long? Phaseid { get; set; }
        public DateTime? DateEntered { get; set; }
        public string IpAddress { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
