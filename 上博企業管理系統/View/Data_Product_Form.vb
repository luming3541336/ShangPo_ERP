Imports System.Drawing

Public Class Data_Product_Form
    Dim controller As Data_Product_Controller = New Data_Product_Controller
    Dim tabName As String = "ProdTab"


    Private Sub LoadProductWorker_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles LoadProductWorker.DoWork
        LoadProductWorker.ReportProgress(0)
        Select Case tabName
            Case "ProdTab"
                If e.Argument Is Nothing Then
                    e.Result = controller.Select_ProdPartData
                Else
                    e.Result = controller.Select_ProdPartData(e.Argument(0), e.Argument(1))
                End If
            Case "FitTab"
                If e.Argument Is Nothing Then
                    e.Result = controller.Select_ProdPartData2
                Else
                    e.Result = controller.Select_ProdPartData2(e.Argument(0), e.Argument(1))
                End If

        End Select

    End Sub

    Private Sub LoadProductWorker_RunWorkerCompleted(sender As Object, e As ComponentModel.RunWorkerCompletedEventArgs) Handles LoadProductWorker.RunWorkerCompleted
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                ViewDGV.Rows.Clear()
                For Each data As Data_Product_Model.Prod In e.Result
                    ViewDGV.Rows.Add(data.ProdPartID, data.SuID, data.SupplierName, data.ProdName, data.ProdNumber)
                Next
                LoadingPic.Visible = False
            Case FitTab.Name
                ViewFDGV.Rows.Clear()
                For Each data As Data_Product_Model.Prod In e.Result
                    ViewFDGV.Rows.Add(data.ProdPartID, data.SuID, data.SupplierName, data.ProdName, data.ProdNumber)
                Next
                LoadingFPic.Visible = False
        End Select

    End Sub

    Private Sub ViewDGV_CurrentCellChanged(sender As Object, e As EventArgs) Handles ViewFDGV.CurrentCellChanged, ViewDGV.CurrentCellChanged
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                If ViewDGV.CurrentRow IsNot Nothing Then
                    SupplierNameCB.SelectedIndex = SupplierNameCB.Items.IndexOf(IIf(ViewDGV.CurrentRow.Cells("ProdSupplierName").Value <> Nothing, ViewDGV.CurrentRow.Cells("ProdSupplierName").Value, 0))
                    ProdNameText.Text = ViewDGV.CurrentRow.Cells("ProdName").Value
                    ProdNumberText.Text = ViewDGV.CurrentRow.Cells("ProdNumber").Value
                    ProdDetailDGV.Rows.Clear()
                    For Each data As Data_Product_Model.PuchaseData In controller.Select_PurchaseData(ViewDGV.CurrentRow.Cells("ProdPartID").Value)
                        ProdDetailDGV.Rows.Add(data.PurchaseID, data.CaseID, data.CaseName, data.PurchaseNo, data.Specification, data.Count, data.InsertTime)
                    Next
                End If
            Case FitTab.Name
                If ViewFDGV.CurrentRow IsNot Nothing Then
                    SupplierFCB.SelectedIndex = SupplierFCB.Items.IndexOf(IIf(ViewFDGV.CurrentRow.Cells("FitSupplierName").Value <> Nothing, ViewFDGV.CurrentRow.Cells("FitSupplierName").Value, 0))
                    FitNameText.Text = ViewFDGV.CurrentRow.Cells("FitName").Value
                    FitNumberText.Text = ViewFDGV.CurrentRow.Cells("FitNumber").Value
                    FitDetailDGV.Rows.Clear()
                    For Each data As Data_Product_Model.PuchaseData In controller.Select_PurchaseFData(ViewFDGV.CurrentRow.Cells("ProdPart2ID").Value)
                        FitDetailDGV.Rows.Add(data.PurchaseID, data.CaseID, data.CaseName, data.PurchaseNo, data.Specification, data.Count, data.InsertTime)
                    Next
                End If
        End Select

    End Sub
    Private Sub DataProductForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadingPic.Visible = True
        LoadProductWorker.RunWorkerAsync()
        For Each data As Data_Product_Model.SupplierData In controller.Select_Supplier
            SupplierNameCB.Items.Add(data.Name)
            SupplierFCB.Items.Add(data.Name)
        Next
    End Sub
    Private Sub DataProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L1 = 1 Then
            ControlLayout.Visible = False
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddFBtn.Click, AddBtn.Click
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                ProdNameText.ReadOnly = False
                ProdNumberText.ReadOnly = False
                SupplierNameCB.Enabled = True
                OKBtn.Visible = True
                CancelBtn.Visible = True
                AddBtn.Visible = False
                ReviseBtn.Visible = False
                DelBtn.Visible = False
                ViewDGV.Enabled = False
                ViewDGV.Rows.Add()
                ViewDGV.CurrentCell = ViewDGV.Rows(ViewDGV.Rows.Count - 1).Cells(2)
                controller.Set_InsertMode()
            Case FitTab.Name
                FitNameText.ReadOnly = False
                FitNumberText.ReadOnly = False
                SupplierFCB.Enabled = True
                OKFBtn.Visible = True
                CancelFBtn.Visible = True
                AddFBtn.Visible = False
                ReviseFBtn.Visible = False
                DelFBtn.Visible = False
                ViewFDGV.Enabled = False
                ViewFDGV.Rows.Add()
                ViewFDGV.CurrentCell = ViewFDGV.Rows(ViewFDGV.Rows.Count - 1).Cells(2)
                controller.Set_InsertMode()
        End Select



    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKFBtn.Click, OKBtn.Click
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                Select Case controller.Get_Mode
                    Case Data_Product_Model.INSERT_MODE
                        Dim index As Integer = controller.Insert_ProdPartData(controller.Get_listSuID(SupplierNameCB.SelectedIndex), ProdNameText.Text, ProdNumberText.Text)
                        ViewDGV.CurrentRow.Cells("ProdPartID").Value = index
                        ViewDGV.CurrentRow.Cells("ProdSupplierName").Value = SupplierNameCB.SelectedItem
                        ViewDGV.CurrentRow.Cells("ProdName").Value = ProdNameText.Text
                        ViewDGV.CurrentRow.Cells("ProdNumber").Value = ProdNumberText.Text
                        ViewDGV.CurrentRow.Cells("ProdSuID").Value = controller.Get_listSuID(SupplierNameCB.SelectedIndex)
                    Case Data_Product_Model.REVISE_MODE
                        Dim index As Integer = controller.Update_ProdPartData(ViewDGV.CurrentRow.Cells("ProdPartID").Value, controller.Get_listSuID(SupplierNameCB.SelectedIndex), ProdNameText.Text, ProdNumberText.Text)
                        ViewDGV.CurrentRow.Cells("ProdSupplierName").Value = SupplierNameCB.SelectedItem
                        ViewDGV.CurrentRow.Cells("ProdName").Value = ProdNameText.Text
                        ViewDGV.CurrentRow.Cells("ProdNumber").Value = ProdNumberText.Text
                        ViewDGV.CurrentRow.Cells("ProdSuID").Value = controller.Get_listSuID(SupplierNameCB.SelectedIndex)
                End Select
                ProdNumberText.ReadOnly = True
                ProdNameText.ReadOnly = True
                SupplierNameCB.Enabled = False
                ViewDGV.Enabled = True
                AddBtn.Visible = True
                ReviseBtn.Visible = True
                DelBtn.Visible = True
                OKBtn.Visible = False
                CancelBtn.Visible = False
                controller.Set_NormalMode()
            Case FitTab.Name
                Select Case controller.Get_Mode
                    Case Data_Product_Model.INSERT_MODE
                        Dim index As Integer = controller.Insert_ProdPartData2(controller.Get_listSuID(SupplierFCB.SelectedIndex), FitNameText.Text, FitNumberText.Text)
                        ViewFDGV.CurrentRow.Cells("ProdPart2ID").Value = index
                        ViewFDGV.CurrentRow.Cells("FitSupplierName").Value = SupplierFCB.SelectedItem
                        ViewFDGV.CurrentRow.Cells("FitName").Value = FitNameText.Text
                        ViewFDGV.CurrentRow.Cells("FitNumber").Value = FitNumberText.Text
                        ViewFDGV.CurrentRow.Cells("FitSuID").Value = controller.Get_listSuID(SupplierFCB.SelectedIndex)
                    Case Data_Product_Model.REVISE_MODE
                        Dim index As Integer = controller.Update_ProdPartData2(ViewFDGV.CurrentRow.Cells("ProdPart2ID").Value, controller.Get_listSuID(SupplierFCB.SelectedIndex), FitNameText.Text, FitNumberText.Text)
                        ViewFDGV.CurrentRow.Cells("FitSupplierName").Value = SupplierFCB.SelectedItem
                        ViewFDGV.CurrentRow.Cells("FitName").Value = FitNameText.Text
                        ViewFDGV.CurrentRow.Cells("FitNumber").Value = FitNumberText.Text
                        ViewFDGV.CurrentRow.Cells("FitSuID").Value = controller.Get_listSuID(SupplierFCB.SelectedIndex)
                End Select
                FitNumberText.ReadOnly = True
                FitNameText.ReadOnly = True
                ViewFDGV.Enabled = True
                SupplierFCB.Enabled = False
                AddFBtn.Visible = True
                ReviseFBtn.Visible = True
                DelFBtn.Visible = True
                OKFBtn.Visible = False
                CancelFBtn.Visible = False
                controller.Set_NormalMode()
        End Select

    End Sub

    Private Sub ReviseBtn_Click(sender As Object, e As EventArgs) Handles ReviseFBtn.Click, ReviseBtn.Click
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                ProdNameText.ReadOnly = False
                ProdNumberText.ReadOnly = False
                SupplierNameCB.Enabled = True
                OKBtn.Visible = True
                CancelBtn.Visible = True
                AddBtn.Visible = False
                ReviseBtn.Visible = False
                ViewDGV.Enabled = False
                DelBtn.Visible = False
                controller.Set_ReviseMode()
            Case FitTab.Name
                FitNameText.ReadOnly = False
                FitNumberText.ReadOnly = False
                SupplierFCB.Enabled = True
                ViewFDGV.Enabled = False
                OKFBtn.Visible = True
                CancelFBtn.Visible = True
                AddFBtn.Visible = False
                ReviseFBtn.Visible = False
                DelFBtn.Visible = False
                controller.Set_ReviseMode()
        End Select



    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelFBtn.Click, DelBtn.Click

        Dim Result As MsgBoxResult = MsgBox("您確認要刪除?刪除後將無法復原", MsgBoxStyle.YesNo, "警告")
        If Result = MsgBoxResult.Yes Then
            Try
                Select Case TabControl1.SelectedTab.Name
                    Case ProdTab.Name
                        controller.Del_ProdPartData(ViewDGV("ProdPartID", ViewDGV.CurrentRow.Index).Value)
                        ViewDGV.Rows.RemoveAt(ViewDGV.CurrentRow.Index)
                    Case FitTab.Name
                        controller.Del_ProdPartData(ViewFDGV("ProdPart2ID", ViewFDGV.CurrentRow.Index).Value)
                        ViewFDGV.Rows.RemoveAt(ViewFDGV.CurrentRow.Index)
                End Select
            Catch ex As Exception
                MsgBox("無法刪除產品，可能已經有使用")
            End Try

        End If
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click, SearchFBtn.Click
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                If SearchCB.SelectedIndex <> -1 Then
                    LoadingPic.Visible = True
                    LoadProductWorker.RunWorkerAsync({SearchCB.SelectedIndex, SearchText.Text})
                ElseIf SearchCB.SelectedIndex = -1 Then
                    MsgBox("請設定查詢類別")
                End If
            Case FitTab.Name
                If SearchFCB.SelectedIndex <> -1 Then
                    LoadingFPic.Visible = True
                    LoadProductWorker.RunWorkerAsync({SearchFCB.SelectedIndex, SearchFText.Text})
                ElseIf SearchFCB.SelectedIndex = -1 Then
                    MsgBox("請設定查詢類別")
                End If
        End Select

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelFBtn.Click, CancelBtn.Click
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                If controller.Get_Mode = Data_Product_Model.INSERT_MODE Then
                    ViewDGV.Rows.RemoveAt(ViewDGV.CurrentCell.RowIndex)
                End If
                ProdNumberText.ReadOnly = True
                ProdNameText.ReadOnly = True
                SupplierNameCB.Enabled = False
                AddBtn.Visible = True
                ReviseBtn.Visible = True
                ViewDGV.Enabled = True
                DelBtn.Visible = True
                OKBtn.Visible = False
                CancelBtn.Visible = False
                controller.Set_NormalMode()
            Case FitTab.Name
                If controller.Get_Mode = Data_Product_Model.INSERT_MODE Then
                    ViewFDGV.Rows.RemoveAt(ViewFDGV.CurrentCell.RowIndex)
                End If
                FitNumberText.ReadOnly = True
                FitNameText.ReadOnly = True
                SupplierFCB.Enabled = False
                ViewFDGV.Enabled = True
                AddFBtn.Visible = True
                ReviseFBtn.Visible = True
                DelFBtn.Visible = True
                OKFBtn.Visible = False
                CancelFBtn.Visible = False
                controller.Set_NormalMode()

        End Select

    End Sub
    Private Sub ProdDetailDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProdDetailDGV.CellDoubleClick, FitDetailDGV.CellDoubleClick
        If e.RowIndex <> -1 Then
            Select Case TabControl1.SelectedTab.Name
                Case ProdTab.Name
                    Dim toViewOrderForm As Data_Order_Form = New Data_Order_Form(ProdDetailDGV.CurrentRow.Cells("CaseIDProd").Value, 0, ProdDetailDGV.CurrentRow.Cells("PurchaseIDProd").Value, ProdDetailDGV.CurrentRow.Cells("PlaceProd").Value) '查詢進貨資料
                    toViewOrderForm.Show()
                Case FitTab.Name
                    Dim toViewOrderForm As Data_Order_Form = New Data_Order_Form(FitDetailDGV.CurrentRow.Cells("CaseIDFit").Value, 0, FitDetailDGV.CurrentRow.Cells("PurchaseIDFit").Value, FitDetailDGV.CurrentRow.Cells("PlaceFit").Value) '查詢進貨資料
                    toViewOrderForm.Show()
            End Select

        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        tabName = TabControl1.SelectedTab.Name
        LoadProductWorker.RunWorkerAsync()
        Select Case TabControl1.SelectedTab.Name
            Case ProdTab.Name
                LoadingPic.Visible = True
            Case FitTab.Name
                LoadingFPic.Visible = True
        End Select

    End Sub
End Class