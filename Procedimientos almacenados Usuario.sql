/* Agregar un usuario */
CREATE PROC Agregar_Usuario (
	@dni VARCHAR(12),
	@nombre_completo VARCHAR(100),
	@email VARCHAR(155),
	@clave VARCHAR(155),
	@id_rol INT,
	@estado BIT,
	@id_usuario_resultado INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @id_usuario_resultado = 0
	SET @mensaje = ''
	IF NOT EXISTS (SELECT * FROM Usuario WHERE dni = @dni)
	BEGIN
		INSERT INTO 
			Usuario(dni, nombre_completo, email, clave, id_rol, estado) 
		VALUES
			(@dni, @nombre_completo, @email, @clave, @id_rol, @estado)
		/* Retorna el id_usuario generado automaticamente */
		SET
			@id_usuario_resultado = SCOPE_IDENTITY()		
	END
	ELSE
		SET @Mensaje = 'Un usuario ya tiene este número de documento registrado'
END

/* TEST AGREGAR_USUARIO */
DECLARE @id_usuario_generado int
DECLARE @mensaje VARCHAR(500)

EXEC Agregar_Usuario '00000000', 'usuario_prueba', 'test@gmail.com', '456', 2, 1, @id_usuario_generado OUTPUT, @mensaje OUTPUT

SELECT @id_usuario_generado
SELECT @mensaje
GO

/* Editar un usuario */
CREATE PROC Editar_Usuario (
	@id_usuario INT,
	@dni VARCHAR(12),
	@nombre_completo VARCHAR(100),
	@email VARCHAR(155),
	@clave VARCHAR(155),
	@id_rol INT,
	@estado BIT,
	@respuesta BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @respuesta = 0
	SET @mensaje = ''
	IF NOT EXISTS (SELECT * FROM Usuario WHERE dni = @dni AND id_usuario != @id_usuario)
	BEGIN
		UPDATE Usuario SET
			dni = @dni,
			nombre_completo = @nombre_completo,
			email = @email,
			clave = @clave,
			id_rol = @id_rol,
			estado = @estado
		WHERE id_usuario = @id_usuario
		/* Usa de forma automática el id_usuario si se insertó correctamente */
		SET
			@respuesta = 1		
	END
	ELSE
		SET @Mensaje = 'Un usuario ya tiene este número de documento registrado'
END

/* TEST EDITAR_USUARIO */
DECLARE @respuesta BIT
DECLARE @mensaje VARCHAR(500)

EXEC Editar_Usuario 4, '43274484', 'usuario_prueba2', 'test2@gmail.com', '567', 2, 1, @respuesta OUTPUT, @mensaje OUTPUT

SELECT @respuesta
SELECT @mensaje
GO

/* Eliminar un usuario */
CREATE PROC Eliminar_Usuario (
	@id_usuario INT,
	@respuesta BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @respuesta = 0
	SET @mensaje = ''
	DECLARE @paso_reglas BIT = 1
	IF EXISTS (
		SELECT * FROM Compra
		INNER JOIN Usuario ON compra.id_usuario = usuario.id_usuario
		WHERE usuario.id_usuario = @id_usuario
		)
	BEGIN
		SET @paso_reglas = 0
		SET @respuesta = 0
		SET @mensaje = @mensaje + 'No se puede eliminar porque el usuario está relacionado con una compra\n'
	END
	IF EXISTS (
		SELECT * FROM Venta
		INNER JOIN Usuario ON venta.id_usuario = usuario.id_usuario
		WHERE usuario.id_usuario = @id_usuario
		)
	BEGIN
		SET @paso_reglas = 0
		SET @respuesta = 0
		SET @mensaje = @mensaje + 'No se puede eliminar porque el usuario está relacionado con una venta\n'
	END
	IF (@paso_reglas = 1)
		BEGIN
			DELETE FROM Usuario WHERE id_usuario = @id_usuario
			SET @respuesta = 1
		END
END