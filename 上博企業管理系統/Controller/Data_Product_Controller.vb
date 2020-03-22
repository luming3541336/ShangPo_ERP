Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Data_Product_Controller
    Inherits Data_Product_Model
    Public Function Select_ProdData() As List(Of ProdData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_ProdData_SQL
        Dim data As List(Of ProdData) = New List(Of ProdData)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New ProdData With {.ProdID = dataReader("ProdID"), .ProdName = dataReader("ProdName"), .Unit = dataReader("Unit")})
            Loop
        End If
        Return data
    End Function
    Public Function Update_ProdData(ByVal id As Integer, ByVal strUpdatedProp As Dictionary(Of String, String)) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_ProdData_SQL
        Dim strStatement As String = Nothing
        For Each data As KeyValuePair(Of String, String) In strUpdatedProp
            strStatement += $"{data.Key} = N'{data.Value}',"
        Next
        strStatement = strStatement.Remove(strStatement.LastIndexOf(","), 1)
            strSQL = strSQL.Replace("@statement", strStatement)
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Insert_ProdData(ByVal strUpdatedProp As Dictionary(Of String, String)) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_ProdData_SQL
        strSQL = strSQL.Replace("@name", strUpdatedProp("ProdName")).Replace("@unit", strUpdatedProp("Unit"))
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intData As Integer = 0
        If dataReader.HasRows Then
            Do While dataReader.Read
                intData = dataReader(0)
            Loop
        End If
        Return intData
    End Function
    Public Function Delete_ProdData(ByVal id As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_ProdData_SQL
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function

    Public Function Select_ProdModel(ByVal id As Integer) As List(Of ProdModel)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_ProdModel_SQL
        strSQL = strSQL.Replace("@id", id)
        Dim data As List(Of ProdModel) = New List(Of ProdModel)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New ProdModel With {.ProdModelID = dataReader("ProdModelID"), .ProdID = dataReader("prodID"), .Model = dataReader("Model"), .Name = dataReader("Name"), .Price = dataReader("Price"), .SuID = dataReader("SuID")})
            Loop
        End If
        Return data
    End Function
    Public Function Update_ProdModel(ByVal id As Integer, strUpdatedProp As Dictionary(Of String, String)) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_ProdModel_SQL
        Dim strStatement As String = Nothing
        For Each data As KeyValuePair(Of String, String) In strUpdatedProp
            strStatement += $"{data.Key} = N'{data.Value}',"
        Next
        strStatement = strStatement.Remove(strStatement.LastIndexOf(","), 1)
        strSQL = strSQL.Replace("@statement", strStatement)
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Insert_ProdModel(ByVal id As Integer, strUpdatedProp As Dictionary(Of String, String)) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_ProdModel_SQL
        strSQL = strSQL.Replace("@id", id).Replace("@suId", strUpdatedProp("SuID")).Replace("@model", strUpdatedProp("Model")).Replace("@price", strUpdatedProp("Price"))
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intData As Integer = 0
        If dataReader.HasRows Then
            Do While dataReader.Read
                intData = dataReader(0)
            Loop
        End If
        Return intData
    End Function
    Public Function Delete_ProdModel(ByVal id As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_ProdModel_SQL
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Select_Supplier() As List(Of SupplierData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_Supplier_SQL
        Dim data As List(Of SupplierData) = New List(Of SupplierData)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New SupplierData With {.SuID = dataReader("SuID"), .Name = dataReader("Name")})
            Loop
        End If
        Return data
    End Function
End Class
