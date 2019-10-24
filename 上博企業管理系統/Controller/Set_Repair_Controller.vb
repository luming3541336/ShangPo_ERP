Imports System.Data.SqlClient

Public Class Set_Repair_Controller
    Inherits Set_Repair_Model
    Public Function Selet_CaseData(ByVal caseID As Integer) As CaseData
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_CASEDATA_FOR_CASEID_SQL
        Dim arrayList As CaseData = Nothing
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList = New CaseData With {.Place = dataReader("Place"), .Address = dataReader("Address"), .Contact = dataReader("Contact"), .Phone = dataReader("Phone"), .UpdateTime = dataReader("UpdateTime")}
            Loop
        End If
        conDB.Close()
        Return arrayList

    End Function
    Public Function Update_RepairData(ByVal data As RepairData, ByVal repairID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_REPAIRDATA_SQL
        strSQL = strSQL.Replace("@repairType", data.RepairType).Replace("@place", data.Place).Replace("@contact", data.Contact).
                                      Replace("@address", data.Address).Replace("@phone", data.Phone).Replace("@warranty", data.Warranty).
                                      Replace("@remark", data.Remark).Replace("@eta", data.ETA).Replace("@archiveDate", data.ArchiveDate).Replace("@loginID", LoginID).Replace("@id", repairID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return intReturn
    End Function
    Public Function Select_RepairData(ByVal repairID As Integer) As RepairData
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_REPAIRDATA_FOR_REPAIRID_SQL
        Dim data As RepairData = Nothing
        strSQL = strSQL.Replace("@repairID", repairID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data = New RepairData With {.RepairID = dataReader("RepairID"), .Warranty = dataReader("Warranty"), .Address = dataReader("Address"), .Contact = dataReader("Contact"), .Phone = dataReader("Phone"),
                    .Place = dataReader("Place"), .RepairOrder = dataReader("RepairOrder"), .ArchiveDate = dataReader("ArchiveDate"), .RepairType = dataReader("RepairType"), .Remark = dataReader("Remark"),
                    .ETA = dataReader("ETA"), .Status = dataReader("Status")}
            Loop
        End If
        conDB.Close()
        Return data
    End Function
    Public Function Select_RepairLog(ByVal repairID As Integer) As List(Of RepairLog)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_REPAIRLOG_FOR_REPAIRID_SQL
        strSQL = strSQL.Replace("@id", repairID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of RepairLog) = New List(Of RepairLog)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New RepairLog With {.LoginID = dataReader("LoginID"), .LogDate = dataReader("LogDate"), .RepairID = dataReader("RepairID"), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function
    Public Function Select_LoginName(ByVal loginID As Integer) As String
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_LOGINDATA_FOR_LOGINID_SQL
        strSQL = strSQL.Replace("@id", loginID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim strData As String = ""
        If dataReader.HasRows Then
            Do While dataReader.Read
                strData = dataReader("UserName")
            Loop
        End If
        conDB.Close()
        Return strData
    End Function
    Public Function Insert_RepairData(ByVal caseID As Integer, ByVal repairOrder As String, ByVal loginID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRDATA_SQL
        strSQL = strSQL.Replace("@caseID", caseID).Replace("@repairOrder", repairOrder).Replace("@id", loginID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        Return intID
    End Function
    Public Function Insert_RepairLog(ByVal RepairID As Integer, ByVal Remark As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRLOG_SQL
        strSQL = strSQL.Replace("@id", RepairID).Replace("@loginID", LoginID).Replace("@date", Now.Date).Replace("@remark", Remark)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        Return intID
    End Function
    Public Function Create_NewOrder() As String
        Dim strOrder As String = "RP" & Now.Year & Now.Month
        Dim strSQL As String = SELECT_PAIRORDER_COUNT_SQL
        strSQL = strSQL.Replace("@order", strOrder)
        Dim conDB As Connection = New Connection
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intCount As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intCount = dataReader("OrderCount")
            Loop
        End If
        If intCount <> -1 Then
            strOrder = "RP" & Now.Year & Now.Month & Format((intCount + 1), "0000")
        Else
            Return Nothing
        End If
        Return strOrder
    End Function

End Class
