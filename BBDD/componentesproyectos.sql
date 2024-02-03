CREATE TABLE [dbo].[ComponentesProyectos]
(
	[codigoProyecto] NVARCHAR(50) PRIMARY KEY,
    [idEmpleado] NVARCHAR(50) PRIMARY KEY,
    [puesto] NVARCHAR(100),
    [porcentajeDedicacion] FLOAT,
    [extras] DECIMAL(18, 2)
)
