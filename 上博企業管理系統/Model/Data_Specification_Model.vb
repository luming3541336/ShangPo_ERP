Public Class Data_Specification_Model
    Protected Const SELECT_SUPPLIER_SQL As String = "SELECT SuID, Name FROM SupplierData"
    Protected Const SELECT_SPEC_SQL As String = "SELECT SpecID, ClassName FROM Specification WHERE SuID = @suID"
    Protected Const SELECT_SPEC_DETAIL_SQL As String = "SELECT SpecDetailID, DetailName FROM SpecificationDetail WHERE SpecID = @specID"
    Protected Const INSERT_SPEC_SQL As String = "INSERT INTO Specification(SuID,ClassName) VALUES (@suID,N'@className'); SELECT id = SCOPE_IDENTITY();"
    Protected Const INSERT_SPEC_DETAIL_SQL As String = "INSERT INTO SpecificationDetail(SpecID,DetailName) VALUES (@specID,N'@detailName'); SELECT id = SCOPE_IDENTITY();"
    Protected Const UPDATE_SPEC_SQL As String = "UPDATE Specification SET ClassName = N'@className' WHERE SpecID = @specID"
    Protected Const UPDATE_SPEC_DETAIL_SQL As String = "UPDATE SpecificationDetail SET DetailName = N'@detailName' WHERE SpecDetailID = @specDetailID"
    Protected Const DELETE_SPEC_SQL As String = "DELETE FROM Specification WHERE SpecID = @specID"
    Protected Const DELETE_SPEC_DETAIL_SQL As String = "DELETE FROM SpecificationDetail WHERE SpecDetailID = @specDetailID"
    Protected Const DELETE_SPEC_DETAIL_ALL_SQL As String = "DELETE FROM SpecificationDetail WHERE SpecID = @specID"
    Public dataSupplier As List(Of Integer) = New List(Of Integer)
    Public dataSpec As List(Of Integer) = New List(Of Integer)
    Public dataSpecDetail As List(Of Integer) = New List(Of Integer)
    Public Structure Supplier
        Dim SuID As Integer
        Dim Name As String
    End Structure
    Public Structure Spec
        Dim SpecID As Integer
        Dim ClassName As String
    End Structure
    Public Structure SpecDetail
        Dim SpecDetailID As Integer
        Dim DetailName As String
    End Structure
End Class
