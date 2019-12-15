Imports System.Data.SqlClient

Public Class Set_ReceiptKey_Controller
    Inherits Set_ReceiptKey_Model
    Public Function Select_ReceiptKey(ByVal intReceiptID As Integer) As List(Of ReceiptKey)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_RECEIPTKEY_SQL
        strSQL = strSQL.Replace("@id", intReceiptID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim data As List(Of ReceiptKey) = New List(Of ReceiptKey)
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New ReceiptKey With {.Item = dataReader("Item"), .Location = dataReader("Location"), .ReceiptCount = dataReader("ReceiptCount"), .Remark = dataReader("Remark"), .Room = dataReader("Room"), .ReceiptKeyID = dataReader("ReceiptKeyID")})
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
    Public Function Insert_ReceiptData(ByVal data As ReceiptData) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_RECEIPTDATA_SQL
        strSQL = strSQL.Replace("@order", data.ReceiptOrder).Replace("@type", data.ReceiptType).Replace("@date", data.ReceiptDate).Replace("@insertDate", data.InsertDate).Replace("@status", data.Status)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim id As Integer = Nothing
        If dataReader.HasRows Then
            dataReader.Read()
            id = dataReader("id")
        End If
        Return id
    End Function
    Public Function Update_ReceiptData(ByVal data As ReceiptData) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_RECEIPTDATA_SQL
        strSQL = strSQL.Replace("@order", data.ReceiptOrder).Replace("@type", data.ReceiptType).Replace("@date", data.ReceiptDate).Replace("@insertDate", data.InsertDate).Replace("@status", data.Status).Replace("@id", data.ReceiptID)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Insert_ReceiptKey(ByVal data As ReceiptKey) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_RECEIPTKEY_SQL
        strSQL = strSQL.Replace("@id", data.ReceiptID).Replace("@room", data.Room).Replace("@date", data.Item).Replace("@location", data.Location).Replace("@count", data.ReceiptCount).Replace("@remark", data.Remark)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim id As Integer = Nothing
        If dataReader.HasRows Then
            dataReader.Read()
            id = dataReader("id")
        End If
        Return id
    End Function


    Public Function Update_ReceiptKey(ByVal data As ReceiptKey) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_RECEIPTKEY_SQL
        strSQL = strSQL.Replace("@id", data.ReceiptKeyID).Replace("@room", data.Room).Replace("@item", data.Item).Replace("@location", data.Location).Replace("@count", data.ReceiptCount).Replace("@remark", data.Remark)
        Dim intData As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return intData
    End Function
    Public Function Create_NewOrder() As String
        Dim strOrder As String = "RPK" & Now.Year & Now.Month
        Dim strSQL As String = SELECT_RECEIPTDATA_COUNT_SQL
        strSQL = strSQL.Replace("@order", strOrder)
        Dim conDB As Connection = New Connection
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intCount As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intCount = dataReader("OrderCount")
            Loop
        End If
        conDB.Close()
        If intCount <> -1 Then
            strOrder = "RPK" & Now.Year & Now.Month & Format((intCount + 1), "0000")
        Else
            Return Nothing
        End If
        Return strOrder
    End Function
End Class
