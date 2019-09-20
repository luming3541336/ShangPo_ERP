Imports System.IO
Imports BespokeFusion
Imports MaterialSkin
Imports Microsoft.VisualBasic.FileIO

Public Class Login_Form
    Const USER_RECORD_FILE As String = "..\Log\Application.log"
    Private Sub Login_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '背景設置
        Dim skinManager = MaterialSkinManager.Instance
        skinManager.AddFormToManage(Me)
        skinManager.Theme = MaterialSkinManager.Themes.DARK
        skinManager.ColorScheme = New ColorScheme(Primary.Teal700, Primary.Teal700, Primary.Teal700, Accent.Teal700, TextShade.WHITE)

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

                RememberCheckBox.Checked = MemoryUser
                UserIDText.Text = UserID
                PasswordText.Text = Password
            Loop
        Else
            Directory.CreateDirectory("..\Log")
            Dim fs As FileStream = File.Create(USER_RECORD_FILE)
            fs.Close()
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim controller As Main_Controller = New Main_Controller
        Dim loginData As Data_User_Model.LoginData = controller.Select_User(UserIDText.Text, PasswordText.Text)
        If loginData.LoginID <> Nothing Then
            UserName = loginData.UserName
            Access = loginData.Access
            LoginID = loginData.LoginID
            L0 = loginData.L0
            L1 = loginData.L1
            L2 = loginData.L2
            L3 = loginData.L3
            L4 = loginData.L4
            L5 = loginData.L5
            L6 = loginData.L6
            '如果有按下記住我則將資料紀錄
            MemoryUser = RememberCheckBox.Checked
            UserID = UserIDText.Text
            Password = PasswordText.Text
            readBoard = readBoard
            If RememberCheckBox.Checked Then
                File.WriteAllText(USER_RECORD_FILE, "True ," & UserIDText.Text & "," & PasswordText.Text & "," & readBoard)
            Else
                File.WriteAllText(USER_RECORD_FILE, "False,,," & readBoard)
            End If
            Dim MainForm As Main_Form = New Main_Form
            Main_Form.Show()
            Me.Hide()
        Else
            ErrorLabel.Visible = True
        End If
    End Sub
End Class