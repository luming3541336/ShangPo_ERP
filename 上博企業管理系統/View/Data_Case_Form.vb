

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
    Private Sub LoadingBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingBackground.DoWork
        Dim arrayList As List(Of CaseData) = New List(Of CaseData)
        If strSearchSQL = Nothing Then
            arrayList = controller.Select_CaseData(Data_Case_Model.UNSUCCESS_STATE)
        Else
            arrayList = controller.Select_CaseData(strSearchSQL)
        End If
        e.Result = {arrayList, e.Argument}
    End Sub
    Private Sub LoadingBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingBackground.RunWorkerCompleted
        Dim arrayList As List(Of CaseData) = e.Result(0)
        For Each item As CaseData In arrayList
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
        If CaseDGV.RowCount > e.Result(1) Then
            CaseDGV.CurrentCell = CaseDGV.Rows(e.Result(1)).Cells(1)
        End If
        caseDGV_SelectionChanged(sender, e)
        formStatusNormal.Hide()
    End Sub
    Private Sub Data_Case_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadingBackground.RunWorkerAsync(0)
        formStatusNormal.Show()
    End Sub

    Private Sub LoadingDetailBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingDetailBackground.DoWork

        e.Result = {controller.Select_PurchasePart(e.Argument), controller.Select_PurchasePart2(e.Argument), controller.Select_ShipmentPart(e.Argument), controller.Select_ShipmentPart2(e.Argument),
            controller.Get_PurchaseCase_Count(e.Argument), controller.Get_SaleCase_Count(e.Argument), controller.Select_WorkDetail(e.Argument), controller.Select_WorkProgress(e.Argument), controller.Select_RepairData(e.Argument), controller.Select_ReceiptData(e.Argument)}
    End Sub

    Private Sub LoadingDetailBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingDetailBackground.RunWorkerCompleted
        listPurchasePart = e.Result(0)
        listPurchasePart2 = e.Result(1)
        Dim listShipmentPart As List(Of Data_Case_Model.ShipmentPart) = e.Result(2)
        Dim listShipmentPart2 As List(Of Data_Case_Model.ShipmentPart2) = e.Result(3)
        Dim intPurchaseCount As Integer = e.Result(4)
        Dim intSaleCount As Integer = e.Result(5)
        Dim listWorkDetail As List(Of Set_WorkDetail_Model.WorkDetail) = e.Result(6)
        Dim listWorkProgress As List(Of Set_WorkProgress_Model.WorkProgress) = e.Result(7)
        Dim listRepairData As List(Of RepairData) = e.Result(8)
        Dim listReceiptData As List(Of ReceiptData) = e.Result(9)
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
        ReceiptDGV.Rows.Clear()
        For Each data As ReceiptData In listReceiptData
            Dim strStatus As String = ""
            Select Case data.Status
                Case 1
                    strStatus = "尚未簽收"
                Case 2
                    strStatus = "簽收完成"
            End Select
            ReceiptDGV.Rows.Add(data.ReceiptID, data.ReceiptType, data.ReceiptOrder, Format(data.InsertDate, "yyyy/MM/dd"), If(data.ReceiptType = 0, "鑰匙", "五金"), If(data.ReceiptDate = Nothing, "尚未簽收", Format(data.ReceiptDate, "yyyy/MM/dd")), strStatus, data.Status)
        Next
        RepairDGV.Rows.Clear()
        For Each data As RepairData In listRepairData
            Dim strStatus As String = ""
            Select Case data.Status
                Case 1
                    strStatus = "尚未提交"
                Case 2
                    strStatus = "複核確認中"
                Case 3
                    strStatus = "已完成派單，等待執行"
                Case 4
                    strStatus = "維修已完成"
            End Select
            RepairDGV.Rows.Add(data.RepairID, Format(data.ArchiveDate, "yyyy/MM/dd"), data.RepairPerson, data.Remark, data.ETA, strStatus)
        Next
        PurchaseCountLabel.Text = intPurchaseCount
        SaleCountLabel.Text = intSaleCount
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim formDataSearch As Data_Search_Form = New Data_Search_Form
        If formDataSearch.ShowDialog = DialogResult.OK Then
            strSearchSQL = formDataSearch.strSQL
            RefreshCaseData(0)
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        RefreshCaseData(CaseDGV.CurrentRow.Index)
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim formSetCase As Set_Case_Form = New Set_Case_Form(UserName)
        If formSetCase.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub
    Private Sub RefreshCaseData(ByVal index As Integer)
        CaseDGV.Rows.Clear()
        If Not LoadingBackground.IsBusy Then
            LoadingBackground.RunWorkerAsync(index)
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
                RefreshCaseData(CaseDGV.CurrentRow.Index)
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
                RefreshCaseData(CaseDGV.CurrentRow.Index)
            End If
        End If
    End Sub

    Private Sub caseDGV_SelectionChanged(sender As Object, e As EventArgs) Handles CaseDGV.SelectionChanged
        If CaseDGV.CurrentRow IsNot Nothing Then
            addPurchaseButton.Enabled = True
            addSaleButton.Enabled = True
            AddDetailBtn.Enabled = True
            ReviseDetailBtn.Enabled = False
            DelDetailBtn.Enabled = False
            AddWPBtn.Enabled = True
            ReviseWPBtn.Enabled = False
            DelWPBtn.Enabled = False
            ReviseRepairBtn.Enabled = False
            AddRepairBtn.Enabled = True
            DelRepairBtn.Enabled = False
            ReviseReceiptBtn.Enabled = False
            DelReceiptBtn.Enabled = False
            ReceiptAddBtn.Enabled = True
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
        Else
            addPurchaseButton.Enabled = False
            addSaleButton.Enabled = False
            AddDetailBtn.Enabled = False
            AddWPBtn.Enabled = False
            AddRepairBtn.Enabled = False
            ReceiptAddBtn.Enabled = False
            Do While LoadingDetailBackground.IsBusy
                Application.DoEvents()
            Loop
            PurchaseCountLabel.Text = 0
            SaleCountLabel.Text = 0
            PurchasePartDGV.Rows.Clear()
            PurchasePart2DGV.Rows.Clear()
            ShipmentPartDGV.Rows.Clear()
            ShipmentPart2DGV.Rows.Clear()
            DetailDGV.Rows.Clear()
            WorkProgressDGV.Rows.Clear()
            ReceiptDGV.Rows.Clear()
            RepairDGV.Rows.Clear()
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
                RefreshCaseData(CaseDGV.CurrentRow.Index)
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

    Private Sub PrintWorkProgressWork_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles PrintWorkProgressWork.ProgressChanged
        formStatusProcessBar.addProcess()
    End Sub

    Private Sub Data_Case_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L3 = 1 Then
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
            ReceiptAddBtn.Visible = False
            ReviseReceiptBtn.Visible = False
            DelReceiptBtn.Visible = False
            AddRepairBtn.Visible = False
            ReviseRepairBtn.Visible = False
            DelRepairBtn.Visible = False
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

    Private Sub AddRepairBtn_Click(sender As Object, e As EventArgs) Handles AddRepairBtn.Click
        Dim view As Set_Repair_Form = New Set_Repair_Form(CaseDGV.CurrentRow.Cells("CaseID").Value)
        If view.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub

    Private Sub RepairDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles RepairDGV.CellDoubleClick
        Dim view As Set_Repair_Form = New Set_Repair_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, RepairDGV.CurrentRow.Cells("RepairID").Value)
        If view.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub
    Private Sub ReviseRepairBtn_Click(sender As Object, e As EventArgs) Handles ReviseRepairBtn.Click
        Dim view As Set_Repair_Form = New Set_Repair_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, RepairDGV.CurrentRow.Cells("RepairID").Value)
        If view.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub

    Private Sub RepairDGV_SelectionChanged(sender As Object, e As EventArgs) Handles RepairDGV.SelectionChanged
        AddRepairBtn.Enabled = True
        If RepairDGV.SelectedRows.Count <> 0 Then
            ReviseRepairBtn.Enabled = True
            DelRepairBtn.Enabled = True
        End If
    End Sub
    Private Sub DelRepairBtn_Click(sender As Object, e As EventArgs) Handles DelRepairBtn.Click
        If RepairDGV.CurrentRow IsNot Nothing Then
            Dim controller As Set_Repair_Controller = New Set_Repair_Controller
            Dim msgResult As MsgBoxResult = MsgBox("請問確認要刪除案件嗎?刪除後將無法恢復", MsgBoxStyle.OkCancel, "注意")
            Select Case msgResult
                Case MsgBoxResult.Ok
                    controller.Delete_RepairData(RepairDGV.CurrentRow.Cells("RepairID").Value)
                    MsgBox("刪除完成")
                    RefreshCaseData(CaseDGV.CurrentRow.Index)
            End Select
        End If
    End Sub
    Private Sub ReceiptAddBtn_Click(sender As Object, e As EventArgs) Handles ReceiptAddBtn.Click
        Dim view As Set_ReceiptKey_Form = New Set_ReceiptKey_Form(CaseDGV.CurrentRow.Cells("CaseID").Value)
        If view.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub
    Private Sub ReceiptDGV_SelectionChanged(sender As Object, e As EventArgs) Handles ReceiptDGV.SelectionChanged
        If ReceiptDGV.SelectedRows.Count <> 0 Then
            ReviseReceiptBtn.Enabled = True
            DelReceiptBtn.Enabled = True
        End If
    End Sub

    Private Sub ReceiptDGV_DoubleClick(sender As Object, e As EventArgs) Handles ReceiptDGV.DoubleClick
        Dim view As Set_ReceiptKey_Form = New Set_ReceiptKey_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, intReceiptID:=ReceiptDGV.CurrentRow.Cells("ReceiptID").Value)
        If view.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub

    Private Sub ReviseReceiptBtn_Click(sender As Object, e As EventArgs) Handles ReviseReceiptBtn.Click
        Dim view As Set_ReceiptKey_Form = New Set_ReceiptKey_Form(CaseDGV.CurrentRow.Cells("CaseID").Value, intReceiptID:=ReceiptDGV.CurrentRow.Cells("ReceiptID").Value)
        If view.ShowDialog = DialogResult.OK Then
            RefreshCaseData(CaseDGV.CurrentRow.Index)
        End If
    End Sub

    Private Sub DelReceiptBtn_Click(sender As Object, e As EventArgs) Handles DelReceiptBtn.Click
        If ReceiptDGV.CurrentRow IsNot Nothing Then
            Dim controller As Set_ReceiptKey_Controller = New Set_ReceiptKey_Controller
            Dim msgResult As MsgBoxResult = MsgBox("請問確認要刪除嗎?刪除後將無法恢復", MsgBoxStyle.OkCancel, "注意")
            Select Case msgResult
                Case MsgBoxResult.Ok
                    controller.Delete_ReceiptData(ReceiptDGV.CurrentRow.Cells("ReceiptID").Value)
                    MsgBox("刪除完成")
                    RefreshCaseData(CaseDGV.CurrentRow.Index)
            End Select
        End If
    End Sub
End Class