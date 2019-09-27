Public Class Data_Product_Model
    Protected intMode As Integer = 3
    Public Const INSERT_MODE = 1
    Public Const REVISE_MODE = 2
    Public Const NORMAL_MODE = 3
    Protected Const SELECT_PRODPARTDATA_SQL = "SELECT ProdPartID,ProdPartData.SuID,ProdPartData.Name as ProdName,ProdPartData.Number as ProdNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM ProdPartData, SupplierData WHERE ProdPartData.SuID = SupplierData.SuID"
    Protected Const SELECT_FITTINGSET_SQL = "SELECT ProdPart2ID,ProdPartData2.SuID,ProdPartData2.Name as FitName,ProdPartData2.Number as FitNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM ProdPartData2, SupplierData WHERE ProdPartData2.SuID = SupplierData.SuID"
    Protected Const SELECT_PRODPARTDATA_FOR_STATEMENT_SQL = "SELECT ProdPartID,ProdPartData.SuID,ProdPartData.Name as ProdName,ProdPartData.Number as ProdNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM ProdPartData, SupplierData WHERE ProdPartData.SuID = SupplierData.SuID @statement"
    Protected Const SELECT_FITTING_FOR_STATEMENT_SQL = "SELECT ProdPart2ID,ProdPartData2.SuID,ProdPartData2.Name as FitName,ProdPartData2.Number as FitNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM ProdPartData2, SupplierData WHERE ProdPartData2.SuID = SupplierData.SuID @statement"
    Protected Const UPDATE_PRODPARTDATA_SQL = "UPDATE ProdPartData SET SuID = '@suID', Name = N'@prodName', Number = N'@prodNumber'  WHERE ProdPartID = @prodPartID"
    Protected Const UPDATE_FITTINGSET_SQL = "UPDATE ProdPartData2 SET SuID = '@suID', Name = N'@fitName', Number = N'@fitNumber' WHERE ProdPart2ID = @prodPart2ID"
    Protected Const INSERT_PRODPARTDATA_SQL = "INSERT INTO ProdPartData (SuID,Name,Number) VALUES('@suID',N'@prodName',N'@prodNumber'); SELECT @@IDENTITY"
    Protected Const INSERT_FITTINGSET_SQL = "INSERT INTO ProdPartData2 (SuID,Name,Number) VALUES('@suID',N'@fitName',N'@fitNumber'); SELECT @@IDENTITY"
    Protected Const DELETE_PRODPARTDATA_SQL = "DELETE FROM ProdPartData WHERE ProdPartID = @prodPartID"
    Protected Const DELETE_FITTINGSET_SQL = "DELETE FROM ProdPartData2 WHERE ProdPart2ID = @prodPart2ID"
    Protected Const SELECT_SUPPLIERDATA_SQL = "SELECT * FROM SupplierData"
    Protected Const SELECT_PURCHASEDATA_FOR_PRODID_SQL = "SELECT TOP 3 PurchasePart.PurchaseID,PurchaseData.PurchaseNO,PurchasePart.Specification,PurchasePart.[Count],PurchaseData.InsertTime,PurchaseData.CaseID, CaseData.Place FROM PurchasePart,PurchaseData,CaseData WHERE PurchasePart.ProdPartID = @prodPartID AND PurchaseData.PurchaseID = PurchasePart.PurchaseID AND CaseData.CaseID = PurchaseData.CaseID ORDER BY PurchaseData.InsertTime DESC"
    Protected Const SELECT_PURCHASEDATA_FOR_FITID_SQL = "SELECT TOP 3 PurchasePart2.PurchaseID,PurchaseData.PurchaseNO,PurchasePart2.Specification,PurchasePart2.[Count],PurchaseData.InsertTime,PurchaseData.CaseID, CaseData.Place FROM PurchasePart2,PurchaseData,CaseData WHERE PurchasePart2.ProdPart2ID = @prodPart2ID AND PurchaseData.PurchaseID = PurchasePart2.PurchaseID AND caseData.CaseID = PurchaseData.CaseID ORDER BY PurchaseData.InsertTime DESC"
    Protected listSuID As List(Of Integer) = New List(Of Integer)
    Public Structure Prod
        Dim ProdPartID As Integer
        Dim ProdName As String
        Dim SupplierName As String
        Dim ProdNumber As String
        Dim SuID As Integer
    End Structure
    Public Structure PuchaseData
        Dim CaseID As Integer
        Dim CaseName As String
        Dim PurchaseID As Integer
        Dim PurchaseNo As String
        Dim Specification As String
        Dim Count As Integer
        Dim InsertTime As String
    End Structure
    Public Structure SupplierData
        Dim SuID As Integer
        Dim Name As String
    End Structure
End Class
