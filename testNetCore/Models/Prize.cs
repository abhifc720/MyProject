using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Prize
    {
        public long Id { get; set; }
        public long PromotionId { get; set; }
        public long? PhaseId { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
