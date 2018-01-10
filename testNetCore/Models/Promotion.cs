using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Promotion
    {
        public long Id { get; set; }
        public long? ParentPromotionid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Disabled { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long? AccountId { get; set; }
        public bool? Isdeleted { get; set; }
        public string Description { get; set; }
    }
}
