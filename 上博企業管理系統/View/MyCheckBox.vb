

Public Class MyCheckBox
    Inherits CheckBox

    Private components As System.ComponentModel.IContainer

    Public Sub MyCheckBox()
        TextAlign = ContentAlignment.MiddleRight
    End Sub
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = False
        End Set
    End Property
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        Dim h As Integer = ClientSize.Height - 2
        Dim rc As Rectangle = New Rectangle(New Point(0, 1), New Size(h, h))
        ControlPaint.DrawCheckBox(pevent.Graphics, rc, If(Checked, ButtonState.Checked, ButtonState.Normal))
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
