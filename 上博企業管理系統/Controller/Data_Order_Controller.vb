Imports System.Data.SqlClient

Public Class Data_Order_Controller
    Inherits Data_Order_Model
    Public Function Search_Order() As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = Nothing
        listOrder = New List(Of OrderData)
        If dataType = Nothing Then
            Throw NullTypeException()
        End If
        If caseID = Nothing Then
            Throw NullCaseIDException()
        End If
        Select Case dataType
            Case TYPE_PURCHASE
                strSQL = SEARCH_PURCHASEDATA_FROM_CASEID
            Case TYPE_SALE
                strSQL = SEARCH_SHIPMENTDATA_FROM_CASEID
        End Select
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                listOrder.Add(New OrderData With {.ID = dataReader("ID"), .Number = dataReader("Number"), .InsertTime = dataReader("InsertTime")}) 'InsertTime欄位在PurchaseData為4，ShipmentData為3
            Loop
        End If
        Return listOrder.Count
    End Function
    Public Sub Set_Type(ByVal dataType As Integer)
        Me.dataType = dataType
    End Sub
    Public Function Get_Type() As Integer
        Return dataType
    End Function
    Public Sub Set_CaseID(ByVal id As Integer)
        caseID = id
    End Sub
    Public Sub Set_Place(ByVal name As String)
        Place = name
    End Sub
    Public Function Get_Place() As String
        Return Place
    End Function
    Public Function Get_CaseID() As Integer
        Return caseID
    End Function
    Public Function Get_Prod_Detail(ByVal id As Integer) As List(Of ProdPartDetail)
        Dim detailArray As List(Of ProdPartDetail) = New List(Of ProdPartDetail)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = Nothing
        If dataType = Nothing Then
            Throw NullTypeException()
        End If
        If dataType = TYPE_PURCHASE Then '進貨
            strSQL = SEARCH_PURCHASEPART_FROM_PURCHASEID
        ElseIf dataType = TYPE_SALE Then ' 出貨
            strSQL = SEARCH_SALEPROD_FROM_SALEID
        End If
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                detailArray.Add(New ProdPartDetail With {.ProdPartID = dataReader("ProdPartID"), .SupplierName = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Name = dataReader("Name"), .Specification = dataReader("Specification"),
                                .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"), .Count = dataReader("Count"), .Remark = dataReader("Remark"), .PIC = If(dataType = TYPE_SALE, dataReader("PIC"), Nothing)})
            Loop
        End If
        Return detailArray
    End Function
    Public Function Get_Fit_Detail(ByVal id As Integer) As List(Of ProdPart2Detail)
        Dim detailArray As List(Of ProdPart2Detail) = New List(Of ProdPart2Detail)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = Nothing
        If dataType = TYPE_PURCHASE Then '進貨
            strSQL = SEARCH_PURCHASEPART2_FROM_PURCHASEID
        ElseIf dataType = TYPE_SALE Then '出貨
            strSQL = SEARCH_SALEFIT_FROM_SALEID
        End If
        strSQL = strSQL.Replace("@id", id)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                detailArray.Add(New ProdPart2Detail With {.ProdPart2ID = dataReader("ProdPart2ID"), .SupplierName = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Name = dataReader("Name"), .Specification = dataReader("Specification"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"), .Count = dataReader("Count"), .Remark = dataReader("Remark"), .PIC = If(dataType = TYPE_SALE, dataReader("PIC"), Nothing)})
            Loop
        End If
        conDB.Close()
        Return detailArray
    End Function
    Public Function Get_Order_Data(ByVal index As Integer) As OrderData
        Return listOrder(index)
    End Function
    Public Function Get_OrderList_Index(ByVal ID As Integer) As Integer
        Dim i As Integer = 0
        For Each data As OrderData In listOrder
            If data.ID = ID Then
                Return i
            End If
            i = i + 1
        Next
        Return Nothing
    End Function
    Public Function Delete_Purchase_Order(ByVal id As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = Nothing
        Try
            strSQL = DELETE_PURCHASEPART_FROM_PURCHASEID
            strSQL = strSQL.Replace("@id", id)
            conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
            strSQL = DELETE_PURCHASEPART2_FROM_PURCHASEID
            strSQL = strSQL.Replace("@id", id)
            conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
            strSQL = DELETE_PURCHASEDATA_FROM_PURCHASEID
            strSQL = strSQL.Replace("@id", id)
            Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Delete_Sale_Order(ByVal id As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = Nothing
        Try
            strSQL = DELETE_SALEPROD_FROM_SALEID
            strSQL = strSQL.Replace("@id", id)
            conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
            strSQL = DELETE_SALEFIT_FROM_SALEID
            strSQL = strSQL.Replace("@id", id)
            conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
            strSQL = DELETE_SHIPMENTDATA_FROM_SALEID
            strSQL = strSQL.Replace("@id", id)
            Return conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function NullTypeException() As ArgumentNullException
        Return New ArgumentNullException("未先設定'Set_Type'無法執行")
    End Function
    Function NullCaseIDException() As ArgumentNullException
        Return New ArgumentNullException("未先設定'Set_CaseID'無法執行")
    End Function
End Class

