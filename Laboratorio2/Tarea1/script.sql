USE [Biblioteca]
GO
/****** Object:  Table [dbo].[autores]    Script Date: sábado 13:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[autores](
	[idAutor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[devoluciones]    Script Date: sábado 13:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devoluciones](
	[idDevoluciones] [int] IDENTITY(1,1) NOT NULL,
	[idPrestamo] [int] NULL,
	[fechaDevolucionReal] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDevoluciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estadoLibro]    Script Date: sábado 13:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estadoLibro](
	[idestadoLibro] [int] IDENTITY(1,1) NOT NULL,
	[estadoLibro] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idestadoLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estadoPrestamo]    Script Date: sábado 13:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estadoPrestamo](
	[idestadoPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[estadoPrestamo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idestadoPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[libros]    Script Date: sábado 13:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[libros](
	[idLibro] [int] IDENTITY(1,1) NOT NULL,
	[idAutor] [int] NULL,
	[idestadoLibro] [int] NULL,
	[editorialLibro] [varchar](50) NULL,
	[nombreLibro] [varchar](100) NULL,
	[isbnLibro] [varchar](100) NULL,
	[generoLibro] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prestamos]    Script Date: sábado 13:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prestamos](
	[idPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[idestadoPrestamo] [int] NULL,
	[idLibro] [int] NULL,
	[clientePrestamo] [varchar](100) NULL,
	[fechaPrestamo] [date] NULL,
	[fechaDevolucionEstimada] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[devoluciones]  WITH CHECK ADD FOREIGN KEY([idPrestamo])
REFERENCES [dbo].[prestamos] ([idPrestamo])
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD FOREIGN KEY([idAutor])
REFERENCES [dbo].[autores] ([idAutor])
GO
ALTER TABLE [dbo].[libros]  WITH CHECK ADD FOREIGN KEY([idestadoLibro])
REFERENCES [dbo].[estadoLibro] ([idestadoLibro])
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD FOREIGN KEY([idestadoPrestamo])
REFERENCES [dbo].[estadoPrestamo] ([idestadoPrestamo])
GO
ALTER TABLE [dbo].[prestamos]  WITH CHECK ADD FOREIGN KEY([idLibro])
REFERENCES [dbo].[libros] ([idLibro])
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
