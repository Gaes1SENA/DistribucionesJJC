using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class CodTelefono
    {
        public CodTelefono()
        {
            Clientes = new HashSet<Clientes>();
            Empleados = new HashSet<Empleados>();
            Proveedor = new HashSet<Proveedor>();
        }

        public int? CodTelefono1 { get; set; }
        public int NumTelefono { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
