Imports Microsoft.Office.Interop
Public Class Set_ReceiptCom_Form
    Private intCaseID As Integer = Nothing
    Private intReceiptID As Integer = Nothing
    Dim arrReceiptFileAdd As ArrayList = New ArrayList
    Dim arrReceiptFileDel As ArrayList = New ArrayList
    Dim arrReceiptDel As ArrayList = New ArrayList
    Private controller As Set_ReceiptCom_Controller = New Set_ReceiptCom_Controller
    '狀態:1 尚未簽收 2 簽收完成
    'ReceiptType:0鑰匙1配件
    Public Sub New(ByVal intCaseID As Integer, Optional ByVal intReceiptID As Integer = Nothing)

        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.intCaseID = intCaseID
        If intReceiptID <> Nothing Then
            Me.intReceiptID = intReceiptID
        End If

    End Sub

    Private Sub Set_ReceiptKey_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '修改鑰匙單時執行
        If intReceiptID <> Nothing Then
            Dim data As ReceiptData = controller.Select_ReceiptData(intReceiptID)
            ReceiptOrderText.Text = data.ReceiptOrder
            InsertDate.Text = Format(CDate(data.InsertDate), "yyyy/MM/dd")
            ContactText.Text = data.Contact
            If data.ReturnDate <> Nothing Then
                ReturnDate.Value = Format(CDate(data.ReturnDate), "yyyy/MM/dd")
            End If
            If data.ReceiptDate > ReceiptDate.MinDate Then
                ReceiptDate.Text = Format(CDate(data.ReceiptDate), "yyyy/MM/dd")
            End If
            ReturnText.Text = data.ReturnUser
            StatusText.Text = If(data.Status = 1, "尚未簽收", "簽收完成")
            If data.Status = 2 Then
                SaveBtn.Visible = False
                RepairConfirmBtn.Visible = False
            Else
                RepairConfirmBtn.Visible = True
                ReceiptDate.Enabled = True
            End If
            PrintBtn.Visible = True
            Dim listdata As List(Of ReceiptCom) = controller.Select_ReceiptCom(intReceiptID)
            For Each data2 As ReceiptCom In listdata
                ReceiptComDGV.Rows.Add(data2.ReceiptComID, data2.Item, data2.Count, data2.Unit, data2.Price, data2.TotalAmount, data2.Remark)
            Next
            Dim listFileData As List(Of ReceiptFile) = controller.Select_ReceiptFile(intReceiptID)
            For Each FD As ReceiptFile In listFileData
                Dim f As FilePath = New FilePath(FD.ReceiptFileID, Me, FD.ReceiptFileName, FD.ReceiptFilePath)
                f.Name = New Random().Next
                FlowLayoutPanel3.Controls.Add(f)
            Next

            '新增鑰匙單時執行
        Else
            Dim controller2 As Set_Repair_Controller = New Set_Repair_Controller
            Dim data As CaseData = controller2.Selet_CaseData(intCaseID)
            ContactText.Text = data.Contact
            ReceiptOrderText.Text = controller.Create_NewOrder
            Dim listFileData As List(Of ReceiptFile) = controller.Select_ReceiptFile(intReceiptID)
            For Each FD As ReceiptFile In listFileData
                Dim f As FilePath = New FilePath(FD.ReceiptFileID, Me, FD.ReceiptFileName, FD.ReceiptFilePath)
                f.Name = New Random().Next
                FlowLayoutPanel3.Controls.Add(f)
            Next
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim data As ReceiptData = New ReceiptData With {.ReceiptID = intReceiptID, .Contact = ContactText.Text, .InsertDate = InsertDate.Text, .Place = "", .ReceiptOrder = ReceiptOrderText.Text, .ReceiptType = 1, .Status = 1, .CaseID = intCaseID, .ReceiptDate = Nothing, .ReturnDate = Format(ReturnDate.Value, "yyyy/MM/dd"), .ReturnUser = ReturnText.Text}
        If intReceiptID = Nothing Then
            Dim intReceiveID As Integer = controller.Insert_ReceiptData(data)
            If intReceiveID <> Nothing Then
                Me.intReceiptID = intReceiveID
            Else
                MsgBox("新增錯誤，請聯絡管理員")
                Exit Sub
            End If
        Else
            controller.Update_ReceiptData(data)
        End If
        Dim data2 As List(Of ReceiptCom) = New List(Of ReceiptCom)
        For Each row As DataGridViewRow In ReceiptComDGV.Rows
            If row.Cells("ReceiptComID").Value = Nothing And row.Cells("Item").Value <> "" Then
                Dim id As Integer = controller.Insert_ReceiptCom(New ReceiptCom With {.ReceiptID = intReceiptID, .Item = row.Cells("Item").Value, .Count = row.Cells("Count").Value, .Price = row.Cells("Price").Value, .Remark = row.Cells("ReceiptRemark").Value, .TotalAmount = row.Cells("TotalAmount").Value, .Unit = row.Cells("Unit").Value})
                row.Cells("ReceiptComID").Value = id
            Else
                controller.Update_ReceiptCom(New ReceiptCom With {.ReceiptComID = row.Cells("ReceiptComID").Value, .ReceiptID = intReceiptID, .Item = row.Cells("Item").Value, .Count = row.Cells("Count").Value, .Price = row.Cells("Price").Value, .Remark = row.Cells("ReceiptRemark").Value, .TotalAmount = row.Cells("TotalAmount").Value, .Unit = row.Cells("Unit").Value})
                '若有刪除任何欄位時執行
                For Each i As Integer In arrReceiptDel
                    controller.Delete_ReceiptCom(i)
                Next
            End If
        Next
        For Each controls As Control In arrReceiptFileAdd
            If CType(controls, FilePath).Get_FileID = 0 Then
                Dim strFile As String() = Split(CType(controls, FilePath).Get_FileName, ".")
                controller.Copy_File(CType(controls, FilePath).Get_Path, controls.Name & "." & strFile(1))
                controller.Insert_ReceipFile(intReceiptID, CType(controls, FilePath).Get_FileName, UPLOAD_PATH & controls.Name & "." & strFile(1))
            End If
        Next
        For Each arrData As ReceiptFile In arrReceiptFileDel
            controller.Delete_ReceiptFile(arrData)
        Next
        MsgBox("新增成功")
        Me.DialogResult = DialogResult.OK
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
                    arrReceiptFileAdd.Add(f)
                Next
            End If
        End If
    End Sub
    Public Sub RemoveControl(ByRef myControl As Control)
        FlowLayoutPanel3.Focus()
        '若刪除的檔案ID為0表示為尚未新增之檔案，直接從新增檔案陣列內刪除
        If CType(myControl, FilePath).Get_FileID = 0 Then
            arrReceiptFileAdd.Remove(myControl)
        Else
            arrReceiptFileDel.Add(New ReceiptFile With {.ReceiptFileID = CType(myControl, FilePath).Get_FileID, .ReceiptFilePath = CType(myControl, FilePath).Get_Path})
        End If
        FlowLayoutPanel3.Controls.Remove(myControl)
    End Sub

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        Dim path As String = My.Application.Info.DirectoryPath
        Dim App As Excel.Application = New Excel.Application
        Dim workBook As Excel.Workbook = App.Workbooks.Open(path + "\Resources\五金簽收單.xltx", [ReadOnly]:=True)
        Dim workSheet As Excel.Worksheet = workBook.Sheets(1)
        workSheet.Cells(2, 2) = ContactText.Text ' 客戶名稱
        workSheet.Cells(2, 7) = Format(Now, "yyyy/MM/dd") '製表時間
        Dim obj As Object(,) = New Object(ReceiptComDGV.RowCount - 1, 5) {}
        Dim i As Integer = 0
        For Each data As DataGridViewRow In ReceiptComDGV.Rows
            obj(i, 0) = data.Cells("Item").Value
            obj(i, 1) = data.Cells("Count").Value
            obj(i, 2) = data.Cells("Unit").Value
            obj(i, 3) = data.Cells("Price").Value
            obj(i, 4) = data.Cells("TotalAmount").Value
            i += 1
        Next
        If obj.Length > 5 Then
            '  workSheet.Range(4, 4).Insert(CopyOrigin:=Excel.XlInsertFormatOrigin.xlFormatFromRightOrBelow)
        End If
        workSheet.Range(App.Cells(4, 2), App.Cells(ReceiptComDGV.RowCount + 3, 6)).Value2 = obj
        App.DisplayAlerts = True
        App.Visible = True
    End Sub

    Private Sub RepairConfirmBtn_Click(sender As Object, e As EventArgs) Handles RepairConfirmBtn.Click
        Dim data As ReceiptData = New ReceiptData With {.ReceiptID = intReceiptID, .Contact = ContactText.Text, .InsertDate = InsertDate.Text, .Place = "", .ReceiptOrder = ReceiptOrderText.Text, .ReceiptType = 1, .Status = 2, .CaseID = intCaseID, .ReceiptDate = Format(ReceiptDate.Value, "yyyy/MM/dd"), .ReturnDate = Format(ReturnDate.Value, "yyyy/MM/dd"), .ReturnUser = ReturnText.Text}
        If controller.Update_ReceiptData(data) = 1 Then
            MsgBox("狀態更新")
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub ReceiptKeyDGV_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs)
        arrReceiptDel.Add(e.Row.Cells("ReceiptKeyID").Value)
    End Sub

    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged, ReceiptDate.ValueChanged
        CType(sender, DateTimePicker).Format = DateTimePickerFormat.Short
    End Sub

    Private Sub 複製ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 複製ToolStripMenuItem.Click
        If Not IsNothing(ReceiptComDGV.CurrentRow) Then
            If ReceiptComDGV.SelectedCells.Count = 6 Then '當整攔複製時執行
                Dim index As Integer = ReceiptComDGV.CurrentRow.Index
                ReceiptComDGV.Rows.Add(Nothing, ReceiptComDGV.Rows(index).Cells("Room").Value, ReceiptComDGV.Rows(index).Cells("Item").Value, ReceiptComDGV.Rows(index).Cells("Location").Value, ReceiptComDGV.Rows(index).Cells("ReceiptCount").Value, ReceiptComDGV.Rows(index).Cells("ReceiptRemark").Value)
            ElseIf ReceiptComDGV.SelectedCells.Count = 1 Then
                Clipboard.SetText(ReceiptComDGV.CurrentCell.Value)
                貼上ToolStripMenuItem.Enabled = True
            End If
        Else
            MsgBox("請選擇要複製的欄位")
        End If
    End Sub

    Private Sub 貼上ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 貼上ToolStripMenuItem.Click
        If Not IsNothing(ReceiptComDGV.CurrentRow) Then
            ReceiptComDGV.CurrentCell.Value = Clipboard.GetText()
        Else
            MsgBox("請選擇要貼上的欄位")
        End If
    End Sub

    Private Sub ReceiptKeyDGV_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.C Then
            複製ToolStripMenuItem_Click(sender, e)
        ElseIf e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
            貼上ToolStripMenuItem_Click(sender, e)
        End If
    End Sub
End Class