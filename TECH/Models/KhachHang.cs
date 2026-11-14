using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HopDongs = new HashSet<HopDong>();
            ThanhVienPhongs = new HashSet<ThanhVienPhong>();
        }

        public int Id { get; set; }
        public string? TenKh { get; set; }
        public string? Cmnd { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? MatKhau { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? GioiTinh { get; set; }

        public virtual ICollection<HopDong> HopDongs { get; set; }
        public virtual ICollection<ThanhVienPhong> ThanhVienPhongs { get; set; }
    }
}
