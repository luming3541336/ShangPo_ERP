Imports System.ComponentModel

Public Class Data_Product_Form
    Dim controller As Data_Product_Controller = New Data_Product_Controller
    Dim bindingSource As BindingSource = New BindingSource ' ProdData
    Dim bindingSource2 As BindingSource = New BindingSource ' ProdModel
    Dim bindingSource3 As BindingSource = New BindingSource ' SupplierData
    Dim arrData As List(Of ProdData) = Nothing
    Dim arrModel As List(Of ProdModel) = New List(Of ProdModel)
    Dim arrSupplier As List(Of SupplierData) = Nothing
    Private Sub Data_Product_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrData = controller.Select_ProdData
        arrSupplier = controller.Select_Supplier
        bindingSource.DataSource = arrData
        bindingSource2.DataSource = arrModel
        bindingSource3.DataSource = arrSupplier
        SupplierCB.DataSource = arrSupplier
        SupplierCB.DisplayMember = "Name"
        SupplierCB.ValueMember = "SuID"
        ProdDGV.AutoGenerateColumns = False
        ModelDGV.AutoGenerateColumns = False
        ProdDGV.DataSource = bindingSource
        SupplierCB.DataBindings.Add(New Binding("SelectedValue", bindingSource2, "SuID", False, DataSourceUpdateMode.Never))
        ModelText.DataBindings.Add(New Binding("Text", bindingSource2, "Model", False, DataSourceUpdateMode.Never))
        PriceText.DataBindings.Add(New Binding("Text", bindingSource2, "Price", False, DataSourceUpdateMode.Never))
        ProdNameText.DataBindings.Add(New Binding("Text", bindingSource, "ProdName", False, DataSourceUpdateMode.Never))
        UnitCB.DataBindings.Add(New Binding("SelectedItem", bindingSource, "Unit", False, DataSourceUpdateMode.Never))
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        ProdPanel.Enabled = False
        AddBtn.Visible = True
        ReviseBtn.Visible = True
        DelBtn.Visible = True
        OKBtn.Visible = False
        CancelBtn.Visible = False
        CType(bindingSource.Current, ProdData).ClearChangeProperty()
        CType(bindingSource.Current, ProdData).ProdName = ProdNameText.Text
        CType(bindingSource.Current, ProdData).Unit = UnitCB.SelectedItem
        Dim changeProperty As Dictionary(Of String, String) = CType(bindingSource.Current, ProdData).GetChargedProperty()
        If CType(bindingSource.Current, ProdData).ProdID = Nothing Then
            If changeProperty.Count <> 2 Then '表示資料未完全輸入(需輸入兩筆資料)
                MsgBox("資料尚未輸入完整")
                bindingSource.RemoveCurrent()
                Exit Sub
            End If
            CType(bindingSource.Current, ProdData).ProdID = controller.Insert_ProdData(changeProperty)
        Else
            If changeProperty.Count > 0 Then
                If controller.Update_ProdData(CType(bindingSource.Current, ProdData).ProdID, changeProperty) = 1 Then
                    MsgBox("OK")
                Else
                    MsgBox("新增錯誤，請聯絡工程師")
                End If
            End If
        End If
        bindingSource.ResetBindings(False)
    End Sub

    Private Sub ReviseBtn_Click(sender As Object, e As EventArgs) Handles ReviseBtn.Click
        ProdPanel.Enabled = True
        AddBtn.Visible = False
        ReviseBtn.Visible = False
        DelBtn.Visible = False
        OKBtn.Visible = True
        CancelBtn.Visible = True
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        ProdPanel.Enabled = True
        AddBtn.Visible = False
        ReviseBtn.Visible = False
        DelBtn.Visible = False
        OKBtn.Visible = True
        CancelBtn.Visible = True
        bindingSource.Add(New ProdData())
        bindingSource.EndEdit()
        ProdDGV.Rows(ProdDGV.RowCount - 1).Cells(1).Selected = True
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        ProdPanel.Enabled = False
        AddBtn.Visible = True
        ReviseBtn.Visible = True
        DelBtn.Visible = True
        OKBtn.Visible = False
        CancelBtn.Visible = False
        If CType(bindingSource.Current, ProdData).ProdID = Nothing Then
            bindingSource.RemoveCurrent()
        End If
        bindingSource.ResetBindings(False)
    End Sub

    Private Sub ProdDGV_CurrentCellChanged(sender As Object, e As EventArgs) Handles ProdDGV.CurrentCellChanged
        ModelAddBtn.Enabled = False
        ModelReviseBtn.Enabled = False
        ModelDelBtn.Enabled = False
        If CType(sender, DataGridView).CurrentRow IsNot Nothing Then
            arrModel = controller.Select_ProdModel(CType(bindingSource.Current, ProdData).ProdID)
            ModelAddBtn.Enabled = True
            ModelReviseBtn.Enabled = True
            ModelDelBtn.Enabled = True
        End If
        bindingSource2.DataSource = arrModel
        ModelDGV.DataSource = bindingSource2
    End Sub

    Private Sub ModelAddBtn_Click(sender As Object, e As EventArgs) Handles ModelAddBtn.Click
        ModelPanel.Enabled = True
        ModelAddBtn.Visible = False
        ModelReviseBtn.Visible = False
        ModelDelBtn.Visible = False
        ModelOKBtn.Visible = True
        ModelCancelBtn.Visible = True
        ProdDGV.Enabled = False
        bindingSource2.Add(New ProdModel())
        ModelDGV.Rows(ModelDGV.RowCount - 1).Cells(2).Selected = True
        SupplierCB.SelectedIndex = 0
    End Sub

    Private Sub ModelOKBtn_Click(sender As Object, e As EventArgs) Handles ModelOKBtn.Click
        ModelPanel.Enabled = False
        ModelAddBtn.Visible = True
        ModelReviseBtn.Visible = True
        ModelDelBtn.Visible = True
        ModelOKBtn.Visible = False
        ModelCancelBtn.Visible = False
        ProdDGV.Enabled = True
        CType(bindingSource2.Current, ProdModel).ClearChangeProperty()
        CType(bindingSource2.Current, ProdModel).SuID = SupplierCB.SelectedValue
        CType(bindingSource2.Current, ProdModel).Name = CType(SupplierCB.SelectedItem, SupplierData).Name
        CType(bindingSource2.Current, ProdModel).Model = ModelText.Text
        CType(bindingSource2.Current, ProdModel).Price = PriceText.Text
        Dim changeProperty As Dictionary(Of String, String) = CType(bindingSource2.Current, ProdModel).GetChargedProperty()

        If CType(bindingSource2.Current, ProdModel).ProdModelID = Nothing Then '無ProdModelID時表示為新增的資料
            If changeProperty.Count <> 3 Then '表示資料未完全輸入(Model需輸入三筆資料)
                MsgBox("資料尚未輸入完整")
                bindingSource2.RemoveCurrent()
                Exit Sub
            End If
            CType(bindingSource2.Current, ProdModel).ProdModelID = controller.Insert_ProdModel(CType(bindingSource.Current, ProdData).ProdID, changeProperty)
        Else
            If changeProperty.Count > 0 Then
                If controller.Update_ProdModel(CType(bindingSource2.Current, ProdModel).ProdModelID, changeProperty) = 1 Then
                    MsgBox("OK")
                Else
                    MsgBox("修正錯誤，請聯絡工程師")
                End If
            End If
        End If
        bindingSource2.ResetBindings(False)
    End Sub

    Private Sub ModelReviseBtn_Click(sender As Object, e As EventArgs) Handles ModelReviseBtn.Click
        ModelPanel.Enabled = True
        ModelAddBtn.Visible = False
        ModelReviseBtn.Visible = False
        ModelDelBtn.Visible = False
        ModelOKBtn.Visible = True
        ProdDGV.Enabled = False
        ModelCancelBtn.Visible = True
    End Sub

    Private Sub ModelCancelBtn_Click(sender As Object, e As EventArgs) Handles ModelCancelBtn.Click
        ModelPanel.Enabled = False
        ModelAddBtn.Visible = True
        ModelReviseBtn.Visible = True
        ModelDelBtn.Visible = True
        ModelOKBtn.Visible = False
        ModelCancelBtn.Visible = False
        ProdDGV.Enabled = True
        If CType(bindingSource2.Current, ProdModel).ProdModelID = Nothing Then
            bindingSource2.RemoveCurrent()
        End If
        bindingSource.ResetBindings(False)
    End Sub

    Private Sub ModelDelBtn_Click(sender As Object, e As EventArgs) Handles ModelDelBtn.Click
        Dim result As DialogResult = MsgBox("您確定要將資料刪除?", vbOKCancel, "注意")
        If result = DialogResult.OK Then
            controller.Delete_ProdModel(CType(bindingSource2.Current, ProdModel).ProdModelID)
            bindingSource2.RemoveCurrent()
            bindingSource2.ResetBindings(False)
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim result As DialogResult = MsgBox("您確定要將資料刪除?", vbOKCancel, "注意")
        If result = DialogResult.OK Then
            If controller.Delete_ProdData(CType(bindingSource.Current, ProdData).ProdID) <> 1 Then
                MsgBox("內有關聯資料，無法刪除")
            End If
            bindingSource.RemoveCurrent()
            bindingSource.ResetBindings(False)
        End If
    End Sub
End Class