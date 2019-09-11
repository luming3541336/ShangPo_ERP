<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSupplier
    Inherits Form

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
        Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Row1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.Row2 = New System.Windows.Forms.TableLayoutPanel()
        Me.NumberText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Row3 = New System.Windows.Forms.TableLayoutPanel()
        Me.IDText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Row4 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Row5 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Row6 = New System.Windows.Forms.TableLayoutPanel()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.MainTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Row1.SuspendLayout()
        Me.Row2.SuspendLayout()
        Me.Row3.SuspendLayout()
        Me.Row4.SuspendLayout()
        Me.Row5.SuspendLayout()
        Me.Row6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTable
        '
        Me.MainTable.AutoSize = True
        Me.MainTable.BackColor = System.Drawing.Color.Gray
        Me.MainTable.ColumnCount = 1
        Me.MainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.Controls.Add(Me.Panel1, 0, 0)
        Me.MainTable.Controls.Add(Me.Row1, 0, 1)
        Me.MainTable.Controls.Add(Me.Row2, 0, 2)
        Me.MainTable.Controls.Add(Me.Row3, 0, 3)
        Me.MainTable.Controls.Add(Me.Row4, 0, 4)
        Me.MainTable.Controls.Add(Me.Row5, 0, 5)
        Me.MainTable.Controls.Add(Me.Row6, 0, 6)
        Me.MainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTable.Location = New System.Drawing.Point(4, 4)
        Me.MainTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MainTable.Name = "MainTable"
        Me.MainTable.RowCount = 7
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.Size = New System.Drawing.Size(1266, 446)
        Me.MainTable.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 100)
        Me.Panel1.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 48)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "新增"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.FlatAppearance.BorderSize = 0
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(1214, 0)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(88, 98)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "X"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Row1
        '
        Me.Row1.AutoSize = True
        Me.Row1.ColumnCount = 2
        Me.Row1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row1.Controls.Add(Me.Label1, 0, 0)
        Me.Row1.Controls.Add(Me.NameText, 1, 0)
        Me.Row1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row1.Location = New System.Drawing.Point(4, 108)
        Me.Row1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Row1.Name = "Row1"
        Me.Row1.RowCount = 1
        Me.Row1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row1.Size = New System.Drawing.Size(1258, 48)
        Me.Row1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "供應商名稱："
        '
        'NameText
        '
        Me.NameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameText.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameText.Location = New System.Drawing.Point(258, 2)
        Me.NameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(998, 44)
        Me.NameText.TabIndex = 1
        '
        'Row2
        '
        Me.Row2.AutoSize = True
        Me.Row2.ColumnCount = 2
        Me.Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row2.Controls.Add(Me.NumberText, 0, 0)
        Me.Row2.Controls.Add(Me.Label2, 0, 0)
        Me.Row2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row2.Location = New System.Drawing.Point(2, 162)
        Me.Row2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row2.Name = "Row2"
        Me.Row2.RowCount = 1
        Me.Row2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row2.Size = New System.Drawing.Size(1262, 62)
        Me.Row2.TabIndex = 1
        '
        'NumberText
        '
        Me.NumberText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumberText.Location = New System.Drawing.Point(258, 2)
        Me.NumberText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumberText.Name = "NumberText"
        Me.NumberText.Size = New System.Drawing.Size(1002, 58)
        Me.NumberText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "供應商代號："
        '
        'Row3
        '
        Me.Row3.AutoSize = True
        Me.Row3.ColumnCount = 2
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row3.Controls.Add(Me.IDText, 0, 0)
        Me.Row3.Controls.Add(Me.Label3, 0, 0)
        Me.Row3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row3.Location = New System.Drawing.Point(2, 228)
        Me.Row3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row3.Name = "Row3"
        Me.Row3.RowCount = 1
        Me.Row3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row3.Size = New System.Drawing.Size(1262, 62)
        Me.Row3.TabIndex = 2
        '
        'IDText
        '
        Me.IDText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IDText.Location = New System.Drawing.Point(220, 2)
        Me.IDText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IDText.Name = "IDText"
        Me.IDText.Size = New System.Drawing.Size(1040, 58)
        Me.IDText.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 48)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "統一編號："
        '
        'Row4
        '
        Me.Row4.AutoSize = True
        Me.Row4.ColumnCount = 2
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row4.Controls.Add(Me.AddressText, 0, 0)
        Me.Row4.Controls.Add(Me.Label4, 0, 0)
        Me.Row4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row4.Location = New System.Drawing.Point(2, 294)
        Me.Row4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row4.Name = "Row4"
        Me.Row4.RowCount = 1
        Me.Row4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row4.Size = New System.Drawing.Size(1262, 62)
        Me.Row4.TabIndex = 3
        '
        'AddressText
        '
        Me.AddressText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddressText.Location = New System.Drawing.Point(144, 2)
        Me.AddressText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.Size = New System.Drawing.Size(1116, 58)
        Me.AddressText.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "地址："
        '
        'Row5
        '
        Me.Row5.AutoSize = True
        Me.Row5.ColumnCount = 4
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.Row5.Controls.Add(Me.ContactText, 0, 0)
        Me.Row5.Controls.Add(Me.Label5, 0, 0)
        Me.Row5.Controls.Add(Me.PhoneText, 3, 0)
        Me.Row5.Controls.Add(Me.Label6, 2, 0)
        Me.Row5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row5.Location = New System.Drawing.Point(2, 360)
        Me.Row5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row5.Name = "Row5"
        Me.Row5.RowCount = 1
        Me.Row5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row5.Size = New System.Drawing.Size(1262, 62)
        Me.Row5.TabIndex = 4
        '
        'ContactText
        '
        Me.ContactText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContactText.Location = New System.Drawing.Point(182, 2)
        Me.ContactText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.Size = New System.Drawing.Size(341, 58)
        Me.ContactText.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 48)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "聯絡人："
        '
        'PhoneText
        '
        Me.PhoneText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhoneText.Location = New System.Drawing.Point(745, 2)
        Me.PhoneText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(515, 58)
        Me.PhoneText.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(529, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 48)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "聯絡電話："
        '
        'Row6
        '
        Me.Row6.AutoSize = True
        Me.Row6.ColumnCount = 4
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Row6.Controls.Add(Me.CancelBtn, 2, 0)
        Me.Row6.Controls.Add(Me.OKBtn, 0, 0)
        Me.Row6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Row6.Location = New System.Drawing.Point(904, 426)
        Me.Row6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row6.Name = "Row6"
        Me.Row6.RowCount = 1
        Me.Row6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row6.Size = New System.Drawing.Size(360, 18)
        Me.Row6.TabIndex = 5
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = True
        Me.CancelBtn.BackColor = System.Drawing.Color.Gray
        Me.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(182, 2)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(140, 14)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "移除"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'OKBtn
        '
        Me.OKBtn.AutoSize = True
        Me.OKBtn.BackColor = System.Drawing.Color.Gray
        Me.OKBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.ForeColor = System.Drawing.Color.White
        Me.OKBtn.Location = New System.Drawing.Point(2, 2)
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(140, 14)
        Me.OKBtn.TabIndex = 0
        Me.OKBtn.Text = "新增"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'AddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1274, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainTable)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddSupplier"
        Me.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "新增供應商"
        Me.MainTable.ResumeLayout(False)
        Me.MainTable.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Row1.ResumeLayout(False)
        Me.Row1.PerformLayout()
        Me.Row2.ResumeLayout(False)
        Me.Row2.PerformLayout()
        Me.Row3.ResumeLayout(False)
        Me.Row3.PerformLayout()
        Me.Row4.ResumeLayout(False)
        Me.Row4.PerformLayout()
        Me.Row5.ResumeLayout(False)
        Me.Row5.PerformLayout()
        Me.Row6.ResumeLayout(False)
        Me.Row6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainTable As TableLayoutPanel
    Friend WithEvents Row1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents Row2 As TableLayoutPanel
    Friend WithEvents NumberText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Row3 As TableLayoutPanel
    Friend WithEvents IDText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Row4 As TableLayoutPanel
    Friend WithEvents AddressText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Row5 As TableLayoutPanel
    Friend WithEvents ContactText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Row6 As TableLayoutPanel
    Friend WithEvents CancelBtn As Button
    Friend WithEvents OKBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents closeButton As Button
End Class
