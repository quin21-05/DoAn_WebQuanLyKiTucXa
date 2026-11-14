using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class ThanhVienPhong
    {
        public int Id { get; set; }
        public int? MaKh { get; set; }
        public int? MaPhong { get; set; }

        public virtual KhachHang? MaKhNavigation { get; set; }
        public virtual Phong? MaPhongNavigation { get; set; }
    }
}
