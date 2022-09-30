using System;
using System.Collections.Generic;

namespace WSVenta.Models
{
    public partial class Client
    {
        public Client()
        {
            Venta = new HashSet<Venta>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
