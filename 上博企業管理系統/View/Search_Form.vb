Public Class Search_Form
    Private Const PURCHASE_MODE = 0
    Private Const SALE_MODE = 1
    Private prodForm As Boolean = True
    Public dataArray As ArrayList
    Private type As Integer = 0
    Public ID As Integer = Nothing
    Public prodName As String = Nothing
    Public suName As String = Nothing
    Private dictionaryArray As ArrayList = New ArrayList
    Public selectIndex As Integer = Nothing
    Private controller As Search_Controller = New Search_Controller
    Private intMode As Integer
    Private intClass As Integer = Nothing '紀錄設定的搜尋類別(產品、配件)
    Public Sub New(ByVal classData As ArrayList, ByVal title As String)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.dataArray = classData
        titleText.Text = title
        prodForm = False
        addBtn.Visible = False
        InsertItem()
    End Sub
    Public Sub New(ByVal intClass As Integer, ByVal mode As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        If mode = PURCHASE_MODE Then
            intMode = PURCHASE_MODE
            Me.intClass = intClass
            Me.dataArray = controller.SearchProd(intClass)
        ElseIf mode = SALE_MODE Then
            intMode = SALE_MODE
            Me.intClass = intClass
            Me.dataArray = controller.SearchStock(intClass)
        End If

        InsertItem()
    End Sub

    Private Sub SearchItem(ByVal str As String)
        itemList.Items.Clear()
        dictionaryArray.Clear()
        Dim index As Integer = 0
        For Each data As Array In dataArray
            If data(1).Contains(str) Then
                If intMode = PURCHASE_MODE Then
                    itemList.Items.Add(data(1) & "(" & data(2) & ")")
                ElseIf intMode = SALE_MODE Then
                    If intClass = 0 Then
                        itemList.Items.Add(data(1) & "(" & data(2) & ")" & "規格:" & data(3) & "剩餘數量:" & data(8))
                    ElseIf intClass = 1 Then
                        itemList.Items.Add(data(1) & "(" & data(2) & ")" & "規格:" & data(3) & "剩餘數量:" & data(5))
                    End If

                End If

                dictionaryArray.Add(index)
            End If
            index += 1
        Next
    End Sub
    Private Sub InsertItem()
        itemList.Items.Clear()
        dictionaryArray.Clear()
        Dim index As Integer = 0
        For Each data As Array In dataArray
            If intMode = PURCHASE_MODE Then
                itemList.Items.Add(data(1) & "(" & data(2) & ")")
            ElseIf intMode = SALE_MODE Then
                If intClass = 0 Then
                    itemList.Items.Add(data(1) & "(" & data(2) & ")" & "規格:" & data(3) & "剩餘數量:" & data(8))
                ElseIf intClass = 1 Then
                    itemList.Items.Add(data(1) & "(" & data(2) & ")" & "規格:" & data(3) & "剩餘數量:" & data(5))
                End If
            End If
            dictionaryArray.Add(index)
            index += 1
        Next

    End Sub

    Private Sub ItemList_DoubleClick(sender As Object, e As EventArgs) Handles itemList.DoubleClick
        selectIndex = dictionaryArray(itemList.SelectedIndex)
        If prodForm Then
            ID = dataArray(selectIndex)(0)
            prodName = dataArray(selectIndex)(1)
            suName = dataArray(selectIndex)(2)
        End If


        If selectIndex < 0 Then
            MsgBox("請選擇一項")
        Else
            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub searchText_TextChanged(sender As Object, e As EventArgs) Handles searchText.TextChanged
        SearchItem(searchText.Text)
        If searchText.Text = "" Then
            InsertItem()
        End If
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim prodName As String = InputBox("請輸入產品名稱", "新增產品", "在此輸入完整的產品名稱，系統會偵測是否重複新增")
        Dim supplierData As ArrayList = controller.LoadSupplierData()
        Dim classData As ArrayList = controller.LoadClassData()
        Dim Form As Search_Form = New Search_Form(supplierData, "供應商設定")
        Form.addBtn.Visible = False
        If Form.ShowDialog = DialogResult.OK Then
            Select Case intClass
                Case 0
                    If controller.SelectProdDataCount(prodName, supplierData(Form.selectIndex)(0)) = 0 Then
                        Dim index As Integer = controller.InsertData(0, prodName, supplierData(Form.selectIndex)(0))
                        ID = index
                        Me.prodName = prodName
                        suName = supplierData(Form.selectIndex)(1)
                        Me.DialogResult = DialogResult.OK
                    Else
                        MsgBox("此產品已經有資料了!", MsgBoxStyle.OkOnly, "無法新增")
                    End If
                Case 1
                    If controller.SelectFitDataCount(prodName, supplierData(Form.selectIndex)(0)) = 0 Then
                        Dim index As Integer = controller.InsertData(1, prodName, supplierData(Form.selectIndex)(0))
                        ID = index
                        Me.prodName = prodName
                        suName = supplierData(Form.selectIndex)(1)
                        Me.DialogResult = DialogResult.OK
                    Else
                        MsgBox("此產品已經有資料了!", MsgBoxStyle.OkOnly, "無法新增")
                    End If
            End Select

        End If

    End Sub

    Private Sub searchText_Enter(sender As Object, e As EventArgs) Handles searchText.Enter
        sender.IMEMode = ImeMode.OnHalf
    End Sub
End Class