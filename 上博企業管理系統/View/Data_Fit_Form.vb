Imports System.Data.SqlClient
Public Class Data_Fit_Form
    'Private SuID As Integer = Nothing '廠商ID
    'Private SupplierName As String = Nothing '廠商名稱
    'Private conDB As DBController = New DBController
    'Private addState As Boolean = False
    'Private reviseState As Boolean = False
    Private controller As Data_Fit_Controller = New Data_Fit_Controller
    Public Sub New(ByVal SuID As Integer, ByVal SupplierName As String)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        'Me.SuID = SuID
        'Me.SupplierName = SupplierName
        controller.Set_Default(SuID, SupplierName)
    End Sub
    Private Sub FittingSetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SupplierText.Text = controller.Get_SupplierName
        Dim dataList As List(Of Data_Fit_Model.FittingSet) = New List(Of Data_Fit_Model.FittingSet)
        dataList = controller.Load_FittingSet
        For Each data As Data_Fit_Model.FittingSet In dataList
            FittingDataGrid.Rows.Add(data.FitID, data.Name, data.Number, data.Specification)
        Next
    End Sub

    Private Sub Radio_Click(sender As Object, e As EventArgs)
        FittingDataGrid.Rows.Clear()
        'Dim dataList As List(Of FittingSetModel.FittingSet) = New List(Of FittingSetModel.FittingSet)
        'dataList = controller.Load_FittingSet
        'For Each data As FittingSetModel.FittingSet In dataList
        '    FittingDataGrid.Rows.Add(data.FitID, data.Name, data.Number, data.Specification)
        'Next
        'conDB._select({"*"}, "FittingSet")
        'conDB._where("SuID", SuID, "AND")
        'conDB._where("IfOptional", IIf(sender.Name = "OptionalRadio", 1, 0), Nothing)
        'Dim DataReader As SqlDataReader = conDB.toSelect.ExecuteReader
        'If DataReader.HasRows Then
        '    Do While DataReader.Read
        '        FittingDataGrid.Rows.Add(DataReader("FitID"), DataReader("Name"), DataReader("Number"), DataReader("Specification"))
        '    Loop
        'End If
        'conDB.Close()
    End Sub

    Private Sub FittingDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FittingDataGrid.CellClick

    End Sub

    Private Sub Text_Leave(sender As Object, e As EventArgs) Handles SpecificationText.Leave, NumberText.Leave, NameText.Leave
        'conDB._update("FittingSet")
        Select Case sender.Name
            Case "SpecificationText"
                'conDB._set("Specification", SpecificationText.Text)
                controller.Revise_Specification_To_SQL(SpecificationText.Text, FittingDataGrid.CurrentRow.Cells("FitID").Value)
                FittingDataGrid.CurrentRow.Cells("Specification").Value = SpecificationText.Text
            Case "NumberText"
                ' conDB._set("Number", NumberText.Text)
                controller.Revise_Number_To_SQL(NumberText.Text, FittingDataGrid.CurrentRow.Cells("FitID").Value)
                FittingDataGrid.CurrentRow.Cells("Number").Value = NumberText.Text
            Case "NameText"
                'conDB._set("Name", NameText.Text)
                controller.Revise_Name_To_SQL(NameText.Text, FittingDataGrid.CurrentRow.Cells("FitID").Value)
                FittingDataGrid.CurrentRow.Cells("FitName").Value = NameText.Text
        End Select
        'conDB._where("FitID", FittingDataGrid.CurrentRow.Cells("FitID").Value, Nothing)
        'Dim DataReader As Integer = conDB.toUpdate.ExecuteNonQuery
        'conDB.Close()
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        'conDB._insert("FittingSet", {"SuID", "IfOptional"})
        'conDB._value({SuID, If(OptionalRadio.Checked, 1, 0)})
        'Dim DataReader As SqlDataReader = conDB.toInsert("FitID").ExecuteReader
        Dim intFitID As Integer = Nothing
        intFitID = controller.Add_FittingSet("", "", "")
        If intFitID Then
            FittingDataGrid.Rows.Add(intFitID, "")
        End If
        FittingDataGrid.CurrentCell = FittingDataGrid.Rows(FittingDataGrid.RowCount - 1).Cells(1)
        controller.Set_AddMode()
        'If DataReader.HasRows Then
        '    Do While DataReader.Read
        '        FittingDataGrid.Rows.Add(DataReader("FitID"))
        '    Loop
        '    FittingDataGrid.CurrentCell = FittingDataGrid.Rows(FittingDataGrid.RowCount - 1).Cells(1)
        'End If
        'conDB.Close()
        NameText.Enabled = True
        NumberText.Enabled = True
        SpecificationText.Enabled = True
        'addState = True
    End Sub
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim msg As MsgBoxResult = MsgBox("確定要刪除嗎?若資料有被產品設定，就無法刪除。", vbOKCancel, "注意")
        Select Case msg
            Case MsgBoxResult.Ok
                Try
                    'conDB._delete("FittingSet")
                    'conDB._where("FitID", FittingDataGrid.CurrentRow.Cells(0).Value, Nothing)
                    Dim DataReader As Integer = controller.Del_FittingSet(FittingDataGrid.CurrentRow.Cells("FitID").Value)
                    If DataReader Then
                        MsgBox("刪除成功", vbOKOnly, "注意")
                        FittingDataGrid.Rows.Remove(FittingDataGrid.CurrentRow)
                    Else
                        MsgBox("無法刪除", vbOKOnly, "注意")
                    End If
                Catch ex As SqlException
                    MsgBox("無法刪除", vbOKOnly, "注意")
                End Try
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub reviseBtn_Click(sender As Object, e As EventArgs) Handles reviseBtn.Click
        NameText.Enabled = True
        NumberText.Enabled = True
        SpecificationText.Enabled = True
        'reviseState = True
        controller.Set_ReviseMode()
    End Sub

    Private Sub FittingDataGrid_CurrentCellChanged(sender As Object, e As EventArgs) Handles FittingDataGrid.CurrentCellChanged
        If controller.Get_Mode <> Data_Fit_Model.VIEW_MODE Then
            NameText.Enabled = False
            NumberText.Enabled = False
            SpecificationText.Enabled = False
            controller.Set_ViewMode()
        End If
        If FittingDataGrid.CurrentRow IsNot Nothing Then
            NameText.Text = FittingDataGrid.CurrentRow.Cells("FitName").Value
            NumberText.Text = FittingDataGrid.CurrentRow.Cells("Number").Value
            SpecificationText.Text = FittingDataGrid.CurrentRow.Cells("Specification").Value
        End If

    End Sub
End Class