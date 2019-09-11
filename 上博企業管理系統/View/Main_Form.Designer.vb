<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VerText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.recordCheckBox = New System.Windows.Forms.CheckBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.userIDText = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.RevisePasswordLabel = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.loginTableLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MainPanel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1139, 764)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.BackgroundImage = Global.上博企業管理系統.My.Resources.Resources.Shangpo_Logo_Final
        Me.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Controls.Add(Me.loginTableLayout)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(1, 55)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1137, 708)
        Me.MainPanel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.VerText)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(979, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(155, 24)
        Me.Panel2.TabIndex = 1
        '
        'VerText
        '
        Me.VerText.AutoSize = True
        Me.VerText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VerText.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.VerText.ForeColor = System.Drawing.Color.Blue
        Me.VerText.Location = New System.Drawing.Point(52, 0)
        Me.VerText.Name = "VerText"
        Me.VerText.Size = New System.Drawing.Size(62, 20)
        Me.VerText.TabIndex = 1
        Me.VerText.Text = "0.0.000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ver.:"
        '
        'loginTableLayout
        '
        Me.loginTableLayout.ColumnCount = 1
        Me.loginTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.loginTableLayout.Controls.Add(Me.OKButton, 0, 3)
        Me.loginTableLayout.Controls.Add(Me.recordCheckBox, 0, 2)
        Me.loginTableLayout.Controls.Add(Me.passwordText, 0, 1)
        Me.loginTableLayout.Controls.Add(Me.userIDText, 0, 0)
        Me.loginTableLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.loginTableLayout.Location = New System.Drawing.Point(0, 554)
        Me.loginTableLayout.Margin = New System.Windows.Forms.Padding(1)
        Me.loginTableLayout.Name = "loginTableLayout"
        Me.loginTableLayout.RowCount = 4
        Me.loginTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.loginTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.loginTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.loginTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.loginTableLayout.Size = New System.Drawing.Size(1137, 154)
        Me.loginTableLayout.TabIndex = 0
        '
        'OKButton
        '
        Me.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OKButton.AutoSize = True
        Me.OKButton.BackColor = System.Drawing.Color.Silver
        Me.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKButton.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OKButton.ForeColor = System.Drawing.Color.Black
        Me.OKButton.Location = New System.Drawing.Point(447, 113)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(1)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(242, 40)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "登入"
        Me.OKButton.UseVisualStyleBackColor = False
        '
        'recordCheckBox
        '
        Me.recordCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.recordCheckBox.AutoSize = True
        Me.recordCheckBox.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.recordCheckBox.ForeColor = System.Drawing.Color.Black
        Me.recordCheckBox.Location = New System.Drawing.Point(435, 83)
        Me.recordCheckBox.Margin = New System.Windows.Forms.Padding(1)
        Me.recordCheckBox.Name = "recordCheckBox"
        Me.recordCheckBox.Padding = New System.Windows.Forms.Padding(180, 0, 0, 0)
        Me.recordCheckBox.Size = New System.Drawing.Size(266, 28)
        Me.recordCheckBox.TabIndex = 4
        Me.recordCheckBox.Text = "記住我"
        Me.recordCheckBox.UseVisualStyleBackColor = True
        '
        'passwordText
        '
        Me.passwordText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.passwordText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordText.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.passwordText.ForeColor = System.Drawing.Color.Black
        Me.passwordText.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.passwordText.Location = New System.Drawing.Point(446, 42)
        Me.passwordText.Margin = New System.Windows.Forms.Padding(1)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(244, 39)
        Me.passwordText.TabIndex = 3
        '
        'userIDText
        '
        Me.userIDText.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.userIDText.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.userIDText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userIDText.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.userIDText.ForeColor = System.Drawing.Color.Black
        Me.userIDText.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.userIDText.Location = New System.Drawing.Point(446, 1)
        Me.userIDText.Margin = New System.Windows.Forms.Padding(1)
        Me.userIDText.Name = "userIDText"
        Me.userIDText.Size = New System.Drawing.Size(244, 39)
        Me.userIDText.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 50)
        Me.Panel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TimeLabel, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(774, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(361, 50)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.RevisePasswordLabel)
        Me.FlowLayoutPanel1.Controls.Add(Me.NameLabel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(361, 25)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'RevisePasswordLabel
        '
        Me.RevisePasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RevisePasswordLabel.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RevisePasswordLabel.ForeColor = System.Drawing.Color.Blue
        Me.RevisePasswordLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RevisePasswordLabel.ImageIndex = 0
        Me.RevisePasswordLabel.ImageList = Me.ImageList1
        Me.RevisePasswordLabel.Location = New System.Drawing.Point(282, 0)
        Me.RevisePasswordLabel.Name = "RevisePasswordLabel"
        Me.RevisePasswordLabel.Size = New System.Drawing.Size(76, 24)
        Me.RevisePasswordLabel.TabIndex = 1
        Me.RevisePasswordLabel.Text = "變更密碼"
        Me.RevisePasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RevisePasswordLabel.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Set_Image.png")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.Black
        Me.NameLabel.Location = New System.Drawing.Point(277, 0)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(0, 20)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(358, 25)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(0, 20)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1139, 764)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main_Form"
        Me.Text = "上博企業管理系統"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.loginTableLayout.ResumeLayout(False)
        Me.loginTableLayout.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents loginTableLayout As TableLayoutPanel
    Friend WithEvents userIDText As TextBox
    Friend WithEvents passwordText As TextBox
    Friend WithEvents recordCheckBox As CheckBox
    Friend WithEvents OKButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VerText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents RevisePasswordLabel As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TimeLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
