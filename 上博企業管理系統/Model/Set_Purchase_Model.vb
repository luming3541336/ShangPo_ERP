Public Class Set_Purchase_Model
    Public Const PRODUCT As Integer = 0
    Public Const FIT As Integer = 1
    Public Const INSERT_MODE As Integer = 0
    Public Const EDIT_MODE As Integer = 1
    Protected Const COUNT_PURCHASEDATA_SQL = "SELECT COUNT(PurchaseNO)  FROM PurchaseData WHERE PurchaseNO LIKE 'P@dateStr%'"
    Protected Const SELECT_PURCHASENO_BY_PURCHASEID_SQL = "SELECT PurchaseNO FROM PurchaseData WHERE PurchaseID = @editID"
    Protected Const SELECT_INSERTTIME_BY_PURCHASEDATA_SQL = "SELECT InsertTime FROM PurchaseData WHERE PurchaseID = @editID"
    Protected Const SELECT_PROD_SQL = "Select ProdPartData.ProdPartID,ProdPartData.Name,SupplierData.Name As Supplier, SupplierData.Abbr From ProdPartData, SupplierData 
                           Where ProdPartData.SuID = SupplierData.SuID  AND (ProdPartData.Name LIKE N'%@strName%' OR ProdPartData.Number Like N'%@strName%')"
    Protected Const SELECT_FIT_SQL = "SELECT ProdPartData2.ProdPart2ID,ProdPartData2.Name,SupplierData.Name as Supplier, SupplierData.Abbr
                           From ProdPartData2, SupplierData Where ProdPartData2.SuID = SupplierData.SuID AND 
                           (ProdPartData2.Name LIKE N'%@strName%' OR ProdPartData2.Number Like N'%@strName%')"
    Protected Const SELECT_PROD_BY_PURCHAEID = "Select PurchasePart.*,ProdPartData.Name,SupplierData.Name As Supplier, SupplierData.Abbr
                           From ProdPartData, SupplierData,PurchasePart Where ProdPartData.SuID = SupplierData.SuID AND PurchasePart.ProdPartID = ProdPartData.ProdPartID AND PurchasePart.PurchaseID = @editID"
    Protected Const SELECT_FIT_BY_PURCHASEID = "SELECT PurchasePart2.*,ProdPartData2.ProdPart2ID,ProdPartData2.Name,SupplierData.Name as Supplier, SupplierData.Abbr 
                           From ProdPartData2, SupplierData,PurchasePart2 Where ProdPartData2.SuID = SupplierData.SuID AND PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID 
                           AND PurchasePart2.PurchaseID = @editID"
    Protected Const SELECT_SUPPLIERDATA_SQL = "SELECT SuID,Name,Abbr FROM SupplierData"
    'Protected Const SELECT_SPECIFICATION_SQL = "SELECT SpecDetail.SpecID, Spec.ClassName, SpecificationForProd.ProdPartID 
    '                                            FROM OtherClassDetail CROSS JOIN SpecificationForProd INNER JOIN Specification ON 
    '                                            OtherClassDetail.SpecID = Specification.SpecID AND SpecificationForProd.ProdPartID = @ProdPartID
    '                                            GROUP BY   OtherClassDetail.SpecID, Specification.ClassName, SpecificationForProd.ProdPartID"
    Protected Const INSERT_PRDOSET_SQL = "INSERT INTO ProdPartData(Name,SuID) VALUES(N'@name', @suID); SELECT id = SCOPE_IDENTITY();"
    Protected Const INSERT_FITTING_SQL = "INSERT INTO ProdPartData2(Name,SuID) VALUES(N'@name', @suID); SELECT id = SCOPE_IDENTITY();"
    Protected Const UPDATE_CASEDATA_SQL = "UPDATE CaseData SET UpdateTime = GETDATE() WHERE CaseID = @caseID"
    Protected Const INSERT_PURCHASEDATA_SQL = "INSERT INTO  PurchaseData(CaseID, PurchaseNO,InsertTime) VALUES(@caseID,N'@purchaseNO','@time'); SELECT id = SCOPE_IDENTITY() "
    Protected Const UPDATE_PURCHASEDATA_BY_PURCHASEID_SQL = "UPDATE PurchaseData SET InsertTime = '@time' WHERE PurchaseID = @id"
    Protected Const INSERT_PURCHASEPART_SQL = "INSERT INTO PurchasePart(PurchaseID, ProdPartID, Specification, Width, Length, CBM, Count, Remark) VALUES(@id,@prodPartID,N'@specification',@width ,@length ,@cbm ,@count, N'@remark')"
    Protected Const UPDATE_PURCHASEPART_SQL = "UPDATE PurchasePart SET ProdPartID = @prodPartID, Specification = N'@specification', Width = @width,Length = @length, CBM = @cbm, Count = @count, Remark = N'@remark' WHERE PurchasePID = @PID"
    Protected Const INSERT_PURCHASEPART2_SQL = "INSERT INTO PurchasePart2(PurchaseID, ProdPart2ID, Specification, Width, Length, CBM, Count, Remark) VALUES(@id,@prodPart2ID,N'@specification',@width ,@length ,@cbm ,@count,N'@remark')"
    Protected Const UPDATE_PURCHASEPART2_SQL = "UPDATE PurchasePart2 SET ProdPart2ID = @prodPart2ID, Specification = N'@specification',Width = @width,Length = @length, CBM = @cbm, Count = @count, Remark = N'@remark' WHERE PurchaseP2ID = @FID"
    Protected Const DEL_PURCHASEPART_BY_PURCHASEPID = "DELETE FROM PurchasePart WHERE PurchasePID = @PID"
    Protected Const DEL_PURCHASEPART2_BY_PURCHASEFID = "DELETE FROM PurchasePart2 WHERE PurchaseP2ID = @FID"
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
        Dim ProdPartID As Integer
        Dim Specification As String
        Dim ClassName As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure
    Public Structure FitDetail
        Dim PurchaseP2ID As Integer
        Dim PurchaseID As Integer
        Dim ProdPart2ID As Integer
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
    End Structure

End Class
