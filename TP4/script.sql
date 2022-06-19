CREATE DATABASE [EmpleadosDB]
GO
USE [EmpleadosDB]
GO
CREATE TABLE [dbo].[Empleados](
[legajo] [int] IDENTITY(1000,1),
[nombre] [varchar](50) NOT NULL,
[apellido][varchar](50) NOT NULL,
[dni] [int] NOT NULL,
[puesto] [varchar](50) NOT NULL,
[sueldo] [float] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Empleados] ([nombre], [apellido], [dni], [puesto], [sueldo]) VALUES ('Jacinto', 'Pereyra', 43582129, 'Marketing', 32000)
INSERT [dbo].[Empleados] ([nombre], [apellido], [dni], [puesto], [sueldo]) VALUES ('Bonifacio', 'Rosales', 39585221, 'Ventas', 35000)
INSERT [dbo].[Empleados] ([nombre], [apellido], [dni], [puesto], [sueldo]) VALUES ('Hector', 'Clyde', 39585221, 'Ventas', 35000)