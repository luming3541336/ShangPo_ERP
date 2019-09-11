
Public Class Output_SaleReport_Model
    Inherits Set_Sale_Model
    Protected Const SEARCH_PURCHASE_PROD_SQL = "SELECT PurchaseProd.PurchasePID, SupplierData.[Name] as SupplierName , SupplierData.Abbr,ProdSet.[Name] as ProdName,PurchaseProd.Specification,PurchaseProd.Width,PurchaseProd.[Length],PurchaseProd.CBM,PurchaseData.InsertTime,PurchaseProd.[Count],PurchaseProd.Remark FROM SupplierData,ProdSet,PurchaseProd,PurchaseData
                                                                                                WHERE ProdSet.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchaseProd.PurchaseID AND PurchaseProd.ProdID = ProdSet.ProdID AND PurchaseData.CaseID =@caseID ORDER BY InsertTime"
    Protected Const SEARCH_SALE_PROD_SQL = "SELECT SaleData.InsertTime,SaleProd.[Count],SaleProd.PIC FROM SaleData,SaleProd WHERE SaleData.SaleID = SaleProd.SaleID AND SaleProd.PurchasePID = @PurchasePID"
    Protected Const SEARCH_PURCHASE_FIT_SQL = "SELECT PurchaseFit.PurchaseFID,SupplierData.[Name] as SupplierName, SupplierData.Abbr,FittingSet.[Name] as FitName,PurchaseFIt.Specification,PurchaseFIt.Width,PurchaseFIt.[Length],PurchaseFIt.CBM,PurchaseData.InsertTime,PurchaseFit.[Count], PurchaseFit.Remark FROM SupplierData,FittingSet,PurchaseFit,PurchaseData
                                                                                        WHERE FittingSet.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchaseFit.PurchaseID AND PurchaseFit.FitID = FittingSet.FitID AND PurchaseData.CaseID =@caseID"
    Protected Const SEARCH_SALE_FIT_SQL = "SELECT SaleData.InsertTime,SaleFit.[Count],SaleFit.PIC FROM SaleData,SaleFit WHERE SaleData.SaleID = SaleFit.SaleID AND SaleFit.PurchaseFID = @PurchaseFID"
    Protected Const SEARCH_CASEID_SQL = "SELECT Place,CaseID,Address,Phone,State,SalesName FROM CaseData WHERE CaseID = '@caseID' AND State < 2"
    Protected Const SEARCH_WORKDETAIL_SQL = "SELECT * FROM WorkDetail Where CaseID = @id"
    'Ver 2 
    Protected Const SELECT_SHIPRECORD_PROD_SQL = "SELECT PurchaseProd.PurchasePID,SupplierData.Abbr AS SupplierName,ProdSet.[Name] AS ProductName,PurchaseProd.Specification,PurchaseProd.Width,PurchaseProd.Length,PurchaseProd.CBM,PurchaseData.InsertTime AS PurchaseTime,PurchaseProd.[Count] AS PurchaseCount,PurchaseProd.Remark,A.InsertTime AS SaleTime,A.[Count] AS SaleCount,A.PIC FROM ProdSet,SupplierData,PurchaseData,PurchaseProd LEFT JOIN (SELECT SaleProd.PurchasePID,SaleData.InsertTime,SaleProd.[Count],SaleProd.PIC FROM SaleData,SaleProd WHERE SaleProd.SaleID = SaleData.SaleID) AS A ON PurchaseProd.PurchasePID = A.PurchasePID WHERE SupplierData.SuID = ProdSet.SuID AND PurchaseData.PurchaseID = PurchaseProd.PurchaseID AND PurchaseProd.ProdID = ProdSet.ProdID  AND PurchaseData.CaseID = @caseID  @statement ORDER BY PurchaseProd.PurchasePID"
    Protected Const SELECT_SHIPRECORD_FIT_SQL = "SELECT PurchaseFIt.PurchaseFID,SupplierData.Abbr AS SupplierName,FittingSet.[Name] AS ProductName,PurchaseFIt.Specification,PurchaseFit.Width,PurchaseFit.Length,PurchaseFit.CBM,PurchaseData.InsertTime  AS PurchaseTime,PurchaseFit.Remark,PurchaseFit.[Count] AS PurchaseCount,A.InsertTime AS SaleTime,A.[Count]  AS SaleCount,A.PIC FROM FittingSet,SupplierData,PurchaseData,PurchaseFIt LEFT JOIN (SELECT SaleFit.PurchaseFID,SaleData.InsertTime,SaleFit.[Count],SaleFit.PIC FROM SaleData,SaleFit WHERE SaleFit.SaleID = SaleData.SaleID) AS A  ON PurchaseFit.PurchaseFID = A.PurchaseFID WHERE SupplierData.SuID = FittingSet.SuID AND PurchaseData.PurchaseID = PurchaseFit.PurchaseID AND PurchaseFit.FitID = FittingSet.FitID  AND PurchaseData.CaseID = @caseID @statement Order By PurchaseFit.PurchaseFID"
    Public CaseList As List(Of CaseData) = New List(Of CaseData)

    Public Structure PurchaseProd
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
    Public Structure PurchaseFit
        Dim PurchaseFID As Integer
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
    Public Structure SaleProd
        Dim Count As String
        Dim InsertTime As Date
        Dim PIC As String
    End Structure
    Public Structure SaleFit
        Dim Count As String
        Dim InsertTime As Date
        Dim PIC As String
    End Structure
    Public Structure CaseData
        Dim Place As String
        Dim CaseID As Integer
        Dim Address As String
        Dim Phone As String
        Dim State As Integer
        Dim SalesName As String
    End Structure
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
