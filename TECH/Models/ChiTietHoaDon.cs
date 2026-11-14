using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class ChiTietHoaDon
    {
        public int Id { get; set; }
        public int? MaHoaDon { get; set; }
        public int? MaDv { get; set; }
        public int? SoLuong { get; set; }
        public int? MaLoi { get; set; }
        public int? ChiSoCu { get; set; }
        public int? ChiSoMoi { get; set; }
        public int? ChiSoDung { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual DichVu? MaDvNavigation { get; set; }
        public virtual HoaDon? MaHoaDonNavigation { get; set; }
        public virtual LoiPham? MaLoiNavigation { get; set; }
    }
}
