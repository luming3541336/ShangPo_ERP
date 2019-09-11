Public Class Data_Fit_Model
    Protected Const SEARCH_FITTINGSET_FROM_SUID_SQL = "SELECT * FROM FittingSet WHERE SuID = @suID"
    Protected Const ADD_FITTINGSET_SQL = "INSERT INTO FittingSet(@statement) VALUES (@values); SELECT id = SCOPE_IDENTITY();"
    Protected Const REVISE_FITTINGSET_SQL = "UPDATE FittingSet SET @values WHERE FitID = @fitID"
    Protected Const DEL_FITTINGSET_SQL = "DELETE FittingSet WHERE FitID = @fitID"
    Public Const ADD_MODE = &HF001
    Public Const REVISE_MODE = &HF011
    Public Const VIEW_MODE = &HF111
    Protected suID As Integer = Nothing
    Protected supplierName As String = Nothing
    Protected mode As Integer = VIEW_MODE
    Public Structure FittingSet
        Dim FitID As Integer
        Dim Name As String
        Dim Number As String
        Dim Specification As String
    End Structure
End Class
