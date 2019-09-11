Imports System.Data.SqlClient

Public Class Set_Case_Form
    Private Const INSERT_MODE As Integer = 0
    Private Const EDIT_MODE As Integer = 1
    Private Const REVIEW_MODE As Integer = 2
    Private userName As String = Nothing
    Private intMode As Integer = 0
    Public caseID As String = Nothing
    Private conDB As Connection = New Connection
    Private statusForm As Status_Normal_Form = New Status_Normal_Form("載入中")
    Private loginData As List(Of Integer) = New List(Of Integer)
    Public Sub New(ByVal userName As String)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.userName = userName
    End Sub
    Public Sub New(ByVal caseID As Integer, ByVal mode As Integer)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        If mode = 1 Then
            intMode = EDIT_MODE
            TitleLabel.Text = "編輯案件"
            Lock_Form(False)
        ElseIf mode = 2 Then
            intMode = REVIEW_MODE
            Lock_Form(True)
            TitleLabel.Text = "預覽案件"
            saveBtn.Visible = False
        End If
        Me.caseID = caseID
    End Sub
    Private Function SelectCase(ByVal caseID As Integer) As String()
        Dim strData As String() = Nothing
        Dim SQL As String = "SELECT CaseData.CaseNo, CaseData.Place, CaseData.SalesName, LoginData.UserName, Contact, Address, Phone,Remark FROM CaseData,LoginData WHERE CaseID = @caseID AND LoginData.LoginID = CaseData.LoginID"
        SQL = SQL.Replace("@caseID", caseID)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(SQL).ExecuteReader
        If dataReader.HasRows Then
            Do While dataReader.Read()
                strData = New String() {dataReader("CaseNo"), dataReader("Place"), dataReader("SalesName"), dataReader("UserName"), dataReader("Contact"), dataReader("Address"), dataReader("Phone"), dataReader("Remark")}
            Loop
        End If
        Return strData
    End Function
    Private Function createCaseNo() As String
        Dim dateStr As String = DateTime.Now.AddYears(-1911).Year & Format(DateTime.Now, "MM")
        Dim SQL As String = "SELECT COUNT(CaseNo)  FROM CaseData WHERE CaseNo LIKE '@dateStr%'"
        SQL = SQL.Replace("@dateStr", dateStr)
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(SQL).ExecuteReader
        If dataReader.HasRows Then
            dataReader.Read()
            Return dateStr & "-" & Format(dataReader(0) + 1, "000")
        End If
        Return "連線錯誤"
    End Function

    Private Sub createCaseNoWork_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles createCaseNoWork.DoWork
        Dim UserNameArray As List(Of String) = LoadUser()
        If intMode = INSERT_MODE Then
            e.Result = {createCaseNo(), UserNameArray}
        ElseIf intMode = EDIT_MODE Or intMode = REVIEW_MODE Then
            e.Result = {SelectCase(caseID), UserNameArray}
        End If

    End Sub

    Private Sub createCaseNoWork_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles createCaseNoWork.RunWorkerCompleted
        For Each data As String In e.Result(1)
            UserNameCombo.Items.Add(data)
        Next
        If intMode = INSERT_MODE Then
            caseIDText.Text = e.Result(0)
            UserNameCombo.SelectedItem = userName
        ElseIf intMode = EDIT_MODE Or intMode = REVIEW_MODE Then
            Dim strCaseArray As String() = e.Result(0)
            caseIDText.Text = strCaseArray(0)
            placeText.Text = strCaseArray(1)
            SalesCB.Text = strCaseArray(2)
            UserNameCombo.SelectedItem = strCaseArray(3)
            ContactText.Text = strCaseArray(4)
            AddressText.Text = strCaseArray(5)
            PhoneText.Text = strCaseArray(6)
            RemarkText.Text = strCaseArray(7)
        End If


        conDB.close()
        statusForm.Dispose()
        Me.Show()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        If intMode = INSERT_MODE Then
            Dim SQL As String = "INSERT INTO CaseData(CaseNo,Place,LoginID,SalesName,Contact,Address,Phone,Remark) VALUES (N'@caseNoText',N'@placeText','@loginID',N'@salesNameText',N'@contact',N'@address','@phone','@remark')"
            If caseIDText.Text = "" Or placeText.Text = "" Or SalesCB.Text = "" Then
                MsgBox("有欄位尚未填寫，請確實填寫", , "警告")
            Else
                caseID = caseIDText.Text
                SQL = SQL.Replace("@caseNoText", caseIDText.Text)
                SQL = SQL.Replace("@placeText", placeText.Text)
                SQL = SQL.Replace("@loginID", loginData(UserNameCombo.SelectedIndex))
                SQL = SQL.Replace("@salesNameText", SalesCB.Text)
                SQL = SQL.Replace("@contact", ContactText.Text)
                SQL = SQL.Replace("@address", AddressText.Text)
                SQL = SQL.Replace("@phone", PhoneText.Text)
                SQL = SQL.Replace("@remark", RemarkText.Text)
                Dim dataReader As Integer = conDB.ExecuteSQL(SQL).ExecuteNonQuery
                If dataReader <> 1 Then
                    MsgBox("OOPS有地方錯誤了")
                End If
                Me.DialogResult = DialogResult.OK
            End If
        ElseIf intMode = EDIT_MODE Then
            Dim SQL As String = "UPDATE CaseData SET Place = N'@place', LoginID = @loginID, SalesName = N'@salesName',Contact = N'@contact', Address = N'@address', Phone = '@phone', UpdateTime = GetDate(), Remark = '@remark' WHERE CaseID = @caseID"
            SQL = SQL.Replace("@place", placeText.Text)
            SQL = SQL.Replace("@salesName", SalesCB.Text)
            SQL = SQL.Replace("@caseID", caseID)
            SQL = SQL.Replace("@loginID", loginData(UserNameCombo.SelectedIndex))
            SQL = SQL.Replace("@contact", ContactText.Text)
            SQL = SQL.Replace("@address", AddressText.Text)
            SQL = SQL.Replace("@phone", PhoneText.Text)
            '判斷字串使否有SQL保留字，若有加一個'處理
            Dim sRemark = RemarkText.Text
            If sRemark <> Nothing Then
                sRemark = sRemark.Replace("'", "''")
            End If
            SQL = SQL.Replace("@remark", sRemark)
            Dim dataReader As Integer = conDB.ExecuteSQL(SQL).ExecuteNonQuery
            If dataReader <> 1 Then
                MsgBox("OOPS有地方錯誤了")
            End If
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub AddCaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        statusForm.Show()
        createCaseNoWork.RunWorkerAsync()
    End Sub
    '取得負責人資料
    Private Function LoadUser() As List(Of String)
        Dim strSQL As String = "SELECT LoginID, UserName FROM LoginData"
        Dim dataReader As SqlDataReader = conDB.ExecuteSQL(strSQL).ExecuteReader
        Dim dataArray As List(Of String) = New List(Of String)
        If dataReader.HasRows Then
            Do While dataReader.Read
                loginData.Add(dataReader("LoginID"))
                dataArray.Add(dataReader("UserName"))
            Loop
        End If
        Return dataArray
    End Function
    Private Sub Lock_Form(ByVal bol As Boolean)
        If bol Then
            UserNameCombo.Enabled = False
            SalesCB.Enabled = False
            placeText.Enabled = False
            ContactText.Enabled = False
            PhoneText.Enabled = False
            AddressText.Enabled = False
            RemarkText.Enabled = False
        ElseIf Not bol Then
            UserNameCombo.Enabled = True
            SalesCB.Enabled = True
            placeText.Enabled = True
            ContactText.Enabled = True
            PhoneText.Enabled = True
            AddressText.Enabled = True
            RemarkText.Enabled = True
        End If
    End Sub

    Private Sub Set_Case_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If intMode = REVIEW_MODE Then
            If e.KeyCode = 27 Then
                Me.DialogResult = DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub Text_Leave(sender As Object, e As EventArgs) Handles placeText.TextChanged, PhoneText.TextChanged, ContactText.TextChanged, AddressText.TextChanged
        sender.Text = StrConv(sender.Text, VbStrConv.Narrow)
    End Sub

    Private Sub PhoneText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PhoneText.KeyPress
        Dim strlimit As String = "1234567890-#"
        If InStr(strlimit, e.KeyChar) <> 0 Or e.KeyChar = ChrW(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub placeText_Enter(sender As Object, e As EventArgs) Handles placeText.Enter, ContactText.Enter, AddressText.Enter
        sender.ImeMode = ImeMode.OnHalf
    End Sub
End Class