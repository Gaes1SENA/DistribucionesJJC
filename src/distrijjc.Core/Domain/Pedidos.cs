using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Pedidos
    {
        public int IdPedido { get; set; }
        public int? PrecioTotal { get; set; }
        public int? Cedula { get; set; }
        public int? IdProductos { get; set; }
        public int? IdEmpleado { get; set; }
        public string FechaPedido { get; set; }
        public string FechaEntrega { get; set; }

        public virtual Clientes CedulaNavigation { get; set; }
        public virtual Empleados IdEmpleadoNavigation { get; set; }
        public virtual Productos IdProductosNavigation { get; set; }
    }
}
