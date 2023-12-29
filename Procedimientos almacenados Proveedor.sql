/* Agregar Proveedor */
DECLARE @resultado INT
DECLARE @mensaje VARCHAR(500)
GO

CREATE PROC Agregar_Proveedor (
	@cuit VARCHAR(40),
	@razon_social VARCHAR(100),
	@email VARCHAR(155),
	@telefono VARCHAR(60),
	@estado BIT,
	@resultado INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''
	IF NOT EXISTS (SELECT * FROM Proveedor WHERE razon_social = @razon_social)
		BEGIN
			INSERT INTO Proveedor(cuit, razon_social, email, telefono, estado)
			VALUES(@cuit, @razon_social, @email, @telefono, @estado)
			SET @resultado = SCOPE_IDENTITY();
		END
	ELSE
		SET @mensaje = 'Un proveedor ya tiene la misma razón social'
END
GO

/* Editar Proveedor */
DECLARE @resultado BIT
DECLARE @mensaje VARCHAR(500)
GO

CREATE PROC Editar_Proveedor(
	@id_proveedor INT,
	@cuit VARCHAR(40),
	@razon_social VARCHAR(100),
	@email VARCHAR(155),
	@telefono VARCHAR(60),
	@estado BIT,
	@resultado BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 1
	SET @mensaje = ''
	IF NOT EXISTS (SELECT * FROM Proveedor WHERE id_proveedor != @id_proveedor AND razon_social = @razon_social)
		BEGIN
			UPDATE Proveedor SET
			cuit = @cuit,
			razon_social = @razon_social,
			email = @email,
			telefono = @telefono,
			estado = @estado
			WHERE id_proveedor = @id_proveedor
		END
	ELSE
		SET @resultado = 0
		SET @mensaje = 'Un proveedor ya tiene la misma razón social'
END
GO

/* Eliminar Proveedor */
CREATE PROC Eliminar_Proveedor (
	@id_proveedor INT,
	@resultado BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 1
	SET @mensaje = ''
	IF NOT EXISTS(
	SELECT * FROM Proveedor
	INNER JOIN Compra ON proveedor.id_proveedor = compra.id_proveedor
	)
		BEGIN
			DELETE TOP (1) FROM Proveedor
			WHERE id_proveedor = @id_proveedor
		END
	ELSE
		SET @resultado = 0
		SET @mensaje = 'No se puede eliminar el proveedor porque está relacionado con una compra'
END
