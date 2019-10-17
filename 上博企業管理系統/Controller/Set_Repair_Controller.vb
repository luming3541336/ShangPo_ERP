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
End Class
