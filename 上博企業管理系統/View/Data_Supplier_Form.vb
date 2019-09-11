Imports System.Drawing

Public Class Data_Supplier_Form
    Dim controller As Data_Supplier_Controller = New Data_Supplier_Controller
    Dim v As Boolean = False
    Dim tabName As String = "ProdTab"


    Private Sub LoadDataCustomerWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles LoadDataCustomerWorker.DoWork
        LoadDataCustomerWorker.ReportProgress(0)
        If e.Argument Is Nothing Then
            e.Result = controller.Select_Supplier
        Else
            e.Result = controller.Select_FittingSet(e.Argument(0), e.Argument(1))
        End If

    End Sub

    Private Sub LoadDataCustomerWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles LoadDataCustomerWorker.RunWorkerCompleted

        ViewDGV.Rows.Clear()
        For Each data As Data_Supplier_Model.SupplierData In e.Result
            ViewDGV.Rows.Add(data.SuID, data.Name, data.Abbr, data.Number, data.CpyID, data.Address, data.Contact, data.Phone)
        Next
        LoadingPic.Visible = False
    End Sub

    Private Sub ViewDGV_CurrentCellChanged(sender As Object, e As EventArgs) Handles ViewDGV.CurrentCellChanged

        If ViewDGV.CurrentRow IsNot Nothing Then
            SuNameText.Text = ViewDGV.CurrentRow.Cells("SuName").Value
            SuAbbrText.Text = ViewDGV.CurrentRow.Cells("SuAbbr").Value
            SuNumberText.Text = ViewDGV.CurrentRow.Cells("SuNumber").Value
            CpyIDText.Text = ViewDGV.CurrentRow.Cells("CpyID").Value
            AddressText.Text = ViewDGV.CurrentRow.Cells("Address").Value
            ContactText.Text = ViewDGV.CurrentRow.Cells("Contact").Value
            PhoneText.Text = ViewDGV.CurrentRow.Cells("Phone").Value
        End If

    End Sub
    Private Sub DataCustomerForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadingPic.Visible = True
        LoadDataCustomerWorker.RunWorkerAsync()

    End Sub


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        SuAbbrText.ReadOnly = False
        SuNumberText.ReadOnly = False
        SuNameText.ReadOnly = False
        CpyIDText.ReadOnly = False
        AddressText.ReadOnly = False
        ContactText.ReadOnly = False
        PhoneText.ReadOnly = False
        OKBtn.Visible = True
        CancelBtn.Visible = True
        AddBtn.Visible = False
        ReviseBtn.Visible = False
        DelBtn.Visible = False
        ViewDGV.Rows.Add()
        ViewDGV.CurrentCell = ViewDGV.Rows(ViewDGV.Rows.Count - 1).Cells(2)
        controller.Set_InsertMode()


    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click

        Select Case controller.Get_Mode
            Case Data_Supplier_Model.INSERT_MODE
                Dim index As Integer = controller.Insert_Supplier(SuNameText.Text, SuNumberText.Text, CpyIDText.Text, AddressText.Text, ContactText.Text, PhoneText.Text, SuAbbrText.Text)
                ViewDGV.CurrentRow.Cells("SuName").Value = SuNameText.Text
                ViewDGV.CurrentRow.Cells("SuAbbr").Value = SuAbbrText.Text
                ViewDGV.CurrentRow.Cells("SuNumber").Value = SuNumberText.Text
                ViewDGV.CurrentRow.Cells("CpyID").Value = CpyIDText.Text
                ViewDGV.CurrentRow.Cells("Address").Value = AddressText.Text
                ViewDGV.CurrentRow.Cells("Contact").Value = ContactText.Text
                ViewDGV.CurrentRow.Cells("Phone").Value = PhoneText.Text
            Case Data_Supplier_Model.REVISE_MODE
                Dim index As Integer = controller.Update_Supplier(ViewDGV.CurrentRow.Cells("SuID").Value, SuNameText.Text, SuNumberText.Text, CpyIDText.Text, AddressText.Text, ContactText.Text, PhoneText.Text, SuAbbrText.Text)
                ViewDGV.CurrentRow.Cells("SuName").Value = SuNameText.Text
                ViewDGV.CurrentRow.Cells("SuAbbr").Value = SuAbbrText.Text
                ViewDGV.CurrentRow.Cells("SuNumber").Value = SuNumberText.Text
                ViewDGV.CurrentRow.Cells("CpyID").Value = CpyIDText.Text
                ViewDGV.CurrentRow.Cells("Address").Value = AddressText.Text
                ViewDGV.CurrentRow.Cells("Contact").Value = ContactText.Text
                ViewDGV.CurrentRow.Cells("Phone").Value = PhoneText.Text
        End Select
        SuAbbrText.ReadOnly = True
        SuNumberText.ReadOnly = True
        SuNameText.ReadOnly = True
        CpyIDText.ReadOnly = True
        AddressText.ReadOnly = True
        ContactText.ReadOnly = True
        PhoneText.ReadOnly = True
        AddBtn.Visible = True
        ReviseBtn.Visible = True
        DelBtn.Visible = True
        OKBtn.Visible = False
        CancelBtn.Visible = False
        controller.Set_NormalMode()
        v = False

    End Sub

    Private Sub ReviseBtn_Click(sender As Object, e As EventArgs) Handles ReviseBtn.Click
        SuAbbrText.ReadOnly = False
        SuNumberText.ReadOnly = False
        SuNameText.ReadOnly = False
        CpyIDText.ReadOnly = False
        AddressText.ReadOnly = False
        ContactText.ReadOnly = False
        PhoneText.ReadOnly = False
        OKBtn.Visible = True
        CancelBtn.Visible = True
        AddBtn.Visible = False
        ReviseBtn.Visible = False
        DelBtn.Visible = False
        controller.Set_ReviseMode()
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click

        Dim Result As MsgBoxResult = MsgBox("您確認要刪除?刪除後將無法復原", MsgBoxStyle.YesNo, "警告")
        If Result = MsgBoxResult.Yes Then
            Try
                controller.Del_Supplier(ViewDGV.CurrentRow.Cells("SuID").Value)
                ViewDGV.Rows.RemoveAt(ViewDGV.CurrentRow.Index)
            Catch ex As Exception
                MsgBox("無法刪除供應商，可能已經有使用")
            End Try

        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click

        If SearchCB.SelectedIndex <> -1 Then
            LoadingPic.Visible = True
            LoadDataCustomerWorker.RunWorkerAsync({SearchCB.SelectedIndex, SearchText.Text})
        ElseIf SearchCB.SelectedIndex = -1 Then
            MsgBox("請設定查詢類別")
        End If


    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

        If controller.Get_Mode = Data_Supplier_Model.INSERT_MODE Then
            ViewDGV.Rows.RemoveAt(ViewDGV.CurrentCell.RowIndex)
        End If
        SuAbbrText.ReadOnly = True
        SuNumberText.ReadOnly = True
        SuNameText.ReadOnly = True
        CpyIDText.ReadOnly = True
        AddressText.ReadOnly = True
        ContactText.ReadOnly = True
        PhoneText.ReadOnly = True
        AddBtn.Visible = True
        ReviseBtn.Visible = True
        DelBtn.Visible = True
        OKBtn.Visible = False
        CancelBtn.Visible = False
        controller.Set_NormalMode()
        v = False

    End Sub


    Private Sub ViewDGV_MouseEnter(sender As Object, e As EventArgs) Handles ViewDGV.MouseEnter
        If controller.Get_Mode <> Data_Supplier_Model.NORMAL_MODE Then
            v = True
        End If
    End Sub

    Private Sub ViewDGV_MouseLeave(sender As Object, e As EventArgs) Handles ViewDGV.MouseLeave
        v = False
    End Sub

    Private Sub ViewDGV_Enter(sender As Object, e As EventArgs) Handles ViewDGV.Enter
        If controller.Get_Mode <> Data_Supplier_Model.NORMAL_MODE Then
            v = True
        End If
    End Sub

    Private Sub ViewDGV_Leave(sender As Object, e As EventArgs) Handles ViewDGV.Leave
        v = False
    End Sub

    Private Sub ViewDGV_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles ViewDGV.CellValidating
        If v Then
            MsgBox("資料尚未儲存，請先儲存或取消")
            e.Cancel = True
        End If
    End Sub

    Private Sub Data_Supplier_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L2 = 1 Then
            ContorlLayout.Visible = False
        End If
    End Sub
End Class