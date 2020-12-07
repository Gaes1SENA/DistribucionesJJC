using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Proveedor
    {
        public int IdProveedor { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public int? TipoProducto { get; set; }
        public int? NumTelefono { get; set; }

        public virtual CodTelefono NumTelefonoNavigation { get; set; }
        public virtual Tipoproducto TipoProductoNavigation { get; set; }
    }
}
