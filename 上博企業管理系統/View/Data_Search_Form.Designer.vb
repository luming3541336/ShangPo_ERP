<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Search_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Search_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CaseNoText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlaceText = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.StartTime = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EndTime = New System.Windows.Forms.DateTimePicker()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StateCombo = New System.Windows.Forms.ComboBox()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SalesTest = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CaseNoText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlaceText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneText, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AddressText, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.StateCombo, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.OKBtn, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.SalesTest, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 303)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "地址："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "電話："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "進貨區間："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CaseNoText
        '
        Me.CaseNoText.Location = New System.Drawing.Point(114, 39)
        Me.CaseNoText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CaseNoText.Name = "CaseNoText"
        Me.CaseNoText.Size = New System.Drawing.Size(255, 33)
        Me.CaseNoText.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "案件編號："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "工地："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlaceText
        '
        Me.PlaceText.Location = New System.Drawing.Point(114, 2)
        Me.PlaceText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlaceText.Name = "PlaceText"
        Me.PlaceText.Size = New System.Drawing.Size(255, 33)
        Me.PlaceText.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.StartTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.EndTime)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(114, 113)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(400, 37)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'StartTime
        '
        Me.StartTime.CustomFormat = " "
        Me.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartTime.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.StartTime.Location = New System.Drawing.Point(2, 2)
        Me.StartTime.Margin = New System.Windows.Forms.Padding(2)
        Me.StartTime.Name = "StartTime"
        Me.StartTime.Size = New System.Drawing.Size(165, 33)
        Me.StartTime.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(171, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "～"
        '
        'EndTime
        '
        Me.EndTime.CustomFormat = "  "
        Me.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTime.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.EndTime.Location = New System.Drawing.Point(204, 2)
        Me.EndTime.Margin = New System.Windows.Forms.Padding(2)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Size = New System.Drawing.Size(165, 33)
        Me.EndTime.TabIndex = 12
        '
        'PhoneText
        '
        Me.PhoneText.Location = New System.Drawing.Point(114, 76)
        Me.PhoneText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(255, 33)
        Me.PhoneText.TabIndex = 10
        '
        'AddressText
        '
        Me.AddressText.Location = New System.Drawing.Point(114, 154)
        Me.AddressText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.Size = New System.Drawing.Size(369, 33)
        Me.AddressText.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "查詢條件："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StateCombo
        '
        Me.StateCombo.Dock = System.Windows.Forms.DockStyle.Left
        Me.StateCombo.FormattingEnabled = True
        Me.StateCombo.Items.AddRange(New Object() {"未結案", "已結案", "作廢"})
        Me.StateCombo.Location = New System.Drawing.Point(114, 229)
        Me.StateCombo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StateCombo.Name = "StateCombo"
        Me.StateCombo.Size = New System.Drawing.Size(255, 32)
        Me.StateCombo.TabIndex = 7
        Me.StateCombo.Text = "未結案"
        '
        'OKBtn
        '
        Me.OKBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKBtn.AutoSize = True
        Me.OKBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OKBtn.ForeColor = System.Drawing.Color.White
        Me.OKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OKBtn.ImageIndex = 0
        Me.OKBtn.Location = New System.Drawing.Point(449, 253)
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(65, 36)
        Me.OKBtn.TabIndex = 8
        Me.OKBtn.Text = "搜尋"
        Me.OKBtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "負責業務："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SalesTest
        '
        Me.SalesTest.Location = New System.Drawing.Point(114, 191)
        Me.SalesTest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalesTest.Name = "SalesTest"
        Me.SalesTest.Size = New System.Drawing.Size(255, 33)
        Me.SalesTest.TabIndex = 14
        '
        'Data_Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(517, 342)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Data_Search_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "搜尋"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PlaceText As TextBox
    Friend WithEvents CaseNoText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents StartTime As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents StateCombo As ComboBox
    Friend WithEvents OKBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents AddressText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SalesTest As TextBox
End Class
