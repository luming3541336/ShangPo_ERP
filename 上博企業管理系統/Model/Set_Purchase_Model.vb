Public Class Set_Purchase_Model
    Public Const PRODUCT As Integer = 0
    Public Const FIT As Integer = 1
    Public Const INSERT_MODE As Integer = 0
    Public Const EDIT_MODE As Integer = 1
    Protected Const COUNT_PURCHASEDATA_SQL = "SELECT COUNT(PurchaseNO)  FROM PurchaseData WHERE PurchaseNO LIKE 'P@dateStr%'"
    Protected Const SELECT_PURCHASENO_BY_PURCHASEID_SQL = "SELECT PurchaseNO FROM PurchaseData WHERE PurchaseID = @editID"
    Protected Const SELECT_INSERTTIME_BY_PURCHASEDATA_SQL = "SELECT InsertTime FROM PurchaseData WHERE PurchaseID = @editID"
    Protected Const SELECT_PROD_SQL = "Select Prodset.ProdID,ProdSet.Name,SupplierData.Name As Supplier, SupplierData.Abbr From ProdSet, SupplierData 
                           Where ProdSet.SuID = SupplierData.SuID  AND (ProdSet.Name LIKE N'%@strName%' OR ProdSet.Number Like N'%@strName%')"
    Protected Const SELECT_FIT_SQL = "SELECT FittingSet.FitID,FittingSet.Name,SupplierData.Name as Supplier, SupplierData.Abbr
                           From FittingSet, SupplierData Where FittingSet.SuID = SupplierData.SuID AND 
                           (FittingSet.Name LIKE N'%@strName%' OR FittingSet.Number Like N'%@strName%')"
    Protected Const SELECT_PROD_BY_PURCHAEID = "Select PurchaseProd.*,ProdSet.Name,SupplierData.Name As Supplier, SupplierData.Abbr
                           From ProdSet, SupplierData,PurchaseProd Where ProdSet.SuID = SupplierData.SuID AND PurchaseProd.ProdID = ProdSet.ProdID AND PurchaseProd.PurchaseID = @editID"
    Protected Const SELECT_FIT_BY_PURCHASEID = "SELECT PurchaseFIt.*,FittingSet.FitID,FittingSet.Name,SupplierData.Name as Supplier, SupplierData.Abbr 
                           From FittingSet, SupplierData,PurchaseFIt Where FittingSet.SuID = SupplierData.SuID AND PurchaseFIt.FitID = FittingSet.FitID 
                           AND PurchaseFIt.PurchaseID = @editID"
    Protected Const SELECT_SUPPLIERDATA_SQL = "SELECT SuID,Name,Abbr FROM SupplierData"
    Protected Const SELECT_SPECIFICATION_SQL = "SELECT SpecDetail.SpecID, Spec.ClassName, SpecificationForProd.ProdID 
                                                FROM OtherClassDetail CROSS JOIN SpecificationForProd INNER JOIN Specification ON 
                                                OtherClassDetail.SpecID = Specification.SpecID AND SpecificationForProd.ProdID = @ProdID
                                                GROUP BY   OtherClassDetail.SpecID, Specification.ClassName, SpecificationForProd.ProdID"
    Protected Const INSERT_PRDOSET_SQL = "INSERT INTO ProdSet(Name,SuID) VALUES(N'@name', @suID); SELECT id = SCOPE_IDENTITY();"
    Protected Const INSERT_FITTING_SQL = "INSERT INTO FittingSet(Name,SuID) VALUES(N'@name', @suID); SELECT id = SCOPE_IDENTITY();"
    Protected Const UPDATE_CASEDATA_SQL = "UPDATE CaseData SET UpdateTime = GETDATE() WHERE CaseID = @caseID"
    Protected Const INSERT_PURCHASEDATA_SQL = "INSERT INTO  PurchaseData(CaseID, PurchaseNO,InsertTime) VALUES(@caseID,N'@purchaseNO','@time'); SELECT id = SCOPE_IDENTITY() "
    Protected Const UPDATE_PURCHASEDATA_BY_PURCHASEID_SQL = "UPDATE PurchaseData SET InsertTime = '@time' WHERE PurchaseID = @id"
    Protected Const INSERT_PURCHASEPROD_SQL = "INSERT INTO PurchaseProd(PurchaseID, ProdID, Specification, Width, Length, CBM, Count, Remark) VALUES(@id,@prodID,N'@specification',@width ,@length ,@cbm ,@count, N'@remark')"
    Protected Const UPDATE_PURCHASEPROD_SQL = "UPDATE PurchaseProd SET ProdID = @prodID, Specification = N'@specification', Width = @width,Length = @length, CBM = @cbm, Count = @count, Remark = N'@remark' WHERE PurchasePID = @PID"
    Protected Const INSERT_PURCHASEFIT_SQL = "INSERT INTO PurchaseFit(PurchaseID, FitID, Specification, Width, Length, CBM, Count, Remark) VALUES(@id,@fitID,N'@specification',@width ,@length ,@cbm ,@count,N'@remark')"
    Protected Const UPDATE_PURCHASEFIT_SQL = "UPDATE PurchaseFit SET FitID = @fitID, Specification = N'@specification',Width = @width,Length = @length, CBM = @cbm, Count = @count, Remark = N'@remark' WHERE PurchaseFID = @FID"
    Protected Const DEL_PURCHASEPROD_BY_PURCHASEPID = "DELETE FROM PurchaseProd WHERE PurchasePID = @PID"
    Protected Const DEL_PURCHASEFIT_BY_PURCHASEFID = "DELETE FROM PurchaseFit WHERE PurchaseFID = @FID"
    Protected editIndex As Integer = Nothing ' 修改中的欄位
    Protected intMode As Integer = Nothing '設定模式
    Protected editID As Integer = Nothing '修改模式下所修改的進貨單ID(PurchaseID)
    Protected caseID As Integer = Nothing '紀錄對應進(出)貨單的案件流水號
    Protected editRemoveProd As ArrayList = New ArrayList '在編輯時，如有做刪除動作則會記錄要刪除的ID
    Protected editRemoveFit As ArrayList = New ArrayList '在編輯時，如有做刪除動作則會記錄要刪除的ID
    Protected purchaseProdArray As List(Of ProdDetail) = New List(Of ProdDetail) ' 進貨產品的陣列
    Protected purchaseFitArray As List(Of FitDetail) = New List(Of FitDetail) '進貨配件的陣列
    Protected copyProd As ProdData = Nothing
    Public Structure ProdData
        Dim ID As Integer
        Dim Name As String
        Dim Supplier As String
    End Structure
    Public Structure PurchaseData
        Dim PurchaseID As Integer
        Dim DataID As Integer
        Dim Name As String
        Dim Supplier As String
        Dim Spicification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As String
        Dim Remark As String
    End Structure

    Public Structure SupplierData
        Dim SuID As Integer
        Dim Name As String
    End Structure
    Public Structure SpecificationData
        Dim SpecID As Integer
        Dim ClassName As String
    End Structure
    Public Structure ProdDetail
        Dim PurchasePID As Integer
        Dim PurchaseID As Integer
        Dim ProdID As Integer
        Dim Specification As String
        Dim ClassName As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure
    Public Structure FitDetail
        Dim PurchaseFID As Integer
        Dim PurchaseID As Integer
        Dim FitID As Integer
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure

End Class
