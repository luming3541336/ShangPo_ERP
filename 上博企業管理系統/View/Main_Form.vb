
Imports MaterialSkin

Public Class Main_Form
    '主畫面讀取
    '   1.先去判斷先前使用者是否有設定"記住我"，並且有正確登入，如有，資料將會記錄在Application.log內
    '   2.判斷userIDText及passwordText是否有空，有的話將會顯示預設字樣
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.DARK
        skinManager.ColorScheme = New ColorScheme(Primary.Teal700, Primary.Teal700, Primary.Teal700, Accent.Teal700, TextShade.WHITE)
        FlowLayoutPanel1.BackColor = Color.FromArgb(150, 7, 80, 133)
        Try
            VerText.Text = Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Catch ex As Exception
            VerText.Text = "開發程式階段"
        End Try
        Timer1.Start()
        If readBoard = False Then
            BillBoardForm.Show()
        End If

    End Sub

    Private Sub VerText_Click(sender As Object, e As EventArgs) Handles VerText.Click
        BillBoardForm.Show()
        '        Panel1.stSetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = "現在時間:" & Format(Now, "HH:mm:ss")
        If Now.Hour < 8 Or Now.Hour > 18 Then
            NameLabel.Text = "晚安，" & UserName & Access
        ElseIf Now.Hour < 8 Or Now.Hour < 12 Then
            NameLabel.Text = "早安，" & UserName & Access
        Else
            NameLabel.Text = "午安，" & UserName & Access
        End If

    End Sub

    Private Sub RevisePasswordLabel_Click(sender As Object, e As EventArgs)
        Dim reviseForm As Set_PasswordRevise_Form = New Set_PasswordRevise_Form
        reviseForm.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class