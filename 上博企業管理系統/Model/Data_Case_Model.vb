Public Class Data_Case_Model
    Protected Const SELECT_CASEDATA_FOR_STATE_SQL = "SELECT * FROM CaseData WHERE State = @state"
    Protected Const SELECT_PURCHASEPART_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,PurchasePID ,ProdPartData.[Name] as ProdName,SupplierData.Abbr as Supplier,Specification,[Count],Width ,[Length],CBM,Remark
                                                                                                                       FROM PurchasePart,PurchaseData,ProdPartData,SupplierData WHERE ProdPartData.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchasePart.PurchaseID AND PurchasePart.ProdPartID = ProdPartData.ProdPartID 
                                                                                                                       AND PurchaseData.CaseID = @caseID"
    Protected Const SELECT_SALEPROD_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,ShipmentPart.ShipmentPID ,ProdPartData.[Name] as ProdName,SupplierData.Abbr as Supplier, Specification ,SUM(ShipmentPart.[Count]) AS [Count]
                                                                                                          ,Width ,[Length] ,CBM ,Remark,PIC FROM PurchasePart,ProdPartData,SupplierData,ShipmentPart,ShipmentData WHERE ProdPartData.SuID = SupplierData.SuID  AND PurchasePart.ProdPartID = ProdPartData.ProdPartID AND ShipmentData.CaseID = @caseID  AND ShipmentData.ShipmentID = ShipmentPart.ShipmentID 
                                                                                                           AND ShipmentPart.PurchasePID = PurchasePart.PurchasePID Group by ShipmentPart.ShipmentPID,InsertTime,ProdPartData.[Name],SupplierData.abbr ,Specification ,Width ,[Length],CBM,Remark,PIC,abbr"
    Protected Const SELECT_PURCHASEPART2_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,PurchaseP2ID ,ProdPartData2.[Name] as FitName ,SupplierData.Abbr as Supplier, PurchasePart2.Specification,Width ,[Length],CBM,[Count],Remark
                                                                                                                 FROM PurchasePart2,PurchaseData,ProdPartData2,SupplierData WHERE ProdPartData2.SuID = SupplierData.SuID AND PurchaseData.PurchaseID = PurchasePart2.PurchaseID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID  AND PurchaseData.CaseID = @caseID"
    Protected Const SELECT_SALEFIT_FOR_CASEID_SQL = "SELECT  Convert(varchar(10),InsertTime,111) AS InsertTime,ShipmentPart2.ShipmentP2ID  ,ProdPartData2.[Name] as FitName , SupplierData.Abbr as Supplier,PurchasePart2.Specification,Sum(ShipmentPart2.[Count]) AS [Count],Width ,[Length],CBM,Remark,PIC
                                                                                                     FROM PurchasePart2,ShipmentData,ProdPartData2,SupplierData,ShipmentPart2 WHERE ProdPartData2.SuID = SupplierData.SuID AND ShipmentPart2.PurchaseP2ID = PurchasePart2.PurchaseP2ID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID AND ShipmentData.CaseID = @caseID AND ShipmentData.ShipmentID = ShipmentPart2.ShipmentID
                                                                                                     GROUP BY ShipmentPart2.ShipmentP2ID,InsertTime ,ProdPartData2.[Name] ,SupplierData.abbr,PurchasePart2.Specification,Remark,Width ,[Length],CBM,PIC,abbr"
    Protected Const SELECT_PURCHASE_COUNT_SQL = "SELECT Count(CaseID)as Count FROM PurchaseData WHERE CaseID = @caseID"
    Protected Const SELECT_SALE_COUNT_SQL = "SELECT Count(CaseID)as Count FROM ShipmentData WHERE CaseID = @caseID"
    Protected Const SELECT_PROD_UNSALE_ITEM_SQL = "SELECT PurchasePart.PurchasePID,ProdPartData.[Name] AS ProdName,SupplierData.[Name] AS Supplier,PurchasePart.Specification,PurchasePart.[Count],Width,[Length],CBM,PurchasePart.Remark,([PurchasePart].[Count] - SUM(ISNULL(ShipmentPart.[Count], 0))) AS RemainAmount
                                              FROM PurchasePart LEFT JOIN ShipmentPart ON PurchasePart.PurchasePID = ShipmentPart.PurchasePID, ProdPartData,SupplierData,CaseData,PurchaseData
                                              WHERE PurchasePart.ProdPartID = ProdPartData.ProdPartID AND ProdPartData.SuID = SupplierData.SuID AND CaseData.CaseID = @caseID AND PurchaseData.CaseID = CaseData.CaseID AND PurchaseData.PurchaseID = PurchasePart.PurchaseID
                                              GROUP BY PurchasePart.PurchasePID,ProdPartData.[Name],PurchasePart.Specification,PurchasePart.[Count],Width,[Length],CBM,PurchasePart.Remark,SupplierData.[Name]
                                              Having ([PurchasePart].[Count] - SUM(ISNULL(ShipmentPart.[Count], 0))) > 0"
    Protected Const SELECT_FIT_UNSALE_ITEM_SQL = "SELECT PurchasePart2.PurchaseP2ID, ProdPartData2.[Name] AS FitName,SupplierData.[Name] As Supplier,PurchasePart2.Specification,PurchasePart2.[Count],PurchasePart2.Width,PurchasePart2.Length,PurchasePart2.Remark,(PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) As RemainAmount
                                               From PurchasePart2 LEFT Join ShipmentPart2 ON PurchasePart2.PurchaseP2ID = ShipmentPart2.PurchaseP2ID, ProdPartData2,SupplierData,CaseData,PurchaseData
                                               Where PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID And CaseData.CaseID = @caseID And PurchaseData.CaseID = CaseData.CaseID And PurchaseData.PurchaseID = PurchasePart2.PurchaseID
                                               Group By PurchasePart2.PurchaseP2ID, ProdPartData2.[Name], PurchasePart2.Specification, PurchasePart2.[Count],PurchasePart2.Width,PurchasePart2.Length, PurchasePart2.Remark, SupplierData.[Name]
                                               Having(PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) > 0"
    Protected Const UPDATE_CASEDATA_STATE_SQL = "Update CaseData SET State = @state, UpdateTime = GetDate() WHERE (CaseID = @caseID)"
    Protected Const SELECT_PURCHASEID_FOR_PROD_SQL = "SELECT PurchaseID FROM PurchasePart WHERE PurchasePID = @PID"
    Protected Const SELECT_SALEID_FOR_PROD_SQL = "SELECT ShipmentID FROM ShipmentPart WHERE ShipmentPID = @PID"
    Protected Const SELECT_PURCHASEID_FOR_FIT_SQL = "SELECT PurchaseID FROM PurchasePart2 WHERE PurchaseP2ID = @FID"
    Protected Const SELECT_SALEID_FOR_FIT_SQL = "SELECT ShipmentID FROM ShipmentPart2 WHERE ShipmentP2ID = @FID"
    Public Const UNSUCCESS_STATE = 0
    Public Const SUCCESS_STATE = 1
    Public Const CANCELCASE_STATE = 2

    'Public Structure CaseData
    '    Dim CaseID As Integer
    '    Dim CaseNo As String
    '    Dim Place As String
    '    Dim LoginID As Integer
    '    Dim InsertTime As String
    '    Dim UpdateTime As String
    '    Dim SalesName As String
    '    Dim State As Integer
    'End Structure
    Public Structure PurchasePart
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
    Public Structure PurchasePart2
        Dim PurchaseP2ID As Integer
        Dim InsertTime As String
        Dim Supplier As String
        Dim FitName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure
    Public Structure ShipmentPart
        Dim ShipmentPID As Integer
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
    Public Structure ShipmentPart2
        Dim ShipmentP2ID As Integer
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
