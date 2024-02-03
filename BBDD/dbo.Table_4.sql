CREATE TABLE [dbo].[Proyectos]
(
	[codigo] INT PRIMARY KEY,
    [presupuestoInicial] FLOAT,
    [presupuestoActual] FLOAT,
    [fechaInicio] DATETIME,
    [fechaFin] DATETIME,
    [codigoCliente] INT,
    [descripcion] NVARCHAR(MAX),
    [cambios] BIT,
    [estadoProyecto] NVARCHAR(50)
)
