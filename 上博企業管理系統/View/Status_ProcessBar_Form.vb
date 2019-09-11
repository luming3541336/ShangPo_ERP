Public Class Status_ProcessBar_Form
    Public Sub New(ByVal strText As String, ByVal barMax As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        statusText.Text = strText
        statusBar.Maximum = barMax
    End Sub
    Public Sub Set_Name(ByVal text As String)
        statusText.Text = text
    End Sub
    Public Sub Set_BarMaxi(ByVal i As Integer)
        statusBar.Maximum = i
    End Sub
    Public Sub addProcess()
        statusBar.PerformStep()
    End Sub
End Class