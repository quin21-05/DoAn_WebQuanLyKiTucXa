using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class QuanHuyen
    {
        public QuanHuyen()
        {
            Nhas = new HashSet<Nha>();
        }

        public int Id { get; set; }
        public int? MaTp { get; set; }
        public string? Ten { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<Nha> Nhas { get; set; }
    }
}
