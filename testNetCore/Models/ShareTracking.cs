using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class ShareTracking
    {
        public long Id { get; set; }
        public long ShareId { get; set; }
        public DateTime? ClickDate { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
