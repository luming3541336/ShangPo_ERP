<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Set_ReceiptCom_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Set_ReceiptCom_Form))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.複製ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼上ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.RepairConfirmBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.RepairResultDGV = New System.Windows.Forms.TableLayoutPanel()
        Me.FileUploadBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InsertDate = New System.Windows.Forms.DateTimePicker()
        Me.ReceiptOrderText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReturnText = New System.Windows.Forms.TextBox()
        Me.ReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
        Me.ReceiptComDGV = New System.Windows.Forms.DataGridView()
        Me.ReceiptComID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.RepairResultDGV.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ReceiptComDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = True
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintBtn.ImageIndex = 1
        Me.PrintBtn.ImageList = Me.ImageList1
        Me.PrintBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PrintBtn.Location = New System.Drawing.Point(177, 3)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(79, 36)
        Me.PrintBtn.TabIndex = 4
        Me.PrintBtn.Text = "列印"
        Me.PrintBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintBtn.UseVisualStyleBackColor = True
        Me.PrintBtn.Visible = False
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.複製ToolStripMenuItem, Me.貼上ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 60)
        '
        '複製ToolStripMenuItem
        '
        Me.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem"
        Me.複製ToolStripMenuItem.Size = New System.Drawing.Size(118, 28)
        Me.複製ToolStripMenuItem.Text = "複製"
        '
        '貼上ToolStripMenuItem
        '
        Me.貼上ToolStripMenuItem.Enabled = False
        Me.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem"
        Me.貼上ToolStripMenuItem.Size = New System.Drawing.Size(118, 28)
        Me.貼上ToolStripMenuItem.Text = "貼上"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.RepairConfirmBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.PrintBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.ExitBtn)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 514)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(873, 42)
        Me.FlowLayoutPanel2.TabIndex = 11
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoSize = True
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.ImageIndex = 2
        Me.SaveBtn.ImageList = Me.ImageList1
        Me.SaveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SaveBtn.Location = New System.Drawing.Point(3, 3)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(82, 36)
        Me.SaveBtn.TabIndex = 0
        Me.SaveBtn.Text = "存檔"
        Me.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'RepairConfirmBtn
        '
        Me.RepairConfirmBtn.AutoSize = True
        Me.RepairConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RepairConfirmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RepairConfirmBtn.ImageKey = "completed.png"
        Me.RepairConfirmBtn.ImageList = Me.ImageList1
        Me.RepairConfirmBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RepairConfirmBtn.Location = New System.Drawing.Point(91, 3)
        Me.RepairConfirmBtn.Name = "RepairConfirmBtn"
        Me.RepairConfirmBtn.Size = New System.Drawing.Size(80, 36)
        Me.RepairConfirmBtn.TabIndex = 3
        Me.RepairConfirmBtn.Text = "結案"
        Me.RepairConfirmBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RepairConfirmBtn.UseVisualStyleBackColor = True
        Me.RepairConfirmBtn.Visible = False
        '
        'ExitBtn
        '
        Me.ExitBtn.AutoSize = True
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.ImageIndex = 4
        Me.ExitBtn.ImageList = Me.ImageList1
        Me.ExitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.RepairResultDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RepairResultDGV.Location = New System.Drawing.Point(0, 444)
        Me.RepairResultDGV.Margin = New System.Windows.Forms.Padding(0)
        Me.RepairResultDGV.Name = "RepairResultDGV"
        Me.RepairResultDGV.RowCount = 1
        Me.RepairResultDGV.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RepairResultDGV.Size = New System.Drawing.Size(873, 70)
        Me.RepairResultDGV.TabIndex = 12
        '
        'FileUploadBtn
        '
        Me.FileUploadBtn.AutoSize = True
        Me.FileUploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileUploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileUploadBtn.ImageIndex = 3
        Me.FileUploadBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(727, 64)
        Me.FlowLayoutPanel3.TabIndex = 17
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.InsertDate, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiptOrderText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactText, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReturnDate, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReturnText, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiptDate, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusText, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(873, 102)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "簽收單號"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(256, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "建檔日期"
        '
        'InsertDate
        '
        Me.InsertDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InsertDate.Location = New System.Drawing.Point(348, 3)
        Me.InsertDate.Name = "InsertDate"
        Me.InsertDate.Size = New System.Drawing.Size(155, 33)
        Me.InsertDate.TabIndex = 1
        '
        'ReceiptOrderText
        '
        Me.ReceiptOrderText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ReceiptOrderText.AutoSize = True
        Me.ReceiptOrderText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ReceiptOrderText.Location = New System.Drawing.Point(95, 7)
        Me.ReceiptOrderText.Name = "ReceiptOrderText"
        Me.ReceiptOrderText.Size = New System.Drawing.Size(0, 24)
        Me.ReceiptOrderText.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(609, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "聯絡人"
        '
        'ContactText
        '
        Me.ContactText.Location = New System.Drawing.Point(701, 3)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.Size = New System.Drawing.Size(155, 33)
        Me.ContactText.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(3, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "交回日期"
        '
        'ReturnDate
        '
        Me.ReturnDate.CustomFormat = " "
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReturnDate.Location = New System.Drawing.Point(95, 42)
        Me.ReturnDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(155, 33)
        Me.ReturnDate.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(256, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 24)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "交回人員"
        '
        'ReturnText
        '
        Me.ReturnText.Location = New System.Drawing.Point(348, 42)
        Me.ReturnText.Name = "ReturnText"
        Me.ReturnText.Size = New System.Drawing.Size(255, 33)
        Me.ReturnText.TabIndex = 27
        '
        'ReceiptDate
        '
        Me.ReceiptDate.CustomFormat = " "
        Me.ReceiptDate.Enabled = False
        Me.ReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceiptDate.Location = New System.Drawing.Point(701, 42)
        Me.ReceiptDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.ReceiptDate.Name = "ReceiptDate"
        Me.ReceiptDate.Size = New System.Drawing.Size(155, 33)
        Me.ReceiptDate.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(609, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 24)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "結案日期"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(3, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 24)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "狀態"
        '
        'StatusText
        '
        Me.StatusText.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.StatusText.AutoSize = True
        Me.StatusText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusText.Location = New System.Drawing.Point(95, 78)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(86, 24)
        Me.StatusText.TabIndex = 23
        Me.StatusText.Text = "尚未建檔"
        '
        'ReceiptComDGV
        '
        Me.ReceiptComDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceiptComDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceiptComDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ReceiptComDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceiptComDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptComID, Me.Item, Me.Count, Me.Unit, Me.Price, Me.TotalAmount, Me.ReceiptRemark})
        Me.ReceiptComDGV.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ReceiptComDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceiptComDGV.Location = New System.Drawing.Point(0, 102)
        Me.ReceiptComDGV.MultiSelect = False
        Me.ReceiptComDGV.Name = "ReceiptComDGV"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.ReceiptComDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ReceiptComDGV.RowTemplate.Height = 24
        Me.ReceiptComDGV.Size = New System.Drawing.Size(873, 342)
        Me.ReceiptComDGV.TabIndex = 13
        '
        'ReceiptComID
        '
        Me.ReceiptComID.HeaderText = "ReceiptKeyID"
        Me.ReceiptComID.Name = "ReceiptComID"
        Me.ReceiptComID.Visible = False
        '
        'Item
        '
        Me.Item.HeaderText = "項目"
        Me.Item.Name = "Item"
        '
        'Count
        '
        Me.Count.HeaderText = "數量"
        Me.Count.Name = "Count"
        '
        'Unit
        '
        Me.Unit.HeaderText = "單位"
        Me.Unit.Name = "Unit"
        '
        'Price
        '
        Me.Price.HeaderText = "單價"
        Me.Price.Name = "Price"
        '
        'TotalAmount
        '
        Me.TotalAmount.HeaderText = "總價"
        Me.TotalAmount.Name = "TotalAmount"
        '
        'ReceiptRemark
        '
        Me.ReceiptRemark.HeaderText = "備註"
        Me.ReceiptRemark.Name = "ReceiptRemark"
        '
        'Set_ReceiptCom_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(873, 556)
        Me.Controls.Add(Me.ReceiptComDGV)
        Me.Controls.Add(Me.RepairResultDGV)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Set_ReceiptCom_Form"
        Me.Text = "五金配件設定"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.RepairResultDGV.ResumeLayout(False)
        Me.RepairResultDGV.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ReceiptComDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintBtn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 複製ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 貼上ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveBtn As Button
    Friend WithEvents RepairConfirmBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents RepairResultDGV As TableLayoutPanel
    Friend WithEvents FileUploadBtn As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InsertDate As DateTimePicker
    Friend WithEvents ReceiptOrderText As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents ReturnText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReceiptDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents ReceiptComDGV As DataGridView
    Friend WithEvents ReceiptComID As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptRemark As DataGridViewTextBoxColumn
End Class
