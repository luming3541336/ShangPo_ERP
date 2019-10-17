Module UserDetail
    Public LoginID As Integer = Nothing
    Public UserName As String = Nothing
    Public Access As String = Nothing
    '權限設定
    '參數: 
    '   0:無法讀取及修改
    '   1:僅能讀取
    '   2:可讀取及修改
    Public L0 As Integer = Nothing  '產品資訊
    Public L1 As Integer = Nothing  '供應商資訊
    Public L2 As Integer = Nothing  '規格設定
    Public L3 As Integer = Nothing  '進出貨管理
    Public L4 As Integer = Nothing  '庫存查詢
    Public L5 As Integer = Nothing  '報表列印
    Public L6 As Integer = Nothing  '用戶設定
    Public MemoryUser As Boolean = Nothing '記憶使用者帳號密碼
    Public UserID As String = Nothing '使用者帳號
    Public Password As String = Nothing '使用者密碼
    Public readBoard As Boolean = Nothing '是否讀取公告

End Module
Public Structure CaseData
    Dim CaseID As Integer
    Dim CaseNo As String
    Dim Place As String
    Dim LoginID As Integer
    Dim Phone As String
    Dim Contact As String
    Dim Address As String
    Dim SalesName As String
    Dim InsertTime As String
    Dim UpdateTime As String
    Dim Success As Boolean
    Dim Del As Boolean
    Dim Remark As String
    Dim State As Integer
End Structure
Public Structure RepairData
    Dim RepairID As Integer
    Dim CaseID As Integer
    Dim RepairOrder As String
    Dim RepairType As String
    Dim Place As String
    Dim Contact As String
    Dim Address As String
    Dim Phone As String
    Dim Warranty As Boolean
    Dim Remark As String
    Dim ETA As Date
    Dim ArchiveDate As Date
    Dim ArchiveLoginID As Integer



End Structure
