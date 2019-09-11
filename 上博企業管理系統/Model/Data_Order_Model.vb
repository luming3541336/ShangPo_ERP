Public Class Data_Order_Model
    Protected Const SEARCH_PURCHASEDATA_FROM_CASEID = "SELECT PurchaseID AS ID, PurchaseNO AS Number, InsertTime  FROM PurchaseData WHERE CaseID = @caseID"
    Protected Const SEARCH_SALEDATA_FROM_CASEID = "SELECT SaleID AS ID, SaleNO AS Number, InsertTime FROM SaleData WHERE CaseID = @caseID"
    Protected Const SEARCH_PURCHASEPROD_FROM_PURCHASEID = "SELECT ProdSet.ProdID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdSet.Name,Specification,Width,[Length],CBM,[Count],Remark
                            From ProdSet,PurchaseProd,SupplierData WHERE ProdSet.ProdID = PurchaseProd.ProdID AND SupplierData.SuID = ProdSet.SuID  AND PurchaseProd.PurchaseID = @id"
    Protected Const SEARCH_SALEPROD_FROM_SALEID = "SELECT ProdSet.ProdID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdSet.Name,Specification,Width,[Length],cbm,Sum(SaleProd.[Count]) AS [Count],Remark,PIC
                                From ProdSet,PurchaseProd,SupplierData,SaleProd WHERE ProdSet.ProdID = PurchaseProd.ProdID AND SupplierData.SuID = ProdSet.SuID 
                                AND  SaleProd.SaleID = @id AND SaleProd.PurchasePID = PurchaseProd.PurchasePID GROUP BY ProdSet.ProdID,SupplierData.Name ,ProdSet.Name,Specification,Width,[Length],cbm,Remark,PIC,Abbr"
    Protected Const SEARCH_PURCHASEFIT_FROM_PURCHASEID = "SELECT FittingSet.FitID,SupplierData.Name AS Supplier,SupplierData.Abbr, FittingSet.[Name],PurchaseFIt.Specification,Width,[Length],CBM,[Count],Remark
                                From FittingSet,PurchaseFIt,SupplierData WHERE FittingSet.FitID = PurchaseFIt.FitID AND SupplierData.SuID = FittingSet.SuID AND PurchaseFIt.PurchaseID = @id"
    Protected Const SEARCH_SALEFIT_FROM_SALEID = "SELECT FittingSet.FitID,SupplierData.Name AS Supplier,SupplierData.Abbr, FittingSet.[Name],PurchaseFIt.Specification,Width,[Length],CBM,sum(SaleFit.Count) AS [Count],Remark,PIC
                                From FittingSet,PurchaseFIt,SupplierData,SaleFit WHERE FittingSet.FitID = PurchaseFIt.FitID AND SupplierData.SuID = FittingSet.SuID AND SaleFIt.SaleID = @id AND SaleFit.PurchaseFID = PurchaseFIt.PurchaseFID
                                GROUP BY FittingSet.FitID,SupplierData.Name ,FittingSet.[Name],PurchaseFIt.Specification,Width,[Length],CBM,Remark,PIC,Abbr"
    Protected Const DELETE_PURCHASEDATA_FROM_PURCHASEID = "DELETE FROM PurchaseData WHERE PurchaseID = @id"
    Protected Const DELETE_PURCHASEPROD_FROM_PURCHASEID = "DELETE FROM PurchaseProd WHERE PurchaseID = @id"
    Protected Const DELETE_PURCHASEFIT_FROM_PURCHASEID = "DELETE FROM PurchaseFit WHERE PurchaseID = @id"
    Protected Const DELETE_SALEDATA_FROM_SALEID = "DELETE FROM SaleData WHERE SaleID = @id"
    Protected Const DELETE_SALEPROD_FROM_SALEID = "DELETE FROM SaleProd WHERE SaleID = @id"
    Protected Const DELETE_SALEFIT_FROM_SALEID = "DELETE FROM SaleFit WHERE SaleID = @id"
    Protected caseID As Integer = Nothing
    Protected dataType As Integer = Nothing
    Protected listOrder As List(Of OrderData) = Nothing
    Protected Place As String = Nothing
    Public Const TYPE_PURCHASE = &H120718
    Public Const TYPE_SALE = &H220718
    Public Structure OrderData
        Dim ID As Integer
        Dim Number As String
        Dim InsertTime As DateTime
    End Structure
    Public Structure ProdDetail
        Dim ProdID As Integer
        Dim SupplierName As String
        Dim Name As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
        Dim PIC As String
    End Structure
    Public Structure FitDetail
        Dim FitID As Integer
        Dim SupplierName As String
        Dim Name As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
        Dim PIC As String
    End Structure
End Class
