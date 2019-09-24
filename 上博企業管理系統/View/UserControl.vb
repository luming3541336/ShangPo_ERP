Public Class UserControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel1.Visible Then
            Panel1.Visible = False
            sender.imageIndex = 1
        Else
            Panel1.Visible = True
            sender.imageIndex = 0
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel2.Visible Then
            Panel2.Visible = False
            sender.imageIndex = 1
        Else
            Panel2.Visible = True
            sender.imageIndex = 0
        End If

    End Sub

    Private Sub UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(50, Color.SlateGray)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Panel3.Visible Then
            Panel3.Visible = False
            sender.imageIndex = 1
        Else
            Panel3.Visible = True
            sender.imageIndex = 0
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Panel4.Visible Then
            Panel4.Visible = False
            sender.imageIndex = 1
        Else
            Panel4.Visible = True
            sender.imageIndex = 0
        End If

    End Sub
End Class
