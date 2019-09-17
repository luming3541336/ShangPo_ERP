Imports System.Data.SqlClient

Public Class Search_Controller
    '透過關鍵字(代號或名稱)搜尋到有庫存之目標產品(語法待修正)
    '  #依照產品或配件分別存入prodSetArray或fittingSetArray
    '  #item定義：
    '       →item = 0 : 產品搜尋
    '       →item = 1 : 配件搜尋
    Public Function SearchStock(ByVal item As Integer) As ArrayList
        Dim conDB As Connection = New Connection
        Dim dataArray As ArrayList = New ArrayList
        Dim strSql As String() = {"SELECT PurchaseProd.PurchasePID,ProdSet.[Name],SupplierData.[Name] AS Supplier, SupplierData.Abbr,PurchaseProd.Specification,PurchaseProd.[Count],Width,[Length],CBM,Remark,([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) AS RemainAmount
                                              From PurchaseProd LEFT JOIN SaleProd ON PurchaseProd.PurchasePID = SaleProd.PurchasePID, ProdSet,SupplierData
                                              WHERE PurchaseProd.ProdID = ProdSet.ProdID AND ProdSet.SuID = SupplierData.SuID 
                                              GROUP BY PurchaseProd.PurchasePID,prodSet.[Name],PurchaseProd.Specification,PurchaseProd.[Count],Width,[Length],CBM,Remark,SupplierData.[Name],SupplierData.Abbr
                                              Having ([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) > 0",
                                              "SELECT PurchaseFit.PurchaseFID,FittingSet.[Name],SupplierData.[Name] AS Supplier,SupplierData.Abbr,PurchaseFit.Width,PurchaseFit.[Length],PurchaseFit.CBM,PurchaseFit.Specification,PurchaseFit.[Count],Remark,(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) AS RemainAmount
                                               FROM PurchaseFit LEFT JOIN SaleFit ON PurchaseFit.PurchaseFID = SaleFit.PurchaseFID, FittingSet,SupplierData
                                               WHERE PurchaseFit.FitID = FittingSet.FitID AND FittingSet.SuID = SupplierData.SuID 
                                               GROUP BY PurchaseFit.PurchaseFID,FittingSet.[Name],PurchaseFit.Specification,PurchaseFit.[Count],Remark,SupplierData.[Name],PurchaseFit.Width,PurchaseFit.[Length],PurchaseFit.CBM,SupplierData.Abbr
                                               Having (PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) > 0"}
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql(item)).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                If item = 0 Then
                    dataArray.Add({dataReader("PurchasePID"), dataReader("Name"), If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), dataReader("Specification"), dataReader("Width"), dataReader("Length"), dataReader("CBM"), dataReader("Remark"), dataReader("RemainAmount")})
                ElseIf item = 1 Then
                    dataArray.Add({dataReader("PurchaseFID"), dataReader("Name"), If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), dataReader("Specification"), dataReader("Width"), dataReader("Length"), dataReader("CBM"), dataReader("Remark"), dataReader("RemainAmount")})
                End If
            Loop
        End If
        conDB.Close()
        Return dataArray
    End Function
    '透過關鍵字(代號或名稱)搜尋到目標產品
    '  ->依照產品或配件分別存入prodSetArray或fittingSetArray
    '  ->intClass定義：
    '                 →intClass = 0 : 產品搜尋
    '                 →intClass = 1 : 配件搜尋
    Public Function SearchProd(ByVal intClass As Integer) As ArrayList
        Dim conDB As Connection = New Connection
        Dim dataArray As ArrayList = New ArrayList
        Dim strSql As String() = {"Select Prodset.ProdID,ProdSet.Name,SupplierData.Name As Supplier ,SupplierData.Abbr
                           From ProdSet, SupplierData
                           Where ProdSet.SuID = SupplierData.SuID",
                           "SELECT FittingSet.FitID,FittingSet.Name,SupplierData.Name as Supplier ,SupplierData.Abbr
                           From FittingSet, SupplierData
                           Where FittingSet.SuID = SupplierData.SuID"}
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql(intClass)).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                If intClass = 0 Then
                    dataArray.Add({dataReader("ProdID"), dataReader("Name"), If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr"))})
                ElseIf intClass = 1 Then
                    dataArray.Add({dataReader("FitID"), dataReader("Name"), If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr"))})
                End If
            Loop
        End If
        conDB.Close()
        Return dataArray
    End Function
    '讀取所有類別資料
    Public Function LoadClassData() As ArrayList
        Dim conDB As Connection = New Connection
        Dim dataArray As ArrayList = New ArrayList
        Dim strSql As String = "SELECT ClassID,Name FROM ClassData"
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataArray.Add({dataReader("ClassID"), dataReader("Name"), ""})
            Loop
        End If
        Return dataArray
    End Function
    '讀取所有供應商資料
    Public Function LoadSupplierData() As ArrayList
        Dim conDB As Connection = New Connection
        Dim dataArray As ArrayList = New ArrayList
        Dim strSql As String = "SELECT SuID,Name,Abbr FROM SupplierData"
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataArray.Add({dataReader("SuID"), If(dataReader("Abbr") = "", dataReader("Name"), dataReader("Abbr")), ""})
            Loop
        End If
        Return dataArray
    End Function
    Public Function SelectProdDataCount(ByVal name As String, ByVal suID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim data As Integer = 0
        Dim strSql As String = "SELECT Count(*) FROM ProdSet WHERE Name = N'@name' AND SuID = @suID"
        strSql = strSql.Replace("@name", name)
        strSql = strSql.Replace("@suID", suID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            dataReader.Read()
            data = dataReader(0)
        End If
        Return data
    End Function
    Public Function SelectFitDataCount(ByVal name As String, ByVal suID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim data As Integer = 0
        Dim strSql As String = "SELECT Count(*) FROM FittingSet WHERE Name = N'@name' AND SuID = @suID"
        strSql = strSql.Replace("@name", name)
        strSql = strSql.Replace("@suID", suID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            dataReader.Read()
            data = dataReader(0)
        End If
        Return data
    End Function
    '將設定產品或配件資料新增至資料庫
    Public Function InsertData(ByVal type As Integer, ByVal name As String, ByVal suID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim typeArray As String() = {"INSERT INTO ProdSet(Name,SuID) VALUES(N'@name', @suID); SELECT id = SCOPE_IDENTITY();",
            "INSERT INTO FittingSet(Name,SuID) VALUES(N'@name', @suID); SELECT id = SCOPE_IDENTITY();"}
        Dim strSQL As String = typeArray(type)
        Dim id As Integer = Nothing
        strSQL = strSQL.Replace("@name", name)
        strSQL = strSQL.Replace("@suID", suID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                id = CInt(dataReader("id"))
            Loop
        End If
        Return id
    End Function
End Class
