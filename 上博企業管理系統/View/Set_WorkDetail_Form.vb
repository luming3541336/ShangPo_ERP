Imports System.Data.SqlClient

Public Class Set_WorkDetail_Form
    Private intMode As Integer = 0
    Private ID As String = Nothing
    Private conDB As Connection = New Connection
    Private statusForm As Status_Normal_Form = New Status_Normal_Form("載入中")
    Private loginData As List(Of Integer) = New List(Of Integer)
    Private controller As Set_WorkDetail_Controller = New Set_WorkDetail_Controller
    Public Sub New(ByVal ID As Integer, ByVal mode As Integer)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        If mode = controller.EDIT_MODE Then
            intMode = controller.EDIT_MODE
            TitleLabel.Text = "編輯工作明細"

        ElseIf mode = controller.INSERT_MODE Then
            intMode = controller.INSERT_MODE
            TitleLabel.Text = "新增工作明細"
        End If
        Me.ID = ID
    End Sub

    Private Sub Set_WorkDetail_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If intMode = controller.EDIT_MODE Then
            Me.Hide()
            LoadingWork.RunWorkerAsync()
            statusForm.Show()
        End If
    End Sub

    Private Sub LoadingWork_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingWork.DoWork
        Dim data As Set_WorkDetail_Model.WorkDetail = controller.SelectWorkDetail(ID)
        e.Result = data
    End Sub

    Private Sub LoadingWork_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingWork.RunWorkerCompleted
        JobDetailDataTime.Value = e.Result.WorkDate
        SalesText.Text = e.Result.SalesName
        JobDetail.Text = e.Result.Detail
        statusForm.Dispose()
        Me.Show()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If intMode = controller.INSERT_MODE Then
            If controller.InsertWorkDetail(ID, JobDetail.Text, SalesText.Text, JobDetailDataTime.Value.Date, UserName) Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("新增錯誤，請重新啟動再嘗試")
            End If
        ElseIf intMode = controller.EDIT_MODE Then
            If controller.UpdateWorkDetail(ID, JobDetail.Text, SalesText.Text, JobDetailDataTime.Value.Date, UserName) Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("新增錯誤，請重新啟動再嘗試")
            End If
        End If

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub Text_Leave(sender As Object, e As EventArgs) Handles JobDetail.TextChanged, SalesText.TextChanged
        sender.Text = StrConv(sender.Text, VbStrConv.Narrow)
    End Sub

    Private Sub placeText_Enter(sender As Object, e As EventArgs) Handles SalesText.Enter
        sender.ImeMode = ImeMode.OnHalf
    End Sub

    Private Sub Set_WorkDetail_Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class