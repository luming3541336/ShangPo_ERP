Public Class ProdSet
    Public ReadOnly ProdID As Integer = Nothing
    Public SuID As Integer = Nothing
    Public Number As String = Nothing
    Public Name As String = Nothing

    Public ImgPath As String = Nothing
    Public Sub New(ByVal ID As Integer, ByVal Supplier As Integer, ByVal Number As String, ByVal Name As String, ByVal ImgPath As String)
        ProdID = ID
        SuID = Supplier
        Me.Number = Number
        Me.Name = Name

        Me.ImgPath = ImgPath
    End Sub
End Class
Public Class SupplierData
    Public SuID As Integer = Nothing
    Public Number As String = Nothing
    Public Name As String = Nothing
    Public CpyID As Integer = Nothing
    Public Address As String = Nothing
    Public Contact As String = Nothing
    Public Phone As String = Nothing
    Public Sub New(ByVal SuID As Integer, ByVal Number As String, ByVal Name As String, ByVal CpyID As Integer, ByVal Address As String,
                   ByVal Contact As String, ByVal Phone As String)
        Me.SuID = SuID
        Me.Number = Number
        Me.Name = Name
        Me.CpyID = CpyID
        Me.Address = Address
        Me.Contact = Contact
        Me.Phone = Phone
    End Sub
End Class
Public Class ClassData

    Public Name As String = Nothing
    Public Number As String = Nothing
    Public Sub New(ByVal Name As String, ByVal Number As String)

        Me.Name = Name
        Me.Number = Number
    End Sub
End Class
Public Class FittingSet
    Public FitID As Integer = Nothing
    Public SuID As Integer = Nothing
    Public Name As String = Nothing
    Public Number As String = Nothing
    Public Specification As String = Nothing
    Public Sub New(ByVal FitID As Integer, ByVal SuID As Integer, ByVal Name As String, ByVal Number As String, ByVal Specification As String)
        Me.FitID = FitID
        Me.SuID = SuID
        Me.Name = Name
        Me.Number = Number
        Me.Specification = Specification
    End Sub
End Class
Public Class ProdFit
    Public ProdFitID As Integer = Nothing
    Public ProdID As Integer = Nothing
    Public FitID As Integer = Nothing
    Public Count As Integer = Nothing

    Public Sub New(ByVal ProdFitID As Integer, ByVal ProdID As Integer, ByVal FitID As Integer, ByVal Count As Integer)
        Me.ProdFitID = ProdFitID
        Me.ProdID = ProdID
        Me.FitID = FitID
        Me.Count = Count
    End Sub
End Class
Public Class Specification
    Public SpecID As Integer = Nothing
    Public SuID As Integer = Nothing
    Public ClassName As String = Nothing
    Public Sub New(ByVal SpecID As Integer, ByVal SuID As Integer, ByVal ClassName As String)
        Me.SpecID = SpecID
        Me.SuID = SuID
        Me.ClassName = ClassName
    End Sub
End Class
Public Class SpecificationDetail
    Public ReadOnly SpecDetailID As Integer = Nothing
    Public SpecID As Integer = Nothing
    Public DetailName As String = Nothing
    Public Sub New(ByVal SpecDetailID As Integer, ByVal SpecID As Integer, ByVal DetailName As String)
        Me.SpecDetailID = SpecDetailID
        Me.SpecID = SpecID
        Me.DetailName = DetailName
    End Sub
End Class
Public Class SpecificationForProd
    Public SpecForProdID As Integer = Nothing
    Public ProdID As Integer = Nothing
    Public SpecDetailID As Integer = Nothing
    Public Sub New(ByVal SpecForProdID As Integer, ByVal ProdID As Integer, ByVal SpecDetailID As Integer)
        Me.SpecForProdID = SpecForProdID
        Me.ProdID = ProdID
        Me.SpecDetailID = SpecDetailID
    End Sub
End Class
Public Class ProdStock
    Public ProdStockID As Integer = Nothing
    Public ProdID As Integer = Nothing
    Public Count As Integer = Nothing
    Public Sub New(ByVal ProdStockID As Integer, ByVal ProdID As Integer, ByVal Count As Integer)
        Me.ProdStockID = ProdStockID
        Me.ProdID = ProdID
        Me.Count = Count
    End Sub
End Class
Public Class FitStock
    Public FitStockID As Integer = Nothing
    Public FitID As Integer = Nothing
    Public Count As Integer = Nothing
    Public Sub New(ByVal FitStockID As Integer, ByVal FitID As Integer, ByVal Count As Integer)
        Me.FitStockID = FitStockID
        Me.FitID = FitID
        Me.Count = Count
    End Sub
End Class
Public Class CaseData
    Public CaseID As Integer = Nothing
    Public CaseNo As String = Nothing
    Public Place As String = Nothing
    Public LoginID As Integer = Nothing
    Public SalesName As String = Nothing
    Public InsertTime As String = Nothing
    Public UpdateTime As String = Nothing
    Public Success As Boolean = Nothing
    Public Del As Boolean = Nothing
    Public Sub New(ByVal CaseID As Integer, ByVal CaseNo As String, ByVal Place As String, ByVal LoginID As Integer, ByVal SalesName As String, ByVal InsertTime As String,
                   ByVal UpdateTime As String, ByVal Success As Boolean, ByVal Del As Boolean)
        Me.CaseID = CaseID
        Me.CaseNo = CaseNo
        Me.Place = Place
        Me.LoginID = LoginID
        Me.SalesName = SalesName
        Me.InsertTime = InsertTime
        Me.UpdateTime = UpdateTime
        Me.Success = Success
        Me.Del = Del
    End Sub
End Class
Public Class PurchaseProd
    Public PurchasePID As Integer = Nothing
    Public PurchaseID As Integer = Nothing
    Public ProdID As Integer = Nothing
    Public Count As Integer = Nothing
    Public Specification As String = Nothing
    Public Width As Double = Nothing
    Public Length As Double = Nothing
    Public CBM As Double = Nothing
    Public Remark As String = Nothing
    Public Sub New(ByVal PurchasePID As Integer, ByVal PurchaseID As Integer, ByVal ProdID As Integer, ByVal Count As Integer, ByVal Specification As String, ByVal Width As Double, ByVal Length As Double, ByVal CBM As Double, ByVal Remark As String)
        Me.PurchasePID = PurchasePID
        Me.PurchaseID = PurchaseID
        Me.ProdID = ProdID
        Me.Count = Count
        Me.Specification = Specification
        Me.Width = Width
        Me.Length = Length
        Me.CBM = CBM
        Me.Remark = Remark
    End Sub
End Class
Public Class PurchaseFit
    Public PurchaseFID As Integer = Nothing
    Public PurchaseID As Integer = Nothing
    Public FitID As Integer = Nothing
    Public Width As Double = Nothing
    Public Length As Double = Nothing
    Public CBM As Double = Nothing
    Public Count As Integer = Nothing
    Public Specification As String = Nothing
    Public Remark As String = Nothing

    Public Sub New(ByVal PurchaseFID As Integer, ByVal PurchaseID As Integer, ByVal FitID As Integer, ByVal Count As Integer, ByVal Specification As String, ByVal Width As Double, ByVal Length As Double, ByVal CBM As Double, ByVal Remark As String)
        Me.PurchaseFID = PurchaseFID
        Me.PurchaseID = PurchaseID
        Me.FitID = FitID
        Me.Width = Width
        Me.Length = Length
        Me.CBM = CBM
        Me.Count = Count
        Me.Specification = Specification
        Me.Remark = Remark
    End Sub
End Class
Public Class SaleProd
    Public SalePID As Integer = Nothing
    Public SaleID As Integer = Nothing
    Public PurchasePID As Integer = Nothing
    Public Count As Integer = Nothing
    Public Sub New(ByVal SalePID As Integer, ByVal SaleID As Integer, ByVal PurchasePID As Integer, ByVal Count As Integer)
        Me.SalePID = SalePID
        Me.SaleID = SaleID
        Me.PurchasePID = PurchasePID
        Me.Count = Count
    End Sub
End Class
Public Class SaleFit
    Public SaleFID As Integer = Nothing
    Public SaleID As Integer = Nothing
    Public PurchaseFID As Integer = Nothing
    Public Count As Integer = Nothing
    Public Sub New(ByVal SaleFID As Integer, ByVal SaleID As Integer, ByVal PurchaseFID As Integer, ByVal Count As Integer)
        Me.SaleFID = SaleFID
        Me.SaleID = SaleID
        Me.PurchaseFID = PurchaseFID
        Me.Count = Count
    End Sub
End Class