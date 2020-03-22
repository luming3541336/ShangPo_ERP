Public Class UserControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel1.Visible Then
            Panel1.Visible = False
            sender.imageIndex = 1
        Else
            Panel1.Visible = True
            sender.imageIndex = 0
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CaseBtn.Click
        If Panel2.Visible Then
            Panel2.Visible = False
            sender.imageIndex = 1
        Else
            Panel2.Visible = True
            sender.imageIndex = 0
        End If

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Panel3.Visible Then
            Panel3.Visible = False
            sender.imageIndex = 1
        Else
            Panel3.Visible = True
            sender.imageIndex = 0
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Panel4.Visible Then
            Panel4.Visible = False
            sender.imageIndex = 1
        Else
            Panel4.Visible = True
            sender.imageIndex = 0
        End If

    End Sub


    Private Sub CasrViewBtn_Click(sender As Object, e As EventArgs) Handles CaseViewBtn.Click
        Dim View As Data_Case_Form = New Data_Case_Form
        View.Show()
    End Sub

    Private Sub ProdPartBtn_Click(sender As Object, e As EventArgs) Handles ProdPartBtn.Click
        Dim View As Data_ProdPart_Form = New Data_ProdPart_Form
        View.Show()
    End Sub

    Private Sub ClassBtn_Click(sender As Object, e As EventArgs) Handles ClassBtn.Click
        Dim View As Data_Specification_Form = New Data_Specification_Form
        View.Show()
    End Sub

    Private Sub StockViewBtn_Click(sender As Object, e As EventArgs) Handles StockViewBtn.Click
        Dim View As Data_Stock_Form = New Data_Stock_Form
        View.Show()
    End Sub

    Private Sub UserSetBtn_Click(sender As Object, e As EventArgs) Handles UserSetBtn.Click
        Dim View As Data_User_Form = New Data_User_Form
        View.Show()
    End Sub

    Private Sub UserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If L0 = 0 Then
            ProdPartBtn.Visible = False
        End If
        If L1 = 0 Then
            SupplierSetBtn.Visible = False
        End If
        If L2 = 0 Then
            ClassBtn.Visible = False
        End If
        If L3 = 0 Then
            CaseBtn.Visible = False
        End If
        If L4 = 0 Then
            StockViewBtn.Visible = False
        End If
        If L6 = 0 Then
            UserSetBtn.Visible = False
        End If
    End Sub

    Private Sub SupplierSetBtn_Click(sender As Object, e As EventArgs) Handles SupplierSetBtn.Click
        Dim View As Data_Supplier_Form = New Data_Supplier_Form
        View.Show()
    End Sub

    Private Sub ProductSetBtn_Click(sender As Object, e As EventArgs) Handles ProductSetBtn.Click
        Dim View As Data_Product_Form = New Data_Product_Form
        View.Show()
    End Sub
End Class
