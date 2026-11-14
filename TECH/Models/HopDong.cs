using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class HopDong
    {
        public HopDong()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public int? MaPhong { get; set; }
        public int? MaNha { get; set; }
        public int? MaNv { get; set; }
        public int? MaKh { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public decimal? TienCoc { get; set; }
        public int? TrangThai { get; set; }
        public string? GhiChu { get; set; }
        public bool? IsDeteled { get; set; }

        public virtual KhachHang? MaKhNavigation { get; set; }
        public virtual NhanVien? MaNvNavigation { get; set; }
        public virtual Phong? MaPhongNavigation { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
