<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Set_Purchase_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Set_Purchase_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PurchaseNoText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PurchaseTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CurrentCaseLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveDataButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ProdDGV = New System.Windows.Forms.DataGridView()
        Me.prodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MouseMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MulAddItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectProdItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FitDGV = New System.Windows.Forms.DataGridView()
        Me.ProdPart2ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitSpecification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitCBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addPurchaseNoBackground = New System.ComponentModel.BackgroundWorker()
        Me.insertToDatabaseBackground = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ProdDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MouseMenu.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.FitDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(842, 516)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PurchaseNoText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.PurchaseTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.CurrentCaseLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 3)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(838, 36)
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
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "進貨編號："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PurchaseNoText
        '
        Me.PurchaseNoText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PurchaseNoText.BackColor = System.Drawing.Color.White
        Me.PurchaseNoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PurchaseNoText.Location = New System.Drawing.Point(111, 0)
        Me.PurchaseNoText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PurchaseNoText.Name = "PurchaseNoText"
        Me.PurchaseNoText.Size = New System.Drawing.Size(188, 36)
        Me.PurchaseNoText.TabIndex = 1
        Me.PurchaseNoText.Text = "Label2"
        Me.PurchaseNoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(303, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "進貨日期："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PurchaseTime
        '
        Me.PurchaseTime.Location = New System.Drawing.Point(412, 2)
        Me.PurchaseTime.Margin = New System.Windows.Forms.Padding(2)
        Me.PurchaseTime.Name = "PurchaseTime"
        Me.PurchaseTime.Size = New System.Drawing.Size(162, 32)
        Me.PurchaseTime.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(578, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "目前操作案件："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrentCaseLabel
        '
        Me.CurrentCaseLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrentCaseLabel.BackColor = System.Drawing.Color.White
        Me.CurrentCaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentCaseLabel.Location = New System.Drawing.Point(2, 36)
        Me.CurrentCaseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CurrentCaseLabel.Name = "CurrentCaseLabel"
        Me.CurrentCaseLabel.Size = New System.Drawing.Size(171, 0)
        Me.CurrentCaseLabel.TabIndex = 6
        Me.CurrentCaseLabel.Text = "Label2"
        Me.CurrentCaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveDataButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.CancelButton)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(655, 474)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(185, 40)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'SaveDataButton
        '
        Me.SaveDataButton.BackColor = System.Drawing.Color.DarkCyan
        Me.SaveDataButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SaveDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveDataButton.ForeColor = System.Drawing.Color.White
        Me.SaveDataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveDataButton.ImageIndex = 0
        Me.SaveDataButton.ImageList = Me.ImageList1
        Me.SaveDataButton.Location = New System.Drawing.Point(2, 2)
        Me.SaveDataButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveDataButton.Name = "SaveDataButton"
        Me.SaveDataButton.Size = New System.Drawing.Size(87, 36)
        Me.SaveDataButton.TabIndex = 0
        Me.SaveDataButton.Text = "存檔&S"
        Me.SaveDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveDataButton.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Save.png")
        Me.ImageList1.Images.SetKeyName(1, "cancel.png")
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.ForeColor = System.Drawing.Color.White
        Me.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelButton.ImageIndex = 1
        Me.CancelButton.ImageList = Me.ImageList1
        Me.CancelButton.Location = New System.Drawing.Point(93, 2)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(90, 36)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "取消&D"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(836, 424)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ProdDGV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(828, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "門框/窗框"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ProdDGV
        '
        Me.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProdDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodID, Me.prodName, Me.prodSupplier, Me.prodClass, Me.prodWidth, Me.prodLength, Me.prodCBM, Me.prodCount, Me.prodRemark})
        Me.ProdDGV.ContextMenuStrip = Me.MouseMenu
        Me.ProdDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdDGV.Location = New System.Drawing.Point(3, 3)
        Me.ProdDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.ProdDGV.Name = "ProdDGV"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.ProdDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProdDGV.RowTemplate.Height = 38
        Me.ProdDGV.Size = New System.Drawing.Size(822, 382)
        Me.ProdDGV.TabIndex = 0
        '
        'prodID
        '
        Me.prodID.HeaderText = "prodID"
        Me.prodID.Name = "prodID"
        Me.prodID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodID.Visible = False
        Me.prodID.Width = 78
        '
        'prodName
        '
        Me.prodName.HeaderText = "名稱"
        Me.prodName.Name = "prodName"
        Me.prodName.ReadOnly = True
        Me.prodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodName.Width = 54
        '
        'prodSupplier
        '
        Me.prodSupplier.HeaderText = "供應商"
        Me.prodSupplier.Name = "prodSupplier"
        Me.prodSupplier.ReadOnly = True
        Me.prodSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodSupplier.Width = 73
        '
        'prodClass
        '
        Me.prodClass.HeaderText = "規格"
        Me.prodClass.Name = "prodClass"
        Me.prodClass.ReadOnly = True
        Me.prodClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodClass.Width = 54
        '
        'prodWidth
        '
        Me.prodWidth.HeaderText = "寬"
        Me.prodWidth.Name = "prodWidth"
        Me.prodWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodWidth.Width = 35
        '
        'prodLength
        '
        Me.prodLength.HeaderText = "高"
        Me.prodLength.Name = "prodLength"
        Me.prodLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodLength.Width = 35
        '
        'prodCBM
        '
        Me.prodCBM.HeaderText = "材積"
        Me.prodCBM.Name = "prodCBM"
        Me.prodCBM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodCBM.Width = 54
        '
        'prodCount
        '
        Me.prodCount.HeaderText = "數量"
        Me.prodCount.Name = "prodCount"
        Me.prodCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodCount.Width = 54
        '
        'prodRemark
        '
        Me.prodRemark.HeaderText = "備註"
        Me.prodRemark.Name = "prodRemark"
        Me.prodRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.prodRemark.Width = 54
        '
        'MouseMenu
        '
        Me.MouseMenu.Font = New System.Drawing.Font("微軟正黑體", 13.875!)
        Me.MouseMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MouseMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertItem, Me.MulAddItem, Me.SelectProdItem, Me.CopyItem, Me.PasteItem})
        Me.MouseMenu.Name = "MouseMenu"
        Me.MouseMenu.Size = New System.Drawing.Size(157, 144)
        '
        'InsertItem
        '
        Me.InsertItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.InsertItem.Name = "InsertItem"
        Me.InsertItem.Size = New System.Drawing.Size(156, 28)
        Me.InsertItem.Text = "插入"
        '
        'MulAddItem
        '
        Me.MulAddItem.Name = "MulAddItem"
        Me.MulAddItem.Size = New System.Drawing.Size(156, 28)
        Me.MulAddItem.Text = "多筆欄位"
        '
        'SelectProdItem
        '
        Me.SelectProdItem.Name = "SelectProdItem"
        Me.SelectProdItem.Size = New System.Drawing.Size(156, 28)
        Me.SelectProdItem.Text = "查詢產品"
        '
        'CopyItem
        '
        Me.CopyItem.Name = "CopyItem"
        Me.CopyItem.Size = New System.Drawing.Size(156, 28)
        Me.CopyItem.Text = "複製"
        '
        'PasteItem
        '
        Me.PasteItem.Name = "PasteItem"
        Me.PasteItem.Size = New System.Drawing.Size(156, 28)
        Me.PasteItem.Text = "貼上"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FitDGV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(828, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "門扇"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FitDGV
        '
        Me.FitDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.FitDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.FitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FitDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdPart2ID, Me.fitName, Me.fitSupplier, Me.fitSpecification, Me.FitWidth, Me.FitLength, Me.FitCBM, Me.fitCount, Me.fitRemark})
        Me.FitDGV.ContextMenuStrip = Me.MouseMenu
        Me.FitDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FitDGV.Location = New System.Drawing.Point(3, 3)
        Me.FitDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.FitDGV.Name = "FitDGV"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.FitDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.FitDGV.RowTemplate.Height = 38
        Me.FitDGV.Size = New System.Drawing.Size(822, 382)
        Me.FitDGV.TabIndex = 0
        '
        'ProdPart2ID
        '
        Me.ProdPart2ID.HeaderText = "ProdPart2ID"
        Me.ProdPart2ID.Name = "ProdPart2ID"
        Me.ProdPart2ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ProdPart2ID.Visible = False
        Me.ProdPart2ID.Width = 123
        '
        'fitName
        '
        Me.fitName.HeaderText = "名稱"
        Me.fitName.Name = "fitName"
        Me.fitName.ReadOnly = True
        Me.fitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fitName.Width = 54
        '
        'fitSupplier
        '
        Me.fitSupplier.HeaderText = "供應商"
        Me.fitSupplier.Name = "fitSupplier"
        Me.fitSupplier.ReadOnly = True
        Me.fitSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fitSupplier.Width = 73
        '
        'fitSpecification
        '
        Me.fitSpecification.HeaderText = "規格"
        Me.fitSpecification.Name = "fitSpecification"
        Me.fitSpecification.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fitSpecification.Width = 54
        '
        'FitWidth
        '
        Me.FitWidth.HeaderText = "寬"
        Me.FitWidth.Name = "FitWidth"
        Me.FitWidth.Width = 54
        '
        'FitLength
        '
        Me.FitLength.HeaderText = "高"
        Me.FitLength.Name = "FitLength"
        Me.FitLength.Width = 54
        '
        'FitCBM
        '
        Me.FitCBM.HeaderText = "材積"
        Me.FitCBM.Name = "FitCBM"
        Me.FitCBM.Visible = False
        Me.FitCBM.Width = 73
        '
        'fitCount
        '
        Me.fitCount.HeaderText = "數量"
        Me.fitCount.Name = "fitCount"
        Me.fitCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fitCount.Width = 54
        '
        'fitRemark
        '
        Me.fitRemark.HeaderText = "備註"
        Me.fitRemark.Name = "fitRemark"
        Me.fitRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fitRemark.Width = 54
        '
        'addPurchaseNoBackground
        '
        Me.addPurchaseNoBackground.WorkerReportsProgress = True
        '
        'insertToDatabaseBackground
        '
        Me.insertToDatabaseBackground.WorkerReportsProgress = True
        '
        'Set_Purchase_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(842, 516)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Set_Purchase_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進貨新增"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.ProdDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MouseMenu.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.FitDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PurchaseNoText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProdDGV As DataGridView
    Friend WithEvents FitDGV As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveDataButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents addPurchaseNoBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents insertToDatabaseBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents PurchaseTime As DateTimePicker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MouseMenu As ContextMenuStrip
    Friend WithEvents InsertItem As ToolStripMenuItem
    Friend WithEvents SelectProdItem As ToolStripMenuItem
    Friend WithEvents CopyItem As ToolStripMenuItem
    Friend WithEvents PasteItem As ToolStripMenuItem
    Friend WithEvents MulAddItem As ToolStripMenuItem
    Friend WithEvents prodID As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodSupplier As DataGridViewTextBoxColumn
    Friend WithEvents prodClass As DataGridViewTextBoxColumn
    Friend WithEvents prodWidth As DataGridViewTextBoxColumn
    Friend WithEvents prodLength As DataGridViewTextBoxColumn
    Friend WithEvents prodCBM As DataGridViewTextBoxColumn
    Friend WithEvents prodCount As DataGridViewTextBoxColumn
    Friend WithEvents prodRemark As DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentCaseLabel As Label
    Friend WithEvents ProdPart2ID As DataGridViewTextBoxColumn
    Friend WithEvents fitName As DataGridViewTextBoxColumn
    Friend WithEvents fitSupplier As DataGridViewTextBoxColumn
    Friend WithEvents fitSpecification As DataGridViewTextBoxColumn
    Friend WithEvents FitWidth As DataGridViewTextBoxColumn
    Friend WithEvents FitLength As DataGridViewTextBoxColumn
    Friend WithEvents FitCBM As DataGridViewTextBoxColumn
    Friend WithEvents fitCount As DataGridViewTextBoxColumn
    Friend WithEvents fitRemark As DataGridViewTextBoxColumn
End Class
