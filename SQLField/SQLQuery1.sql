CREATE TRIGGER TRG_CaseData_INSERT ON CaseData
AFTER INSERT
AS
	SET NOCOUNT ON;
	INSERT INTO CaseData_Log(
	   [Type]
	  ,[CaseID]
      ,[CaseNo]
      ,[Place]
      ,[LoginID]
      ,[SalesName]
      ,[InsertTime]
      ,[UpdateTime]
      ,[Phone]
      ,[Contact]
      ,[Address]
      ,[Remark]
      ,[Success]
      ,[Del]
	  ,[LogUpdate])
	  SELECT 'I',CaseID,CaseNO,Place,LoginID,SalesName,InsertTime,UpdateTime,Phone,Contact,[Address],Remark,Success,Del,GETDATE() FROM inserted;
	  WAITFOR DELAY '00:00:02';
GO

CREATE TRIGGER TRG_CaseData_DELETE ON CaseData
AFTER DELETE
AS
	SET NOCOUNT ON;
	INSERT INTO CaseData_Log(
	   [Type]
	  ,[CaseID]
      ,[CaseNo]
      ,[Place]
      ,[LoginID]
      ,[SalesName]
      ,[InsertTime]
      ,[UpdateTime]
      ,[Phone]
      ,[Contact]
      ,[Address]
      ,[Remark]
      ,[Success]
      ,[Del]
	  ,[LogUpdate])
	  SELECT 'D',CaseID,CaseNO,Place,LoginID,SalesName,InsertTime,UpdateTime,Phone,Contact,[Address],Remark,Success,Del,GETDATE() FROM deleted;
	  WAITFOR DELAY '00:00:02';
GO

CREATE TRIGGER TRG_CaseData_UPDATE ON CaseData
AFTER UPDATE
AS
	SET NOCOUNT ON;
	INSERT INTO CaseData_Log(
	   [Type]
	  ,[CaseID]
      ,[CaseNo]
      ,[Place]
      ,[LoginID]
      ,[SalesName]
      ,[InsertTime]
      ,[UpdateTime]
      ,[Phone]
      ,[Contact]
      ,[Address]
      ,[Remark]
      ,[Success]
      ,[Del]
	  ,[LogUpdate])
	  SELECT 'U-I',CaseID,CaseNO,Place,LoginID,SalesName,InsertTime,UpdateTime,Phone,Contact,[Address],Remark,Success,Del,GETDATE() FROM inserted
	   UNION ALL
	  SELECT 'U-D',CaseID,CaseNO,Place,LoginID,SalesName,InsertTime,UpdateTime,Phone,Contact,[Address],Remark,Success,Del,GETDATE() FROM deleted
	  WAITFOR DELAY '00:00:02';
GO

