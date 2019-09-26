Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class Data_Product_Controller
    Inherits Data_Product_Model
    Public Function Select_ProdPartData() As List(Of Prod)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PRODPARTDATA_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of Prod) = New List(Of Prod)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New Prod With {.ProdPartID = dataReader("ProdPartID"), .SuID = dataReader("SuID"), .ProdName = dataReader("ProdName"), .ProdNumber = dataReader("ProdNumber"), .SupplierName = dataReader("SupplierNumber") & "(" & dataReader("SupplierName") & ")"})
            End While
        End If
        Return listData
    End Function
    Public Function Select_ProdPartData2() As List(Of Prod)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_FITTINGSET_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of Prod) = New List(Of Prod)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New Prod With {.ProdPartID = dataReader("ProdPart2ID"), .SuID = dataReader("SuID"), .ProdName = dataReader("FitName"), .ProdNumber = dataReader("FitNumber"), .SupplierName = dataReader("SupplierNumber") & "(" & dataReader("SupplierName") & ")"})
            End While
        End If
        Return listData
    End Function
    Public Function Select_Supplier() As List(Of SupplierData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_SUPPLIERDATA_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of SupplierData) = New List(Of SupplierData)
        Clear_listSuID()
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New SupplierData With {.Name = dataReader("Number") & "(" & dataReader("Name") & ")"})
                Set_listSuID(dataReader("SuID"))
            End While
        End If
        Return listData
    End Function
    Public Function Select_PurchaseData(ByVal prodID As Integer) As List(Of PuchaseData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASEDATA_FOR_PRODID_SQL
        strSQL = strSQL.Replace("@prodPartID", prodID)
        Dim listData As List(Of PuchaseData) = New List(Of PuchaseData)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New PuchaseData With {.CaseID = dataReader("CaseID"), .CaseName = dataReader("Place"), .PurchaseID = dataReader("PurchaseID"), .Count = dataReader("Count"), .InsertTime = dataReader("InsertTime").ToString, .PurchaseNo = dataReader("PurchaseNo"), .Specification = dataReader("Specification")})
            End While
        End If
        Return listData
    End Function
    Public Function Select_PurchaseFData(ByVal fitID As Integer) As List(Of PuchaseData)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PURCHASEDATA_FOR_FITID_SQL
        strSQL = strSQL.Replace("@prodPart2ID", fitID)
        Dim listData As List(Of PuchaseData) = New List(Of PuchaseData)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New PuchaseData With {.CaseID = dataReader("CaseID"), .CaseName = dataReader("Place"), .PurchaseID = dataReader("PurchaseID"), .Count = dataReader("Count"), .InsertTime = dataReader("InsertTime").ToString, .PurchaseNo = dataReader("PurchaseNo"), .Specification = dataReader("Specification")})
            End While
        End If
        Return listData
    End Function
    Public Function Select_ProdPartData(ByVal searchitem As Integer, ByVal statement As String) As List(Of Prod)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_PRODPARTDATA_FOR_STATEMENT_SQL
        Select Case searchitem
            Case 0
                strSQL = strSQL.Replace("@statement", " AND ProdPartData.Name Like N'%" & statement & "%'")
            Case 1
                strSQL = strSQL.Replace("@statement", " AND ProdPartData.Number Like N'%" & statement & "%'")

        End Select
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of Prod) = New List(Of Prod)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New Prod With {.ProdPartID = dataReader("ProdPartID"), .SuID = dataReader("SuID"), .ProdName = dataReader("ProdName"), .ProdNumber = dataReader("ProdNumber"), .SupplierName = dataReader("SupplierNumber") & "(" & dataReader("SupplierName") & ")"})
            End While
        End If
        Return listData
    End Function
    Public Function Select_ProdPartData2(ByVal searchitem As Integer, ByVal statement As String) As List(Of Prod)
        Dim conDB As Connection = New Connection
        Dim strSQL As String = SELECT_FITTING_FOR_STATEMENT_SQL

        Select Case searchitem
            Case 0
                strSQL = strSQL.Replace("@statement", " AND ProdPartData2.Name Like N'%" & statement & "%'")
            Case 1
                strSQL = strSQL.Replace("@statement", " AND ProdPartData2.Number Like N'%" & statement & "%'")

        End Select
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim listData As List(Of Prod) = New List(Of Prod)
        If dataReader.HasRows Then
            While dataReader.Read
                listData.Add(New Prod With {.ProdPartID = dataReader("ProdPart2ID"), .SuID = dataReader("SuID"), .ProdName = dataReader("FitName"), .ProdNumber = dataReader("FitNumber"), .SupplierName = dataReader("SupplierNumber") & "(" & dataReader("SupplierName") & ")"})
            End While
        End If
        Return listData
    End Function
    Public Function Insert_ProdPartData(ByVal suID As Integer, ByVal prodName As String, ByVal prodNumber As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_PRODPARTDATA_SQL
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@prodName", prodName)
        strSQL = strSQL.Replace("@prodNumber", prodNumber)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                Return dataReader(0)
            End While
        End If
        Return Nothing
    End Function
    Public Function Insert_ProdPartData2(ByVal suID As Integer, ByVal fitName As String, ByVal fitNumber As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_FITTINGSET_SQL
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@fitName", fitName)
        strSQL = strSQL.Replace("@fitNumber", fitNumber)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            While dataReader.Read
                Return dataReader(0)
            End While
        End If
        Return Nothing
    End Function
    Public Function Update_ProdPartData(ByVal prodID As Integer, ByVal suID As Integer, ByVal prodName As String, ByVal prodNumber As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_PRODPARTDATA_SQL
        strSQL = strSQL.Replace("@prodPartID", prodID)
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@prodNumber", prodNumber)
        strSQL = strSQL.Replace("@prodName", prodName)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Update_ProdPartData2(ByVal fitID As Integer, ByVal suID As Integer, ByVal fitName As String, ByVal fitNumber As String) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = UPDATE_FITTINGSET_SQL
        strSQL = strSQL.Replace("@prodPart2ID", fitID)
        strSQL = strSQL.Replace("@suID", suID)
        strSQL = strSQL.Replace("@fitNumber", fitNumber)
        strSQL = strSQL.Replace("@fitName", fitName)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Del_ProdPartData(ByVal prodID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_PRODPARTDATA_SQL
        strSQL = strSQL.Replace("@prodPartID", prodID)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Function Del_ProdPartData2(ByVal fitID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = DELETE_FITTINGSET_SQL
        strSQL = strSQL.Replace("@prodPart2ID", fitID)
        Dim dataReader As Integer = conDB.ExecuteSQL(strSQL).ExecuteNonQuery
        Return dataReader
    End Function
    Public Sub Set_listSuID(ByVal suID As Integer)
        listSuID.Add(suID)
    End Sub
    Public Function Get_listSuID(ByVal index As Integer) As Integer
        Return listSuID(index)
    End Function
    Public Sub Clear_listSuID()
        listSuID.Clear()
    End Sub
    Public Sub Set_InsertMode()
        intMode = INSERT_MODE
    End Sub
    Public Sub Set_ReviseMode()
        intMode = REVISE_MODE
    End Sub
    Public Sub Set_NormalMode()
        intMode = NORMAL_MODE
    End Sub
    Public Function Get_Mode() As Integer
        Return intMode
    End Function
End Class
