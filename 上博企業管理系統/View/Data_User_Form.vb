Public Class Data_User_Form
    Dim controller As Data_User_Controller = New Data_User_Controller
    Dim arrL() As String = {"L0", "L1", "L2", "L3", "L4", "L5", "L6"}
    Dim arrCheckBoxLx1 As CheckBox()
    Dim arrCheckBoxLx2 As CheckBox()
    Private Sub Data_User_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrCheckBoxLx1 = {L01, L11, L21, L31, L41, L51, L61} '讀取權限陣列
        arrCheckBoxLx2 = {L02, L12, L22, L32, L42, L52, L62} '修改權限陣列
    End Sub

    Private Sub LoginDGV_CurrentCellChanged(sender As Object, e As EventArgs) Handles LoginDGV.CurrentCellChanged
        If LoginDGV.CurrentRow IsNot Nothing Then
            UserNameText.Text = LoginDGV.CurrentRow.Cells("UserName").Value
            AccessText.Text = LoginDGV.CurrentRow.Cells("Access").Value
            UserIDText.Text = LoginDGV.CurrentRow.Cells("UserID").Value
            PasswordText.Text = LoginDGV.CurrentRow.Cells("Password").Value
            For i As Integer = 0 To arrL.Length - 1
                Select Case LoginDGV.CurrentRow.Cells(arrL(i)).Value
                    Case 0
                        arrCheckBoxLx1(i).Checked = False
                        arrCheckBoxLx1(i).Enabled = True
                        arrCheckBoxLx2(i).Enabled = False
                        arrCheckBoxLx2(i).Checked = False

                    Case 1
                        arrCheckBoxLx1(i).Checked = True
                        arrCheckBoxLx2(i).Checked = False
                        arrCheckBoxLx1(i).Enabled = True
                        arrCheckBoxLx2(i).Enabled = True
                    Case 2
                        arrCheckBoxLx1(i).Checked = True
                        arrCheckBoxLx2(i).Checked = True
                        If arrL(i) = "L3" Then 'L3X有提供管理級權限
                            L33.Enabled = True
                        End If
                    Case 3 '管理級權限資料 暫時限定只有"進出貨管理(L3X)使用
                        arrCheckBoxLx1(i).Checked = True
                        arrCheckBoxLx2(i).Checked = True
                        L33.Checked = True
                End Select
            Next
        End If

    End Sub

    Private Sub Data_User_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        For Each data As Data_User_Model.LoginData In controller.Select_LoginData()
            LoginDGV.Rows.Add(data.LoginID, data.UserName, data.Access, data.UserID, data.Password, data.L0, data.L1, data.L2, data.L3, data.L4, data.L5, data.L6)
        Next
    End Sub

    Private Sub L11_CheckedChanged(sender As Object, e As EventArgs) Handles L61.CheckedChanged, L51.CheckedChanged, L41.CheckedChanged, L31.CheckedChanged, L21.CheckedChanged, L11.CheckedChanged, L01.CheckedChanged
        If sender.checked = False Then
            arrCheckBoxLx2(Array.IndexOf(arrCheckBoxLx1, sender)).Checked = False
            arrCheckBoxLx2(Array.IndexOf(arrCheckBoxLx1, sender)).Enabled = False
            If sender.Name = "L31" Then
                L33.Checked = False
                L33.Enabled = False
            End If
        Else
            arrCheckBoxLx2(Array.IndexOf(arrCheckBoxLx1, sender)).Enabled = True
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        addBtn.Visible = False
        ReviseBtn.Visible = False
        DelBtn.Visible = False
        OKBtn.Visible = True
        CancelBtn.Visible = True
        T1.Enabled = True
        T2.Enabled = True
        LoginDGV.Enabled = False
        LoginDGV.Rows.Add()
        LoginDGV.CurrentCell = LoginDGV.Rows(LoginDGV.Rows.Count - 1).Cells(2)
        controller.Set_InsertMode()

    End Sub

    Private Sub ReviseBtn_Click(sender As Object, e As EventArgs) Handles ReviseBtn.Click
        addBtn.Visible = False
        ReviseBtn.Visible = False
        DelBtn.Visible = False
        OKBtn.Visible = True
        CancelBtn.Visible = True
        LoginDGV.Enabled = False
        T1.Enabled = True
        T2.Enabled = True
        controller.Set_ReviseMode()
        If UserIDText.Text = "Admin" Then
            UserIDText.Enabled = False
            L01.Enabled = False
            L02.Enabled = False
        End If
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        Dim arrLSave(7) As Integer
        For i = 0 To 6
            If arrCheckBoxLx1(i).Checked And arrCheckBoxLx2(i).Checked Then
                arrLSave(i) = 2
                If i = 3 And L33.Checked Then
                    arrLSave(i) = 3
                End If
            ElseIf arrCheckBoxLx1(i).Checked Then
                arrLSave(i) = 1
            Else
                arrLSave(i) = 0
            End If
        Next
        Select Case controller.Get_Mode
            Case Data_User_Model.INSERT_MODE
                Dim index As Integer = controller.Insert_LoginData(UserIDText.Text, PasswordText.Text, UserNameText.Text, AccessText.Text, arrLSave(0), arrLSave(1), arrLSave(2), arrLSave(3), arrLSave(4), arrLSave(5), arrLSave(6))
                LoginDGV.CurrentRow.Cells("LoginID").Value = index
            Case Data_User_Model.REVISE_MODE
                Dim index As Integer = controller.Update_LoginData(LoginDGV.CurrentRow.Cells("LoginID").Value, UserIDText.Text, PasswordText.Text, UserNameText.Text, AccessText.Text, arrLSave(0), arrLSave(1), arrLSave(2), arrLSave(3), arrLSave(4), arrLSave(5), arrLSave(6))
        End Select
        LoginDGV.CurrentRow.Cells("UserName").Value = UserNameText.Text
        LoginDGV.CurrentRow.Cells("Access").Value = AccessText.Text
        LoginDGV.CurrentRow.Cells("UserID").Value = UserIDText.Text
        LoginDGV.CurrentRow.Cells("Password").Value = PasswordText.Text
        LoginDGV.CurrentRow.Cells("L0").Value = arrLSave(0)
        LoginDGV.CurrentRow.Cells("L1").Value = arrLSave(1)
        LoginDGV.CurrentRow.Cells("L2").Value = arrLSave(2)
        LoginDGV.CurrentRow.Cells("L3").Value = arrLSave(3)
        LoginDGV.CurrentRow.Cells("L4").Value = arrLSave(4)
        LoginDGV.CurrentRow.Cells("L5").Value = arrLSave(5)
        LoginDGV.CurrentRow.Cells("L6").Value = arrLSave(6)
        addBtn.Visible = True
        ReviseBtn.Visible = True
        DelBtn.Visible = True
        OKBtn.Visible = False
        CancelBtn.Visible = False
        LoginDGV.Enabled = True
        T1.Enabled = False
        T2.Enabled = False
        controller.Set_NormalMode()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If controller.Get_Mode = Data_User_Model.INSERT_MODE Then
            LoginDGV.Rows.RemoveAt(LoginDGV.CurrentCell.RowIndex)
        End If
        UserNameText.Text = LoginDGV.CurrentRow.Cells("UserName").Value
        AccessText.Text = LoginDGV.CurrentRow.Cells("Access").Value
        UserIDText.Text = LoginDGV.CurrentRow.Cells("UserID").Value
        PasswordText.Text = LoginDGV.CurrentRow.Cells("Password").Value
        addBtn.Visible = True
        ReviseBtn.Visible = True
        DelBtn.Visible = True
        OKBtn.Visible = False
        CancelBtn.Visible = False
        LoginDGV.Enabled = True
        T1.Enabled = False
        T2.Enabled = False
        controller.Set_NormalMode()
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Select Case MsgBox("是否確認刪除此帳戶，刪除後將無法復原", vbOKCancel, "注意")
            Case MsgBoxResult.Ok
                controller.Del_LoginData(LoginDGV.CurrentRow.Cells("LoginID").Value)
                LoginDGV.Rows.RemoveAt(LoginDGV.CurrentRow.Index)
        End Select
    End Sub

    Private Sub L32_CheckedChanged(sender As Object, e As EventArgs) Handles L32.CheckedChanged
        If L32.Checked Then
            L33.Enabled = True
        Else
            L33.Enabled = False
        End If
    End Sub
End Class