Public Class Set_ReceiptKey_Form
    Private intCaseID As Integer = Nothing
    Private intReceiptID As Integer = Nothing
    Private controller As Set_ReceiptKey_Controller = New Set_ReceiptKey_Controller

    Public Sub New(ByVal intCaseID As Integer, Optional ByVal intReceiptID As Integer = Nothing)

        ' 設計工具需要此呼叫。
        InitializeComponent()c
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
            ArchiveDate.Text = Format(data.InsertDate)
            ContactText.Text = data.Contact
            PlaceText.Text = data.Place
            StatusText.Text = If(data.Status = 0, "尚未簽收", "簽收完成")
            Dim data2 As ReceiptKey = controller.Select_ReceiptKey(intReceiptID)
            ReceiptKeyDGV.Rows.Add()
        End If
    End Sub
End Class