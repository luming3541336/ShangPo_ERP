<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StockViewBtn = New System.Windows.Forms.Button()
        Me.CaseSearchBtn = New System.Windows.Forms.Button()
        Me.CasrViewBtn = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ClassBtn = New System.Windows.Forms.Button()
        Me.ProdPartBtn = New System.Windows.Forms.Button()
        Me.RevisePWBtn = New System.Windows.Forms.Button()
        Me.UserSetBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(222, 897)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.ImageIndex = 1
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "估價系統"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "baseline_Down.png")
        Me.ImageList1.Images.SetKeyName(1, "baseline_right.png")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 91)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 29)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(222, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "新增估價"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "估價總覽"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 60)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(222, 31)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "列印報價單"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.ImageKey = "baseline_right.png"
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(0, 122)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(222, 31)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "進出貨管理系統"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StockViewBtn)
        Me.Panel2.Controls.Add(Me.CaseSearchBtn)
        Me.Panel2.Controls.Add(Me.CasrViewBtn)
        Me.Panel2.Location = New System.Drawing.Point(0, 153)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(222, 93)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'StockViewBtn
        '
        Me.StockViewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.StockViewBtn.FlatAppearance.BorderSize = 0
        Me.StockViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StockViewBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StockViewBtn.ForeColor = System.Drawing.Color.White
        Me.StockViewBtn.Location = New System.Drawing.Point(0, 62)
        Me.StockViewBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.StockViewBtn.Name = "StockViewBtn"
        Me.StockViewBtn.Size = New System.Drawing.Size(222, 31)
        Me.StockViewBtn.TabIndex = 2
        Me.StockViewBtn.Text = "庫存紀錄"
        Me.StockViewBtn.UseVisualStyleBackColor = False
        '
        'CaseSearchBtn
        '
        Me.CaseSearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.CaseSearchBtn.FlatAppearance.BorderSize = 0
        Me.CaseSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CaseSearchBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CaseSearchBtn.ForeColor = System.Drawing.Color.White
        Me.CaseSearchBtn.Location = New System.Drawing.Point(0, 31)
        Me.CaseSearchBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CaseSearchBtn.Name = "CaseSearchBtn"
        Me.CaseSearchBtn.Size = New System.Drawing.Size(222, 31)
        Me.CaseSearchBtn.TabIndex = 2
        Me.CaseSearchBtn.Text = "案件查詢"
        Me.CaseSearchBtn.UseVisualStyleBackColor = False
        '
        'CasrViewBtn
        '
        Me.CasrViewBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.CasrViewBtn.FlatAppearance.BorderSize = 0
        Me.CasrViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CasrViewBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CasrViewBtn.ForeColor = System.Drawing.Color.White
        Me.CasrViewBtn.Location = New System.Drawing.Point(0, 0)
        Me.CasrViewBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.CasrViewBtn.Name = "CasrViewBtn"
        Me.CasrViewBtn.Size = New System.Drawing.Size(222, 31)
        Me.CasrViewBtn.TabIndex = 1
        Me.CasrViewBtn.Text = "案件總覽"
        Me.CasrViewBtn.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.ImageIndex = 1
        Me.Button8.ImageList = Me.ImageList1
        Me.Button8.Location = New System.Drawing.Point(0, 246)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(222, 31)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "財務管理"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Location = New System.Drawing.Point(0, 277)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(222, 61)
        Me.Panel3.TabIndex = 3
        Me.Panel3.Visible = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(0, 30)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(222, 31)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "應收帳款"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(0, 0)
        Me.Button10.Margin = New System.Windows.Forms.Padding(0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(222, 31)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "應收應付總覽"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.ImageIndex = 1
        Me.Button11.ImageList = Me.ImageList1
        Me.Button11.Location = New System.Drawing.Point(0, 338)
        Me.Button11.Margin = New System.Windows.Forms.Padding(0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(222, 31)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "設定"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.ClassBtn)
        Me.Panel4.Controls.Add(Me.ProdPartBtn)
        Me.Panel4.Controls.Add(Me.RevisePWBtn)
        Me.Panel4.Controls.Add(Me.UserSetBtn)
        Me.Panel4.Location = New System.Drawing.Point(0, 369)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(222, 157)
        Me.Panel4.TabIndex = 4
        Me.Panel4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 31)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(222, 31)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "產品設定"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ClassBtn
        '
        Me.ClassBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClassBtn.FlatAppearance.BorderSize = 0
        Me.ClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClassBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ClassBtn.ForeColor = System.Drawing.Color.White
        Me.ClassBtn.Location = New System.Drawing.Point(0, 93)
        Me.ClassBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ClassBtn.Name = "ClassBtn"
        Me.ClassBtn.Size = New System.Drawing.Size(222, 31)
        Me.ClassBtn.TabIndex = 2
        Me.ClassBtn.Text = "類別設定"
        Me.ClassBtn.UseVisualStyleBackColor = False
        '
        'ProdPartBtn
        '
        Me.ProdPartBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ProdPartBtn.FlatAppearance.BorderSize = 0
        Me.ProdPartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProdPartBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ProdPartBtn.ForeColor = System.Drawing.Color.White
        Me.ProdPartBtn.Location = New System.Drawing.Point(0, 62)
        Me.ProdPartBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ProdPartBtn.Name = "ProdPartBtn"
        Me.ProdPartBtn.Size = New System.Drawing.Size(222, 31)
        Me.ProdPartBtn.TabIndex = 2
        Me.ProdPartBtn.Text = "組件設定"
        Me.ProdPartBtn.UseVisualStyleBackColor = False
        '
        'RevisePWBtn
        '
        Me.RevisePWBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.RevisePWBtn.FlatAppearance.BorderSize = 0
        Me.RevisePWBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RevisePWBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RevisePWBtn.ForeColor = System.Drawing.Color.White
        Me.RevisePWBtn.Location = New System.Drawing.Point(0, 124)
        Me.RevisePWBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.RevisePWBtn.Name = "RevisePWBtn"
        Me.RevisePWBtn.Size = New System.Drawing.Size(222, 31)
        Me.RevisePWBtn.TabIndex = 2
        Me.RevisePWBtn.Text = "修改密碼"
        Me.RevisePWBtn.UseVisualStyleBackColor = False
        '
        'UserSetBtn
        '
        Me.UserSetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.UserSetBtn.FlatAppearance.BorderSize = 0
        Me.UserSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserSetBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.UserSetBtn.ForeColor = System.Drawing.Color.White
        Me.UserSetBtn.Location = New System.Drawing.Point(0, 0)
        Me.UserSetBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.UserSetBtn.Name = "UserSetBtn"
        Me.UserSetBtn.Size = New System.Drawing.Size(222, 31)
        Me.UserSetBtn.TabIndex = 1
        Me.UserSetBtn.Text = "帳戶設定"
        Me.UserSetBtn.UseVisualStyleBackColor = False
        '
        'UserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Name = "UserControl"
        Me.Size = New System.Drawing.Size(222, 897)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CaseSearchBtn As Button
    Friend WithEvents CasrViewBtn As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RevisePWBtn As Button
    Friend WithEvents UserSetBtn As Button
    Friend WithEvents StockViewBtn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Button5 As Button
    Friend WithEvents ProdPartBtn As Button
    Friend WithEvents ClassBtn As Button
End Class
