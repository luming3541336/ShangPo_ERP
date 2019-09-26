Public Class Data_Order_Model
    Protected Const SEARCH_PURCHASEDATA_FROM_CASEID = "SELECT PurchaseID AS ID, PurchaseNO AS Number, InsertTime  FROM PurchaseData WHERE CaseID = @caseID"
    Protected Const SEARCH_SALEDATA_FROM_CASEID = "SELECT SaleID AS ID, SaleNO AS Number, InsertTime FROM SaleData WHERE CaseID = @caseID"
    Protected Const SEARCH_PURCHASEPROD_FROM_PURCHASEID = "SELECT ProdPartData.ProdPartID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData.Name,Specification,Width,[Length],CBM,[Count],Remark
                            From ProdPartData,PurchaseProd,SupplierData WHERE ProdPartData.ProdPartID = PurchaseProd.ProdPartID AND SupplierData.SuID = ProdPartData.SuID  AND PurchaseProd.PurchaseID = @id"
    Protected Const SEARCH_SALEPROD_FROM_SALEID = "SELECT ProdPartData.ProdPartID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData.Name,Specification,Width,[Length],cbm,Sum(SaleProd.[Count]) AS [Count],Remark,PIC
                                From ProdPartData,PurchaseProd,SupplierData,SaleProd WHERE ProdPartData.ProdPartID = PurchaseProd.ProdPartID AND SupplierData.SuID = ProdPartData.SuID 
                                AND  SaleProd.SaleID = @id AND SaleProd.PurchasePID = PurchaseProd.PurchasePID GROUP BY ProdPartData.ProdPartID,SupplierData.Name ,ProdPartData.Name,Specification,Width,[Length],cbm,Remark,PIC,Abbr"
    Protected Const SEARCH_PURCHASEFIT_FROM_PURCHASEID = "SELECT ProdPartData2.ProdPart2ID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData2.[Name],PurchaseFIt.Specification,Width,[Length],CBM,[Count],Remark
                                From ProdPartData2,PurchaseFIt,SupplierData WHERE ProdPartData2.ProdPart2ID = PurchaseFIt.ProdPart2ID AND SupplierData.SuID = ProdPartData2.SuID AND PurchaseFIt.PurchaseID = @id"
    Protected Const SEARCH_SALEFIT_FROM_SALEID = "SELECT ProdPartData2.ProdPart2ID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData2.[Name],PurchaseFIt.Specification,Width,[Length],CBM,sum(SaleFit.Count) AS [Count],Remark,PIC
                                From ProdPartData2,PurchaseFIt,SupplierData,SaleFit WHERE ProdPartData2.ProdPart2ID = PurchaseFIt.ProdPart2ID AND SupplierData.SuID = ProdPartData2.SuID AND SaleFIt.SaleID = @id AND SaleFit.PurchaseFID = PurchaseFIt.PurchaseFID
                                GROUP BY ProdPartData2.ProdPart2ID,SupplierData.Name ,ProdPartData2.[Name],PurchaseFIt.Specification,Width,[Length],CBM,Remark,PIC,Abbr"
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
        Dim ProdPartID As Integer
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
        Dim ProdPart2ID As Integer
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
