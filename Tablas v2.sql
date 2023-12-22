CREATE TABLE Categoria (
  id_categoria INT IDENTITY (1, 1) NOT NULL,
  descripcion VARCHAR(60) NOT NULL,
  estado BIT NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_categoria PRIMARY KEY (id_categoria)
);
GO

CREATE TABLE Producto (
  id_producto INT IDENTITY(1, 1) NOT NULL,
  codigo VARCHAR(60) NOT NULL,
  descripcion VARCHAR(60) NOT NULL,
  id_categoria INT NOT NULL,
  stock INT DEFAULT 0 NOT NULL,
  precio_costo DECIMAL(9, 2) DEFAULT 0 NOT NULL,
  precio_venta DECIMAL(9, 2) DEFAULT 0 NOT NULL,
  estado BIT NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_producto PRIMARY KEY (id_producto),
  FOREIGN KEY (id_categoria) REFERENCES Categoria(id_categoria)
);
GO

CREATE TABLE Rol (
  id_rol INT IDENTITY(1, 1) NOT NULL,
  descripcion VARCHAR(60) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_rol PRIMARY KEY (id_rol)
);
GO

CREATE TABLE Permiso (
  id_permiso INT IDENTITY(1, 1) NOT NULL,
  id_rol INT NOT NULL,
  nombre_menu VARCHAR(100) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_permiso PRIMARY KEY (id_permiso),
  CONSTRAINT FK_Permiso_Rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol)
);
GO

CREATE TABLE Proveedor (
  id_proveedor INT IDENTITY(1, 1) NOT NULL,
  descripcion VARCHAR(100) NOT NULL,
  email VARCHAR(155) NOT NULL,
  telefono VARCHAR(60) NOT NULL,
  estado BIT NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL
  CONSTRAINT PK_id_proveedor PRIMARY KEY (id_proveedor)
);
GO

CREATE TABLE Cliente (
  id_cliente INT IDENTITY(1, 1) NOT NULL,
  nombre_completo VARCHAR(100) NOT NULL,
  email VARCHAR(155) NOT NULL,
  telefono VARCHAR(60) NOT NULL,
  estado BIT NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  dni VARCHAR(12) NOT NULL,
  CONSTRAINT PK_id_cliente PRIMARY KEY (id_cliente)
);
GO

CREATE TABLE Usuario (
  id_usuario INT IDENTITY(1, 1) NOT NULL,
  dni VARCHAR(12) NOT NULL,
  nombre_completo VARCHAR(100) NOT NULL,
  email VARCHAR(155) NOT NULL,
  clave VARCHAR(155) NOT NULL,
  id_rol INT NOT NULL,
  estado BIT NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_usuario PRIMARY KEY (id_usuario),
  CONSTRAINT FK_usuario_rol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol)
);
GO

CREATE TABLE Compra (
  id_compra INT IDENTITY(1, 1) NOT NULL,
  id_usuario INT NOT NULL,
  id_proveedor INT NULL,
  monto_total DECIMAL(12, 2) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_compra PRIMARY KEY (id_compra),
  CONSTRAINT FK_Compra_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT FK_Compra_Proveedor FOREIGN KEY (id_proveedor) REFERENCES Proveedor(id_proveedor)
);
GO

CREATE TABLE Venta (
  id_venta INT IDENTITY(1, 1) NOT NULL,
  id_usuario INT NOT NULL,
  monto_total DECIMAL(12, 2) NOT NULL,
  monto_cambio DECIMAL(6, 2) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  id_cliente INT NULL,
  CONSTRAINT PK_id_venta PRIMARY KEY (id_venta),
  CONSTRAINT FK_Venta_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT FK_Venta_Cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);
GO

CREATE TABLE Compra_Detalle (
  id_compradetalle INT IDENTITY(1, 1) NOT NULL,
  id_compra INT NOT NULL,
  id_producto INT NOT NULL,
  precio_compra DECIMAL(9, 2) DEFAULT 0 NOT NULL,
  precio_venta DECIMAL(9, 2) DEFAULT 0 NOT NULL,
  cantidad INT NOT NULL,
  subtotal DECIMAL(12, 2) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_compradetalle PRIMARY KEY (id_compradetalle),
  CONSTRAINT FK_Compra_Detalle FOREIGN KEY (id_compra) REFERENCES Compra(id_compra),
  CONSTRAINT FK_Compra_Producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);
GO

CREATE TABLE Venta_Detalle (
  id_ventadetalle INT IDENTITY(1, 1) NOT NULL,
  id_venta INT NOT NULL,
  id_producto INT NOT NULL,
  precio_venta DECIMAL(12, 2) NOT NULL,
  cantidad INT NOT NULL,
  subtotal DECIMAL(12, 2) NOT NULL,
  fecha_registro DATETIME DEFAULT GETDATE() NOT NULL,
  CONSTRAINT PK_id_ventadetalle PRIMARY KEY (id_ventadetalle),
  CONSTRAINT FK_Venta_Detalle FOREIGN KEY (id_venta) REFERENCES Venta(id_venta),
  CONSTRAINT FK_Venta_Producto FOREIGN KEY (id_producto) REFERENCES Producto(id_producto)
);
GO
