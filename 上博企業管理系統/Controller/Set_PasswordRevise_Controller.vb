Imports System.Data.SqlClient

Public Class Set_PasswordRevise_Controller
    Inherits Set_PasswordRevise_Model
    Public Function Confirm_Password(ByVal pd As String) As Boolean
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PASSWORD_FOR_LOGINID_SQL
        Dim strPassword As String = Nothing
        strSQL = strSQL.Replace("@id", LoginID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                strPassword = dataReader("Password")
            End While
        End If
        If strPassword = Nothing Then
            MsgBox("資料查詢錯誤，請聯絡管理員")
            Return False
        Else
            If pd = strPassword Then
                Return True
            Else
                Return False
            End If
        End If
        conDB.close()
    End Function
    Public Function Update_Password(ByVal pd As String) As Boolean
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_PASSWORD_SQL
        strSQL = strSQL.Replace("@pd", pd)
        strSQL = strSQL.Replace("@id", LoginID)
        Dim intSuccess As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        If intSuccess <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
