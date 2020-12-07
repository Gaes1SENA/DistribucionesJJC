using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Tipoproducto
    {
        public Tipoproducto()
        {
            Productos = new HashSet<Productos>();
            Proveedor = new HashSet<Proveedor>();
        }

        public int TipoProducto1 { get; set; }
        public string Producto { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
        public virtual ICollection<Proveedor> Proveedor { get; set; }
    }
}
