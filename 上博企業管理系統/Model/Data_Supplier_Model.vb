Public Class Data_Supplier_Model
    Protected intMode As Integer = 3
    Public Const INSERT_MODE = 1
    Public Const REVISE_MODE = 2
    Public Const NORMAL_MODE = 3
    Protected Const SELECT_SUPPLIERDATA_SQL = "SELECT * FROM SupplierData"
    Protected Const SELECT_SUPPLIERDATA_FOR_STATEMENT_SQL = "SELECT * FROM SupplierData WHERE @statement"
    Protected Const UPDATE_SUPPLIERDATA_SQL = "UPDATE SupplierData SET CpyID = N'@cpyID', Name = N'@name', Number = N'@number', Address = N'@address', Contact = N'@contact', Phone = N'@phone', Abbr = N'@abbr'  WHERE SuID = @suID"
    Protected Const INSERT_SUPPLIERDATA_SQL = "INSERT INTO SupplierData (Name,Number,CpyID,Address,Contact,Phone,Abbr) VALUES(N'@name',N'@number',N'@cpyID',N'@address', N'@contact', N'@phone',N'@abbr' ); SELECT @@IDENTITY"
    Protected Const DELETE_SUPPLIERDATA_SQL = "DELETE FROM SupplierData WHERE SuID = @suID"
    Protected listSuID As List(Of Integer) = New List(Of Integer)
    Public Structure SupplierData
        Dim SuID As Integer
        Dim Name As String
        Dim Number As String
        Dim CpyID As String
        Dim Address As String
        Dim Contact As String
        Dim Phone As String
        Dim Abbr As String
    End Structure
End Class
