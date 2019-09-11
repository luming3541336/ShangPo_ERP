
Public Class Set_WorkProgress_Form
    Private intMode As Integer = 0
    Private ID As String = Nothing
    Private conDB As Connection = New Connection
    Private statusForm As Status_Normal_Form = New Status_Normal_Form("載入中")
    Private loginData As List(Of Integer) = New List(Of Integer)
    Private controller As Set_WorkProgress_Controller = New Set_WorkProgress_Controller
    Public Sub New(ByVal ID As Integer, ByVal mode As Integer)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        If mode = controller.EDIT_MODE Then
            intMode = controller.EDIT_MODE
            TitleLabel.Text = "編輯工程進度"

        ElseIf mode = controller.INSERT_MODE Then
            intMode = controller.INSERT_MODE
            TitleLabel.Text = "新增工程進度"
        End If
        Me.ID = ID
    End Sub

    Private Sub Set_WorkDetail_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClassCombo.SelectedIndex = 0
        If intMode = controller.EDIT_MODE Then
            Me.Hide()
            LoadingWork.RunWorkerAsync()
            statusForm.Show()
        End If
    End Sub

    Private Sub LoadingWork_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadingWork.DoWork
        Dim data As Set_WorkProgress_Model.WorkProgress = controller.SelectWorkProgress(ID)
        e.Result = data
    End Sub

    Private Sub LoadingWork_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadingWork.RunWorkerCompleted
        WPDateTime.Value = e.Result.WPDate
        ClassCombo.SelectedIndex = e.Result.WPClass
        ProdText.Text = e.Result.ProdName
        SpecificationText.Text = e.Result.Specification
        CountText.Text = e.Result.Count
        UnitText.Text = e.Result.Unit
        SupplierText.Text = e.Result.Supplier
        RemarkText.Text = e.Result.Remark
        statusForm.Dispose()
        Me.Show()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If intMode = controller.INSERT_MODE Then
            If controller.InsertWorkProgress(ID, WPDateTime.Value.Date, ClassCombo.SelectedIndex, ProdText.Text, SpecificationText.Text, If(CountText.Text = "", 0, CountText.Text), If(UnitText.Text = "", 0, UnitText.Text), SupplierText.Text, If(RemarkText.Text = "", 0, RemarkText.Text)) Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("新增錯誤，請重新啟動再嘗試")
            End If
        ElseIf intMode = controller.EDIT_MODE Then
            If controller.UpdateWorkProgress(ID, WPDateTime.Value.Date, ClassCombo.SelectedIndex, ProdText.Text, SpecificationText.Text, If(CountText.Text = "", 0, CountText.Text), If(UnitText.Text = "", 0, UnitText.Text), SupplierText.Text, If(RemarkText.Text = "", 0, RemarkText.Text)) Then
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("新增錯誤，請重新啟動再嘗試")
            End If
        End If

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub Text_Leave(sender As Object, e As EventArgs) Handles SpecificationText.TextChanged, SupplierText.TextChanged
        sender.Text = StrConv(sender.Text, VbStrConv.Narrow)
    End Sub

    Private Sub placeText_Enter(sender As Object, e As EventArgs) Handles SupplierText.Enter
        sender.ImeMode = ImeMode.OnHalf
    End Sub

    Private Sub Set_WorkProgress_Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class