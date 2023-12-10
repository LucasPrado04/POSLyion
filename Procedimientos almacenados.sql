-- CRUD
-- PROCEDIMIENTOS ALMACENADOS PARA PRODUCTO
CREATE PROCEDURE Agregar_producto
@id_categoria INT,
@codigo_barra VARCHAR(55),
@nombre VARCHAR(155),
@precio_costo DECIMAL(6, 2),
@precio_venta DECIMAL(6, 2),
@stock INT,
@imagen VARCHAR(255)
AS
INSERT INTO Producto(codigo_barra, nombre, precio_costo, precio_venta, stock, imagen)
VALUES (@codigo_barra, @nombre, @precio_costo, @precio_venta, @stock, @imagen)
GO
--***********************************************
CREATE PROCEDURE Editar_producto
@id_producto INT,
@id_categoria INT,
@codigo_barra VARCHAR(55),
@nombre VARCHAR(155),
@precio_costo DECIMAL(6, 2),
@precio_venta DECIMAL(6, 2),
@stock INT,
@imagen VARCHAR(255)
AS
UPDATE Producto SET 
id_categoria = @id_categoria,
codigo_barra = @codigo_barra,
nombre = @nombre,
precio_costo = @precio_costo,
precio_venta = @precio_venta,
stock = @stock,
imagen = @imagen
WHERE id_producto = @id_producto
GO
--***********************************************
CREATE PROCEDURE Eliminar_producto
@id_producto INT
AS
DELETE FROM Producto
WHERE id_producto = @id_producto
GO
--***********************************************
-- PROCEDIMIENTOS ALMACENADOS PARA USUARIO
CREATE PROCEDURE Agregar_usuario
@id_rol INT NOT NULL,
@contrasena VARCHAR(255) NOT NULL,
@nombre VARCHAR(255) NOT NULL
AS
INSERT INTO Usuario(id_rol, contrasena, nombre)
VALUES (@id_rol, @contrasena, @nombre)
GO
--***********************************************
CREATE PROCEDURE Editar_usuario
@id_usuario INT,
@id_rol INT,
@contrasena VARCHAR(255),
@nombre VARCHAR(255)
AS
UPDATE Usuario SET
id_rol = @id_rol,
contrasena = @contrasena,
nombre = @nombre
WHERE id_usuario = @id_usuario
GO
--***********************************************
CREATE PROCEDURE Eliminar_usuario
@id_usuario INT
AS
DELETE FROM Usuario
WHERE id_usuario = @id_usuario
GO

--***********************************************
-- PROCEDIMIENTOS ALMACENADOS PARA CATEGORIA
CREATE PROCEDURE Agregar_categoria
@nombre VARCHAR(100)
AS
INSERT INTO Categoria (nombre)
VALUES (@nombre)
GO

CREATE PROCEDURE Editar_categoria
@id_categoria INT,
@nombre VARCHAR(100)
AS
UPDATE Categoria SET
nombre = @nombre
WHERE id_categoria = @id_categoria
GO

-- CREATE PROCEDURE Eliminar_categoria
-- REVISAR COMO HACER BAJAS LOGICAS EN BACKEND AL ELIMINAR UN OBJETO