Public Class UserControl
    Dim a = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a = 0 Then
            FlowLayoutPanel2.Visible = True
            a = 1
        Else
            FlowLayoutPanel2.Visible = False
            a = 0
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel2.Visible = False
    End Sub
End Class
