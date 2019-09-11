Imports System.IO

Public Class BillBoardForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Const USER_RECORD_FILE As String = "..\Log\Application.log"
        File.WriteAllText(USER_RECORD_FILE, MemoryUser & "," & UserID & "," & Password & "," & "True")
        Me.Close()
    End Sub
End Class