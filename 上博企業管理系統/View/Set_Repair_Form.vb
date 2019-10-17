Public Class Set_Repair_Form
    Dim caseID As Integer = 0
    Dim controller As Set_Repair_Controller = New Set_Repair_Controller
    Public Sub New(ByVal caseID As Integer)

        ' 設計工具需要此呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入所有初始設定。
        Me.caseID = caseID
    End Sub

    Private Sub Set_Repair_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As CaseData = controller.Selet_CaseData(caseID)
        PlaceText.Text = data.Place
        AddressText.Text = data.Address
        ContactText.Text = data.Contact
        PhoneText.Text = data.Place
    End Sub
End Class