/* Guardar categoria */

DECLARE @descripcion VARCHAR(60)
DECLARE @resultado INT
DECLARE @estado BIT
DECLARE @mensaje VARCHAR(500)
GO

CREATE PROC Agregar_Categoria (
@descripcion VARCHAR(60),
@estado BIT,
@resultado INT OUTPUT,
@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 0
	IF NOT EXISTS (SELECT * FROM Categoria WHERE descripcion = @descripcion)
	BEGIN
		INSERT INTO Categoria(descripcion, estado) VALUES (@descripcion, @estado)
		SET @resultado = SCOPE_IDENTITY()
	END
	ELSE
		SET @mensaje = 'Una categor�a ya tiene esta descripci�n'
END
GO

/* Editar categor�a */ 
CREATE PROC Editar_Categoria (
@id_categoria INT,
@descripcion VARCHAR(60),
@estado BIT,
@resultado BIT OUTPUT,
@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 1
	IF NOT EXISTS (SELECT * FROM Categoria WHERE descripcion = @descripcion AND id_categoria != @id_categoria)
		UPDATE Categoria
		SET
			descripcion = @descripcion,
			estado = @estado
		WHERE
			id_categoria = @id_categoria
	ELSE
	BEGIN
		SET @resultado = 0
		SET @mensaje = 'Una categor�a ya tiene esta descripci�n'
	END
END
GO

/* Eliminar categor�a */ 
CREATE PROC Eliminar_Categoria (
@id_categoria INT,
@resultado BIT OUTPUT,
@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 1
	IF NOT EXISTS (
		SELECT * FROM Categoria
		INNER JOIN Producto ON producto.id_categoria = categoria.id_categoria
		WHERE categoria.id_categoria = @id_categoria
	)
	BEGIN
		DELETE TOP (1) FROM Categoria WHERE id_categoria = @id_categoria
	END
	ELSE
	BEGIN
		SET @resultado = 0
		SET @mensaje = 'No se puede eliminar porque la categor�a se encuentra relacionada a uno o m�s productos'
	END
END


