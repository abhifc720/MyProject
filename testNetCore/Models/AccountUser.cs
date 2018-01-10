using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class AccountUser
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long UserId { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
