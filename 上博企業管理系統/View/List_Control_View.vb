Public Class List_Control_View

    Private Sub prodSetButton_Click(sender As Object, e As EventArgs) Handles prodSetButton.Click, supplierSetButton.Click, stockButton.Click, purchaseSaleBtn.Click, SetBtn.Click, PrintBtn.Click
        Select Case sender.name
            Case "prodSetButton"
                Dim toViewForm As Data_Product_Form = New Data_Product_Form
                toViewForm.Show()
            Case "supplierSetButton"
                Dim toViewForm As Data_Supplier_Form = New Data_Supplier_Form
                toViewForm.Show()
            Case "stockButton"
                Dim toViewForm As StockForm = New StockForm
                toViewForm.Show()
            Case "purchaseSaleBtn"
                Dim toViewForm As Data_Case_Form = New Data_Case_Form
                toViewForm.Show()
            Case "SetBtn"
                Dim toViewForm As Data_Specification_Form = New Data_Specification_Form
                toViewForm.Show()

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UserSetBtn.Click
        Dim showForm As Data_User_Form = New Data_User_Form
        showForm.Show()
    End Sub

    Private Sub List_Control_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrL() As Integer = {L0, L1, L2, L3, L4, L5, L6}
        Dim arrBtn() As Button = {UserSetBtn, prodSetButton, supplierSetButton, stockButton, purchaseSaleBtn, SetBtn, PrintBtn}
        For i = 0 To 6
            If arrL(i) = 0 Then
                arrBtn(i).Visible = False
            End If
        Next
    End Sub
End Class
