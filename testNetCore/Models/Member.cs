using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class Member
    {
        public long Id { get; set; }
        public string Emailaddress { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool? Disabled { get; set; }
        public string Detail { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
