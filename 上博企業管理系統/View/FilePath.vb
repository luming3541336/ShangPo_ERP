Public Class FilePath
    Private RepairForm As Object
    Private FilePath As String
    Private FileID As Integer = 0
    Public Sub New(ByRef RepairForm As Object, ByVal FileName As String, FilePath As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()
        Me.RepairForm = RepairForm
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        FileNameText.Text = FileName
        Dim arrFileName As String() = FileName.Split(".")
        Select Case arrFileName(1)
            Case "pdf"
                Label1.ImageIndex = 0
            Case "jpg"
                Label1.ImageIndex = 1
        End Select
        Me.FilePath = FilePath
    End Sub
    Public Sub New(ByVal ID As Integer, ByRef RepairForm As Object, ByVal FileName As String, FilePath As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()
        Me.RepairForm = RepairForm
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        FileNameText.Text = FileName
        Dim arrFileName As String() = FileName.Split(".")
        Select Case arrFileName(1)
            Case "pdf"
                Label1.ImageIndex = 0
            Case "jpg"
                Label1.ImageIndex = 1
        End Select
        Me.FilePath = FilePath
        FileID = ID
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RepairForm.RemoveControl(Me)
    End Sub
    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles FileNameText.MouseEnter, Label1.MouseEnter
        Button1.Visible = True
        FileNameText.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub FlowLayoutPanel1_MouseLeave(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.MouseLeave, FileNameText.MouseLeave, Button1.MouseLeave, Label1.MouseLeave
        If Me.ClientRectangle.Contains(Me.PointToClient(Control.MousePosition)) Then
            Return
        Else
            Button1.Visible = False
            FileNameText.ForeColor = SystemColors.Control
        End If
    End Sub
    Public Function Get_FileID() As Integer
        Return FileID
    End Function
    Public Function Get_Path() As String
        Return FilePath
    End Function
    Public Function Get_FileName() As String
        Return FileNameText.Text
    End Function

    Private Sub FileNameText_Click(sender As Object, e As EventArgs) Handles FileNameText.Click
        Process.Start(FilePath)
    End Sub
End Class
