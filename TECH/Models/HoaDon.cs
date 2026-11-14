using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public int? MaHopDong { get; set; }
        public DateTime? HanDong { get; set; }
        public DateTime? NgayDongTien { get; set; }
        public string? NguoiDong { get; set; }
        public decimal? TongTien { get; set; }
        public decimal? TienDong { get; set; }
        public int? TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public virtual HopDong? MaHopDongNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
