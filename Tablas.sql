CREATE TABLE Categoria (
  id_categoria INT IDENTITY(1, 1) NOT NULL,
  nombre VARCHAR(100) NOT NULL,
  PRIMARY KEY (id_categoria)
);
GO

CREATE TABLE Rol (
  id_rol INT IDENTITY(1, 1) NOT NULL,
  nombre VARCHAR(100) NOT NULL,
  PRIMARY KEY (id_rol)
);
GO

CREATE TABLE Categoria_estado (
  id_categoria_estado INT IDENTITY(1, 1) NOT NULL,
  id_categoria INT NOT NULL,
  descripcion VARCHAR(20) NOT NULL,
  PRIMARY KEY (id_categoria_estado),
  FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);
GO

CREATE TABLE Producto (
  id_producto INT IDENTITY(1, 1) NOT NULL,
  id_categoria INT NOT NULL,
  codigo_barra VARCHAR(55) NOT NULL,
  nombre VARCHAR(155) NOT NULL,
  precio_costo DECIMAL(6, 2) NOT NULL,
  precio_venta DECIMAL(6, 2) NOT NULL,
  stock INT NOT NULL,
  imagen VARCHAR(255) NOT NULL,
  PRIMARY KEY (id_producto),
  FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);
GO

CREATE TABLE Usuario (
  id_usuario INT IDENTITY(1, 1) NOT NULL,
  id_rol INT NOT NULL,
  contrasena VARCHAR(255) NOT NULL,
  nombre VARCHAR(255) NOT NULL,
  PRIMARY KEY (id_usuario),
  FOREIGN KEY (id_rol) REFERENCES Rol(id_rol)
);
GO

CREATE TABLE Usuario_info (
	id_usuario_info INT IDENTITY(1, 1) NOT NULL,
	id_usuario INT NOT NULL,
	nombre_completo VARCHAR (255) NOT NULL,
	telefono VARCHAR(155) NULL,
	email VARCHAR(255) NULL,
	domicilio VARCHAR(255) NULL,
	PRIMARY KEY (id_usuario_info),
	FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);
GO

CREATE TABLE Producto_estado (
  id_producto_estado INT IDENTITY(1, 1) NOT NULL,
  id_producto INT NOT NULL,
  PRIMARY KEY (id_producto_estado),
  FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);
GO

CREATE TABLE Venta (
  id_venta INT IDENTITY(1, 1) NOT NULL,
  id_usuario INT NOT NULL,
  fecha_venta DATETIME NOT NULL DEFAULT GETDATE(),
  importe_total DECIMAL(12, 2) NOT NULL,
  PRIMARY KEY (id_venta),
  FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);
GO

CREATE TABLE Venta_Detalle (
  id_venta_detalle INT IDENTITY(1, 1) NOT NULL,
  id_venta INT NOT NULL,
  id_producto INT NOT NULL,
  cantidad_producto INT NOT NULL,
  precio_producto DECIMAL(6, 2) NOT NULL,
  PRIMARY KEY (id_venta_detalle),
  FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
  FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);
GO

CREATE TABLE Venta_estado (
  id_venta_estado INT NOT NULL,
  id_venta INT NOT NULL,
  PRIMARY KEY (id_venta_estado),
  FOREIGN KEY (id_venta) REFERENCES Venta(id_venta)
);