using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Entry
    {
        public long Id { get; set; }
        public long PromotionMemberId { get; set; }
        public long MemberId { get; set; }
        public long PromotionId { get; set; }
        public long PhaseId { get; set; }
        public string Status { get; set; }
        public string EntryType { get; set; }
        public string Source { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
