using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class SuaChua
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? MaPhong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? Comment { get; set; }
        public int? Status { get; set; }
    }
}
