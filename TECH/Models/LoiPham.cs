using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class LoiPham
    {
        public LoiPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public string? TenLoi { get; set; }
        public decimal? TienPhat { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
