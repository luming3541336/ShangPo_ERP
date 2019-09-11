<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Set_Fitting_Form
    Inherits Form

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
        Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Row7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.Row2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierText = New System.Windows.Forms.TextBox()
        Me.Row3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FittingCombo = New System.Windows.Forms.ComboBox()
        Me.AddFittingBtn = New System.Windows.Forms.Button()
        Me.Row4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumberText = New System.Windows.Forms.TextBox()
        Me.Row5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SpecificationText = New System.Windows.Forms.TextBox()
        Me.Row6 = New System.Windows.Forms.TableLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.MainTable.SuspendLayout()
        Me.Row7.SuspendLayout()
        Me.Row2.SuspendLayout()
        Me.Row3.SuspendLayout()
        Me.Row4.SuspendLayout()
        Me.Row5.SuspendLayout()
        Me.Row6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTable
        '
        Me.MainTable.AutoSize = True
        Me.MainTable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MainTable.ColumnCount = 1
        Me.MainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.Controls.Add(Me.Row7, 0, 3)
        Me.MainTable.Controls.Add(Me.Row2, 0, 1)
        Me.MainTable.Controls.Add(Me.Row3, 0, 2)
        Me.MainTable.Controls.Add(Me.Row4, 0, 4)
        Me.MainTable.Controls.Add(Me.Row5, 0, 5)
        Me.MainTable.Controls.Add(Me.Row6, 0, 6)
        Me.MainTable.Controls.Add(Me.Panel1, 0, 0)
        Me.MainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTable.Location = New System.Drawing.Point(2, 2)
        Me.MainTable.Margin = New System.Windows.Forms.Padding(2)
        Me.MainTable.Name = "MainTable"
        Me.MainTable.RowCount = 7
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.MainTable.Size = New System.Drawing.Size(687, 257)
        Me.MainTable.TabIndex = 0
        '
        'Row7
        '
        Me.Row7.AutoSize = True
        Me.Row7.ColumnCount = 2
        Me.Row7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row7.Controls.Add(Me.Label5, 0, 0)
        Me.Row7.Controls.Add(Me.NameText, 1, 0)
        Me.Row7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row7.Location = New System.Drawing.Point(1, 109)
        Me.Row7.Margin = New System.Windows.Forms.Padding(1)
        Me.Row7.Name = "Row7"
        Me.Row7.RowCount = 1
        Me.Row7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row7.Size = New System.Drawing.Size(685, 35)
        Me.Row7.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "配件名稱："
        '
        'NameText
        '
        Me.NameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameText.Location = New System.Drawing.Point(108, 1)
        Me.NameText.Margin = New System.Windows.Forms.Padding(1)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(576, 33)
        Me.NameText.TabIndex = 1
        '
        'Row2
        '
        Me.Row2.AutoSize = True
        Me.Row2.ColumnCount = 2
        Me.Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row2.Controls.Add(Me.Label1, 0, 0)
        Me.Row2.Controls.Add(Me.SupplierText, 1, 0)
        Me.Row2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row2.Location = New System.Drawing.Point(1, 34)
        Me.Row2.Margin = New System.Windows.Forms.Padding(1)
        Me.Row2.Name = "Row2"
        Me.Row2.RowCount = 1
        Me.Row2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row2.Size = New System.Drawing.Size(685, 35)
        Me.Row2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "供應商名稱："
        '
        'SupplierText
        '
        Me.SupplierText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierText.Location = New System.Drawing.Point(127, 1)
        Me.SupplierText.Margin = New System.Windows.Forms.Padding(1)
        Me.SupplierText.Name = "SupplierText"
        Me.SupplierText.ReadOnly = True
        Me.SupplierText.Size = New System.Drawing.Size(557, 33)
        Me.SupplierText.TabIndex = 1
        '
        'Row3
        '
        Me.Row3.AutoSize = True
        Me.Row3.ColumnCount = 3
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row3.Controls.Add(Me.Label2, 0, 0)
        Me.Row3.Controls.Add(Me.FittingCombo, 1, 0)
        Me.Row3.Controls.Add(Me.AddFittingBtn, 2, 0)
        Me.Row3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row3.Location = New System.Drawing.Point(1, 71)
        Me.Row3.Margin = New System.Windows.Forms.Padding(1)
        Me.Row3.Name = "Row3"
        Me.Row3.RowCount = 1
        Me.Row3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.Row3.Size = New System.Drawing.Size(685, 36)
        Me.Row3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "選擇配件："
        '
        'FittingCombo
        '
        Me.FittingCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FittingCombo.FormattingEnabled = True
        Me.FittingCombo.Location = New System.Drawing.Point(108, 1)
        Me.FittingCombo.Margin = New System.Windows.Forms.Padding(1)
        Me.FittingCombo.Name = "FittingCombo"
        Me.FittingCombo.Size = New System.Drawing.Size(535, 32)
        Me.FittingCombo.TabIndex = 1
        '
        'AddFittingBtn
        '
        Me.AddFittingBtn.AutoSize = True
        Me.AddFittingBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AddFittingBtn.ForeColor = System.Drawing.Color.Black
        Me.AddFittingBtn.Location = New System.Drawing.Point(645, 1)
        Me.AddFittingBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.AddFittingBtn.Name = "AddFittingBtn"
        Me.AddFittingBtn.Size = New System.Drawing.Size(39, 34)
        Me.AddFittingBtn.TabIndex = 2
        Me.AddFittingBtn.Text = "＋"
        Me.AddFittingBtn.UseVisualStyleBackColor = False
        '
        'Row4
        '
        Me.Row4.AutoSize = True
        Me.Row4.ColumnCount = 3
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row4.Controls.Add(Me.Label3, 0, 0)
        Me.Row4.Controls.Add(Me.NumberText, 1, 0)
        Me.Row4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row4.Location = New System.Drawing.Point(1, 146)
        Me.Row4.Margin = New System.Windows.Forms.Padding(1)
        Me.Row4.Name = "Row4"
        Me.Row4.RowCount = 1
        Me.Row4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row4.Size = New System.Drawing.Size(685, 35)
        Me.Row4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "識別號："
        '
        'NumberText
        '
        Me.NumberText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumberText.Location = New System.Drawing.Point(89, 1)
        Me.NumberText.Margin = New System.Windows.Forms.Padding(1)
        Me.NumberText.Name = "NumberText"
        Me.NumberText.Size = New System.Drawing.Size(595, 33)
        Me.NumberText.TabIndex = 1
        '
        'Row5
        '
        Me.Row5.AutoSize = True
        Me.Row5.ColumnCount = 2
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row5.Controls.Add(Me.Label4, 0, 0)
        Me.Row5.Controls.Add(Me.SpecificationText, 1, 0)
        Me.Row5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row5.Location = New System.Drawing.Point(1, 183)
        Me.Row5.Margin = New System.Windows.Forms.Padding(1)
        Me.Row5.Name = "Row5"
        Me.Row5.RowCount = 1
        Me.Row5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row5.Size = New System.Drawing.Size(685, 35)
        Me.Row5.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "規格(描述)："
        '
        'SpecificationText
        '
        Me.SpecificationText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecificationText.Location = New System.Drawing.Point(120, 1)
        Me.SpecificationText.Margin = New System.Windows.Forms.Padding(1)
        Me.SpecificationText.Name = "SpecificationText"
        Me.SpecificationText.Size = New System.Drawing.Size(564, 33)
        Me.SpecificationText.TabIndex = 1
        '
        'Row6
        '
        Me.Row6.AutoSize = True
        Me.Row6.ColumnCount = 3
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.Row6.Controls.Add(Me.AddBtn, 0, 0)
        Me.Row6.Controls.Add(Me.CancelBtn, 2, 0)
        Me.Row6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Row6.Location = New System.Drawing.Point(553, 220)
        Me.Row6.Margin = New System.Windows.Forms.Padding(1)
        Me.Row6.Name = "Row6"
        Me.Row6.RowCount = 1
        Me.Row6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row6.Size = New System.Drawing.Size(133, 36)
        Me.Row6.TabIndex = 5
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = True
        Me.AddBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.AddBtn.ForeColor = System.Drawing.Color.Black
        Me.AddBtn.Location = New System.Drawing.Point(1, 1)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(57, 34)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "加入"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.AutoSize = True
        Me.CancelBtn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelBtn.Location = New System.Drawing.Point(73, 1)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(58, 34)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "取消"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 31)
        Me.Panel1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 31)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "新增"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.FlatAppearance.BorderSize = 0
        Me.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Location = New System.Drawing.Point(657, 1)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(1)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(27, 29)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "X"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Set_Fitting_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainTable)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Set_Fitting_Form"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "新增"
        Me.MainTable.ResumeLayout(False)
        Me.MainTable.PerformLayout()
        Me.Row7.ResumeLayout(False)
        Me.Row7.PerformLayout()
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainTable As TableLayoutPanel
    Friend WithEvents Row2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierText As TextBox
    Friend WithEvents Row3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents FittingCombo As ComboBox
    Friend WithEvents AddFittingBtn As Button
    Friend WithEvents Row4 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents NumberText As TextBox
    Friend WithEvents Row5 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents SpecificationText As TextBox
    Friend WithEvents Row6 As TableLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Row7 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents closeButton As Button
End Class
