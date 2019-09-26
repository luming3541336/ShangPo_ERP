Imports System.Data.SqlClient

Public Class Data_Order_Form
    Private updateCheck As Boolean = 0  ' 判斷是否有更新過資料，若有狀態則改為1，並且會在關閉瀏覽訂單時更新總表。
    Private controller As Data_Order_Controller = New Data_Order_Controller
    '產品資訊查詢訂單用
    Public Sub New(ByVal caseID As Integer, ByVal orderClass As Integer, ByVal orderID As Integer, ByVal currentPlace As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        controller.Set_CaseID(caseID)
        controller.Set_Place(currentPlace)
        If orderClass = 0 Then
            controller.Set_Type(Data_Order_Model.TYPE_PURCHASE)
        ElseIf orderClass = 1 Then
            controller.Set_Type(Data_Order_Model.TYPE_SALE)
            prodPIC.Visible = True
            fitPIC.Visible = True
        End If
        initiBackGround.RunWorkerAsync()
        Do While initiBackGround.IsBusy
            Application.DoEvents()
        Loop
        currentText.Text = controller.Get_OrderList_Index(orderID) + 1

        orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
        dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
        Do While getDetailBackGround.IsBusy
            Application.DoEvents()
        Loop
        getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
        If orderClass = 0 Then
            orderLabel.Text = "進貨單"
            orderNoLabel.Text = "進貨單號"
            dateNameText.Text = "進貨日期"
        ElseIf orderClass = 1 Then
            orderLabel.Text = "出貨單"
            orderNoLabel.Text = "出貨單號"
            dateNameText.Text = "出貨日期"
        End If
    End Sub
    Public Sub New(ByVal caseID As Integer, ByVal orderClass As Integer, ByVal currentCaseName As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。

        controller.Set_CaseID(caseID)
        controller.Set_Place(currentCaseName)
        If orderClass = 0 Then
            controller.Set_Type(Data_Order_Model.TYPE_PURCHASE)
        ElseIf orderClass = 1 Then
            controller.Set_Type(Data_Order_Model.TYPE_SALE)
            prodPIC.Visible = True
            fitPIC.Visible = True
        End If
        initiBackGround.RunWorkerAsync()
        If orderClass = 0 Then
            orderLabel.Text = "進貨單"
            orderNoLabel.Text = "進貨單號"
            dateNameText.Text = "進貨日期"
        ElseIf orderClass = 1 Then
            orderLabel.Text = "出貨單"
            orderNoLabel.Text = "出貨單號"
            dateNameText.Text = "出貨日期"
        End If
    End Sub

    Private Sub InitiBackGround_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles initiBackGround.DoWork
        e.Result = controller.Search_Order()
    End Sub
    Private Sub initiBackGround_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles initiBackGround.RunWorkerCompleted
        If e.Result <= 0 Then
            MsgBox("無訂單資料")
            Me.DialogResult = DialogResult.OK
            Exit Sub
        End If
        totalText.Text = e.Result
        currentText.Text = 1
        previousBtn.Enabled = False
        orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
        dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
        If CInt(currentText.Text) = CInt(totalText.Text) Then
            nextBtn.Visible = False
        Else
            nextBtn.Enabled = True
        End If
        getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
    End Sub

    Private Sub getDetailBackGround_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles getDetailBackGround.DoWork
        e.Result = {controller.Get_Prod_Detail(e.Argument), controller.Get_Fit_Detail(e.Argument)}
    End Sub

    Private Sub getDetailBackGround_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles getDetailBackGround.RunWorkerCompleted
        prodDGV.Rows.Clear()
        FitDGV.Rows.Clear()
        For Each data As Data_Order_Model.ProdDetail In e.Result(0) 'ProdArray
            prodDGV.Rows.Add(data.ProdPartID, data.SupplierName, data.Name, data.Specification, data.Width, data.Length, data.CBM, data.Count, data.Remark, data.PIC)
        Next
        For Each data As Data_Order_Model.FitDetail In e.Result(1) 'FitArray
            FitDGV.Rows.Add(data.ProdPart2ID, data.SupplierName, data.Name, data.Specification, data.Width, data.Length, data.CBM, data.Count, data.Remark, data.PIC)
        Next

    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        currentText.Text += 1
        If CInt(currentText.Text) = CInt(totalText.Text) Then
            nextBtn.Enabled = False
        End If
        If CInt(currentText.Text) <> 1 Then
            previousBtn.Enabled = True
        End If
        orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
        dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
        getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        currentText.Text -= 1
        If CInt(currentText.Text) <> CInt(totalText.Text) Then
            nextBtn.Enabled = True
        End If
        If CInt(currentText.Text) = 1 Then
            previousBtn.Enabled = False
        End If
        orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
        dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
        getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)

    End Sub

    Private Sub ViewOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L4 = 1 Then
            DelBtn.Visible = False
            editBtn.Visible = False
        End If
    End Sub
    Public Sub Show_Dialog_Result()
        controller.Search_Order()
        orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
        dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
        getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
        updateCheck = True
    End Sub
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        Select Case controller.Get_Type
            Case Data_Order_Model.TYPE_PURCHASE
                Dim toAddPurchaseForm As Set_Purchase_Form = New Set_Purchase_Form(controller.Get_CaseID, controller.Get_Order_Data(CInt(currentText.Text) - 1).ID, controller.Get_Place)
                If toAddPurchaseForm.ShowDialog = DialogResult.OK Then
                    controller.Search_Order()
                    orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
                    dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
                    getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
                    updateCheck = True
                End If
            Case Data_Order_Model.TYPE_SALE
                Dim toAddSaleForm As Set_Sale_Form = New Set_Sale_Form(controller.Get_CaseID, controller.Get_Order_Data(CInt(currentText.Text) - 1).ID, controller.Get_Place)
                If toAddSaleForm.ShowDialog = DialogResult.OK Then
                    controller.Search_Order()
                    orderText.Text = controller.Get_Order_Data(CInt(currentText.Text) - 1).Number
                    dateTime.Value = controller.Get_Order_Data(CInt(currentText.Text) - 1).InsertTime
                    getDetailBackGround.RunWorkerAsync(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
                    updateCheck = True
                End If
        End Select
    End Sub

    Private Sub ViewOrderForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If updateCheck Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        MsgBox("若刪除訂單，將無法復原，確認要刪除嗎?", MsgBoxStyle.OkCancel, "注意")
        Select Case controller.Get_Type
            Case Data_Order_Model.TYPE_PURCHASE
                Try
                    controller.Delete_Purchase_Order(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
                    MsgBox("刪除完成", MsgBoxStyle.OkCancel, "注意")
                    initiBackGround.RunWorkerAsync()
                    updateCheck = True
                Catch ex As Exception
                    MsgBox("此訂單已有出貨紀錄，無法刪除", MsgBoxStyle.OkOnly, "錯誤")
                End Try
            Case Data_Order_Model.TYPE_SALE
                Try
                    controller.Delete_Sale_Order(controller.Get_Order_Data(CInt(currentText.Text) - 1).ID)
                    MsgBox("刪除完成", MsgBoxStyle.OkCancel, "注意")
                    initiBackGround.RunWorkerAsync()
                    updateCheck = True
                Catch ex As Exception
                    MsgBox("此訂單無法刪除", MsgBoxStyle.OkOnly, "錯誤")
                End Try
        End Select
    End Sub

End Class