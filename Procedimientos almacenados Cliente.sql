DECLARE @resultado INT
DECLARE @mensaje VARCHAR(500)
GO

/* Agregar un cliente */
CREATE PROC Agregar_Cliente(
@nombre_completo VARCHAR(100),
@dni VARCHAR(12),
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
	IF NOT EXISTS (SELECT * FROM Cliente WHERE dni = @dni)
		BEGIN
			INSERT INTO Cliente(nombre_completo, dni, email, telefono, estado)
			VALUES (@nombre_completo, @dni, @email, @telefono, @estado)
			/* Retorna el id_cliente generado automaticamente */
			SET @resultado = SCOPE_IDENTITY()
		END
	ELSE
		SET @mensaje = 'No se puede agregar un cliente con el mismo DNI'
END
GO

/* Editar un cliente */
CREATE PROC Editar_Cliente(
@id_cliente INT,
@nombre_completo VARCHAR(100),
@dni VARCHAR(12),
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
	IF NOT EXISTS (SELECT * FROM Cliente WHERE id_cliente != @id_cliente AND dni = @dni)
		BEGIN
			UPDATE Cliente SET
			nombre_completo = @nombre_completo,
			dni = @dni,
			email = @email,
			telefono = @telefono,
			estado = @estado
			WHERE id_cliente = @id_cliente
		END
	ELSE
	BEGIN
		SET @resultado = 0
		SET @mensaje = 'Un cliente ya tiene el mismo DNI'
	END
END
GO

/* Eliminar un cliente */
CREATE PROC Eliminar_Cliente(
@id_cliente INT,
@resultado BIT OUTPUT,
@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''
	IF NOT EXISTS (
	SELECT * FROM Cliente
	INNER JOIN Venta ON cliente.id_cliente = venta.id_cliente
	)
		BEGIN
			DELETE FROM Cliente
			WHERE id_cliente = @id_cliente
			SET @resultado = 1
		END
	ELSE
		SET @mensaje = 'No se puede eliminar este cliente ya que está asociado a una venta realizada'
END
