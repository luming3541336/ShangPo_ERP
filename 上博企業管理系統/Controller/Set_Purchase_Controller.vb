Imports System.Data.SqlClient

Public Class Set_Purchase_Controller : Inherits Set_Purchase_Model
    Public Sub New(ByVal caseID As Integer)
        Me.caseID = caseID
        intMode = INSERT_MODE
    End Sub
    Public Sub New(ByVal caseID As Integer, ByVal editID As Integer)
        Me.caseID = caseID
        Me.editID = editID
        intMode = EDIT_MODE
    End Sub
    '創造進貨單號
    '   ﹂>編碼規則:
    '       ﹂>P:進貨
    '       ﹂>XXXXX: 建立民國年月
    '       ﹂>-XXX:訂單流水號(依照每個月排序，開放最多每個月999筆)
    Public Function Create_PurchaseNO() As String
        Dim conDB As Connection = New Connection
        If intMode = INSERT_MODE Then
            Dim dateStr As String = DateTime.Now.AddYears(-1911).Year & Format(DateTime.Now, "MM")
            Dim SQL As String = COUNT_PURCHASEDATA_SQL
            SQL = SQL.Replace("@dateStr", dateStr)
            Dim dataReader As SqlDataReader = conDB.ExecuteSQL(SQL).ExecuteReader
            If dataReader.HasRows Then
                dataReader.Read()
                Return "P" & dateStr & Format(dataReader(0) + 1, "000")
            End If
        ElseIf intMode = EDIT_MODE Then '修改模式
            Dim SQL As String = SELECT_PURCHASENO_BY_PURCHASEID_SQL
            SQL = SQL.Replace("@editID", editID)
            Dim dataReader As SqlDataReader = conDB.ExecuteSQL(SQL).ExecuteReader
            If dataReader.HasRows Then
                dataReader.Read()
                Return dataReader(0)
            End If
        End If

        Return "Error"
    End Function
    Public Function Get_OrderTime() As Date
        Dim conDB As Connection = New Connection
        Dim SQL As String = SELECT_INSERTTIME_BY_PURCHASEDATA_SQL
        SQL = SQL.Replace("@editID", editID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(SQL).ExecuteReader
        If dataReader.HasRows Then
            dataReader.Read()
            Return dataReader(0)
        End If
        Return Nothing
    End Function
    '透過關鍵字(代號或名稱)搜尋到目標產品
    '  ->依照產品或配件分別存入prodSetArray或fittingSetArray
    Public Function Search_Prod(ByVal strName As String) As List(Of ProdData)
        Dim conDB As Connection = New Connection
        Dim dataArray As List(Of ProdData) = New List(Of ProdData)
        Dim strSql As String = SELECT_PROD_SQL
        strSql = strSql.Replace("@strName", strName)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataArray.Add(New ProdData With {.ID = dataReader("ProdPartID"), .Name = dataReader("Name"), .Supplier = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr"))})
            Loop
        End If
        conDB.Close()
        Return dataArray
    End Function
    Public Function Search_Fit(ByVal strName As String) As List(Of ProdData)
        Dim conDB As Connection = New Connection
        Dim dataArray As List(Of ProdData) = New List(Of ProdData)
        Dim strSql As String = SELECT_FIT_SQL
        strSql = strSql.Replace("@strName", strName)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataArray.Add(New ProdData With {.ID = dataReader("ProdPart2ID"), .Name = dataReader("Name"), .Supplier = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr"))})
            Loop
        End If
        conDB.Close()
        Return dataArray
    End Function
    '透過訂單ID搜尋到產品庫存
    '   ->會用到訂單ID搜尋代表目前狀態為:修改模式
    '  ↳intClass定義：
    '                 →intClass = PRODUCT : 產品搜尋
    '                 →intClass = FIT : 配件搜尋
    Public Function Search_Stock(ByVal intClass As Integer) As List(Of PurchaseData)
        Dim conDB As Connection = New Connection
        Dim dataArray As List(Of PurchaseData) = New List(Of PurchaseData)
        Dim strSql As String = SELECT_PROD_BY_PURCHAEID
        Select Case intClass
            Case PRODUCT
                strSql = SELECT_PROD_BY_PURCHAEID
            Case FIT
                strSql = SELECT_FIT_BY_PURCHASEID
        End Select
        strSql = strSql.Replace("@editID", editID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                If intClass = PRODUCT Then
                    dataArray.Add(New PurchaseData With {.PurchaseID = dataReader("PurchasePID"), .DataID = dataReader("ProdPartID"), .Name = dataReader("Name"), .Supplier = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Spicification = dataReader("Specification"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"), .Count = dataReader("Count"), .Remark = dataReader("Remark")})
                ElseIf intClass = FIT Then
                    dataArray.Add(New PurchaseData With {.PurchaseID = dataReader("PurchaseP2ID"), .DataID = dataReader("ProdPart2ID"), .Name = dataReader("Name"), .Supplier = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr")), .Spicification = dataReader("Specification"), .Width = dataReader("Width"), .Length = dataReader("Length"), .CBM = dataReader("CBM"), .Count = dataReader("Count"), .Remark = dataReader("Remark")})
                End If
            Loop
        End If
        conDB.Close()
        Return dataArray
    End Function
    '讀取所有供應商資料
    Public Function Load_SupplierData() As List(Of SupplierData)
        Dim conDB As Connection = New Connection
        Dim dataArray As List(Of SupplierData) = New List(Of SupplierData)
        Dim strSql As String = SELECT_SUPPLIERDATA_SQL
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read
                dataArray.Add(New SupplierData With {.SuID = dataReader("SuID"), .Name = If(dataReader("Abbr") = "", dataReader("Supplier"), dataReader("Abbr"))})
            Loop
        End If
        Return dataArray
    End Function
    '讀取產品的規格
    '  ↳此方法主要是顯示產品的對應類別，因此在Specification內省略紀錄SuID
    '  ↳OtherClassArray主要提供給ProdDGV內的prodClass顯示用，資料只需暫存，使用完畢即可刪除
    'Public Function Load_Specification(ByVal index As Integer, ByVal ProdPartID As Integer) As List(Of SpecificationData)
    '    Dim conDB As Connection = New Connection
    '    Dim dataArray As List(Of SpecificationData) = New List(Of SpecificationData) '產品類別陣列
    '    Dim strSql As String = SELECT_SPECIFICATION_SQL
    '    strSql = strSql.Replace("@ProdPartID", ProdPartID)
    '    Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
    '    If dataReader.HasRows Then
    '        Do While dataReader.Read
    '            dataArray.Add(New SpecificationData With {.SpecID = dataReader("SpecID"), .ClassName = dataReader("ClassName")})
    '        Loop
    '    End If
    '    Return dataArray
    'End Function
    '將設定產品或配件資料新增至資料庫
    Public Function Insert_ProdData(ByVal name As String, ByVal suID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_PRDOSET_SQL
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
    Public Function Insert_FittingData(ByVal type As Integer, ByVal name As String, ByVal suID As Integer) As Integer
        Dim conDB As Connection = New Connection
        Dim strSQL As String = INSERT_FITTING_SQL
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
    '設定進貨產品<更新>
    '將顯示的資料存入Array內
    '此方法主要修改與名稱連動的資料:包含產品ID及規格名稱
    '此方法透過複寫(override)設定寫入不同的資料:
    '   ﹂>若要新增(修改)進貨產品資料須多寫入width、length、CBM
    '   ﹂>若無上述三樣參數，則判定為是新增(修改)進貨配件資料
    '判斷: 1.若設定的index大於陣列的大小時
    '             ↳表示為新增資料
    '         ☉若設定的index小於陣列大小時
    '             ↳表示修改已存在的產品的值
    Public Sub Set_PurchasePItem(ByVal index As Integer, ByVal PurchasePID As Integer, ByVal ID As Integer, ByVal Specification As String, ByVal Width As Double, ByVal Length As Double, ByVal CBM As Double, ByVal Count As Integer, ByVal Remark As String)
        If index >= purchaseProdArray.Count Then
            purchaseProdArray.Add(New ProdDetail With {.PurchasePID = PurchasePID, .PurchaseID = editID, .ProdPartID = ID, .Count = Count, .Specification = Specification, .Width = Width, .Length = Length, .CBM = CBM, .Remark = Remark})
        Else
            Dim bufArray As ProdDetail = New ProdDetail
            'bufArray.PurchasePID = IIf(PurchasePID = Nothing, purchaseProdArray.Item(index).PurchasePID, PurchasePID)
            'bufArray.PurchaseID = IIf(editID = Nothing, purchaseProdArray.Item(index).PurchaseID, editID)
            'bufArray.ProdPartID = IIf(ID = Nothing, purchaseProdArray.Item(index).ProdPartID, ID)
            'bufArray.Count = IIf(Count = Nothing, purchaseProdArray.Item(index).Count, Count)
            'bufArray.Specification = IIf(Specification = Nothing, purchaseProdArray.Item(index).Specification, Specification)
            'bufArray.Width = IIf(Width = Nothing, purchaseProdArray.Item(index).Width, Width)
            'bufArray.Length = IIf(Length = Nothing, purchaseProdArray.Item(index).Length, Length)
            'bufArray.CBM = IIf(CBM = Nothing, purchaseProdArray.Item(index).CBM, CBM)
            'bufArray.Remark = IIf(Remark = Nothing, purchaseProdArray.Item(index).Remark, Remark)
            bufArray.PurchasePID = IIf(PurchasePID = Nothing, purchaseProdArray.Item(index).PurchasePID, PurchasePID)
            bufArray.PurchaseID = editID
            bufArray.ProdPartID = ID
            bufArray.Count = Count
            bufArray.Specification = Specification
            bufArray.Width = Width
            bufArray.Length = Length
            bufArray.CBM = CBM
            bufArray.Remark = Remark
            purchaseProdArray.Item(index) = bufArray
        End If
    End Sub
    Public Sub Set_PurchasePart2em(ByVal index As Integer, ByVal PurchaseP2ID As Integer, ByVal ID As Integer, ByVal Specification As String, ByVal Count As Integer, ByVal Remark As String, ByVal Width As Double, ByVal Length As Double, ByVal CBM As Double)
        If index >= purchaseFitArray.Count Then
            purchaseFitArray.Add(New FitDetail With {.PurchaseP2ID = PurchaseP2ID, .PurchaseID = editID, .ProdPart2ID = ID, .Count = Count, .Specification = Specification, .Width = Width, .Length = Length, .CBM = CBM, .Remark = Remark})
        Else
            Dim bufArray As FitDetail = New FitDetail
            bufArray.PurchaseP2ID = IIf(PurchaseP2ID = Nothing, purchaseFitArray.Item(index).PurchaseP2ID, PurchaseP2ID)
            bufArray.PurchaseID = editID
            bufArray.ProdPart2ID = ID
            bufArray.Count = Count
            bufArray.Specification = Specification
            bufArray.Width = Width
            bufArray.Length = Length
            bufArray.CBM = CBM
            bufArray.Remark = Remark
            purchaseFitArray.Item(index) = bufArray
        End If
    End Sub
    Public Function Update_ToDataBase(ByVal number As String, ByVal time As Date) As String
        Dim conDB As Connection = New Connection
        Dim id As Integer = Nothing '作為新增進貨資料時產生流水號暫存使用
        Dim strSql As String = Nothing
        Dim updateCaseTime As String = UPDATE_CASEDATA_SQL
        updateCaseTime = updateCaseTime.Replace("@caseID", caseID)
        If intMode = INSERT_MODE Then
            strSql = INSERT_PURCHASEDATA_SQL
            strSql = strSql.Replace("@caseID", caseID)
            strSql = strSql.Replace("@purchaseNO", number)
            strSql = strSql.Replace("@time", Format(time, "yyyy/MM/dd"))
            Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSql).ExecuteReader
            If dataReader.HasRows Then
                Do While dataReader.Read
                    id = CInt(dataReader("id"))
                Loop
            End If
        ElseIf intMode = EDIT_MODE Then
            id = editID
            strSql = UPDATE_PURCHASEDATA_BY_PURCHASEID_SQL
            strSql = strSql.Replace("@id", id)
            strSql = strSql.Replace("@time", Format(time, "yyyy/MM/dd"))
            conDB.ExecuteSQL(strSql).ExecuteNonQuery()
        End If

        If id <> Nothing Then
            For Each data As ProdDetail In purchaseProdArray
                If data.Count > 0 Then
                    If data.ProdPartID <> Nothing Then
                        If data.PurchasePID = Nothing Then
                            strSql = INSERT_PURCHASEPART_SQL
                        Else
                            strSql = UPDATE_PURCHASEPART_SQL
                        End If
                        strSql = strSql.Replace("@PID", data.PurchasePID)
                        strSql = strSql.Replace("@id", id)
                        strSql = strSql.Replace("@prodPartID", data.ProdPartID)
                        strSql = strSql.Replace("@specification", data.Specification)
                        strSql = strSql.Replace("@width", data.Width)
                        strSql = strSql.Replace("@length", data.Length)
                        strSql = strSql.Replace("@cbm", data.CBM)
                        strSql = strSql.Replace("@count", data.Count)
                        '判斷字串使否有SQL保留字，若有加一個'處理
                        Dim sRemark = data.Remark
                        If sRemark <> Nothing Then
                            sRemark = sRemark.Replace("'", "''")
                        End If
                        strSql = strSql.Replace("@remark", sRemark)
                        Dim i As Integer = conDB.ExecuteSQL(strSql).ExecuteNonQuery
                        If i <> 1 Then
                            Return "Error： insert PurchasePart that count <> 1."
                        End If
                        conDB.Close()
                    End If
                End If
            Next
            For Each data As FitDetail In purchaseFitArray
                If data.Count > 0 Then
                    If data.ProdPart2ID <> Nothing Then
                        If data.PurchaseP2ID = Nothing Then
                            strSql = INSERT_PURCHASEPART2_SQL
                        Else
                            strSql = UPDATE_PURCHASEPART2_SQL
                        End If
                        strSql = strSql.Replace("@FID", data.PurchaseP2ID)
                        strSql = strSql.Replace("@id", id)
                        strSql = strSql.Replace("@prodPart2ID", data.ProdPart2ID)
                        strSql = strSql.Replace("@specification", data.Specification)
                        strSql = strSql.Replace("@width", data.Width)
                        strSql = strSql.Replace("@length", data.Length)
                        strSql = strSql.Replace("@cbm", data.CBM)
                        strSql = strSql.Replace("@count", data.Count)
                        Dim sRemark = data.Remark
                        '判斷字串使否有SQL保留字，若有加一個'處理
                        sRemark = data.Remark
                        If sRemark <> Nothing Then
                            sRemark = sRemark.Replace("'", "''")
                        End If
                        strSql = strSql.Replace("@remark", sRemark)
                        Dim i As Integer = conDB.ExecuteSQL(strSql).ExecuteNonQuery
                        If i <> 1 Then
                            Return "Error： insert PurchasePart2 that count <> 1."
                        End If
                        conDB.Close()
                    End If
                End If
            Next
            '若處於編輯模式，則可能會有刪除的產品，將在此執行刪除
            If intMode = 1 Then
                For Each data As Integer In editRemoveProd
                    strSql = DEL_PURCHASEPART_BY_PURCHASEPID
                    strSql = strSql.Replace("@PID", data)
                    Dim i As Integer = conDB.ExecuteSQL(strSql).ExecuteNonQuery
                    If i <> 1 Then
                        Return "Error： Delete PurchasePart that count <> 1."
                    End If
                    conDB.Close()
                Next
                For Each data As Integer In editRemoveFit
                    strSql = DEL_PURCHASEPART2_BY_PURCHASEFID
                    strSql = strSql.Replace("@FID", data)
                    Dim i As Integer = conDB.ExecuteSQL(strSql).ExecuteNonQuery
                    If i <> 1 Then
                        Return "Error： Delete PurchasePart2 that count <> 1."
                    End If
                    conDB.Close()
                Next
            End If
        End If
        conDB.ExecuteSQL(updateCaseTime).ExecuteNonQuery() '時間更新
        Return Nothing
    End Function
    Public Sub Copy_Row(ByVal ID As Integer, ByVal strName As String, ByVal strSupplier As String)
        copyProd = New ProdData With {.ID = ID, .Name = strName, .Supplier = strSupplier}
    End Sub
    Public Function Paste_Row() As ProdData
        Return copyProd
    End Function
    Public Function Get_PurchasePartCount() As Integer
        Return purchaseProdArray.Count
    End Function
    Public Function Get_PurchasePart2Count() As Integer
        Return purchaseFitArray.Count
    End Function
    Public Function Get_PurchasePart(ByVal index As Integer) As ProdDetail
        Return purchaseProdArray(index)
    End Function
    Public Function Get_PurchasePart2(ByVal index As Integer) As FitDetail
        Return purchaseFitArray(index)
    End Function
    Public Sub Insert_PurchasePart(ByVal index As Integer)
        purchaseProdArray.Insert(index - 1, New ProdDetail)
    End Sub
    Public Sub Insert_PurchasePart2(ByVal index As Integer)
        purchaseFitArray.Insert(index - 1, New FitDetail)
    End Sub
    Public Sub Remove_PurchasePart(ByVal index As Integer)
        purchaseProdArray.RemoveAt(index)
    End Sub
    Public Sub Remove_PurchasePart2(ByVal index As Integer)
        purchaseFitArray.RemoveAt(index)
    End Sub
    Public Sub Add_EditRemoveProd(ByVal index As Integer)
        editRemoveProd.Add(purchaseProdArray(index).PurchasePID)
    End Sub
    Public Sub Add_EditRemoveFit(ByVal index As Integer)
        editRemoveFit.Add(purchaseFitArray(index).PurchaseP2ID)
    End Sub
    Public Function Mode() As Integer
        Return intMode
    End Function
End Class
