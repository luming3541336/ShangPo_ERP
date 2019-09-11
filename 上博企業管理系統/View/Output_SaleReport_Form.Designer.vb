<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output_SaleReport_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Output_SaleReport_Form))
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PrintRecordBackGround = New System.ComponentModel.BackgroundWorker()
        Me.PrintWorkProgressBackGround = New System.ComponentModel.BackgroundWorker()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ForBoss_Checkbox = New System.Windows.Forms.CheckBox()
        Me.UnSale_Checkbox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PICText = New System.Windows.Forms.TextBox()
        Me.PIC_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EndS_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.StartS_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Sale_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EndP_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.StartP_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Purchase_CheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EndP2_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.StartP2_DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Purchase_CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "csv"
        Me.SaveFileDialog.FileName = "統計表"
        Me.SaveFileDialog.Title = "匯出"
        '
        'PrintRecordBackGround
        '
        Me.PrintRecordBackGround.WorkerReportsProgress = True
        '
        'PrintWorkProgressBackGround
        '
        Me.PrintWorkProgressBackGround.WorkerReportsProgress = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1130, 578)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SlateGray
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(8, 62)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1114, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "出貨總表"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ForBoss_Checkbox)
        Me.Panel5.Controls.Add(Me.UnSale_Checkbox)
        Me.Panel5.Location = New System.Drawing.Point(16, 316)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1068, 90)
        Me.Panel5.TabIndex = 4
        '
        'ForBoss_Checkbox
        '
        Me.ForBoss_Checkbox.AutoSize = True
        Me.ForBoss_Checkbox.ForeColor = System.Drawing.Color.White
        Me.ForBoss_Checkbox.Location = New System.Drawing.Point(184, 16)
        Me.ForBoss_Checkbox.Margin = New System.Windows.Forms.Padding(6)
        Me.ForBoss_Checkbox.Name = "ForBoss_Checkbox"
        Me.ForBoss_Checkbox.Size = New System.Drawing.Size(204, 52)
        Me.ForBoss_Checkbox.TabIndex = 1
        Me.ForBoss_Checkbox.Text = "老闆專用"
        Me.ForBoss_Checkbox.UseVisualStyleBackColor = True
        '
        'UnSale_Checkbox
        '
        Me.UnSale_Checkbox.AutoSize = True
        Me.UnSale_Checkbox.ForeColor = System.Drawing.Color.White
        Me.UnSale_Checkbox.Location = New System.Drawing.Point(6, 16)
        Me.UnSale_Checkbox.Margin = New System.Windows.Forms.Padding(6)
        Me.UnSale_Checkbox.Name = "UnSale_Checkbox"
        Me.UnSale_Checkbox.Size = New System.Drawing.Size(166, 52)
        Me.UnSale_Checkbox.TabIndex = 0
        Me.UnSale_Checkbox.Text = "未出貨"
        Me.UnSale_Checkbox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(916, 418)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 62)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "列印"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PICText)
        Me.Panel3.Controls.Add(Me.PIC_CheckBox)
        Me.Panel3.Location = New System.Drawing.Point(16, 214)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1068, 90)
        Me.Panel3.TabIndex = 2
        '
        'PICText
        '
        Me.PICText.Location = New System.Drawing.Point(228, 6)
        Me.PICText.Margin = New System.Windows.Forms.Padding(6)
        Me.PICText.Name = "PICText"
        Me.PICText.Size = New System.Drawing.Size(362, 58)
        Me.PICText.TabIndex = 1
        '
        'PIC_CheckBox
        '
        Me.PIC_CheckBox.AutoSize = True
        Me.PIC_CheckBox.ForeColor = System.Drawing.Color.White
        Me.PIC_CheckBox.Location = New System.Drawing.Point(6, 16)
        Me.PIC_CheckBox.Margin = New System.Windows.Forms.Padding(6)
        Me.PIC_CheckBox.Name = "PIC_CheckBox"
        Me.PIC_CheckBox.Size = New System.Drawing.Size(213, 52)
        Me.PIC_CheckBox.TabIndex = 0
        Me.PIC_CheckBox.Text = "進場人員:"
        Me.PIC_CheckBox.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.EndS_DateTime)
        Me.Panel2.Controls.Add(Me.StartS_DateTime)
        Me.Panel2.Controls.Add(Me.Sale_CheckBox)
        Me.Panel2.Location = New System.Drawing.Point(16, 112)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1068, 90)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(606, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "至"
        '
        'EndS_DateTime
        '
        Me.EndS_DateTime.CustomFormat = "yyyy/MM/dd"
        Me.EndS_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndS_DateTime.Location = New System.Drawing.Point(676, 6)
        Me.EndS_DateTime.Margin = New System.Windows.Forms.Padding(6)
        Me.EndS_DateTime.Name = "EndS_DateTime"
        Me.EndS_DateTime.Size = New System.Drawing.Size(362, 58)
        Me.EndS_DateTime.TabIndex = 2
        '
        'StartS_DateTime
        '
        Me.StartS_DateTime.CustomFormat = "yyyy/MM/dd"
        Me.StartS_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartS_DateTime.Location = New System.Drawing.Point(228, 6)
        Me.StartS_DateTime.Margin = New System.Windows.Forms.Padding(6)
        Me.StartS_DateTime.Name = "StartS_DateTime"
        Me.StartS_DateTime.Size = New System.Drawing.Size(362, 58)
        Me.StartS_DateTime.TabIndex = 1
        '
        'Sale_CheckBox
        '
        Me.Sale_CheckBox.AutoSize = True
        Me.Sale_CheckBox.ForeColor = System.Drawing.Color.White
        Me.Sale_CheckBox.Location = New System.Drawing.Point(6, 16)
        Me.Sale_CheckBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Sale_CheckBox.Name = "Sale_CheckBox"
        Me.Sale_CheckBox.Size = New System.Drawing.Size(204, 52)
        Me.Sale_CheckBox.TabIndex = 0
        Me.Sale_CheckBox.Text = "出庫時間"
        Me.Sale_CheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.EndP_DateTime)
        Me.Panel1.Controls.Add(Me.StartP_DateTime)
        Me.Panel1.Controls.Add(Me.Purchase_CheckBox)
        Me.Panel1.Location = New System.Drawing.Point(16, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 90)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(606, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "至"
        '
        'EndP_DateTime
        '
        Me.EndP_DateTime.CustomFormat = "yyyy/MM/dd"
        Me.EndP_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndP_DateTime.Location = New System.Drawing.Point(676, 6)
        Me.EndP_DateTime.Margin = New System.Windows.Forms.Padding(6)
        Me.EndP_DateTime.Name = "EndP_DateTime"
        Me.EndP_DateTime.Size = New System.Drawing.Size(362, 58)
        Me.EndP_DateTime.TabIndex = 2
        '
        'StartP_DateTime
        '
        Me.StartP_DateTime.CustomFormat = "yyyy/MM/dd"
        Me.StartP_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartP_DateTime.Location = New System.Drawing.Point(228, 6)
        Me.StartP_DateTime.Margin = New System.Windows.Forms.Padding(6)
        Me.StartP_DateTime.Name = "StartP_DateTime"
        Me.StartP_DateTime.Size = New System.Drawing.Size(362, 58)
        Me.StartP_DateTime.TabIndex = 1
        '
        'Purchase_CheckBox
        '
        Me.Purchase_CheckBox.AutoSize = True
        Me.Purchase_CheckBox.ForeColor = System.Drawing.Color.White
        Me.Purchase_CheckBox.Location = New System.Drawing.Point(6, 16)
        Me.Purchase_CheckBox.Margin = New System.Windows.Forms.Padding(6)
        Me.Purchase_CheckBox.Name = "Purchase_CheckBox"
        Me.Purchase_CheckBox.Size = New System.Drawing.Size(204, 52)
        Me.Purchase_CheckBox.TabIndex = 0
        Me.Purchase_CheckBox.Text = "入庫時間"
        Me.Purchase_CheckBox.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SlateGray
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(8, 62)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1114, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "工程進度表"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(922, 320)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 62)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "列印"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.EndP2_DateTime)
        Me.Panel4.Controls.Add(Me.StartP2_DateTime)
        Me.Panel4.Controls.Add(Me.Purchase_CheckBox2)
        Me.Panel4.Location = New System.Drawing.Point(6, 10)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1068, 90)
        Me.Panel4.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(606, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 48)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "至"
        '
        'EndP2_DateTime
        '
        Me.EndP2_DateTime.CustomFormat = "yyyy/MM/dd"
        Me.EndP2_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndP2_DateTime.Location = New System.Drawing.Point(676, 6)
        Me.EndP2_DateTime.Margin = New System.Windows.Forms.Padding(6)
        Me.EndP2_DateTime.Name = "EndP2_DateTime"
        Me.EndP2_DateTime.Size = New System.Drawing.Size(362, 58)
        Me.EndP2_DateTime.TabIndex = 2
        '
        'StartP2_DateTime
        '
        Me.StartP2_DateTime.CustomFormat = "yyyy/MM/dd"
        Me.StartP2_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartP2_DateTime.Location = New System.Drawing.Point(228, 6)
        Me.StartP2_DateTime.Margin = New System.Windows.Forms.Padding(6)
        Me.StartP2_DateTime.Name = "StartP2_DateTime"
        Me.StartP2_DateTime.Size = New System.Drawing.Size(362, 58)
        Me.StartP2_DateTime.TabIndex = 1
        '
        'Purchase_CheckBox2
        '
        Me.Purchase_CheckBox2.AutoSize = True
        Me.Purchase_CheckBox2.ForeColor = System.Drawing.Color.White
        Me.Purchase_CheckBox2.Location = New System.Drawing.Point(6, 16)
        Me.Purchase_CheckBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.Purchase_CheckBox2.Name = "Purchase_CheckBox2"
        Me.Purchase_CheckBox2.Size = New System.Drawing.Size(204, 52)
        Me.Purchase_CheckBox2.TabIndex = 0
        Me.Purchase_CheckBox2.Text = "入庫時間"
        Me.Purchase_CheckBox2.UseVisualStyleBackColor = True
        '
        'Output_SaleReport_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1130, 578)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Output_SaleReport_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "列印"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents PrintRecordBackGround As System.ComponentModel.BackgroundWorker
    Friend WithEvents PrintWorkProgressBackGround As System.ComponentModel.BackgroundWorker
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PIC_CheckBox As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents EndS_DateTime As DateTimePicker
    Friend WithEvents StartS_DateTime As DateTimePicker
    Friend WithEvents Sale_CheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents EndP_DateTime As DateTimePicker
    Friend WithEvents StartP_DateTime As DateTimePicker
    Friend WithEvents Purchase_CheckBox As CheckBox
    Friend WithEvents PICText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents EndP2_DateTime As DateTimePicker
    Friend WithEvents StartP2_DateTime As DateTimePicker
    Friend WithEvents Purchase_CheckBox2 As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UnSale_Checkbox As CheckBox
    Friend WithEvents ForBoss_Checkbox As CheckBox
End Class
