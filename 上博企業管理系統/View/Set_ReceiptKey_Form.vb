Public Class Set_ReceiptKey_Form
    Private intCaseID As Integer = Nothing
    Private intReceiptID As Integer = Nothing

    Public Sub New(ByVal intCaseID As Integer, Optional ByVal intReceiptID As Integer = Nothing)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.intCaseID = intCaseID
        If intReceiptID <> Nothing Then
            Me.intReceiptID = intReceiptID
        End If

    End Sub
End Class