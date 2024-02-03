CREATE TABLE [dbo].[Empleados]
(
	[id] INT PRIMARY KEY,
    [dni] NVARCHAR(20),
    [nombre] NVARCHAR(50),
    [apellido1] NVARCHAR(50),
    [apellido2] NVARCHAR(50),
    [puesto] NVARCHAR(100),
    [correo] NVARCHAR(100),
    [comentarios] NVARCHAR(MAX),
    [telefono] INT,
    [numSS] BIGINT,
    [fechaNacimiento] DATETIME
)
