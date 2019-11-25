Imports System.Data.SqlClient

Public Class Set_Purchase_Form
    Private editIndex As Integer = Nothing ' 修改中的欄位
    Private controller As Set_Purchase_Controller
    Dim CurrentPoint As Point

    Public Sub New(ByVal caseID As Integer, ByVal currentCaseName As String)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        controller = New Set_Purchase_Controller(caseID)
        CurrentCaseLabel.Text = currentCaseName
    End Sub
    Public Sub New(ByVal caseID As Integer, ByVal editID As Integer, ByVal currentCaseName As String)
        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        controller = New Set_Purchase_Controller(caseID, editID)
        CurrentCaseLabel.Text = currentCaseName
    End Sub
    'ProdDGV與FitDGV欄位修正結束後會產生的作業:
    '  ﹂>當ProdDGV(FitDGV)內產品名稱(配件名稱)修改時會判斷名稱內是否有一個以上的相同名稱，有的話將會跳出選擇視窗選擇
    '  ﹂>當ProdDGV(FitDGV)輸入數量時將會直接更改purchaseProdArray(purchaseFitArray)對應欄位的數量
    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ProdDGV.CellEndEdit, FitDGV.CellEndEdit
        editIndex = e.RowIndex
        Select Case sender.Name
            Case "ProdDGV"
                If e.ColumnIndex() = 1 Then '產品名稱
                    ProdDGV.Rows(e.RowIndex).ErrorText = String.Empty
                Else
                    If controller.Get_PurchasePartCount > e.RowIndex Then
                        '進入此欄位代表已有存在的欄位做了變更，並執行以下程序：
                        ' ﹂>先去偵測寬與長的欄位是否有資料，若有資料將會去透過公式換算成CBM
                        '       ﹂>因為換算CBM需要長跟寬才可換算，若其中一個值為NULL則會出現警告要求使用者輸入
                        '       ﹂>若長跟寬皆為NULL時，有可能是這個貨沒有此規格，因此就不予理會
                        '﹂>若有輸入完整的長跟寬則會將算好的CBM帶入至暫存器purchaseProdArray內，最後存檔時會一並存檔
                        '      ×雖然若輸入不完整也會帶入至暫存器，但因有出現錯誤訊息，會無法存檔
                        If ProdDGV.CurrentRow.Cells("prodWidth").EditedFormattedValue.ToString <> "" And ProdDGV.CurrentRow.Cells("prodLength").EditedFormattedValue.ToString <> "" Then

                            Dim dobCBM As Double = 0 '透過公式算出CBM
                            dobCBM = Format((CDbl(ProdDGV.CurrentRow.Cells("prodWidth").EditedFormattedValue.ToString) * CDbl(ProdDGV.CurrentRow.Cells("prodLength").EditedFormattedValue.ToString) * 11 / 10000), "0.##")
                            ProdDGV.CurrentRow.Cells("prodCBM").Value = dobCBM
                            ProdDGV.Rows(e.RowIndex).ErrorText = String.Empty
                            ProdDGV.AllowUserToAddRows = True
                        Else
                            ProdDGV.Rows(e.RowIndex).ErrorText = String.Empty
                            ProdDGV.AllowUserToAddRows = True
                            ProdDGV.CurrentRow.Cells("prodCBM").Value = ""
                        End If
                        'Dim strRemark As String = ""
                        'If ProdDGV.CurrentRow.Cells("prodRemark").EditedFormattedValue.ToString <> "" Then
                        '    strRemark = ProdDGV.CurrentRow.Cells("prodRemark").EditedFormattedValue.ToString
                        '    strRemark = strRemark.Replace("'", "''")
                        'End If
                        controller.Set_PurchasePItem(editIndex, Nothing, IIf(ProdDGV.CurrentRow.Cells("prodID").EditedFormattedValue.ToString = "", 0, ProdDGV.CurrentRow.Cells("prodID").EditedFormattedValue.ToString),
                                         IIf(ProdDGV.CurrentRow.Cells("prodClass").EditedFormattedValue.ToString = "", Nothing, ProdDGV.CurrentRow.Cells("prodClass").EditedFormattedValue.ToString),
                                        IIf(ProdDGV.CurrentRow.Cells("prodWidth").EditedFormattedValue.ToString = "", Nothing, ProdDGV.CurrentRow.Cells("prodWidth").EditedFormattedValue.ToString),
                                       IIf(ProdDGV.CurrentRow.Cells("prodLength").EditedFormattedValue.ToString = "", Nothing, ProdDGV.CurrentRow.Cells("prodLength").EditedFormattedValue.ToString),
                                        IIf(ProdDGV.CurrentRow.Cells("prodCBM").EditedFormattedValue.ToString = "", Nothing, ProdDGV.CurrentRow.Cells("prodCBM").EditedFormattedValue.ToString),
                                        IIf(ProdDGV.CurrentRow.Cells("prodCount").EditedFormattedValue.ToString = "", Nothing, ProdDGV.CurrentRow.Cells("prodCount").EditedFormattedValue.ToString),
                                       IIf(ProdDGV.CurrentRow.Cells("prodRemark").EditedFormattedValue.ToString = "", Nothing, ProdDGV.CurrentRow.Cells("prodRemark").EditedFormattedValue.ToString))
                        ProdDGV.AllowUserToAddRows = True
                    Else
                        ProdDGV.Rows(e.RowIndex).ErrorText = "請輸入產品"
                        ProdDGV.AllowUserToAddRows = False
                    End If
                End If
            Case "FitDGV"
                If e.ColumnIndex() = 1 Then 'FitName
                    editIndex = e.RowIndex
                    FitDGV.Rows(e.RowIndex).ErrorText = String.Empty
                Else
                    If FitDGV.CurrentRow.Cells("fitWidth").EditedFormattedValue.ToString <> "" And FitDGV.CurrentRow.Cells("fitLength").EditedFormattedValue.ToString <> "" Then
                        Dim dobCBM As Double = 0 '透過公式算出CBM
                        dobCBM = Format((CDbl(FitDGV.CurrentRow.Cells("fitWidth").EditedFormattedValue.ToString) * CDbl(FitDGV.CurrentRow.Cells("fitLength").EditedFormattedValue.ToString) * 11 / 10000), "0.##")
                        FitDGV.CurrentRow.Cells("fitCBM").Value = dobCBM
                        FitDGV.Rows(e.RowIndex).ErrorText = String.Empty
                        FitDGV.AllowUserToAddRows = True
                    Else
                        FitDGV.Rows(e.RowIndex).ErrorText = String.Empty
                        FitDGV.AllowUserToAddRows = True
                        FitDGV.CurrentRow.Cells("fitCBM").Value = ""
                    End If
                    'Dim strRemark As String = ""
                    'If FitDGV.CurrentRow.Cells("fitRemark").EditedFormattedValue.ToString <> "" Then
                    '    strRemark = FitDGV.CurrentRow.Cells("fitRemark").EditedFormattedValue.ToString
                    '    strRemark = strRemark.Replace("'", "''")
                    'End If

                    If controller.Get_PurchasePart2Count > e.RowIndex Then
                        controller.Set_PurchasePart2em(editIndex, Nothing, IIf(FitDGV.CurrentRow.Cells("ProdPart2ID").EditedFormattedValue.ToString = "", 0, FitDGV.CurrentRow.Cells("ProdPart2ID").EditedFormattedValue.ToString),
                                             IIf(FitDGV.CurrentRow.Cells("fitSpecification").EditedFormattedValue.ToString = "", "", FitDGV.CurrentRow.Cells("fitSpecification").EditedFormattedValue.ToString),
                                              IIf(FitDGV.CurrentRow.Cells("fitCount").EditedFormattedValue.ToString = "", 0, FitDGV.CurrentRow.Cells("fitCount").EditedFormattedValue.ToString),
                                             IIf(FitDGV.CurrentRow.Cells("fitRemark").EditedFormattedValue.ToString = "", Nothing, FitDGV.CurrentRow.Cells("fitRemark").EditedFormattedValue.ToString),
                            IIf(FitDGV.CurrentRow.Cells("fitWidth").EditedFormattedValue.ToString = "", Nothing, FitDGV.CurrentRow.Cells("fitWidth").EditedFormattedValue.ToString),
                                           IIf(FitDGV.CurrentRow.Cells("fitLength").EditedFormattedValue.ToString = "", Nothing, FitDGV.CurrentRow.Cells("fitLength").EditedFormattedValue.ToString),
                                            IIf(FitDGV.CurrentRow.Cells("fitCBM").EditedFormattedValue.ToString = "", Nothing, FitDGV.CurrentRow.Cells("fitCBM").EditedFormattedValue.ToString))
                        FitDGV.AllowUserToAddRows = True
                        Else
                            FitDGV.Rows(e.RowIndex).ErrorText = "請輸入產品"
                            FitDGV.AllowUserToAddRows = False
                        End If
                    End If
        End Select

    End Sub

    Private Sub ProdDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdDGV.CellClick
        If e.ColumnIndex() = 3 Then
            Dim Form As Set_Specification_Form = New Set_Specification_Form(ProdDGV.CurrentRow.Cells(0).Value, 0, ProdDGV.CurrentRow.Cells("prodClass").Value)
            If e.RowIndex < controller.Get_PurchasePartCount And e.RowIndex <> -1 Then
                If Form.ShowDialog = DialogResult.OK Then
                    ProdDGV.Item(3, e.RowIndex).Value = Form.strClassName
                    controller.Set_PurchasePItem(e.RowIndex, Nothing, Nothing, Form.strClassName, Nothing, Nothing, Nothing, Nothing, Nothing)
                End If
            End If
        End If
    End Sub
    Private Sub DGV_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles ProdDGV.RowsRemoved, FitDGV.RowsRemoved
        Select Case sender.Name
            Case "ProdDGV"
                If controller.Get_PurchasePartCount > e.RowIndex Then
                    If controller.Mode = 1 And controller.Get_PurchasePart(e.RowIndex).PurchasePID <> Nothing Then
                        controller.Add_EditRemoveProd(e.RowIndex)
                    End If
                    controller.Remove_PurchasePart(e.RowIndex)
                End If
            Case "FitDGV"
                If controller.Get_PurchasePart2Count > e.RowIndex Then
                    If controller.Mode = 1 And controller.Get_PurchasePart2(e.RowIndex).PurchaseP2ID <> Nothing Then
                        controller.Add_EditRemoveFit(e.RowIndex)
                    End If
                    controller.Remove_PurchasePart2(e.RowIndex)

                End If
        End Select
    End Sub

    Private Sub saveDataButton_Click(sender As Object, e As EventArgs) Handles SaveDataButton.Click
        insertToDatabaseBackground.RunWorkerAsync()
    End Sub
    Private Sub addPurchaseNoBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles addPurchaseNoBackground.DoWork
        Dim statusForm As Status_Normal_Form = New Status_Normal_Form("載入中....")
        sender.ReportProgress(0, statusForm)
        If controller.Mode = Set_Purchase_Model.INSERT_MODE Then
            e.Result = {statusForm, controller.Create_PurchaseNO(), Now, Nothing, Nothing}
        ElseIf controller.Mode = Set_Purchase_Model.EDIT_MODE Then
            e.Result = {statusForm, controller.Create_PurchaseNO(), controller.Get_OrderTime, controller.Search_Stock(Set_Purchase_Model.PRODUCT), controller.Search_Stock(Set_Purchase_Model.FIT)}
        End If

    End Sub

    Private Sub addPurchaseNoBackground_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles addPurchaseNoBackground.ProgressChanged
        e.UserState.Show()
    End Sub

    Private Sub addPurchaseNoBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles addPurchaseNoBackground.RunWorkerCompleted
        PurchaseNoText.Text = e.Result(1)
        PurchaseTime.Value = e.Result(2)
        If controller.Mode = Set_Purchase_Model.EDIT_MODE Then
            Dim prodArray As List(Of Set_Purchase_Model.PurchaseData) = e.Result(3)
            Dim fitArray As List(Of Set_Purchase_Model.PurchaseData) = e.Result(4)
            Dim index As Integer = 0 '紀錄ForEach迴圈數
            For Each data As Set_Purchase_Model.PurchaseData In prodArray
                ProdDGV.Rows.Add(data.DataID, data.Name, data.Supplier, data.Spicification, data.Width, data.Length, data.CBM, data.Count, data.Remark)
                controller.Set_PurchasePItem(index, data.PurchaseID, data.DataID, data.Spicification, data.Width, data.Length, data.CBM, data.Count, data.Remark)
                index += 1
            Next
            index = 0
            For Each data As Set_Purchase_Model.PurchaseData In fitArray
                FitDGV.Rows.Add(data.DataID, data.Name, data.Supplier, data.Spicification, data.Width, data.Length, data.CBM, data.Count, data.Remark)
                controller.Set_PurchasePart2em(index, data.PurchaseID, data.DataID, data.Spicification, data.Count, data.Remark, data.Width, data.Length, data.CBM)
                index += 1
            Next
        End If
        e.Result(0).Close()
    End Sub

    Private Sub AddPurchaseForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        addPurchaseNoBackground.RunWorkerAsync()
    End Sub

    Private Sub insertToDatabaseBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles insertToDatabaseBackground.DoWork
        Dim statusForm As Status_Normal_Form = New Status_Normal_Form("存檔中....")
        sender.ReportProgress(0, statusForm)
        e.Result = {statusForm, controller.Update_ToDataBase(PurchaseNoText.Text, PurchaseTime.Value)}
    End Sub

    Private Sub insertToDatabaseBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles insertToDatabaseBackground.RunWorkerCompleted
        If e.Result(1) Is Nothing Then
            e.Result(0).Close()
            Me.DialogResult = DialogResult.OK
            'If controller.Mode = Set_Purchase_Model.INSERT_MODE Then
            '    CType(Me.Owner, View_Form).toPurchaseSaleView.Show_Dialog_Result()
            'ElseIf controller.Mode = Set_Purchase_Model.EDIT_MODE Then
            '    CType(Me.Owner, Data_Order_Form).Show_Dialog_Result()
            'End If
            Me.Dispose()
        Else
            e.Result(0).dispose()
            MsgBox(e.Result(1))
        End If
    End Sub

    Private Sub InsertToDatabaseBackground_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles insertToDatabaseBackground.ProgressChanged
        e.UserState.Show()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()
    End Sub
    Private Sub FitDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles FitDGV.CellEnter
        If e.ColumnIndex >= 4 And e.ColumnIndex <= 7 Then
            sender.ImeMode = ImeMode.Disable
        Else
            sender.ImeMode = ImeMode.NoControl
        End If
    End Sub

    Private Sub FitDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FitDGV.CellClick
        If e.ColumnIndex() = 3 Then
            Dim Form As Set_Specification_Form = New Set_Specification_Form(FitDGV.CurrentRow.Cells(0).Value, 1, FitDGV.CurrentRow.Cells("fitSpecification").Value)
            If e.RowIndex < controller.Get_PurchasePart2Count And e.RowIndex <> -1 Then
                If Form.ShowDialog = DialogResult.OK Then
                    FitDGV.Item(3, e.RowIndex).Value = Form.strClassName
                    controller.Set_PurchasePart2em(e.RowIndex, Nothing, Nothing, Form.strClassName, Nothing, Nothing, Nothing, Nothing, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub AddPurchaseForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then
            e.Handled = True
            SendKeys.Send(vbTab)
        End If
    End Sub

    Private Sub ProdDGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles ProdDGV.EditingControlShowing

        If ProdDGV.CurrentCell.ColumnIndex >= 4 And ProdDGV.CurrentCell.ColumnIndex <= 7 Then
            e.Control.ImeMode = ImeMode.Disable
        Else
            e.Control.ImeMode = ImeMode.NoControl
        End If


    End Sub

    Private Sub ProdDGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ProdDGV.CellValueChanged, FitDGV.CellValueChanged
        If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
            sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = StrConv(sender.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, VbStrConv.Narrow)
        End If
    End Sub

    Private Sub ProdDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ProdDGV.RowPostPaint, FitDGV.RowPostPaint
        Using b As SolidBrush = New SolidBrush(sender.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString(e.RowIndex.ToString(System.Globalization.CultureInfo.CurrentCulture) + 1, sender.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4)
        End Using
    End Sub

    Private Sub InsertItem_Click(sender As Object, e As EventArgs) Handles InsertItem.Click
        If TabControl1.SelectedIndex = 0 Then
            If ProdDGV.CurrentRow.Index <> -1 Then
                ProdDGV.Rows.Insert(ProdDGV.CurrentRow.Index, New DataGridViewRow())
                controller.Insert_PurchasePart(ProdDGV.CurrentRow.Index)
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            If FitDGV.CurrentRow.Index <> -1 Then
                FitDGV.Rows.Insert(FitDGV.CurrentRow.Index, New DataGridViewRow())
                controller.Insert_PurchasePart2(FitDGV.CurrentRow.Index)
            End If
        End If


    End Sub
    Private Sub SelectProdItem_Click(sender As Object, e As EventArgs) Handles SelectProdItem.Click
        If TabControl1.SelectedIndex = 0 Then
            If ProdDGV.SelectedCells.Count > 0 Then
                Dim Form As Search_Form = New Search_Form(0, 0)
                If Form.ShowDialog = DialogResult.OK Then
                    controller.Set_PurchasePItem(ProdDGV.CurrentRow.Index, Nothing, Form.ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    ProdDGV.Item(0, ProdDGV.CurrentRow.Index).Value = Form.ID
                    ProdDGV.Item(1, ProdDGV.CurrentRow.Index).Value = Form.prodName
                    ProdDGV.Item(2, ProdDGV.CurrentRow.Index).Value = Form.suName
                End If
            Else
                MsgBox("請選擇資料欄位")
            End If

        ElseIf TabControl1.SelectedIndex = 1 Then
            If FitDGV.SelectedCells.Count > 0 Then
                Dim Form As Search_Form = New Search_Form(1, 0)
                If Form.ShowDialog = DialogResult.OK Then
                    controller.Set_PurchasePart2em(FitDGV.CurrentRow.Index, Nothing, Form.ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    FitDGV.Item(0, FitDGV.CurrentRow.Index).Value = Form.ID
                    FitDGV.Item(1, FitDGV.CurrentRow.Index).Value = Form.prodName
                    FitDGV.Item(2, FitDGV.CurrentRow.Index).Value = Form.suName
                End If
            Else
                MsgBox("請選擇資料欄位")
            End If
        End If
    End Sub

    Private Sub CopyItem_Click(sender As Object, e As EventArgs) Handles CopyItem.Click
        If TabControl1.SelectedIndex = 0 Then
            If ProdDGV.SelectedCells.Count > 0 Then
                controller.Copy_Row(ProdDGV.CurrentRow.Cells("prodID").Value, ProdDGV.CurrentRow.Cells("prodName").Value, ProdDGV.CurrentRow.Cells("prodSupplier").Value)
            Else
                MsgBox("請選擇要複製的資料欄位")
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            If FitDGV.SelectedCells.Count > 0 Then
                controller.Copy_Row(FitDGV.CurrentRow.Cells("ProdPart2ID").Value, FitDGV.CurrentRow.Cells("fitName").Value, FitDGV.CurrentRow.Cells("fitSupplier").Value)
            Else
                MsgBox("請選擇要複製的資料欄位")
            End If
        End If

    End Sub

    Private Sub PasteItem_Click(sender As Object, e As EventArgs) Handles PasteItem.Click
        If TabControl1.SelectedIndex = 0 Then
            If ProdDGV.SelectedCells.Count > 0 Then
                controller.Set_PurchasePItem(ProdDGV.CurrentRow.Index, Nothing, controller.Paste_Row.ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                ProdDGV.Item(0, ProdDGV.CurrentRow.Index).Value = controller.Paste_Row.ID
                ProdDGV.Item(1, ProdDGV.CurrentRow.Index).Value = controller.Paste_Row.Name
                ProdDGV.Item(2, ProdDGV.CurrentRow.Index).Value = controller.Paste_Row.Supplier
            End If
        ElseIf TabControl1.SelectedIndex = 1 Then
            If FitDGV.SelectedCells.Count > 0 Then
                controller.Set_PurchasePart2em(FitDGV.CurrentRow.Index, Nothing, controller.Paste_Row.ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                FitDGV.Item(0, FitDGV.CurrentRow.Index).Value = controller.Paste_Row.ID
                FitDGV.Item(1, FitDGV.CurrentRow.Index).Value = controller.Paste_Row.Name
                FitDGV.Item(2, FitDGV.CurrentRow.Index).Value = controller.Paste_Row.Supplier
            End If
        End If

    End Sub
    Private Sub MouseMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MouseMenu.Opening
        If controller.Paste_Row.ID = Nothing Then
            PasteItem.Enabled = False
        Else
            PasteItem.Enabled = True
        End If
    End Sub

    Private Sub MulAddItem_Click(sender As Object, e As EventArgs) Handles MulAddItem.Click
        Dim rowCount As Integer = InputBox("請輸入新增欄位數", "新增", 0)
        If TabControl1.SelectedIndex = 0 Then
            ProdDGV.RowCount += rowCount
            For i As Integer = 0 To rowCount - 1
                controller.Set_PurchasePItem(controller.Get_PurchasePartCount + 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Next
        ElseIf TabControl1.SelectedIndex = 1 Then
            FitDGV.RowCount += rowCount
            For i As Integer = 0 To rowCount - 1
                controller.Set_PurchasePart2em(controller.Get_PurchasePart2Count + 1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Next
        End If

    End Sub

End Class