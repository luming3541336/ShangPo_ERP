Imports System.Data.SqlClient

Public Class Data_Case_Controller
    Inherits Data_Case_Model
    Public Function Select_CaseData(ByVal state As Integer) As List(Of CaseData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_CASEDATA_FOR_STATE_SQL
        Dim arrayList As List(Of CaseData) = New List(Of CaseData)
        strSQL = strSQL.Replace("@state", state)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New CaseData With {.CaseID = dataReader("CaseID"), .CaseNo = dataReader("CaseNo"), .InsertTime = dataReader("InsertTime"), .LoginID = dataReader("LoginID"), .Place = dataReader("Place"), .State = dataReader("State"), .UpdateTime = dataReader("UpdateTime"), .SalesName = dataReader("SalesName")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_CaseData(ByVal strSearchSQL As String) As List(Of CaseData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = strSearchSQL
        Dim arrayList As List(Of CaseData) = New List(Of CaseData)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New CaseData With {.CaseID = dataReader("CaseID"), .CaseNo = dataReader("CaseNo"), .InsertTime = dataReader("InsertTime"), .LoginID = dataReader("LoginID"), .Place = dataReader("Place"), .State = dataReader("State"), .UpdateTime = dataReader("UpdateTime"), .SalesName = dataReader("SalesName")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_PurchasePart(ByVal caseID As Integer) As List(Of PurchasePart)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASEPART_FOR_CASEID_SQL
        Dim arrayList As List(Of PurchasePart) = New List(Of PurchasePart)
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New PurchasePart With {.PurchasePID = dataReader("PurchasePID"), .ProdName = dataReader("ProdName"), .InsertTime = dataReader("InsertTime"), .Specification = dataReader("Specification"), .CBM = dataReader("CBM"), .Width = dataReader("Width"), .Supplier = dataReader("Supplier"),
                              .Count = dataReader("Count"), .Length = dataReader("Length"), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_PurchasePart2(ByVal caseID As Integer) As List(Of PurchasePart2)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASEPART2_FOR_CASEID_SQL
        Dim arrayList As List(Of PurchasePart2) = New List(Of PurchasePart2)
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New PurchasePart2 With {.PurchaseP2ID = dataReader("PurchaseP2ID"), .FitName = dataReader("FitName"), .InsertTime = dataReader("InsertTime"), .Specification = dataReader("Specification"), .Width = dataReader("Width"), .Supplier = dataReader("Supplier"),
                              .Count = dataReader("Count"), .Length = dataReader("Length"), .Remark = dataReader("Remark")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_ShipmentPart2(ByVal caseID As Integer) As List(Of ShipmentPart2)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SALEFIT_FOR_CASEID_SQL
        Dim arrayList As List(Of ShipmentPart2) = New List(Of ShipmentPart2)
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New ShipmentPart2 With {.ShipmentP2ID = dataReader("ShipmentP2ID"), .FitName = dataReader("FitName"), .InsertTime = dataReader("InsertTime"), .Specification = dataReader("Specification"), .Width = dataReader("Width"), .Supplier = dataReader("Supplier"),
                              .Count = dataReader("Count"), .Length = dataReader("Length"), .Remark = dataReader("Remark"), .PIC = dataReader("PIC")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_ShipmentPart(ByVal caseID As Integer) As List(Of ShipmentPart)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SALEPROD_FOR_CASEID_SQL
        Dim arrayList As List(Of ShipmentPart) = New List(Of ShipmentPart)
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New ShipmentPart With {.ShipmentPID = dataReader("ShipmentPID"), .ProdName = dataReader("ProdName"), .InsertTime = dataReader("InsertTime"), .Specification = dataReader("Specification"), .CBM = dataReader("CBM"), .Width = dataReader("Width"), .Supplier = dataReader("Supplier"),
                              .Count = dataReader("Count"), .Length = dataReader("Length"), .Remark = dataReader("Remark"), .PIC = dataReader("PIC")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_UnShipmentPart(ByVal caseID As Integer) As List(Of UnsaleProd)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PROD_UNSALE_ITEM_SQL
        Dim arrayList As List(Of UnsaleProd) = New List(Of UnsaleProd)
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New UnsaleProd With {.ProdName = dataReader("ProdName"), .Specification = dataReader("Specification"), .CBM = dataReader("CBM"), .Width = dataReader("Width"),
                               .Length = dataReader("Length"), .RemainAmount = dataReader("RemainAmount")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Select_UnShipmentPart2(ByVal caseID As Integer) As List(Of UnsaleFit)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_FIT_UNSALE_ITEM_SQL
        Dim arrayList As List(Of UnsaleFit) = New List(Of UnsaleFit)
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                arrayList.Add(New UnsaleFit With {.FitName = dataReader("FitName"), .Specification = dataReader("Specification"), .Width = dataReader("Width"),
                               .Length = dataReader("Length"), .RemainAmount = dataReader("RemainAmount")})
            Loop
        End If
        conDB.Close()
        Return arrayList
    End Function
    Public Function Update_Case_Complete(ByVal caseID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_CASEDATA_STATE_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@caseID", caseID)
        strSQL = strSQL.Replace("@state", 1)
        intResult = conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
        conDB.Close()
        Return intResult
    End Function
    Public Function Update_Case_Void(ByVal caseID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_CASEDATA_STATE_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@caseID", caseID)
        strSQL = strSQL.Replace("@state", 2)
        intResult = conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
        conDB.Close()
        Return intResult
    End Function
    Public Function Update_Case_CancelComplete(ByVal caseID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_CASEDATA_STATE_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@caseID", caseID)
        strSQL = strSQL.Replace("@state", 0)
        intResult = conDB.ExecuteSQL(strSQL).ExecuteNonQuery()
        conDB.Close()
        Return intResult
    End Function
    Public Function Get_PurchaseCase_Count(ByVal caseID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASE_COUNT_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader()
        If dataReader.Read Then
            intResult = dataReader("Count")
        End If
        conDB.Close()
        Return intResult
    End Function
    Public Function Get_SaleCase_Count(ByVal caseID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SALE_COUNT_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader()
        If dataReader.Read Then
            intResult = dataReader("Count")
        End If
        conDB.Close()
        Return intResult
    End Function
    Public Function Get_PurchaseID_For_Prod(ByVal PID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASEID_FOR_PROD_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@PID", PID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader()
        If dataReader.Read Then
            intResult = dataReader("PurchaseID")
        End If
        conDB.Close()
        Return intResult
    End Function
    Public Function Get_ShipmentID_For_Prod(ByVal PID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SALEID_FOR_PROD_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@PID", PID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader()
        If dataReader.Read Then
            intResult = dataReader("ShipmentID")
        End If
        conDB.Close()
        Return intResult
    End Function
    Public Function Get_PurchaseID_For_Fit(ByVal FID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASEID_FOR_FIT_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@FID", FID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader()
        If dataReader.Read Then
            intResult = dataReader("PurchaseID")
        End If
        conDB.Close()
        Return intResult
    End Function
    Public Function Get_ShipmentID_For_Fit(ByVal FID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SALEID_FOR_FIT_SQL
        Dim intResult As Integer = 0
        strSQL = strSQL.Replace("@FID", FID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader()
        If dataReader.Read Then
            intResult = dataReader("ShipmentID")
        End If
        conDB.Close()
        Return intResult
    End Function
    Public Function Select_WorkDetail(ByVal caseID As Integer) As List(Of Set_WorkDetail_Model.WorkDetail)
        Dim controller As Set_WorkDetail_Controller = New Set_WorkDetail_Controller
        Return controller.SelectWorkDetailForCaseID(caseID)
    End Function
    Public Function DEL_WorkDetail(ByVal WDID As Integer) As Integer
        Dim controller As Set_WorkDetail_Controller = New Set_WorkDetail_Controller
        Return controller.DelWorkDetail(WDID)
    End Function
    Public Function Select_WorkProgress(ByVal caseID As Integer) As List(Of Set_WorkProgress_Model.WorkProgress)
        Dim controller As Set_WorkProgress_Controller = New Set_WorkProgress_Controller
        Return controller.SelectWorkProgressForCaseID(caseID)
    End Function
    Public Function DEL_WorkProgress(ByVal WPID As Integer) As Integer
        Dim controller As Set_WorkProgress_Controller = New Set_WorkProgress_Controller
        Return controller.DelWorkProgress(WPID)
    End Function
End Class
