Public Class Set_ReceiptKey_Form
    Private intCaseID As Integer = Nothing
    Private intReceiptID As Integer = Nothing
    Private controller As Set_ReceiptKey_Controller = New Set_ReceiptKey_Controller

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
            StatusText.Text = If(data.Status = 0, "尚未簽收", "簽收完成")
            Dim listdata As List(Of ReceiptKey) = controller.Select_ReceiptKey(intReceiptID)
            For Each data2 As ReceiptKey In listdata
                ReceiptKeyDGV.Rows.Add(data2.ReceiptKeyID, data2.Room, data2.Location, data2.ReceiptCount, data2.Remark)
            Next
        Else
            Dim controller2 As Set_Repair_Controller = New Set_Repair_Controller
            Dim data As CaseData = controller2.Selet_CaseData(intCaseID)
            ContactText.Text = data.Contact
            PlaceText.Text = data.Place
            ReceiptOrderText.Text = controller.Create_NewOrder

        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim data As ReceiptData = New ReceiptData With {.ReceiptID = intReceiptID, .Contact = ContactText.Text, .InsertDate = InsertDate.Text, .Place = PlaceText.Text, .ReceiptOrder = ReceiptOrderText.Text, .ReceiptType = 0, .Status = 1}
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
            If row.Cells("ReceiptKeyID").Value <> "" Then
                Dim id As Integer = controller.Insert_ReceiptKey(New ReceiptKey With {.ReceiptID = intReceiptID, .Item = row.Cells("Item").Value, .Location = row.Cells("Location").Value, .ReceiptCount = row.Cells("ReceiptCount").Value, .Remark = row.Cells("ReceiptRemark").Value, .Room = row.Cells("Room").Value})
                row.Cells("ReceiptKeyID").Value = id
            Else
                controller.Update_ReceiptKey(New ReceiptKey With {.ReceiptKeyID = row.Cells("ReceiptKeyID").Value, .ReceiptID = intReceiptID, .Item = row.Cells("Item").Value, .Location = row.Cells("Location").Value, .ReceiptCount = row.Cells("ReceiptCount").Value, .Remark = row.Cells("ReceiptRemark").Value, .Room = row.Cells("Room").Value})
            End If
        Next

    End Sub
End Class