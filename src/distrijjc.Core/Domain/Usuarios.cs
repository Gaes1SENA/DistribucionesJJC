using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Clientes = new HashSet<Clientes>();
            Empleados = new HashSet<Empleados>();
        }

        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public int? IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
