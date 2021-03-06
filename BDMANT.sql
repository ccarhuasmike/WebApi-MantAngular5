USE [bdMantenimiento]
GO
/****** Object:  Table [dbo].[tb_reporte]    Script Date: 21/01/2018 10:49:45 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_reporte](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[serie] [varchar](20) NULL,
	[numerodoc] [varchar](20) NULL,
	[nombre] [varchar](30) NULL,
	[descripcion] [varchar](25) NULL,
	[tipodocumento] [varchar](20) NULL,
	[precio_compra] [decimal](9, 2) NULL,
	[fechaproceso] [datetime] NULL,
	[fecharegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_reporte] ON 

INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (1, N'S001', N'00001', N'Clientes Demos', N'Billetera', N'Boleta', CAST(100.00 AS Decimal(9, 2)), CAST(N'2018-01-15 00:00:00.000' AS DateTime), CAST(N'2018-01-15 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (2, N'S002', N'00002', N'Clientes Demos', N'Billetera', N'Factura', CAST(300.00 AS Decimal(9, 2)), CAST(N'2018-01-15 00:00:00.000' AS DateTime), CAST(N'2018-01-14 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (3, N'S003', N'00003', N'Clientes Demos', N'Cartera', N'Boleta', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (5, N'S004', N'00004', N'Clientes Demos', N'Cartera', N'Boleta', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (6, N'S005', N'00005', N'Clientes Demos', N'Cartera', N'Boleta', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (7, N'S006', N'00006', N'Clientes Demos', N'Billetera', N'Factura', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (8, N'S007', N'00007', N'Clientes Demos', N'Cartera', N'Boleta', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (9, N'S008', N'00008', N'Clientes Demos', N'Cartera', N'Factura', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (10, N'S009', N'00009', N'Clientes Demos', N'Billetera', N'Boleta', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (11, N'S010', N'00010', N'Clientes Demos', N'Billetera', N'Boleta', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
INSERT [dbo].[tb_reporte] ([id], [serie], [numerodoc], [nombre], [descripcion], [tipodocumento], [precio_compra], [fechaproceso], [fecharegistro]) VALUES (12, N'S011', N'00011', N'Clientes Demos', N'Cartera', N'Factura', CAST(400.00 AS Decimal(9, 2)), CAST(N'2018-01-13 00:00:00.000' AS DateTime), CAST(N'2018-01-10 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_reporte] OFF
/****** Object:  StoredProcedure [dbo].[sp_listar_reporte]    Script Date: 21/01/2018 10:49:45 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_listar_reporte] 
@serie varchar(20),
@numerodoc varchar(20),
@fechaproceso_ini varchar(8),
@fechaproceso_fin varchar(8),
@vi_Pagina Int,  
@vi_RegistrosporPagina Int,  
@vi_RecordCount INT OUTPUT  
  
AS  
  
BEGIN  
--SET NOCOUNT ON Evita que se devuelva el mensaje que muestra el recuento del número de filas afectadas por una instrucción  
SET NOCOUNT ON;  
  
SELECT ROW_NUMBER()Over(Order by numerodoc Asc) As RowNum,  
	id ,
	serie ,
	numerodoc ,
	nombre ,
	descripcion ,
	tipodocumento ,
	precio_compra ,
	CONVERT(varchar(10),fechaproceso,103) as fechaproceso,
	CONVERT(varchar(10),fecharegistro,103) as fecharegistro	
 into #temporales  
FROM tb_reporte 
where 
	(serie = @serie or '' = @serie ) and 
	(numerodoc = @numerodoc or '' = @numerodoc ) and 
	CONVERT(varchar(10),fechaproceso,112) between @fechaproceso_ini and @fechaproceso_fin
  
set @vi_RecordCount  = (select  COUNT(*)  
      FROM #temporales  )
        
SELECT * FROM #temporales       
WHERE RowNum BETWEEN (@vi_Pagina - 1) * @vi_RegistrosporPagina + 1 AND @vi_Pagina * @vi_RegistrosporPagina  
  
DROP TABLE #temporales   
END

GO
