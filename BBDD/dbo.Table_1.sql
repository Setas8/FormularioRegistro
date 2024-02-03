CREATE TABLE [dbo].[Clientes]
(
	[id] INT PRIMARY KEY,
    [nombre] NVARCHAR(100),
    [direccion] NVARCHAR(100),
    [ciudad] NVARCHAR(50),
    [pais] NVARCHAR(50),
    [nombreRepresentante] NVARCHAR(100),
    [correo] NVARCHAR(100),
    [nif] NVARCHAR(20),
    [tipoCliente] NVARCHAR(50),
    [descuento] INT,
    [comentarios] NVARCHAR(MAX),
    [logo] NVARCHAR(MAX),
    [telefono] NVARCHAR(20),
    [fechaAlta] DATETIME,
    [proximaCita] DATETIME,
    [ultimaCita] DATETIME
)
