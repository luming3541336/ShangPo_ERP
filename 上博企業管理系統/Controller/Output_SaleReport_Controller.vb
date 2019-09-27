Imports System.Data.SqlClient

Public Class Output_SaleReport_Controller
    Inherits Output_SaleReport_Model
    Public Function Load_Purchase_Prod_Form_CaseID(ByVal intCaseID As Integer) As List(Of PurchasePart)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SEARCH_PURCHASE_PROD_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim returnList As List(Of PurchasePart) = New List(Of PurchasePart)
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New PurchasePart With {.PurchasePID = dataReader("PurchasePID"), .ProdName = dataReader("ProdName"),
                               .SupplierName = If(dataReader("Abbr") = "", dataReader("SupplierName"), dataReader("Abbr")), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                               .Count = dataReader("Count"), .Specification = dataReader("Specification"), .InsertTime = dataReader("InsertTime"), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    Public Function Load_Purchase_Fit_Form_CaseID(ByVal intCaseID As Integer) As List(Of PurchasePart2)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SEARCH_PURCHASE_FIT_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim returnList As List(Of PurchasePart2) = New List(Of PurchasePart2)
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New PurchasePart2 With {.PurchaseP2ID = dataReader("PurchaseP2ID"), .FitName = dataReader("FitName"),
                               .SupplierName = If(dataReader("Abbr") = "", dataReader("SupplierName"), dataReader("Abbr")), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                               .Count = dataReader("Count"), .Specification = dataReader("Specification"), .InsertTime = dataReader("InsertTime"), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    Public Function Load_Sale_Prod_From_PID(ByVal intPID As Integer) As List(Of ShipmentPart)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SEARCH_SALE_PROD_SQL
        strSQL = strSQL.Replace("@PurchasePID", intPID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim returnList As List(Of ShipmentPart) = New List(Of ShipmentPart)
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New ShipmentPart With {.Count = dataReader("Count"), .InsertTime = dataReader("InsertTime"), .PIC = dataReader("PIC")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    Public Function Load_Sale_Fit_From_FID(ByVal intFID As Integer) As List(Of ShipmentPart2)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SEARCH_SALE_FIT_SQL
        strSQL = strSQL.Replace("@PurchaseP2ID", intFID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim returnList As List(Of ShipmentPart2) = New List(Of ShipmentPart2)
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New ShipmentPart2 With {.Count = dataReader("Count"), .InsertTime = dataReader("InsertTime"), .PIC = dataReader("PIC")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    '搜尋指定案件編號之資訊
    Public Function Load_Case_Data(ByVal intCaseID As Integer) As CaseData
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SEARCH_CASEID_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim result As CaseData = Nothing
        If dataReader.HasRows Then
            Do While dataReader.Read
                result = New CaseData With {.Place = dataReader("Place"), .CaseID = dataReader("CaseID"), .Address = dataReader("Address"), .Phone = dataReader("Phone"), .State = dataReader("State"), .SalesName = dataReader("SalesName")}
            Loop
        End If
        conDB.Close()
        Return result
    End Function
    Public Function Get_WorkDetail(ByVal caseID As Integer) As List(Of WorkDetail)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SEARCH_WORKDETAIL_SQL
        strSQL = strSQL.Replace("@id", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim returnList As List(Of WorkDetail) = New List(Of WorkDetail)
        If dataReader.HasRows Then
            Do While dataReader.Read
                returnList.Add(New WorkDetail With {.WorkDate = dataReader("WorkDate"), .Detail = dataReader("Detail"), .SalesName = dataReader("SalesName")})
            Loop
        End If
        conDB.Close()
        Return returnList
    End Function
    Public Function Get_CaseID(ByVal index As Integer) As Integer
        Return CaseList(index).CaseID
    End Function
    Public Function Search_CaseID_Index(ByVal caseID As Integer)
        Dim index As Integer = 0
        For Each data As CaseData In CaseList
            If data.CaseID = caseID Then
                Return index
            End If
            index += 1
        Next
        Return Nothing
    End Function
    '產生工程進度表門框部分資料
    Public Function Analysis_WorkProgress_Prod(ByVal purchaseProdList As List(Of PurchasePart)) As List(Of WorkProgress)
        Dim listData As List(Of WorkProgress) = New List(Of WorkProgress)
        For Each data As PurchasePart In purchaseProdList
            If listData.Count = 0 Then
                listData.Add(New WorkProgress With {.DateTime = data.InsertTime, .ProdName = New List(Of String), .Specification = New List(Of String), .Supplier = data.SupplierName, .Count = New List(Of String)})
                listData(listData.Count - 1).ProdName.Add(data.ProdName.Split("(")(0))
                listData(listData.Count - 1).Specification.Add("(" & data.Width & "*" & data.Length & ")")
                listData(listData.Count - 1).Count.Add(data.Count)
            Else
                Dim exitData As Boolean = False
                For Each data2 As WorkProgress In listData
                    If data.InsertTime = data2.DateTime And data.SupplierName.Equals(data2.Supplier) Then
                        Dim index = 0
                        Dim existProd As Boolean = False
                        For Each prodName As String In data2.ProdName
                            If data.ProdName.Split("(")(0).Equals(prodName) Then
                                data2.Specification(index) += "(" & data.Width & "*" & data.Length & ")"
                                data2.Count(index) += "." & (data.Count)
                                existProd = True
                                Exit For
                            End If
                            index += 1
                        Next
                        If existProd = False Then
                            data2.ProdName.Add(data.ProdName.Split("(")(0))
                            data2.Specification.Add("(" & data.Width & "*" & data.Length & ")")
                            data2.Count.Add(data.Count)
                        End If
                        exitData = True
                    End If
                Next
                '若發現日期及廠商皆不符合時，會新增一欄新的日期及廠商
                If exitData = False Then
                    listData.Add(New WorkProgress With {.DateTime = data.InsertTime, .Count = New List(Of String), .ProdName = New List(Of String), .Specification = New List(Of String), .Supplier = data.SupplierName})
                    listData(listData.Count - 1).ProdName.Add(data.ProdName.Split("(")(0))
                    listData(listData.Count - 1).Specification.Add("(" & data.Width & "*" & data.Length & ")")
                    listData(listData.Count - 1).Count.Add(data.Count)
                End If
            End If
        Next
        Return listData
    End Function
    '產生工程進度表門扇部分資料
    Public Function Analysis_WorkProgress_Fit(ByVal purchaseFitList As List(Of PurchasePart2)) As List(Of WorkProgress)
        Dim listData As List(Of WorkProgress) = New List(Of WorkProgress)
        For Each data As PurchasePart2 In purchaseFitList
            If listData.Count = 0 Then
                listData.Add(New WorkProgress With {.DateTime = data.InsertTime, .Count = New List(Of String), .ProdName = New List(Of String), .Specification = New List(Of String), .Supplier = data.SupplierName})
                listData(listData.Count - 1).ProdName.Add(data.FitName.Split("(")(0))
                listData(listData.Count - 1).Specification.Add("(" & data.Width & "*" & data.Length & ")")
                listData(listData.Count - 1).Count.Add(data.Count)
            Else
                Dim exitData As Boolean = False
                For Each data2 As WorkProgress In listData
                    If data.InsertTime = data2.DateTime And data.SupplierName.Equals(data2.Supplier) Then
                        Dim index = 0
                        Dim existProd As Boolean = False
                        For Each prodName As String In data2.ProdName
                            If data.FitName.Split("(")(0).Equals(prodName) Then
                                data2.Specification(index) += "(" & data.Width & "*" & data.Length & ")"
                                data2.Count(index) += "." & (data.Count)
                                existProd = True
                                Exit For
                            End If
                            index += 1
                        Next
                        If existProd = False Then
                            data2.ProdName.Add(data.FitName.Split("(")(0))
                            data2.Specification.Add("(" & data.Width & "*" & data.Length & ")")
                            data2.Count.Add(data.Count)
                        End If
                        exitData = True
                    End If
                Next
                If exitData = False Then
                    listData.Add(New WorkProgress With {.DateTime = data.InsertTime, .Count = New List(Of String), .ProdName = New List(Of String), .Specification = New List(Of String), .Supplier = data.SupplierName})
                    listData(listData.Count - 1).ProdName.Add(data.FitName.Split("(")(0))
                    listData(listData.Count - 1).Specification.Add("(" & data.Width & "*" & data.Length & ")")
                    listData(listData.Count - 1).Count.Add(data.Count)
                End If
            End If
        Next
        Return listData
    End Function
    'Ver2
    Public Function Select_ShipRecord_Prod(ByVal intCaseID As Integer) As List(Of ShipRecord)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SHIPRECORD_PROD_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        strSQL = strSQL.Replace("@statement", "")
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of ShipRecord) = New List(Of ShipRecord)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New ShipRecord With {.PurchaseID = dataReader("PurchasePID"), .ProductName = dataReader("ProductName"),
                               .SupplierName = dataReader("SupplierName"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                               .PurchaseCount = dataReader("PurchaseCount"), .Specification = dataReader("Specification"), .PurchaseTime = dataReader("PurchaseTime"), .SaleCount = If(IsDBNull(dataReader("SaleCount")), "", dataReader("SaleCount")), .SaleTime = If(IsDBNull(dataReader("SaleTime")), "", dataReader("SaleTime")), .PIC = If(IsDBNull(dataReader("PIC")), "", dataReader("PIC")), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function
    Public Function Select_UnSale_Prod(ByVal intCaseID As Integer) As List(Of ShipRecord)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PROD_STOCK_BY_CASEID
        strSQL = strSQL.Replace("@caseID", intCaseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of ShipRecord) = New List(Of ShipRecord)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New ShipRecord With {.PurchaseID = dataReader("PurchaseDetailID"), .ProductName = dataReader("Name"),
                               .SupplierName = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                               .PurchaseCount = dataReader("RemainAmount"), .Specification = dataReader("Specification"), .PurchaseTime = "", .SaleCount = "", .SaleTime = "", .PIC = "", .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function
    Public Function Select_UnSale_Fit(ByVal intCaseID As Integer) As List(Of ShipRecord)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_FIT_STOCK_BY_CASEID
        strSQL = strSQL.Replace("@caseID", intCaseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of ShipRecord) = New List(Of ShipRecord)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New ShipRecord With {.PurchaseID = dataReader("PurchaseDetailID"), .ProductName = dataReader("Name"),
                               .SupplierName = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                               .PurchaseCount = dataReader("RemainAmount"), .Specification = dataReader("Specification"), .PurchaseTime = "", .SaleCount = "", .SaleTime = "", .PIC = "", .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function
    Public Function Select_ShipRecord_Prod(ByVal intCaseID As Integer, ByVal strStatement As String) As List(Of ShipRecord)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SHIPRECORD_PROD_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        strSQL = strSQL.Replace("@statement", strStatement)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of ShipRecord) = New List(Of ShipRecord)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New ShipRecord With {.PurchaseID = dataReader("PurchasePID"), .ProductName = dataReader("ProductName"),
                               .SupplierName = dataReader("SupplierName"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                               .PurchaseCount = dataReader("PurchaseCount"), .Specification = dataReader("Specification"), .PurchaseTime = dataReader("PurchaseTime"), .SaleCount = If(IsDBNull(dataReader("SaleCount")), "", dataReader("SaleCount")), .SaleTime = If(IsDBNull(dataReader("SaleTime")), "", dataReader("SaleTime")), .PIC = If(IsDBNull(dataReader("PIC")), "", dataReader("PIC")), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function

    Public Function Select_ShipRecord_Fit(ByVal intCaseID As Integer) As List(Of ShipRecord)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SHIPRECORD_FIT_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        strSQL = strSQL.Replace("@statement", "")
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of ShipRecord) = New List(Of ShipRecord)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New ShipRecord With {.PurchaseID = dataReader("PurchaseP2ID"), .ProductName = dataReader("ProductName"),
                               .SupplierName = dataReader("SupplierName"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                              .PurchaseCount = dataReader("PurchaseCount"), .Specification = dataReader("Specification"), .PurchaseTime = dataReader("PurchaseTime"), .SaleCount = If(IsDBNull(dataReader("SaleCount")), "", dataReader("SaleCount")), .SaleTime = If(IsDBNull(dataReader("SaleTime")), "", dataReader("SaleTime")), .PIC = If(IsDBNull(dataReader("PIC")), "", dataReader("PIC")), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function
    Public Function Select_ShipRecord_Fit(ByVal intCaseID As Integer, ByVal strStatement As String) As List(Of ShipRecord)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SHIPRECORD_FIT_SQL
        strSQL = strSQL.Replace("@caseID", intCaseID)
        strSQL = strSQL.Replace("@statement", strStatement)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of ShipRecord) = New List(Of ShipRecord)
        If dataReader.HasRows Then
            Do While dataReader.Read
                listData.Add(New ShipRecord With {.PurchaseID = dataReader("PurchaseP2ID"), .ProductName = dataReader("ProductName"),
                               .SupplierName = dataReader("SupplierName"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"),
                              .PurchaseCount = dataReader("PurchaseCount"), .Specification = dataReader("Specification"), .PurchaseTime = dataReader("PurchaseTime"), .SaleCount = If(IsDBNull(dataReader("SaleCount")), "", dataReader("SaleCount")), .SaleTime = If(IsDBNull(dataReader("SaleTime")), "", dataReader("SaleTime")), .PIC = If(IsDBNull(dataReader("PIC")), "", dataReader("PIC")), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return listData
    End Function
End Class
