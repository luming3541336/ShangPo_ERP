Public Class Set_ReceiptKey_Form
    Private intCaseID As Integer = Nothing
    Private intReceiptID As Integer = Nothing
    Dim arrRepairFileAdd As ArrayList = New ArrayList
    Dim arrRepairFileDel As ArrayList = New ArrayList
    Private controller As Set_ReceiptKey_Controller = New Set_ReceiptKey_Controller
    '狀態:1 尚未簽收 2 簽收完成
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
        If intReceiptID <> Nothing Then
            Dim data As ReceiptData = controller.Select_ReceiptData(intReceiptID)
            ReceiptOrderText.Text = data.ReceiptOrder
            InsertDate.Text = Format(data.InsertDate, "yyyy/MM/dd")
            ContactText.Text = data.Contact
            PlaceText.Text = data.Place
            StatusText.Text = If(data.Status = 1, "尚未簽收", "簽收完成")
            Dim listdata As List(Of ReceiptKey) = controller.Select_ReceiptKey(intReceiptID)
            For Each data2 As ReceiptKey In listdata
                ReceiptKeyDGV.Rows.Add(data2.ReceiptKeyID, data2.Room, data2.Item, data2.Location, data2.ReceiptCount, data2.Remark)
            Next
            RepairConfirmBtn.Visible = True
            PrintBtn.Visible = True
        Else
            Dim controller2 As Set_Repair_Controller = New Set_Repair_Controller
            Dim data As CaseData = controller2.Selet_CaseData(intCaseID)
            ContactText.Text = data.Contact
            PlaceText.Text = data.Place
            ReceiptOrderText.Text = controller.Create_NewOrder

        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim data As ReceiptData = New ReceiptData With {.ReceiptID = intReceiptID, .Contact = ContactText.Text, .InsertDate = InsertDate.Text, .Place = PlaceText.Text, .ReceiptOrder = ReceiptOrderText.Text, .ReceiptType = 0, .Status = 1, .CaseID = intCaseID, .ReceiptDate = Nothing}
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
        Dim data2 As List(Of ReceiptKey) = New List(Of ReceiptKey)
        For Each row As DataGridViewRow In ReceiptKeyDGV.Rows
            If row.Cells("ReceiptKeyID").Value = "" And row.Cells("Item").Value <> "" Then
                Dim id As Integer = controller.Insert_ReceiptKey(New ReceiptKey With {.ReceiptID = intReceiptID, .Item = row.Cells("Item").Value, .Location = row.Cells("Location").Value, .ReceiptCount = row.Cells("ReceiptCount").Value, .Remark = row.Cells("ReceiptRemark").Value, .Room = row.Cells("Room").Value})
                row.Cells("ReceiptKeyID").Value = id
            Else
                controller.Update_ReceiptKey(New ReceiptKey With {.ReceiptKeyID = row.Cells("ReceiptKeyID").Value, .ReceiptID = intReceiptID, .Item = row.Cells("Item").Value, .Location = row.Cells("Location").Value, .ReceiptCount = row.Cells("ReceiptCount").Value, .Remark = row.Cells("ReceiptRemark").Value, .Room = row.Cells("Room").Value})
            End If
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
            arrRepairFileDel.Add(New ReceiptFile With {.ReceiptFileID = CType(myControl, FilePath).Get_FileID, .ReceiveFilePath = CType(myControl, FilePath).Get_Path})
        End If
        FlowLayoutPanel3.Controls.Remove(myControl)
    End Sub
End Class