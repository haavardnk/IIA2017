-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE AddMeasurement
	-- Add the parameters for the stored procedure here
	@Value float,
	@Unit varchar(30),
	@Id int
AS

DECLARE
@TimeStamp datetime = getdate(),
@SensorId int

SELECT @SensorId = SensorId from SENSOR where SensorId = @Id

IF(@Unit = Celsius)
	BEGIN
	insert into LOG (CelsiusValue, TimeStamp, SensorId)
	values(@Value, @TimeStamp, @SensorId)
	END

ELSE
	BEGIN
	insert into LOG (FahrenheitValue, TimeStamp, SensorId)
	values(@Value, @TimeStamp, @SensorId)
	END

GO