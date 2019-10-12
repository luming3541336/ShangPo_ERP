Public Class Data_Order_Model
    Protected Const SEARCH_PURCHASEDATA_FROM_CASEID = "SELECT PurchaseID AS ID, PurchaseNO AS Number, InsertTime  FROM PurchaseData WHERE CaseID = @caseID"
    Protected Const SEARCH_SHIPMENTDATA_FROM_CASEID = "SELECT ShipmentID AS ID, ShipmentNO AS Number, InsertTime FROM ShipmentData WHERE CaseID = @caseID"
    Protected Const SEARCH_PURCHASEPART_FROM_PURCHASEID = "SELECT ProdPartData.ProdPartID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData.Name,Specification,Width,[Length],CBM,[Count],Remark
                            From ProdPartData,PurchasePart,SupplierData WHERE ProdPartData.ProdPartID = PurchasePart.ProdPartID AND SupplierData.SuID = ProdPartData.SuID  AND PurchasePart.PurchaseID = @id"
    Protected Const SEARCH_SALEPROD_FROM_SALEID = "SELECT ProdPartData.ProdPartID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData.Name,Specification,Width,[Length],cbm,Sum(ShipmentPart.[Count]) AS [Count],Remark,PIC
                                From ProdPartData,PurchasePart,SupplierData,ShipmentPart WHERE ProdPartData.ProdPartID = PurchasePart.ProdPartID AND SupplierData.SuID = ProdPartData.SuID 
                                AND  ShipmentPart.ShipmentID = @id AND ShipmentPart.PurchasePID = PurchasePart.PurchasePID GROUP BY ProdPartData.ProdPartID,SupplierData.Name ,ProdPartData.Name,Specification,Width,[Length],cbm,Remark,PIC,Abbr"
    Protected Const SEARCH_PURCHASEPART2_FROM_PURCHASEID = "SELECT ProdPartData2.ProdPart2ID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData2.[Name],PurchasePart2.Specification,Width,[Length],CBM,[Count],Remark
                                From ProdPartData2,PurchasePart2,SupplierData WHERE ProdPartData2.ProdPart2ID = PurchasePart2.ProdPart2ID AND SupplierData.SuID = ProdPartData2.SuID AND PurchasePart2.PurchaseID = @id"
    Protected Const SEARCH_SALEFIT_FROM_SALEID = "SELECT ProdPartData2.ProdPart2ID,SupplierData.Name AS Supplier,SupplierData.Abbr, ProdPartData2.[Name],PurchasePart2.Specification,Width,[Length],CBM,sum(ShipmentPart2.Count) AS [Count],Remark,PIC
                                From ProdPartData2,PurchasePart2,SupplierData,ShipmentPart2 WHERE ProdPartData2.ProdPart2ID = PurchasePart2.ProdPart2ID AND SupplierData.SuID = ProdPartData2.SuID AND ShipmentPart2.ShipmentID = @id AND ShipmentPart2.PurchaseP2ID = PurchasePart2.PurchaseP2ID
                                GROUP BY ProdPartData2.ProdPart2ID,SupplierData.Name ,ProdPartData2.[Name],PurchasePart2.Specification,Width,[Length],CBM,Remark,PIC,Abbr"
    Protected Const DELETE_PURCHASEDATA_FROM_PURCHASEID = "DELETE FROM PurchaseData WHERE PurchaseID = @id"
    Protected Const DELETE_PURCHASEPART_FROM_PURCHASEID = "DELETE FROM PurchasePart WHERE PurchaseID = @id"
    Protected Const DELETE_PURCHASEPART2_FROM_PURCHASEID = "DELETE FROM PurchasePart2 WHERE PurchaseID = @id"
    Protected Const DELETE_SHIPMENTDATA_FROM_SALEID = "DELETE FROM ShipmentData WHERE ShipmentID = @id"
    Protected Const DELETE_SALEPROD_FROM_SALEID = "DELETE FROM ShipmentPart WHERE ShipmentID = @id"
    Protected Const DELETE_SALEFIT_FROM_SALEID = "DELETE FROM ShipmentPart2 WHERE ShipmentID = @id"
    Protected caseID As Integer = Nothing
    Protected dataType As Integer = Nothing
    Protected listOrder As List(Of OrderData) = Nothing
    Protected Place As String = Nothing
    Public Const TYPE_PURCHASE = &H120718
    Public Const TYPE_SALE = &H220718
    Public Structure OrderData
        Dim ID As Integer
        Dim Number As String
        Dim InsertTime As Date
    End Structure
    Public Structure ProdPartDetail
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
    Public Structure ProdPart2Detail
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
