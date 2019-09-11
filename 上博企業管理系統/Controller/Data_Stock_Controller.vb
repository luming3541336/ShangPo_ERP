Imports System.Data.SqlClient

Public Class Data_Stock_Controller
    Inherits Data_Stock_Model
    Public Function Load_Stock() As List(Of StockData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = Nothing
        Dim returnData As List(Of StockData) = New List(Of StockData)
        strSQL = SELECT_PRODSTOCK_SQL
        For i As Integer = 0 To 1
            Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
            If dataReader.HasRows Then
                Do While dataReader.Read
                    returnData.Add(New StockData With {.InsertTime = dataReader("InsertTime"), .Name = dataReader("Name"), .SupplierName = dataReader("Supplier"),
                                   .Specification = dataReader("Specification"), .Count = dataReader("RemainAmount"), .Width = dataReader("Width"), .Length = dataReader("Length"),
                                   .CBM = dataReader("CBM"), .Remark = dataReader("Remark"), .CasePlace = dataReader("Place"), .State = dataReader("State")})
                Loop
            End If
            strSQL = SELECT_FITSTOCK_SQL
        Next
        Return returnData
    End Function
End Class
