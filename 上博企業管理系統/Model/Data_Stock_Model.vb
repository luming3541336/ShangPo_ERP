Public Class Data_Stock_Model
    Protected Const SELECT_PRODSTOCK_SQL = "SELECT PurchaseData.InsertTime,ProdSet.[Name], SupplierData.[Name] AS Supplier,PurchaseProd.Specification,PurchaseProd.[Count],Width,[Length],CBM,PurchaseProd.Remark,([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) AS RemainAmount,CaseData.Place, CaseData.state
                                              From PurchaseProd LEFT Join SaleProd ON PurchaseProd.PurchasePID = SaleProd.PurchasePID, ProdSet,SupplierData,PurchaseData,CaseData
                                              Where PurchaseProd.ProdID = ProdSet.ProdID And ProdSet.SuID = SupplierData.SuID And PurchaseData.PurchaseID = PurchaseProd.PurchaseID And CaseData.CaseID = PurchaseData.CaseID And CaseData.state < 2
                                              Group By PurchaseProd.PurchasePID, ProdSet.[Name], PurchaseProd.Specification, PurchaseProd.[Count], Width, [Length], CBM, PurchaseProd.Remark, SupplierData.[Name], CaseData.Place,PurchaseData.InsertTime,CaseData.state
                                              Having([PurchaseProd].[Count] - SUM(ISNULL(SaleProd.[Count], 0))) > 0"
    Protected Const SELECT_FITSTOCK_SQL = "SELECT PurchaseData.InsertTime, FittingSet.[Name], SupplierData.[Name] AS Supplier,PurchaseFit.Width,PurchaseFit.[Length],PurchaseFit.CBM,PurchaseFit.Specification,PurchaseFit.[Count],PurchaseFit.Remark,(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) AS RemainAmount, CaseData.Place,CaseData.state
                                              From PurchaseFit LEFT Join SaleFit ON PurchaseFit.PurchaseFID = SaleFit.PurchaseFID, FittingSet,SupplierData, PurchaseData,CaseData
                                               Where PurchaseFit.FitID = FittingSet.FitID And FittingSet.SuID = SupplierData.SuID  AND CaseData.CaseID = PurchaseData.CaseID And PurchaseData.PurchaseID = PurchaseFit.PurchaseID And CaseData.state < 2
                                               Group By PurchaseFit.PurchaseFID, FittingSet.[Name], PurchaseFit.Specification, PurchaseFit.[Count],PurchaseFit.Remark, SupplierData.[Name],PurchaseFit.Width,PurchaseFit.[Length],PurchaseFit.CBM,CaseData.Place,PurchaseData.InsertTime,CaseData.state
                                               Having(PurchaseFit.[Count] - SUM(ISNULL(SaleFit.[Count], 0))) > 0"
    Public Structure StockData
        Dim InsertTime As DateTime
        Dim Name As String
        Dim SupplierName As String
        Dim Specification As String
        Dim Width As Double
        Dim Length As Double
        Dim CBM As Double
        Dim Count As Integer
        Dim Remark As String
        Dim CasePlace As String
        Dim State As Boolean
    End Structure
End Class
