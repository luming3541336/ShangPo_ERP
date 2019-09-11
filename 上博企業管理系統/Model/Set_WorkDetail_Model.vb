Public Class Set_WorkDetail_Model
    Public Const INSERT_MODE As Integer = 0
    Public Const EDIT_MODE As Integer = 1
    Protected Const SELECT_WORKDETAIL_FOR_WDID_SQL = "SELECT * FROM WorkDetail WHERE WDID = @id"
    Protected Const SELECT_WORKDETAIL_FOR_CASEID_SQL = "SELECT * FROM WorkDetail WHERE CaseID = @id"

    Protected Const INSERT_WORKDETAIL_SQL = "INSERT INTO WorkDetail(CaseID,WorkDate,SalesName,Detail,UserName) VALUES(@id,N'@workDate',N'@salesName',N'@detail',N'@userName')"
    Protected Const UPDATE_WORKDETAIL_FOR_WDID_SQL = "UPDATE WorkDetail SET WorkDate = N'@workDate', SalesName = N'@salesName' , Detail = N'@detail' , UserName = N'@userName' WHERE WDID = @id "
    Protected Const DELETE_WORKDETAIL_SQL = "DELETE FROM WorkDetail WHERE WDID = @id"

    Public Structure WorkDetail
        Dim WDID As Integer
        Dim CaseID As Integer
        Dim WorkDate As Date
        Dim SalesName As String
        Dim Detail As String
    End Structure
End Class
