USE [SensorDatabase]
GO
/****** Object:  Trigger [dbo].[CalculateTempUnit]    Script Date: 02.04.2019 20:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER TRIGGER [dbo].[CalculateTempUnit] ON [dbo].[LOG]
   FOR UPDATE, INSERT
AS 

DECLARE
@CelsiusValue float,
@FahrenheitValue float,
@TimeStamp datetime

select @CelsiusValue = CelsiusValue from INSERTED
select @FahrenheitValue = FahrenheitValue from INSERTED
select @TimeStamp = TimeStamp from INSERTED

IF @CelsiusValue IS NOT NULL
update LOG set FahrenheitValue = ROUND(@CelsiusValue * 1.8 + 32, 1) where TimeStamp = @TimeStamp
ELSE
update LOG set CelsiusValue = ROUND((@FahrenheitValue - 32) / 1.8, 1) where TimeStamp = @TimeStamp

