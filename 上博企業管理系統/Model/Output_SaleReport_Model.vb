
Public Class Output_SaleReport_Model
    Inherits Set_Sale_Model
    Protected Const SEARCH_PURCHASE_PROD_SQL = "SELECT PurchasePart.PurchasePID, SupplierData.[Name] as SupplierName , SupplierData.Abbr,ProdPartData.[Name] as ProdName,PurchasePart.Specification,PurchasePart.Width,PurchasePart.[Length],PurchasePart.CBM,PurchaseData.InsertTime,PurchasePart.[Count],PurchasePart.Remark FROM SupplierData,ProdPartData,PurchasePart,PurchaseData
                                                                                                WHERE ProdPartData.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchasePart.PurchaseID AND PurchasePart.ProdPartID = ProdPartData.ProdPartID AND PurchaseData.CaseID =@caseID ORDER BY InsertTime"
    Protected Const SEARCH_SALE_PROD_SQL = "SELECT ShipmentData.InsertTime,ShipmentPart.[Count],ShipmentPart.PIC FROM ShipmentData,ShipmentPart WHERE ShipmentData.ShipmentID = ShipmentPart.ShipmentID AND ShipmentPart.PurchasePID = @PurchasePID"
    Protected Const SEARCH_PURCHASE_FIT_SQL = "SELECT PurchasePart2.PurchaseP2ID,SupplierData.[Name] as SupplierName, SupplierData.Abbr,ProdPartData2.[Name] as FitName,PurchasePart2.Specification,PurchasePart2.Width,PurchasePart2.[Length],PurchasePart2.CBM,PurchaseData.InsertTime,PurchasePart2.[Count], PurchasePart2.Remark FROM SupplierData,ProdPartData2,PurchasePart2,PurchaseData
                                                                                        WHERE ProdPartData2.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchasePart2.PurchaseID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID AND PurchaseData.CaseID =@caseID"
    Protected Const SEARCH_SALE_FIT_SQL = "SELECT ShipmentData.InsertTime,ShipmentPart2.[Count],ShipmentPart2.PIC FROM ShipmentData,ShipmentPart2 WHERE ShipmentData.ShipmentID = ShipmentPart2.ShipmentID AND ShipmentPart2.PurchaseP2ID = @PurchaseP2ID"
    Protected Const SEARCH_CASEID_SQL = "SELECT Place,CaseID,Address,Phone,State,SalesName FROM CaseData WHERE CaseID = '@caseID' AND State < 2"
    Protected Const SEARCH_WORKDETAIL_SQL = "SELECT * FROM WorkDetail Where CaseID = @id"
    'Ver 2 
    Protected Const SELECT_SHIPRECORD_PROD_SQL = "SELECT PurchasePart.PurchasePID,SupplierData.Abbr AS SupplierName,ProdPartData.[Name] AS ProductName,PurchasePart.Specification,PurchasePart.Width,PurchasePart.Length,PurchasePart.CBM,PurchaseData.InsertTime AS PurchaseTime,PurchasePart.[Count] AS PurchaseCount,PurchasePart.Remark,A.InsertTime AS SaleTime,A.[Count] AS SaleCount,A.PIC FROM ProdPartData,SupplierData,PurchaseData,PurchasePart LEFT JOIN (SELECT ShipmentPart.PurchasePID,ShipmentData.InsertTime,ShipmentPart.[Count],ShipmentPart.PIC FROM ShipmentData,ShipmentPart WHERE ShipmentPart.ShipmentID = ShipmentData.ShipmentID) AS A ON PurchasePart.PurchasePID = A.PurchasePID WHERE SupplierData.SuID = ProdPartData.SuID AND PurchaseData.PurchaseID = PurchasePart.PurchaseID AND PurchasePart.ProdPartID = ProdPartData.ProdPartID  AND PurchaseData.CaseID = @caseID  @statement ORDER BY PurchasePart.PurchasePID"
    Protected Const SELECT_SHIPRECORD_FIT_SQL = "SELECT PurchasePart2.PurchaseP2ID,SupplierData.Abbr AS SupplierName,ProdPartData2.[Name] AS ProductName,PurchasePart2.Specification,PurchasePart2.Width,PurchasePart2.Length,PurchasePart2.CBM,PurchaseData.InsertTime  AS PurchaseTime,PurchasePart2.Remark,PurchasePart2.[Count] AS PurchaseCount,A.InsertTime AS SaleTime,A.[Count]  AS SaleCount,A.PIC FROM ProdPartData2,SupplierData,PurchaseData,PurchasePart2 LEFT JOIN (SELECT ShipmentPart2.PurchaseP2ID,ShipmentData.InsertTime,ShipmentPart2.[Count],ShipmentPart2.PIC FROM ShipmentData,ShipmentPart2 WHERE ShipmentPart2.ShipmentID = ShipmentData.ShipmentID) AS A  ON PurchasePart2.PurchaseP2ID = A.PurchaseP2ID WHERE SupplierData.SuID = ProdPartData2.SuID AND PurchaseData.PurchaseID = PurchasePart2.PurchaseID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID  AND PurchaseData.CaseID = @caseID @statement Order By PurchasePart2.PurchaseP2ID"
    Public CaseList As List(Of CaseData) = New List(Of CaseData)

    Public Structure PurchasePart
        Dim PurchasePID As Integer
        Dim ProdName As String
        Dim SupplierName As String
        Dim Specification As String
        Dim Count As String
        Dim InsertTime As Date
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Remark As String
    End Structure
    Public Structure PurchasePart2
        Dim PurchaseP2ID As Integer
        Dim FitName As String
        Dim SupplierName As String
        Dim Specification As String
        Dim Count As String
        Dim InsertTime As Date
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Remark As String
    End Structure
    Public Structure ShipmentPart
        Dim Count As String
        Dim InsertTime As Date
        Dim PIC As String
    End Structure
    Public Structure ShipmentPart2
        Dim Count As String
        Dim InsertTime As Date
        Dim PIC As String
    End Structure
    'Public Structure CaseData
    '    Dim Place As String
    '    Dim CaseID As Integer
    '    Dim Address As String
    '    Dim Phone As String
    '    Dim State As Integer
    '    Dim SalesName As String
    'End Structure
    Public Structure WorkProgress
        Dim DateTime As Date
        Dim Supplier As String
        Dim ProdName As List(Of String)
        Dim Specification As List(Of String)
        Dim Count As List(Of String)
    End Structure
    Public Structure WorkProgress_Sale
        Dim DateTime As Date
        Dim PIC As String
        Dim ProdName As List(Of String)
        Dim Specification As List(Of String)
    End Structure
    Public Structure WorkDetail
        Dim WorkDate As Date
        Dim SalesName As String
        Dim Detail As String
    End Structure
    'Ver 2
    Public Structure ShipRecord
        Dim PurchaseID As Integer
        Dim SupplierName As String
        Dim ProductName As String
        Dim Specification As String
        Dim Width As String
        Dim Length As String
        Dim CBM As String
        Dim PurchaseTime As String
        Dim PurchaseCount As String
        Dim SaleTime As String
        Dim SaleCount As String
        Dim PIC As String
        Dim Remark As String
    End Structure
End Class
