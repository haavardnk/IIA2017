-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
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
CREATE TRIGGER AlarmTrigger
   ON  HISTORY
   FOR UPDATE, INSERT
AS 
DECLARE
@TagId int,
@Value float,
@TimeStamp datetime,
@Ack bit,

@HH float,
@H float,
@L float,
@LL float,

@DescriptionHH char(100),
@DescriptionH char(100),
@DescriptionL char(100),
@DescriptionLL char(100)

select @TagId = TagId from INSERTED
select @Value = Value from INSERTED
select @TimeStamp = TimeStamp from INSERTED

select @HH = HH from ALARMCONFIG where TagId = @TagId
select @H = H from ALARMCONFIG where TagId = @TagId
select @L = L from ALARMCONFIG where TagId = @TagId
select @LL = LL from ALARMCONFIG where TagId = @TagId

select @DescriptionHH = DescriptionHH from ALARMCONFIG where TagId = @TagId
select @DescriptionH = DescriptionH from ALARMCONFIG where TagId = @TagId
select @DescriptionL = DescriptionL from ALARMCONFIG where TagId = @TagId
select @DescriptionLL = DescriptionLL from ALARMCONFIG where TagId = @TagId

-- Generating alarms
IF @Value >= @HH
BEGIN
	IF NOT EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'HH')
		INSERT INTO ALARM(TagId, ActivationTime, Acknowledged, AlarmType, Description, AlarmLimit) VALUES (@TagId, @TimeStamp, 0, 'HH', @DescriptionHH, @HH)
END
IF @Value >= @H
BEGIN
	IF NOT EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'H')
		INSERT INTO ALARM(TagId, ActivationTime, Acknowledged, AlarmType, Description, AlarmLimit) VALUES (@TagId, @TimeStamp, 0, 'H', @DescriptionH, @H)
END
IF @Value <= @L
BEGIN
	IF NOT EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'L')
		INSERT INTO ALARM(TagId, ActivationTime, Acknowledged, AlarmType, Description, AlarmLimit) VALUES (@TagId, @TimeStamp, 0, 'L', @DescriptionL, @L)
END
IF @Value <= @LL
BEGIN
	IF NOT EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'LL')
		INSERT INTO ALARM(TagId, ActivationTime, Acknowledged, AlarmType, Description, AlarmLimit) VALUES (@TagId, @TimeStamp, 0, 'LL', @DescriptionL, @LL)
END

-- Deleting alarms
IF @Value < @HH
BEGIN
	IF EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'HH')
	BEGIN
		select @Ack = Acknowledged FROM ALARM WHERE TagId = @TagId AND AlarmType = 'HH'
		IF @Ack = 1
			DELETE FROM ALARM WHERE TagId = @TagId AND AlarmType = 'HH'
	END
END

IF @Value < @H
BEGIN
	IF EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'H')
	BEGIN
		select @Ack = Acknowledged FROM ALARM WHERE TagId = @TagId AND AlarmType = 'H'
		IF @Ack = 1
			DELETE FROM ALARM WHERE TagId = @TagId AND AlarmType = 'H'
	END
END

IF @Value > @L
BEGIN
	IF EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'L')
	BEGIN
		select @Ack = Acknowledged FROM ALARM WHERE TagId = @TagId AND AlarmType = 'L'
		IF @Ack = 1
			DELETE FROM ALARM WHERE TagId = @TagId AND AlarmType = 'L'
	END
END

IF @Value > @LL
BEGIN
	IF EXISTS (SELECT * FROM ALARM WHERE TagId = @TagId AND AlarmType = 'LL')
	BEGIN
		select @Ack = Acknowledged FROM ALARM WHERE TagId = @TagId AND AlarmType = 'LL'
		IF @Ack = 1
			DELETE FROM ALARM WHERE TagId = @TagId AND AlarmType = 'LL'
	END
END