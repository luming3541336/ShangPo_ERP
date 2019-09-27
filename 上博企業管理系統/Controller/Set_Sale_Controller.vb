Imports System.Data.SqlClient

Public Class Set_Sale_Controller
    Inherits Set_Sale_Model
    Public Sub Set_Mode(ByVal intMode As Integer)
        Me.intMode = intMode
    End Sub
    Public Function Get_Mode() As Integer
        Return intMode
    End Function
    Public Sub Set_CaseID(ByVal caseID As Integer)
        Me.caseID = caseID
    End Sub
    Public Sub Set_ShipmentID(ByVal saleID As Integer)
        Me.saleID = saleID
    End Sub
    Public Function Create_SaleNO() As String
        Dim conDB As Connection = New Connection
        Select Case intMode
            Case INSERT_MODE
                Dim strDate As String = DateTime.Now.AddYears(-1911).Year & Format(DateTime.Now, "MM")
                Dim strSQL As String = COUNT_SHIPMENTDATA
                strSQL = strSQL.Replace("@dateStr", strDate)
                Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
                If dataReader.HasRows Then
                    dataReader.Read()
                    Return "S" & strDate & Format(dataReader(0) + 1, "000")
                End If
            Case EDIT_MODE
                Dim strSQL As String = SELECT_SHIPMENTDATA_FOR_SALEID
                strSQL = strSQL.Replace("@editID", saleID)
                Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
                If dataReader.HasRows Then
                    dataReader.Read()
                    Return dataReader(0)
                End If
        End Select
        conDB.Close()
        Return "連線錯誤"
    End Function
    Public Function Load_Stock(ByVal item As Integer) As List(Of Stock)
        Dim returnList As List(Of Stock) = New List(Of Stock)
        Dim strSql As String = Nothing
        Dim conDB As Connection = New Connection
        Select Case item
            Case PRODUCT
                strSql = SELECT_PROD_STOCK_BY_CASEID
            Case FIT
                strSql = SELECT_FIT_STOCK_BY_CASEID
        End Select
        strSql = strSql.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New Stock With {.PurchaseDetailID = dataReader("PurchaseDetailID"), .Name = dataReader("Name"), .Supplier = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Specification = dataReader("Specification"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"), .Remark = dataReader("Remark"), .RemainAmount = dataReader("RemainAmount")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    Public Function Search_Order(ByVal item As Integer) As List(Of ShipmentData)
        Dim conDB As Connection = New Connection
        Dim returnList As List(Of ShipmentData) = New List(Of ShipmentData)
        Dim strSql As String = Nothing
        Select Case item
            Case PRODUCT
                strSql = SELECT_PROD_REVIEW_BY_SALEID
            Case FIT
                strSql = SELECT_FIT_REVIEW_BY_SALEID
        End Select
        strSql = strSql.Replace("@editID", saleID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New ShipmentData With {.SaleDetailID = dataReader("SaleDetailID"), .PurchaseDetailID = dataReader("PurchaseDetailID"), .Name = dataReader("Name"), .Supplier = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Specification = dataReader("Specification"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"), .Remark = dataReader("Remark"), .count = dataReader("Count"), .RemainAmount = dataReader("RemainAmount"), .PIC = dataReader("PIC")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    Public Function Insert_ShipmentData(ByVal saleNo As String, insertTime As DateTime) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_SHIPMENTDATA_SQL
        Dim strUpdateCaseTimeSQL As String = UPDATE_CASEDATA_FOR_UPDATETIME_SQL
        strSQL = strSQL.Replace("@caseID", caseID)
        strSQL = strSQL.Replace("@saleNO", saleNo)
        strSQL = strSQL.Replace("@time", Format(insertTime, "yyyy/MM/dd"))
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                saleID = CInt(dataReader("id"))
                Return 1
            Loop
        End If
        Return Nothing
    End Function
    Public Function Update_ShipmentData_For_InsertTime(ByVal insertTime As DateTime) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_SHIPMENTDATA_FOR_INSERTTIME_SQL
        strSQL = strSQL.Replace("@time", Format(insertTime, "yyyy/MM/dd"))
        strSQL = strSQL.Replace("@editID", saleID)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Insert_ShipmentPart(ByVal purchasePID As Integer, ByVal count As Integer, ByVal pic As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_SALEPROD_SQL
        strSQL = strSQL.Replace("@id", saleID)
        strSQL = strSQL.Replace("@purchasePID", purchasePID)
        strSQL = strSQL.Replace("@count", count)
        strSQL = strSQL.Replace("@pic", pic)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Update_ShipmentPart(ByVal salePID As Integer, ByVal purchasePID As Integer, ByVal count As Integer, ByVal pic As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_SALEPROD_SQL
        strSQL = strSQL.Replace("@shipmentPID", salePID)
        strSQL = strSQL.Replace("@purchasePID", purchasePID)
        strSQL = strSQL.Replace("@count", count)
        strSQL = strSQL.Replace("@pic", pic)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Del_ShipmentPart(ByVal salePID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_SALEPROD_SQL
        strSQL = strSQL.Replace("@shipmentPID", salePID)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Insert_ShipmentPart2(ByVal purchaseFID As Integer, ByVal count As Integer, ByVal pic As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_SALEFIT_SQL
        strSQL = strSQL.Replace("@id", saleID)
        strSQL = strSQL.Replace("@purchaseP2ID", purchaseFID)
        strSQL = strSQL.Replace("@count", count)
        strSQL = strSQL.Replace("@pic", pic)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Update_ShipmentPart2(ByVal saleFID As Integer, ByVal purchaseFID As Integer, ByVal count As Integer, ByVal pic As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_SALEFIT_SQL
        strSQL = strSQL.Replace("@shipmentP2ID", saleFID)
        strSQL = strSQL.Replace("@purchaseP2ID", purchaseFID)
        strSQL = strSQL.Replace("@count", count)
        strSQL = strSQL.Replace("@pic", pic)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Del_ShipmentPart2(ByVal saleFID As Integer)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_SALEFIT_SQL
        strSQL = strSQL.Replace("@shipmentP2ID", saleFID)
        Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery
    End Function
    Public Function Get_ShipmentData_InsertTime() As Date
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SHIPMENTDATA_FOR_INSERTTIME_SQL
        strSQL = strSQL.Replace("@editID", saleID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            dataReader.Read()
            Return dataReader(0)
        End If
        Return Nothing
    End Function
    Public Sub Set_Remove_Prod_DGV(ByVal salePID As Integer)
        removePDGV.Add(salePID)
    End Sub
    Public Sub Set_Remove_Fit_DGV(ByVal saleFID As Integer)
        removeFDGV.Add(saleFID)
    End Sub
    Public Function Get_Remove_Prod_DGV() As List(Of Integer)
        Return removePDGV
    End Function
    Public Function Get_Remove_Fit_DGV() As List(Of Integer)
        Return removeFDGV
    End Function
End Class