Public Class Set_Repair_Model
    Protected Const SELECT_CASEDATA_FOR_CASEID_SQL = "SELECT * FROM CaseData WHERE CaseID = @caseID"
    Protected Const SELECT_REPAIRDATA_FOR_REPAIRID_SQL = "SELECT * FROM RepairData WHERE RepairID = @repairData"
    Protected Const UPDATE_REPAIRDATA_STATUS_SQL = "UPDATE RepairData SET Status = @status WHERE RepairID = @id"
    Protected Const UPDATE_REPAIRDATA_SQL = "UPDATE RepairData SET RepairType = N'@repairType',Place= N'@place',Contact = N'@contact',Address = N'@address', Phone = N'@phone', Warranty = '@warranty', Remark = N'@remark', ETA = @eta, ArchiveDate = '@archiveDate', ArchiveLoginID = @loginID WHERE RepairID = @id "
    Protected Const INSERT_REPAIRDATA_SQL = "INSERT INTO RepairData(CaseID,RepairOrder,ArchiveLoginID,Status) VALUES('@caseID',N'@repairOrder',@id,1); SELECT @@IDENTITY as id "
    Protected Const SELECT_PAIRORDER_COUNT_SQL = "SELECT COUNT(RepairOrder)  AS OrderCount FROM RepairData WHERE RepairOrder LIKE N'@order%'"

End Class

