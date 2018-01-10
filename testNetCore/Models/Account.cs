using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Account
    {
        public long Id { get; set; }
        public long? ParentAccountId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
