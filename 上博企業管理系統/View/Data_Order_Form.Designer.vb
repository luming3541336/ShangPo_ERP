<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Order_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Order_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.currentText = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalText = New System.Windows.Forms.Label()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.orderLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.orderNoLabel = New System.Windows.Forms.Label()
        Me.orderText = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.userNameText = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dateNameText = New System.Windows.Forms.Label()
        Me.dateTime = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.prodDGV = New System.Windows.Forms.DataGridView()
        Me.prodID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSpecification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodPIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FitDGV = New System.Windows.Forms.DataGridView()
        Me.fitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitSupplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitSpecification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitCBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitPIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.initiBackGround = New System.ComponentModel.BackgroundWorker()
        Me.getDetailBackGround = New System.ComponentModel.BackgroundWorker()
        Me.PrintShippingRecordBackground = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.prodDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.FitDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1252, 707)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.DelBtn)
        Me.Panel1.Controls.Add(Me.editBtn)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel1.Controls.Add(Me.orderLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 44)
        Me.Panel1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "note_del.png")
        Me.ImageList1.Images.SetKeyName(1, "note_revise.png")
        Me.ImageList1.Images.SetKeyName(2, "print.png")
        '
        'DelBtn
        '
        Me.DelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelBtn.AutoSize = True
        Me.DelBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.DelBtn.FlatAppearance.BorderSize = 2
        Me.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelBtn.ImageIndex = 0
        Me.DelBtn.ImageList = Me.ImageList1
        Me.DelBtn.Location = New System.Drawing.Point(1159, 4)
        Me.DelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(84, 38)
        Me.DelBtn.TabIndex = 8
        Me.DelBtn.Text = "刪除&D"
        Me.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBtn.AutoSize = True
        Me.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.editBtn.FlatAppearance.BorderSize = 2
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.editBtn.ForeColor = System.Drawing.Color.White
        Me.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editBtn.ImageIndex = 1
        Me.editBtn.ImageList = Me.ImageList1
        Me.editBtn.Location = New System.Drawing.Point(1075, 3)
        Me.editBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(80, 38)
        Me.editBtn.TabIndex = 7
        Me.editBtn.Text = "修改&E"
        Me.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.previousBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.currentText)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel2.Controls.Add(Me.totalText)
        Me.FlowLayoutPanel2.Controls.Add(Me.nextBtn)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(553, 2)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(148, 38)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'previousBtn
        '
        Me.previousBtn.AutoSize = True
        Me.previousBtn.BackColor = System.Drawing.Color.Transparent
        Me.previousBtn.FlatAppearance.BorderSize = 0
        Me.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previousBtn.ForeColor = System.Drawing.Color.White
        Me.previousBtn.Location = New System.Drawing.Point(2, 2)
        Me.previousBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(34, 34)
        Me.previousBtn.TabIndex = 2
        Me.previousBtn.Text = "<"
        Me.previousBtn.UseVisualStyleBackColor = False
        '
        'currentText
        '
        Me.currentText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.currentText.AutoSize = True
        Me.currentText.ForeColor = System.Drawing.Color.White
        Me.currentText.Location = New System.Drawing.Point(40, 0)
        Me.currentText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.currentText.Name = "currentText"
        Me.currentText.Size = New System.Drawing.Size(21, 38)
        Me.currentText.TabIndex = 5
        Me.currentText.Text = "1"
        Me.currentText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(65, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(18, 38)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "/"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalText
        '
        Me.totalText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.totalText.AutoSize = True
        Me.totalText.ForeColor = System.Drawing.Color.White
        Me.totalText.Location = New System.Drawing.Point(87, 0)
        Me.totalText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalText.Name = "totalText"
        Me.totalText.Size = New System.Drawing.Size(21, 38)
        Me.totalText.TabIndex = 7
        Me.totalText.Text = "1"
        Me.totalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nextBtn
        '
        Me.nextBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nextBtn.AutoSize = True
        Me.nextBtn.BackColor = System.Drawing.Color.Transparent
        Me.nextBtn.FlatAppearance.BorderSize = 0
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.ForeColor = System.Drawing.Color.White
        Me.nextBtn.Location = New System.Drawing.Point(112, 2)
        Me.nextBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(34, 34)
        Me.nextBtn.TabIndex = 4
        Me.nextBtn.Text = ">"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        'orderLabel
        '
        Me.orderLabel.AutoSize = True
        Me.orderLabel.ForeColor = System.Drawing.Color.White
        Me.orderLabel.Location = New System.Drawing.Point(4, 5)
        Me.orderLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.orderLabel.Name = "orderLabel"
        Me.orderLabel.Size = New System.Drawing.Size(67, 24)
        Me.orderLabel.TabIndex = 0
        Me.orderLabel.Text = "進貨單"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 50)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1248, 645)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1244, 42)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.Controls.Add(Me.orderNoLabel)
        Me.Panel3.Controls.Add(Me.orderText)
        Me.Panel3.Location = New System.Drawing.Point(2, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(291, 38)
        Me.Panel3.TabIndex = 2
        '
        'orderNoLabel
        '
        Me.orderNoLabel.AutoSize = True
        Me.orderNoLabel.ForeColor = System.Drawing.Color.White
        Me.orderNoLabel.Location = New System.Drawing.Point(2, 3)
        Me.orderNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.orderNoLabel.Name = "orderNoLabel"
        Me.orderNoLabel.Size = New System.Drawing.Size(90, 24)
        Me.orderNoLabel.TabIndex = 0
        Me.orderNoLabel.Text = "進貨單號:"
        '
        'orderText
        '
        Me.orderText.Location = New System.Drawing.Point(93, 4)
        Me.orderText.Margin = New System.Windows.Forms.Padding(2)
        Me.orderText.Name = "orderText"
        Me.orderText.ReadOnly = True
        Me.orderText.Size = New System.Drawing.Size(196, 32)
        Me.orderText.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.userNameText)
        Me.Panel4.Location = New System.Drawing.Point(297, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(272, 36)
        Me.Panel4.TabIndex = 3
        Me.Panel4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "建立人:"
        '
        'userNameText
        '
        Me.userNameText.Location = New System.Drawing.Point(74, 2)
        Me.userNameText.Margin = New System.Windows.Forms.Padding(2)
        Me.userNameText.Name = "userNameText"
        Me.userNameText.Size = New System.Drawing.Size(196, 32)
        Me.userNameText.TabIndex = 1
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.SlateGray
        Me.FlowLayoutPanel3.Controls.Add(Me.dateNameText)
        Me.FlowLayoutPanel3.Controls.Add(Me.dateTime)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(573, 3)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(275, 36)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'dateNameText
        '
        Me.dateNameText.AutoSize = True
        Me.dateNameText.ForeColor = System.Drawing.Color.White
        Me.dateNameText.Location = New System.Drawing.Point(2, 0)
        Me.dateNameText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dateNameText.Name = "dateNameText"
        Me.dateNameText.Size = New System.Drawing.Size(105, 24)
        Me.dateNameText.TabIndex = 2
        Me.dateNameText.Text = "出貨日期："
        '
        'dateTime
        '
        Me.dateTime.Enabled = False
        Me.dateTime.Location = New System.Drawing.Point(111, 2)
        Me.dateTime.Margin = New System.Windows.Forms.Padding(2)
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Size = New System.Drawing.Size(162, 32)
        Me.dateTime.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1242, 593)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.prodDGV)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1234, 557)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "門框/窗框"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'prodDGV
        '
        Me.prodDGV.AllowUserToAddRows = False
        Me.prodDGV.AllowUserToDeleteRows = False
        Me.prodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.prodDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.prodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prodDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodID, Me.prodSupplierName, Me.prodName, Me.prodSpecification, Me.prodWidth, Me.prodLength, Me.prodCBM, Me.prodCount, Me.prodRemark, Me.prodPIC})
        Me.prodDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.prodDGV.Location = New System.Drawing.Point(3, 3)
        Me.prodDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.prodDGV.Name = "prodDGV"
        Me.prodDGV.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.prodDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.prodDGV.RowTemplate.Height = 38
        Me.prodDGV.Size = New System.Drawing.Size(1228, 551)
        Me.prodDGV.TabIndex = 4
        '
        'prodID
        '
        Me.prodID.HeaderText = "prodID"
        Me.prodID.Name = "prodID"
        Me.prodID.ReadOnly = True
        Me.prodID.Visible = False
        Me.prodID.Width = 97
        '
        'prodSupplierName
        '
        Me.prodSupplierName.HeaderText = "供應商"
        Me.prodSupplierName.Name = "prodSupplierName"
        Me.prodSupplierName.ReadOnly = True
        Me.prodSupplierName.Width = 92
        '
        'prodName
        '
        Me.prodName.HeaderText = "名稱"
        Me.prodName.Name = "prodName"
        Me.prodName.ReadOnly = True
        Me.prodName.Width = 73
        '
        'prodSpecification
        '
        Me.prodSpecification.HeaderText = "規格"
        Me.prodSpecification.Name = "prodSpecification"
        Me.prodSpecification.ReadOnly = True
        Me.prodSpecification.Width = 73
        '
        'prodWidth
        '
        Me.prodWidth.HeaderText = "寬"
        Me.prodWidth.Name = "prodWidth"
        Me.prodWidth.ReadOnly = True
        Me.prodWidth.Width = 54
        '
        'prodLength
        '
        Me.prodLength.HeaderText = "高"
        Me.prodLength.Name = "prodLength"
        Me.prodLength.ReadOnly = True
        Me.prodLength.Width = 54
        '
        'prodCBM
        '
        Me.prodCBM.HeaderText = "材積"
        Me.prodCBM.Name = "prodCBM"
        Me.prodCBM.ReadOnly = True
        Me.prodCBM.Width = 73
        '
        'prodCount
        '
        Me.prodCount.HeaderText = "數量"
        Me.prodCount.Name = "prodCount"
        Me.prodCount.ReadOnly = True
        Me.prodCount.Width = 73
        '
        'prodRemark
        '
        Me.prodRemark.HeaderText = "備註"
        Me.prodRemark.Name = "prodRemark"
        Me.prodRemark.ReadOnly = True
        Me.prodRemark.Width = 73
        '
        'prodPIC
        '
        Me.prodPIC.HeaderText = "進場人員"
        Me.prodPIC.Name = "prodPIC"
        Me.prodPIC.ReadOnly = True
        Me.prodPIC.Visible = False
        Me.prodPIC.Width = 111
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FitDGV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1234, 567)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "門扇"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FitDGV
        '
        Me.FitDGV.AllowUserToAddRows = False
        Me.FitDGV.AllowUserToDeleteRows = False
        Me.FitDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.FitDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.FitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FitDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fitID, Me.fitSupplierName, Me.fitName, Me.fitSpecification, Me.fitWidth, Me.fitLength, Me.fitCBM, Me.fitCount, Me.fitRemark, Me.fitPIC})
        Me.FitDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FitDGV.Location = New System.Drawing.Point(3, 3)
        Me.FitDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.FitDGV.Name = "FitDGV"
        Me.FitDGV.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.FitDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.FitDGV.RowTemplate.Height = 38
        Me.FitDGV.Size = New System.Drawing.Size(1228, 561)
        Me.FitDGV.TabIndex = 5
        '
        'fitID
        '
        Me.fitID.HeaderText = "fitID"
        Me.fitID.Name = "fitID"
        Me.fitID.ReadOnly = True
        Me.fitID.Visible = False
        Me.fitID.Width = 72
        '
        'fitSupplierName
        '
        Me.fitSupplierName.HeaderText = "供應商"
        Me.fitSupplierName.Name = "fitSupplierName"
        Me.fitSupplierName.ReadOnly = True
        Me.fitSupplierName.Width = 92
        '
        'fitName
        '
        Me.fitName.HeaderText = "名稱"
        Me.fitName.Name = "fitName"
        Me.fitName.ReadOnly = True
        Me.fitName.Width = 73
        '
        'fitSpecification
        '
        Me.fitSpecification.HeaderText = "規格"
        Me.fitSpecification.Name = "fitSpecification"
        Me.fitSpecification.ReadOnly = True
        Me.fitSpecification.Width = 73
        '
        'fitWidth
        '
        Me.fitWidth.HeaderText = "寬"
        Me.fitWidth.Name = "fitWidth"
        Me.fitWidth.ReadOnly = True
        Me.fitWidth.Width = 54
        '
        'fitLength
        '
        Me.fitLength.HeaderText = "高"
        Me.fitLength.Name = "fitLength"
        Me.fitLength.ReadOnly = True
        Me.fitLength.Width = 54
        '
        'fitCBM
        '
        Me.fitCBM.HeaderText = "材積"
        Me.fitCBM.Name = "fitCBM"
        Me.fitCBM.ReadOnly = True
        Me.fitCBM.Visible = False
        Me.fitCBM.Width = 73
        '
        'fitCount
        '
        Me.fitCount.HeaderText = "數量"
        Me.fitCount.Name = "fitCount"
        Me.fitCount.ReadOnly = True
        Me.fitCount.Width = 73
        '
        'fitRemark
        '
        Me.fitRemark.HeaderText = "備註"
        Me.fitRemark.Name = "fitRemark"
        Me.fitRemark.ReadOnly = True
        Me.fitRemark.Width = 73
        '
        'fitPIC
        '
        Me.fitPIC.HeaderText = "進場人員"
        Me.fitPIC.Name = "fitPIC"
        Me.fitPIC.ReadOnly = True
        Me.fitPIC.Visible = False
        Me.fitPIC.Width = 111
        '
        'initiBackGround
        '
        '
        'getDetailBackGround
        '
        '
        'Data_Order_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1252, 707)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Data_Order_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進貨單"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.prodDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.FitDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents previousBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents orderLabel As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents orderNoLabel As Label
    Friend WithEvents orderText As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents userNameText As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents currentText As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalText As Label
    Friend WithEvents initiBackGround As System.ComponentModel.BackgroundWorker
    Friend WithEvents getDetailBackGround As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents dateNameText As Label
    Friend WithEvents dateTime As DateTimePicker
    Friend WithEvents editBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents prodDGV As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FitDGV As DataGridView
    Friend WithEvents fitID As DataGridViewTextBoxColumn
    Friend WithEvents fitSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents fitName As DataGridViewTextBoxColumn
    Friend WithEvents fitSpecification As DataGridViewTextBoxColumn
    Friend WithEvents fitWidth As DataGridViewTextBoxColumn
    Friend WithEvents fitLength As DataGridViewTextBoxColumn
    Friend WithEvents fitCBM As DataGridViewTextBoxColumn
    Friend WithEvents fitCount As DataGridViewTextBoxColumn
    Friend WithEvents fitRemark As DataGridViewTextBoxColumn
    Friend WithEvents fitPIC As DataGridViewTextBoxColumn
    Friend WithEvents prodID As DataGridViewTextBoxColumn
    Friend WithEvents prodSupplierName As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodSpecification As DataGridViewTextBoxColumn
    Friend WithEvents prodWidth As DataGridViewTextBoxColumn
    Friend WithEvents prodLength As DataGridViewTextBoxColumn
    Friend WithEvents prodCBM As DataGridViewTextBoxColumn
    Friend WithEvents prodCount As DataGridViewTextBoxColumn
    Friend WithEvents prodRemark As DataGridViewTextBoxColumn
    Friend WithEvents prodPIC As DataGridViewTextBoxColumn
    Friend WithEvents PrintShippingRecordBackground As System.ComponentModel.BackgroundWorker
End Class
