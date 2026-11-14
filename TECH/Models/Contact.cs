using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Note { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? IpAddress { get; set; }
    }
}
