Imports System.Data.SqlClient

Public Class Main_Controller
    Inherits Data_User_Model
    Public Function Select_User(ByVal userID As String, ByVal password As String) As LoginData
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_LOGINDATA_SQL_USERID
        Dim listData As LoginData = Nothing
        strSQL = strSQL.Replace("@userID", userID)
        strSQL = strSQL.Replace("@password", password)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            listData = New LoginData
            While dataReader.Read
                listData = New LoginData With {.LoginID = dataReader("LoginID"), .UserName = dataReader("UserName"), .UserID = dataReader("UserID"), .Password = dataReader("Password"), .Access = dataReader("Access"), .L0 = dataReader("L0"), .L1 = dataReader("L1"), .L2 = dataReader("L2"), .L3 = dataReader("L3"), .L4 = dataReader("L4"), .L5 = dataReader("L5"), .L6 = dataReader("L6")}
            End While
        End If
        Return listData
    End Function
End Class
