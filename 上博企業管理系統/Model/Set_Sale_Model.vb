Public Class Set_Sale_Model
    Protected Const SELECT_PROD_REVIEW_BY_SALEID = "SELECT s.ShipmentPID as SaleDetailID, s.Count,s.PurchasePID as PurchaseDetailID, PurchasePart.Specification, PurchasePart.Width,PurchasePart.Length, PurchasePart.CBM, PurchasePart.Remark, ProdPartData.Name,SupplierData.Name As Supplier,SupplierData.Abbr,s.PIC,(Select PurchasePart.Count - SUM(ISNULL(ShipmentPart.Count, 0)) + s.Count As RemainAmount
                            FROM PurchasePart LEFT OUTER JOIN ShipmentPart On PurchasePart.PurchasePID = ShipmentPart.PurchasePID WHERE PurchasePart.PurchasePID = s.PurchasePID 
                            GROUP BY PurchasePart.Count ) As RemainAmount FROM ProdPartData INNER JOIN SupplierData On ProdPartData.SuID = SupplierData.SuID INNER JOIN PurchasePart  On ProdPartData.ProdPartID = PurchasePart.ProdPartID INNER JOIN
                            ShipmentPart s On PurchasePart.PurchasePID = s.PurchasePID  WHERE s.ShipmentID = @editID"
    Protected Const SELECT_FIT_REVIEW_BY_SALEID = "SELECT Fit.ShipmentP2ID as SaleDetailID,Fit.PurchaseP2ID as PurchaseDetailID ,Fit.[Count],Fit.PIC,PurchasePart2.Width, PurchasePart2.Length, PurchasePart2.CBM, PurchasePart2.Specification,PurchasePart2.Remark,ProdPartData2.ProdPart2ID,ProdPartData2.Name,SupplierData.Name as Supplier, SupplierData.Abbr ,(SELECT (PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) + Fit.Count AS RemainAmount
                           From PurchasePart2 LEFT Join ShipmentPart2 ON PurchasePart2.PurchaseP2ID = ShipmentPart2.PurchaseP2ID, ProdPartData2,SupplierData, PurchaseData
                           Where PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID  And PurchaseData.PurchaseID = PurchasePart2.PurchaseID AND PurchasePart2.PurchaseP2ID = Fit.PurchaseP2ID
                           Group By PurchasePart2.[Count]) as RemainAmount From ProdPartData2, SupplierData,PurchasePart2 ,ShipmentPart2 as Fit
                           Where ProdPartData2.SuID = SupplierData.SuID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID AND Fit.PurchaseP2ID = PurchasePart2.PurchaseP2ID AND ShipmentID = @editID"
    Protected Const SELECT_PROD_STOCK_BY_CASEID = "SELECT PurchasePart.PurchasePID as PurchaseDetailID, ProdPartData.[Name], SupplierData.[Name] AS Supplier,SupplierData.Abbr,PurchasePart.Specification,PurchasePart.[Count],Width,[Length],CBM,Remark,([PurchasePart].[Count] - SUM(ISNULL(ShipmentPart.[Count], 0))) AS RemainAmount
                                              From PurchasePart LEFT Join ShipmentPart ON PurchasePart.PurchasePID = ShipmentPart.PurchasePID, ProdPartData,SupplierData,PurchaseData
                                              Where PurchasePart.ProdPartID = ProdPartData.ProdPartID And ProdPartData.SuID = SupplierData.SuID And PurchaseData.CaseID = @caseID And PurchaseData.PurchaseID = PurchasePart.PurchaseID
                                              Group By PurchasePart.PurchasePID, ProdPartData.[Name], PurchasePart.Specification, PurchasePart.[Count], Width, [Length], CBM, Remark, SupplierData.[Name],SupplierData.Abbr
                                              Having([PurchasePart].[Count] - SUM(ISNULL(ShipmentPart.[Count], 0))) > 0"
    Protected Const SELECT_FIT_STOCK_BY_CASEID = "SELECT PurchasePart2.PurchaseP2ID as PurchaseDetailID, ProdPartData2.[Name], SupplierData.[Name] AS Supplier,SupplierData.Abbr,PurchasePart2.Width,PurchasePart2.[Length],PurchasePart2.CBM,PurchasePart2.Specification,PurchasePart2.[Count],Remark,(PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) AS RemainAmount
                                              From PurchasePart2 LEFT Join ShipmentPart2 ON PurchasePart2.PurchaseP2ID = ShipmentPart2.PurchaseP2ID, ProdPartData2,SupplierData, PurchaseData
                                               Where PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID And PurchaseData.CaseID = @caseID And PurchaseData.PurchaseID = PurchasePart2.PurchaseID
                                               Group By PurchasePart2.PurchaseP2ID, ProdPartData2.[Name], PurchasePart2.Specification, PurchasePart2.[Count], Remark, SupplierData.[Name],PurchasePart2.Width,PurchasePart2.[Length],PurchasePart2.CBM,SupplierData.Abbr
                                               Having(PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) > 0"
    Protected Const INSERT_SHIPMENTDATA_SQL = "INSERT INTO  ShipmentData(CaseID, ShipmentNO, InsertTime) VALUES(@caseID,N'@saleNO','@time'); SELECT id = SCOPE_IDENTITY() "
    Protected Const SELECT_SHIPMENTDATA_FOR_SALEID = "SELECT ShipmentNO FROM ShipmentData WHERE ShipmentID = @editID"
    Protected Const UPDATE_CASEDATA_FOR_UPDATETIME_SQL = "UPDATE CaseData SET UpdateTime = GETDATE() WHERE CaseID = @caseID"
    Protected Const UPDATE_SHIPMENTDATA_FOR_INSERTTIME_SQL = "UPDATE ShipmentData SET InsertTime = '@time' WHERE ShipmentID = @editID"
    Protected Const INSERT_SALEPROD_SQL = "INSERT INTO ShipmentPart(ShipmentID, PurchasePID, Count,PIC) VALUES(@id,N'@purchasePID',@count, N'@pic')"
    Protected Const UPDATE_SALEPROD_SQL = "UPDATE ShipmentPart SET PurchasePID = N'@purchasePID', Count = @count, PIC = N'@pic' WHERE ShipmentPID = @shipmentPID"
    Protected Const INSERT_SALEFIT_SQL = "INSERT INTO ShipmentPart2(ShipmentID, PurchaseP2ID, Count, PIC) VALUES(@id,@purchaseP2ID,@count,N'@pic')"
    Protected Const UPDATE_SALEFIT_SQL = "UPDATE ShipmentPart2 SET PurchaseP2ID = N'@purchaseP2ID', Count = @count, PIC = N'@pic' WHERE ShipmentP2ID = @shipmentP2ID"
    Protected Const DELETE_SALEPROD_SQL = "DELETE FROM ShipmentPart WHERE ShipmentPID = @shipmentPID"
    Protected Const DELETE_SALEFIT_SQL = "DELETE FROM ShipmentPart2 WHERE ShipmentP2ID = @shipmentP2ID"
    Protected Const SELECT_SHIPMENTDATA_FOR_INSERTTIME_SQL = "SELECT InsertTime FROM ShipmentData WHERE ShipmentID = @editID"
    Protected Const COUNT_SHIPMENTDATA = "SELECT COUNT(ShipmentNO)  FROM ShipmentData WHERE ShipmentNO LIKE 'S@dateStr%'"
    Public Const INSERT_MODE = &H147A2
    Public Const EDIT_MODE = &H139CC
    Public Const PRODUCT = &H40FA
    Public Const FIT = &H79AE
    Public Const OP_ADD = &H2388
    Public Const OP_EDIT = &H2898
    Public Const OP_DEL = &H332A
    Protected intMode As Integer = Nothing
    Protected caseID As Integer = Nothing
    Protected saleID As Integer = Nothing
    Protected removePDGV As List(Of Integer) = New List(Of Integer)
    Protected removeFDGV As List(Of Integer) = New List(Of Integer)

    Public Structure Stock
        Dim PurchaseDetailID As Integer
        Dim Name As String
        Dim Supplier As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Remark As String
        Dim RemainAmount As Integer
        Dim PIC As String
    End Structure
    Public Structure ShipmentData
        Dim SaleDetailID As Integer
        Dim PurchaseDetailID As Integer
        Dim Name As String
        Dim Supplier As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Remark As String
        Dim count As Integer
        Dim RemainAmount As Integer
        Dim PIC As String
    End Structure

End Class
