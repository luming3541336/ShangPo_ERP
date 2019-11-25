Imports Microsoft.Office.Interop

Public Class Set_Repair_Form
    Dim intCaseID As Integer = 0
    Dim intRepairID As Integer = -1
    Dim controller As Set_Repair_Controller = New Set_Repair_Controller
    Dim listRepairProd As List(Of RepairProd)
    Dim arrRepairProdEdit As ArrayList = New ArrayList '紀錄修改RepairProd的資料欄位
    Dim arrRepairProdDel As ArrayList = New ArrayList '紀錄刪除RepairProd的RepairProdID
    Dim bufRepairProdEdit As String = Nothing
    Dim arrRepairAmountEdit As ArrayList = New ArrayList
    Dim arrRepairAmountDel As ArrayList = New ArrayList
    Dim bufRepairAmountEdit As String = Nothing
    Dim arrRepairFileAdd As ArrayList = New ArrayList
    Dim arrRepairFileDel As ArrayList = New ArrayList


    Public Sub New(ByVal intCaseID As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.intCaseID = intCaseID
    End Sub
    Public Sub New(ByVal intCaseID As Integer, ByVal intRepairID As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.intCaseID = intCaseID
        Me.intRepairID = intRepairID
    End Sub


    Private Sub Set_Repair_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingDataBGW.RunWorkerAsync()
        If intRepairID = -1 Then
            '未有RepairID表示要新增維修紀錄
            Dim data As CaseData = controller.Selet_CaseData(intCaseID)
            RepairOrderText.Text = controller.Create_NewOrder
            PlaceText.Text = data.Place
            AddressText.Text = data.Address
            ContactText.Text = data.Contact
            PhoneText.Text = data.Phone
            '查詢是否已過保固
            '過保定義: 最後更新日期+1年
            If Now > DateAdd(DateInterval.Year, 1, CDate(data.UpdateTime)) Then
                WarrantyText.Text = "已過保固，保固期限為:" & Format(DateAdd(DateInterval.Year, 1, CDate(data.UpdateTime)), "yyyy/MM")
            Else
                WarrantyText.Text = "尚未過保，保固期限為:" & Format(DateAdd(DateInterval.Year, 1, CDate(data.UpdateTime)), "yyyy/MM")
            End If
        Else
            '有RepairID表示已有此紀錄，載入內容
            Dim data As RepairData = controller.Select_RepairData(intRepairID)
            '載入RepairData資訊
            RepairOrderText.Text = data.RepairOrder
            RemarkText.Text = data.Remark
            PlaceText.Text = data.Place
            AddressText.Text = data.Address
            ContactText.Text = data.Contact
            PhoneText.Text = data.Place
            RepairPersonText.Text = data.RepairPerson
            ArchiveDate.Text = data.ArchiveDate
            WarrantyText.Text = data.Warranty
            RepairResultText.Text = data.RepairResult
            Select Case data.Status
                Case 1
                    StatusText.Text = "尚未提交"
                    SubmitBtn.Visible = True
                Case 2
                    StatusText.Text = "覆核確認中"
                    SaveBtn.Visible = False
                    If L3 = 3 Then
                        ReCheckBtn.Visible = True
                        PrintBtn.Visible = True
                        SaveBtn.Visible = True
                    End If
                Case 3
                    StatusText.Text = "已完成派單，等待執行"
                    RepairConfirmBtn.Visible = True
                    SaveBtn.Visible = False
                    PrintBtn.Visible = True
                    RepairResultDGV.Visible = True
                    If L3 = 3 Then
                        SaveBtn.Visible = True
                    End If
                Case 4
                    StatusText.Text = "維修已完成"
                    SaveBtn.Visible = False
                    RepairResultDGV.Visible = True
            End Select
            '載入維修產品ReapairProd
            Dim listProdData As List(Of RepairProd) = controller.Select_RepairProd(intRepairID)
            For Each RP As RepairProd In listProdData
                RepairProdDGV.Rows.Add(RP.RepairProdID, RP.ProdPartType, RP.ShipmentPID, RP.ProdPartName, RP.ProdPartCount, RP.RepairRemark)
            Next
            '載入維修費用RepairAmount
            Dim listAmountData As List(Of RepairAmount) = controller.Select_RepairAmount(intRepairID)
            Dim intCount As Integer = 0
            For Each AD As RepairAmount In listAmountData
                RepairAmountDGV.Rows.Add(AD.RepairAmountID, AD.BillItem, AD.RepairPrice)
                intCount += AD.RepairPrice
            Next
            TotalAmountText.Text = intCount
            Dim listFileData As List(Of RepairFile) = controller.Select_RepairFile(intRepairID)
            For Each FD As RepairFile In listFileData
                Dim f As FilePath = New FilePath(FD.RepairFileID, Me, FD.RepairFileName, FD.RepairFilePath)
                f.Name = New Random().Next
                FlowLayoutPanel3.Controls.Add(f)
            Next
            '載入維修單之歷史更新紀錄(RepairLog)
            Dim listData As List(Of RepairLog) = controller.Select_RepairLog(intRepairID)
            Dim strMsg As String = ""
            For Each RL As RepairLog In listData
                strMsg += RL.LogDate & " " & controller.Select_LoginName(RL.LoginID) & RL.Remark & vbCrLf
            Next
            LogText.Text = strMsg
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim data As RepairData = New RepairData
        Dim flag As Boolean = False ' 設置是否為新增維修單旗標
        data.RepairOrder = RepairOrderText.Text
        data.Place = PlaceText.Text
        data.Address = AddressText.Text
        data.Contact = ContactText.Text
        data.ArchiveDate = Format(ArchiveDate.Value, "yyyy/MM/dd")
        data.Warranty = WarrantyText.Text
        data.ETA = Format(ETADate.Value, "yyyy/MM/dd")
        data.RepairResult = RepairResultText.Text
        data.Remark = RemarkText.Text
        data.RepairPerson = RepairPersonText.Text
        data.RepairID = intRepairID
        If intRepairID = -1 Then
            '表示此單為新的維修單，先建立維修單後再將資料放入此維修單中
            Dim id As Integer = controller.Insert_RepairData(intCaseID, RepairOrderText.Text)
            If id <> -1 Then
                intRepairID = id
                data.RepairID = id
                flag = True
                StatusText.Text = "尚未提交"
                SubmitBtn.Visible = True
            Else
                MsgBox("新增錯誤，請聯絡工程師")
                Exit Sub
            End If
        End If
        '新增修繕產品資料:
        '     >若是使用者新增的產品預設不會有RepairProdID，判斷若沒有RepairProdID資料即新增
        '     >防止空值資料紀錄，若修繕產品名稱(ProdPartName)為空，將不會做紀錄
        For Each dataRow As DataGridViewRow In RepairProdDGV.Rows
            If dataRow.Cells("RepairProdID").Value = Nothing And dataRow.Cells("ProdPartName").Value <> "" Then
                controller.Insert_RepairProd(intRepairID, dataRow.Cells("ProdPartType").Value, dataRow.Cells("ShipmentPID").Value, dataRow.Cells("ProdPartName").Value, dataRow.Cells("RepairCount").Value, dataRow.Cells("RepairRemark").Value)
            End If
        Next
        '修改修繕產品資料
        '     >將arrRepairProdEdit內所記錄的資料做更新
        For Each intdata As Integer In arrRepairProdEdit
            controller.Update_RepairProd(New RepairProd With {.RepairProdID = RepairProdDGV(0, intdata).Value, .ProdPartType = RepairProdDGV(1, intdata).Value, .ShipmentPID = RepairProdDGV(2, intdata).Value, .ProdPartName = RepairProdDGV(3, intdata).Value, .ProdPartCount = RepairProdDGV(4, intdata).Value, .RepairRemark = RepairProdDGV(5, intdata).Value})
        Next
        '刪除修繕產品資料
        '      >刪除於arrRepairProdDel所記錄的編號資料
        For Each intdata As Integer In arrRepairProdDel
            controller.Delete_RepairProd(intdata)
        Next
        '新增修繕費用資料
        '    >判斷資料行內的RepairAmountID是否有資料，若無表示此筆為新增資料。
        For Each dataRow As DataGridViewRow In RepairAmountDGV.Rows
            If dataRow.Cells("RepairAmountID").Value = Nothing And dataRow.Cells("BillItem").Value <> "" Then
                controller.Insert_RepairAmount(intRepairID, dataRow.Cells("BillItem").Value, dataRow.Cells("RepairPrice").Value)
            End If
        Next
        '修改修繕費用資料
        '    >將arrRepairAmountEdit所記錄的資料欄位做更新
        For Each intdata As Integer In arrRepairAmountEdit
            controller.Update_RepairAmount(New RepairAmount With {.RepairAmountID = RepairAmountDGV(0, intdata).Value, .BillItem = RepairAmountDGV(1, intdata).Value, .RepairPrice = RepairAmountDGV(2, intdata).Value})
        Next
        '刪除修繕費用資料
        '      >刪除於arrRepairAmountDel所記錄的編號資料
        For Each intdata As Integer In arrRepairAmountDel
            controller.Delete_RepairAmount(intdata)
        Next
        '新增維修單據掃描檔
        For Each controls As Control In arrRepairFileAdd
            If CType(controls, FilePath).Get_FileID = 0 Then
                Dim strFile As String() = Split(CType(controls, FilePath).Get_FileName, ".")
                controller.Copy_File(CType(controls, FilePath).Get_Path, controls.Name & "." & strFile(1))
                controller.Insert_RepairFile(intRepairID, CType(controls, FilePath).Get_FileName, Set_Repair_Model.UPLOAD_PATH & controls.Name & "." & strFile(1))
            End If
        Next
        For Each arrData As RepairFile In arrRepairFileDel
            controller.Delete_RepairFile(arrData)
        Next
        If controller.Update_RepairData(data) <> 0 Then
            If flag Then
                controller.Insert_RepairLog(intRepairID, "新增維修單")
            Else
                controller.Insert_RepairLog(intRepairID, "更改維修單資料")
            End If
            MsgBox("存檔成功")
        Else
            MsgBox("存取錯誤，請重新在試")
        End If
    End Sub

    Private Sub RepairProdDGV_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles RepairProdDGV.CellValidating
        If e.ColumnIndex = ProdPartName.DisplayIndex Then
            If Not ProdPartName.Items.Contains(e.FormattedValue) Then
                ProdPartName.Items.Add(e.FormattedValue)
            End If
            RepairProdDGV.Rows(e.RowIndex).Cells("ShipmentPID").Value = 0
            RepairProdDGV.Rows(e.RowIndex).Cells("ProdPartType").Value = 0
            RepairProdDGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = e.FormattedValue
            For Each data As RepairProd In listRepairProd
                If data.ProdPartName = e.FormattedValue Then
                    RepairProdDGV.Rows(e.RowIndex).Cells("ShipmentPID").Value = data.ShipmentPID
                    RepairProdDGV.Rows(e.RowIndex).Cells("ProdPartType").Value = data.ProdPartType
                End If
            Next
        End If
    End Sub

    Private Sub RepairProdDGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles RepairProdDGV.EditingControlShowing
        If RepairProdDGV.CurrentCell.ColumnIndex = 4 Then
            e.Control.ImeMode = ImeMode.Disable
        Else
            e.Control.ImeMode = ImeMode.OnHalf

        End If
        If RepairProdDGV.CurrentCellAddress.X = ProdPartName.DisplayIndex Then
            Dim cb As ComboBox = TryCast(e.Control, ComboBox)
            If cb IsNot Nothing Then
                cb.DropDownStyle = ComboBoxStyle.DropDown
            End If
        End If
    End Sub

    Private Sub LoadingDataBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingDataBGW.DoWork
        listRepairProd = controller.Select_RepairShipment(intCaseID)
    End Sub

    Private Sub LoadingDataBGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingDataBGW.RunWorkerCompleted
        For Each data As RepairProd In listRepairProd
            ProdPartName.Items.Add(data.ProdPartName)
        Next
        RepairProdDGV.Enabled = True
    End Sub

    Private Sub RepairAmountDGV_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles RepairAmountDGV.CellValidating
        If e.ColumnIndex = BillItem.DisplayIndex Then
            If Not BillItem.Items.Contains(e.FormattedValue) Then
                BillItem.Items.Add(e.FormattedValue)
            End If
            RepairAmountDGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = e.FormattedValue
        End If
    End Sub

    Private Sub RepairAmountDGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles RepairAmountDGV.EditingControlShowing
        If RepairAmountDGV.CurrentCell.ColumnIndex = 2 Then
            e.Control.ImeMode = ImeMode.Disable
        Else
            e.Control.ImeMode = ImeMode.OnHalf

        End If
        If RepairAmountDGV.CurrentCellAddress.X = BillItem.DisplayIndex Then
            Dim cb As ComboBox = TryCast(e.Control, ComboBox)
            If cb IsNot Nothing Then
                cb.DropDownStyle = ComboBoxStyle.DropDown
            End If
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        Select Case MsgBox("確定要提交資料?提交後資料修改需交由上級主管執行。", MsgBoxStyle.OkCancel, "注意")
            Case MsgBoxResult.Ok
                controller.Update_RepairDataStatus(2, intRepairID)
                controller.Insert_RepairLog(intRepairID, "提交維修申請單")
                MsgBox("資料已更新", MsgBoxStyle.OkOnly, "注意")
                Me.DialogResult = DialogResult.OK
        End Select
    End Sub

    Private Sub RepairAmountDGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles RepairAmountDGV.CellValueChanged
        If RepairAmountDGV.Rows.Count > 1 Then
            If e.ColumnIndex = RepairPrice.DisplayIndex Then
                Dim intCount As Integer = 0
                For Each rowData As DataGridViewRow In RepairAmountDGV.Rows
                    intCount += CInt(rowData.Cells("RepairPrice").Value)
                Next
                TotalAmountText.Text = intCount
            End If
        End If
    End Sub

    Private Sub ReCheckBtn_Click(sender As Object, e As EventArgs) Handles ReCheckBtn.Click
        Select Case MsgBox("若有新增資料時須先存檔，確定資料皆正確?", MsgBoxStyle.OkCancel, "注意")
            Case MsgBoxResult.Ok
                controller.Update_RepairDataStatus(3, intRepairID)
                controller.Insert_RepairLog(intRepairID, "覆核確認")
                MsgBox("資料已更新", MsgBoxStyle.OkOnly, "注意")
                Me.DialogResult = DialogResult.OK
        End Select
    End Sub

    Private Sub RepairProdDGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles RepairProdDGV.DataError
        If e.ColumnIndex = ProdPartName.DisplayIndex Then
            If Not ProdPartName.Items.Contains(RepairProdDGV(e.ColumnIndex, e.RowIndex).Value) Then
                ProdPartName.Items.Add(RepairProdDGV(e.ColumnIndex, e.RowIndex).Value)
            End If
        End If
    End Sub

    Private Sub RepairAmountDGV_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles RepairAmountDGV.DataError
        If e.ColumnIndex = BillItem.DisplayIndex Then
            If Not BillItem.Items.Contains(RepairAmountDGV(e.ColumnIndex, e.RowIndex).Value) Then
                BillItem.Items.Add(RepairAmountDGV(e.ColumnIndex, e.RowIndex).Value)
            End If
        End If
    End Sub

    Private Sub RepairProdDGV_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles RepairProdDGV.CellBeginEdit
        bufRepairProdEdit = RepairProdDGV(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub RepairProdDGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles RepairProdDGV.CellEndEdit
        If bufRepairProdEdit <> RepairProdDGV(e.ColumnIndex, e.RowIndex).Value And RepairProdDGV.Rows(e.RowIndex).Cells("RepairProdID").Value <> Nothing Then
            arrRepairProdEdit.Add(e.RowIndex)
        End If
    End Sub


    Private Sub RepairProdDGV_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles RepairProdDGV.UserDeletingRow
        If e.Row.Cells("RepairProdID").Value <> Nothing Then
            arrRepairProdDel.Add(e.Row.Cells("RepairProdID").Value)
        End If
    End Sub

    Private Sub RepairAmountDGV_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles RepairAmountDGV.CellBeginEdit
        bufRepairAmountEdit = RepairAmountDGV(e.ColumnIndex, e.RowIndex).Value
    End Sub

    Private Sub RepairAmountDGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles RepairAmountDGV.CellEndEdit
        If bufRepairAmountEdit <> RepairAmountDGV(e.ColumnIndex, e.RowIndex).Value And RepairAmountDGV.Rows(e.RowIndex).Cells("RepairAmountID").Value <> Nothing Then
            arrRepairAmountEdit.Add(e.RowIndex)
        End If
    End Sub

    Private Sub RepairAmountDGV_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles RepairAmountDGV.UserDeletingRow
        If e.Row.Cells("RepairAmountID").Value <> Nothing Then
            arrRepairAmountDel.Add(e.Row.Cells("RepairAmountID").Value)
        End If
    End Sub

    Private Sub FileUploadBtn_Click(sender As Object, e As EventArgs) Handles FileUploadBtn.Click
        Dim dialog As OpenFileDialog = New OpenFileDialog
        dialog.Title = "選擇要上傳的檔案"
        dialog.Filter = "pdf files (*.pdf)|*.pdf|jpeg(*.jpg)|*.jpg"
        dialog.Multiselect = True
        If dialog.ShowDialog = DialogResult.OK Then
            If dialog.OpenFile IsNot Nothing Then
                Dim Filter As Integer = dialog.FilterIndex
                Dim FileNames As String() = dialog.FileNames
                Dim SafeFileNames As String() = dialog.SafeFileNames
                For i As Integer = 0 To SafeFileNames.Length - 1
                    Dim f As FilePath = New FilePath(Me, SafeFileNames(i), FileNames(i))
                    f.Name = New Random().Next
                    FlowLayoutPanel3.Controls.Add(f)
                    arrRepairFileAdd.Add(f)
                Next
            End If
        End If
    End Sub
    Public Sub RemoveControl(ByRef myControl As Control)
        FlowLayoutPanel3.Focus()
        '若刪除的檔案ID為0表示為尚未新增之檔案，直接從新增檔案陣列內刪除
        If CType(myControl, FilePath).Get_FileID = 0 Then
            arrRepairFileAdd.Remove(myControl)
        Else
            arrRepairFileDel.Add(New RepairFile With {.RepairFileID = CType(myControl, FilePath).Get_FileID, .RepairFilePath = CType(myControl, FilePath).Get_Path})
        End If
        FlowLayoutPanel3.Controls.Remove(myControl)
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim wordApp As Word.Application = New Word.Application
        Dim wordDoc As Word.Document = wordApp.Documents.Open(path + "\Resources\維修單.dotx", [ReadOnly]:=True)
        wordDoc.Content.Find.Execute(FindText:="$ArchiveDate", ReplaceWith:=Format(ArchiveDate.Value, "yyyy/MM/dd"), Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$ETADate", ReplaceWith:=Format(ETADate.Value, "yyyy/MM/dd"), Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$RepairOrder", ReplaceWith:=RepairOrderText.Text, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$Place", ReplaceWith:=PlaceText.Text, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$Contact", ReplaceWith:=ContactText.Text, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$Address", ReplaceWith:=AddressText.Text, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$Phone", ReplaceWith:=PhoneText.Text, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        wordDoc.Content.Find.Execute(FindText:="$RepairPerson", ReplaceWith:=RepairPersonText.Text, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        Dim strRepairProd As String = ""
        For Each data As DataGridViewRow In RepairProdDGV.Rows
            If data.Cells("ProdPartName").Value <> Nothing Then
                strRepairProd += data.Cells("ProdPartName").Value & "*" & data.Cells("RepairCount").Value & IIf(data.Cells("RepairRemark").Value <> Nothing, "(" & data.Cells("RepairRemark").Value & ")", Nothing) & vbCr
            End If
        Next
        strRepairProd = strRepairProd.TrimEnd(vbCr)
        wordDoc.Content.Find.Execute(FindText:="$RepairProd", ReplaceWith:=strRepairProd, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        Dim strRepairAmount As String = ""
        For Each data As DataGridViewRow In RepairAmountDGV.Rows
            If data.Cells("BillItem").Value <> Nothing Then
                strRepairAmount += data.Cells("BillItem").Value & ":" & data.Cells("RepairPrice").Value & vbCr
            End If
        Next
        strRepairAmount = strRepairAmount.TrimEnd(vbCr)
        wordDoc.Content.Find.Execute(FindText:="$RepairAmount", ReplaceWith:=strRepairAmount, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)

        wordApp.DisplayAlerts = True
        wordApp.Visible = True
    End Sub

    Private Sub RepairConfirmBtn_Click(sender As Object, e As EventArgs) Handles RepairConfirmBtn.Click

        Select Case MsgBox("若有新增資料時須先存檔，完成後將無法再修正", MsgBoxStyle.OkCancel, "注意")
            Case MsgBoxResult.Ok
                controller.Update_RepairDataStatus(4, intRepairID)
                controller.Insert_RepairLog(intRepairID, "維修確認")
                MsgBox("資料已更新", MsgBoxStyle.OkOnly, "注意")
                Me.DialogResult = DialogResult.OK
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class