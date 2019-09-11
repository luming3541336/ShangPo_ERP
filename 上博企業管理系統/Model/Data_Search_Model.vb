Public Class Data_Search_Model
    Public Const SELECT_CASEDATA_STATEMENT_SQL = "SELECT * FROM CaseData WHERE Place LIKE N'%@place%' AND CaseNo LIKE N'%@caseNo%' @time AND Phone LIKE '%@phone%' AND Address LIKE N'%@address%' AND SalesName LIKE N'%@salesName%' AND State = @state"
End Class
