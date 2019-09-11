Public Class Set_WorkProgress_Model
    Public Const INSERT_MODE As Integer = 0
    Public Const EDIT_MODE As Integer = 1
    Protected Const SELECT_WORKPROGRESS_FOR_WPID_SQL = "SELECT * FROM WorkProgress WHERE WPID = @id"
    Protected Const SELECT_WORKPROGRESS_FOR_CASEID_SQL = "SELECT * FROM WorkProgress WHERE CaseID = @id"
    Protected Const INSERT_WORKPROGRESS_SQL = "INSERT INTO WorkProgress(CaseID,WPClass,WPDate,Supplier,ProdName,Specification,Count,Unit,Remark) VALUES(@id,@class,N'@date',N'@supplier',N'@prodName',N'@specification',N'@count',N'@unit',N'@price')"
    Protected Const UPDATE_WORKPROGRESS_FOR_WPID_SQL = "UPDATE WorkProgress SET WPDate = N'@date', Supplier = N'@supplier' , ProdName = N'@prodName' , Specification = N'@specification',Count = N'@count', Unit = N'@unit', Remark = N'@price'  WHERE WPID = @id "
    Protected Const DELETE_WORKPROGRESS_SQL = "DELETE FROM WorkProgress WHERE WPID = @id"
    Public Structure WorkProgress
        Dim WPID As Integer
        Dim WPClass As Integer
        Dim WPDate As Date
        Dim Supplier As String
        Dim ProdName As String
        Dim Specification As String
        Dim Count As String
        Dim Unit As String
        Dim Remark As String
    End Structure
End Class
