Public Class Set_Repair_Model
    Protected Const SELECT_CASEDATA_FOR_CASEID = "SELECT * FROM CaseData WHERE CaseID = @caseID"
    Protected Const SELECT_REPAIRDATA_FOR_REPAIRID = "SELECT * FROM RepairData WHERE RepairID = @repairData"
    Protected Const UPDATE_REPAIRDATA = "UPDATE RepairData SET RepairType = N'@repairType',Place= N'@place',Contact = N'@contact',Address = N'@address', Phone = N'@phone', Warranty = @warranty, Remark = N'@remark', ETA = @eta, ArchiveDate = @archiveDate, ArchiveLoginID = @loginID WHERE RepairID = @id "
    Protected Const INSERT_REPAIRDATA = "INSERT INTO RepairData(CaseID,RepairOrder) VALUES('@caseID',N'@repairOrder'); SELECT @@IDENTITY as id "
    Protected Const SELECT_PAIRORDER_COUNT = "SELECT COUNT(RepairOrder) WHERE RepairOrder = N'@order'"
End Class

