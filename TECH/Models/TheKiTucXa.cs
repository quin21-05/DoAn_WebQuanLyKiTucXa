using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class TheKiTucXa
    {
        public int Id { get; set; }
        public int? MaSinhVien { get; set; }
        public string? MaThe { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? Status { get; set; }
    }
}
