using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Role
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
