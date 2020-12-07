using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Productos
    {
        public Productos()
        {
            Inventario = new HashSet<Inventario>();
            Pedidos = new HashSet<Pedidos>();
            Ventas = new HashSet<Ventas>();
        }

        public int IdProducto { get; set; }
        public int? PrecioUnitario { get; set; }
        public int? TipoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Cantidad { get; set; }

        public virtual Tipoproducto TipoProductoNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
