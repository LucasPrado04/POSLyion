USE [POSLyion]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (1, N'Gaseosas', 0, CAST(N'2023-12-22T13:26:50.827' AS DateTime))
INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (2, N'Golosinas', 1, CAST(N'2023-12-22T13:26:50.827' AS DateTime))
INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (3, N'Harinas', 0, CAST(N'2023-12-27T13:33:52.133' AS DateTime))
INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (6, N'Energizantes', 1, CAST(N'2023-12-27T14:14:48.030' AS DateTime))
INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (7, N'Enlatados', 0, CAST(N'2023-12-27T14:14:52.180' AS DateTime))
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (1, N'0', N'Schweppes 500ml', 1, 3, CAST(233.33 AS Decimal(9, 2)), CAST(350.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (2, N'1', N'Pepsi 1L', 1, 3, CAST(821.54 AS Decimal(9, 2)), CAST(1020.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (3, N'2', N'Alfajor Tofi simple chocolate', 2, 10, CAST(121.98 AS Decimal(9, 2)), CAST(200.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (4, N'3', N'Mantecol 50g', 2, 6, CAST(212.11 AS Decimal(9, 2)), CAST(330.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (6, N'4', N'Caramelo de chocolate', 2, 0, CAST(0.00 AS Decimal(9, 2)), CAST(0.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-28T11:42:18.900' AS DateTime))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO

SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([id_rol], [descripcion], [fecha_registro]) VALUES (1, N'Administrador', CAST(N'2023-12-22T13:23:17.223' AS DateTime))
INSERT [dbo].[Rol] ([id_rol], [descripcion], [fecha_registro]) VALUES (2, N'Cajero', CAST(N'2023-12-22T13:23:35.287' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (1, N'43274484', N'mauricio', N'contraixosh@hotmail.com', N'1234', 2, 0, CAST(N'2023-12-22T13:24:49.010' AS DateTime))
INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (2, N'43108399', N'lucas', N'luks@gmail.com', N'321', 1, 1, CAST(N'2023-12-22T13:24:49.010' AS DateTime))
INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (4, N'00000001', N'usuario_prueba2', N'test2@gmail.com', N'567', 2, 1, CAST(N'2023-12-25T17:30:49.313' AS DateTime))
INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (5, N'00000002', N'test_agregarusuario', N'test3@hotmail.com', N'1234', 1, 0, CAST(N'2023-12-26T12:36:48.087' AS DateTime))
INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (6, N'00000012', N'123123', N'lol@gmail.com', N'123321', 2, 1, CAST(N'2023-12-26T12:39:41.543' AS DateTime))
INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (7, N'00000011', N'warchi', N'smite@hotmail.com', N'123456', 1, 0, CAST(N'2023-12-26T18:31:26.293' AS DateTime))
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id_cliente], [nombre_completo], [email], [telefono], [estado], [fecha_registro], [dni]) VALUES (1, N'Guillermoo', N'guillermo@hotmail.comm', N'3794111112', 1, CAST(N'2023-12-28T16:15:38.387' AS DateTime), N'00000003')
INSERT [dbo].[Cliente] ([id_cliente], [nombre_completo], [email], [telefono], [estado], [fecha_registro], [dni]) VALUES (3, N'DASDSA', N'', N'', 0, CAST(N'2023-12-28T16:27:01.093' AS DateTime), N'123321123')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (1, 1, N'menu_usuarios', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (2, 1, N'menu_productos', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (3, 1, N'menu_ventas', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (4, 1, N'menu_compras', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (5, 1, N'menu_clientes', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (6, 1, N'menu_proveedores', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (7, 1, N'menu_reportes', CAST(N'2023-12-23T18:09:41.997' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (8, 2, N'menu_ventas', CAST(N'2023-12-23T18:12:21.990' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (9, 2, N'menu_compras', CAST(N'2023-12-23T18:12:21.990' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (10, 2, N'menu_clientes', CAST(N'2023-12-23T18:12:21.990' AS DateTime))
INSERT [dbo].[Permiso] ([id_permiso], [id_rol], [nombre_menu], [fecha_registro]) VALUES (11, 2, N'menu_proveedores', CAST(N'2023-12-23T18:12:21.990' AS DateTime))
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
