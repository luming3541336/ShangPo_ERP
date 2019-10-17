
Imports Microsoft.Office.Interop.Excel

Public Class Output_SaleReport_Form
    Private controller As Output_SaleReport_Controller = New Output_SaleReport_Controller
    Private userName As String = Nothing
    Private caseID As Integer = Nothing
    Private place As String = Nothing
    Private strFilter As String = Nothing
    '工程進度表
    Private listProdData As List(Of Set_WorkProgress_Model.WorkProgress) = Nothing
    Private listFitData As List(Of Set_WorkProgress_Model.WorkProgress) = Nothing
    Private listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = Nothing
    '-------------------------------------------------------------------------------
    Private bufListProdData As List(Of Set_WorkProgress_Model.WorkProgress) = Nothing
    Private bufListFitData As List(Of Set_WorkProgress_Model.WorkProgress) = Nothing
    Private bufListWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = Nothing
    Private statusForm As Status_Normal_Form
    Dim app As Application 'app 是操作 Excel 的變數
    Dim workSheet As Worksheet 'Worksheet 代表的是 Excel 工作表
    Dim workBook As Workbook 'Workbook 代表的是一個 Excel 本體
    Public Sub New(ByVal userName As String, ByVal caseID As Integer, ByVal place As String, ByVal listProdData As List(Of Set_WorkProgress_Model.WorkProgress), ByVal listFitData As List(Of Set_WorkProgress_Model.WorkProgress), ByVal listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail))
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.userName = userName
        Me.caseID = caseID
        Me.place = place
        Me.listProdData = listProdData
        Me.listFitData = listFitData
        Me.listWorkDetail = listWorkDetail
    End Sub

    Private Sub OutPutBtn_Click(sender As Object, e As EventArgs) Handles Button1.Click
        app = Nothing
        workSheet = Nothing
        workBook = Nothing
        strFilter = Nothing
        If Purchase_CheckBox.Checked Then
            strFilter += " AND PurchaseData.InsertTime >='" & StartP_DateTime.Text & "' AND PurchaseData.InsertTime <= '" & EndP_DateTime.Text & "'"
        End If
        If Sale_CheckBox.Checked Then
            strFilter += " AND A.InsertTime  >='" & StartS_DateTime.Text & "' AND A.InsertTime  <= '" & EndS_DateTime.Text & "'"
        End If
        If PIC_CheckBox.Checked Then
            strFilter += " AND PIC ='" & PICText.Text & "'"
        End If
        If UnSale_Checkbox.Checked Then
            strFilter = "-1"
        End If
        statusForm = New Status_Normal_Form("報表生產中")
        statusForm.Show()
        Print_ShipRecord() '列印出貨總表
    End Sub
    '生產出貨總表標頭資訊
    Private Sub Print_ShipRecord()
        Dim path As String = My.Application.Info.DirectoryPath
        app = New Application
        workBook = app.Workbooks.Open(path + "\Resources\出貨總表.xltx") '開啟一張已存在的 Excel 檔案
        workSheet = workBook.Worksheets(1) '門框
        workSheet.Cells(4, 2) = place ' 工地
        workSheet.Cells(4, 15) = Now '製表時間
        workSheet.Cells(5, 15) = userName '製表人
        workSheet = workBook.Worksheets(2) '門扇
        workSheet.Cells(4, 2) = place ' 工地
        workSheet.Cells(4, 15) = Now '製表時間
        workSheet.Cells(5, 15) = userName '製表人
        PrintRecordBackGround.RunWorkerAsync()
    End Sub
    '生產工程進度表標頭資訊
    Private Sub Print_WorkProgress()
        Dim path As String = My.Application.Info.DirectoryPath
        app = New Application
        workBook = app.Workbooks.Open(path + "\Resources\工程進度表.xltx") '開啟一張已存在的 Excel 檔案
        workSheet = workBook.Worksheets(1)
        Dim caseData As CaseData = controller.Load_Case_Data(caseID)
        workSheet.Cells(1, 1) = caseData.Place
        workSheet.Cells(3, 2) = caseData.Address
        workSheet.Cells(4, 2) = caseData.Phone
        workSheet.Cells(2, 11) = caseData.SalesName
        PrintWorkProgressBackGround.RunWorkerAsync()
    End Sub
    Private Sub PrintWorkProgressBackGround_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PrintWorkProgressBackGround.DoWork
        Dim index As Integer = Nothing '工作進度表表格位置設定
        '門扇內容打印
        If bufListFitData.Count > 5 Then '預設資料筆數為5筆，若大於需要增加欄位
            For i As Integer = 0 To bufListFitData.Count - 6
                workSheet.Rows(20).insert
            Next
            workSheet.Rows(18).Copy
            For i As Integer = 0 To bufListFitData.Count - 6
                workSheet.Rows(20 + i).PasteSpecial
            Next
        End If
        index = 17 '工作進度表門扇的初始位置
        For Each data As Set_WorkProgress_Model.WorkProgress In bufListFitData
            workSheet.Cells(index, 1) = data.WPDate
            workSheet.Cells(index, 2) = data.Supplier
            workSheet.Cells(index, 3) = data.ProdName
            workSheet.Cells(index, 4) = data.Specification
            workSheet.Cells(index, 8) = data.Count
            workSheet.Cells(index, 10) = data.Unit
            workSheet.Cells(index, 11) = data.Remark
            index += 1
        Next
        '門框、窗框內容打印
        If bufListProdData.Count > 5 Then '預設資料筆數為5筆，若大於需要增加欄位
            For i As Integer = 0 To bufListProdData.Count - 6
                workSheet.Rows(11).insert
            Next
            workSheet.Rows(9).Copy
            For i As Integer = 0 To bufListProdData.Count - 6
                workSheet.Rows(11 + i).PasteSpecial
            Next
        End If
        index = 8 '門框的初始位置
        For Each data As Set_WorkProgress_Model.WorkProgress In bufListProdData
            workSheet.Cells(index, 1) = data.WPDate
            workSheet.Cells(index, 2) = data.Supplier
            workSheet.Cells(index, 3) = data.ProdName
            workSheet.Cells(index, 4) = data.Specification
            workSheet.Cells(index, 8) = data.Count
            workSheet.Cells(index, 10) = data.Unit
            workSheet.Cells(index, 11) = data.Remark
            index += 1
        Next
        workSheet = workBook.Worksheets(2)
        If bufListWorkDetail.Count > 54 Then ' 產生工程進度表門框(背面)資料量超過預設欄位時新增欄位
            For i As Integer = 0 To bufListWorkDetail.Count - 55
                workSheet.Rows(20).insert
            Next
            workSheet.Rows(18).Copy
            For i As Integer = 0 To bufListWorkDetail.Count - 55
                workSheet.Rows(20 + i).PasteSpecial
            Next
        End If
        workSheet = workBook.Worksheets(2) '開始輸入工程進度表(背面)
        index = 4
        For Each data As Set_WorkDetail_Model.WorkDetail In bufListWorkDetail
            workSheet.Cells(index, 1) = data.WorkDate
            workSheet.Cells(index, 2) = data.SalesName
            workSheet.Cells(index, 3) = data.Detail
            index += 1
        Next
    End Sub
    Private Sub PrintWorkProgressBackGround_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PrintWorkProgressBackGround.RunWorkerCompleted
        app.DisplayAlerts = True
        app.Visible = True
        statusForm.Close()
    End Sub
    Private Sub PrintRecordBackGround_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PrintRecordBackGround.DoWork
        Dim arrShipRecord As List(Of Output_SaleReport_Model.ShipRecord) = New List(Of Output_SaleReport_Model.ShipRecord)
        Dim index As Integer = 10 '工作進度表表格第一欄位置
        Dim num As Integer = 0
        Dim bufID As Integer = Nothing
        For sheets As Integer = 0 To 1
            If sheets = 0 Then
                workSheet = workBook.Worksheets(1)
                If strFilter = Nothing Then
                    arrShipRecord = controller.Select_ShipRecord_Prod(caseID)
                ElseIf strFilter.Equals("-1") Then
                    arrShipRecord = controller.Select_UnSale_Prod(caseID)
                ElseIf strFilter <> Nothing Then
                    arrShipRecord = controller.Select_ShipRecord_Prod(caseID, strFilter)
                End If

            ElseIf sheets = 1 Then
                workSheet = workBook.Worksheets(2)
                If strFilter = Nothing Then
                    arrShipRecord = controller.Select_ShipRecord_Fit(caseID)
                ElseIf strFilter.Equals("-1") Then
                    arrShipRecord = controller.Select_UnSale_Fit(caseID)
                ElseIf strFilter <> Nothing Then
                    arrShipRecord = controller.Select_ShipRecord_Fit(caseID, strFilter)
                End If

            End If
            If arrShipRecord.Count > 19 Then '預設資料筆數為20筆，若大於需要增加欄位

                For i As Integer = 0 To arrShipRecord.Count - 19
                    workSheet.Rows(20).insert
                Next
                workSheet.Rows(11).Copy
                For i As Integer = 0 To arrShipRecord.Count - 19
                    workSheet.Rows(20 + i).PasteSpecial
                Next
            End If

            For i As Integer = 0 To arrShipRecord.Count - 1
                If arrShipRecord(i).PurchaseID <> bufID Then
                    num += 1
                    workSheet.Cells(index, 1) = num
                    workSheet.Cells(index, 2) = arrShipRecord(i).SupplierName
                    workSheet.Cells(index, 3) = arrShipRecord(i).ProductName
                    workSheet.Cells(index, 5) = arrShipRecord(i).Specification
                    If arrShipRecord(i).Width = 0 And arrShipRecord(i).Length = 0 Then
                        workSheet.Range("F" & index & ":" & "H" & index).MergeCells = True
                        workSheet.Cells(index, 6) = "共"
                    Else
                        workSheet.Cells(index, 6) = arrShipRecord(i).Width
                        workSheet.Cells(index, 7) = arrShipRecord(i).Length
                        workSheet.Cells(index, 8) = arrShipRecord(i).CBM
                    End If
                    workSheet.Cells(index, 9) = arrShipRecord(i).PurchaseTime
                    workSheet.Cells(index, 10) = arrShipRecord(i).PurchaseCount
                    workSheet.Cells(index, 15) = arrShipRecord(i).Remark
                    bufID = arrShipRecord(i).PurchaseID
                End If
                workSheet.Cells(index, 11) = arrShipRecord(i).SaleTime
                workSheet.Cells(index, 12) = arrShipRecord(i).SaleCount
                workSheet.Cells(index, 13) = arrShipRecord(i).PIC
                index += 1
            Next
            index = 10
            num = 0
            bufID = Nothing
            arrShipRecord.Clear()
        Next

    End Sub

    Private Sub PrintWorkReordBackGround_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PrintRecordBackGround.RunWorkerCompleted
        app.DisplayAlerts = True
        app.Visible = True
        statusForm.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        app = Nothing
        workSheet = Nothing
        workBook = Nothing
        statusForm = New Status_Normal_Form("報表生產中")
        statusForm.Show()
        bufListProdData = listProdData.ToList
        bufListFitData = listFitData.ToList
        bufListWorkDetail = listWorkDetail.ToList
        If Purchase_CheckBox2.Checked Then
            For i As Integer = bufListProdData.Count - 1 To 0 Step -1
                If bufListProdData(i).WPDate < StartP2_DateTime.Text Or bufListProdData(i).WPDate > EndP2_DateTime.Text Then
                    bufListProdData.RemoveAt(i)
                End If
            Next
            For i As Integer = bufListFitData.Count - 1 To 0 Step -1
                If bufListFitData(i).WPDate < StartP2_DateTime.Text Or bufListFitData(i).WPDate > EndP2_DateTime.Text Then
                    bufListFitData.RemoveAt(i)
                End If
            Next
            For i As Integer = bufListWorkDetail.Count - 1 To 0 Step -1
                If bufListWorkDetail(i).WorkDate < StartP2_DateTime.Text Or bufListWorkDetail(i).WorkDate > EndP2_DateTime.Text Then
                    bufListWorkDetail.RemoveAt(i)
                End If
            Next
        End If
        Print_WorkProgress()

    End Sub

End Class