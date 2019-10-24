Public Class Set_Repair_Form
    Dim intCaseID As Integer = 0
    Dim intRepairID As Integer = -1
    Dim controller As Set_Repair_Controller = New Set_Repair_Controller

    Public Sub New(ByVal intCaseID As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.intCaseID = intCaseID
    End Sub
    Public Sub New(ByVal intCaseID As Integer, ByVal intRepairID As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.intCaseID = intCaseID
        Me.intRepairID = intRepairID
    End Sub


    Private Sub Set_Repair_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If intRepairID = -1 Then
            '未有RepairID表示要新增維修紀錄
            Dim data As CaseData = controller.Selet_CaseData(intCaseID)
            RepairOrderText.Text = controller.Create_NewOrder
            PlaceText.Text = data.Place
            AddressText.Text = data.Address
            ContactText.Text = data.Contact
            PhoneText.Text = data.Place
            '查詢是否已過保固
            '過保定義: 最後更新日期+1年
            If Now > DateAdd(DateInterval.Year, 1, CDate(data.UpdateTime)) Then
                WarrantyText.Text = "已過保固，保固期限為:" & Format(DateAdd(DateInterval.Year, 1, CDate(data.UpdateTime)), "yyyy/MM")
            Else
                WarrantyText.Text = "尚未過保，保固期限為:" & Format(DateAdd(DateInterval.Year, 1, CDate(data.UpdateTime)), "yyyy/MM")
            End If
        Else
            '有RepairID表示已有此紀錄，載入內容
            Dim data As RepairData = controller.Select_RepairData(intRepairID)
            RepairOrderText.Text = data.RepairOrder
            RemarkText.Text = data.Remark
            PlaceText.Text = data.Place
            AddressText.Text = data.Address
            ContactText.Text = data.Contact
            PhoneText.Text = data.Place
            RepairClassText.Text = data.RepairType
            ArchiveDate.Text = data.ArchiveDate
            WarrantyText.Text = data.Warranty
            Select Case data.Status
                Case 1
                    StatusText.Text = "複核確認中"
                Case 2
                    StatusText.Text = "已完成派單，等待執行"
                Case 3
                    StatusText.Text = "維修已完成"
            End Select
            '載入維修單之歷史更新紀錄
            Dim listData As List(Of RepairLog) = controller.Select_RepairLog(intRepairID)
            Dim strMsg As String = ""
            For Each RL As RepairLog In listData
                strMsg += RL.LogDate & " " & controller.Select_LoginName(RL.LoginID) & RL.Remark & vbCrLf
            Next
            LogText.Text = strMsg
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim data As RepairData = New RepairData
        Dim flag As Boolean = False ' 設置是否為新增維修單旗標
        data.RepairOrder = RepairOrderText.Text
        data.Place = PlaceText.Text
        data.Address = AddressText.Text
        data.Contact = ContactText.Text
        data.ArchiveDate = Format(ArchiveDate.Value, "yyyy/MM/dd")
        data.Warranty = WarrantyText.Text
        data.ETA = Format(ETADate.Value, "yyyy/MM/dd")
        data.Remark = RemarkText.Text
        data.ArchiveLoginID = LoginID
        If intRepairID = -1 Then
            '表示此單為新的維修單，先建立維修單後再將資料放入此維修單中
            Dim id As Integer = controller.Insert_RepairData(intCaseID, RepairOrderText.Text, LoginID)
            If id <> -1 Then
                intRepairID = id
                flag = True
            Else
                MsgBox("新增錯誤，請聯絡工程師")
                Exit Sub
            End If
        End If
        If controller.Update_RepairData(data, intRepairID) <> 0 Then
            If flag Then
                controller.Insert_RepairLog(intRepairID, "新增維修單")
            Else
                controller.Insert_RepairLog(intRepairID, "更改維修單資料")
            End If
            MsgBox("存檔成功")
        Else
            MsgBox("存取錯誤，請重新在試")
        End If
    End Sub


End Class