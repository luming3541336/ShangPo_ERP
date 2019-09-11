Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class Data_Supplier_Controller
    Inherits Data_Supplier_Model
    Public Function Select_Supplier() As List(Of SupplierData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SUPPLIERDATA_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of SupplierData) = New List(Of SupplierData)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New SupplierData With {.Abbr = dataReader("Abbr"), .Address = dataReader("Address"), .Contact = dataReader("Contact"), .CpyID = dataReader("CpyID"), .Name = dataReader("Name"), .Number = dataReader("Number"), .Phone = dataReader("Phone"), .SuID = dataReader("SuID")})
            End While
        End If
        Return listData
    End Function

    Public Function Select_FittingSet(ByVal searchitem As Integer, ByVal statement As String) As List(Of SupplierData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SUPPLIERDATA_FOR_STATEMENT_SQL

        Select Case searchitem
            Case 0
                strSQL = strSQL.Replace("@statement", " Name Like N'%" & statement & "%'")
            Case 1
                strSQL = strSQL.Replace("@statement", " Number Like N'%" & statement & "%'")
            Case 2
                strSQL = strSQL.Replace("@statement", " Abbr Like N'%" & statement & "%'")
            Case 3
                strSQL = strSQL.Replace("@statement", " CpyID Like N'%" & statement & "%'")
        End Select
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of SupplierData) = New List(Of SupplierData)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New SupplierData With {.Abbr = dataReader("Abbr"), .Address = dataReader("Address"), .Contact = dataReader("Contact"), .CpyID = dataReader("CpyID"), .Name = dataReader("Name"), .Number = dataReader("Number"), .Phone = dataReader("Phone"), .SuID = dataReader("SuID")})
            End While
        End If
        Return listData
    End Function
    Public Function Insert_Supplier(ByVal name As String, ByVal number As String, ByVal cpyID As String, ByVal address As String, ByVal contact As String, ByVal phone As String, ByVal abbr As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_SUPPLIERDATA_SQL
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@number", number)
        strSQL = strSQL.Replace("@cpyID", cpyID)
        strSQL = strSQL.Replace("@address", address)
        strSQL = strSQL.Replace("@contact", contact)
        strSQL = strSQL.Replace("@phone", phone)
        strSQL = strSQL.Replace("@abbr", abbr)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                Return dataReader(0)
            End While
        End If
        Return Nothing
    End Function
    Public Function Update_Supplier(ByVal suID As Integer, ByVal name As String, ByVal number As String, ByVal cpyID As String, ByVal address As String, ByVal contact As String, ByVal phone As String, ByVal abbr As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_SUPPLIERDATA_SQL
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@number", number)
        strSQL = strSQL.Replace("@cpyID", cpyID)
        strSQL = strSQL.Replace("@address", address)
        strSQL = strSQL.Replace("@contact", contact)
        strSQL = strSQL.Replace("@phone", phone)
        strSQL = strSQL.Replace("@abbr", abbr)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function

    Public Function Del_Supplier(ByVal suID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_SUPPLIERDATA_SQL
        strSQL = strSQL.Replace("@suID", suID)
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
