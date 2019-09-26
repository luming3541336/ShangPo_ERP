Public Class Set_Sale_Model
    Protected Const SELECT_PROD_REVIEW_BY_SALEID = "SELECT s.SalePID as SaleDetailID, s.Count,s.PurchasePID as PurchaseDetailID, PurchaseProd.Specification, PurchaseProd.Width,PurchaseProd.Length, PurchaseProd.CBM, PurchaseProd.Remark, ProdPartData.Name,SupplierData.Name As Supplier,SupplierData.Abbr,s.PIC,(Select PurchaseProd.Count - SUM(ISNULL(SaleProd.Count, 0)) + s.Count As RemainAmount
                            FROM PurchaseProd LEFT OUTER JOIN SaleProd On PurchaseProd.PurchasePID = SaleProd.PurchasePID WHERE PurchaseProd.PurchasePID = s.PurchasePID 
                            GROUP BY PurchaseProd.Count ) As RemainAmount FROM ProdPartData INNER JOIN SupplierData On ProdPartData.SuID = SupplierData.SuID INNER JOIN PurchaseProd  On ProdPartData.ProdPartID = PurchaseProd.ProdPartID INNER JOIN
                            SaleProd s On PurchaseProd.PurchasePID = s.PurchasePID  WHERE s.SaleID = @editID"
    Protected Const SELECT_FIT_REVIEW_BY_SALEID = "SELECT Fit.SaleFID as SaleDetailID,Fit.PurchaseFID as PurchaseDetailID ,Fit.[Count],Fit.PIC,PurchaseFit.Width, PurchaseFit.Length, PurchaseFit.CBM, PurchaseFIt.Specification,PurchaseFIt.Remark,ProdPartData2.ProdPart2ID,ProdPartData2.Name,SupplierData.Name as Supplier, SupplierData.Abbr ,(SELECT (PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) + Fit.Count AS RemainAmount
                           From PurchaseFit LEFT Join SaleFit ON PurchaseFit.PurchaseFID = SaleFit.PurchaseFID, ProdPartData2,SupplierData, PurchaseData
                           Where PurchaseFit.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID  And PurchaseData.PurchaseID = PurchaseFit.PurchaseID AND PurchaseFIt.PurchaseFID = Fit.PurchaseFID
                           Group By PurchaseFit.[Count]) as RemainAmount From ProdPartData2, SupplierData,PurchaseFIt ,SaleFit as Fit
                           Where ProdPartData2.SuID = SupplierData.SuID AND PurchaseFIt.ProdPart2ID = ProdPartData2.ProdPart2ID AND Fit.PurchaseFID = PurchaseFIt.PurchaseFID AND SaleID = @editID"
    Protected Const SELECT_PROD_STOCK_BY_CASEID = "SELECT PurchaseProd.PurchasePID as PurchaseDetailID, ProdPartData.[Name], SupplierData.[Name] AS Supplier,SupplierData.Abbr,PurchaseProd.Specification,PurchaseProd.[Count],Width,[Length],CBM,Remark,([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) AS RemainAmount
                                              From PurchaseProd LEFT Join SaleProd ON PurchaseProd.PurchasePID = SaleProd.PurchasePID, ProdPartData,SupplierData,PurchaseData
                                              Where PurchaseProd.ProdPartID = ProdPartData.ProdPartID And ProdPartData.SuID = SupplierData.SuID And PurchaseData.CaseID = @caseID And PurchaseData.PurchaseID = PurchaseProd.PurchaseID
                                              Group By PurchaseProd.PurchasePID, ProdPartData.[Name], PurchaseProd.Specification, PurchaseProd.[Count], Width, [Length], CBM, Remark, SupplierData.[Name],SupplierData.Abbr
                                              Having([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) > 0"
    Protected Const SELECT_FIT_STOCK_BY_CASEID = "SELECT PurchaseFit.PurchaseFID as PurchaseDetailID, ProdPartData2.[Name], SupplierData.[Name] AS Supplier,SupplierData.Abbr,PurchaseFit.Width,PurchaseFit.[Length],PurchaseFit.CBM,PurchaseFit.Specification,PurchaseFit.[Count],Remark,(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) AS RemainAmount
                                              From PurchaseFit LEFT Join SaleFit ON PurchaseFit.PurchaseFID = SaleFit.PurchaseFID, ProdPartData2,SupplierData, PurchaseData
                                               Where PurchaseFit.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID And PurchaseData.CaseID = @caseID And PurchaseData.PurchaseID = PurchaseFit.PurchaseID
                                               Group By PurchaseFit.PurchaseFID, ProdPartData2.[Name], PurchaseFit.Specification, PurchaseFit.[Count], Remark, SupplierData.[Name],PurchaseFit.Width,PurchaseFit.[Length],PurchaseFit.CBM,SupplierData.Abbr
                                               Having(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) > 0"
    Protected Const INSERT_SALEDATA_SQL = "INSERT INTO  SaleData(CaseID, SaleNO, InsertTime) VALUES(@caseID,N'@saleNO','@time'); SELECT id = SCOPE_IDENTITY() "
    Protected Const SELECT_SALEDATA_FOR_SALEID = "SELECT SaleNO FROM SaleData WHERE SaleID = @editID"
    Protected Const UPDATE_CASEDATA_FOR_UPDATETIME_SQL = "UPDATE CaseData SET UpdateTime = GETDATE() WHERE CaseID = @caseID"
    Protected Const UPDATE_SALEDATA_FOR_INSERTTIME_SQL = "UPDATE SaleData SET InsertTime = '@time' WHERE SaleID = @editID"
    Protected Const INSERT_SALEPROD_SQL = "INSERT INTO SaleProd(SaleID, PurchasePID, Count,PIC) VALUES(@id,N'@purchasePID',@count, N'@pic')"
    Protected Const UPDATE_SALEPROD_SQL = "UPDATE SaleProd SET PurchasePID = N'@purchasePID', Count = @count, PIC = N'@pic' WHERE SalePID = @salePID"
    Protected Const INSERT_SALEFIT_SQL = "INSERT INTO SaleFit(SaleID, PurchaseFID, Count, PIC) VALUES(@id,@purchaseFID,@count,N'@pic')"
    Protected Const UPDATE_SALEFIT_SQL = "UPDATE SaleFit SET PurchaseFID = N'@purchaseFID', Count = @count, PIC = N'@pic' WHERE SaleFID = @saleFID"
    Protected Const DELETE_SALEPROD_SQL = "DELETE FROM SaleProd WHERE SalePID = @salePID"
    Protected Const DELETE_SALEFIT_SQL = "DELETE FROM SaleFit WHERE SaleFID = @saleFID"
    Protected Const SELECT_SALEDATA_FOR_INSERTTIME_SQL = "SELECT InsertTime FROM SaleData WHERE SaleID = @editID"
    Protected Const COUNT_SALEDATA = "SELECT COUNT(SaleNO)  FROM SaleData WHERE SaleNO LIKE 'S@dateStr%'"
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
    Public Structure SaleData
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
