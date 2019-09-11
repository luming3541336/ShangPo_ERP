Imports System.Data.SqlClient

Public Class Set_WorkProgress_Controller
    Inherits Set_WorkProgress_Model

    Public Function SelectWorkProgress(ByVal WPID As Integer) As WorkProgress
        Dim conDB As Connection = New Connection
        Dim data As WorkProgress = New WorkProgress
        Dim strSQL As String = SELECT_WORKPROGRESS_FOR_WPID_SQL
        strSQL = strSQL.Replace("@id", WPID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read()
                With data
                    .WPID = dataReader("WPID")
                    .ProdName = dataReader("ProdName")
                    .Specification = dataReader("Specification")
                    .Count = dataReader("Count")
                    .Supplier = dataReader("Supplier")
                    .Unit = dataReader("Unit")
                    .WPClass = dataReader("WPClass")
                    .WPDate = dataReader("WPDate")
                    .Remark = dataReader("Remark")
                End With
            Loop
        End If
        Return data
    End Function
    Public Function SelectWorkProgressForCaseID(ByVal caseID As Integer) As List(Of WorkProgress)
        Dim conDB As Connection = New Connection
        Dim listData As List(Of WorkProgress) = New List(Of WorkProgress)
        Dim strSQL As String = SELECT_WORKPROGRESS_FOR_CASEID_SQL
        strSQL = strSQL.Replace("@id", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read()
                listData.Add(New WorkProgress With {.WPID = dataReader("WPID"), .ProdName = dataReader("ProdName"), .Specification = dataReader("Specification"), .Count = dataReader("Count"),
                .Supplier = dataReader("Supplier"), .Unit = dataReader("Unit"), .WPClass = dataReader("WPClass"), .WPDate = dataReader("WPDate"), .Remark = dataReader("Remark")})
            Loop
        End If
        Return listData
    End Function
    Public Function UpdateWorkProgress(ByVal WPID As Integer, ByVal WPDate As Date, ByVal WPClass As Integer, ByVal prodName As String, specification As String, ByVal count As String, ByVal unit As String, ByVal supplier As String, ByVal Remark As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_WORKPROGRESS_FOR_WPID_SQL
        strSQL = strSQL.Replace("@id", WPID)
        strSQL = strSQL.Replace("@date", WPDate)
        strSQL = strSQL.Replace("@class", WPClass)
        strSQL = strSQL.Replace("@supplier", supplier)
        strSQL = strSQL.Replace("@prodName", prodName)
        strSQL = strSQL.Replace("@specification", specification)
        strSQL = strSQL.Replace("@count", count)
        strSQL = strSQL.Replace("@unit", unit)
        strSQL = strSQL.Replace("@price", Remark)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function InsertWorkProgress(ByVal id As Integer, ByVal WPDate As Date, ByVal WPClass As Integer, ByVal prodName As String, specification As String, ByVal count As String, ByVal unit As String, ByVal supplier As String, ByVal Remark As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_WORKPROGRESS_SQL
        strSQL = strSQL.Replace("@id", id)
        strSQL = strSQL.Replace("@date", WPDate)
        strSQL = strSQL.Replace("@class", WPClass)
        strSQL = strSQL.Replace("@supplier", supplier)
        strSQL = strSQL.Replace("@prodName", prodName)
        strSQL = strSQL.Replace("@specification", specification)
        strSQL = strSQL.Replace("@count", count)
        strSQL = strSQL.Replace("@unit", unit)
        strSQL = strSQL.Replace("@price", Remark)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function DelWorkProgress(ByVal WPID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_WORKPROGRESS_SQL
        strSQL = strSQL.Replace("@id", WPID)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
End Class
