
Imports MaterialSkin

Public Class Main_Form
    Private arrConfirm As List(Of RepairData) = Nothing
    '主畫面讀取
    '   1.先去判斷先前使用者是否有設定"記住我"，並且有正確登入，如有，資料將會記錄在Application.log內
    '   2.判斷userIDText及passwordText是否有空，有的話將會顯示預設字樣
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim skinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.DARK
        skinManager.ColorScheme = New ColorScheme(Primary.Teal700, Primary.Teal700, Primary.Teal700, Accent.Teal700, TextShade.WHITE)
        Try
            VerText.Text = Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Catch ex As Exception
            VerText.Text = "開發程式階段"
        End Try
        Timer1.Start()
        If L3 = 3 Then
            Timer2.Start()
            ConfirmBGW.RunWorkerAsync()
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
        'If Label2.ForeColor = Color.Black Then
        '    Label2.ForeColor = Color.Red
        'Else
        '    Label2.ForeColor = Color.Black
        'End If
    End Sub

    Private Sub RevisePasswordLabel_Click(sender As Object, e As EventArgs)
        Dim reviseForm As Set_PasswordRevise_Form = New Set_PasswordRevise_Form
        reviseForm.ShowDialog()
    End Sub

    Private Sub Main_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ConfirmBGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ConfirmBGW.DoWork
        Dim controller As Main_Controller = New Main_Controller
        If arrConfirm IsNot Nothing Then
            arrConfirm.Clear()
        End If

        arrConfirm = controller.Select_RepairStatus

    End Sub
    Private Sub link_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim view As Set_Repair_Form = New Set_Repair_Form(arrConfirm(sender.Name).CaseID, arrConfirm(sender.Name).RepairID)
        If view.ShowDialog() = DialogResult.OK Then
            ConfirmPanel.Controls.Remove(sender)
        End If

    End Sub

    Private Sub ConfirmBGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ConfirmBGW.RunWorkerCompleted
        Dim i As Integer = 0
        ConfirmPanel.Controls.Clear()
        If arrConfirm Is Nothing Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
            For Each data As RepairData In arrConfirm
                Dim link As LinkLabel = New LinkLabel
                link.Name = i
                link.Text = data.RepairOrder
                link.AutoSize = True
                AddHandler link.Click, AddressOf link_Click
                ConfirmPanel.Controls.Add(link)
            Next
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ConfirmBGW.RunWorkerAsync()
    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub

    Private Sub Main_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If readBoard = False Then
            BillBoardForm.Show()
        End If
    End Sub
End Class