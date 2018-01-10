using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class EmailTracking
    {
        public long Id { get; set; }
        public long EmailTemplateId { get; set; }
        public string EmailAddress { get; set; }
        public string Event { get; set; }
        public DateTime? EventTs { get; set; }
        public string ExternalTrackingId { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
