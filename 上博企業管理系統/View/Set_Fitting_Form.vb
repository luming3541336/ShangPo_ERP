Imports System.Data.SqlClient

Public Class Set_Fitting_Form
    Private SuID As Integer = Nothing '供應商流水號
    Private SuName As String = Nothing ' 供應商名稱
    Private FittingState As Boolean = Nothing 'False:選配;True:配件
    Public FitArrayIndex As Integer = Nothing '當確認後，將確認的FittingSet的Index放置此
    Private FittingSetArray As ArrayList = New ArrayList '將FittingSet 資料庫內與SuID及FittingState配對的資料
    Public SelectedFitID As Integer = Nothing ' 目前選擇的配件ID
    Private EditFitComboIndex As Integer = -1
    Private conDB As DBController = New DBController

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Public Sub New(ByVal ID As Integer, ByVal Name As String, ByVal State As Boolean, ByRef FittingSetArray As ArrayList)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        SuID = ID
        SuName = Name
        FittingState = State
        Me.FittingSetArray = FittingSetArray
    End Sub
    Private Sub AddFitting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SupplierText.Text = SuName
        Dim i As Integer = 0 '目前顯示的index
        For Each buf As FittingSet In FittingSetArray

            FittingCombo.Items.Add("(" & buf.Number & ")" & buf.Name)
        Next

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If FittingCombo.SelectedIndex > -1 Then
            Me.DialogResult = DialogResult.OK
            FitArrayIndex = FittingCombo.SelectedIndex
        Else
            MsgBox("請選擇配件", vbOKOnly, "注意")
        End If

    End Sub

    Private Sub AddFittingBtn_Click(sender As Object, e As EventArgs) Handles AddFittingBtn.Click
        Dim con As Connection = New Connection
        Dim strSQL As String = "INSERT INTO FittingSet(SuID) VALUES (@suID); Select @@IDENTITY As 'FitID';"
        strSQL = strSQL.Replace("@suID", SuID)
        Dim DataReader As SqlDataReader = con.ExecuteSQL(strSQL).ExecuteReader
        If DataReader.HasRows Then
            Do While DataReader.Read
                FittingSetArray.Add(New FittingSet(DataReader("FitID"), SuID, "<<未設定>>", Nothing, Nothing))
            Loop
        End If
        conDB.Close()
        FittingCombo.Items.Add("<<未設定>>")
        FittingSetArray.Add(FittingSetArray.Count - 1)
        FittingCombo.SelectedIndex = FittingCombo.Items.Count - 1
    End Sub

    Private Sub FittingCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FittingCombo.SelectedIndexChanged
        If FittingCombo.SelectedIndex <> -1 Then
            EditFitComboIndex = FittingCombo.SelectedIndex
            SelectedFitID = FittingSetArray(FittingCombo.SelectedIndex).FitID
            NameText.Text = FittingSetArray(FittingCombo.SelectedIndex).Name
            NumberText.Text = FittingSetArray(FittingCombo.SelectedIndex).Number
            SpecificationText.Text = FittingSetArray(FittingCombo.SelectedIndex).Specification
        End If
    End Sub

    Private Sub Text_Leave(sender As Object, e As EventArgs) Handles SpecificationText.Leave, NumberText.Leave, NameText.Leave
        Dim con As Connection = New Connection
        Dim DataReader As Integer
        If EditFitComboIndex > -1 Then
            Select Case sender.Name
                Case "SpecificationText"
                    DataReader = con.ExecuteSQL("UPDATE FittingSet Set Specification = N'" & SpecificationText.Text & "' WHERE FitID = " & SelectedFitID).ExecuteNonQuery
                    FittingSetArray(FittingSetArray(EditFitComboIndex)).Specification = SpecificationText.Text
                Case "NumberText"
                    DataReader = con.ExecuteSQL("UPDATE FittingSet Set Number = N'" & NumberText.Text & "' WHERE FitID = " & SelectedFitID).ExecuteNonQuery
                    FittingSetArray(FittingSetArray(EditFitComboIndex)).Number = NumberText.Text
                    FittingCombo.Items(EditFitComboIndex) = "(" & NumberText.Text & ")" & NameText.Text
                Case "NameText"
                    DataReader = con.ExecuteSQL("UPDATE FittingSet Set Name = N'" & NameText.Text & "' WHERE FitID = " & SelectedFitID).ExecuteNonQuery
                    FittingSetArray(FittingSetArray(EditFitComboIndex)).Name = NameText.Text
                    FittingCombo.Items(EditFitComboIndex) = "(" & NumberText.Text & ")" & NameText.Text
            End Select
        End If
        conDB.Close()

        If FittingCombo.SelectedIndex = -1 Then
            FittingCombo.SelectedIndex = EditFitComboIndex
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub
End Class