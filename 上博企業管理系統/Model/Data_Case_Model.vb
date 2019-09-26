Public Class Data_Case_Model
    Protected Const SELECT_CASEDATA_FOR_STATE_SQL = "SELECT * FROM CaseData WHERE State = @state"
    Protected Const SELECT_PURCHASEPROD_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,PurchasePID ,ProdPartData.[Name] as ProdName,SupplierData.Abbr as Supplier,Specification,[Count],Width ,[Length],CBM,Remark
                                                                                                                       FROM PurchaseProd,PurchaseData,ProdPartData,SupplierData WHERE ProdPartData.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchaseProd.PurchaseID AND PurchaseProd.ProdPartID = ProdPartData.ProdPartID 
                                                                                                                       AND PurchaseData.CaseID = @caseID"
    Protected Const SELECT_SALEPROD_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,SaleProd.SalePID ,ProdPartData.[Name] as ProdName,SupplierData.Abbr as Supplier, Specification ,SUM(SaleProd.[Count]) AS [Count]
                                                                                                          ,Width ,[Length] ,CBM ,Remark,PIC FROM PurchaseProd,ProdPartData,SupplierData,SaleProd,SaleData WHERE ProdPartData.SuID = SupplierData.SuID  AND PurchaseProd.ProdPartID = ProdPartData.ProdPartID AND SaleData.CaseID = @caseID  AND SaleData.SaleID = SaleProd.SaleID 
                                                                                                           AND SaleProd.PurchasePID = PurchaseProd.PurchasePID Group by SaleProd.SalePID,InsertTime,ProdPartData.[Name],SupplierData.abbr ,Specification ,Width ,[Length],CBM,Remark,PIC,abbr"
    Protected Const SELECT_PURCHASEFIT_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,PurchaseFID ,ProdPartData2.[Name] as FitName ,SupplierData.Abbr as Supplier, PurchaseFit.Specification,Width ,[Length],CBM,[Count],Remark
                                                                                                                 FROM PurchaseFIt,PurchaseData,ProdPartData2,SupplierData WHERE ProdPartData2.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchaseFIt.PurchaseID AND PurchaseFIt.ProdPart2ID = ProdPartData2.ProdPart2ID  AND PurchaseData.CaseID = @caseID"
    Protected Const SELECT_SALEFIT_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,SaleFit.SaleFID  ,ProdPartData2.[Name] as FitName , SupplierData.Abbr as Supplier,PurchaseFit.Specification,Sum(SaleFit.[Count]) AS [Count],Width ,[Length],CBM,Remark,PIC
                                                                                                     FROM PurchaseFit,SaleData,ProdPartData2,SupplierData,SaleFit WHERE ProdPartData2.SuID = SupplierData.SuID AND SaleFit.PurchaseFID = PurchaseFit.PurchaseFID AND PurchaseFit.ProdPart2ID = ProdPartData2.ProdPart2ID AND SaleData.CaseID = @caseID AND SaleData.SaleID = SaleFit.SaleID
                                                                                                     GROUP BY SaleFit.SaleFID,InsertTime ,ProdPartData2.[Name] ,SupplierData.abbr,PurchaseFit.Specification,Remark,Width ,[Length],CBM,PIC,abbr"
    Protected Const SELECT_PURCHASE_COUNT_SQL = "SELECT Count(CaseID)as Count FROM PurchaseData WHERE CaseID = @caseID"
    Protected Const SELECT_SALE_COUNT_SQL = "SELECT Count(CaseID)as Count FROM SaleData WHERE CaseID = @caseID"
    Protected Const SELECT_PROD_UNSALE_ITEM_SQL = "SELECT PurchaseProd.PurchasePID,ProdPartData.[Name] AS ProdName,SupplierData.[Name] AS Supplier,PurchaseProd.Specification,PurchaseProd.[Count],Width,[Length],CBM,PurchaseProd.Remark,([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) AS RemainAmount
                                              FROM PurchaseProd LEFT JOIN SaleProd ON PurchaseProd.PurchasePID = SaleProd.PurchasePID, ProdPartData,SupplierData,CaseData,PurchaseData
                                              WHERE PurchaseProd.ProdPartID = ProdPartData.ProdPartID AND ProdPartData.SuID = SupplierData.SuID AND CaseData.CaseID = @caseID AND PurchaseData.CaseID = CaseData.CaseID AND PurchaseData.PurchaseID = PurchaseProd.PurchaseID
                                              GROUP BY PurchaseProd.PurchasePID,prodSet.[Name],PurchaseProd.Specification,PurchaseProd.[Count],Width,[Length],CBM,PurchaseProd.Remark,SupplierData.[Name]
                                              Having ([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) > 0"
    Protected Const SELECT_FIT_UNSALE_ITEM_SQL = "SELECT PurchaseFit.PurchaseFID, ProdPartData2.[Name] AS FitName,SupplierData.[Name] As Supplier,PurchaseFit.Specification,PurchaseFit.[Count],PurchaseFit.Width,PurchaseFit.Length,PurchaseFit.Remark,(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) As RemainAmount
                                               From PurchaseFit LEFT Join SaleFit ON PurchaseFit.PurchaseFID = SaleFit.PurchaseFID, ProdPartData2,SupplierData,CaseData,PurchaseData
                                               Where PurchaseFit.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID And CaseData.CaseID = @caseID And PurchaseData.CaseID = CaseData.CaseID And PurchaseData.PurchaseID = PurchaseFit.PurchaseID
                                               Group By PurchaseFit.PurchaseFID, ProdPartData2.[Name], PurchaseFit.Specification, PurchaseFit.[Count],PurchaseFit.Width,PurchaseFit.Length, PurchaseFit.Remark, SupplierData.[Name]
                                               Having(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) > 0"
    Protected Const UPDATE_CASEDATA_STATE_SQL = "Update CaseData SET State = @state, UpdateTime = GetDate() WHERE (CaseID = @caseID)"
    Protected Const SELECT_PURCHASEID_FOR_PROD_SQL = "SELECT PurchaseID FROM PurchaseProd WHERE PurchasePID = @PID"
    Protected Const SELECT_SALEID_FOR_PROD_SQL = "SELECT SaleID FROM SaleProd WHERE SalePID = @PID"
    Protected Const SELECT_PURCHASEID_FOR_FIT_SQL = "SELECT PurchaseID FROM PurchaseFit WHERE PurchaseFID = @FID"
    Protected Const SELECT_SALEID_FOR_FIT_SQL = "SELECT SaleID FROM SaleFit WHERE SaleFID = @FID"
    Public Const UNSUCCESS_STATE = 0
    Public Const SUCCESS_STATE = 1
    Public Const CANCELCASE_STATE = 2

    Public Structure CaseData
        Dim CaseID As Integer
        Dim CaseNo As String
        Dim Place As String
        Dim LoginID As Integer
        Dim InsertTime As String
        Dim UpdateTime As String
        Dim SalesName As String
        Dim State As Integer
    End Structure
    Public Structure PurchaseProd
        Dim PurchasePID As Integer
        Dim InsertTime As String
        Dim Supplier As String
        Dim ProdName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure
    Public Structure PurchaseFit
        Dim PurchaseFID As Integer
        Dim InsertTime As String
        Dim Supplier As String
        Dim FitName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure
    Public Structure SaleProd
        Dim SalePID As Integer
        Dim InsertTime As String
        Dim Supplier As String
        Dim ProdName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim PIC As String
        Dim Remark As String
    End Structure
    Public Structure SaleFit
        Dim SaleFID As Integer
        Dim InsertTime As String
        Dim Supplier As String
        Dim FitName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim Count As Integer
        Dim PIC As String
        Dim Remark As String
    End Structure
    Public Structure UnsaleProd
        Dim ProdName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim RemainAmount As Integer
    End Structure
    Public Structure UnsaleFit
        Dim FitName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim RemainAmount As Integer
    End Structure
End Class
