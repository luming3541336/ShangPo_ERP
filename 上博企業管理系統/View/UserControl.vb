Public Class UserControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel1.Visible Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel2.Visible Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If

    End Sub

    Private Sub UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(50, Color.SlateGray)
    End Sub
End Class
