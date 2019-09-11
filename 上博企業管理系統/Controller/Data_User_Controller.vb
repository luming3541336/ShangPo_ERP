Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class Data_User_Controller
    Inherits Data_User_Model
    Public Function Select_LoginData() As List(Of LoginData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_LOGINDATA_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of LoginData) = New List(Of LoginData)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New LoginData With {.LoginID = dataReader("LoginID"), .UserName = dataReader("UserName"), .Password = dataReader("Password"), .Access = dataReader("Access"), .UserID = dataReader("UserID"), .L0 = dataReader("L0"), .L1 = dataReader("L1"), .L2 = dataReader("L2"), .L3 = dataReader("L3"), .L4 = dataReader("L4"), .L5 = dataReader("L5"), .L6 = dataReader("L6")})
            End While
        End If
        Return listData
    End Function
    Public Function Insert_LoginData(ByVal ID As String, ByVal PW As String, ByVal name As String, ByVal access As String, ByVal L0 As Integer, ByVal L1 As Integer, ByVal L2 As Integer, ByVal L3 As Integer, ByVal L4 As Integer, ByVal L5 As Integer, ByVal L6 As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_LOGINDATA_SQL
        strSQL = strSQL.Replace("@ID", ID)
        strSQL = strSQL.Replace("@PW", PW)
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@access", access)
        strSQL = strSQL.Replace("@L1", L1)
        strSQL = strSQL.Replace("@L2", L2)
        strSQL = strSQL.Replace("@L3", L3)
        strSQL = strSQL.Replace("@L4", L4)
        strSQL = strSQL.Replace("@L5", L5)
        strSQL = strSQL.Replace("@L6", L6)
        strSQL = strSQL.Replace("@L0", L0)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                Return dataReader(0)
            End While
        End If
        Return Nothing
    End Function
    Public Function Update_LoginData(ByVal LoginID As Integer, ByVal ID As String, ByVal PW As String, ByVal name As String, ByVal access As String, ByVal L0 As Integer, ByVal L1 As Integer, ByVal L2 As Integer, ByVal L3 As Integer, ByVal L4 As Integer, ByVal L5 As Integer, ByVal L6 As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_LOGINDATA_SQL
        strSQL = strSQL.Replace("@LID", LoginID)
        strSQL = strSQL.Replace("@ID", ID)
        strSQL = strSQL.Replace("@PW", PW)
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@access", access)
        strSQL = strSQL.Replace("@L1", L1)
        strSQL = strSQL.Replace("@L2", L2)
        strSQL = strSQL.Replace("@L3", L3)
        strSQL = strSQL.Replace("@L4", L4)
        strSQL = strSQL.Replace("@L5", L5)
        strSQL = strSQL.Replace("@L6", L6)
        strSQL = strSQL.Replace("@L0", L0)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function

    Public Function Del_LoginData(ByVal id As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_LOGINDATA_SQL
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Sub Set_InsertMode()
        intMode = INSERT_MODE
    End Sub
    Public Sub Set_ReviseMode()
        intMode = REVISE_MODE
    End Sub
    Public Sub Set_NormalMode()
        intMode = NORMAL_MODE
    End Sub
    Public Function Get_Mode() As Integer
        Return intMode
    End Function
End Class
