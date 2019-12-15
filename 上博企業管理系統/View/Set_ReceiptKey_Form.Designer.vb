<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Set_ReceiptKey_Form
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Set_ReceiptKey_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PlaceText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InsertDate = New System.Windows.Forms.DateTimePicker()
        Me.ReceiptOrderText = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReceiptKeyDGV = New System.Windows.Forms.DataGridView()
        Me.ReceiptKeyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RepairConfirmBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.RepairResultDGV = New System.Windows.Forms.TableLayoutPanel()
        Me.FileUploadBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.ReceiptKeyDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.PlaceText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.InsertDate, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiptOrderText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusText, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactText, 3, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(914, 102)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PlaceText
        '
        Me.PlaceText.Location = New System.Drawing.Point(95, 42)
        Me.PlaceText.Name = "PlaceText"
        Me.PlaceText.Size = New System.Drawing.Size(330, 33)
        Me.PlaceText.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "簽收單號"
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
        'InsertDate
        '
        Me.InsertDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InsertDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InsertDate.Location = New System.Drawing.Point(523, 3)
        Me.InsertDate.Name = "InsertDate"
        Me.InsertDate.Size = New System.Drawing.Size(388, 33)
        Me.InsertDate.TabIndex = 1
        '
        'ReceiptOrderText
        '
        Me.ReceiptOrderText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ReceiptOrderText.AutoSize = True
        Me.ReceiptOrderText.Location = New System.Drawing.Point(95, 7)
        Me.ReceiptOrderText.Name = "ReceiptOrderText"
        Me.ReceiptOrderText.Size = New System.Drawing.Size(0, 24)
        Me.ReceiptOrderText.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(431, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "狀態"
        '
        'StatusText
        '
        Me.StatusText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StatusText.AutoSize = True
        Me.StatusText.Location = New System.Drawing.Point(523, 78)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(86, 24)
        Me.StatusText.TabIndex = 23
        Me.StatusText.Text = "尚未建檔"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "聯絡人"
        '
        'ContactText
        '
        Me.ContactText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactText.Location = New System.Drawing.Point(523, 42)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.Size = New System.Drawing.Size(388, 33)
        Me.ContactText.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.ReceiptKeyDGV, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 102)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 221.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(914, 221)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'ReceiptKeyDGV
        '
        Me.ReceiptKeyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceiptKeyDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceiptKeyDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ReceiptKeyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceiptKeyDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptKeyID, Me.Room, Me.Item, Me.Location, Me.ReceiptCount, Me.ReceiptRemark})
        Me.ReceiptKeyDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiptKeyDGV.Location = New System.Drawing.Point(3, 3)
        Me.ReceiptKeyDGV.MultiSelect = False
        Me.ReceiptKeyDGV.Name = "ReceiptKeyDGV"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.ReceiptKeyDGV.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ReceiptKeyDGV.RowTemplate.Height = 24
        Me.ReceiptKeyDGV.Size = New System.Drawing.Size(908, 215)
        Me.ReceiptKeyDGV.TabIndex = 0
        '
        'ReceiptKeyID
        '
        Me.ReceiptKeyID.HeaderText = "ReceiptKeyID"
        Me.ReceiptKeyID.Name = "ReceiptKeyID"
        Me.ReceiptKeyID.Visible = False
        '
        'Room
        '
        Me.Room.HeaderText = "棟別"
        Me.Room.Name = "Room"
        '
        'Item
        '
        Me.Item.HeaderText = "項目"
        Me.Item.Name = "Item"
        '
        'Location
        '
        Me.Location.HeaderText = "位置"
        Me.Location.Name = "Location"
        Me.Location.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ReceiptCount
        '
        Me.ReceiptCount.HeaderText = "數量"
        Me.ReceiptCount.Name = "ReceiptCount"
        '
        'ReceiptRemark
        '
        Me.ReceiptRemark.HeaderText = "備註"
        Me.ReceiptRemark.Name = "ReceiptRemark"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.RepairConfirmBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.PrintBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.ExitBtn)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 378)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(914, 42)
        Me.FlowLayoutPanel2.TabIndex = 7
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
        'RepairConfirmBtn
        '
        Me.RepairConfirmBtn.AutoSize = True
        Me.RepairConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RepairConfirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RepairConfirmBtn.ImageKey = "completed.png"
        Me.RepairConfirmBtn.ImageList = Me.ImageList1
        Me.RepairConfirmBtn.Location = New System.Drawing.Point(91, 3)
        Me.RepairConfirmBtn.Name = "RepairConfirmBtn"
        Me.RepairConfirmBtn.Size = New System.Drawing.Size(80, 36)
        Me.RepairConfirmBtn.TabIndex = 3
        Me.RepairConfirmBtn.Text = "結案"
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
        Me.PrintBtn.Location = New System.Drawing.Point(177, 3)
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
        Me.ExitBtn.Location = New System.Drawing.Point(262, 3)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(80, 36)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "關閉"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'RepairResultDGV
        '
        Me.RepairResultDGV.AutoSize = True
        Me.RepairResultDGV.ColumnCount = 2
        Me.RepairResultDGV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.RepairResultDGV.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RepairResultDGV.Controls.Add(Me.FileUploadBtn, 0, 0)
        Me.RepairResultDGV.Controls.Add(Me.FlowLayoutPanel3, 1, 0)
        Me.RepairResultDGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.RepairResultDGV.Location = New System.Drawing.Point(0, 323)
        Me.RepairResultDGV.Margin = New System.Windows.Forms.Padding(0)
        Me.RepairResultDGV.Name = "RepairResultDGV"
        Me.RepairResultDGV.RowCount = 1
        Me.RepairResultDGV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RepairResultDGV.Size = New System.Drawing.Size(914, 55)
        Me.RepairResultDGV.TabIndex = 8
        '
        'FileUploadBtn
        '
        Me.FileUploadBtn.AutoSize = True
        Me.FileUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileUploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileUploadBtn.ImageIndex = 3
        Me.FileUploadBtn.Location = New System.Drawing.Point(3, 3)
        Me.FileUploadBtn.Name = "FileUploadBtn"
        Me.FileUploadBtn.Size = New System.Drawing.Size(134, 49)
        Me.FileUploadBtn.TabIndex = 0
        Me.FileUploadBtn.Text = "簽收單上傳"
        Me.FileUploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FileUploadBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoScroll = True
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(143, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(768, 49)
        Me.FlowLayoutPanel3.TabIndex = 17
        '
        'Set_ReceiptKey_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(914, 435)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.RepairResultDGV)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Set_ReceiptKey_Form"
        Me.Text = "鑰匙單設定"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.ReceiptKeyDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.RepairResultDGV.ResumeLayout(False)
        Me.RepairResultDGV.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PlaceText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InsertDate As DateTimePicker
    Friend WithEvents ReceiptOrderText As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactText As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents ReceiptKeyDGV As DataGridView
    Friend WithEvents ReceiptKeyID As DataGridViewTextBoxColumn
    Friend WithEvents Room As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptCount As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptRemark As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveBtn As Button
    Friend WithEvents RepairConfirmBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents RepairResultDGV As TableLayoutPanel
    Friend WithEvents FileUploadBtn As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ImageList1 As ImageList
End Class
