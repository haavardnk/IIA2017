
CREATE PROCEDURE SampleValues

@TagId int,
@Value float,
@Quality float

AS

INSERT INTO HISTORY (TagId, Value, Quality, TimeStamp) VALUES (@TagId, @Value, @Quality, GETDATE())

GO



CREATE PROCEDURE AcknowledgeAlarm

@Acknowledged int

AS

UPDATE ALARM SET Acknowledged = @Acknowledged

GO