using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Inventario
    {
        public Inventario()
        {
            Empleados = new HashSet<Empleados>();
        }

        public int IdInventario { get; set; }
        public string Cantidad { get; set; }
        public string EstadoProducto { get; set; }
        public int? IdProducto { get; set; }
        public string FechaIngreso { get; set; }

        public virtual Productos IdProductoNavigation { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
