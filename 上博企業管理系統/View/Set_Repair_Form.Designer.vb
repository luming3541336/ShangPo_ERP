<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Set_Repair_Form
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.RepairPersonText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.ArchiveDate = New System.Windows.Forms.DateTimePicker()
        Me.RepairOrderText = New System.Windows.Forms.Label()
        Me.WarrantyText = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
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
        Me.ShipmentPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPartName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RepairCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RepairRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.RepairAmountDGV = New System.Windows.Forms.DataGridView()
        Me.RepairAmountID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillItem = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.RepairPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TotalAmountText = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.ReCheckBtn = New System.Windows.Forms.Button()
        Me.RepairConfirmBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.FileUploadBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LogText = New System.Windows.Forms.TextBox()
        Me.LoadingDataBGW = New System.ComponentModel.BackgroundWorker()
        Me.RepairResultDGV = New System.Windows.Forms.TableLayoutPanel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.RepairResultText = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.RepairProdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.RepairAmountDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.RepairResultDGV.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.RepairPersonText, 1, 4)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 195)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ETADate
        '
        Me.ETADate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETADate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ETADate.Location = New System.Drawing.Point(561, 81)
        Me.ETADate.Name = "ETADate"
        Me.ETADate.Size = New System.Drawing.Size(284, 33)
        Me.ETADate.TabIndex = 4
        '
        'PlaceText
        '
        Me.PlaceText.Location = New System.Drawing.Point(95, 42)
        Me.PlaceText.Name = "PlaceText"
        Me.PlaceText.Size = New System.Drawing.Size(330, 33)
        Me.PlaceText.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "維修人員"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 2
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
        'RepairPersonText
        '
        Me.RepairPersonText.Location = New System.Drawing.Point(95, 159)
        Me.RepairPersonText.Name = "RepairPersonText"
        Me.RepairPersonText.Size = New System.Drawing.Size(330, 33)
        Me.RepairPersonText.TabIndex = 7
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
        Me.PhoneText.TabIndex = 6
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
        Me.ContactText.TabIndex = 5
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
        Me.AddressText.TabIndex = 3
        '
        'ArchiveDate
        '
        Me.ArchiveDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArchiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ArchiveDate.Location = New System.Drawing.Point(561, 3)
        Me.ArchiveDate.Name = "ArchiveDate"
        Me.ArchiveDate.Size = New System.Drawing.Size(284, 33)
        Me.ArchiveDate.TabIndex = 1
        '
        'RepairOrderText
        '
        Me.RepairOrderText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RepairOrderText.AutoSize = True
        Me.RepairOrderText.Location = New System.Drawing.Point(95, 7)
        Me.RepairOrderText.Name = "RepairOrderText"
        Me.RepairOrderText.Size = New System.Drawing.Size(0, 24)
        Me.RepairOrderText.TabIndex = 3
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(848, 194)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'RemarkText
        '
        Me.RemarkText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RemarkText.Location = New System.Drawing.Point(95, 3)
        Me.RemarkText.Multiline = True
        Me.RemarkText.Name = "RemarkText"
        Me.RemarkText.Size = New System.Drawing.Size(750, 188)
        Me.RemarkText.TabIndex = 0
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
        Me.TableLayoutPanel3.Controls.Add(Me.RepairProdDGV, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 389)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(848, 221)
        Me.TableLayoutPanel3.TabIndex = 3
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
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(848, 30)
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
        Me.UnJudgeCheckBox.Enabled = False
        Me.UnJudgeCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.SlateGray
        Me.UnJudgeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UnJudgeCheckBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.UnJudgeCheckBox.Location = New System.Drawing.Point(697, 0)
        Me.UnJudgeCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.UnJudgeCheckBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.UnJudgeCheckBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UnJudgeCheckBox.Name = "UnJudgeCheckBox"
        Me.UnJudgeCheckBox.Ripple = True
        Me.UnJudgeCheckBox.Size = New System.Drawing.Size(151, 30)
        Me.UnJudgeCheckBox.TabIndex = 7
        Me.UnJudgeCheckBox.Text = "無法判斷修繕項目"
        Me.UnJudgeCheckBox.UseVisualStyleBackColor = False
        Me.UnJudgeCheckBox.Visible = False
        '
        'RepairProdDGV
        '
        Me.RepairProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RepairProdDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepairProdDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RepairProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RepairProdDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairProdID, Me.ProdPartType, Me.ShipmentPID, Me.ProdPartName, Me.RepairCount, Me.RepairRemark})
        Me.RepairProdDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepairProdDGV.Location = New System.Drawing.Point(3, 40)
        Me.RepairProdDGV.MultiSelect = False
        Me.RepairProdDGV.Name = "RepairProdDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.RepairProdDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.RepairProdDGV.RowTemplate.Height = 24
        Me.RepairProdDGV.Size = New System.Drawing.Size(842, 178)
        Me.RepairProdDGV.TabIndex = 0
        '
        'RepairProdID
        '
        Me.RepairProdID.HeaderText = "RepairProdID"
        Me.RepairProdID.Name = "RepairProdID"
        Me.RepairProdID.Visible = False
        '
        'ProdPartType
        '
        Me.ProdPartType.HeaderText = "ProdPartType"
        Me.ProdPartType.Name = "ProdPartType"
        Me.ProdPartType.Visible = False
        '
        'ShipmentPID
        '
        Me.ShipmentPID.HeaderText = "ShipmentPID"
        Me.ShipmentPID.Name = "ShipmentPID"
        Me.ShipmentPID.Visible = False
        '
        'ProdPartName
        '
        Me.ProdPartName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ProdPartName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProdPartName.HeaderText = "產品名稱"
        Me.ProdPartName.Name = "ProdPartName"
        Me.ProdPartName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'RepairCount
        '
        Me.RepairCount.HeaderText = "維修數量"
        Me.RepairCount.Name = "RepairCount"
        '
        'RepairRemark
        '
        Me.RepairRemark.HeaderText = "備註"
        Me.RepairRemark.Name = "RepairRemark"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(842, 1)
        Me.Panel2.TabIndex = 18
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.RepairAmountDGV, 0, 0)
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
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(848, 175)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'RepairAmountDGV
        '
        Me.RepairAmountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.RepairAmountDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RepairAmountDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.RepairAmountDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RepairAmountDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RepairAmountID, Me.BillItem, Me.RepairPrice})
        Me.RepairAmountDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepairAmountDGV.Location = New System.Drawing.Point(3, 27)
        Me.RepairAmountDGV.Name = "RepairAmountDGV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.RepairAmountDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.RepairAmountDGV.RowTemplate.Height = 24
        Me.RepairAmountDGV.Size = New System.Drawing.Size(842, 115)
        Me.RepairAmountDGV.TabIndex = 2
        '
        'RepairAmountID
        '
        Me.RepairAmountID.HeaderText = "RepairAmountID"
        Me.RepairAmountID.Name = "RepairAmountID"
        Me.RepairAmountID.Visible = False
        Me.RepairAmountID.Width = 185
        '
        'BillItem
        '
        Me.BillItem.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.BillItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BillItem.HeaderText = "收費項目"
        Me.BillItem.Name = "BillItem"
        Me.BillItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillItem.Width = 92
        '
        'RepairPrice
        '
        Me.RepairPrice.HeaderText = "金額"
        Me.RepairPrice.Name = "RepairPrice"
        Me.RepairPrice.Width = 73
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
        Me.FlowLayoutPanel1.Controls.Add(Me.TotalAmountText)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 148)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(842, 24)
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
        'TotalAmountText
        '
        Me.TotalAmountText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TotalAmountText.AutoSize = True
        Me.TotalAmountText.Location = New System.Drawing.Point(114, 0)
        Me.TotalAmountText.Name = "TotalAmountText"
        Me.TotalAmountText.Size = New System.Drawing.Size(21, 24)
        Me.TotalAmountText.TabIndex = 21
        Me.TotalAmountText.Text = "0"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.SubmitBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReCheckBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.RepairConfirmBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.PrintBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.ExitBtn)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 1025)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(848, 42)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = True
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.ImageIndex = 2
        Me.SaveBtn.ImageList = Me.ImageList1
        Me.SaveBtn.Location = New System.Drawing.Point(3, 3)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(82, 36)
        Me.SaveBtn.TabIndex = 0
        Me.SaveBtn.Text = "存檔"
        Me.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "completed.png")
        Me.ImageList1.Images.SetKeyName(1, "print.png")
        Me.ImageList1.Images.SetKeyName(2, "Save.png")
        Me.ImageList1.Images.SetKeyName(3, "note_add.png")
        Me.ImageList1.Images.SetKeyName(4, "cancel.png")
        '
        'SubmitBtn
        '
        Me.SubmitBtn.AutoSize = True
        Me.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitBtn.ImageIndex = 0
        Me.SubmitBtn.ImageList = Me.ImageList1
        Me.SubmitBtn.Location = New System.Drawing.Point(91, 3)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(79, 36)
        Me.SubmitBtn.TabIndex = 1
        Me.SubmitBtn.Text = "提交"
        Me.SubmitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubmitBtn.UseVisualStyleBackColor = True
        Me.SubmitBtn.Visible = False
        '
        'ReCheckBtn
        '
        Me.ReCheckBtn.AutoSize = True
        Me.ReCheckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReCheckBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReCheckBtn.ImageIndex = 0
        Me.ReCheckBtn.ImageList = Me.ImageList1
        Me.ReCheckBtn.Location = New System.Drawing.Point(176, 3)
        Me.ReCheckBtn.Name = "ReCheckBtn"
        Me.ReCheckBtn.Size = New System.Drawing.Size(79, 36)
        Me.ReCheckBtn.TabIndex = 2
        Me.ReCheckBtn.Text = "複核"
        Me.ReCheckBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReCheckBtn.UseVisualStyleBackColor = True
        Me.ReCheckBtn.Visible = False
        '
        'RepairConfirmBtn
        '
        Me.RepairConfirmBtn.AutoSize = True
        Me.RepairConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RepairConfirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RepairConfirmBtn.ImageKey = "completed.png"
        Me.RepairConfirmBtn.ImageList = Me.ImageList1
        Me.RepairConfirmBtn.Location = New System.Drawing.Point(261, 3)
        Me.RepairConfirmBtn.Name = "RepairConfirmBtn"
        Me.RepairConfirmBtn.Size = New System.Drawing.Size(118, 36)
        Me.RepairConfirmBtn.TabIndex = 3
        Me.RepairConfirmBtn.Text = "維修確認"
        Me.RepairConfirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RepairConfirmBtn.UseVisualStyleBackColor = True
        Me.RepairConfirmBtn.Visible = False
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = True
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.ImageIndex = 1
        Me.PrintBtn.ImageList = Me.ImageList1
        Me.PrintBtn.Location = New System.Drawing.Point(385, 3)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(79, 36)
        Me.PrintBtn.TabIndex = 4
        Me.PrintBtn.Text = "列印"
        Me.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintBtn.UseVisualStyleBackColor = True
        Me.PrintBtn.Visible = False
        '
        'ExitBtn
        '
        Me.ExitBtn.AutoSize = True
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.ImageIndex = 4
        Me.ExitBtn.ImageList = Me.ImageList1
        Me.ExitBtn.Location = New System.Drawing.Point(470, 3)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(80, 36)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "關閉"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'FileUploadBtn
        '
        Me.FileUploadBtn.AutoSize = True
        Me.FileUploadBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FileUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileUploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileUploadBtn.ImageIndex = 3
        Me.FileUploadBtn.ImageList = Me.ImageList1
        Me.FileUploadBtn.Location = New System.Drawing.Point(3, 97)
        Me.FileUploadBtn.Name = "FileUploadBtn"
        Me.FileUploadBtn.Size = New System.Drawing.Size(134, 49)
        Me.FileUploadBtn.TabIndex = 0
        Me.FileUploadBtn.Text = "簽收單上傳"
        Me.FileUploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FileUploadBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.LogText)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 935)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 90)
        Me.Panel1.TabIndex = 7
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
        Me.LogText.BackColor = System.Drawing.Color.SlateGray
        Me.LogText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogText.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LogText.ForeColor = System.Drawing.Color.White
        Me.LogText.Location = New System.Drawing.Point(0, 27)
        Me.LogText.Multiline = True
        Me.LogText.Name = "LogText"
        Me.LogText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.LogText.Size = New System.Drawing.Size(848, 63)
        Me.LogText.TabIndex = 6
        '
        'LoadingDataBGW
        '
        '
        'RepairResultDGV
        '
        Me.RepairResultDGV.ColumnCount = 2
        Me.RepairResultDGV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RepairResultDGV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RepairResultDGV.Controls.Add(Me.Label17, 0, 0)
        Me.RepairResultDGV.Controls.Add(Me.RepairResultText, 1, 0)
        Me.RepairResultDGV.Controls.Add(Me.FileUploadBtn, 0, 1)
        Me.RepairResultDGV.Controls.Add(Me.FlowLayoutPanel3, 1, 1)
        Me.RepairResultDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RepairResultDGV.Location = New System.Drawing.Point(0, 786)
        Me.RepairResultDGV.Margin = New System.Windows.Forms.Padding(0)
        Me.RepairResultDGV.MinimumSize = New System.Drawing.Size(0, 121)
        Me.RepairResultDGV.Name = "RepairResultDGV"
        Me.RepairResultDGV.RowCount = 2
        Me.RepairResultDGV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.75839!))
        Me.RepairResultDGV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.24161!))
        Me.RepairResultDGV.Size = New System.Drawing.Size(848, 149)
        Me.RepairResultDGV.TabIndex = 5
        Me.RepairResultDGV.Visible = False
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 24)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "維修情況說明"
        '
        'RepairResultText
        '
        Me.RepairResultText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepairResultText.Location = New System.Drawing.Point(143, 3)
        Me.RepairResultText.Multiline = True
        Me.RepairResultText.Name = "RepairResultText"
        Me.RepairResultText.Size = New System.Drawing.Size(702, 88)
        Me.RepairResultText.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoScroll = True
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(143, 97)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(702, 49)
        Me.FlowLayoutPanel3.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 785)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(848, 1)
        Me.Panel3.TabIndex = 19
        '
        'Set_Repair_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(848, 745)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.RepairResultDGV)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
        CType(Me.RepairAmountDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.RepairResultDGV.ResumeLayout(False)
        Me.RepairResultDGV.PerformLayout()
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
    Friend WithEvents RepairPersonText As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RemarkText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents UnJudgeCheckBox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents RepairAmountDGV As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents TotalAmountText As Label
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents AddressText As TextBox
    Friend WithEvents ETADate As DateTimePicker
    Friend WithEvents ArchiveDate As DateTimePicker
    Friend WithEvents RepairOrderText As Label
    Friend WithEvents WarrantyText As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ReCheckBtn As Button
    Friend WithEvents RepairConfirmBtn As Button
    Friend WithEvents FileUploadBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents LogText As TextBox
    Friend WithEvents RepairProdDGV As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusText As Label
    Friend WithEvents LoadingDataBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents RepairProdID As DataGridViewTextBoxColumn
    Friend WithEvents ProdPartType As DataGridViewTextBoxColumn
    Friend WithEvents ShipmentPID As DataGridViewTextBoxColumn
    Friend WithEvents ProdPartName As DataGridViewComboBoxColumn
    Friend WithEvents RepairCount As DataGridViewTextBoxColumn
    Friend WithEvents RepairRemark As DataGridViewTextBoxColumn
    Friend WithEvents RepairAmountID As DataGridViewTextBoxColumn
    Friend WithEvents BillItem As DataGridViewComboBoxColumn
    Friend WithEvents RepairPrice As DataGridViewTextBoxColumn
    Friend WithEvents SubmitBtn As Button
    Friend WithEvents RepairResultDGV As TableLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents RepairResultText As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ImageList1 As ImageList
End Class
