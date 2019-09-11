Public Class Search_Model

    Public Structure StockProd
        Dim PurchasePID As Integer
        Dim Name As String
        Dim Supplier As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Remark As String
        Dim RemainAmount As Integer
    End Structure
    Public Structure StockFit
        Dim PurchaseFID As Integer
        Dim Name As String
        Dim Supplier As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Remark As String
        Dim RemainAmount As Integer
    End Structure
    Public Structure SearchProd
        Dim ProdID As Integer
        Dim Name As String
        Dim Supplier As String
    End Structure
    Public Structure SearchFit
        Dim FitID As Integer
        Dim Name As String
        Dim Supplier As String
    End Structure
End Class
