using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class Nha
    {
        public Nha()
        {
            Phongs = new HashSet<Phong>();
        }

        public int Id { get; set; }
        public string? TenNha { get; set; }
        public int? MaTp { get; set; }
        public int? MaQh { get; set; }
        public int? MaPx { get; set; }
        public int? Slphong { get; set; }
        public string? DiaChi { get; set; }

        public virtual PhuongXa? MaPxNavigation { get; set; }
        public virtual QuanHuyen? MaQhNavigation { get; set; }
        public virtual ThanhPho? MaTpNavigation { get; set; }
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
