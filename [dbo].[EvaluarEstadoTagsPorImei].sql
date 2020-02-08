SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	JONATHAN DE JESUS MENESES MARQUEZ
-- Create date: 11/12/2019
-- Description:	SP QUE REALIZA LA EVALUACION DE LOS TAGS Y DEVUELVE SU ESTADO ACTUAL
-- =============================================
ALTER PROCEDURE [dbo].[EvaluarEstadoTagsPorImei]
@sImei varchar(20),
@nRespuesta int output
AS
BEGIN
SET NOCOUNT ON;
	
DECLARE @UltimosReportes TABLE(IMEI varchar(20),
				Fecha datetime,
				Long varchar(50),
				Lat varchar(50),
				posiciondetectada bit)
				
DECLARE @fechaUltimaOperacion datetime = 0;
SELECT TOP 1 @fechaUltimaOperacion = Fecha_creacion 
	FROM TagsWS_LogsOperacionesCreadas 
	WHERE Etiqueta = @sImei 
	ORDER BY Fecha_Creacion DESC;

   
 IF(select COUNT (imei) FROM [tagsbd].[dbo].[PosicionamientoSocket] 
 	WHERE tag = @sImei and posiciondetectada = 1 
	AND DATEDIFF(day,@fechaUltimaOperacion,Fecha) <= 5 
	AND DATEDIFF(day,@fechaUltimaOperacion,Fecha) >=-5) > 10
	BEGIN 
			set @nRespuesta = 1
	END
	ELSE 
	BEGIN
		IF (SELECT COUNT(imei) 
			FROM [tagsbd].[dbo].[PosicionamientoSocket] 
				WHERE tag=@sImei 
				AND datediff(day,@fechaUltimaOperacion,Fecha) <= 10 
				AND datediff(day,@fechaUltimaOperacion,Fecha) > 0) > 0
			BEGIN 
				set @nRespuesta = 2
			END
			ELSE
			BEGIN
				set @nRespuesta = 3
			END
	END

END
GO
