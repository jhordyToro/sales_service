using System;
using System.Collections.Generic;

namespace WSVenta.Models
{
    public partial class Venta
    {
        public Venta()
        {
            Conceptos = new HashSet<Concepto>();
        }

        public long Id { get; set; }
        public long IdClient { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Total { get; set; }

        public virtual Client IdClientNavigation { get; set; } = null!;
        public virtual ICollection<Concepto> Conceptos { get; set; }
    }
}
