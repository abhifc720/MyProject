using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Winner
    {
        public long Id { get; set; }
        public long EntryId { get; set; }
        public long MemberId { get; set; }
        public long PromotionId { get; set; }
        public long PrizeId { get; set; }
        public DateTime? WinTime { get; set; }
        public DateTime? PlayedTime { get; set; }
        public string IpAddress { get; set; }
        public DateTime? DateRedeemed { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}
