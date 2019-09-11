Public Class Data_Product_Model
    Protected intMode As Integer = 3
    Public Const INSERT_MODE = 1
    Public Const REVISE_MODE = 2
    Public Const NORMAL_MODE = 3
    Protected Const SELECT_PRODSET_SQL = "SELECT ProdID,ProdSet.SuID,ProdSet.Name as ProdName,ProdSet.Number as ProdNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM ProdSet, SupplierData WHERE ProdSet.SuID = SupplierData.SuID"
    Protected Const SELECT_FITTINGSET_SQL = "SELECT FitID,FittingSet.SuID,FittingSet.Name as FitName,FittingSet.Number as FitNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM FittingSet, SupplierData WHERE FittingSet.SuID = SupplierData.SuID"
    Protected Const SELECT_PRODSET_FOR_STATEMENT_SQL = "SELECT ProdID,ProdSet.SuID,ProdSet.Name as ProdName,ProdSet.Number as ProdNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM ProdSet, SupplierData WHERE ProdSet.SuID = SupplierData.SuID @statement"
    Protected Const SELECT_FITTING_FOR_STATEMENT_SQL = "SELECT FitID,FittingSet.SuID,FittingSet.Name as FitName,FittingSet.Number as FitNumber,SupplierData.Name as SupplierName,SupplierData.Number as SupplierNumber FROM FittingSet, SupplierData WHERE FittingSet.SuID = SupplierData.SuID @statement"
    Protected Const UPDATE_PRODSET_SQL = "UPDATE ProdSet SET SuID = '@suID', Name = N'@prodName', Number = N'@prodNumber'  WHERE ProdID = @prodID"
    Protected Const UPDATE_FITTINGSET_SQL = "UPDATE FittingSet SET SuID = '@suID', Name = N'@fitName', Number = N'@fitNumber' WHERE FitID = @fitID"
    Protected Const INSERT_PRODSET_SQL = "INSERT INTO ProdSet (SuID,Name,Number) VALUES('@suID',N'@prodName',N'@prodNumber'); SELECT @@IDENTITY"
    Protected Const INSERT_FITTINGSET_SQL = "INSERT INTO FittingSet (SuID,Name,Number) VALUES('@suID',N'@fitName',N'@fitNumber'); SELECT @@IDENTITY"
    Protected Const DELETE_PRODSET_SQL = "DELETE FROM ProdSet WHERE ProdID = @prodID"
    Protected Const DELETE_FITTINGSET_SQL = "DELETE FROM FittingSet WHERE FitID = @fitID"
    Protected Const SELECT_SUPPLIERDATA_SQL = "SELECT * FROM SupplierData"
    Protected Const SELECT_PURCHASEDATA_FOR_PRODID_SQL = "SELECT TOP 3 PurchaseProd.PurchaseID,PurchaseData.PurchaseNO,PurchaseProd.Specification,PurchaseProd.[Count],PurchaseData.InsertTime,PurchaseData.CaseID, CaseData.Place FROM PurchaseProd,PurchaseData,CaseData WHERE PurchaseProd.ProdID = @prodID AND PurchaseData.PurchaseID = PurchaseProd.PurchaseID AND CaseData.CaseID = PurchaseData.CaseID ORDER BY PurchaseData.InsertTime DESC"
    Protected Const SELECT_PURCHASEDATA_FOR_FITID_SQL = "SELECT TOP 3 PurchaseFit.PurchaseID,PurchaseData.PurchaseNO,PurchaseFit.Specification,PurchaseFit.[Count],PurchaseData.InsertTime,PurchaseData.CaseID, CaseData.Place FROM PurchaseFit,PurchaseData,CaseData WHERE PurchaseFit.FitID = @fitID AND PurchaseData.PurchaseID = PurchaseFit.PurchaseID AND caseData.CaseID = PurchaseData.CaseID ORDER BY PurchaseData.InsertTime DESC"
    Protected listSuID As List(Of Integer) = New List(Of Integer)
    Public Structure Prod
        Dim ProdID As Integer
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
