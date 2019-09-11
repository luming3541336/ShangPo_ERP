Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Main_Form
    Const USER_RECORD_FILE As String = "..\Log\Application.log"
    Private oOriginalRegion As Region = Nothing
    Private bFormDragging As Boolean = False
    Private oPointClicked As Point
    Private conDB As DBController = New DBController

    '主畫面讀取
    '   1.先去判斷先前使用者是否有設定"記住我"，並且有正確登入，如有，資料將會記錄在Application.log內
    '   2.判斷userIDText及passwordText是否有空，有的話將會顯示預設字樣
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            VerText.Text = Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Catch ex As Exception
            VerText.Text = "開發程式階段"
        End Try


        If Not conDB.ConTry Then
            MsgBox("連線錯誤，請通知管理員")
        End If
        '使用者如有按下"記住我"按鈕將會讀取資料
        If File.Exists(USER_RECORD_FILE) Then
            Dim fileReader As TextFieldParser = New TextFieldParser(USER_RECORD_FILE) With {
                .TextFieldType = FieldType.Delimited
            }
            fileReader.SetDelimiters(",")
            Dim currentRow As String()
            Do While Not fileReader.EndOfData
                currentRow = fileReader.ReadFields()
                MemoryUser = currentRow(0)
                UserID = currentRow(1)
                Password = currentRow(2)
                readBoard = currentRow(3)

                recordCheckBox.Checked = MemoryUser
                userIDText.Text = UserID
                passwordText.Text = Password
            Loop
        Else
            Directory.CreateDirectory("..\Log")
            Dim fs As FileStream = File.Create(USER_RECORD_FILE)
            fs.Close()
        End If
        If userIDText.Text = "" Then
            userIDText.Text = "使用者帳號"
            userIDText.ForeColor = Color.Silver
        End If
        If passwordText.Text = "" Then
            passwordText.Text = "使用者密碼"
            passwordText.ForeColor = Color.Silver
        End If

    End Sub

    Private Sub userIDText_Enter(sender As Object, e As EventArgs) Handles userIDText.Enter, passwordText.Enter
        sender.text = ""
        sender.ForeColor = Color.Black
    End Sub

    Private Sub userIDText_Leave(sender As Object, e As EventArgs) Handles userIDText.Leave, passwordText.Leave
        If sender.text = "" Then
            sender.Text = IIf(sender.name = "userIDText", "使用者帳號", "使用者密碼")
            sender.ForeColor = Color.Silver
        End If
    End Sub
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        conDB._select({"*"}, "LoginData")
        conDB._where("UserID", userIDText.Text, "AND")
        conDB._where("Password", passwordText.Text, Nothing)
        Dim dataReader As SqlDataReader = conDB.toSelect.ExecuteReader

        If dataReader.HasRows Then
            dataReader.Read()
            UserName = dataReader("UserName")
            Access = dataReader("Access")
            LoginID = dataReader("LoginID")
            L0 = dataReader("L0")
            L1 = dataReader("L1")
            L2 = dataReader("L2")
            L3 = dataReader("L3")
            L4 = dataReader("L4")
            L5 = dataReader("L5")
            L6 = dataReader("L6")
            Dim userControl As List_Control_View = New List_Control_View()
            Timer1.Start()
            RevisePasswordLabel.Visible = True
            MainPanel.Controls.Add(userControl)
            userControl.Show()
            If readBoard = False Then
                BillBoardForm.Show()
            End If
            userControl.Dock = DockStyle.Bottom
            loginTableLayout.Hide()
            '如果有按下記住我則將資料紀錄
            MemoryUser = recordCheckBox.Checked
            UserID = userIDText.Text
            Password = passwordText.Text
            readBoard = readBoard
            If recordCheckBox.Checked Then
                File.WriteAllText(USER_RECORD_FILE, "True ," & userIDText.Text & "," & passwordText.Text & "," & readBoard)
            Else
                File.WriteAllText(USER_RECORD_FILE, "False,,," & readBoard)
            End If
        Else
            MsgBox("帳號或密碼錯誤")
        End If
    End Sub

    Private Sub passwordText_TextChanged(sender As Object, e As EventArgs) Handles passwordText.TextChanged
        If passwordText.Text = "使用者密碼" Then
            passwordText.PasswordChar = Nothing
        Else
            passwordText.PasswordChar = "*"
        End If
    End Sub

    Private Sub VerText_Click(sender As Object, e As EventArgs) Handles VerText.Click
        BillBoardForm.Show()
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

    Private Sub RevisePasswordLabel_Click(sender As Object, e As EventArgs) Handles RevisePasswordLabel.Click
        Dim reviseForm As Set_PasswordRevise_Form = New Set_PasswordRevise_Form
        reviseForm.ShowDialog()

    End Sub
End Class