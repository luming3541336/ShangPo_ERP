Public Class Set_Repair_Model

    'CaseData資料表欄位指令
    Protected Const SELECT_CASEDATA_FOR_CASEID_SQL = "SELECT * FROM CaseData WHERE CaseID = @caseID"
    'RepairData資料表欄位指令
    Protected Const SELECT_REPAIRDATA_FOR_REPAIRID_SQL = "SELECT * FROM RepairData WHERE RepairID = @repairID"
    Protected Const UPDATE_REPAIRDATA_STATUS_SQL = "UPDATE RepairData SET Status = @status WHERE RepairID = @id"
    Protected Const UPDATE_REPAIRDATA_SQL = "UPDATE RepairData SET RepairPerson = N'@repairPerson',Place= N'@place',Contact = N'@contact',Address = N'@address', Phone = N'@phone', Warranty = '@warranty', Remark = N'@remark', ETA = '@eta', ArchiveDate = '@archiveDate', RepairResult = N'@result' WHERE RepairID = @id "
    Protected Const INSERT_REPAIRDATA_SQL = "INSERT INTO RepairData(CaseID,RepairOrder,Status) VALUES('@caseID',N'@repairOrder',1); SELECT @@IDENTITY as id "
    Protected Const SELECT_PAIRORDER_COUNT_SQL = "SELECT COUNT(RepairOrder)  AS OrderCount FROM RepairData WHERE RepairOrder LIKE N'@order%'"
    Protected Const DELETE_REPAIRDATA_SQL = "DELETE FROM RepairFile WHERE RepairID = @id DELETE FROM RepairAmount WHERE RepairID = @id DELETE FROM RepairProd WHERE RepairID = @id DELETE FROM RepairLog WHERE RepairID = @id DELETE FROM RepairData WHERE RepairID = @id"
    'RepairLog資料表欄位指令
    Protected Const SELECT_REPAIRLOG_FOR_REPAIRID_SQL = "SELECT * FROM RepairLog WHERE RepairID=@id"
    Protected Const INSERT_REPAIRLOG_SQL = "INSERT INTO RepairLog(RepairID,LoginID,LogDate,Remark) VALUES('@id',@loginID,'@date',N'@remark')"
    'LoginData資料表欄位指令
    Protected Const SELECT_LOGINDATA_FOR_LOGINID_SQL = "SELECT * FROM LoginData WHERE LoginID =@id"
    'ShipmentData資料表欄位指令
    Protected Const SELECT_SHIPMENTDATA_SQL = "SELECT ShipmentPID,ProdPartData.Name,ProdPartType = 1 FROM ShipmentPart,ProdPartData,PurchasePart,ShipmentData WHERE ShipmentPart.PurchasePID = PurchasePart.PurchasePID AND PurchasePart.ProdPartID = ProdPartData.ProdPartID AND ShipmentData.ShipmentID = ShipmentPart.ShipmentID AND ShipmentData.CaseID = @caseID 
                                                                                                            UNION SELECT ShipmentP2ID,ProdPartData2.Name,ProdPartType = 2 FROM ShipmentPart2,ProdPartData2,PurchasePart2,ShipmentData WHERE ShipmentPart2.PurchaseP2ID = PurchasePart2.PurchaseP2ID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID AND ShipmentData.ShipmentID = ShipmentPart2.ShipmentID AND ShipmentData.CaseID = @caseID"
    'RepairProd資料表欄位指令
    Protected Const INSERT_REPAIRPROD_SQL = "INSERT INTO RepairProd(RepairID,ProdPartType,ShipmentPID,ProdPartName,ProdPartCount,RepairRemark) VALUES(@id,@type,@shipmentPID,N'@name',@count,N'@remark')"
    Protected Const SELECT_REPAIRPROD_FOR_REPAIRID_SQL = "SELECT * FROM RepairProd WHERE RepairID = @id"
    Protected Const UPDATE_REPAIRPROD_SQL = "UPDATE RepairProd SET ProdPartType = @type, ShipmentPID = @shipmentPID, ProdPartName = N'@name',ProdPartCount = @count,RepairRemark = N'@remark' WHERE RepairProdID = @id"
    Protected Const DELETE_REPAIRPROD_SQL = "DELETE FROM RepairProd WHERE RepairProdID = @id"

    'RepairAmount資料表欄位指令
    Protected Const SELECT_REPAIRAMOUNT_SQL = "SELECT * FROM RepairAmount WHERE RepairID = @id"
    Protected Const INSERT_REPAIRAMOUNT_SQL = "INSERT INTO RepairAmount(RepairID,BillItem,RepairPrice) VALUES(@id,N'@item',@price)"
    Protected Const UPDATE_REPAIRAMOUNT_SQL = "UPDATE RepairAmount SET BillItem = N'@item', RepairPrice = @price WHERE RepairAmountID = @id"
    Protected Const DELETE_REPAIRAMOUNT_SQL = "DELETE FROM RepairAmount WHERE RepairAmountID = @id"
    'RepairFile資料表欄位指令
    Protected Const SELECT_REPAIRFILE_SQL = "SELECT * FROM RepairFile WHERE RepairID = @id"
    Protected Const UPDATE_REPAIRFILE_SQL = "UPDATE RepairFile SET RepairFileName = N'@name', RepairFilePath = N'@path' WHERE RepairFileID = @id"
    Protected Const INSERT_REPAIRFILE_SQL = "INSERT INTO RepairFile(RepairID, RepairFileName, RepairFilePath) VALUES(@id,N'@name',N'@path')"
    Protected Const DELETE_REPAIRFILE_SQL = "DELETE FROM RepairFile WHERE RepairFileID = @id"

End Class

