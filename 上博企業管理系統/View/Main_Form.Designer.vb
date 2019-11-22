<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ConfirmBGW = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ConfirmPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VerText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.UserControl1 = New 上博企業管理系統.UserControl()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MainPanel, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 64)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1139, 700)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "baseline_Down.png")
        Me.ImageList1.Images.SetKeyName(1, "baseline_right.png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ConfirmBGW
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 10000
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.BackgroundImage = Global.上博企業管理系統.My.Resources.Resources.Shangpo_Logo_Final
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainPanel.Controls.Add(Me.Panel3)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.UserControl1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1139, 700)
        Me.MainPanel.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.上博企業管理系統.My.Resources.Resources.您有待審查訊息
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.ConfirmPanel)
        Me.Panel3.Location = New System.Drawing.Point(924, 143)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(212, 300)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'ConfirmPanel
        '
        Me.ConfirmPanel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ConfirmPanel.Location = New System.Drawing.Point(12, 39)
        Me.ConfirmPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ConfirmPanel.Name = "ConfirmPanel"
        Me.ConfirmPanel.Size = New System.Drawing.Size(192, 251)
        Me.ConfirmPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.上博企業管理系統.My.Resources.Resources.登入資訊
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.NameLabel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TimeLabel)
        Me.Panel1.Location = New System.Drawing.Point(924, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 140)
        Me.Panel1.TabIndex = 7
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.BackColor = System.Drawing.Color.Transparent
        Me.NameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NameLabel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.White
        Me.NameLabel.Location = New System.Drawing.Point(8, 45)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(73, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "測試字幕"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.VerText)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(8, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 24)
        Me.Panel2.TabIndex = 1
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VerText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerText.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.VerText.ForeColor = System.Drawing.Color.White
        Me.VerText.Location = New System.Drawing.Point(55, 0)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(62, 20)
        Me.VerText.TabIndex = 1
        Me.VerText.Text = "0.0.000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver.:"
        '
        'TimeLabel
        '
        Me.TimeLabel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLabel.Location = New System.Drawing.Point(8, 68)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(196, 20)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "測試字幕"
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserControl1
        '
        Me.UserControl1.AutoSize = True
        Me.UserControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.UserControl1.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.UserControl1.Location = New System.Drawing.Point(0, 0)
        Me.UserControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.UserControl1.Name = "UserControl1"
        Me.UserControl1.Size = New System.Drawing.Size(222, 700)
        Me.UserControl1.TabIndex = 4
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1139, 764)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "上博企業管理系統"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents NameLabel As Label
    Friend WithEvents VerText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents UserControl1 As UserControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ConfirmPanel As FlowLayoutPanel
    Friend WithEvents ConfirmBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
