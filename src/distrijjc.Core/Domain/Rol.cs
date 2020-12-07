using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Rol
    {
        public Rol()
        {
            Empleados = new HashSet<Empleados>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdRol { get; set; }
        public string Rol1 { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
