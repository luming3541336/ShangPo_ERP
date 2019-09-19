Public Class Data_User_Model
    Protected intMode As Integer = 3
    Public Const INSERT_MODE = 1
    Public Const REVISE_MODE = 2
    Public Const NORMAL_MODE = 3
    Protected Const SELECT_LOGINDATA_SQL = "SELECT * FROM LoginData"
    Protected Const SELECT_LOGINDATA_SQL_USERID = "SELECT * FROM LoginData WHERE UserID = '@userID' AND Password = '@password' "
    Protected Const INSERT_LOGINDATA_SQL = "INSERT INTO LoginData(UserName,Access,UserID,Password,L0,L1,L2,L3,L4,L5,L6) VALUES (N'@name',N'@access','@ID','@PW',@L0,@L1,@L2,@L3,@L4,@L5,@L6); SELECT id = SCOPE_IDENTITY(); "
    Protected Const UPDATE_LOGINDATA_SQL = "UPDATE LoginData SET UserName = N'@name', Access = N'@access', UserID = '@ID', Password = '@PW', L0 = @L0, L1 = @L1, L2 = @L2, L3 = @L3, L4 = @L4, L5 = @L5, L6 = @L6 WHERE LoginID = @LID"
    Protected Const DELETE_LOGINDATA_SQL = "DELETE FROM LoginData WHERE LoginID = @id"
    Public Structure LoginData
        Dim LoginID As Integer
        Dim UserName As String
        Dim Access As String
        Dim UserID As String
        Dim Password As String
        Dim L0 As Integer
        Dim L1 As Integer
        Dim L2 As Integer
        Dim L3 As Integer
        Dim L4 As Integer
        Dim L5 As Integer
        Dim L6 As Integer
    End Structure
End Class
