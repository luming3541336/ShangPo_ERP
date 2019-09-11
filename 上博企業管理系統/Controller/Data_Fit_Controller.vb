Imports System.Data.SqlClient

Public Class Data_Fit_Controller
    Inherits Data_Fit_Model
    Public Sub Set_Default(ByVal suID As Integer, ByVal suName As String)
        Me.suID = suID
        Me.supplierName = suName
    End Sub
    Public Sub Set_AddMode()
        mode = ADD_MODE
    End Sub
    Public Sub Set_ReviseMode()
        mode = REVISE_MODE
    End Sub
    Public Sub Set_ViewMode()
        mode = VIEW_MODE
    End Sub
    Public Function Get_SupplierName() As String
        Return supplierName
    End Function
    Public Function Load_FittingSet() As List(Of FittingSet)
        Dim conDB As Connection = New Connection
        Dim returnList As List(Of FittingSet) = New List(Of FittingSet)
        Dim strSQL As String = SEARCH_FITTINGSET_FROM_SUID_SQL
        strSQL = strSQL.Replace("@suID", suID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New FittingSet With {.FitID = dataReader("FitID"), .Name = dataReader("Name"), .Number = dataReader("Number"), .Specification = dataReader("Specification")})
            Loop
        End If
        conDB.close()
        Return returnList
    End Function
    Public Function Add_FittingSet(ByVal name As String, ByVal number As String, ByVal specification As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = ADD_FITTINGSET_SQL
        strSQL = strSQL.Replace("@statement", "Name,Number,Specification,SuID")
        strSQL = strSQL.Replace("@values", "N'@name',N'@number',N'@specification',@suID")
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@number", number)
        strSQL = strSQL.Replace("@specification", specification)
        strSQL = strSQL.Replace("@suID", suID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intReturn As Integer = Nothing
        If dataReader.HasRows Then
            Do While dataReader.Read
                intReturn = dataReader("id")
            Loop
        End If
        conDB.close()
        Return intReturn
    End Function
    Public Function Del_FittingSet(ByVal fitID) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DEL_FITTINGSET_SQL
        strSQL = strSQL.Replace("@fitID", fitID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.close()
        Return intReturn
    End Function
    Public Function Revise_Name_To_SQL(ByVal name As String, ByVal fitID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = REVISE_FITTINGSET_SQL
        strSQL = strSQL.Replace("@values", "Name = N'@name'")
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@fitID", fitID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.close()
        Return intReturn
    End Function
    Public Function Revise_Number_To_SQL(ByVal number As String, ByVal fitID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = REVISE_FITTINGSET_SQL
        strSQL = strSQL.Replace("@values", "Number = N'@number'")
        strSQL = strSQL.Replace("@number", number)
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@fitID", fitID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.close()
        Return intReturn
    End Function
    Public Function Revise_Specification_To_SQL(ByVal specification As String, ByVal fitID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = REVISE_FITTINGSET_SQL
        strSQL = strSQL.Replace("@values", "Specification = N'@specification'")
        strSQL = strSQL.Replace("@specification", specification)
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@fitID", fitID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.close()
        Return intReturn
    End Function
    Public Function Get_Mode() As Integer
        Return mode
    End Function
End Class
