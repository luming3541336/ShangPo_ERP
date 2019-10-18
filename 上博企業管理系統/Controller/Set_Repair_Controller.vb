Imports System.Data.SqlClient

Public Class Set_Repair_Controller
    Inherits Set_Repair_Model
    Public Function Selet_CaseData(ByVal caseID As Integer) As CaseData
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_CASEDATA_FOR_CASEID
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
    Public Function Updata_RepairData(ByVal data As RepairData, ByVal index As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_REPAIRDATA
        strSQL = strSQL.Replace("@repairType", data.RepairType).Replace("@place", data.Place).Replace("@contact", data.Contact).
                                      Replace("@address", data.Address).Replace("@phone", data.Phone).Replace("@warranty", data.Warranty).
                                      Replace("@remark", data.Remark).Replace("@eta", data.ETA).Replace("@archiveDate", Format(data.ArchiveDate, "YYYY/mm/DD")).Replace("@loginID", LoginID).Replace("@id", index)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return intReturn
    End Function
End Class
