Imports System.Data.SqlClient
Public Class Set_ReceiptCom_Controller
    Inherits Set_ReceiptCom_Model
    Private ReceiptKeyController As Set_ReceiptKey_Controller = New Set_ReceiptKey_Controller
    Public Function Select_ReceiptCom(ByVal intReceiptID As Integer) As List(Of ReceiptCom)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_RECEIPTCOM_SQL
        strSQL = strSQL.Replace("@id", intReceiptID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim data As List(Of ReceiptCom) = New List(Of ReceiptCom)
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New ReceiptCom With {.Item = dataReader("Item"), .Count = dataReader("Count"), .Price = dataReader("Price"), .Remark = dataReader("Remark"), .ReceiptComID = dataReader("ReceiptComID"), .ReceiptID = dataReader("ReceiptID"), .TotalAmount = dataReader("TotalAmount"), .Unit = dataReader("Unit")})
            Loop
        End If
        Return data
    End Function
    Public Function Select_ReceiptData(ByVal intReceiptID As Integer) As ReceiptData
        Return ReceiptKeyController.Select_ReceiptData(intReceiptID)
    End Function
    Public Function Delete_ReceiptData(ByVal intReceiptID As Integer) As Integer
        Return ReceiptKeyController.Delete_ReceiptData(intReceiptID)
    End Function
    Public Function Select_ReceiptFile(ByVal repairID As Integer) As List(Of ReceiptFile)
        Return ReceiptKeyController.Select_ReceiptFile(repairID)
    End Function
    Public Function Insert_ReceipFile(ByVal ReceiptID As Integer, ByVal ReceiptFileName As String, ByVal ReceiptFilePath As String) As Integer
        Return ReceiptKeyController.Insert_ReceipFile(ReceiptID, ReceiptFileName, ReceiptFilePath)
    End Function
    Public Function Delete_ReceiptFile(ByVal data As ReceiptFile) As Integer
        Return ReceiptKeyController.Delete_ReceiptFile(data)
    End Function
    Public Function Insert_ReceiptData(ByVal data As ReceiptData) As Integer
        Return ReceiptKeyController.Insert_ReceiptData(data)
    End Function
    Public Function Update_ReceiptData(ByVal data As ReceiptData) As Integer
        Return ReceiptKeyController.Update_ReceiptData(data)
    End Function
    Public Function Insert_ReceiptCom(ByVal data As ReceiptCom) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_RECEIPTCOM_SQL
        strSQL = strSQL.Replace("@id", data.ReceiptID).Replace("@price", data.Price).Replace("@item", data.Item).Replace("@totalAmount", data.TotalAmount).Replace("@count", data.Count).Replace("@unit", data.Unit).Replace("@remark", data.Remark)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim id As Integer = Nothing
        If dataReader.HasRows Then
            dataReader.Read()
            id = dataReader("id")
        End If
        Return id
    End Function
    Public Function Delete_ReceiptCom(ByVal id As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_RECEIPTCOM_SQL
        strSQL = strSQL.Replace("@id", id)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
    End Function
    Public Function Update_ReceiptCom(ByVal data As ReceiptCom) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_RECEIPTCOM_SQL
        strSQL = strSQL.Replace("@id", data.ReceiptComID).Replace("@price", data.Price).Replace("@item", data.Item).Replace("@count", data.Count).Replace("@totalAmount", data.TotalAmount).Replace("@unit", data.Unit).Replace("@remark", data.Remark)
        Dim intData As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return intData
    End Function
    Public Function Create_NewOrder() As String
        Dim strOrder As String = "RPC" & Now.Year & Now.Month
        Dim strSQL As String = ReceiptKeyController.SELECT_RECEIPTDATA_COUNT
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
            strOrder = "RPC" & Now.Year & Now.Month & Format((intCount + 1), "0000")
        Else
            Return Nothing
        End If
        Return strOrder
    End Function
    Public Sub Copy_File(ByVal D1 As String, ByVal FileName As String)
        FileSystem.FileCopy(D1, UPLOAD_PATH & FileName)
    End Sub
End Class
