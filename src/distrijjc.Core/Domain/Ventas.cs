using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Ventas
    {
        public int IdComprobante { get; set; }
        public int? PrecioUnitario { get; set; }
        public int? PrecioTotal { get; set; }
        public int? Cantidad { get; set; }
        public int? IdEmpleado { get; set; }
        public int? IdProducto { get; set; }
        public int? Cedula { get; set; }
        public string FechaVenta { get; set; }

        public virtual Clientes CedulaNavigation { get; set; }
        public virtual Empleados IdEmpleadoNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
