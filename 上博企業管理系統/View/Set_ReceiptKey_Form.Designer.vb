﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Set_ReceiptKey_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Set_ReceiptKey_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InsertDate = New System.Windows.Forms.DateTimePicker()
        Me.ReceiptOrderText = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlaceText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.ReturnText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReceiptDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.複製ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼上ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RepairConfirmBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.RepairResultDGV = New System.Windows.Forms.TableLayoutPanel()
        Me.FileUploadBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ReceiptKeyDGV = New System.Windows.Forms.DataGridView()
        Me.ReceiptKeyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Room = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.RepairResultDGV.SuspendLayout()
        CType(Me.ReceiptKeyDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.InsertDate, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiptOrderText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusText, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlaceText, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ContactText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReturnDate, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReturnText, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ReceiptDate, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'InsertDate
        '
        Me.InsertDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        resources.ApplyResources(Me.InsertDate, "InsertDate")
        Me.InsertDate.Name = "InsertDate"
        '
        'ReceiptOrderText
        '
        resources.ApplyResources(Me.ReceiptOrderText, "ReceiptOrderText")
        Me.ReceiptOrderText.Name = "ReceiptOrderText"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'StatusText
        '
        resources.ApplyResources(Me.StatusText, "StatusText")
        Me.StatusText.Name = "StatusText"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'PlaceText
        '
        resources.ApplyResources(Me.PlaceText, "PlaceText")
        Me.PlaceText.Name = "PlaceText"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'ContactText
        '
        resources.ApplyResources(Me.ContactText, "ContactText")
        Me.ContactText.Name = "ContactText"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'ReturnDate
        '
        resources.ApplyResources(Me.ReturnDate, "ReturnDate")
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReturnDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.ReturnDate.Name = "ReturnDate"
        '
        'ReturnText
        '
        resources.ApplyResources(Me.ReturnText, "ReturnText")
        Me.ReturnText.Name = "ReturnText"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'ReceiptDate
        '
        resources.ApplyResources(Me.ReceiptDate, "ReceiptDate")
        Me.ReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReceiptDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.ReceiptDate.Name = "ReceiptDate"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'ContextMenuStrip1
        '
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.複製ToolStripMenuItem, Me.貼上ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        '複製ToolStripMenuItem
        '
        Me.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem"
        resources.ApplyResources(Me.複製ToolStripMenuItem, "複製ToolStripMenuItem")
        '
        '貼上ToolStripMenuItem
        '
        resources.ApplyResources(Me.貼上ToolStripMenuItem, "貼上ToolStripMenuItem")
        Me.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem"
        '
        'FlowLayoutPanel2
        '
        resources.ApplyResources(Me.FlowLayoutPanel2, "FlowLayoutPanel2")
        Me.FlowLayoutPanel2.Controls.Add(Me.SaveBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.RepairConfirmBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.PrintBtn)
        Me.FlowLayoutPanel2.Controls.Add(Me.ExitBtn)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        '
        'SaveBtn
        '
        resources.ApplyResources(Me.SaveBtn, "SaveBtn")
        Me.SaveBtn.ImageList = Me.ImageList1
        Me.SaveBtn.Name = "SaveBtn"
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
        resources.ApplyResources(Me.RepairConfirmBtn, "RepairConfirmBtn")
        Me.RepairConfirmBtn.ImageList = Me.ImageList1
        Me.RepairConfirmBtn.Name = "RepairConfirmBtn"
        Me.RepairConfirmBtn.UseVisualStyleBackColor = True
        '
        'PrintBtn
        '
        resources.ApplyResources(Me.PrintBtn, "PrintBtn")
        Me.PrintBtn.ImageList = Me.ImageList1
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        resources.ApplyResources(Me.ExitBtn, "ExitBtn")
        Me.ExitBtn.ImageList = Me.ImageList1
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'RepairResultDGV
        '
        resources.ApplyResources(Me.RepairResultDGV, "RepairResultDGV")
        Me.RepairResultDGV.Controls.Add(Me.FileUploadBtn, 0, 0)
        Me.RepairResultDGV.Controls.Add(Me.FlowLayoutPanel3, 1, 0)
        Me.RepairResultDGV.Name = "RepairResultDGV"
        '
        'FileUploadBtn
        '
        resources.ApplyResources(Me.FileUploadBtn, "FileUploadBtn")
        Me.FileUploadBtn.Name = "FileUploadBtn"
        Me.FileUploadBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel3
        '
        resources.ApplyResources(Me.FlowLayoutPanel3, "FlowLayoutPanel3")
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        '
        'ReceiptKeyDGV
        '
        Me.ReceiptKeyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceiptKeyDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ReceiptKeyDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ReceiptKeyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceiptKeyDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptKeyID, Me.Room, Me.Item, Me.Location, Me.ReceiptCount, Me.ReceiptRemark})
        Me.ReceiptKeyDGV.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.ReceiptKeyDGV, "ReceiptKeyDGV")
        Me.ReceiptKeyDGV.MultiSelect = False
        Me.ReceiptKeyDGV.Name = "ReceiptKeyDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.ReceiptKeyDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ReceiptKeyDGV.RowTemplate.Height = 24
        '
        'ReceiptKeyID
        '
        resources.ApplyResources(Me.ReceiptKeyID, "ReceiptKeyID")
        Me.ReceiptKeyID.Name = "ReceiptKeyID"
        '
        'Room
        '
        resources.ApplyResources(Me.Room, "Room")
        Me.Room.Name = "Room"
        '
        'Item
        '
        resources.ApplyResources(Me.Item, "Item")
        Me.Item.Name = "Item"
        '
        'Location
        '
        resources.ApplyResources(Me.Location, "Location")
        Me.Location.Name = "Location"
        Me.Location.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ReceiptCount
        '
        resources.ApplyResources(Me.ReceiptCount, "ReceiptCount")
        Me.ReceiptCount.Name = "ReceiptCount"
        '
        'ReceiptRemark
        '
        resources.ApplyResources(Me.ReceiptRemark, "ReceiptRemark")
        Me.ReceiptRemark.Name = "ReceiptRemark"
        '
        'Set_ReceiptKey_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.Controls.Add(Me.ReceiptKeyDGV)
        Me.Controls.Add(Me.RepairResultDGV)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Set_ReceiptKey_Form"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.RepairResultDGV.ResumeLayout(False)
        Me.RepairResultDGV.PerformLayout()
        CType(Me.ReceiptKeyDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents ContactText As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents SaveBtn As Button
    Friend WithEvents RepairConfirmBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents RepairResultDGV As TableLayoutPanel
    Friend WithEvents FileUploadBtn As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label16 As Label
    Friend WithEvents StatusText As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents ReturnText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReceiptDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 複製ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 貼上ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReceiptKeyDGV As DataGridView
    Friend WithEvents ReceiptKeyID As DataGridViewTextBoxColumn
    Friend WithEvents Room As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptCount As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptRemark As DataGridViewTextBoxColumn
End Class
