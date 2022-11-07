create database FrtSlim

Use FrtSlim

GO

CREATE TABLE Usuario (
  idUsuario Int identity(1,1) primary key,
  nombre varchar(50) not null,
  correo varchar(150)not null,
  pass varchar(200)not null,
  rol int not null
);



CREATE TABLE Categorias (
  idCategorias Int identity (1,1) primary key,
  nombre varchar(100)
);

CREATE TABLE Proveedor (
  idProveedor Int identity (1,1) primary key,
  proveedor varchar(100),
  Direccion varchar(200),
  Telefono varchar(120)

);

CREATE TABLE Productos (
  IdProducto Int identity (1,1) primary key,
  idProveedor int references Proveedor(IdProducto),
  nombre varchar(50),
  descripcion varchar(300),
  stock int,
  precio decimal(19,2),
  estado int,
);

CREATE TABLE detalleVentas (
  idDetalleVentas Int identity (1,1) primary key,
  idProducto int references Productos(IdProducto),
  cantidad int,
  fecha datetime,
  Total decimal(19,2)
);


select *from Productos


insert 