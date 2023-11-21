DROP DATABASE IF EXISTS [Biblioteca]
GO
CREATE DATABASE [Biblioteca]
GO

USE [Biblioteca]
GO

-- Crear tabla de usuarios
CREATE TABLE [dbo].[usuarios](
    [idUsuario] [int] IDENTITY(1,1) NOT NULL,
    [usuario] [varchar](50) NOT NULL,
    [contraseña] [varchar](50) NOT NULL,
    [nombre] [varchar](50) NOT NULL,
    [apellido] [varchar](50) NOT NULL,
    [correo] [varchar](100) NOT NULL,
    [telefono] [varchar](20) NOT NULL,
    [fechaCreacion] [datetime] NOT NULL DEFAULT GETDATE(),
    PRIMARY KEY CLUSTERED ([idUsuario] ASC)
) ON [PRIMARY]
GO

-- Crear tabla de autores
CREATE TABLE [dbo].[autores](
    [idAutor] [int] IDENTITY(1,1) NOT NULL,
    [nombre] [varchar](50) NULL,
    [apellido] [varchar](50) NULL,
    PRIMARY KEY CLUSTERED ([idAutor] ASC)
) ON [PRIMARY]
GO



-- Crear tabla de estadoLibro
CREATE TABLE [dbo].[estadoLibro](
    [idestadoLibro] [int] IDENTITY(1,1) NOT NULL,
    [estadoLibro] [varchar](30) NULL,
    PRIMARY KEY CLUSTERED ([idestadoLibro] ASC)
) ON [PRIMARY]
GO

-- Crear tabla de estadoPrestamo
CREATE TABLE [dbo].[estadoPrestamo](
    [idestadoPrestamo] [int] IDENTITY(1,1) NOT NULL,
    [estadoPrestamo] [varchar](30) NULL,
    PRIMARY KEY CLUSTERED ([idestadoPrestamo] ASC)
) ON [PRIMARY]
GO

-- Crear tabla de libros
CREATE TABLE [dbo].[libros](
    [idLibro] [int] IDENTITY(1,1) NOT NULL,
    [idAutor] [int] NULL,
    [idestadoLibro] [int] NULL,
    [editorialLibro] [varchar](50) NULL,
    [nombreLibro] [varchar](100) NULL,
    [isbnLibro] [varchar](100) NULL,
    [generoLibro] [varchar](100) NULL,
    PRIMARY KEY CLUSTERED ([idLibro] ASC),
    CONSTRAINT FK_Libros_Autores FOREIGN KEY ([idAutor]) REFERENCES [dbo].[autores] ([idAutor]),
    CONSTRAINT FK_Libros_EstadoLibro FOREIGN KEY ([idestadoLibro]) REFERENCES [dbo].[estadoLibro] ([idestadoLibro])
) ON [PRIMARY]
GO

-- Crear tabla de prestamos
CREATE TABLE [dbo].[prestamos](
    [idPrestamo] [int] IDENTITY(1,1) NOT NULL,
    [idestadoPrestamo] [int] NULL,
    [idLibro] [int] NULL,
    [idUsuario] [int] NULL,
    [clientePrestamo] [varchar](100) NULL,
    [fechaPrestamo] [date] NULL,
    [fechaDevolucionEstimada] [date] NULL,
    PRIMARY KEY CLUSTERED ([idPrestamo] ASC),
    CONSTRAINT FK_Prestamos_EstadoPrestamo FOREIGN KEY ([idestadoPrestamo]) REFERENCES [dbo].[estadoPrestamo] ([idestadoPrestamo]),
    CONSTRAINT FK_Prestamos_Libros FOREIGN KEY ([idLibro]) REFERENCES [dbo].[libros] ([idLibro]),
    CONSTRAINT FK_Prestamos_Usuarios FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[usuarios] ([idUsuario])
) ON [PRIMARY]
GO

-- Crear tabla de devoluciones
CREATE TABLE [dbo].[devoluciones](
    [idDevoluciones] [int] IDENTITY(1,1) NOT NULL,
    [idPrestamo] [int] NULL,
    [idUsuario] [int] NULL,
    [fechaDevolucionReal] [date] NULL,
    PRIMARY KEY CLUSTERED ([idDevoluciones] ASC),
    CONSTRAINT FK_Devoluciones_Prestamos FOREIGN KEY ([idPrestamo]) REFERENCES [dbo].[prestamos] ([idPrestamo]),
    CONSTRAINT FK_Devoluciones_Usuarios FOREIGN KEY ([idUsuario]) REFERENCES [dbo].[usuarios] ([idUsuario])
) ON [PRIMARY]
GO
---Insertando datos a estado libros
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Disponible');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Prestado');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('En reparación');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Perdido');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('En espera');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('En revisión');
INSERT INTO [dbo].[estadoLibro] ([estadoLibro]) VALUES ('Reservado');
GO

-- Insertar estados de préstamo
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('En curso');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Pendiente');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Finalizado');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Vencido');
INSERT INTO [dbo].[estadoPrestamo] ([estadoPrestamo]) VALUES ('Cancelado');
-- Inserta más estados si es necesario
