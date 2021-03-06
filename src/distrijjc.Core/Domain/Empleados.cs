﻿using System;
using System.Collections.Generic;

namespace distrijjc.Infrastructure
{
    public partial class Empleados
    {
        public Empleados()
        {
            Pedidos = new HashSet<Pedidos>();
            Ventas = new HashSet<Ventas>();
        }

        public int IdEmpleado { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public int? NDocumento { get; set; }
        public int? IdRol { get; set; }
        public int? IdInventario { get; set; }
        public int? IdUsuario { get; set; }
        public int? NumTelefono { get; set; }

        public virtual Inventario IdInventarioNavigation { get; set; }
        public virtual Rol IdRolNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual CodTelefono NumTelefonoNavigation { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
