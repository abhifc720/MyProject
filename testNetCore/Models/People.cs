using System;
using System.Collections.Generic;

namespace testNetCore.Models
{
    public partial class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string IpAddress { get; set; }
    }
}
