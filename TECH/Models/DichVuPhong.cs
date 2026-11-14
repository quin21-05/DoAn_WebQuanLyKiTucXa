using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class DichVuPhong
    {
        public int Id { get; set; }
        public int? MaDv { get; set; }
        public int? MaPhong { get; set; }
        public int? SoLuong { get; set; }

        public virtual Phong? MaPhongNavigation { get; set; }
    }
}
