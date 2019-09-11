Public Class Set_PasswordRevise_Form
    Private controller As Set_PasswordRevise_Controller = New Set_PasswordRevise_Controller
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        If OldPasswordText.Text = "" Then
            MsgBox("請輸入舊密碼")
        Else
            If controller.Confirm_Password(OldPasswordText.Text) Then
                If NewPasswordText.Text <> ReNewPasswordText.Text Then

                    MsgBox("新密碼核對錯誤，請重新確認新密碼是否輸入正確")
                Else
                    If NewPasswordText.Text = "" Then
                        MsgBox("新密碼不得為空白")
                    ElseIf controller.Update_Password(NewPasswordText.Text) Then
                        Dim result As MsgBoxResult = MsgBoxResult.Ok
                        MsgBox("密碼已更新")
                        Me.Close()
                    End If
                End If
            Else
                MsgBox("舊密碼不正確")
            End If
        End If
    End Sub
End Class