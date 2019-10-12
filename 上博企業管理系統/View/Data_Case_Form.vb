

Public Class Data_Case_Form
    Dim controller As Data_Case_Controller = New Data_Case_Controller
    Dim controller_SaleReport As Output_SaleReport_Controller = New Output_SaleReport_Controller
    Dim formStatusNormal As Status_Normal_Form = New Status_Normal_Form("載入中，請稍後")
    Dim formStatusProcessBar As Status_ProcessBar_Form
    Dim strSearchSQL As String = Nothing
    Dim app As Microsoft.Office.Interop.Excel.Application 'app 是操作 Excel 的變數
    Dim workSheet As Microsoft.Office.Interop.Excel.Worksheet 'Worksheet 代表的是 Excel 工作表
    Dim workBook As Microsoft.Office.Interop.Excel.Workbook 'Workbook 代表的是一個 Excel 本體
    Dim listPurchasePart As List(Of Data_Case_Model.PurchasePart) = Nothing
    Dim listPurchasePart2 As List(Of Data_Case_Model.PurchasePart2) = Nothing
    'Dim listShipmentPart As List(Of Data_Case_Model.ShipmentPart) = Nothing
    'Dim listShipmentPart2 As List(Of Data_Case_Model.ShipmentPart2) = Nothing
    Private Sub LoadingBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingBackground.DoWork
        Dim arrayList As List(Of Data_Case_Model.CaseData) = New List(Of Data_Case_Model.CaseData)
        If strSearchSQL = Nothing Then
            arrayList = controller.Select_CaseData(Data_Case_Model.UNSUCCESS_STATE)
        Else
            arrayList = controller.Select_CaseData(strSearchSQL)
        End If
        e.Result = arrayList
    End Sub
    Private Sub LoadingBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingBackground.RunWorkerCompleted
        Dim arrayList As List(Of Data_Case_Model.CaseData) = e.Result
        For Each item As Data_Case_Model.CaseData In arrayList
            Dim strState As String = ""
            Select Case item.State
                Case 0
                    strState = "未結案"
                Case 1
                    strState = "已結案"
                Case 2
                    strState = "作廢"
            End Select
            CaseDGV.Rows.Add(item.CaseID, item.CaseNo, item.Place, item.SalesName, item.InsertTime, item.UpdateTime, strState)
            Select Case item.State
                Case 1
                    CaseDGV.Rows(CaseDGV.Rows.Count - 1).Cells("Success").Style.ForeColor = Color.Green
                Case 2
                    CaseDGV.Rows(CaseDGV.Rows.Count - 1).Cells("Success").Style.ForeColor = Color.Red
            End Select
        Next
        formStatusNormal.Hide()
    End Sub
    Private Sub Data_Case_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadingBackground.RunWorkerAsync()
        formStatusNormal.Show()
    End Sub

    Private Sub LoadingDetailBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingDetailBackground.DoWork

        e.Result = {controller.Select_PurchasePart(e.Argument), controller.Select_PurchasePart2(e.Argument), controller.Select_ShipmentPart(e.Argument), controller.Select_ShipmentPart2(e.Argument), controller.Get_PurchaseCase_Count(e.Argument), controller.Get_SaleCase_Count(e.Argument), controller.Select_WorkDetail(e.Argument), controller.Select_WorkProgress(e.Argument)}
    End Sub

    Private Sub LoadingDetailBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingDetailBackground.RunWorkerCompleted
        listPurchasePart = e.Result(0)
        listPurchasePart2 = e.Result(1)
        'listShipmentPart = e.Result(2)
        'listShipmentPart2 = e.Result(3)
        Dim listShipmentPart As List(Of Data_Case_Model.ShipmentPart) = e.Result(2)
        Dim listShipmentPart2 As List(Of Data_Case_Model.ShipmentPart2) = e.Result(3)
        Dim intPurchaseCount As Integer = e.Result(4)
        Dim intSaleCount As Integer = e.Result(5)
        Dim listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = e.Result(6)
        Dim listWorkProgress As List(Of Set_WorkProgress_Model.WorkProgress) = e.Result(7)
        PurchasePartDGV.Rows.Clear()
        For Each data As Data_Case_Model.PurchasePart In listPurchasePart '取得PurchasePart並放入purchaseProdDGV內
            PurchasePartDGV.Rows.Add(data.PurchasePID, data.InsertTime, data.Supplier, data.ProdName, data.Specification, data.Width, data.Length, data.CBM, data.Count, data.Remark)
        Next
        PurchasePart2DGV.Rows.Clear()
        For Each data As Data_Case_Model.PurchasePart2 In listPurchasePart2 '取得PurchasePart2並放入purchaseFitDGV內
            PurchasePart2DGV.Rows.Add(data.PurchaseP2ID, data.InsertTime, data.Supplier, data.FitName, data.Specification, data.Width, data.Length, data.Count, data.Remark)
        Next
        ShipmentPartDGV.Rows.Clear()
        For Each data As Data_Case_Model.ShipmentPart In listShipmentPart '取得ShipmentPart並放入ShipmentPartDGV內
            ShipmentPartDGV.Rows.Add(data.ShipmentPID, data.InsertTime, data.Supplier, data.ProdName, data.Specification, data.Width, data.Length, data.CBM, data.Count, data.PIC, data.Remark)
        Next
        ShipmentPart2DGV.Rows.Clear()
        For Each data As Data_Case_Model.ShipmentPart2 In listShipmentPart2 '取得PurchasePart2並放入ShipmentPart2DGV內
            ShipmentPart2DGV.Rows.Add(data.ShipmentP2ID, data.InsertTime, data.Supplier, data.FitName, data.Specification, data.Width, data.Length, data.Count, data.PIC, data.Remark)
        Next
        DetailDGV.Rows.Clear()
        For Each data As Set_WorkDetail_Model.WorkDetail In listWorkDetail
            DetailDGV.Rows.Add(data.WDID, Format(data.WorkDate, "yyyy/MM/dd"), data.SalesName, data.Detail)
        Next
        WorkProgressDGV.Rows.Clear()
        For Each data As Set_WorkProgress_Model.WorkProgress In listWorkProgress
            WorkProgressDGV.Rows.Add(data.WPID, If(data.WPClass = 0, "門框、窗框", "門扇"), Format(data.WPDate, "yyyy/MM/dd"), data.Supplier, data.ProdName, data.Specification, data.Count, data.Unit, data.Remark)
        Next
        PurchaseCountLabel.Text = intPurchaseCount
        SaleCountLabel.Text = intSaleCount
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim formDataSearch As Data_Search_Form = New Data_Search_Form
        If formDataSearch.ShowDialog = DialogResult.OK Then
            strSearchSQL = formDataSearch.strSQL
            CaseDGV.Rows.Clear()
            LoadingBackground.RunWorkerAsync()
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        RefreshCaseData()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim formSetCase As Set_Case_Form = New Set_Case_Form(UserName)
        If formSetCase.ShowDialog = DialogResult.OK Then
            RefreshCaseData()
        End If
    End Sub
    Private Sub RefreshCaseData()
        CaseDGV.Rows.Clear()
        If Not LoadingBackground.IsBusy Then
            LoadingBackground.RunWorkerAsync()
        End If
    End Sub

    Private Sub Data_Case_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt And e.KeyCode = 49 Then ' Alt+1
            MainTabControl.SelectedIndex = 0
        ElseIf e.Alt And e.KeyCode = 50 Then ' Alt+2
            MainTabControl.SelectedIndex = 1
        ElseIf e.Alt And e.KeyCode = 51 Then ' Alt+3
            MainTabControl.SelectedIndex = 2
        ElseIf e.Alt And e.KeyCode = 52 Then ' Alt+4
            MainTabControl.SelectedIndex = 3
        End If
        If e.Alt And e.KeyCode = 81 Then ' Alt+Q
            If MainTabControl.SelectedIndex = 0 Then
                TabControl1.SelectedIndex = 0
            ElseIf MainTabControl.SelectedIndex = 1 Then
                TabControl2.SelectedIndex = 0
            End If
        End If
        If e.Alt And e.KeyCode = 87 Then ' Alt+W
            If MainTabControl.SelectedIndex = 0 Then
                TabControl1.SelectedIndex = 1
            ElseIf MainTabControl.SelectedIndex = 1 Then
                TabControl2.SelectedIndex = 1
            End If
        End If
    End Sub

    Private Sub caseDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CaseDGV.CellDoubleClick
        Dim formSetCase As Set_Case_Form = New Set_Case_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, 2) 'Mode = 2 預覽按鍵
        formSetCase.ShowDialog()
    End Sub

    Private Sub ConpleteBtn_Click(sender As Object, e As EventArgs) Handles ConpleteBtn.Click
        Dim listUnsaleProd As List(Of Data_Case_Model.UnsaleProd) = controller.Select_UnShipmentPart(CaseDGV.CurrentRow.Cells("CaseID").Value)
        Dim listUnsaleFit As List(Of Data_Case_Model.UnsaleFit) = controller.Select_UnShipmentPart2(CaseDGV.CurrentRow.Cells("CaseID").Value)
        If CaseDGV.CurrentRow.Cells("Success").Value = "作廢" Then
            MsgBox("此案件已作廢，無法結案。")
        ElseIf CaseDGV.CurrentRow.Cells("Success").Value = "已結案" Then
            If MsgBox("您要取消結案嗎?取消結案會影響保固期的計算(會依照結案的日期計算)", vbYesNo, "警告") = MsgBoxResult.Yes Then
                If controller.Update_Case_CancelComplete(CaseDGV.CurrentRow.Cells("CaseID").Value) = 1 Then
                    MsgBox("操作成功")
                Else
                    MsgBox("操作未成功，請在試一次或告知系統管理員")
                End If
                RefreshCaseData()
            End If
        Else
            Dim msgResult As MsgBoxResult
            If listUnsaleProd.Count = 0 And listUnsaleFit.Count = 0 Then
                msgResult = MsgBox("此案件確定結案了嗎?結案後將無法變更及修改", MsgBoxStyle.OkCancel, "警告")
            Else '尚有貨物未出貨
                Dim strShowDetail As String = Nothing
                strShowDetail = "您上有進貨物品未出貨，您確定要結案了嗎?結案後無法變更與修改" & vbCrLf
                If listUnsaleProd.Count > 0 Then
                    strShowDetail += "-------------------------------------------------------------------------------" & vbCrLf
                    strShowDetail += "以下為未出貨的門框/窗框資訊:" & vbCrLf
                    strShowDetail += "--------------------------------------------------------------------------------" & vbCrLf
                    For Each data As Data_Case_Model.UnsaleProd In listUnsaleProd
                        strShowDetail += data.ProdName & "(規格:" & data.Specification & "寬:" & data.Width & "高:" & data.Length & ")剩餘" & data.RemainAmount & "件" & vbCrLf
                    Next
                End If
                If listUnsaleFit.Count > 0 Then
                    strShowDetail += "-------------------------------------------------------------------------------" & vbCrLf
                    strShowDetail += "以下為未出貨門扇資訊:" & vbCrLf
                    strShowDetail += "-------------------------------------------------------------------------------" & vbCrLf
                    For Each data As Data_Case_Model.UnsaleFit In listUnsaleFit
                        strShowDetail += data.FitName & "(規格:" & data.Specification & "寬:" & data.Width & "高:" & data.Length & ")剩餘" & data.RemainAmount & "件" & vbCrLf
                    Next
                End If
                msgResult = MsgBox(strShowDetail, MsgBoxStyle.OkCancel, "警告")
            End If
            If msgResult = MsgBoxResult.Ok Then
                If controller.Update_Case_Complete(CaseDGV.CurrentRow.Cells("CaseID").Value) = 1 Then
                    MsgBox("已成功結案")
                Else
                    MsgBox("結案未成功，請在試一次或告知系統管理員")
                End If
                RefreshCaseData()
            End If
        End If
    End Sub

    Private Sub caseDGV_SelectionChanged(sender As Object, e As EventArgs) Handles CaseDGV.SelectionChanged
        If CaseDGV.CurrentRow IsNot Nothing Then
            'PurchasePartDGV.Rows.Clear()
            'PurchasePart2DGV.Rows.Clear()
            'ShipmentPartDGV.Rows.Clear()
            'ShipmentPart2DGV.Rows.Clear()
            'DetailDGV.Rows.Clear()
            'WorkProgressDGV.Rows.Clear()
            AddDetailBtn.Enabled = True
            ReviseDetailBtn.Enabled = False
            DelDetailBtn.Enabled = False
            AddWPBtn.Enabled = True
            ReviseWPBtn.Enabled = False
            DelWPBtn.Enabled = False
            Do While LoadingDetailBackground.IsBusy
                Application.DoEvents()
            Loop
            If CaseDGV.CurrentRow.Cells("Success").Value = "已結案" Then
                ConpleteBtn.Text = "取消結案"
                ConpleteBtn.BackColor = Color.Red
                ConpleteBtn.Width = 115
                ConpleteBtn.Enabled = True
            ElseIf CaseDGV.CurrentRow.Cells("Success").Value = "未結案" Then
                ConpleteBtn.Text = "結案&C"
                ConpleteBtn.BackColor = Color.SlateGray
                ConpleteBtn.Width = 90
                ConpleteBtn.Enabled = True
            Else
                ConpleteBtn.Enabled = False
            End If
            LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
        End If
    End Sub

    Private Sub ReviseBtn_Click(sender As Object, e As EventArgs) Handles ReviseBtn.Click
        If CaseDGV.CurrentRow.Cells("Success").Value = "已結案" Then
            MsgBox("此案件已結案，無法修改資料。")
        Else
            Dim formSetCase As Set_Case_Form = New Set_Case_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, 1) 'Mode = 1 編輯按鍵
            formSetCase.ShowDialog()
        End If
    End Sub

    Private Sub VoidBtn_Click(sender As Object, e As EventArgs) Handles VoidBtn.Click
        If CaseDGV.CurrentRow.Cells("Success").Value = "已結案" Then
            MsgBox("此案件已結案，無法作廢。")
        Else
            If MsgBox("是否要將此案件作廢?", vbOKCancel, "警告") = MsgBoxResult.Ok Then
                If controller.Update_Case_Void(CaseDGV.CurrentRow.Cells("CaseID").Value) = 1 Then
                    MsgBox("已作廢案件")
                Else
                    MsgBox("作廢未成功，請在試一次或告知系統管理員")
                End If
                RefreshCaseData()
            End If
        End If

    End Sub

    Private Sub purchaseProdDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchasePartDGV.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim toViewOrderForm As Data_Order_Form = New Data_Order_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, 0, controller.Get_PurchaseID_For_Prod(PurchasePartDGV.CurrentRow.Cells("PurchasePID").Value), CaseDGV.CurrentRow.Cells("place").Value) '查詢進貨資料
            If toViewOrderForm.ShowDialog = DialogResult.OK Then
                LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
            End If
        End If
    End Sub

    Private Sub purchaseFitDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchasePart2DGV.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim toViewOrderForm As Data_Order_Form = New Data_Order_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, 0, controller.Get_PurchaseID_For_Fit(PurchasePart2DGV.CurrentRow.Cells("PurchaseP2ID").Value), CaseDGV.CurrentRow.Cells("place").Value) '查詢進貨資料
            If toViewOrderForm.ShowDialog = DialogResult.OK Then
                LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
            End If
        End If
    End Sub

    Private Sub saleProdDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShipmentPartDGV.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim toViewOrderForm As Data_Order_Form = New Data_Order_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, 1, controller.Get_ShipmentID_For_Prod(ShipmentPartDGV.CurrentRow.Cells("ShipmentPID").Value), CaseDGV.CurrentRow.Cells("place").Value) '查詢進貨資料
            If toViewOrderForm.ShowDialog = DialogResult.OK Then
                LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
            End If
        End If
    End Sub

    Private Sub saleFitDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShipmentPart2DGV.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim toViewOrderForm As Data_Order_Form = New Data_Order_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, 1, controller.Get_ShipmentID_For_Fit(ShipmentPart2DGV.CurrentRow.Cells("ShipmentP2ID").Value), CaseDGV.CurrentRow.Cells("place").Value) '查詢進貨資料
            If toViewOrderForm.ShowDialog = DialogResult.OK Then
                LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
            End If
        End If
    End Sub

    Private Sub addPurchaseButton_Click(sender As Object, e As EventArgs) Handles addPurchaseButton.Click
        Dim toAddSaleForm As Set_Purchase_Form = New Set_Purchase_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, CaseDGV.CurrentRow.Cells("place").Value)
        If toAddSaleForm.ShowDialog = DialogResult.OK Then
            LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
        End If
    End Sub

    Private Sub addSaleButton_Click(sender As Object, e As EventArgs) Handles addSaleButton.Click
        Dim toAddSaleForm As Set_Sale_Form = New Set_Sale_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, CaseDGV.CurrentRow.Cells("place").Value)
        If toAddSaleForm.ShowDialog = DialogResult.OK Then
            LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
        End If
    End Sub

    Private Sub ReviseDetailBtn_Click(sender As Object, e As EventArgs) Handles ReviseDetailBtn.Click
        Dim workDetailForm As Set_WorkDetail_Form = New Set_WorkDetail_Form(DetailDGV.CurrentRow.Cells("WDID").Value, Set_WorkDetail_Model.EDIT_MODE)
        If workDetailForm.ShowDialog = DialogResult.OK Then
            DetailDGV.Rows.Clear()
            Dim listData As List(Of Set_WorkDetail_Model.WorkDetail) = controller.Select_WorkDetail(CaseDGV.CurrentRow.Cells("CaseID").Value)
            For Each data As Set_WorkDetail_Model.WorkDetail In listData
                DetailDGV.Rows.Add(data.WDID, Format(data.WorkDate, "yyyy/MM/dd"), data.SalesName, data.Detail)
            Next
        End If
    End Sub

    Private Sub DelDetailBtn_Click(sender As Object, e As EventArgs) Handles DelDetailBtn.Click
        If DetailDGV.CurrentRow IsNot Nothing Then
            Dim msgResult As MsgBoxResult = MsgBox("請問確認要刪除案件嗎?刪除後將無法恢復", MsgBoxStyle.OkCancel, "注意")
            Select Case msgResult
                Case MsgBoxResult.Ok
                    Dim intResult As Integer = controller.DEL_WorkDetail(DetailDGV.CurrentRow.Cells("WDID").Value)
                    DetailDGV.Rows.RemoveAt(DetailDGV.SelectedRows(0).Index)
                    If intResult = 1 Then
                        MsgBox("刪除完成")
                    Else
                        MsgBox("刪除錯誤，請通知工程師: 刪除數:" & intResult)
                    End If
            End Select
        Else
            MsgBox("請先選擇刪除項目", MsgBoxStyle.OkOnly, "錯誤")
        End If

    End Sub

    Private Sub DetailDGV_SelectionChanged(sender As Object, e As EventArgs) Handles DetailDGV.SelectionChanged
        AddDetailBtn.Enabled = True
        ReviseDetailBtn.Enabled = True
        DelDetailBtn.Enabled = True
    End Sub

    Private Sub AddDetailBtn_Click(sender As Object, e As EventArgs) Handles AddDetailBtn.Click
        Dim workDetailForm As Set_WorkDetail_Form = New Set_WorkDetail_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, Set_WorkDetail_Model.INSERT_MODE)
        If workDetailForm.ShowDialog = DialogResult.OK Then
            LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
        End If
    End Sub
    '生產出貨總表標頭資訊
    Private Sub Print_ShippingRecord()
        Dim path As String = My.Application.Info.DirectoryPath
        app = New Microsoft.Office.Interop.Excel.Application
        workBook = app.Workbooks.Open(path + "\Resources\出貨總表.xltx") '開啟一張已存在的 Excel 檔案
        workSheet = workBook.Worksheets(1) '門框
        workSheet.Cells(4, 2) = CaseDGV.CurrentRow.Cells("place").Value ' 工地
        workSheet.Cells(4, 15) = Now '製表時間
        workSheet.Cells(5, 15) = UserName '製表人
        workSheet = workBook.Worksheets(2) '門扇
        workSheet.Cells(4, 2) = CaseDGV.CurrentRow.Cells("place").Value ' 工地
        workSheet.Cells(4, 15) = Now '製表時間
        workSheet.Cells(5, 15) = UserName '製表人
        PrintShippingRecordBackground.RunWorkerAsync()
    End Sub
    Private Sub PrintShippingRecordBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PrintShippingRecordBackground.DoWork
        Dim index As Integer = 10 '工作進度表表格第一欄位置
        Dim listShipmentPart As List(Of Output_SaleReport_Model.ShipmentPart)
        Dim listShipmentPart2 As List(Of Output_SaleReport_Model.ShipmentPart2)
        workSheet = workBook.Worksheets(1)
        If listPurchasePart.Count > 19 Then '預設資料筆數為20筆，若大於需要增加欄位

            For i As Integer = 0 To listPurchasePart.Count - 19
                workSheet.Rows(20).insert
            Next
            workSheet.Rows(11).Copy
            For i As Integer = 0 To listPurchasePart.Count - 19
                workSheet.Rows(20 + i).PasteSpecial
            Next
        End If
        For i As Integer = 0 To listPurchasePart.Count - 1
            listShipmentPart = controller_SaleReport.Load_Sale_Prod_From_PID(listPurchasePart(i).PurchasePID)
            If listShipmentPart.Count > 1 Then '出貨次數大於1筆時，若大於需要增加欄位
                For i2 As Integer = 1 To listShipmentPart.Count - 1
                    workSheet.Rows(index + 2).insert
                Next
                workSheet.Rows(index + 1).Copy
                For i2 As Integer = 1 To listShipmentPart.Count - 1
                    workSheet.Rows(index + i2 + 1).PasteSpecial
                Next
            End If
            workSheet.Cells(index, 1) = i + 1
            workSheet.Cells(index, 2) = listPurchasePart(i).Supplier
            workSheet.Cells(index, 3) = listPurchasePart(i).ProdName
            workSheet.Cells(index, 5) = listPurchasePart(i).Specification
            If listPurchasePart(i).Width = 0 And listPurchasePart(i).Length = 0 Then
                workSheet.Range("F" & index & ":" & "H" & index).MergeCells = True
                workSheet.Cells(index, 6) = "共"
            Else
                workSheet.Cells(index, 6) = listPurchasePart(i).Width
                workSheet.Cells(index, 7) = listPurchasePart(i).Length
                workSheet.Cells(index, 8) = listPurchasePart(i).CBM
            End If
            workSheet.Cells(index, 9) = listPurchasePart(i).InsertTime
            workSheet.Cells(index, 10) = listPurchasePart(i).Count
            workSheet.Cells(index, 15) = listPurchasePart(i).Remark

            If listShipmentPart.Count <> 0 Then
                For Each data As Output_SaleReport_Model.ShipmentPart In listShipmentPart
                    workSheet.Cells(index, 11) = data.InsertTime
                    workSheet.Cells(index, 12) = data.Count
                    workSheet.Cells(index, 13) = data.PIC
                    index += 1
                Next
            Else
                index += 1
            End If
            PrintShippingRecordBackground.ReportProgress(i)
        Next
        index = 10
        workSheet = workBook.Worksheets(2)
        If listPurchasePart2.Count > 19 Then '預設資料筆數為20筆，若大於需要增加欄位
            For i As Integer = 0 To listPurchasePart2.Count - 19
                workSheet.Rows(20).insert
            Next
            workSheet.Rows(11).Copy
            For i As Integer = 0 To listPurchasePart2.Count - 19
                workSheet.Rows(20).PasteSpecial
            Next
        End If

        For i As Integer = 0 To listPurchasePart2.Count - 1
            listShipmentPart2 = controller_SaleReport.Load_Sale_Fit_From_FID(listPurchasePart2(i).PurchaseP2ID)
            If listShipmentPart2.Count > 1 Then '出貨次數大於1筆時，若大於需要增加欄位
                For i2 As Integer = 1 To listShipmentPart2.Count
                    workSheet.Rows(index + 2).insert
                Next
                workSheet.Rows(index + 1).Copy
                For i2 As Integer = 1 To listShipmentPart2.Count
                    workSheet.Rows(index + i2 + 1).PasteSpecial
                Next
            End If
            workSheet.Cells(index, 1) = i + 1
            workSheet.Cells(index, 2) = listPurchasePart2(i).Supplier
            workSheet.Cells(index, 3) = listPurchasePart2(i).FitName
            workSheet.Cells(index, 5) = listPurchasePart2(i).Specification
            If listPurchasePart2(i).Width = 0 And listPurchasePart2(i).Length = 0 Then
                workSheet.Range("F" & index & ":" & "H" & index).MergeCells = True
                workSheet.Cells(index, 6) = "共"
            Else
                workSheet.Cells(index, 6) = listPurchasePart2(i).Width
                workSheet.Cells(index, 7) = listPurchasePart2(i).Length
            End If

            workSheet.Cells(index, 9) = listPurchasePart2(i).InsertTime
            workSheet.Cells(index, 10) = listPurchasePart2(i).Count
            workSheet.Cells(index, 15) = listPurchasePart2(i).Remark
            If listShipmentPart2.Count <> 0 Then
                For Each data As Output_SaleReport_Model.ShipmentPart2 In listShipmentPart2
                    workSheet.Cells(index, 11) = data.InsertTime
                    workSheet.Cells(index, 12) = data.Count
                    workSheet.Cells(index, 13) = data.PIC
                    index += 1
                Next
            Else
                index += 1
            End If
            PrintShippingRecordBackground.ReportProgress(i)
        Next
    End Sub

    Private Sub PrintShippingRecordBackground_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles PrintShippingRecordBackground.ProgressChanged
        formStatusProcessBar.addProcess()
    End Sub

    Private Sub PrintShippingRecordBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PrintShippingRecordBackground.RunWorkerCompleted
        app.DisplayAlerts = True
        app.Visible = True
        formStatusProcessBar.Close()
    End Sub

    Private Sub PrintShippingRecordItem_Click(sender As Object, e As EventArgs) Handles PrintShippingRecordItem.Click
        formStatusProcessBar = New Status_ProcessBar_Form("報表生產中....請稍後", listPurchasePart.Count + listPurchasePart2.Count)
        formStatusProcessBar.Show()
        Print_ShippingRecord() '列印出貨總表
    End Sub

    Private Sub AddWPBtn_Click(sender As Object, e As EventArgs) Handles AddWPBtn.Click
        Dim workProgressForm As Set_WorkProgress_Form = New Set_WorkProgress_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, Set_WorkProgress_Model.INSERT_MODE)
        If workProgressForm.ShowDialog = DialogResult.OK Then
            LoadingDetailBackground.RunWorkerAsync(CaseDGV.CurrentRow.Cells("CaseID").Value)
        End If
    End Sub

    Private Sub ReviseWPBtn_Click(sender As Object, e As EventArgs) Handles ReviseWPBtn.Click
        Dim workProgressForm As Set_WorkProgress_Form = New Set_WorkProgress_Form(WorkProgressDGV.CurrentRow.Cells("WPID").Value, Set_WorkDetail_Model.EDIT_MODE)
        If workProgressForm.ShowDialog = DialogResult.OK Then
            WorkProgressDGV.Rows.Clear()
            Dim listData As List(Of Set_WorkProgress_Model.WorkProgress) = controller.Select_WorkProgress(CaseDGV.CurrentRow.Cells("CaseID").Value)
            For Each data As Set_WorkProgress_Model.WorkProgress In listData
                WorkProgressDGV.Rows.Add(data.WPID, If(data.WPClass = 0, "門框、窗框", "門扇"), Format(data.WPDate, "yyyy/MM/dd"), data.Supplier, data.ProdName, data.Specification, data.Count, data.Unit, data.Remark)
            Next
        End If
    End Sub

    Private Sub WorkProgressDGV_SelectionChanged(sender As Object, e As EventArgs) Handles WorkProgressDGV.SelectionChanged
        AddWPBtn.Enabled = True
        ReviseWPBtn.Enabled = True
        DelWPBtn.Enabled = True
    End Sub

    Private Sub DelWPBtn_Click(sender As Object, e As EventArgs) Handles DelWPBtn.Click
        If WorkProgressDGV.CurrentRow IsNot Nothing Then
            Dim msgResult As MsgBoxResult = MsgBox("請問確認要刪除嗎?刪除後將無法恢復", MsgBoxStyle.OkCancel, "注意")
            Select Case msgResult
                Case MsgBoxResult.Ok
                    Dim intResult As Integer = controller.DEL_WorkProgress(WorkProgressDGV.CurrentRow.Cells("WPID").Value)
                    WorkProgressDGV.Rows.RemoveAt(WorkProgressDGV.SelectedRows(0).Index)
                    If intResult = 1 Then
                        MsgBox("刪除完成")
                    Else
                        MsgBox("刪除錯誤，請通知工程師: 刪除數:" & intResult)
                    End If
            End Select
        Else
            MsgBox("請先選擇刪除項目", MsgBoxStyle.OkOnly, "錯誤")
        End If
    End Sub
    Private Sub Print_WorkProgress()
        Dim listProdData As List(Of Set_WorkProgress_Model.WorkProgress) = New List(Of Set_WorkProgress_Model.WorkProgress)
        Dim listFitData As List(Of Set_WorkProgress_Model.WorkProgress) = New List(Of Set_WorkProgress_Model.WorkProgress)
        For Each rowData As DataGridViewRow In WorkProgressDGV.Rows
            If rowData.Cells("WPClass").Value = "門框、窗框" Then
                listProdData.Add(New Set_WorkProgress_Model.WorkProgress With {.WPDate = rowData.Cells("WPDate").Value, .Supplier = rowData.Cells("WPSupplier").Value, .ProdName = rowData.Cells("WPPartName").Value, .Specification = rowData.Cells("WPSpecification").Value, .Count = rowData.Cells("WPCount").Value, .Unit = rowData.Cells("WPUnit").Value, .Remark = rowData.Cells("WPRemark").Value})
            Else
                listFitData.Add(New Set_WorkProgress_Model.WorkProgress With {.WPDate = rowData.Cells("WPDate").Value, .Supplier = rowData.Cells("WPSupplier").Value, .ProdName = rowData.Cells("WPPartName").Value, .Specification = rowData.Cells("WPSpecification").Value, .Count = rowData.Cells("WPCount").Value, .Unit = rowData.Cells("WPUnit").Value, .Remark = rowData.Cells("WPRemark").Value})
            End If
        Next
        Dim listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = New List(Of Set_WorkDetail_Model.WorkDetail)
        For Each rowData As DataGridViewRow In DetailDGV.Rows
            listWorkDetail.Add(New Set_WorkDetail_Model.WorkDetail With {.WorkDate = rowData.Cells("WorkDate").Value, .SalesName = rowData.Cells("WorkPerson").Value, .Detail = rowData.Cells("WorkDetail").Value})
        Next
        Dim path As String = My.Application.Info.DirectoryPath
        'controller_SaleReport.Load_Case_Data()
        app = New Microsoft.Office.Interop.Excel.Application
        workBook = app.Workbooks.Open(path + "\Resources\工程進度表.xltx") '開啟一張已存在的 Excel 檔案
        workSheet = workBook.Worksheets(1)
        workSheet.Cells(1, 1) = CaseDGV.CurrentRow.Cells("place").Value
        workSheet.Cells(3, 2) = controller_SaleReport.CaseList(controller_SaleReport.Search_CaseID_Index(CaseDGV.CurrentRow.Cells("CaseID").Value)).Address
        workSheet.Cells(4, 2) = controller_SaleReport.CaseList(controller_SaleReport.Search_CaseID_Index(CaseDGV.CurrentRow.Cells("CaseID").Value)).Phone
        workSheet.Cells(2, 11) = controller_SaleReport.CaseList(controller_SaleReport.Search_CaseID_Index(CaseDGV.CurrentRow.Cells("CaseID").Value)).SalesName
        formStatusProcessBar = New Status_ProcessBar_Form("報表生產中....請稍後", listProdData.Count + listFitData.Count + listWorkDetail.Count)
        formStatusProcessBar.Show()
        PrintWorkProgressWork.RunWorkerAsync({listProdData, listFitData, listWorkDetail})
    End Sub
    Private Sub PrintWorkProgressWork_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PrintWorkProgressWork.DoWork
        Dim index As Integer = Nothing '工作進度表表格位置設定
        Dim listProdData As List(Of Set_WorkProgress_Model.WorkProgress) = e.Argument(0)
        Dim listFitData As List(Of Set_WorkProgress_Model.WorkProgress) = e.Argument(1)
        Dim listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = e.Argument(2)
        '門扇內容打印
        If listFitData.Count > 5 Then '預設資料筆數為5筆，若大於需要增加欄位
            For i As Integer = 0 To listFitData.Count - 6
                workSheet.Rows(20).insert
            Next
            workSheet.Rows(18).Copy
            For i As Integer = 0 To listFitData.Count - 6
                workSheet.Rows(20 + i).PasteSpecial
            Next
        End If
        index = 17 '工作進度表門扇的初始位置
        For Each data As Set_WorkProgress_Model.WorkProgress In listFitData
            workSheet.Cells(index, 1) = data.WPDate
            workSheet.Cells(index, 2) = data.Supplier
            workSheet.Cells(index, 3) = data.ProdName
            workSheet.Cells(index, 4) = data.Specification
            workSheet.Cells(index, 8) = data.Count
            workSheet.Cells(index, 10) = data.Unit
            workSheet.Cells(index, 11) = data.Remark
            PrintWorkProgressWork.ReportProgress(index)
            index += 1
        Next
        '門框、窗框內容打印
        If listProdData.Count > 5 Then '預設資料筆數為5筆，若大於需要增加欄位
            For i As Integer = 0 To listProdData.Count - 6
                workSheet.Rows(11).insert
            Next
            workSheet.Rows(9).Copy
            For i As Integer = 0 To listProdData.Count - 6
                workSheet.Rows(11 + i).PasteSpecial
            Next
        End If
        index = 8 '門框的初始位置
        For Each data As Set_WorkProgress_Model.WorkProgress In listProdData
            workSheet.Cells(index, 1) = data.WPDate
            workSheet.Cells(index, 2) = data.Supplier
            workSheet.Cells(index, 3) = data.ProdName
            workSheet.Cells(index, 4) = data.Specification
            workSheet.Cells(index, 8) = data.Count
            workSheet.Cells(index, 10) = data.Unit
            workSheet.Cells(index, 11) = data.Remark
            index += 1
            PrintWorkProgressWork.ReportProgress(index)
        Next
        workSheet = workBook.Worksheets(2)
        If listWorkDetail.Count > 54 Then ' 產生工程進度表門框(背面)資料量超過預設欄位時新增欄位
            For i As Integer = 0 To listWorkDetail.Count - 55
                workSheet.Rows(20).insert
            Next
            workSheet.Rows(18).Copy
            For i As Integer = 0 To listWorkDetail.Count - 55
                workSheet.Rows(20 + i).PasteSpecial
            Next
        End If
        workSheet = workBook.Worksheets(2) '開始輸入工程進度表(背面)
        index = 4
        For Each data As Set_WorkDetail_Model.WorkDetail In listWorkDetail
            workSheet.Cells(index, 1) = data.WorkDate
            workSheet.Cells(index, 2) = data.SalesName
            workSheet.Cells(index, 3) = data.Detail
            index += 1
            PrintWorkProgressWork.ReportProgress(index)
        Next
    End Sub

    Private Sub WorkProgressItem_Click(sender As Object, e As EventArgs) Handles WorkProgressItem.Click
        Print_WorkProgress()
    End Sub

    Private Sub PrintWorkProgressWork_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PrintWorkProgressWork.RunWorkerCompleted
        app.DisplayAlerts = True
        app.Visible = True
        formStatusProcessBar.Close()
    End Sub

    Private Sub PrintBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles PrintBtn.MouseDown
        'If e.Button = MouseButtons.Left Then '按下左鍵 
        '    Me.PrintMenu.Show(sender, e.Location) '顯示功能表 
        'End If
    End Sub

    Private Sub PrintWorkProgressWork_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles PrintWorkProgressWork.ProgressChanged
        formStatusProcessBar.addProcess()
    End Sub

    Private Sub Data_Case_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L4 = 1 Then
            AddBtn.Visible = False
            DelDetailBtn.Visible = False
            ReviseBtn.Visible = False
            ConpleteBtn.Visible = False
            VoidBtn.Visible = False
            addPurchaseButton.Visible = False
            addSaleButton.Visible = False
            AddDetailBtn.Visible = False
            ReviseDetailBtn.Visible = False
            DelDetailBtn.Visible = False
            AddWPBtn.Visible = False
            ReviseWPBtn.Visible = False
            DelWPBtn.Visible = False
        End If

    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim listProdData As List(Of Set_WorkProgress_Model.WorkProgress) = New List(Of Set_WorkProgress_Model.WorkProgress)
        Dim listFitData As List(Of Set_WorkProgress_Model.WorkProgress) = New List(Of Set_WorkProgress_Model.WorkProgress)
        For Each rowData As DataGridViewRow In WorkProgressDGV.Rows
            If rowData.Cells("WPClass").Value = "門框、窗框" Then
                listProdData.Add(New Set_WorkProgress_Model.WorkProgress With {.WPDate = rowData.Cells("WPDate").Value, .Supplier = rowData.Cells("WPSupplier").Value, .ProdName = rowData.Cells("WPPartName").Value, .Specification = rowData.Cells("WPSpecification").Value, .Count = rowData.Cells("WPCount").Value, .Unit = rowData.Cells("WPUnit").Value, .Remark = rowData.Cells("WPRemark").Value})
            Else
                listFitData.Add(New Set_WorkProgress_Model.WorkProgress With {.WPDate = rowData.Cells("WPDate").Value, .Supplier = rowData.Cells("WPSupplier").Value, .ProdName = rowData.Cells("WPPartName").Value, .Specification = rowData.Cells("WPSpecification").Value, .Count = rowData.Cells("WPCount").Value, .Unit = rowData.Cells("WPUnit").Value, .Remark = rowData.Cells("WPRemark").Value})
            End If
        Next
        Dim listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = New List(Of Set_WorkDetail_Model.WorkDetail)
        For Each rowData As DataGridViewRow In DetailDGV.Rows
            listWorkDetail.Add(New Set_WorkDetail_Model.WorkDetail With {.WorkDate = rowData.Cells("WorkDate").Value, .SalesName = rowData.Cells("WorkPerson").Value, .Detail = rowData.Cells("WorkDetail").Value})
        Next
        Dim testView As Output_SaleReport_Form = New Output_SaleReport_Form(UserName, CaseDGV.CurrentRow.Cells("CaseID").Value, CaseDGV.CurrentRow.Cells("Place").Value, listProdData, listFitData, listWorkDetail)
        testView.Show()
    End Sub

    Private Sub WorkProgressDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles WorkProgressDGV.CellDoubleClick
        ReviseWPBtn_Click(Me, New EventArgs)
    End Sub

    Private Sub DetailDGV_DoubleClick(sender As Object, e As EventArgs) Handles DetailDGV.DoubleClick
        ReviseDetailBtn_Click(Me, New EventArgs)
    End Sub
End Class