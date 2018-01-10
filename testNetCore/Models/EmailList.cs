using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class EmailList
    {
        public long Id { get; set; }
        public long EmailTemplateId { get; set; }
        public long PromotionId { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EmailAddress { get; set; }
    }
}
