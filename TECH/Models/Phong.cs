using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class Phong
    {
        public Phong()
        {
            DichVuPhongs = new HashSet<DichVuPhong>();
            HopDongs = new HashSet<HopDong>();
            ThanhVienPhongs = new HashSet<ThanhVienPhong>();
        }

        public int Id { get; set; }
        public int? MaNha { get; set; }
        public string? TenPhong { get; set; }
        public decimal? DonGia { get; set; }
        public int? SlnguoiMax { get; set; }
        public double? ChieuDai { get; set; }
        public double? ChieuRong { get; set; }
        public string? MoTa { get; set; }
        public int? LoaiPhong { get; set; }
        public int? TinhTrang { get; set; }
        public string? HinhAnh { get; set; }

        public virtual Nha? MaNhaNavigation { get; set; }
        public virtual ICollection<DichVuPhong> DichVuPhongs { get; set; }
        public virtual ICollection<HopDong> HopDongs { get; set; }
        public virtual ICollection<ThanhVienPhong> ThanhVienPhongs { get; set; }
    }
}
