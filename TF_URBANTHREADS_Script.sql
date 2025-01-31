
GO
ALTER DATABASE [TF_UrbanThreads] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET ARITHABORT OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TF_UrbanThreads] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TF_UrbanThreads] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TF_UrbanThreads] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TF_UrbanThreads] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET RECOVERY FULL 
GO
ALTER DATABASE [TF_UrbanThreads] SET  MULTI_USER 
GO
ALTER DATABASE [TF_UrbanThreads] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TF_UrbanThreads] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TF_UrbanThreads] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TF_UrbanThreads] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TF_UrbanThreads] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TF_UrbanThreads] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TF_UrbanThreads', N'ON'
GO
ALTER DATABASE [TF_UrbanThreads] SET QUERY_STORE = ON
GO
ALTER DATABASE [TF_UrbanThreads] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TF_UrbanThreads]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 26/06/2024 2:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Correo_Electronico] [varchar](100) NOT NULL,
	[Direccion] [varchar](255) NOT NULL,
	[Ciudad] [varchar](50) NOT NULL,
	[Pais] [varchar](50) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Sexo] [varchar](10) NOT NULL,
	[Fecha_de_Nacimiento] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Venta]    Script Date: 26/06/2024 2:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Venta](
	[ID_Venta] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio_Unitario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC,
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Metodos_Pago]    Script Date: 26/06/2024 2:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodos_Pago](
	[ID_Metodo_Pago] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Metodo_Pago] [varchar](20) NOT NULL,
	[Numero_Tarjeta] [varchar](20) NOT NULL,
	[Titular_Tarjeta] [varchar](100) NOT NULL,
	[Fecha_Caducidad] [date] NOT NULL,
	[CVV] [varchar](4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Metodo_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 26/06/2024 2:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Precio] [int] NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
	[Tallas_disponibles] [varchar](50) NOT NULL,
	[Color] [varchar](30) NOT NULL,
	[Stock] [int] NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 26/06/2024 2:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Proveedor] [varchar](100) NOT NULL,
	[Contacto] [varchar](100) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Direccion] [varchar](255) NOT NULL,
	[Correo_Electronico] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 26/06/2024 2:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Fecha_Venta] [datetime] NOT NULL,
	[Estado_Venta] [varchar](20) NOT NULL,
	[Total_Venta] [decimal](10, 2) NOT NULL,
	[ID_Metodo_Pago] [int] NOT NULL,
	[Costo_Envio] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalles_Venta]  WITH CHECK ADD FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalles_Venta]  WITH CHECK ADD FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[Metodos_Pago]  WITH CHECK ADD FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([ID_Metodo_Pago])
REFERENCES [dbo].[Metodos_Pago] ([ID_Metodo_Pago])
GO
ALTER TABLE [dbo].[Metodos_Pago]  WITH CHECK ADD CHECK  (([Metodo_Pago]='Debito' OR [Metodo_Pago]='Credito'))
GO
USE [master]
GO
ALTER DATABASE [TF_UrbanThreads] SET  READ_WRITE 
GO
use TF_UrbanThreads
go
INSERT INTO [dbo].[Clientes] ( DNI, Nombre, Apellido, Correo_Electronico, Direccion, Ciudad, Pais, Telefono, Sexo, Fecha_de_Nacimiento)
VALUES 
('12345678', 'Tito', 'Pérez', 'juan.perez@gmail.com', 'Calle Falsa 123', 'Lima', 'Peru', '555-1234', 'Masculino', '1985-01-01'),
('23456789', 'Ana', 'García', 'ana.garcia@gmail.com', 'Avenida Siempre Viva 742', 'Buenos Aires', 'Argentina', '555-2345', 'Femenino', '1990-02-02'),
('34567890', 'Pedro', 'López', 'pedro.lopez@gmail.com', 'Bulevar de la Luz 56', 'Bogota', 'Colombia', '555-3456', 'Masculino', '1988-03-03'),
('45678901', 'María', 'Martínez', 'maria.martinez@gmail.com', 'Calle del Sol 9', 'Brasilia', 'Brasil', '555-4567', 'Femenino', '1992-04-04'),
('56789012', 'Luis', 'Rodríguez', 'luis.rodriguez@gmail.com', 'Avenida Central 123', 'Montevideo', 'Uruguay', '555-5678', 'Masculino', '1983-05-05'),
('67890123', 'Laura', 'Fernández', 'laura.fernandez@gmail.com', 'Plaza Mayor 4', 'Ciudad de Mexico', 'Mexico', '555-6789', 'Femenino', '1995-06-06'),
('78901234', 'Carlos', 'González', 'carlos.gonzalez@gmail.com', 'Paseo de la Reforma 321', 'Paris', 'Francia', '555-7890', 'Masculino', '1987-07-07'),
('89012345', 'Sofía', 'Hernández', 'sofia.hernandez@gmail.com', 'Callejón del Beso 13', 'Roma', 'Italia', '555-8901', 'Femenino', '1993-08-08');
go
INSERT INTO [dbo].[Proveedores] (Nombre_Proveedor, Contacto, Telefono, Direccion, Correo_Electronico)
VALUES 
('Diego', 'Facebook', '555-5678', 'Avenida Principal 456', 'Diego@gmail.com'),
('Felipe', 'Instagram', '555-6789', 'Calle Secundaria 789', 'Felipe@gmail.com'),
('Manuel', 'Whatsapp', '555-7890', 'Bulevar Tercero 101', 'Manuel@gmail.com'),
('Carlos', 'Instagram', '555-8901', 'Plaza Cuarta 102', 'Carlos@gmail.com'),
('Mario', 'Facebook', '555-9012', 'Paseo Quinto 103', 'Mario@gmail.com'),
('Renato', 'Instagram', '555-0123', 'Avenida Sexta 104', 'Renato@gmail.com'),
('Michael', 'Whatsapp', '555-1234', 'Calle Séptima 105', 'Michael@gmail.com'),
('Armando', 'Facebook', '555-2345', 'Bulevar Octavo 106', 'Armando@gmail.com');

go
INSERT INTO [dbo].[Productos] ( Nombre, Precio, Categoria, Tallas_disponibles, Color, Stock, ID_Proveedor)
VALUES 
('Sudadera Urbana', 200, 'Invierno', 'S', 'Azul', 100, 1),
('Polera Grafiti', 150, 'Verano', 'M', 'Rojo', 150, 2),
('Camiseta Street', 100, 'Primavera', 'L', 'Verde', 200, 3),
('Chaqueta Skater', 250, 'Otoño', 'S', 'Negro', 50, 4),
('Jeans Ripped', 300, 'Invierno', 'M', 'Azul', 120, 5),
('Vestido Urbano', 180, 'Verano', 'L', 'Amarillo', 80, 6),
('Falda Hip-Hop', 130, 'Primavera', 'S', 'Blanco', 90, 7),
('Abrigo Streetwear', 350, 'Invierno', 'M', 'Gris', 70, 8);
go
INSERT INTO [dbo].[Metodos_Pago] (ID_Cliente, Metodo_Pago, Numero_Tarjeta, Titular_Tarjeta, Fecha_Caducidad, CVV)
VALUES 
(1, 'Credito', '1234-5678-9012-3456', 'Juan Pérez', '2025-12-31', '123'),
(2, 'Debito', '2345-6789-0123-4567', 'Ana García', '2026-01-31', '234'),
(3, 'Credito', '3456-7890-1234-5678', 'Pedro López', '2027-02-28', '345'),
(4, 'Debito', '4567-8901-2345-6789', 'María Martínez', '2028-03-31', '456'),
(5, 'Credito', '5678-9012-3456-7890', 'Luis Rodríguez', '2029-04-30', '567'),
(6, 'Debito', '6789-0123-4567-8901', 'Laura Fernández', '2030-05-31', '678'),
(7, 'Credito', '7890-1234-5678-9012', 'Carlos González', '2031-06-30', '789'),
(8, 'Debito', '8901-2345-6789-0123', 'Sofía Hernández', '2032-07-31', '890');
go



INSERT INTO [dbo].[Ventas] (ID_Cliente, Fecha_Venta, Estado_Venta, Total_Venta, ID_Metodo_Pago, Costo_Envio)
VALUES 
(1, '2024-06-25', 'Completado', 150.50, 2, 30.00),
(2, '2024-06-26', 'Completado', 200.75, 3, 70.00),
(3, '2024-06-27', 'Completado', 175.25, 4, 30.00),
(4, '2024-06-28', 'Completado', 225.00, 5, 70.00),
(5, '2024-06-29', 'Completado', 195.50, 6, 30.00),
(6, '2024-06-30', 'Completado', 205.75, 7, 30.00),
(7, '2024-07-01', 'Completado', 185.25, 8, 70.00),
(8, '2024-07-02', 'Completado', 175.00, 9, 70.00),
(2, '2024-07-03', 'Completado', 165.50, 3, 70.00),
(2, '2024-07-03', 'Completado', 165.50, 3, 30.00);
go
INSERT INTO [dbo].[Detalles_Venta] (ID_Venta, ID_Producto, Cantidad, Precio_Unitario)
VALUES 
(3, 1, 10, 50),
(4, 2, 15, 150),
(5, 3, 30, 200),
(6, 4, 25, 250),
(7, 5, 15, 300),
(8, 6, 40, 350),
(9, 7, 20, 400),
(10, 8, 10, 450);
go