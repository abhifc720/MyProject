using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Apikey
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long ApiKey { get; set; }
        public long? Phaseid { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
