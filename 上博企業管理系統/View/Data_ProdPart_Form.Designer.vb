<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_ProdPart_Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_ProdPart_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LoadProductWorker = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ProdTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierNameCB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProdNameText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProdNumberText = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SearchCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.ControlLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ReviseBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LoadingPic = New System.Windows.Forms.PictureBox()
        Me.ViewDGV = New System.Windows.Forms.DataGridView()
        Me.ProdPartID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdSuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdSupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdDetailDGV = New System.Windows.Forms.DataGridView()
        Me.PurchaseIDProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseIDProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseNoProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecificationProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsertTimeProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FitTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SupplierFCB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FitNameText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FitNumberText = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SearchFCB = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SearchFText = New System.Windows.Forms.TextBox()
        Me.SearchFBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddFBtn = New System.Windows.Forms.Button()
        Me.ReviseFBtn = New System.Windows.Forms.Button()
        Me.DelFBtn = New System.Windows.Forms.Button()
        Me.OKFBtn = New System.Windows.Forms.Button()
        Me.CancelFBtn = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LoadingFPic = New System.Windows.Forms.PictureBox()
        Me.ViewFDGV = New System.Windows.Forms.DataGridView()
        Me.FitDetailDGV = New System.Windows.Forms.DataGridView()
        Me.PurchaseIDFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseIDFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaeNoFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecificationFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsertTimeFit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProdPart2ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitSuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitSupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.ProdTab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.ControlLayout.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.LoadingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdDetailDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FitTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.LoadingFPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewFDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FitDetailDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "delete-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "pencil-red-icon.png")
        '
        'LoadProductWorker
        '
        Me.LoadProductWorker.WorkerReportsProgress = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ProdTab)
        Me.TabControl1.Controls.Add(Me.FitTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 492)
        Me.TabControl1.TabIndex = 0
        '
        'ProdTab
        '
        Me.ProdTab.BackColor = System.Drawing.Color.SlateGray
        Me.ProdTab.Controls.Add(Me.TableLayoutPanel1)
        Me.ProdTab.Location = New System.Drawing.Point(4, 33)
        Me.ProdTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProdTab.Name = "ProdTab"
        Me.ProdTab.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProdTab.Size = New System.Drawing.Size(834, 455)
        Me.ProdTab.TabIndex = 0
        Me.ProdTab.Text = "門框/窗框"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ControlLayout, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.ProdDetailDGV, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(830, 451)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SupplierNameCB)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProdNameText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProdNumberText)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 41)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(824, 74)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "供應商："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierNameCB
        '
        Me.SupplierNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierNameCB.Enabled = False
        Me.SupplierNameCB.FormattingEnabled = True
        Me.SupplierNameCB.Location = New System.Drawing.Point(92, 2)
        Me.SupplierNameCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SupplierNameCB.Name = "SupplierNameCB"
        Me.SupplierNameCB.Size = New System.Drawing.Size(243, 32)
        Me.SupplierNameCB.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(339, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "產品名稱："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdNameText
        '
        Me.ProdNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdNameText.Location = New System.Drawing.Point(448, 2)
        Me.ProdNameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProdNameText.Name = "ProdNameText"
        Me.ProdNameText.ReadOnly = True
        Me.ProdNameText.Size = New System.Drawing.Size(170, 33)
        Me.ProdNameText.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(622, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "產品簡稱："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdNumberText
        '
        Me.ProdNumberText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdNumberText.Location = New System.Drawing.Point(2, 39)
        Me.ProdNumberText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProdNumberText.Name = "ProdNumberText"
        Me.ProdNumberText.ReadOnly = True
        Me.ProdNumberText.Size = New System.Drawing.Size(250, 33)
        Me.ProdNumberText.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 233)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 1)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 407)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(826, 1)
        Me.Panel2.TabIndex = 3
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel3.Controls.Add(Me.SearchCB)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel3.Controls.Add(Me.SearchText)
        Me.FlowLayoutPanel3.Controls.Add(Me.SearchBtn)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(2, 409)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(826, 40)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "查詢類別："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchCB
        '
        Me.SearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchCB.FormattingEnabled = True
        Me.SearchCB.Items.AddRange(New Object() {"產品名稱", "產品簡稱"})
        Me.SearchCB.Location = New System.Drawing.Point(111, 2)
        Me.SearchCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchCB.Name = "SearchCB"
        Me.SearchCB.Size = New System.Drawing.Size(150, 32)
        Me.SearchCB.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(265, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "查詢內容："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(374, 2)
        Me.SearchText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(252, 33)
        Me.SearchText.TabIndex = 6
        '
        'SearchBtn
        '
        Me.SearchBtn.AutoSize = True
        Me.SearchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(630, 2)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(70, 36)
        Me.SearchBtn.TabIndex = 7
        Me.SearchBtn.Text = "查詢"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'ControlLayout
        '
        Me.ControlLayout.AutoSize = True
        Me.ControlLayout.Controls.Add(Me.AddBtn)
        Me.ControlLayout.Controls.Add(Me.ReviseBtn)
        Me.ControlLayout.Controls.Add(Me.DelBtn)
        Me.ControlLayout.Controls.Add(Me.OKBtn)
        Me.ControlLayout.Controls.Add(Me.CancelBtn)
        Me.ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlLayout.Location = New System.Drawing.Point(2, 2)
        Me.ControlLayout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ControlLayout.Name = "ControlLayout"
        Me.ControlLayout.Size = New System.Drawing.Size(826, 34)
        Me.ControlLayout.TabIndex = 5
        '
        'AddBtn
        '
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBtn.ImageKey = "add-icon.png"
        Me.AddBtn.ImageList = Me.ImageList1
        Me.AddBtn.Location = New System.Drawing.Point(2, 2)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(84, 30)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "新增"
        Me.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ReviseBtn
        '
        Me.ReviseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReviseBtn.ForeColor = System.Drawing.Color.White
        Me.ReviseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReviseBtn.ImageKey = "pencil-red-icon.png"
        Me.ReviseBtn.ImageList = Me.ImageList1
        Me.ReviseBtn.Location = New System.Drawing.Point(90, 2)
        Me.ReviseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReviseBtn.Name = "ReviseBtn"
        Me.ReviseBtn.Size = New System.Drawing.Size(84, 30)
        Me.ReviseBtn.TabIndex = 1
        Me.ReviseBtn.Text = "修改"
        Me.ReviseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReviseBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelBtn.ImageKey = "delete-icon.png"
        Me.DelBtn.ImageList = Me.ImageList1
        Me.DelBtn.Location = New System.Drawing.Point(178, 2)
        Me.DelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(84, 30)
        Me.DelBtn.TabIndex = 2
        Me.DelBtn.Text = "移除"
        Me.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.ForeColor = System.Drawing.Color.White
        Me.OKBtn.Location = New System.Drawing.Point(266, 2)
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(84, 30)
        Me.OKBtn.TabIndex = 3
        Me.OKBtn.Text = "確認"
        Me.OKBtn.UseVisualStyleBackColor = False
        Me.OKBtn.Visible = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(354, 2)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(84, 30)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "取消"
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LoadingPic)
        Me.Panel4.Controls.Add(Me.ViewDGV)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(2, 237)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(826, 166)
        Me.Panel4.TabIndex = 6
        '
        'LoadingPic
        '
        Me.LoadingPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LoadingPic.Image = Global.上博企業管理系統.My.Resources.Resources.loading
        Me.LoadingPic.Location = New System.Drawing.Point(457, 57)
        Me.LoadingPic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LoadingPic.Name = "LoadingPic"
        Me.LoadingPic.Size = New System.Drawing.Size(0, 36)
        Me.LoadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPic.TabIndex = 5
        Me.LoadingPic.TabStop = False
        '
        'ViewDGV
        '
        Me.ViewDGV.AllowUserToAddRows = False
        Me.ViewDGV.AllowUserToDeleteRows = False
        Me.ViewDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ViewDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ViewDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdPartID, Me.ProdSuID, Me.ProdSupplierName, Me.ProdName, Me.ProdNumber})
        Me.ViewDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewDGV.Location = New System.Drawing.Point(0, 0)
        Me.ViewDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewDGV.Name = "ViewDGV"
        Me.ViewDGV.ReadOnly = True
        Me.ViewDGV.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.ViewDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewDGV.RowTemplate.Height = 24
        Me.ViewDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewDGV.Size = New System.Drawing.Size(826, 166)
        Me.ViewDGV.TabIndex = 3
        '
        'ProdPartID
        '
        Me.ProdPartID.HeaderText = "Column1"
        Me.ProdPartID.Name = "ProdPartID"
        Me.ProdPartID.ReadOnly = True
        Me.ProdPartID.Visible = False
        Me.ProdPartID.Width = 55
        '
        'ProdSuID
        '
        Me.ProdSuID.HeaderText = "Column1"
        Me.ProdSuID.Name = "ProdSuID"
        Me.ProdSuID.ReadOnly = True
        Me.ProdSuID.Visible = False
        Me.ProdSuID.Width = 55
        '
        'ProdSupplierName
        '
        Me.ProdSupplierName.HeaderText = "供應商簡稱"
        Me.ProdSupplierName.Name = "ProdSupplierName"
        Me.ProdSupplierName.ReadOnly = True
        Me.ProdSupplierName.Width = 130
        '
        'ProdName
        '
        Me.ProdName.HeaderText = "產品名稱"
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        Me.ProdName.Width = 111
        '
        'ProdNumber
        '
        Me.ProdNumber.HeaderText = "產品簡稱"
        Me.ProdNumber.Name = "ProdNumber"
        Me.ProdNumber.ReadOnly = True
        Me.ProdNumber.Width = 111
        '
        'ProdDetailDGV
        '
        Me.ProdDetailDGV.AllowUserToAddRows = False
        Me.ProdDetailDGV.AllowUserToDeleteRows = False
        Me.ProdDetailDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProdDetailDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ProdDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdDetailDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseIDProd, Me.CaseIDProd, Me.PlaceProd, Me.PurchaseNoProd, Me.SpecificationProd, Me.CountProd, Me.InsertTimeProd})
        Me.ProdDetailDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdDetailDGV.Location = New System.Drawing.Point(2, 148)
        Me.ProdDetailDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProdDetailDGV.Name = "ProdDetailDGV"
        Me.ProdDetailDGV.ReadOnly = True
        Me.ProdDetailDGV.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.ProdDetailDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ProdDetailDGV.RowTemplate.Height = 38
        Me.ProdDetailDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProdDetailDGV.Size = New System.Drawing.Size(826, 81)
        Me.ProdDetailDGV.TabIndex = 7
        '
        'PurchaseIDProd
        '
        Me.PurchaseIDProd.HeaderText = "Column1"
        Me.PurchaseIDProd.Name = "PurchaseIDProd"
        Me.PurchaseIDProd.ReadOnly = True
        Me.PurchaseIDProd.Visible = False
        Me.PurchaseIDProd.Width = 188
        '
        'CaseIDProd
        '
        Me.CaseIDProd.HeaderText = "Column1"
        Me.CaseIDProd.Name = "CaseIDProd"
        Me.CaseIDProd.ReadOnly = True
        Me.CaseIDProd.Visible = False
        Me.CaseIDProd.Width = 188
        '
        'PlaceProd
        '
        Me.PlaceProd.HeaderText = "Column1"
        Me.PlaceProd.Name = "PlaceProd"
        Me.PlaceProd.ReadOnly = True
        Me.PlaceProd.Visible = False
        Me.PlaceProd.Width = 188
        '
        'PurchaseNoProd
        '
        Me.PurchaseNoProd.HeaderText = "訂單編號"
        Me.PurchaseNoProd.Name = "PurchaseNoProd"
        Me.PurchaseNoProd.ReadOnly = True
        Me.PurchaseNoProd.Width = 111
        '
        'SpecificationProd
        '
        Me.SpecificationProd.HeaderText = "規格"
        Me.SpecificationProd.Name = "SpecificationProd"
        Me.SpecificationProd.ReadOnly = True
        Me.SpecificationProd.Width = 73
        '
        'CountProd
        '
        Me.CountProd.HeaderText = "數量"
        Me.CountProd.Name = "CountProd"
        Me.CountProd.ReadOnly = True
        Me.CountProd.Width = 73
        '
        'InsertTimeProd
        '
        Me.InsertTimeProd.HeaderText = "建立日期"
        Me.InsertTimeProd.Name = "InsertTimeProd"
        Me.InsertTimeProd.ReadOnly = True
        Me.InsertTimeProd.Width = 111
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 120)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(826, 1)
        Me.Panel3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(334, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "最近三筆進貨紀錄"
        '
        'FitTab
        '
        Me.FitTab.BackColor = System.Drawing.Color.SlateGray
        Me.FitTab.Controls.Add(Me.TableLayoutPanel2)
        Me.FitTab.Location = New System.Drawing.Point(4, 33)
        Me.FitTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FitTab.Name = "FitTab"
        Me.FitTab.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FitTab.Size = New System.Drawing.Size(834, 455)
        Me.FitTab.TabIndex = 1
        Me.FitTab.Text = "門扇"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel5, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel6, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel7, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.FitDetailDGV, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel8, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(830, 451)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.SupplierFCB)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel2.Controls.Add(Me.FitNameText)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel2.Controls.Add(Me.FitNumberText)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 41)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(824, 74)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "供應商："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierFCB
        '
        Me.SupplierFCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupplierFCB.Enabled = False
        Me.SupplierFCB.FormattingEnabled = True
        Me.SupplierFCB.Location = New System.Drawing.Point(92, 2)
        Me.SupplierFCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SupplierFCB.Name = "SupplierFCB"
        Me.SupplierFCB.Size = New System.Drawing.Size(243, 32)
        Me.SupplierFCB.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(339, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "產品名稱："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FitNameText
        '
        Me.FitNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FitNameText.Location = New System.Drawing.Point(448, 2)
        Me.FitNameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FitNameText.Name = "FitNameText"
        Me.FitNameText.ReadOnly = True
        Me.FitNameText.Size = New System.Drawing.Size(170, 33)
        Me.FitNameText.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(622, 6)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "產品簡稱："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FitNumberText
        '
        Me.FitNumberText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FitNumberText.Location = New System.Drawing.Point(2, 39)
        Me.FitNumberText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FitNumberText.Name = "FitNumberText"
        Me.FitNumberText.ReadOnly = True
        Me.FitNumberText.Size = New System.Drawing.Size(250, 33)
        Me.FitNumberText.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(2, 233)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(826, 1)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 407)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(826, 1)
        Me.Panel6.TabIndex = 3
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel5.Controls.Add(Me.SearchFCB)
        Me.FlowLayoutPanel5.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel5.Controls.Add(Me.SearchFText)
        Me.FlowLayoutPanel5.Controls.Add(Me.SearchFBtn)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(2, 409)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(826, 40)
        Me.FlowLayoutPanel5.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 8)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "查詢類別："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchFCB
        '
        Me.SearchFCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchFCB.FormattingEnabled = True
        Me.SearchFCB.Items.AddRange(New Object() {"產品名稱", "產品簡稱"})
        Me.SearchFCB.Location = New System.Drawing.Point(111, 2)
        Me.SearchFCB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchFCB.Name = "SearchFCB"
        Me.SearchFCB.Size = New System.Drawing.Size(150, 32)
        Me.SearchFCB.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(265, 8)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 24)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "查詢內容："
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchFText
        '
        Me.SearchFText.Location = New System.Drawing.Point(374, 2)
        Me.SearchFText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchFText.Name = "SearchFText"
        Me.SearchFText.Size = New System.Drawing.Size(252, 33)
        Me.SearchFText.TabIndex = 6
        '
        'SearchFBtn
        '
        Me.SearchFBtn.AutoSize = True
        Me.SearchFBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchFBtn.ForeColor = System.Drawing.Color.White
        Me.SearchFBtn.Location = New System.Drawing.Point(630, 2)
        Me.SearchFBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchFBtn.Name = "SearchFBtn"
        Me.SearchFBtn.Size = New System.Drawing.Size(70, 36)
        Me.SearchFBtn.TabIndex = 7
        Me.SearchFBtn.Text = "查詢"
        Me.SearchFBtn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.AutoSize = True
        Me.FlowLayoutPanel6.Controls.Add(Me.AddFBtn)
        Me.FlowLayoutPanel6.Controls.Add(Me.ReviseFBtn)
        Me.FlowLayoutPanel6.Controls.Add(Me.DelFBtn)
        Me.FlowLayoutPanel6.Controls.Add(Me.OKFBtn)
        Me.FlowLayoutPanel6.Controls.Add(Me.CancelFBtn)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(826, 34)
        Me.FlowLayoutPanel6.TabIndex = 5
        '
        'AddFBtn
        '
        Me.AddFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddFBtn.ForeColor = System.Drawing.Color.White
        Me.AddFBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddFBtn.ImageKey = "add-icon.png"
        Me.AddFBtn.ImageList = Me.ImageList1
        Me.AddFBtn.Location = New System.Drawing.Point(2, 2)
        Me.AddFBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddFBtn.Name = "AddFBtn"
        Me.AddFBtn.Size = New System.Drawing.Size(84, 30)
        Me.AddFBtn.TabIndex = 0
        Me.AddFBtn.Text = "新增"
        Me.AddFBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddFBtn.UseVisualStyleBackColor = True
        '
        'ReviseFBtn
        '
        Me.ReviseFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReviseFBtn.ForeColor = System.Drawing.Color.White
        Me.ReviseFBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReviseFBtn.ImageKey = "pencil-red-icon.png"
        Me.ReviseFBtn.ImageList = Me.ImageList1
        Me.ReviseFBtn.Location = New System.Drawing.Point(90, 2)
        Me.ReviseFBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReviseFBtn.Name = "ReviseFBtn"
        Me.ReviseFBtn.Size = New System.Drawing.Size(84, 30)
        Me.ReviseFBtn.TabIndex = 1
        Me.ReviseFBtn.Text = "修改"
        Me.ReviseFBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReviseFBtn.UseVisualStyleBackColor = True
        '
        'DelFBtn
        '
        Me.DelFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelFBtn.ForeColor = System.Drawing.Color.White
        Me.DelFBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelFBtn.ImageKey = "delete-icon.png"
        Me.DelFBtn.ImageList = Me.ImageList1
        Me.DelFBtn.Location = New System.Drawing.Point(178, 2)
        Me.DelFBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DelFBtn.Name = "DelFBtn"
        Me.DelFBtn.Size = New System.Drawing.Size(84, 30)
        Me.DelFBtn.TabIndex = 2
        Me.DelFBtn.Text = "移除"
        Me.DelFBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelFBtn.UseVisualStyleBackColor = True
        '
        'OKFBtn
        '
        Me.OKFBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.OKFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKFBtn.ForeColor = System.Drawing.Color.White
        Me.OKFBtn.Location = New System.Drawing.Point(266, 2)
        Me.OKFBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OKFBtn.Name = "OKFBtn"
        Me.OKFBtn.Size = New System.Drawing.Size(84, 30)
        Me.OKFBtn.TabIndex = 3
        Me.OKFBtn.Text = "確認"
        Me.OKFBtn.UseVisualStyleBackColor = False
        Me.OKFBtn.Visible = False
        '
        'CancelFBtn
        '
        Me.CancelFBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelFBtn.ForeColor = System.Drawing.Color.White
        Me.CancelFBtn.Location = New System.Drawing.Point(354, 2)
        Me.CancelFBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelFBtn.Name = "CancelFBtn"
        Me.CancelFBtn.Size = New System.Drawing.Size(84, 30)
        Me.CancelFBtn.TabIndex = 4
        Me.CancelFBtn.Text = "取消"
        Me.CancelFBtn.UseVisualStyleBackColor = False
        Me.CancelFBtn.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.LoadingFPic)
        Me.Panel7.Controls.Add(Me.ViewFDGV)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(2, 237)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(826, 166)
        Me.Panel7.TabIndex = 6
        '
        'LoadingFPic
        '
        Me.LoadingFPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingFPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LoadingFPic.Image = Global.上博企業管理系統.My.Resources.Resources.loading
        Me.LoadingFPic.Location = New System.Drawing.Point(446, 57)
        Me.LoadingFPic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LoadingFPic.Name = "LoadingFPic"
        Me.LoadingFPic.Size = New System.Drawing.Size(0, 36)
        Me.LoadingFPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingFPic.TabIndex = 5
        Me.LoadingFPic.TabStop = False
        '
        'ViewFDGV
        '
        Me.ViewFDGV.AllowUserToAddRows = False
        Me.ViewFDGV.AllowUserToDeleteRows = False
        Me.ViewFDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ViewFDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ViewFDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ViewFDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewFDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdPart2ID, Me.FitSuID, Me.FitSupplierName, Me.FitName, Me.FitNumber})
        Me.ViewFDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewFDGV.Location = New System.Drawing.Point(0, 0)
        Me.ViewFDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewFDGV.Name = "ViewFDGV"
        Me.ViewFDGV.ReadOnly = True
        Me.ViewFDGV.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.ViewFDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ViewFDGV.RowTemplate.Height = 24
        Me.ViewFDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewFDGV.Size = New System.Drawing.Size(826, 166)
        Me.ViewFDGV.TabIndex = 3
        '
        'FitDetailDGV
        '
        Me.FitDetailDGV.AllowUserToAddRows = False
        Me.FitDetailDGV.AllowUserToDeleteRows = False
        Me.FitDetailDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.FitDetailDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.FitDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FitDetailDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseIDFit, Me.CaseIDFit, Me.PlaceFit, Me.PurchaeNoFit, Me.SpecificationFit, Me.CountFit, Me.InsertTimeFit})
        Me.FitDetailDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FitDetailDGV.Location = New System.Drawing.Point(2, 148)
        Me.FitDetailDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FitDetailDGV.Name = "FitDetailDGV"
        Me.FitDetailDGV.ReadOnly = True
        Me.FitDetailDGV.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.FitDetailDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.FitDetailDGV.RowTemplate.Height = 38
        Me.FitDetailDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FitDetailDGV.Size = New System.Drawing.Size(826, 81)
        Me.FitDetailDGV.TabIndex = 7
        '
        'PurchaseIDFit
        '
        Me.PurchaseIDFit.HeaderText = "Column1"
        Me.PurchaseIDFit.Name = "PurchaseIDFit"
        Me.PurchaseIDFit.ReadOnly = True
        Me.PurchaseIDFit.Visible = False
        Me.PurchaseIDFit.Width = 188
        '
        'CaseIDFit
        '
        Me.CaseIDFit.HeaderText = "Column1"
        Me.CaseIDFit.Name = "CaseIDFit"
        Me.CaseIDFit.ReadOnly = True
        Me.CaseIDFit.Visible = False
        Me.CaseIDFit.Width = 188
        '
        'PlaceFit
        '
        Me.PlaceFit.HeaderText = "Column1"
        Me.PlaceFit.Name = "PlaceFit"
        Me.PlaceFit.ReadOnly = True
        Me.PlaceFit.Visible = False
        Me.PlaceFit.Width = 188
        '
        'PurchaeNoFit
        '
        Me.PurchaeNoFit.HeaderText = "訂單編號"
        Me.PurchaeNoFit.Name = "PurchaeNoFit"
        Me.PurchaeNoFit.ReadOnly = True
        Me.PurchaeNoFit.Width = 111
        '
        'SpecificationFit
        '
        Me.SpecificationFit.HeaderText = "規格"
        Me.SpecificationFit.Name = "SpecificationFit"
        Me.SpecificationFit.ReadOnly = True
        Me.SpecificationFit.Width = 73
        '
        'CountFit
        '
        Me.CountFit.HeaderText = "數量"
        Me.CountFit.Name = "CountFit"
        Me.CountFit.ReadOnly = True
        Me.CountFit.Width = 73
        '
        'InsertTimeFit
        '
        Me.InsertTimeFit.HeaderText = "建立日期"
        Me.InsertTimeFit.Name = "InsertTimeFit"
        Me.InsertTimeFit.ReadOnly = True
        Me.InsertTimeFit.Width = 111
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(2, 120)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(826, 1)
        Me.Panel8.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(334, 122)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 24)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "最近三筆進貨紀錄"
        '
        'ProdPart2ID
        '
        Me.ProdPart2ID.HeaderText = "Column1"
        Me.ProdPart2ID.Name = "ProdPart2ID"
        Me.ProdPart2ID.ReadOnly = True
        Me.ProdPart2ID.Visible = False
        Me.ProdPart2ID.Width = 99
        '
        'FitSuID
        '
        Me.FitSuID.HeaderText = "Column1"
        Me.FitSuID.Name = "FitSuID"
        Me.FitSuID.ReadOnly = True
        Me.FitSuID.Visible = False
        Me.FitSuID.Width = 99
        '
        'FitSupplierName
        '
        Me.FitSupplierName.HeaderText = "供應商簡稱"
        Me.FitSupplierName.Name = "FitSupplierName"
        Me.FitSupplierName.ReadOnly = True
        Me.FitSupplierName.Width = 130
        '
        'FitName
        '
        Me.FitName.HeaderText = "產品名稱"
        Me.FitName.Name = "FitName"
        Me.FitName.ReadOnly = True
        Me.FitName.Width = 111
        '
        'FitNumber
        '
        Me.FitNumber.HeaderText = "產品簡稱"
        Me.FitNumber.Name = "FitNumber"
        Me.FitNumber.ReadOnly = True
        Me.FitNumber.Width = 111
        '
        'Data_Product_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(842, 492)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Name = "Data_Product_Form"
        Me.Text = "產品設定"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.ProdTab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ControlLayout.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.LoadingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdDetailDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FitTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.LoadingFPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewFDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FitDetailDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadProductWorker As ComponentModel.BackgroundWorker
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ProdTab As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierNameCB As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProdNameText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProdNumberText As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents SearchCB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchText As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents ControlLayout As FlowLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents ReviseBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LoadingPic As PictureBox
    Friend WithEvents ViewDGV As DataGridView
    Friend WithEvents ProdPartID As DataGridViewTextBoxColumn
    Friend WithEvents ProdSuID As DataGridViewTextBoxColumn
    Friend WithEvents ProdSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents ProdNumber As DataGridViewTextBoxColumn
    Friend WithEvents ProdDetailDGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents FitTab As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents SupplierFCB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FitNameText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents FitNumberText As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents SearchFCB As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SearchFText As TextBox
    Friend WithEvents SearchFBtn As Button
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents AddFBtn As Button
    Friend WithEvents ReviseFBtn As Button
    Friend WithEvents DelFBtn As Button
    Friend WithEvents OKFBtn As Button
    Friend WithEvents CancelFBtn As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LoadingFPic As PictureBox
    Friend WithEvents ViewFDGV As DataGridView
    Friend WithEvents FitDetailDGV As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PurchaseIDFit As DataGridViewTextBoxColumn
    Friend WithEvents CaseIDFit As DataGridViewTextBoxColumn
    Friend WithEvents PlaceFit As DataGridViewTextBoxColumn
    Friend WithEvents PurchaeNoFit As DataGridViewTextBoxColumn
    Friend WithEvents SpecificationFit As DataGridViewTextBoxColumn
    Friend WithEvents CountFit As DataGridViewTextBoxColumn
    Friend WithEvents InsertTimeFit As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseIDProd As DataGridViewTextBoxColumn
    Friend WithEvents CaseIDProd As DataGridViewTextBoxColumn
    Friend WithEvents PlaceProd As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseNoProd As DataGridViewTextBoxColumn
    Friend WithEvents SpecificationProd As DataGridViewTextBoxColumn
    Friend WithEvents CountProd As DataGridViewTextBoxColumn
    Friend WithEvents InsertTimeProd As DataGridViewTextBoxColumn
    Friend WithEvents ProdPart2ID As DataGridViewTextBoxColumn
    Friend WithEvents FitSuID As DataGridViewTextBoxColumn
    Friend WithEvents FitSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents FitName As DataGridViewTextBoxColumn
    Friend WithEvents FitNumber As DataGridViewTextBoxColumn
End Class
