Imports System.Data.SqlClient

'設定使用者連線資料

Public Class Connection
    Private Initial_Catalog As String

    '正式帳號
    Private objCon As SqlConnection
    Private strDbCon As String = "Data Source= DBSERVER,1433;Initial Catalog=ERPShongPo;User ID=ShongPoUser;Password=1234"
    'Private strDbCon As String = "Data Source=DESKTOP-96CGOU8;Initial Catalog=ERPShongPo;Integrated Security=SSPI;"
    'Private strDbCon As String = "Data Source=DESKTOP-SNRFQUA\SQLEXPRESS;Initial Catalog=ERPShongPo;Integrated Security=SSPI;"
    Private objCmd As SqlCommand
    Sub New(ByVal Data_Source As String, ByVal ID As String, ByVal Password As String, ByVal Initial_Catalog As String)
        strDbCon = "Data Source=" & Data_Source & ";Initial Catalog=" & Initial_Catalog & ";User ID=" & ID & ";Password=" & Password
    End Sub
    Sub New(ByVal Data_Source As String, ByVal Initial_Catalog As String)
        strDbCon = "Data Source=" & Data_Source & ";Initial Catalog=" & Initial_Catalog & ";Integrated Security=SSPI;"
    End Sub
    Sub New()

    End Sub

    Function ConTry() As String
        Try
            objCon = New SqlConnection(strDbCon)
            objCon.Open()
            objCon.Close()
            Return "OK"
        Catch ex As Exception
            MsgBox("ExecuteSQL 錯誤: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Function ExecuteSQL(ByVal strSQL As String) As SqlCommand
        Try
            objCon = New SqlConnection(strDbCon)
            objCon.Open()
            objCmd = New SqlCommand(strSQL, objCon)

            Return objCmd
        Catch ex As Exception
            MsgBox("ExecuteSQL 錯誤: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Sub Close()
        Try
            objCon.Close()
            objCmd.Dispose()
        Catch ex As Exception

        End Try

    End Sub
End Class
