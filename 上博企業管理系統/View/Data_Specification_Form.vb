Imports 上博企業管理系統.Data_Specification_Model

Public Class Data_Specification_Form
    Private Const LOAD_SUPPLIER As Integer = 0
    Private Const LOAD_SPEC As Integer = 1
    Private Const LOAD_SPECDETAIL As Integer = 2
    Dim controller As Data_Specification_Controller = New Data_Specification_Controller
    Private Sub SpecificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ImeMode = ImeMode.OnHalf
        Dim statusForm As Status_Normal_Form = New Status_Normal_Form("載入中")
        statusForm.Show()
        Me.Visible = False
        LoadBackgroundWorker.RunWorkerAsync({LOAD_SUPPLIER, statusForm})
        If L3 = 1 Then
            AddSpecBtn.Visible = False
            EditSpecBtn.Visible = False
            DelSpecBtn.Visible = False
            AddSpecDetailBtn.Visible = False
            EditSpecDetailBtn.Visible = False
            DelSpecDetailBtn.Visible = False
        End If
    End Sub

    Private Sub LoadBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LoadBackgroundWorker.DoWork
        If e.Argument(0) = LOAD_SUPPLIER Then
            Dim data As ArrayList = controller.LoadSupplier
            e.Result = {LOAD_SUPPLIER, data, e.Argument(1)}
        ElseIf e.Argument(0) = LOAD_SPEC Then
            Dim data As ArrayList = controller.Load_Spec(e.Argument(1))
            e.Result = {LOAD_SPEC, data}
        ElseIf e.Argument(0) = LOAD_SPECDETAIL Then
            Dim data As ArrayList = controller.Load_Spec_Detail(e.Argument(1))
            e.Result = {LOAD_SPECDETAIL, data}
        End If
    End Sub

    Private Sub LoadBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LoadBackgroundWorker.RunWorkerCompleted
        If e.Result(0) = LOAD_SUPPLIER Then
            For Each data As Supplier In e.Result(1)
                SupplierList.Items.Add(data.Name)
            Next
            Me.Visible = True
            e.Result(2).Dispose
        ElseIf e.Result(0) = LOAD_SPEC Then
            SpecList.Items.Clear()
            SpecDetailList.Items.Clear()
            For Each data As Spec In e.Result(1)
                SpecList.Items.Add(data.ClassName)
            Next
        ElseIf e.Result(0) = LOAD_SPECDETAIL Then
            SpecDetailList.Items.Clear()
            For Each data As SpecDetail In e.Result(1)
                SpecDetailList.Items.Add(data.DetailName)
            Next
        End If
    End Sub

    Private Sub SupplierList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupplierList.SelectedIndexChanged, SpecList.SelectedIndexChanged, SpecDetailList.SelectedIndexChanged
        If sender.name = "SupplierList" And SupplierList.SelectedIndex <> -1 Then
            AddSpecBtn.Enabled = True
            EditSpecBtn.Enabled = False
            DelSpecBtn.Enabled = False
            AddSpecDetailBtn.Enabled = False
            EditSpecDetailBtn.Enabled = False
            DelSpecDetailBtn.Enabled = False
            LoadBackgroundWorker.RunWorkerAsync({LOAD_SPEC, controller.dataSupplier(SupplierList.SelectedIndex)})
        ElseIf sender.Name = "SpecList" And SpecList.SelectedIndex <> -1 Then
            EditSpecBtn.Enabled = True
            DelSpecBtn.Enabled = True
            AddSpecDetailBtn.Enabled = True
            EditSpecDetailBtn.Enabled = False
            DelSpecDetailBtn.Enabled = False
            LoadBackgroundWorker.RunWorkerAsync({LOAD_SPECDETAIL, controller.dataSpec(SpecList.SelectedIndex)})
        ElseIf sender.Name = "SpecDetailList" And SpecDetailList.SelectedIndex <> -1 Then
            EditSpecDetailBtn.Enabled = True
            DelSpecDetailBtn.Enabled = True
        End If
    End Sub

    Private Sub AddSpecBtn_Click(sender As Object, e As EventArgs) Handles AddSpecBtn.Click
        Dim input As String = InputBox("請輸入種類名稱", "新增種類", "請輸入種類名稱")
        If input <> "" Then
            If controller.Add_Spec(controller.dataSupplier(SupplierList.SelectedIndex), input) = 0 Then
                MsgBox("錯誤，請重新輸入!")
            Else
                SpecList.Items.Add(input)
            End If
        End If
    End Sub
    Private Sub AddSpecDetailBtn_Click(sender As Object, e As EventArgs) Handles AddSpecDetailBtn.Click
        Dim input As String = InputBox("請輸入規格名稱", "新增規格", "請輸入規格名稱")
        If input <> "" Then
            If controller.Add_Spec_Detail(controller.dataSpec(SpecList.SelectedIndex), input) = 0 Then
                MsgBox("錯誤，請重新輸入!")
            Else
                SpecDetailList.Items.Add(input)
            End If
        End If
    End Sub

    Private Sub EditSpecBtn_Click(sender As Object, e As EventArgs) Handles EditSpecBtn.Click
        Dim input As String = InputBox("請輸入種類名稱", "修改種類", SpecList.SelectedItem)
        If input <> "" Then
            If controller.Update_Spec(controller.dataSpec(SpecList.SelectedIndex), input) = 0 Then
                MsgBox("錯誤，請重新輸入!")
            Else
                SpecList.Items(SpecList.SelectedIndex) = input
            End If
        End If
    End Sub
    Private Sub EditSpecDetailBtn_Click(sender As Object, e As EventArgs) Handles EditSpecDetailBtn.Click
        Dim input As String = InputBox("請輸入規格名稱", "修改規格", SpecDetailList.SelectedItem)
        If input <> "" Then
            If controller.Update_Spec_Detail(controller.dataSpecDetail(SpecDetailList.SelectedIndex), input) = 0 Then
                MsgBox("錯誤，請重新輸入!")
            Else
                SpecDetailList.Items(SpecDetailList.SelectedIndex) = input
            End If
        End If
    End Sub

    Private Sub DelSpecBtn_Click(sender As Object, e As EventArgs) Handles DelSpecBtn.Click
        Dim msg As Integer = MsgBox("確定要刪除?", MsgBoxStyle.YesNo, "注意")
        If msg = MsgBoxResult.Yes Then
            If controller.Del_Spec(controller.dataSpec(SpecList.SelectedIndex)) = 0 Then
                Dim msg2 As Integer = MsgBox("在此類別內有設定規格，是否也要連同刪除?", MsgBoxStyle.YesNo, "注意")
                If msg2 = MsgBoxResult.Yes Then
                    If controller.Del_Spec_All(controller.dataSpec(SpecList.SelectedIndex)) = 0 Then
                        MsgBox("刪除錯誤，此類別已經有產品在使用了")
                    Else
                        '若刪除類別內含有規格時執行
                        controller.dataSpec.RemoveAt(SpecList.SelectedIndex)
                        SpecList.Items.RemoveAt(SpecList.SelectedIndex)
                        SpecDetailList.Items.Clear()
                        MsgBox("刪除完成")
                        Exit Sub
                    End If
                End If
            Else
                controller.dataSpec.RemoveAt(SpecList.SelectedIndex)
                SpecList.Items.RemoveAt(SpecList.SelectedIndex)
                MsgBox("刪除完成")
            End If
        End If
    End Sub

    Private Sub DelSpecDetailBtn_Click(sender As Object, e As EventArgs) Handles DelSpecDetailBtn.Click
        Dim msg As Integer = MsgBox("確定要刪除?", MsgBoxStyle.YesNo, "注意")
        If msg = MsgBoxResult.Yes Then
            If controller.Del_Spec_Detail(controller.dataSpecDetail(SpecDetailList.SelectedIndex)) = 0 Then
                MsgBox("刪除錯誤，此類別已經有產品在使用了")
            Else
                controller.dataSpecDetail.RemoveAt(SpecDetailList.SelectedIndex)
                SpecDetailList.Items.RemoveAt(SpecDetailList.SelectedIndex)
                MsgBox("刪除完成")
            End If
        End If
    End Sub
End Class