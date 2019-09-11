<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Fit_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MainTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Row6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.Row2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupplierText = New System.Windows.Forms.TextBox()
        Me.Row3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumberText = New System.Windows.Forms.TextBox()
        Me.Row4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SpecificationText = New System.Windows.Forms.TextBox()
        Me.Row5 = New System.Windows.Forms.TableLayoutPanel()
        Me.reviseBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.FittingDataGrid = New System.Windows.Forms.DataGridView()
        Me.FitID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Specification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainTable.SuspendLayout()
        Me.Row6.SuspendLayout()
        Me.Row2.SuspendLayout()
        Me.Row3.SuspendLayout()
        Me.Row4.SuspendLayout()
        Me.Row5.SuspendLayout()
        CType(Me.FittingDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainTable
        '
        Me.MainTable.AutoSize = True
        Me.MainTable.BackColor = System.Drawing.Color.Gray
        Me.MainTable.ColumnCount = 1
        Me.MainTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTable.Controls.Add(Me.Row6, 0, 3)
        Me.MainTable.Controls.Add(Me.Row2, 0, 2)
        Me.MainTable.Controls.Add(Me.Row3, 0, 4)
        Me.MainTable.Controls.Add(Me.Row4, 0, 5)
        Me.MainTable.Controls.Add(Me.Row5, 0, 6)
        Me.MainTable.Controls.Add(Me.FittingDataGrid, 0, 7)
        Me.MainTable.Controls.Add(Me.Button1, 0, 0)
        Me.MainTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTable.Location = New System.Drawing.Point(2, 2)
        Me.MainTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MainTable.Name = "MainTable"
        Me.MainTable.RowCount = 8
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.MainTable.Size = New System.Drawing.Size(602, 366)
        Me.MainTable.TabIndex = 1
        '
        'Row6
        '
        Me.Row6.AutoSize = True
        Me.Row6.ColumnCount = 2
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row6.Controls.Add(Me.Label5, 0, 0)
        Me.Row6.Controls.Add(Me.NameText, 1, 0)
        Me.Row6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row6.Location = New System.Drawing.Point(2, 67)
        Me.Row6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row6.Name = "Row6"
        Me.Row6.RowCount = 1
        Me.Row6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row6.Size = New System.Drawing.Size(598, 30)
        Me.Row6.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "配件名稱："
        '
        'NameText
        '
        Me.NameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameText.Enabled = False
        Me.NameText.Location = New System.Drawing.Point(111, 2)
        Me.NameText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(485, 26)
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
        Me.Row2.Location = New System.Drawing.Point(2, 33)
        Me.Row2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row2.Name = "Row2"
        Me.Row2.RowCount = 1
        Me.Row2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row2.Size = New System.Drawing.Size(598, 30)
        Me.Row2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "供應商名稱："
        '
        'SupplierText
        '
        Me.SupplierText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierText.Location = New System.Drawing.Point(130, 2)
        Me.SupplierText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SupplierText.Name = "SupplierText"
        Me.SupplierText.ReadOnly = True
        Me.SupplierText.Size = New System.Drawing.Size(466, 26)
        Me.SupplierText.TabIndex = 1
        '
        'Row3
        '
        Me.Row3.AutoSize = True
        Me.Row3.ColumnCount = 2
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row3.Controls.Add(Me.Label3, 0, 0)
        Me.Row3.Controls.Add(Me.NumberText, 1, 0)
        Me.Row3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row3.Location = New System.Drawing.Point(2, 101)
        Me.Row3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row3.Name = "Row3"
        Me.Row3.RowCount = 1
        Me.Row3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row3.Size = New System.Drawing.Size(598, 30)
        Me.Row3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "識別號："
        '
        'NumberText
        '
        Me.NumberText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumberText.Enabled = False
        Me.NumberText.Location = New System.Drawing.Point(92, 2)
        Me.NumberText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NumberText.Name = "NumberText"
        Me.NumberText.Size = New System.Drawing.Size(504, 26)
        Me.NumberText.TabIndex = 1
        '
        'Row4
        '
        Me.Row4.AutoSize = True
        Me.Row4.ColumnCount = 2
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row4.Controls.Add(Me.Label4, 0, 0)
        Me.Row4.Controls.Add(Me.SpecificationText, 1, 0)
        Me.Row4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row4.Location = New System.Drawing.Point(2, 135)
        Me.Row4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row4.Name = "Row4"
        Me.Row4.RowCount = 1
        Me.Row4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row4.Size = New System.Drawing.Size(598, 30)
        Me.Row4.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "規格(描述)："
        '
        'SpecificationText
        '
        Me.SpecificationText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpecificationText.Enabled = False
        Me.SpecificationText.Location = New System.Drawing.Point(123, 2)
        Me.SpecificationText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SpecificationText.Name = "SpecificationText"
        Me.SpecificationText.Size = New System.Drawing.Size(473, 26)
        Me.SpecificationText.TabIndex = 1
        '
        'Row5
        '
        Me.Row5.AutoSize = True
        Me.Row5.ColumnCount = 3
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.Row5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row5.Controls.Add(Me.reviseBtn, 0, 0)
        Me.Row5.Controls.Add(Me.AddBtn, 0, 0)
        Me.Row5.Controls.Add(Me.DeleteBtn, 2, 0)
        Me.Row5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Row5.Location = New System.Drawing.Point(414, 169)
        Me.Row5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Row5.Name = "Row5"
        Me.Row5.RowCount = 1
        Me.Row5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Row5.Size = New System.Drawing.Size(186, 38)
        Me.Row5.TabIndex = 5
        '
        'reviseBtn
        '
        Me.reviseBtn.AutoSize = True
        Me.reviseBtn.BackColor = System.Drawing.Color.Gray
        Me.reviseBtn.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviseBtn.ForeColor = System.Drawing.Color.White
        Me.reviseBtn.Location = New System.Drawing.Point(64, 2)
        Me.reviseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.reviseBtn.Name = "reviseBtn"
        Me.reviseBtn.Size = New System.Drawing.Size(58, 34)
        Me.reviseBtn.TabIndex = 2
        Me.reviseBtn.Text = "修正"
        Me.reviseBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.AutoSize = True
        Me.AddBtn.BackColor = System.Drawing.Color.Gray
        Me.AddBtn.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(2, 2)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(58, 34)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "新增"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.AutoSize = True
        Me.DeleteBtn.BackColor = System.Drawing.Color.Gray
        Me.DeleteBtn.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(126, 2)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(58, 34)
        Me.DeleteBtn.TabIndex = 1
        Me.DeleteBtn.Text = "移除"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'FittingDataGrid
        '
        Me.FittingDataGrid.AllowUserToAddRows = False
        Me.FittingDataGrid.AllowUserToDeleteRows = False
        Me.FittingDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FittingDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.FittingDataGrid.BackgroundColor = System.Drawing.Color.Gray
        Me.FittingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FittingDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FitID, Me.FitName, Me.Number, Me.Specification})
        Me.FittingDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FittingDataGrid.Location = New System.Drawing.Point(1, 210)
        Me.FittingDataGrid.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.FittingDataGrid.Name = "FittingDataGrid"
        Me.FittingDataGrid.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.FittingDataGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FittingDataGrid.RowTemplate.Height = 40
        Me.FittingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FittingDataGrid.Size = New System.Drawing.Size(600, 155)
        Me.FittingDataGrid.TabIndex = 7
        '
        'FitID
        '
        Me.FitID.HeaderText = "FitID"
        Me.FitID.Name = "FitID"
        Me.FitID.ReadOnly = True
        Me.FitID.Visible = False
        '
        'FitName
        '
        Me.FitName.HeaderText = "配件名稱"
        Me.FitName.Name = "FitName"
        Me.FitName.ReadOnly = True
        '
        'Number
        '
        Me.Number.HeaderText = "識別號"
        Me.Number.Name = "Number"
        Me.Number.ReadOnly = True
        '
        'Specification
        '
        Me.Specification.HeaderText = "規格"
        Me.Specification.Name = "Specification"
        Me.Specification.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(571, 1)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FittingSetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(606, 370)
        Me.Controls.Add(Me.MainTable)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FittingSetForm"
        Me.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MainTable.ResumeLayout(False)
        Me.MainTable.PerformLayout()
        Me.Row6.ResumeLayout(False)
        Me.Row6.PerformLayout()
        Me.Row2.ResumeLayout(False)
        Me.Row2.PerformLayout()
        Me.Row3.ResumeLayout(False)
        Me.Row3.PerformLayout()
        Me.Row4.ResumeLayout(False)
        Me.Row4.PerformLayout()
        Me.Row5.ResumeLayout(False)
        Me.Row5.PerformLayout()
        CType(Me.FittingDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainTable As TableLayoutPanel
    Friend WithEvents Row6 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents Row2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierText As TextBox
    Friend WithEvents Row3 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents NumberText As TextBox
    Friend WithEvents Row4 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents SpecificationText As TextBox
    Friend WithEvents Row5 As TableLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents FittingDataGrid As DataGridView
    Friend WithEvents FitID As DataGridViewTextBoxColumn
    Friend WithEvents FitName As DataGridViewTextBoxColumn
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents Specification As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents reviseBtn As Button
End Class
