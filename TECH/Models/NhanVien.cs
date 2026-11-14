using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HopDongs = new HashSet<HopDong>();
        }

        public int Id { get; set; }
        public string? TenNv { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? Cmnd { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }
        public int? Role { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
