<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Set_Repair_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Set_Repair_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ETADate = New System.Windows.Forms.DateTimePicker()
        Me.PlaceText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RepairClassText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.ArchiveDate = New System.Windows.Forms.DateTimePicker()
        Me.RepairOrderText = New System.Windows.Forms.Label()
        Me.WarrantyText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RemarkText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UnJudgeCheckBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.RepairProdDGV = New System.Windows.Forms.DataGridView()
        Me.RepairProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPartType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPartID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPartName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.RepairAccountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairAccountItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LogText = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.RepairProdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.ETADate, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PlaceText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RepairClassText, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneText, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactText, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AddressText, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ArchiveDate, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RepairOrderText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.WarrantyText, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusText, 3, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 195)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ETADate
        '
        Me.ETADate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETADate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ETADate.Location = New System.Drawing.Point(561, 81)
        Me.ETADate.Name = "ETADate"
        Me.ETADate.Size = New System.Drawing.Size(253, 33)
        Me.ETADate.TabIndex = 21
        '
        'PlaceText
        '
        Me.PlaceText.Location = New System.Drawing.Point(95, 42)
        Me.PlaceText.Name = "PlaceText"
        Me.PlaceText.Size = New System.Drawing.Size(330, 33)
        Me.PlaceText.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "維修類別"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "維修單號"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "工地名稱"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(431, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "建檔日期"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(431, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "保固期"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(431, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "預計維修日期"
        '
        'RepairClassText
        '
        Me.RepairClassText.Location = New System.Drawing.Point(95, 159)
        Me.RepairClassText.Name = "RepairClassText"
        Me.RepairClassText.Size = New System.Drawing.Size(330, 33)
        Me.RepairClassText.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "聯絡電話"
        '
        'PhoneText
        '
        Me.PhoneText.Location = New System.Drawing.Point(561, 120)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(174, 33)
        Me.PhoneText.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "聯絡人"
        '
        'ContactText
        '
        Me.ContactText.Location = New System.Drawing.Point(95, 120)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.Size = New System.Drawing.Size(330, 33)
        Me.ContactText.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 24)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "地址"
        '
        'AddressText
        '
        Me.AddressText.Location = New System.Drawing.Point(95, 81)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.Size = New System.Drawing.Size(330, 33)
        Me.AddressText.TabIndex = 17
        '
        'ArchiveDate
        '
        Me.ArchiveDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArchiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ArchiveDate.Location = New System.Drawing.Point(561, 3)
        Me.ArchiveDate.Name = "ArchiveDate"
        Me.ArchiveDate.Size = New System.Drawing.Size(253, 33)
        Me.ArchiveDate.TabIndex = 18
        '
        'RepairOrderText
        '
        Me.RepairOrderText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RepairOrderText.AutoSize = True
        Me.RepairOrderText.Location = New System.Drawing.Point(95, 7)
        Me.RepairOrderText.Name = "RepairOrderText"
        Me.RepairOrderText.Size = New System.Drawing.Size(0, 24)
        Me.RepairOrderText.TabIndex = 19
        '
        'WarrantyText
        '
        Me.WarrantyText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.WarrantyText.AutoSize = True
        Me.WarrantyText.Location = New System.Drawing.Point(561, 46)
        Me.WarrantyText.Name = "WarrantyText"
        Me.WarrantyText.Size = New System.Drawing.Size(80, 24)
        Me.WarrantyText.TabIndex = 20
        Me.WarrantyText.Text = "Label15"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RemarkText, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 195)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 194)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'RemarkText
        '
        Me.RemarkText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemarkText.Location = New System.Drawing.Point(95, 3)
        Me.RemarkText.Multiline = True
        Me.RemarkText.Name = "RemarkText"
        Me.RemarkText.Size = New System.Drawing.Size(702, 188)
        Me.RemarkText.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "狀況描述"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RepairProdDGV, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 389)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(800, 221)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.87075!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.12925!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.UnJudgeCheckBox, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 7)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(800, 30)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "修繕產品/配件"
        '
        'UnJudgeCheckBox
        '
        Me.UnJudgeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UnJudgeCheckBox.AutoSize = True
        Me.UnJudgeCheckBox.Depth = 0
        Me.UnJudgeCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray
        Me.UnJudgeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UnJudgeCheckBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.UnJudgeCheckBox.Location = New System.Drawing.Point(649, 0)
        Me.UnJudgeCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.UnJudgeCheckBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.UnJudgeCheckBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UnJudgeCheckBox.Name = "UnJudgeCheckBox"
        Me.UnJudgeCheckBox.Ripple = True
        Me.UnJudgeCheckBox.Size = New System.Drawing.Size(151, 30)
        Me.UnJudgeCheckBox.TabIndex = 7
        Me.UnJudgeCheckBox.Text = "無法判斷修繕項目"
        Me.UnJudgeCheckBox.UseVisualStyleBackColor = False
        '
        'RepairProdDGV
        '
        Me.RepairProdDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.RepairProdDGV.BackgroundColor = System.Drawing.Color.SlateGray
        Me.RepairProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RepairProdDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairProdID, Me.ProdPartType, Me.ProdPartID, Me.ProdPartName, Me.RepairCount, Me.RepairRemark})
        Me.RepairProdDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepairProdDGV.Location = New System.Drawing.Point(3, 40)
        Me.RepairProdDGV.Name = "RepairProdDGV"
        Me.RepairProdDGV.RowTemplate.Height = 24
        Me.RepairProdDGV.Size = New System.Drawing.Size(794, 178)
        Me.RepairProdDGV.TabIndex = 17
        '
        'RepairProdID
        '
        Me.RepairProdID.HeaderText = "RepairProdID"
        Me.RepairProdID.Name = "RepairProdID"
        Me.RepairProdID.Visible = False
        Me.RepairProdID.Width = 153
        '
        'ProdPartType
        '
        Me.ProdPartType.HeaderText = "ProdPartType"
        Me.ProdPartType.Name = "ProdPartType"
        Me.ProdPartType.Visible = False
        Me.ProdPartType.Width = 156
        '
        'ProdPartID
        '
        Me.ProdPartID.HeaderText = "ProdPartID"
        Me.ProdPartID.Name = "ProdPartID"
        Me.ProdPartID.Visible = False
        Me.ProdPartID.Width = 131
        '
        'ProdPartName
        '
        Me.ProdPartName.HeaderText = "產品名稱"
        Me.ProdPartName.Name = "ProdPartName"
        Me.ProdPartName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProdPartName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ProdPartName.Width = 229
        '
        'RepairCount
        '
        Me.RepairCount.HeaderText = "維修數量"
        Me.RepairCount.Name = "RepairCount"
        Me.RepairCount.Width = 125
        '
        'RepairRemark
        '
        Me.RepairRemark.HeaderText = "備註"
        Me.RepairRemark.Name = "RepairRemark"
        Me.RepairRemark.Width = 229
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 1)
        Me.Panel2.TabIndex = 18
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.DataGridView2, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 610)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(800, 175)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.SlateGray
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairAccountID, Me.RepairAccountItem, Me.RepairAccount})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 27)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(794, 115)
        Me.DataGridView2.TabIndex = 17
        '
        'RepairAccountID
        '
        Me.RepairAccountID.HeaderText = "RepairAcountID"
        Me.RepairAccountID.Name = "RepairAccountID"
        Me.RepairAccountID.Visible = False
        Me.RepairAccountID.Width = 176
        '
        'RepairAccountItem
        '
        Me.RepairAccountItem.HeaderText = "收費項目"
        Me.RepairAccountItem.Name = "RepairAccountItem"
        Me.RepairAccountItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepairAccountItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.RepairAccountItem.Width = 160
        '
        'RepairAccount
        '
        Me.RepairAccount.HeaderText = "金額"
        Me.RepairAccount.Name = "RepairAccount"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 24)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "費用計算"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 148)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(794, 24)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 24)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "金額總計："
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(114, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "0"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button5)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 875)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(800, 42)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = True
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Location = New System.Drawing.Point(3, 3)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(95, 36)
        Me.SaveBtn.TabIndex = 0
        Me.SaveBtn.Text = "存檔"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(104, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 36)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "列印"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(205, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 36)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "複核"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(306, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(98, 36)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "維修確認"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(410, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 36)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "簽收單上傳"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(533, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "關閉"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.LogText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 785)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 90)
        Me.Panel1.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(-1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 24)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "操作紀錄"
        '
        'LogText
        '
        Me.LogText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogText.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LogText.Location = New System.Drawing.Point(0, 27)
        Me.LogText.Multiline = True
        Me.LogText.Name = "LogText"
        Me.LogText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LogText.Size = New System.Drawing.Size(800, 63)
        Me.LogText.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(431, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "狀態"
        '
        'StatusText
        '
        Me.StatusText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StatusText.AutoSize = True
        Me.StatusText.Location = New System.Drawing.Point(561, 163)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(86, 24)
        Me.StatusText.TabIndex = 23
        Me.StatusText.Text = "尚未建檔"
        '
        'Set_Repair_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(817, 707)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(833, 700)
        Me.Name = "Set_Repair_Form"
        Me.Text = "維修單設定"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.RepairProdDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ContactText As TextBox
    Friend WithEvents PlaceText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RepairClassText As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RemarkText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents UnJudgeCheckBox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents AddressText As TextBox
    Friend WithEvents ETADate As DateTimePicker
    Friend WithEvents ArchiveDate As DateTimePicker
    Friend WithEvents RepairOrderText As Label
    Friend WithEvents WarrantyText As Label
    Friend WithEvents RepairAccountID As DataGridViewTextBoxColumn
    Friend WithEvents RepairAccountItem As DataGridViewTextBoxColumn
    Friend WithEvents RepairAccount As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents LogText As TextBox
    Friend WithEvents RepairProdDGV As DataGridView
    Friend WithEvents RepairProdID As DataGridViewTextBoxColumn
    Friend WithEvents ProdPartType As DataGridViewTextBoxColumn
    Friend WithEvents ProdPartID As DataGridViewTextBoxColumn
    Friend WithEvents ProdPartName As DataGridViewTextBoxColumn
    Friend WithEvents RepairCount As DataGridViewTextBoxColumn
    Friend WithEvents RepairRemark As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusText As Label
End Class
