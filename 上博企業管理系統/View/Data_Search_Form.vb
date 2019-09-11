Public Class Data_Search_Form
    Public strSQL As String = Data_Search_Model.SELECT_CASEDATA_STATEMENT_SQL
    Private Sub startTime_CloseUp(sender As Object, e As EventArgs) Handles StartTime.CloseUp, EndTime.CloseUp
        sender.Format = DateTimePickerFormat.Short
    End Sub
    Private Sub endTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StartTime.KeyPress, EndTime.KeyPress
        If e.KeyChar = vbBack Then
            sender.Format = DateTimePickerFormat.Custom
        End If
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click

        strSQL = strSQL.Replace("@place", PlaceText.Text)
        strSQL = strSQL.Replace("@caseNo", CaseNoText.Text)
        strSQL = strSQL.Replace("@state", StateCombo.SelectedIndex)
        strSQL = strSQL.Replace("@phone", PhoneText.Text)
        strSQL = strSQL.Replace("@address", AddressText.Text)
        strSQL = strSQL.Replace("@salesName", SalesTest.Text)
        If StartTime.Format <> DateTimePickerFormat.Custom And EndTime.Format <> DateTimePickerFormat.Custom Then
            strSQL = strSQL.Replace("@time", " AND InsertTime > '@startTime' AND InsertTime < '@endTime' ")
            strSQL = strSQL.Replace("@startTime", Format(CDate(StartTime.Value), "yyyy/MM/dd"))
            strSQL = strSQL.Replace("@endTime", Format(CDate(EndTime.Value), "yyyy/MM/dd"))
        Else
            strSQL = strSQL.Replace("@time", "")
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Data_Search_Form_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            OKBtn_Click(sender, e)
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub StateCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StateCombo.SelectedIndexChanged

    End Sub

    Private Sub Data_Search_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class