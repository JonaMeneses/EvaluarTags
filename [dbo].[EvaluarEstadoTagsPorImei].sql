SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		JONATHAN DE JESUS MENESES MARQUEZ
-- Create date: 11/12/2019
-- Description:	SP QUE REALIZA LA EVALUACION DE LOS TAGS Y DEVUELVE SU ESTADO ACTUAL
-- =============================================
ALTER PROCEDURE [dbo].[EvaluarEstadoTagsPorImei]
@sImei varchar(20),
@nRespuesta int output
AS
BEGIN
	
	SET NOCOUNT ON;
DECLARE @UltimosReportes TABLE(IMEI varchar(20),Fecha datetime,Long varchar(50),Lat varchar(50),posiciondetectada bit)
declare @fechaUltimaOperacion datetime = 0;
select top 1 @fechaUltimaOperacion = Fecha_creacion from TagsWS_LogsOperacionesCreadas where Etiqueta = @sImei ORDER BY Fecha_Creacion DESC;

   
 -- select datediff(day,@fechaUltimaOperacion,Fecha)as diff,Fecha,@fechaUltimaOperacion as ultimA from @UltimosReportes 
 -- select count(imei) as imeis from @UltimosReportes where datediff(day,@fechaUltimaOperacion,Fecha) <= 30 and datediff(day,@fechaUltimaOperacion,Fecha) >= 0
if(select count (imei) from [tagsbd].[dbo].[PosicionamientoSocket] where tag = @sImei and posiciondetectada = 1 and datediff(day,@fechaUltimaOperacion,Fecha) <= 5 and datediff(day,@fechaUltimaOperacion,Fecha) >=-5) > 10
begin 
			set @nRespuesta = 1
end
else 
begin
	if (select count(imei) from [tagsbd].[dbo].[PosicionamientoSocket] where tag=@sImei and datediff(day,@fechaUltimaOperacion,Fecha) <= 10 and datediff(day,@fechaUltimaOperacion,Fecha) > 0) > 0
		begin 
			set @nRespuesta = 2
		end
		else
		begin
			set @nRespuesta = 3
		end
end

END
GO
