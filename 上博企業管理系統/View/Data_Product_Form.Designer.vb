<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Product_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Product_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ProdPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProdNameText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UnitCB = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ControlLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ReviseBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProdDGV = New System.Windows.Forms.DataGridView()
        Me.ProdID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ModelPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SupplierCB = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ModelText = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PriceText = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ModelAddBtn = New System.Windows.Forms.Button()
        Me.ModelReviseBtn = New System.Windows.Forms.Button()
        Me.ModelDelBtn = New System.Windows.Forms.Button()
        Me.ModelOKBtn = New System.Windows.Forms.Button()
        Me.ModelCancelBtn = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ModelDGV = New System.Windows.Forms.DataGridView()
        Me.ProdModelID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ProdPanel.SuspendLayout()
        Me.ControlLayout.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ProdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ModelPanel.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ModelDGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(843, 648)
        Me.SplitContainer1.SplitterDistance = 281
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ProdPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ControlLayout, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(843, 281)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ProdPanel
        '
        Me.ProdPanel.AutoSize = True
        Me.ProdPanel.Controls.Add(Me.Label2)
        Me.ProdPanel.Controls.Add(Me.ProdNameText)
        Me.ProdPanel.Controls.Add(Me.Label9)
        Me.ProdPanel.Controls.Add(Me.UnitCB)
        Me.ProdPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdPanel.Enabled = False
        Me.ProdPanel.Location = New System.Drawing.Point(3, 41)
        Me.ProdPanel.Name = "ProdPanel"
        Me.ProdPanel.Size = New System.Drawing.Size(837, 38)
        Me.ProdPanel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "樣式："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdNameText
        '
        Me.ProdNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdNameText.Location = New System.Drawing.Point(73, 2)
        Me.ProdNameText.Margin = New System.Windows.Forms.Padding(2)
        Me.ProdNameText.Name = "ProdNameText"
        Me.ProdNameText.Size = New System.Drawing.Size(351, 33)
        Me.ProdNameText.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(428, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "計算單位："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnitCB
        '
        Me.UnitCB.FormattingEnabled = True
        Me.UnitCB.Items.AddRange(New Object() {"樘"})
        Me.UnitCB.Location = New System.Drawing.Point(538, 3)
        Me.UnitCB.Name = "UnitCB"
        Me.UnitCB.Size = New System.Drawing.Size(61, 32)
        Me.UnitCB.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 281)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 1)
        Me.Panel2.TabIndex = 3
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
        Me.ControlLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlLayout.Name = "ControlLayout"
        Me.ControlLayout.Size = New System.Drawing.Size(839, 34)
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
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2)
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
        Me.ReviseBtn.Margin = New System.Windows.Forms.Padding(2)
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
        Me.DelBtn.Margin = New System.Windows.Forms.Padding(2)
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
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(2)
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
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(84, 30)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "取消"
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ProdDGV)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(2, 88)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(839, 189)
        Me.Panel4.TabIndex = 6
        '
        'ProdDGV
        '
        Me.ProdDGV.AllowUserToAddRows = False
        Me.ProdDGV.AllowUserToDeleteRows = False
        Me.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProdDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ProdDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProdDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdID, Me.ProdName, Me.Unit})
        Me.ProdDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdDGV.Location = New System.Drawing.Point(0, 0)
        Me.ProdDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.ProdDGV.MultiSelect = False
        Me.ProdDGV.Name = "ProdDGV"
        Me.ProdDGV.ReadOnly = True
        Me.ProdDGV.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.ProdDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ProdDGV.RowTemplate.Height = 24
        Me.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProdDGV.Size = New System.Drawing.Size(839, 189)
        Me.ProdDGV.TabIndex = 3
        '
        'ProdID
        '
        Me.ProdID.DataPropertyName = "ProdID"
        Me.ProdID.HeaderText = "產品名稱"
        Me.ProdID.Name = "ProdID"
        Me.ProdID.ReadOnly = True
        Me.ProdID.Visible = False
        '
        'ProdName
        '
        Me.ProdName.DataPropertyName = "ProdName"
        Me.ProdName.FillWeight = 172.5888!
        Me.ProdName.HeaderText = "樣式"
        Me.ProdName.Name = "ProdName"
        Me.ProdName.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.DataPropertyName = "Unit"
        Me.Unit.FillWeight = 27.41116!
        Me.Unit.HeaderText = "單位"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 84)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(839, 1)
        Me.Panel3.TabIndex = 8
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ModelPanel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel4, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(843, 363)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'ModelPanel
        '
        Me.ModelPanel.AutoSize = True
        Me.ModelPanel.Controls.Add(Me.Label5)
        Me.ModelPanel.Controls.Add(Me.SupplierCB)
        Me.ModelPanel.Controls.Add(Me.Label8)
        Me.ModelPanel.Controls.Add(Me.ModelText)
        Me.ModelPanel.Controls.Add(Me.Label10)
        Me.ModelPanel.Controls.Add(Me.PriceText)
        Me.ModelPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModelPanel.Enabled = False
        Me.ModelPanel.Location = New System.Drawing.Point(3, 41)
        Me.ModelPanel.Name = "ModelPanel"
        Me.ModelPanel.Size = New System.Drawing.Size(837, 38)
        Me.ModelPanel.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "供應商："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SupplierCB
        '
        Me.SupplierCB.FormattingEnabled = True
        Me.SupplierCB.Location = New System.Drawing.Point(93, 3)
        Me.SupplierCB.Name = "SupplierCB"
        Me.SupplierCB.Size = New System.Drawing.Size(171, 32)
        Me.SupplierCB.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(269, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "型號："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ModelText
        '
        Me.ModelText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ModelText.Location = New System.Drawing.Point(340, 2)
        Me.ModelText.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelText.Name = "ModelText"
        Me.ModelText.Size = New System.Drawing.Size(170, 33)
        Me.ModelText.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(514, 7)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 24)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "單價："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceText
        '
        Me.PriceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceText.Location = New System.Drawing.Point(585, 2)
        Me.PriceText.Margin = New System.Windows.Forms.Padding(2)
        Me.PriceText.Name = "PriceText"
        Me.PriceText.Size = New System.Drawing.Size(153, 33)
        Me.PriceText.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 317)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 1)
        Me.Panel1.TabIndex = 3
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel4.Controls.Add(Me.ComboBox5)
        Me.FlowLayoutPanel4.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel4.Controls.Add(Me.TextBox4)
        Me.FlowLayoutPanel4.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(2, 319)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(839, 42)
        Me.FlowLayoutPanel4.TabIndex = 4
        Me.FlowLayoutPanel4.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(2, 8)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 24)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "查詢類別："
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"產品名稱", "產品簡稱"})
        Me.ComboBox5.Location = New System.Drawing.Point(111, 2)
        Me.ComboBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(150, 32)
        Me.ComboBox5.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(265, 8)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 24)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "查詢內容："
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(374, 2)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(252, 33)
        Me.TextBox4.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(630, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "查詢"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.Controls.Add(Me.ModelAddBtn)
        Me.FlowLayoutPanel.Controls.Add(Me.ModelReviseBtn)
        Me.FlowLayoutPanel.Controls.Add(Me.ModelDelBtn)
        Me.FlowLayoutPanel.Controls.Add(Me.ModelOKBtn)
        Me.FlowLayoutPanel.Controls.Add(Me.ModelCancelBtn)
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(839, 34)
        Me.FlowLayoutPanel.TabIndex = 5
        '
        'ModelAddBtn
        '
        Me.ModelAddBtn.Enabled = False
        Me.ModelAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModelAddBtn.ForeColor = System.Drawing.Color.White
        Me.ModelAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModelAddBtn.ImageKey = "add-icon.png"
        Me.ModelAddBtn.ImageList = Me.ImageList1
        Me.ModelAddBtn.Location = New System.Drawing.Point(2, 2)
        Me.ModelAddBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelAddBtn.Name = "ModelAddBtn"
        Me.ModelAddBtn.Size = New System.Drawing.Size(84, 30)
        Me.ModelAddBtn.TabIndex = 0
        Me.ModelAddBtn.Text = "新增"
        Me.ModelAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModelAddBtn.UseVisualStyleBackColor = True
        '
        'ModelReviseBtn
        '
        Me.ModelReviseBtn.Enabled = False
        Me.ModelReviseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModelReviseBtn.ForeColor = System.Drawing.Color.White
        Me.ModelReviseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModelReviseBtn.ImageKey = "pencil-red-icon.png"
        Me.ModelReviseBtn.ImageList = Me.ImageList1
        Me.ModelReviseBtn.Location = New System.Drawing.Point(90, 2)
        Me.ModelReviseBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelReviseBtn.Name = "ModelReviseBtn"
        Me.ModelReviseBtn.Size = New System.Drawing.Size(84, 30)
        Me.ModelReviseBtn.TabIndex = 1
        Me.ModelReviseBtn.Text = "修改"
        Me.ModelReviseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModelReviseBtn.UseVisualStyleBackColor = True
        '
        'ModelDelBtn
        '
        Me.ModelDelBtn.Enabled = False
        Me.ModelDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModelDelBtn.ForeColor = System.Drawing.Color.White
        Me.ModelDelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModelDelBtn.ImageKey = "delete-icon.png"
        Me.ModelDelBtn.ImageList = Me.ImageList1
        Me.ModelDelBtn.Location = New System.Drawing.Point(178, 2)
        Me.ModelDelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelDelBtn.Name = "ModelDelBtn"
        Me.ModelDelBtn.Size = New System.Drawing.Size(84, 30)
        Me.ModelDelBtn.TabIndex = 2
        Me.ModelDelBtn.Text = "移除"
        Me.ModelDelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModelDelBtn.UseVisualStyleBackColor = True
        '
        'ModelOKBtn
        '
        Me.ModelOKBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.ModelOKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModelOKBtn.ForeColor = System.Drawing.Color.White
        Me.ModelOKBtn.Location = New System.Drawing.Point(266, 2)
        Me.ModelOKBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelOKBtn.Name = "ModelOKBtn"
        Me.ModelOKBtn.Size = New System.Drawing.Size(84, 30)
        Me.ModelOKBtn.TabIndex = 3
        Me.ModelOKBtn.Text = "確認"
        Me.ModelOKBtn.UseVisualStyleBackColor = False
        Me.ModelOKBtn.Visible = False
        '
        'ModelCancelBtn
        '
        Me.ModelCancelBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.ModelCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModelCancelBtn.ForeColor = System.Drawing.Color.White
        Me.ModelCancelBtn.Location = New System.Drawing.Point(354, 2)
        Me.ModelCancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelCancelBtn.Name = "ModelCancelBtn"
        Me.ModelCancelBtn.Size = New System.Drawing.Size(84, 30)
        Me.ModelCancelBtn.TabIndex = 4
        Me.ModelCancelBtn.Text = "取消"
        Me.ModelCancelBtn.UseVisualStyleBackColor = False
        Me.ModelCancelBtn.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ModelDGV)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(2, 88)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(839, 225)
        Me.Panel5.TabIndex = 6
        '
        'ModelDGV
        '
        Me.ModelDGV.AllowUserToAddRows = False
        Me.ModelDGV.AllowUserToDeleteRows = False
        Me.ModelDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ModelDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ModelDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ModelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdModelID, Me.SuID, Me.SupplierName, Me.Model, Me.Price})
        Me.ModelDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModelDGV.Location = New System.Drawing.Point(0, 0)
        Me.ModelDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelDGV.MultiSelect = False
        Me.ModelDGV.Name = "ModelDGV"
        Me.ModelDGV.ReadOnly = True
        Me.ModelDGV.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.ModelDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ModelDGV.RowTemplate.Height = 24
        Me.ModelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ModelDGV.Size = New System.Drawing.Size(839, 225)
        Me.ModelDGV.TabIndex = 3
        '
        'ProdModelID
        '
        Me.ProdModelID.DataPropertyName = "ProdModelID"
        Me.ProdModelID.HeaderText = "產品名稱"
        Me.ProdModelID.Name = "ProdModelID"
        Me.ProdModelID.ReadOnly = True
        Me.ProdModelID.Visible = False
        Me.ProdModelID.Width = 92
        '
        'SuID
        '
        Me.SuID.DataPropertyName = "SuID"
        Me.SuID.HeaderText = "SuID"
        Me.SuID.Name = "SuID"
        Me.SuID.ReadOnly = True
        Me.SuID.Visible = False
        Me.SuID.Width = 58
        '
        'SupplierName
        '
        Me.SupplierName.DataPropertyName = "Name"
        Me.SupplierName.HeaderText = "供應商"
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.ReadOnly = True
        Me.SupplierName.Width = 92
        '
        'Model
        '
        Me.Model.DataPropertyName = "Model"
        Me.Model.HeaderText = "型號"
        Me.Model.Name = "Model"
        Me.Model.ReadOnly = True
        Me.Model.Width = 73
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "單價"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 73
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(2, 84)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(839, 1)
        Me.Panel6.TabIndex = 8
        '
        'Data_Product_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(843, 648)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Data_Product_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "產品設定"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ProdPanel.ResumeLayout(False)
        Me.ProdPanel.PerformLayout()
        Me.ControlLayout.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.ProdDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ModelPanel.ResumeLayout(False)
        Me.ModelPanel.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.ModelDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ProdPanel As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents ProdNameText As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ControlLayout As FlowLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents ReviseBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ProdDGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ModelPanel As FlowLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents SupplierCB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ModelText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents UnitCB As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PriceText As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents ModelAddBtn As Button
    Friend WithEvents ModelReviseBtn As Button
    Friend WithEvents ModelDelBtn As Button
    Friend WithEvents ModelOKBtn As Button
    Friend WithEvents ModelCancelBtn As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ModelDGV As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ProdID As DataGridViewTextBoxColumn
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents ProdModelID As DataGridViewTextBoxColumn
    Friend WithEvents SuID As DataGridViewTextBoxColumn
    Friend WithEvents SupplierName As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
