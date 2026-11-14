using System;
using System.Collections.Generic;

namespace Website.Models
{
    public partial class PhuongXa
    {
        public PhuongXa()
        {
            Nhas = new HashSet<Nha>();
        }

        public int Id { get; set; }
        public int? MaQh { get; set; }
        public string? Ten { get; set; }
        public string? GhiChu { get; set; }

        public virtual ICollection<Nha> Nhas { get; set; }
    }
}
