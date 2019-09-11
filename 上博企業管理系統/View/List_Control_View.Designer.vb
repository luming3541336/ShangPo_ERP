<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class List_Control_View
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_Control_View))
        Me.supplierSetButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.stockButton = New System.Windows.Forms.Button()
        Me.purchaseSaleBtn = New System.Windows.Forms.Button()
        Me.prodSetButton = New System.Windows.Forms.Button()
        Me.SetBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.UserSetBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'supplierSetButton
        '
        Me.supplierSetButton.BackColor = System.Drawing.Color.YellowGreen
        Me.supplierSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supplierSetButton.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplierSetButton.ForeColor = System.Drawing.Color.White
        Me.supplierSetButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.supplierSetButton.ImageIndex = 2
        Me.supplierSetButton.ImageList = Me.ImageList1
        Me.supplierSetButton.Location = New System.Drawing.Point(138, 5)
        Me.supplierSetButton.Margin = New System.Windows.Forms.Padding(1)
        Me.supplierSetButton.Name = "supplierSetButton"
        Me.supplierSetButton.Size = New System.Drawing.Size(138, 102)
        Me.supplierSetButton.TabIndex = 1
        Me.supplierSetButton.Text = "供應商資訊"
        Me.supplierSetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.supplierSetButton.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "進出貨.png")
        Me.ImageList1.Images.SetKeyName(1, "產品資訊.png")
        Me.ImageList1.Images.SetKeyName(2, "供應商資訊.png")
        Me.ImageList1.Images.SetKeyName(3, "規格設定.png")
        Me.ImageList1.Images.SetKeyName(4, "庫存.png")
        Me.ImageList1.Images.SetKeyName(5, "用戶設定.png")
        Me.ImageList1.Images.SetKeyName(6, "報表列印.png")
        '
        'stockButton
        '
        Me.stockButton.BackColor = System.Drawing.Color.MediumOrchid
        Me.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stockButton.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockButton.ForeColor = System.Drawing.Color.White
        Me.stockButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.stockButton.ImageIndex = 4
        Me.stockButton.ImageList = Me.ImageList1
        Me.stockButton.Location = New System.Drawing.Point(554, 5)
        Me.stockButton.Margin = New System.Windows.Forms.Padding(1)
        Me.stockButton.Name = "stockButton"
        Me.stockButton.Size = New System.Drawing.Size(136, 102)
        Me.stockButton.TabIndex = 2
        Me.stockButton.Text = "庫存查詢"
        Me.stockButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.stockButton.UseVisualStyleBackColor = False
        '
        'purchaseSaleBtn
        '
        Me.purchaseSaleBtn.BackColor = System.Drawing.Color.MediumOrchid
        Me.purchaseSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.purchaseSaleBtn.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchaseSaleBtn.ForeColor = System.Drawing.Color.White
        Me.purchaseSaleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.purchaseSaleBtn.ImageIndex = 0
        Me.purchaseSaleBtn.ImageList = Me.ImageList1
        Me.purchaseSaleBtn.Location = New System.Drawing.Point(416, 5)
        Me.purchaseSaleBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.purchaseSaleBtn.Name = "purchaseSaleBtn"
        Me.purchaseSaleBtn.Size = New System.Drawing.Size(136, 102)
        Me.purchaseSaleBtn.TabIndex = 3
        Me.purchaseSaleBtn.Text = "進出貨管理"
        Me.purchaseSaleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.purchaseSaleBtn.UseVisualStyleBackColor = False
        '
        'prodSetButton
        '
        Me.prodSetButton.BackColor = System.Drawing.Color.YellowGreen
        Me.prodSetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prodSetButton.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodSetButton.ForeColor = System.Drawing.Color.White
        Me.prodSetButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.prodSetButton.ImageIndex = 1
        Me.prodSetButton.ImageList = Me.ImageList1
        Me.prodSetButton.Location = New System.Drawing.Point(8, 5)
        Me.prodSetButton.Margin = New System.Windows.Forms.Padding(1)
        Me.prodSetButton.Name = "prodSetButton"
        Me.prodSetButton.Size = New System.Drawing.Size(128, 102)
        Me.prodSetButton.TabIndex = 0
        Me.prodSetButton.Text = "產品資訊"
        Me.prodSetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.prodSetButton.UseVisualStyleBackColor = False
        '
        'SetBtn
        '
        Me.SetBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetBtn.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetBtn.ForeColor = System.Drawing.Color.White
        Me.SetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SetBtn.ImageIndex = 3
        Me.SetBtn.ImageList = Me.ImageList1
        Me.SetBtn.Location = New System.Drawing.Point(278, 5)
        Me.SetBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.SetBtn.Name = "SetBtn"
        Me.SetBtn.Size = New System.Drawing.Size(136, 102)
        Me.SetBtn.TabIndex = 4
        Me.SetBtn.Text = "規格設定"
        Me.SetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SetBtn.UseVisualStyleBackColor = False
        '
        'PrintBtn
        '
        Me.PrintBtn.BackColor = System.Drawing.Color.MediumOrchid
        Me.PrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintBtn.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.White
        Me.PrintBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PrintBtn.ImageIndex = 6
        Me.PrintBtn.ImageList = Me.ImageList1
        Me.PrintBtn.Location = New System.Drawing.Point(692, 5)
        Me.PrintBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(136, 102)
        Me.PrintBtn.TabIndex = 5
        Me.PrintBtn.Text = "報表列印"
        Me.PrintBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PrintBtn.UseVisualStyleBackColor = False
        Me.PrintBtn.Visible = False
        '
        'UserSetBtn
        '
        Me.UserSetBtn.BackColor = System.Drawing.Color.Goldenrod
        Me.UserSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserSetBtn.Font = New System.Drawing.Font("微軟正黑體", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserSetBtn.ForeColor = System.Drawing.Color.White
        Me.UserSetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UserSetBtn.ImageIndex = 5
        Me.UserSetBtn.ImageList = Me.ImageList1
        Me.UserSetBtn.Location = New System.Drawing.Point(830, 5)
        Me.UserSetBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.UserSetBtn.Name = "UserSetBtn"
        Me.UserSetBtn.Size = New System.Drawing.Size(136, 102)
        Me.UserSetBtn.TabIndex = 6
        Me.UserSetBtn.Text = "用戶設定"
        Me.UserSetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UserSetBtn.UseVisualStyleBackColor = False
        '
        'List_Control_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.UserSetBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.SetBtn)
        Me.Controls.Add(Me.purchaseSaleBtn)
        Me.Controls.Add(Me.stockButton)
        Me.Controls.Add(Me.supplierSetButton)
        Me.Controls.Add(Me.prodSetButton)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "List_Control_View"
        Me.Size = New System.Drawing.Size(1064, 162)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prodSetButton As Button
    Friend WithEvents supplierSetButton As Button
    Friend WithEvents stockButton As Button
    Friend WithEvents purchaseSaleBtn As Button
    Friend WithEvents SetBtn As Button
    Friend WithEvents PrintBtn As Button
    Friend WithEvents UserSetBtn As Button
    Friend WithEvents ImageList1 As ImageList
End Class
