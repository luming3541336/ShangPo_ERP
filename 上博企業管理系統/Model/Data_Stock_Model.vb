Public Class Data_Stock_Model
    Protected Const SELECT_PRODSTOCK_SQL = "SELECT PurchaseData.InsertTime,ProdPartData.[Name], SupplierData.[Name] AS Supplier,PurchasePart.Specification,PurchasePart.[Count],Width,[Length],CBM,PurchasePart.Remark,([PurchasePart].[Count] - SUM(ISNULL(ShipmentPart.[Count], 0))) AS RemainAmount,CaseData.Place, CaseData.state
                                              From PurchasePart LEFT Join ShipmentPart ON PurchasePart.PurchasePID = ShipmentPart.PurchasePID, ProdPartData,SupplierData,PurchaseData,CaseData
                                              Where PurchasePart.ProdPartID = ProdPartData.ProdPartID And ProdPartData.SuID = SupplierData.SuID And PurchaseData.PurchaseID = PurchasePart.PurchaseID And CaseData.CaseID = PurchaseData.CaseID And CaseData.state < 2
                                              Group By PurchasePart.PurchasePID, ProdPartData.[Name], PurchasePart.Specification, PurchasePart.[Count], Width, [Length], CBM, PurchasePart.Remark, SupplierData.[Name], CaseData.Place,PurchaseData.InsertTime,CaseData.state
                                              Having([PurchasePart].[Count] - SUM(ISNULL(ShipmentPart.[Count], 0))) > 0"
    Protected Const SELECT_FITSTOCK_SQL = "SELECT PurchaseData.InsertTime, ProdPartData2.[Name], SupplierData.[Name] AS Supplier,PurchasePart2.Width,PurchasePart2.[Length],PurchasePart2.CBM,PurchasePart2.Specification,PurchasePart2.[Count],PurchasePart2.Remark,(PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) AS RemainAmount, CaseData.Place,CaseData.state
                                              From PurchasePart2 LEFT Join ShipmentPart2 ON PurchasePart2.PurchaseP2ID = ShipmentPart2.PurchaseP2ID, ProdPartData2,SupplierData, PurchaseData,CaseData
                                               Where PurchasePart2.ProdPart2ID = ProdPartData2.ProdPart2ID And ProdPartData2.SuID = SupplierData.SuID  AND CaseData.CaseID = PurchaseData.CaseID And PurchaseData.PurchaseID = PurchasePart2.PurchaseID And CaseData.state < 2
                                               Group By PurchasePart2.PurchaseP2ID, ProdPartData2.[Name], PurchasePart2.Specification, PurchasePart2.[Count],PurchasePart2.Remark, SupplierData.[Name],PurchasePart2.Width,PurchasePart2.[Length],PurchasePart2.CBM,CaseData.Place,PurchaseData.InsertTime,CaseData.state
                                               Having(PurchasePart2.[Count] - SUM(ISNULL(ShipmentPart2.[Count], 0))) > 0"
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
