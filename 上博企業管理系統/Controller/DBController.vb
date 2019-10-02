Imports System.Data.SqlClient

Public Class DBController
    Private Initial_Catalog As String
    '正式帳號
    Private objCon As SqlConnection

    'Private strDbCon As String = "Data Source=DBSERVER,1433;Initial Catalog=ERPShongPo;User ID=ShongPoUser;Password=1234"
    'Private strDbCon As String = "Data Source=DESKTOP-96CGOU8;Initial Catalog=ERPShongPo;Integrated Security=SSPI;"
    Private strDbCon As String = "Data Source=ALEXLUCD48\SQLEXPRESS02;Initial Catalog=ERPShongPo;Integrated Security=SSPI;"
    Private objCmd As SqlCommand
    Private type As Integer = 0
    Private selectSQL As String = Nothing
    Private updateSQL As String = Nothing
    Private insertSQL As String = Nothing
    Private deleteSQL As String = Nothing
    Private from As String = Nothing
    Private where As String = Nothing
    Private setSQL As String = Nothing
    Private valueSQL As String = Nothing
    Private join As String = Nothing

    Sub New(ByVal Data_Source As String, ByVal ID As String, ByVal Password As String, ByVal Initial_Catalog As String)
        strDbCon = "Data Source=" & Data_Source & ";Initial Catalog=" & Initial_Catalog & ";User ID=" & ID & ";Password=" & Password
    End Sub
    Sub New(ByVal Data_Source As String, ByVal Initial_Catalog As String)
        strDbCon = "Data Source=" & Data_Source & ";Initial Catalog=" & Initial_Catalog & ";Integrated Security=SSPI;"
    End Sub
    Sub New()

    End Sub

    Function ConTry() As Boolean
        Try
            objCon = New SqlConnection(strDbCon)
            objCon.Open()
            objCon.Close()
            Return True
        Catch ex As Exception
            MsgBox("ExecuteSQL 錯誤: " & ex.ToString)
            Return False
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
    Public Sub _select(ByVal col() As String, ByVal from As String)
        selectSQL = "SELECT "
        For Each name As String In col
            selectSQL += name & ","
        Next
        selectSQL = selectSQL.TrimEnd(",")
        Me.from = " FROM " & from
    End Sub
    Public Sub _update(ByVal from As String)
        updateSQL = "UPDATE " & from & " SET "
    End Sub
    Public Sub _insert(ByVal from As String, ByVal name() As String)
        insertSQL = "INSERT INTO " & from & "("
        For Each value As String In name
            insertSQL += value & ","
        Next
        insertSQL = insertSQL.TrimEnd(",")
        insertSQL += ") VALUES ("
    End Sub
    Public Sub _delete(ByVal from As String)
        deleteSQL = "DELETE FROM " & from
    End Sub
    Public Sub _set(ByVal name As String, ByVal value As String)
        setSQL += "," & name & "= N'" & value & "' "
        setSQL = setSQL.TrimStart(",")
    End Sub
    Public Sub _value(ByVal value() As String)
        For Each data As String In value
            valueSQL += "N'" & data & "',"
        Next
        valueSQL = valueSQL.TrimEnd(",")
        valueSQL += ")"
    End Sub
    Public Sub _where(ByVal name As String, ByVal value As String, ByVal nextWhere As String)
        where += " " & name & " = N'" & value & "' " & nextWhere
    End Sub
    Public Sub _join(ByVal type As String, ByVal from As String, ByVal judgment As String)
        join = " " & type & " " & from & " ON " & judgment
    End Sub

    Public Function toSelect() As SqlCommand
        objCon = New SqlConnection(strDbCon)
        objCon.Open()
        objCmd = New SqlCommand(selectSQL & from & IIf(join <> Nothing, join, Nothing) & IIf(where <> Nothing, " WHERE" & where, Nothing), objCon)
        selectSQL = Nothing
        from = Nothing
        where = Nothing
        join = Nothing
        Return objCmd
    End Function
    Public Function toUpdate() As SqlCommand
        objCon = New SqlConnection(strDbCon)
        objCon.Open()
        objCmd = New SqlCommand(updateSQL & setSQL & IIf(where <> Nothing, " WHERE" & where, Nothing), objCon)
        updateSQL = Nothing
        setSQL = Nothing
        where = Nothing
        Return objCmd
    End Function
    Public Function toInsert(ByVal id As String) As SqlCommand
        objCon = New SqlConnection(strDbCon)
        objCon.Open()
        objCmd = New SqlCommand(insertSQL & valueSQL & "; Select @@IDENTITY As '" & id & "';", objCon)
        insertSQL = Nothing
        valueSQL = Nothing
        where = Nothing
        Return objCmd
    End Function
    Public Function toDelete() As SqlCommand
        objCon = New SqlConnection(strDbCon)
        objCon.Open()
        objCmd = New SqlCommand(deleteSQL & IIf(where <> Nothing, " WHERE" & where, Nothing), objCon)
        from = Nothing
        where = Nothing
        Return objCmd
    End Function

End Class
