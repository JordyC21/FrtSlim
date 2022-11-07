create database Fslim

Use Fslim

GO

CREATE TABLE Usuario (
  idUsuario Int identity(1,1) primary key,
  nombre varchar(50) not null,
  correo varchar(150)not null,
  pass varchar(200)not null,
  rol int not null
);



CREATE TABLE ventas (
  idVenta Int primary key identity (1,1),
  fecha datetime not null,
  total decimal(19,2) not null
);

CREATE TABLE Categorias (
  idCategorias Int identity (1,1) primary key,
  nombre varchar(100)
);

CREATE TABLE Proveedor (
  idProveedor Int identity (1,1) primary key,
  nombre varchar(100)
);

CREATE TABLE Productos (
  idProducto Int identity (1,1) primary key,
  nombre varchar(50),
  descripcion varchar(300),
  stock int,
  precio decimal(19,2),
  idCategorias int,
  idProveedor int,
  estado int,
  CONSTRAINT fk_Categorias FOREIGN KEY (idCategorias) references Categorias(idCategorias),
  CONSTRAINT fk_Proveedor  FOREIGN KEY (idProveedor) references Proveedor(idProveedor)
);

CREATE TABLE detalleVentas (
  idDetalleVentas Int identity (1,1) primary key,
  cantidad int,
  subTotal decimal(19,2),
  idProducto int,
  idVenta int,
  CONSTRAINT fk_ventas  FOREIGN KEY (idVenta) references ventas(idVenta),
  CONSTRAINT fk_Productos  FOREIGN KEY (idProducto) references Productos(idProducto)
);