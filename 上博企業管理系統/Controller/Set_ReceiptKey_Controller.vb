Imports System.Data.SqlClient

Public Class Set_ReceiptKey_Controller
    Inherits Set_ReceiptKey_Model
    Public Function Select_ReceiptKey(ByVal intReceiptKeyID As Integer) As ReceiptKey
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_RECEIPTKEY_SQL
        strSQL = strSQL.Replace("@id", intReceiptKeyID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim data As ReceiptKey = Nothing
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Item = dataReader("Item")
                data.Location = dataReader("Location")
                data.ReceiptCount = dataReader("ReceiptCount")
                data.Remark = dataReader("Remark")
                data.Room = dataReader("Room")
            Loop
        End If
        Return data
    End Function
    Public Function Select_ReceiptData(ByVal intReceiptID As Integer) As ReceiptData
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_RECEIPTDATA_SQL
        strSQL = strSQL.Replace("@id", intReceiptID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim data As ReceiptData = Nothing
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.ReceiptID = dataReader("ReceiptID")
                data.CaseID = dataReader("CaseID")
                data.ReceiptOrder = dataReader("ReceiptOrder")
                data.ReceiptType = dataReader("ReceiptType")
                data.ReceiptDate = dataReader("ReceiptDate")
                data.Contact = dataReader("Contact")
                data.Place = dataReader("Place")
                data.Status = dataReader("Status")
                data.InsertDate = dataReader("InsertTime")
            Loop
        End If
        Return data
    End Function
    Public Function Update_ReceiptKey(ByVal intReceiptKeyID As String, Optional ByVal Item As String, Optional ByVal Location As String, Optional ByVal ReceiptCount As Integer, Optional ByVal Remark As String, Optional ByVal Room As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_RECEIPTKEY_SQL
        strSQL = strSQL.Replace("@id", intReceiptKeyID).Replace("@room", Room).Replace("@item", Item).Replace("@location", Location).Replace("@count", ReceiptCount).Replace("@remark", Remark)
        Dim intData As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return intData
    End Function
End Class
