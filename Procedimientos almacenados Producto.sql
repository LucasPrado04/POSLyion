SELECT id_producto, codigo, producto.descripcion, stock, precio_costo, precio_venta, producto.estado, categoria.id_categoria, categoria.descripcion[DescripcionCategoria] FROM Producto
INNER JOIN Categoria ON categoria.id_categoria = producto.id_categoria

/* Agregar un producto */
DECLARE @resultado INT
DECLARE @mensaje VARCHAR(500)
GO

SELECT * FROM Producto

CREATE PROC Agregar_Producto(
	@codigo VARCHAR(60),
	@descripcion VARCHAR(60),
	@id_categoria INT,
	@estado BIT,
	@resultado INT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''
	IF NOT EXISTS (SELECT * FROM Producto WHERE codigo = @codigo)
	BEGIN
		INSERT INTO Producto(codigo, descripcion, id_categoria, estado) VALUES
		(@codigo, @descripcion, @id_categoria, @estado)
		/* Usa de forma automática el id_producto si se insertó correctamente */
		SET
			@resultado = SCOPE_IDENTITY()	
	END
	ELSE
		SET @mensaje = 'Ya existe un producto con este código de barras'
END
GO

/* Editar un producto */
CREATE PROC Editar_Producto (
	@id_producto INT,
	@codigo VARCHAR(60),
	@descripcion VARCHAR(60),
	@id_categoria INT,
	@estado BIT,
	@resultado BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 1
	SET @mensaje = ''
	IF NOT EXISTS (SELECT * FROM Producto WHERE codigo = @codigo AND id_producto != @id_producto)
	BEGIN
		UPDATE Producto SET
			codigo = @codigo,
			descripcion = @descripcion,
			id_categoria = @id_categoria,
			estado = @estado
		WHERE id_producto = @id_producto
		/* Usa de forma automática el id_usuario si se insertó correctamente */	
	END
	ELSE
		BEGIN
			SET @resultado = 0
			SET @Mensaje = 'Ya existe un producto con este código de barras'
		END
END
GO

/* Eliminar un producto */
CREATE PROC Eliminar_Producto (
	@id_producto INT,
	@resultado BIT OUTPUT,
	@mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''
	DECLARE @paso_reglas BIT = 1
	/* Si el producto está relacionado con una compra, no se elimina */
	IF EXISTS (
		SELECT * FROM Compra_Detalle
		INNER JOIN Producto ON producto.id_producto = compra_detalle.id_producto
		WHERE producto.id_producto = @id_producto
	)
		BEGIN
			SET @paso_reglas = 0
			SET @resultado = 0
			SET @mensaje = @mensaje + 'No se puede eliminar el producto porque está relacionado con compras realizadas'
		END
	/* Si el producto está relacionado con una venta, no se elimina */
	IF EXISTS (
		SELECT * FROM Venta_Detalle
		INNER JOIN Producto ON producto.id_producto = venta_detalle.id_producto
		WHERE producto.id_producto = @id_producto
	)
		BEGIN
			SET @paso_reglas = 0
			SET @resultado = 0
			SET @mensaje = @mensaje + 'No se puede eliminar el producto porque está relacionado con ventas realizadas'
		END
	/* Si el producto no está relacionado con una compra ni con una venta, se elimina */
	IF (@paso_reglas = 1)
		BEGIN
			DELETE FROM Producto
			WHERE producto.id_producto = @id_producto
			SET @resultado = 1
		END
END