using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using distrijjc.Infrastructure;

namespace distrijjc.Infrastructure.Data
{
    public partial class distrijjcDbContext : DbContext
    {
        public distrijjcDbContext()
        {
        }

        public distrijjcDbContext(DbContextOptions<distrijjcDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CodTelefono> CodTelefono { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Tipoproducto> Tipoproducto { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           /*if (!optionsBuilder.IsConfigured)
            {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=distrijjc;server=localhost;port=3307;user id=root;password=");
            } */
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Cedula)
                    .HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.HasIndex(e => e.NumTelefono)
                    .HasName("num_telefono");

                entity.Property(e => e.Cedula).HasColumnType("int(11)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreTienda)
                    .HasColumnName("Nombre_Tienda")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumTelefono)
                    .HasColumnName("num_telefono")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("Primer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("Segundo_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("clientes_ibfk_2");

                entity.HasOne(d => d.NumTelefonoNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.NumTelefono)
                    .HasConstraintName("clientes_ibfk_3");
            });

            modelBuilder.Entity<CodTelefono>(entity =>
            {
                entity.HasKey(e => e.NumTelefono)
                    .HasName("PRIMARY");

                entity.ToTable("cod_telefono");

                entity.Property(e => e.NumTelefono)
                    .HasColumnName("num_telefono")
                    .HasColumnType("int(10)");

                entity.Property(e => e.CodTelefono1)
                    .HasColumnName("cod_telefono")
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PRIMARY");

                entity.ToTable("empleados");

                entity.HasIndex(e => e.IdInventario)
                    .HasName("id_inventario");

                entity.HasIndex(e => e.IdRol)
                    .HasName("id_rol");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("id_usuario");

                entity.HasIndex(e => e.NumTelefono)
                    .HasName("num_telefono");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInventario)
                    .HasColumnName("id_inventario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NDocumento)
                    .HasColumnName("N_Documento")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumTelefono)
                    .HasColumnName("num_telefono")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("Primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("Primer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdInventarioNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdInventario)
                    .HasConstraintName("empleados_ibfk_3");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("empleados_ibfk_2");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("empleados_ibfk_4");

                entity.HasOne(d => d.NumTelefonoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.NumTelefono)
                    .HasConstraintName("empleados_ibfk_5");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PRIMARY");

                entity.ToTable("inventario");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("id_producto");

                entity.Property(e => e.IdInventario)
                    .HasColumnName("id_inventario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EstadoProducto)
                    .HasColumnName("estado_producto")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("id_producto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("inventario_ibfk_1");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PRIMARY");

                entity.ToTable("pedidos");

                entity.HasIndex(e => e.Cedula)
                    .HasName("cedula");

                entity.HasIndex(e => e.IdEmpleado)
                    .HasName("id_empleado");

                entity.HasIndex(e => e.IdProductos)
                    .HasName("id_productos");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("id_pedido")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Cedula)
                    .HasColumnName("cedula")
                    .HasColumnType("int(12)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("fecha_entrega")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("fecha_pedido")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProductos)
                    .HasColumnName("id_productos")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrecioTotal)
                    .HasColumnName("precio_total")
                    .HasColumnType("int(7)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.CedulaNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.Cedula)
                    .HasConstraintName("pedidos_ibfk_2");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("pedidos_ibfk_3");

                entity.HasOne(d => d.IdProductosNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(d => d.IdProductos)
                    .HasConstraintName("pedidos_ibfk_1");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("productos");

                entity.HasIndex(e => e.TipoProducto)
                    .HasName("tipo_producto");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("id_producto")
                    .HasColumnType("int(3)");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreProducto)
                    .HasColumnName("nombre_producto")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("Precio_unitario")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("tipo_producto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.TipoProductoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.TipoProducto)
                    .HasConstraintName("productos_ibfk_1");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor)
                    .HasName("PRIMARY");

                entity.ToTable("proveedor");

                entity.HasIndex(e => e.NumTelefono)
                    .HasName("num_telefono");

                entity.HasIndex(e => e.TipoProducto)
                    .HasName("tipo_producto");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("id_proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(40)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreEmpresa)
                    .HasColumnName("Nombre_Empresa")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumTelefono)
                    .HasColumnName("num_telefono")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipoProducto)
                    .HasColumnName("tipo_producto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.NumTelefonoNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.NumTelefono)
                    .HasConstraintName("proveedor_ibfk_2");

                entity.HasOne(d => d.TipoProductoNavigation)
                    .WithMany(p => p.Proveedor)
                    .HasForeignKey(d => d.TipoProducto)
                    .HasConstraintName("proveedor_ibfk_1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rol1)
                    .HasColumnName("rol")
                    .HasMaxLength(13)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Tipoproducto>(entity =>
            {
                entity.HasKey(e => e.TipoProducto1)
                    .HasName("PRIMARY");

                entity.ToTable("tipoproducto");

                entity.Property(e => e.TipoProducto1)
                    .HasColumnName("tipo_producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Producto)
                    .HasColumnName("producto")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdRol)
                    .HasName("id_rol");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("id_usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdRol)
                    .HasColumnName("id_rol")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("usuarios_ibfk_1");
            });

            modelBuilder.Entity<Ventas>(entity =>
            {
                entity.HasKey(e => e.IdComprobante)
                    .HasName("PRIMARY");

                entity.ToTable("ventas");

                entity.HasIndex(e => e.Cedula)
                    .HasName("cedula");

                entity.HasIndex(e => e.IdEmpleado)
                    .HasName("id_empleado");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("id_producto");

                entity.Property(e => e.IdComprobante)
                    .HasColumnName("id_comprobante")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("int(3)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cedula)
                    .HasColumnName("cedula")
                    .HasColumnType("int(12)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaVenta)
                    .HasColumnName("fecha_venta")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdEmpleado)
                    .HasColumnName("id_empleado")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("id_producto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrecioTotal)
                    .HasColumnName("Precio_Total")
                    .HasColumnType("int(7)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("Precio_Unitario")
                    .HasColumnType("int(5)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.CedulaNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.Cedula)
                    .HasConstraintName("ventas_ibfk_3");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("ventas_ibfk_1");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Ventas)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("ventas_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
