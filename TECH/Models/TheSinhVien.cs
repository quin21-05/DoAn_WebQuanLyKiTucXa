using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class TheSinhVien
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? MaThe { get; set; }
        public DateTime? NgayTaoThe { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public int? Status { get; set; }
        public string? Comment { get; set; }
    }
}
