Public Class Status_Normal_Form
    Public Sub New(status As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        statusText.Text = status
    End Sub
    Public Sub updateStatus(ByVal status As String)
        statusText.Text = status
    End Sub
End Class