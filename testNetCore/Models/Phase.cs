using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Phase
    {
        public long Id { get; set; }
        public long PromotionId { get; set; }
        public string Phase1 { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Detail { get; set; }
        public int? EntriesPerDay { get; set; }
        public int? TotalEntriesPhase { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
