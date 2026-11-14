using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class DichVu
    {
        public DichVu()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public int? LoaiDv { get; set; }
        public string? TenDv { get; set; }
        public decimal? DonGia { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
