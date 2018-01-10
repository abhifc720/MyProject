using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class OptOut
    {
        public long Id { get; set; }
        public long PromotionId { get; set; }
        public string Emailaddress { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
