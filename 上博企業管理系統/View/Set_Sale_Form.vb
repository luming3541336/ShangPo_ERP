Imports System.Data.SqlClient

Public Class Set_Sale_Form
    Private controller As Set_Sale_Controller = New Set_Sale_Controller
    Public Sub New(ByVal caseID As Integer, ByVal currentCaseName As String)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        controller.Set_CaseID(caseID)
        controller.Set_Mode(Set_Sale_Model.INSERT_MODE)
        CurrentCaseLabel.Text = currentCaseName
    End Sub
    Public Sub New(ByVal caseID As Integer, ByVal editID As Integer, ByVal currentCaseName As String)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        controller.Set_CaseID(caseID)
        controller.Set_ShipmentID(editID)
        controller.Set_Mode(Set_Sale_Model.EDIT_MODE)
        CurrentCaseLabel.Text = currentCaseName
    End Sub

    Private Sub ProdDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles prodDGV.CellClick, fitDGV.CellClick
        Select Case sender.name
            Case "prodDGV"
                If e.ColumnIndex() = 2 Then
                    If e.ColumnIndex() = 2 Then 'ProdName

                        Dim toSearchForm As Search_Form = New Search_Form(0, 1)
                        If toSearchForm.ShowDialog = DialogResult.OK Then
                            prodDGV.Rows(e.RowIndex).Cells(0).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(0)
                            prodDGV.Rows(e.RowIndex).Cells(1).Value = 0
                            prodDGV.Rows(e.RowIndex).Cells(2).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(1)
                            prodDGV.Rows(e.RowIndex).Cells(3).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(2)
                            prodDGV.Rows(e.RowIndex).Cells(4).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(3)
                            prodDGV.Rows(e.RowIndex).Cells(5).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(4)
                            prodDGV.Rows(e.RowIndex).Cells(6).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(5)
                            prodDGV.Rows(e.RowIndex).Cells(7).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(6)
                            prodDGV.Rows(e.RowIndex).Cells(11).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(7)
                            prodDGV.Rows(e.RowIndex).Cells(10).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(8)
                        End If
                    End If
                End If
            Case "fitDGV"
                If e.ColumnIndex() = 2 Then 'FitName  

                    Dim toSearchForm As Search_Form = New Search_Form(1, 1)
                    If toSearchForm.ShowDialog = DialogResult.OK Then

                        fitDGV.Rows(e.RowIndex).Cells(0).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(0)
                        fitDGV.Rows(e.RowIndex).Cells(1).Value = 0
                        fitDGV.Rows(e.RowIndex).Cells(2).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(1)
                        fitDGV.Rows(e.RowIndex).Cells(3).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(2)
                        fitDGV.Rows(e.RowIndex).Cells(4).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(3)
                        fitDGV.Rows(e.RowIndex).Cells(5).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(4)
                        fitDGV.Rows(e.RowIndex).Cells(6).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(5)
                        fitDGV.Rows(e.RowIndex).Cells(7).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(6)
                        fitDGV.Rows(e.RowIndex).Cells(11).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(7)
                        fitDGV.Rows(e.RowIndex).Cells(10).Value = toSearchForm.dataArray(toSearchForm.selectIndex)(8)
                    End If
                End If
        End Select

    End Sub
    Private Sub AddPurchaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        purchaseNoText.Text = controller.Create_SaleNO
        loadBackGround.RunWorkerAsync()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '資料存取前先確定是否有資料不符合預期
        For Each data As DataGridViewRow In prodDGV.Rows
            If data.Cells("prodCount").Value > data.Cells("prodRemainAmount").Value Then
                MsgBox("出貨數量不可以大於庫存數")
                Exit Sub
            End If
        Next
        For Each data As DataGridViewRow In fitDGV.Rows
            If data.Cells("fitCount").Value > data.Cells("fitRemainAmount").Value Then
                MsgBox("出貨數量不可以大於庫存數")
                Exit Sub
            End If
        Next
        Dim id As Integer = Nothing '作為新增出貨資料時產生流水號暫存使用
        Dim strSql As String = Nothing
        If controller.Get_Mode = Set_Sale_Model.INSERT_MODE Then
            controller.Insert_ShipmentData(purchaseNoText.Text, saleTime.Value)
        ElseIf controller.Get_Mode = Set_Sale_Model.EDIT_MODE Then
            controller.Update_ShipmentData_For_InsertTime(saleTime.Value)
        End If
        For i As Integer = 0 To prodDGV.Rows.Count - 1
            If prodDGV.Rows(i).Cells("prodCount").Value <> 0 Then
                If prodDGV.Rows(i).Cells("salePID").Value = 0 Then
                    controller.Insert_ShipmentPart(prodDGV.Rows(i).Cells("purchasePID").Value, prodDGV.Rows(i).Cells("prodCount").Value, prodDGV.Rows(0).Cells("prodPIC").Value)
                Else
                    controller.Update_ShipmentPart(prodDGV.Rows(i).Cells("salePID").Value, prodDGV.Rows(i).Cells("purchasePID").Value, prodDGV.Rows(i).Cells("prodCount").Value, prodDGV.Rows(0).Cells("prodPIC").Value)
                End If
            End If
        Next
        For i As Integer = 0 To fitDGV.Rows.Count - 1
            If fitDGV.Rows(i).Cells("fitCount").Value <> 0 Then
                If fitDGV.Rows(i).Cells("saleFID").Value = 0 Then
                    controller.Insert_ShipmentPart2(fitDGV.Rows(i).Cells("purchaseFID").Value, fitDGV.Rows(i).Cells("fitCount").Value, fitDGV.Rows(0).Cells("fitPIC").Value)
                Else
                    controller.Update_ShipmentPart2(fitDGV.Rows(i).Cells("saleFID").Value, fitDGV.Rows(i).Cells("purchaseFID").Value, fitDGV.Rows(i).Cells("fitCount").Value, fitDGV.Rows(0).Cells("fitPIC").Value)
                End If
            End If
        Next
        If controller.Get_Remove_Prod_DGV.Count <> 0 Then
            For Each data As Integer In controller.Get_Remove_Prod_DGV
                controller.Del_ShipmentPart(data)
            Next
        End If
        If controller.Get_Remove_Fit_DGV.Count <> 0 Then
            For Each data As Integer In controller.Get_Remove_Fit_DGV
                controller.Del_ShipmentPart2(data)
            Next
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub loadBackGround_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles loadBackGround.DoWork
        Select Case controller.Get_Mode
            Case Set_Sale_Model.INSERT_MODE
                e.Result = {controller.Load_Stock(Set_Sale_Model.PRODUCT), controller.Load_Stock(Set_Sale_Model.FIT)}
            Case Set_Sale_Model.EDIT_MODE
                e.Result = {controller.Search_Order(Set_Sale_Model.PRODUCT), controller.Search_Order(Set_Sale_Model.FIT), controller.Get_ShipmentData_InsertTime}
        End Select
    End Sub

    Private Sub loadBackGround_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles loadBackGround.RunWorkerCompleted
        Select Case controller.Get_Mode
            Case Set_Sale_Model.INSERT_MODE
                For Each data As Set_Sale_Model.Stock In e.Result(0)
                    prodDGV.Rows.Add(data.PurchaseDetailID, 0, data.Name, data.Supplier, data.Specification,
                                     data.Width, data.Length, data.CBM, data.PIC, 0, data.RemainAmount, data.Remark)
                Next
                For Each data As Set_Sale_Model.Stock In e.Result(1)
                    fitDGV.Rows.Add(data.PurchaseDetailID, 0, data.Name, data.Supplier, data.Specification,
                                     data.Width, data.Length, data.CBM, data.PIC, 0, data.RemainAmount, data.Remark)
                Next
            Case Set_Sale_Model.EDIT_MODE
                For Each data As Set_Sale_Model.ShipmentData In e.Result(0)
                    prodDGV.Rows.Add(data.PurchaseDetailID, data.SaleDetailID, data.Name, data.Supplier, data.Specification,
                                     data.Width, data.Length, data.CBM, data.PIC, data.count, data.RemainAmount, data.Remark)
                Next
                For Each data As Set_Sale_Model.ShipmentData In e.Result(1)
                    fitDGV.Rows.Add(data.PurchaseDetailID, data.SaleDetailID, data.Name, data.Supplier, data.Specification,
                                     data.Width, data.Length, data.CBM, data.PIC, data.count, data.RemainAmount, data.Remark)
                Next
                saleTime.Value = e.Result(2)
        End Select
    End Sub

    Private Sub prodDGV_Enter(sender As Object, e As EventArgs) Handles prodDGV.Enter, fitDGV.Enter
        sender.ImeMode = ImeMode.OnHalf
    End Sub

    Private Sub AddSaleForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then
            e.Handled = True
            SendKeys.Send(vbTab)
        End If
    End Sub

    'Private Sub prodDGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles prodDGV.EditingControlShowing, fitDGV.EditingControlShowing
    '    e.Control.ImeMode = ImeMode.Disable
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub prodDGV_KeyDown(sender As Object, e As KeyEventArgs) Handles prodDGV.KeyDown, fitDGV.KeyDown
        If e.KeyCode = 46 Then
            Select Case sender.Name
                Case "prodDGV"
                    If controller.Get_Mode = Set_Sale_Model.EDIT_MODE Then
                        If prodDGV.Rows(prodDGV.CurrentRow.Index).Cells("salePID").Value <> 0 Then
                            controller.Set_Remove_Prod_DGV(CInt(prodDGV.Rows(prodDGV.CurrentRow.Index).Cells("salePID").Value))
                        End If
                    End If
                Case "fitDGV"
                    If controller.Get_Mode = Set_Sale_Model.EDIT_MODE Then
                        If fitDGV.Rows(fitDGV.CurrentRow.Index).Cells("saleFID").Value <> 0 Then
                            controller.Set_Remove_Fit_DGV(CInt(fitDGV.Rows(fitDGV.CurrentRow.Index).Cells("saleFID").Value))
                        End If

                    End If

            End Select
        End If
    End Sub

    Private Sub prodDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles prodDGV.CellEnter, fitDGV.CellEnter
        If e.ColumnIndex = 8 Then
            sender.ImeMode = ImeMode.OnHalf
        Else
            sender.ImeMode = ImeMode.Disable
        End If
    End Sub

    Private Sub prodDGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles prodDGV.CellValueChanged, fitDGV.CellValueChanged
        If e.RowIndex <> -1 Then
            sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = StrConv(sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, VbStrConv.Narrow)
        End If

    End Sub
    Private Sub prodDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles prodDGV.RowPostPaint, fitDGV.RowPostPaint
        Using b As SolidBrush = New SolidBrush(sender.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentCulture) + 1, sender.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4)
        End Using
    End Sub
    Private Sub ProdDGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles prodDGV.EditingControlShowing, fitDGV.EditingControlShowing
        If sender.Name = "prodDGV" Then
            If prodDGV.CurrentCell.ColumnIndex = 9 Then
                e.Control.ImeMode = ImeMode.Disable
            Else
                e.Control.ImeMode = ImeMode.OnHalf
            End If
        Else
            If fitDGV.CurrentCell.ColumnIndex = 7 Then
                e.Control.ImeMode = ImeMode.Disable
            Else
                e.Control.ImeMode = ImeMode.OnHalf
            End If
        End If

    End Sub
End Class