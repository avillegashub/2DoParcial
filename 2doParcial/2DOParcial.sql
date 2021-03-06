USE [master]
GO
/****** Object:  Database [SegundoParcial]    Script Date: 24/11/2020 18:39:14 ******/
CREATE DATABASE [SegundoParcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SegundoParcial', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SegundoParcial.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SegundoParcial_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SegundoParcial_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SegundoParcial] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SegundoParcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SegundoParcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SegundoParcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SegundoParcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SegundoParcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SegundoParcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SegundoParcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SegundoParcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SegundoParcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SegundoParcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SegundoParcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SegundoParcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SegundoParcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SegundoParcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SegundoParcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SegundoParcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SegundoParcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SegundoParcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SegundoParcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SegundoParcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SegundoParcial] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SegundoParcial] SET  MULTI_USER 
GO
ALTER DATABASE [SegundoParcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SegundoParcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SegundoParcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SegundoParcial] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SegundoParcial]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 24/11/2020 18:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Dni] [numeric](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 24/11/2020 18:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Precio] [float] NOT NULL,
	[TiempoP] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(1 AS Numeric(18, 0)), N'Jose', N'Joseson', N'Av. Siempre Viva 1111', CAST(11111111 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(2 AS Numeric(18, 0)), N'Pablo', N'Pabloson', N'Av. Lejitos 4178', CAST(22222222 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(3 AS Numeric(18, 0)), N'Mario', N'Marioson', N'Av. Cerquita 9871', CAST(33333333 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(4 AS Numeric(18, 0)), N'Rodrigo', N'Rodrigoson', N'Av. Cruzando la Calle', CAST(44444444 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(5 AS Numeric(18, 0)), N'Ramon', N'Ramonson', N'Calle Sin Retorno 4125', CAST(55555555 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(6 AS Numeric(18, 0)), N'Carlos ', N'Carlosson', N'Calle Ciega 12451', CAST(66666666 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(7 AS Numeric(18, 0)), N'Estoy', N'Cansado', N'Quiero dormir', CAST(77777777 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(8 AS Numeric(18, 0)), N'MenteN', N'Blanco', N'NoSe Street 124', CAST(88888888 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(9 AS Numeric(18, 0)), N'Esa', N'Persona', N'AlgunLugar', CAST(99999999 AS Numeric(18, 0)))
INSERT [dbo].[Clientes] ([ID], [Nombre], [Apellido], [Direccion], [Dni]) VALUES (CAST(10 AS Numeric(18, 0)), N'Aquella', N'Persona', N'En la calle', CAST(10101010 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(1 AS Numeric(18, 0)), N'Hamburguesas', 9.79, CAST(3000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(2 AS Numeric(18, 0)), N'Pancho', 8.79, CAST(2000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(3 AS Numeric(18, 0)), N'Pizza', 10.79, CAST(4000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(4 AS Numeric(18, 0)), N'Arepa', 6.69, CAST(1000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(5 AS Numeric(18, 0)), N'Nachos', 4.69, CAST(1000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(6 AS Numeric(18, 0)), N'Combo1', 12.69, CAST(4000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(7 AS Numeric(18, 0)), N'Combo2', 13.69, CAST(4000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(8 AS Numeric(18, 0)), N'Combo3', 14.69, CAST(4000 AS Numeric(18, 0)))
INSERT [dbo].[Productos] ([Id], [Nombre], [Precio], [TiempoP]) VALUES (CAST(10 AS Numeric(18, 0)), N'Bebida ', 0.69, CAST(0 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
USE [master]
GO
ALTER DATABASE [SegundoParcial] SET  READ_WRITE 
GO
