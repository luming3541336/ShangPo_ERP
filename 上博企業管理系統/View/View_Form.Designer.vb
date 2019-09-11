<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Form))
        Me.mainTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'mainTableLayout
        '
        Me.mainTableLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mainTableLayout.ColumnCount = 1
        Me.mainTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.mainTableLayout.Name = "mainTableLayout"
        Me.mainTableLayout.RowCount = 1
        Me.mainTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364.0!))
        Me.mainTableLayout.Size = New System.Drawing.Size(685, 364)
        Me.mainTableLayout.TabIndex = 0
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(685, 364)
        Me.Controls.Add(Me.mainTableLayout)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ViewForm"
        Me.Text = "ViewForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTableLayout As TableLayoutPanel
End Class
