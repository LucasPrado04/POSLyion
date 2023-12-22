USE [master]
GO
/****** Object:  Database [POSLyion]    Script Date: 22/12/2023 13:34:40 ******/
CREATE DATABASE [POSLyion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POSLyion', FILENAME = N'D:\Programas\SQL Server 2022\Instancia Express\MSSQL16.SQLEXPRESS\MSSQL\DATA\POSLyion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POSLyion_log', FILENAME = N'D:\Programas\SQL Server 2022\Instancia Express\MSSQL16.SQLEXPRESS\MSSQL\DATA\POSLyion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [POSLyion] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POSLyion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POSLyion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POSLyion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POSLyion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POSLyion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POSLyion] SET ARITHABORT OFF 
GO
ALTER DATABASE [POSLyion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [POSLyion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POSLyion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POSLyion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POSLyion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POSLyion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POSLyion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POSLyion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POSLyion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POSLyion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [POSLyion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POSLyion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POSLyion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POSLyion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POSLyion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POSLyion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POSLyion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POSLyion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [POSLyion] SET  MULTI_USER 
GO
ALTER DATABASE [POSLyion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POSLyion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POSLyion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POSLyion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POSLyion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POSLyion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [POSLyion] SET QUERY_STORE = ON
GO
ALTER DATABASE [POSLyion] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [POSLyion]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_completo] [varchar](100) NOT NULL,
	[email] [varchar](155) NOT NULL,
	[telefono] [varchar](60) NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
	[dni] [varchar](12) NOT NULL,
 CONSTRAINT [PK_id_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_proveedor] [int] NULL,
	[monto_total] [decimal](12, 2) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_compra] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra_Detalle]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra_Detalle](
	[id_compradetalle] [int] IDENTITY(1,1) NOT NULL,
	[id_compra] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_compra] [decimal](9, 2) NOT NULL,
	[precio_venta] [decimal](9, 2) NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [decimal](12, 2) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_compradetalle] PRIMARY KEY CLUSTERED 
(
	[id_compradetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[id_permiso] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NOT NULL,
	[nombre_menu] [varchar](100) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_permiso] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](60) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[precio_costo] [decimal](9, 2) NOT NULL,
	[precio_venta] [decimal](9, 2) NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[email] [varchar](155) NOT NULL,
	[telefono] [varchar](60) NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](12) NOT NULL,
	[nombre_completo] [varchar](100) NOT NULL,
	[email] [varchar](155) NOT NULL,
	[clave] [varchar](155) NOT NULL,
	[id_rol] [int] NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[monto_total] [decimal](12, 2) NOT NULL,
	[monto_cambio] [decimal](6, 2) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
	[id_cliente] [int] NULL,
 CONSTRAINT [PK_id_venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta_Detalle]    Script Date: 22/12/2023 13:34:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta_Detalle](
	[id_ventadetalle] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_venta] [decimal](12, 2) NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [decimal](12, 2) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
 CONSTRAINT [PK_id_ventadetalle] PRIMARY KEY CLUSTERED 
(
	[id_ventadetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (1, N'Gaseosas', 1, CAST(N'2023-12-22T13:26:50.827' AS DateTime))
INSERT [dbo].[Categoria] ([id_categoria], [descripcion], [estado], [fecha_registro]) VALUES (2, N'Golosinas', 1, CAST(N'2023-12-22T13:26:50.827' AS DateTime))
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (1, N'0', N'Schweppes 500ml', 1, 3, CAST(233.33 AS Decimal(9, 2)), CAST(350.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (2, N'1', N'Pepsi 1L', 1, 3, CAST(821.54 AS Decimal(9, 2)), CAST(1020.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (3, N'2', N'Alfajor Tofi simple chocolate', 2, 10, CAST(121.98 AS Decimal(9, 2)), CAST(200.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
INSERT [dbo].[Producto] ([id_producto], [codigo], [descripcion], [id_categoria], [stock], [precio_costo], [precio_venta], [estado], [fecha_registro]) VALUES (4, N'3', N'Mantecol 50g', 2, 6, CAST(212.11 AS Decimal(9, 2)), CAST(330.00 AS Decimal(9, 2)), 1, CAST(N'2023-12-22T13:30:59.640' AS DateTime))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [descripcion], [email], [telefono], [estado], [fecha_registro]) VALUES (1, N'Arcor', N'arcor@hotmail.com', N'3794111111', 1, CAST(N'2023-12-22T13:33:37.210' AS DateTime))
INSERT [dbo].[Proveedor] ([id_proveedor], [descripcion], [email], [telefono], [estado], [fecha_registro]) VALUES (2, N'Quilmes', N'quilmes@outlook.com', N'3974222222', 0, CAST(N'2023-12-22T13:33:37.210' AS DateTime))
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([id_rol], [descripcion], [fecha_registro]) VALUES (1, N'admin', CAST(N'2023-12-22T13:23:17.223' AS DateTime))
INSERT [dbo].[Rol] ([id_rol], [descripcion], [fecha_registro]) VALUES (2, N'user', CAST(N'2023-12-22T13:23:35.287' AS DateTime))
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (1, N'12121212', N'mauricio', N'email@gmail.com', N'123', 2, 1, CAST(N'2023-12-22T13:24:49.010' AS DateTime))
INSERT [dbo].[Usuario] ([id_usuario], [dni], [nombre_completo], [email], [clave], [id_rol], [estado], [fecha_registro]) VALUES (2, N'21212121', N'lucas', N'email@outlook.com', N'321', 1, 1, CAST(N'2023-12-22T13:24:49.010' AS DateTime))
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Categoria] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Compra] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Compra_Detalle] ADD  DEFAULT ((0)) FOR [precio_compra]
GO
ALTER TABLE [dbo].[Compra_Detalle] ADD  DEFAULT ((0)) FOR [precio_venta]
GO
ALTER TABLE [dbo].[Compra_Detalle] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Permiso] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [stock]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [precio_costo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [precio_venta]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Rol] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Venta_Detalle] ADD  DEFAULT (getdate()) FOR [fecha_registro]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Proveedor]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Usuario]
GO
ALTER TABLE [dbo].[Compra_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Detalle] FOREIGN KEY([id_compra])
REFERENCES [dbo].[Compra] ([id_compra])
GO
ALTER TABLE [dbo].[Compra_Detalle] CHECK CONSTRAINT [FK_Compra_Detalle]
GO
ALTER TABLE [dbo].[Compra_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Compra_Detalle] CHECK CONSTRAINT [FK_Compra_Producto]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[Rol] ([id_rol])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK_Permiso_Rol]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[Rol] ([id_rol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_usuario_rol]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
GO
ALTER TABLE [dbo].[Venta_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Detalle] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Venta] ([id_venta])
GO
ALTER TABLE [dbo].[Venta_Detalle] CHECK CONSTRAINT [FK_Venta_Detalle]
GO
ALTER TABLE [dbo].[Venta_Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Venta_Detalle] CHECK CONSTRAINT [FK_Venta_Producto]
GO
USE [master]
GO
ALTER DATABASE [POSLyion] SET  READ_WRITE 
GO
