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
    Public Function Update_RepairData(ByVal data As RepairData) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_REPAIRDATA_SQL
        strSQL = strSQL.Replace("@repairPerson", data.RepairPerson).Replace("@place", data.Place).Replace("@contact", data.Contact).
                                      Replace("@address", data.Address).Replace("@phone", data.Phone).Replace("@warranty", data.Warranty).
                                      Replace("@remark", data.Remark).Replace("@eta", data.ETA).Replace("@archiveDate", data.ArchiveDate).Replace("@result", data.RepairResult).Replace("@id", data.RepairID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
    End Function
    Public Function Update_RepairDataStatus(ByVal status As Integer, repairID As Integer)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_REPAIRDATA_STATUS_SQL
        strSQL = strSQL.Replace("@status", status).Replace("@id", repairID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
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
                    .Place = dataReader("Place"), .RepairOrder = dataReader("RepairOrder"), .ArchiveDate = dataReader("ArchiveDate"), .RepairPerson = dataReader("RepairPerson"), .Remark = dataReader("Remark"),
                    .ETA = dataReader("ETA"), .RepairResult = dataReader("RepairResult"), .Status = dataReader("Status")}
            Loop
        End If
        conDB.Close()
        Return data
    End Function
    Public Function Select_RepairProd(ByVal repairID As Integer) As List(Of RepairProd)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_REPAIRPROD_FOR_REPAIRID_SQL
        Dim data As List(Of RepairProd) = New List(Of RepairProd)
        strSQL = strSQL.Replace("@id", repairID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New RepairProd With {.RepairID = dataReader("RepairID"), .ShipmentPID = dataReader("ShipmentPID"), .ProdPartCount = dataReader("ProdPartCount"), .ProdPartName = dataReader("ProdPartName"), .ProdPartType = dataReader("ProdPartType"),
                    .RepairProdID = dataReader("RepairProdID"), .RepairRemark = dataReader("RepairRemark")})
            Loop
        End If
        conDB.Close()
        Return data
    End Function
    Public Function Select_RepairFile(ByVal repairID As Integer) As List(Of RepairFile)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_REPAIRFILE_SQL
        Dim data As List(Of RepairFile) = New List(Of RepairFile)
        strSQL = strSQL.Replace("@id", repairID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New RepairFile With {.RepairID = dataReader("RepairID"), .RepairFileID = dataReader("RepairFileID"), .RepairFileName = dataReader("RepairFileName"), .RepairFilePath = dataReader("RepairFilePath")})
            Loop
        End If
        conDB.Close()
        Return data
    End Function
    Public Function Select_RepairAmount(ByVal repairID As Integer) As List(Of RepairAmount)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_REPAIRAMOUNT_SQL
        Dim data As List(Of RepairAmount) = New List(Of RepairAmount)
        strSQL = strSQL.Replace("@id", repairID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New RepairAmount With {.RepairID = dataReader("RepairID"), .BillItem = dataReader("BillItem"), .RepairAmountID = dataReader("RepairAmountID"), .RepairPrice = dataReader("RepairPrice")})
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
    Public Function Select_RepairShipment(ByVal caseID As Integer) As List(Of RepairProd)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SHIPMENTDATA_SQL
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim data As List(Of RepairProd) = New List(Of RepairProd)
        If dataReader.HasRows Then
            Do While dataReader.Read
                data.Add(New RepairProd With {.ShipmentPID = dataReader("ShipmentPID"), .ProdPartName = dataReader("Name"), .ProdPartType = dataReader("ProdPartType")})
            Loop
        End If
        conDB.Close()
        Return data
    End Function
    Public Function Insert_RepairData(ByVal caseID As Integer, ByVal repairOrder As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRDATA_SQL
        strSQL = strSQL.Replace("@caseID", caseID).Replace("@repairOrder", repairOrder)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        conDB.Close()
        Return intID
    End Function
    Public Function Insert_RepairLog(ByVal RepairID As Integer, ByVal Remark As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRLOG_SQL
        strSQL = strSQL.Replace("@id", RepairID).Replace("@loginID", LoginID).Replace("@date", Now.ToString("yyyy-MM-dd HH:mm:ss")).Replace("@remark", Remark)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        conDB.Close()
        Return intID
    End Function
    Public Function Insert_RepairProd(ByVal RepairID As Integer, ByVal ProdPartType As Integer, ByVal ShipmentPID As Integer, ByVal ProdPartName As String, ByVal ProdPartCount As Integer, ByVal Remark As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRPROD_SQL
        strSQL = strSQL.Replace("@id", RepairID).Replace("@type", ProdPartType).Replace("@shipmentPID", ShipmentPID).Replace("@name", ProdPartName).Replace("@count", ProdPartCount).Replace("@remark", Remark)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        conDB.Close()
        Return intID
    End Function
    Public Function Insert_RepairAmount(ByVal RepairID As Integer, ByVal BillItem As String, ByVal RepairPrice As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRAMOUNT_SQL
        strSQL = strSQL.Replace("@id", RepairID).Replace("@item", BillItem).Replace("@price", RepairPrice)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        conDB.Close()
        Return intID
    End Function

    Public Function Insert_RepairFile(ByVal RepairID As Integer, ByVal RepairFileName As String, ByVal RepairFilePath As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_REPAIRFILE_SQL
        strSQL = strSQL.Replace("@id", RepairID).Replace("@name", RepairFileName).Replace("@path", RepairFilePath)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim intID As Integer = -1
        If dataReader.HasRows Then
            Do While dataReader.Read
                intID = dataReader("id")
            Loop
        End If
        conDB.Close()
        Return intID
    End Function

    Public Function Update_RepairAmount(ByVal data As RepairAmount) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_REPAIRAMOUNT_SQL
        strSQL = strSQL.Replace("@item", data.BillItem).Replace("@price", data.RepairPrice).Replace("@id", data.RepairAmountID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
    End Function
    Public Function Update_RepairProd(ByVal data As RepairProd) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_REPAIRPROD_SQL
        strSQL = strSQL.Replace("@type", data.ProdPartType).Replace("@shipmentPID", data.ShipmentPID).Replace("@id", data.RepairProdID).Replace("@name", data.ProdPartName).Replace("@count", data.ProdPartCount).Replace("@remark", data.RepairRemark)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
    End Function
    Public Function Delete_RepairFile(ByVal data As RepairFile) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_REPAIRFILE_SQL
        strSQL = strSQL.Replace("@id", data.RepairFileID)
        My.Computer.FileSystem.DeleteFile(data.RepairFilePath)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
    End Function
    Public Function Delete_RepairProd(ByVal RepairProdID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_REPAIRPROD_SQL
        strSQL = strSQL.Replace("@id", RepairProdID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
    End Function
    Public Function Delete_RepairAmount(ByVal RepairAmountID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_REPAIRAMOUNT_SQL
        strSQL = strSQL.Replace("@id", RepairAmountID)
        Dim intReturn As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        conDB.Close()
        Return intReturn
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
        conDB.Close()
        If intCount <> -1 Then
            strOrder = "RP" & Now.Year & Now.Month & Format((intCount + 1), "0000")
        Else
            Return Nothing
        End If
        Return strOrder
    End Function
    Public Sub Copy_File(ByVal D1 As String, ByVal FileName As String)
        FileSystem.FileCopy(D1, UPLOAD_PATH & FileName)
    End Sub
End Class
