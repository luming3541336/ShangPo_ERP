Imports System.Data.SqlClient

Public Class Data_Specification_Controller
    Inherits Data_Specification_Model
    Public Function LoadSupplier() As ArrayList
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SUPPLIER_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        dataSupplier.Clear()
        dataSupplier.Add(0)
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataSupplier.Add(dataReader("SuID"))
                dataArray.Add(New Supplier With {.SuID = dataReader("SuID"), .Name = dataReader("Name")})
            Loop
        End If
        Return dataArray
    End Function
    Public Function Load_Spec(ByVal SuID As Integer) As ArrayList
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SPEC_SQL
        strSQL = strSQL.Replace("@suID", SuID)
        dataSpec.Clear()
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataArray.Add(New Spec With {.SpecID = dataReader("SpecID"), .ClassName = dataReader("ClassName")})
                dataSpec.Add(dataReader("SpecID"))
            Loop
        End If
        Return dataArray
    End Function
    Public Function Load_Spec_Detail(ByVal SpecID As Integer) As ArrayList
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SPEC_DETAIL_SQL
        strSQL = strSQL.Replace("@specID", SpecID)
        dataSpecDetail.Clear()
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataSpecDetail.Add(dataReader("SpecDetailID"))
                dataArray.Add(New SpecDetail With {.SpecDetailID = dataReader("SpecDetailID"), .DetailName = dataReader("DetailName")})
            Loop
        End If
        Return dataArray
    End Function
    Public Function Add_Spec(ByVal SuID As Integer, ByVal ClassName As String) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_SPEC_SQL
        strSQL = strSQL.Replace("@suID", SuID)
        strSQL = strSQL.Replace("@className", ClassName)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataSpec.Add(dataReader("id"))
                Return dataReader("id")
            Loop
        End If
        Return 0
    End Function
    Public Function Add_Spec_Detail(ByVal SpecID As Integer, ByVal DetailName As String) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_SPEC_DETAIL_SQL
        strSQL = strSQL.Replace("@specID", SpecID)
        strSQL = strSQL.Replace("@detailName", DetailName)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataSpecDetail.Add(dataReader("id"))
                Return dataReader("id")
            Loop
        End If
        Return 0
    End Function
    Public Function Update_Spec(ByVal SpecID As Integer, ByVal ClassName As String) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_SPEC_SQL
        strSQL = strSQL.Replace("@specID", SpecID)
        strSQL = strSQL.Replace("@className", ClassName)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Update_Spec_Detail(ByVal SpecDetailID As Integer, ByVal DetailName As String) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_SPEC_DETAIL_SQL
        strSQL = strSQL.Replace("@specDetailID", SpecDetailID)
        strSQL = strSQL.Replace("@detailName", DetailName)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Del_Spec(ByVal SpecID As Integer) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_SPEC_SQL
        strSQL = strSQL.Replace("@specID", SpecID)
        Try
            Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
            Return dataReader
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function Del_Spec_Detail(ByVal SpecDetailID As Integer) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_SPEC_DETAIL_SQL
        strSQL = strSQL.Replace("@specDetailID", SpecDetailID)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Del_Spec_All(ByVal SpecID As Integer) As Integer
        Dim dataArray As ArrayList = New ArrayList
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_SPEC_DETAIL_ALL_SQL
        strSQL = strSQL.Replace("@specID", SpecID)
        Try
            Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
            Return dataReader
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
