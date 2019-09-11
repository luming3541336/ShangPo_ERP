Imports System.Data.SqlClient

Public Class Set_WorkDetail_Controller
    Inherits Set_WorkDetail_Model

    Public Function SelectWorkDetail(ByVal WDID As Integer) As WorkDetail
        Dim conDB As Connection = New Connection
        Dim data As WorkDetail = New WorkDetail
        Dim strSQL As String = SELECT_WORKDETAIL_FOR_WDID_SQL
        strSQL = strSQL.Replace("@id", WDID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read()
                With data
                    .WDID = dataReader("WDID")
                    .CaseID = dataReader("CaseID")
                    .Detail = dataReader("Detail")
                    .SalesName = dataReader("SalesName")
                    .WorkDate = dataReader("WorkDate")
                End With
            Loop
        End If
        Return data
    End Function
    Public Function SelectWorkDetailForCaseID(ByVal caseID As Integer) As List(Of WorkDetail)
        Dim listData As List(Of WorkDetail) = New List(Of WorkDetail)
        Dim strSQL As String = SELECT_WORKDETAIL_FOR_CASEID_SQL
        strSQL = strSQL.Replace("@id", caseID)
        Dim conDB As Connection = New Connection
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New WorkDetail With {.WorkDate = dataReader("WorkDate"), .WDID = dataReader("WDID"), .Detail = dataReader("Detail"), .SalesName = dataReader("SalesName")})
            End While
        End If
        Return listData
    End Function
    Public Function UpdateWorkDetail(ByVal WDID As Integer, ByVal detail As String, ByVal salesName As String, ByVal workDate As Date, ByVal userName As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_WORKDETAIL_FOR_WDID_SQL
        strSQL = strSQL.Replace("@id", WDID)
        strSQL = strSQL.Replace("@detail", detail)
        strSQL = strSQL.Replace("@salesName", salesName)
        strSQL = strSQL.Replace("@workDate", workDate)
        strSQL = strSQL.Replace("@userName", userName)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function InsertWorkDetail(ByVal CaseID As Integer, ByVal detail As String, ByVal salesName As String, ByVal workDate As Date, ByVal userName As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_WORKDETAIL_SQL
        strSQL = strSQL.Replace("@id", CaseID)
        strSQL = strSQL.Replace("@detail", detail)
        strSQL = strSQL.Replace("@salesName", salesName)
        strSQL = strSQL.Replace("@workDate", workDate)
        strSQL = strSQL.Replace("@userName", userName)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function DelWorkDetail(ByVal WDID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_WORKDETAIL_SQL
        strSQL = strSQL.Replace("@id", WDID)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
End Class
