create database distrijjc;
use distrijjc;

create table Clientes (
Cedula int not null,
Primer_nombre varchar(15),
Segundo_nombre varchar(15),
primer_apellido varchar(15),
segundo_apellido varchar(15),
Direccion varchar(40),
Nombre_Tienda varchar(30)
);
alter table Clientes add primary key (Cedula);
alter table clientes add column cod_telefono int(3);
alter table Clientes add column id_usuario int;

create table Ventas (
id_comprobante int(5),
fecha_venta datetime,
Precio_Unitario int(5),
Precio_Total int(7),
Cantidad int(3)
);
alter table Ventas add primary key (id_comprobante);
alter table ventas add column id_empleado int;
alter table ventas add column id_producto int;
alter table ventas add column cedula int(12);

create table Pedidos (
id_pedido int(4),
fecha_pedido datetime,
fecha_entrega datetime,
precio_total int(7)
);
alter table Pedidos add primary key (id_pedido);
alter table pedidos add column id_productos int;
alter table pedidos add column cedula int(12);
alter table pedidos add column id_empleado int(11);

create table Productos (
id_producto int(3),
nombre_producto varchar(15),
Cantidad int(3),
Precio_unitario int(5),
presentacion varchar(10)
);
alter table Productos add primary key (id_producto);
alter table productos add column tipo_producto int(11);

create table Empleados (
id_empleado int not null,
Primer_nombre varchar(15),
segundo_nombre varchar(15),
Primer_apellido varchar(15),
segundo_apellido varchar(15),
Direccion varchar(30),
N_Documento int(11)
);
alter table Empleados add primary key (id_empleado);
alter table empleados add column cod_telefono int(3);
alter table empleados add column id_rol int;
alter table empleados add column id_inventario int;
alter table empleados add column id_usuario int;

create table Inventario (
id_inventario int,
fecha_ingreso datetime,
Cantidad varchar(20),
estado_producto varchar(20)
);
alter table Inventario add primary key (id_inventario);
alter table inventario add column id_producto int;

create table Proveedor (
id_proveedor int,
primer_nombre varchar(15),
primer_apellido varchar(15),
Nombre_Empresa varchar(20),
Direccion varchar(40)
);
alter table Proveedor add primary key (id_proveedor);
alter table proveedor add column tipo_producto int(11);
alter table proveedor add column cod_telefono int(3);


create table tipoproducto (
tipo_producto int,
producto varchar(15)
);

alter table tipoproducto add primary key (tipo_producto);

create table tiponumero (
cod_telefono int(3),
num_telefono int(10)
);
alter table tiponumero add primary key (cod_telefono);

create table usuarios (
id_usuario int,
usuario varchar(15),
Contraseña varchar(15),
correo varchar(25)
);

alter table usuarios add primary key (id_usuario);
alter table usuarios add column id_rol int;

create table rol (
id_rol int,
rol varchar(13)
);

alter table rol add primary key (id_rol);


-- asignacion de llaves foraneas

ALTER TABLE clientes ADD FOREIGN KEY (cod_telefono) REFERENCES tiponumero(cod_telefono);	
alter table clientes add foreign key (id_usuario) references usuarios(id_usuario);
alter table ventas add foreign key (id_empleado) references empleados(id_empleado);
alter table ventas add foreign key (id_producto) references productos(id_producto);
alter table ventas add foreign key (cedula) references clientes(cedula);
alter table productos add foreign key (tipo_producto) references tipoproducto(tipo_producto);
alter table proveedor add foreign key (tipo_producto) references tipoproducto(tipo_producto);
alter table proveedor add foreign key (cod_telefono) REFERENCES tiponumero(cod_telefono);
alter table usuarios add foreign key (id_rol) references rol(id_rol);
alter table pedidos add foreign key (id_productos) references productos(id_producto);
alter table pedidos add foreign key (cedula) references clientes(cedula);
alter table pedidos add foreign key (id_empleado) references empleados(id_empleado);
alter table empleados add foreign key (cod_telefono) references tiponumero(cod_telefono);
alter table empleados add foreign key (id_rol) references rol(id_rol);
alter table empleados add foreign key (id_inventario) references inventario(id_inventario);
alter table empleados add foreign key (id_usuario) references usuarios(id_usuario);
alter table inventario add foreign key (id_producto) references productos(id_producto);
