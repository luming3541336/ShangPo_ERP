<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Specification_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Specification_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SpecDetailList = New System.Windows.Forms.ListBox()
        Me.SpecList = New System.Windows.Forms.ListBox()
        Me.SupplierList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditSpecDetailBtn = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DelSpecDetailBtn = New System.Windows.Forms.Button()
        Me.AddSpecDetailBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EditSpecBtn = New System.Windows.Forms.Button()
        Me.DelSpecBtn = New System.Windows.Forms.Button()
        Me.AddSpecBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SpecDetailList, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SpecList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SupplierList, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 72)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(841, 279)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SpecDetailList
        '
        Me.SpecDetailList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecDetailList.FormattingEnabled = True
        Me.SpecDetailList.ItemHeight = 24
        Me.SpecDetailList.Location = New System.Drawing.Point(523, 3)
        Me.SpecDetailList.Name = "SpecDetailList"
        Me.SpecDetailList.Size = New System.Drawing.Size(315, 277)
        Me.SpecDetailList.TabIndex = 5
        '
        'SpecList
        '
        Me.SpecList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecList.FormattingEnabled = True
        Me.SpecList.ItemHeight = 24
        Me.SpecList.Location = New System.Drawing.Point(204, 3)
        Me.SpecList.Name = "SpecList"
        Me.SpecList.Size = New System.Drawing.Size(313, 277)
        Me.SpecList.TabIndex = 4
        '
        'SupplierList
        '
        Me.SupplierList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierList.FormattingEnabled = True
        Me.SupplierList.ItemHeight = 24
        Me.SupplierList.Items.AddRange(New Object() {"全部供應商"})
        Me.SupplierList.Location = New System.Drawing.Point(3, 3)
        Me.SupplierList.Name = "SupplierList"
        Me.SupplierList.Size = New System.Drawing.Size(195, 277)
        Me.SupplierList.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.EditSpecDetailBtn, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.DelSpecDetailBtn, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.AddSpecDetailBtn, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(530, 6)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(311, 48)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 48)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "規格名稱"
        '
        'EditSpecDetailBtn
        '
        Me.EditSpecDetailBtn.Enabled = False
        Me.EditSpecDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSpecDetailBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EditSpecDetailBtn.ForeColor = System.Drawing.Color.White
        Me.EditSpecDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditSpecDetailBtn.ImageKey = "pencil-red-icon.png"
        Me.EditSpecDetailBtn.ImageList = Me.ImageList1
        Me.EditSpecDetailBtn.Location = New System.Drawing.Point(169, 6)
        Me.EditSpecDetailBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.EditSpecDetailBtn.Name = "EditSpecDetailBtn"
        Me.EditSpecDetailBtn.Size = New System.Drawing.Size(62, 32)
        Me.EditSpecDetailBtn.TabIndex = 3
        Me.EditSpecDetailBtn.Text = "修改"
        Me.EditSpecDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditSpecDetailBtn.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "delete-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "pencil-red-icon.png")
        '
        'DelSpecDetailBtn
        '
        Me.DelSpecDetailBtn.Enabled = False
        Me.DelSpecDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelSpecDetailBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DelSpecDetailBtn.ForeColor = System.Drawing.Color.White
        Me.DelSpecDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelSpecDetailBtn.ImageIndex = 1
        Me.DelSpecDetailBtn.ImageList = Me.ImageList1
        Me.DelSpecDetailBtn.Location = New System.Drawing.Point(243, 6)
        Me.DelSpecDetailBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.DelSpecDetailBtn.Name = "DelSpecDetailBtn"
        Me.DelSpecDetailBtn.Size = New System.Drawing.Size(62, 32)
        Me.DelSpecDetailBtn.TabIndex = 1
        Me.DelSpecDetailBtn.Text = "刪除"
        Me.DelSpecDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelSpecDetailBtn.UseVisualStyleBackColor = True
        '
        'AddSpecDetailBtn
        '
        Me.AddSpecDetailBtn.AutoSize = True
        Me.AddSpecDetailBtn.Enabled = False
        Me.AddSpecDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSpecDetailBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AddSpecDetailBtn.ForeColor = System.Drawing.Color.White
        Me.AddSpecDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddSpecDetailBtn.ImageIndex = 0
        Me.AddSpecDetailBtn.ImageList = Me.ImageList1
        Me.AddSpecDetailBtn.Location = New System.Drawing.Point(95, 6)
        Me.AddSpecDetailBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.AddSpecDetailBtn.Name = "AddSpecDetailBtn"
        Me.AddSpecDetailBtn.Size = New System.Drawing.Size(62, 32)
        Me.AddSpecDetailBtn.TabIndex = 0
        Me.AddSpecDetailBtn.Text = "新增"
        Me.AddSpecDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddSpecDetailBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EditSpecBtn, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DelSpecBtn, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.AddSpecBtn, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(209, 6)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(309, 48)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "規格種類"
        '
        'EditSpecBtn
        '
        Me.EditSpecBtn.AutoSize = True
        Me.EditSpecBtn.Enabled = False
        Me.EditSpecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSpecBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EditSpecBtn.ForeColor = System.Drawing.Color.White
        Me.EditSpecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditSpecBtn.ImageIndex = 2
        Me.EditSpecBtn.ImageList = Me.ImageList1
        Me.EditSpecBtn.Location = New System.Drawing.Point(167, 6)
        Me.EditSpecBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.EditSpecBtn.Name = "EditSpecBtn"
        Me.EditSpecBtn.Size = New System.Drawing.Size(62, 32)
        Me.EditSpecBtn.TabIndex = 3
        Me.EditSpecBtn.Text = "修改"
        Me.EditSpecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditSpecBtn.UseVisualStyleBackColor = True
        '
        'DelSpecBtn
        '
        Me.DelSpecBtn.Enabled = False
        Me.DelSpecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelSpecBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DelSpecBtn.ForeColor = System.Drawing.Color.White
        Me.DelSpecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelSpecBtn.ImageIndex = 1
        Me.DelSpecBtn.ImageList = Me.ImageList1
        Me.DelSpecBtn.Location = New System.Drawing.Point(241, 6)
        Me.DelSpecBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.DelSpecBtn.Name = "DelSpecBtn"
        Me.DelSpecBtn.Size = New System.Drawing.Size(62, 32)
        Me.DelSpecBtn.TabIndex = 1
        Me.DelSpecBtn.Text = "刪除"
        Me.DelSpecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelSpecBtn.UseVisualStyleBackColor = True
        '
        'AddSpecBtn
        '
        Me.AddSpecBtn.AutoSize = True
        Me.AddSpecBtn.Enabled = False
        Me.AddSpecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSpecBtn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AddSpecBtn.ForeColor = System.Drawing.Color.White
        Me.AddSpecBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddSpecBtn.ImageIndex = 0
        Me.AddSpecBtn.ImageList = Me.ImageList1
        Me.AddSpecBtn.Location = New System.Drawing.Point(93, 6)
        Me.AddSpecBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.AddSpecBtn.Name = "AddSpecBtn"
        Me.AddSpecBtn.Size = New System.Drawing.Size(62, 32)
        Me.AddSpecBtn.TabIndex = 0
        Me.AddSpecBtn.Text = "新增"
        Me.AddSpecBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddSpecBtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(191, 48)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "供應商"
        '
        'LoadBackgroundWorker
        '
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(900, 350)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.SteelBlue
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(847, 60)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'SpecificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(900, 350)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "SpecificationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SpecificationForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SpecDetailList As ListBox
    Friend WithEvents SpecList As ListBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents EditSpecDetailBtn As Button
    Friend WithEvents DelSpecDetailBtn As Button
    Friend WithEvents AddSpecDetailBtn As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents EditSpecBtn As Button
    Friend WithEvents DelSpecBtn As Button
    Friend WithEvents AddSpecBtn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierList As ListBox
    Friend WithEvents LoadBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents ImageList1 As ImageList
End Class
