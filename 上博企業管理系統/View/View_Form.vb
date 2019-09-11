Public Class View_Form
    Private userName As String = Nothing
    Private loginID As Integer = Nothing
    Private formName As String = Nothing
    Private toStatusForm As Status_Normal_Form = New Status_Normal_Form("啟動中")

    '  Public toPurchaseSaleView As Data_Case_View = Nothing

    Public Sub New(ByVal formName As String, ByVal userName As String, ByVal loginID As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()
        Me.userName = userName
        Me.loginID = loginID
        Me.formName = formName
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
    End Sub

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Visible = False
        'toStatusForm.Show()
        'Application.DoEvents()
        'If formName = "PurchaseSale" Then
        '    toPurchaseSaleView = New Data_Case_View(userName, loginID)
        '    mainTableLayout.Controls.Add(toPurchaseSaleView)
        '    Me.Text = "進出貨管理"
        '    toPurchaseSaleView.Dock = DockStyle.Fill
        'End If
    End Sub

    Private Sub ViewForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Visible = True
        toStatusForm.Dispose()
    End Sub

    Private Sub ViewForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = 13 Then
            SendKeys.Send(vbTab)
        End If
    End Sub
End Class