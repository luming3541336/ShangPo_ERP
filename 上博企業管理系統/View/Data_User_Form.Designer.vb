<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_User_Form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_User_Form))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoginDGV = New System.Windows.Forms.DataGridView()
        Me.LoginID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Access = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.L6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ControlTable = New System.Windows.Forms.TableLayoutPanel()
        Me.T1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AccessText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.UserIDText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.T2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.L33 = New System.Windows.Forms.CheckBox()
        Me.L61 = New System.Windows.Forms.CheckBox()
        Me.L51 = New System.Windows.Forms.CheckBox()
        Me.L41 = New System.Windows.Forms.CheckBox()
        Me.L31 = New System.Windows.Forms.CheckBox()
        Me.L21 = New System.Windows.Forms.CheckBox()
        Me.L11 = New System.Windows.Forms.CheckBox()
        Me.L01 = New System.Windows.Forms.CheckBox()
        Me.L62 = New System.Windows.Forms.CheckBox()
        Me.L52 = New System.Windows.Forms.CheckBox()
        Me.L42 = New System.Windows.Forms.CheckBox()
        Me.L32 = New System.Windows.Forms.CheckBox()
        Me.L22 = New System.Windows.Forms.CheckBox()
        Me.L12 = New System.Windows.Forms.CheckBox()
        Me.L02 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.ReviseBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LoginDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ControlTable.SuspendLayout()
        Me.T1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.T2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04538!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.95462!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1250.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(976, 608)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LoginDGV)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(359, 596)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "總覽"
        '
        'LoginDGV
        '
        Me.LoginDGV.AllowUserToAddRows = False
        Me.LoginDGV.AllowUserToDeleteRows = False
        Me.LoginDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LoginDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoginDGV.ColumnHeadersVisible = False
        Me.LoginDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginID, Me.UserName, Me.Access, Me.UserID, Me.Password, Me.L0, Me.L1, Me.L2, Me.L3, Me.L4, Me.L5, Me.L6})
        Me.LoginDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginDGV.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.LoginDGV.Location = New System.Drawing.Point(6, 31)
        Me.LoginDGV.Name = "LoginDGV"
        Me.LoginDGV.ReadOnly = True
        Me.LoginDGV.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.LoginDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LoginDGV.RowTemplate.Height = 24
        Me.LoginDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LoginDGV.Size = New System.Drawing.Size(347, 559)
        Me.LoginDGV.TabIndex = 0
        '
        'LoginID
        '
        Me.LoginID.HeaderText = "Column1"
        Me.LoginID.Name = "LoginID"
        Me.LoginID.ReadOnly = True
        Me.LoginID.Visible = False
        '
        'UserName
        '
        Me.UserName.HeaderText = "用戶名稱"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'Access
        '
        Me.Access.HeaderText = "職稱"
        Me.Access.Name = "Access"
        Me.Access.ReadOnly = True
        '
        'UserID
        '
        Me.UserID.HeaderText = "Column1"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        Me.UserID.Visible = False
        '
        'Password
        '
        Me.Password.HeaderText = "Column1"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Visible = False
        '
        'L0
        '
        Me.L0.HeaderText = "Column1"
        Me.L0.Name = "L0"
        Me.L0.ReadOnly = True
        Me.L0.Visible = False
        '
        'L1
        '
        Me.L1.HeaderText = "Column1"
        Me.L1.Name = "L1"
        Me.L1.ReadOnly = True
        Me.L1.Visible = False
        '
        'L2
        '
        Me.L2.HeaderText = "Column1"
        Me.L2.Name = "L2"
        Me.L2.ReadOnly = True
        Me.L2.Visible = False
        '
        'L3
        '
        Me.L3.HeaderText = "Column1"
        Me.L3.Name = "L3"
        Me.L3.ReadOnly = True
        Me.L3.Visible = False
        '
        'L4
        '
        Me.L4.HeaderText = "Column1"
        Me.L4.Name = "L4"
        Me.L4.ReadOnly = True
        Me.L4.Visible = False
        '
        'L5
        '
        Me.L5.HeaderText = "Column1"
        Me.L5.Name = "L5"
        Me.L5.ReadOnly = True
        Me.L5.Visible = False
        '
        'L6
        '
        Me.L6.HeaderText = "Column1"
        Me.L6.Name = "L6"
        Me.L6.ReadOnly = True
        Me.L6.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ControlTable)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(377, 6)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(593, 596)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "設定"
        '
        'ControlTable
        '
        Me.ControlTable.ColumnCount = 1
        Me.ControlTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ControlTable.Controls.Add(Me.T1, 0, 0)
        Me.ControlTable.Controls.Add(Me.GroupBox3, 0, 1)
        Me.ControlTable.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.ControlTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlTable.Location = New System.Drawing.Point(6, 31)
        Me.ControlTable.Name = "ControlTable"
        Me.ControlTable.RowCount = 3
        Me.ControlTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ControlTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ControlTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ControlTable.Size = New System.Drawing.Size(581, 559)
        Me.ControlTable.TabIndex = 0
        '
        'T1
        '
        Me.T1.AutoSize = True
        Me.T1.ColumnCount = 2
        Me.T1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.T1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.T1.Controls.Add(Me.Label4, 0, 3)
        Me.T1.Controls.Add(Me.Label3, 0, 2)
        Me.T1.Controls.Add(Me.AccessText, 1, 1)
        Me.T1.Controls.Add(Me.Label2, 0, 1)
        Me.T1.Controls.Add(Me.Label1, 0, 0)
        Me.T1.Controls.Add(Me.UserNameText, 1, 0)
        Me.T1.Controls.Add(Me.UserIDText, 1, 2)
        Me.T1.Controls.Add(Me.PasswordText, 1, 3)
        Me.T1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T1.Enabled = False
        Me.T1.Location = New System.Drawing.Point(3, 3)
        Me.T1.Name = "T1"
        Me.T1.RowCount = 4
        Me.T1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T1.Size = New System.Drawing.Size(575, 152)
        Me.T1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "密碼："
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "帳號："
        '
        'AccessText
        '
        Me.AccessText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccessText.Location = New System.Drawing.Point(114, 41)
        Me.AccessText.Name = "AccessText"
        Me.AccessText.Size = New System.Drawing.Size(458, 32)
        Me.AccessText.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "職位："
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用戶名稱："
        '
        'UserNameText
        '
        Me.UserNameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserNameText.Location = New System.Drawing.Point(114, 3)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(458, 32)
        Me.UserNameText.TabIndex = 1
        '
        'UserIDText
        '
        Me.UserIDText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserIDText.Location = New System.Drawing.Point(114, 79)
        Me.UserIDText.Name = "UserIDText"
        Me.UserIDText.Size = New System.Drawing.Size(458, 32)
        Me.UserIDText.TabIndex = 5
        '
        'PasswordText
        '
        Me.PasswordText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordText.Location = New System.Drawing.Point(114, 117)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(458, 32)
        Me.PasswordText.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.T2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(3, 161)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 345)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "權限設定"
        '
        'T2
        '
        Me.T2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.T2.ColumnCount = 4
        Me.T2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.T2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.T2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.T2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.T2.Controls.Add(Me.Label12, 0, 6)
        Me.T2.Controls.Add(Me.Label10, 0, 4)
        Me.T2.Controls.Add(Me.Label9, 0, 3)
        Me.T2.Controls.Add(Me.Label8, 0, 2)
        Me.T2.Controls.Add(Me.Label5, 1, 0)
        Me.T2.Controls.Add(Me.Label7, 0, 1)
        Me.T2.Controls.Add(Me.Label11, 0, 5)
        Me.T2.Controls.Add(Me.Label6, 2, 0)
        Me.T2.Controls.Add(Me.Label14, 3, 0)
        Me.T2.Controls.Add(Me.Label13, 0, 7)
        Me.T2.Controls.Add(Me.L33, 3, 4)
        Me.T2.Controls.Add(Me.L61, 1, 7)
        Me.T2.Controls.Add(Me.L51, 1, 6)
        Me.T2.Controls.Add(Me.L41, 1, 5)
        Me.T2.Controls.Add(Me.L31, 1, 4)
        Me.T2.Controls.Add(Me.L21, 1, 3)
        Me.T2.Controls.Add(Me.L11, 1, 2)
        Me.T2.Controls.Add(Me.L01, 1, 1)
        Me.T2.Controls.Add(Me.L62, 2, 7)
        Me.T2.Controls.Add(Me.L52, 2, 6)
        Me.T2.Controls.Add(Me.L42, 2, 5)
        Me.T2.Controls.Add(Me.L32, 2, 4)
        Me.T2.Controls.Add(Me.L22, 2, 3)
        Me.T2.Controls.Add(Me.L12, 2, 2)
        Me.T2.Controls.Add(Me.L02, 2, 1)
        Me.T2.Dock = System.Windows.Forms.DockStyle.Top
        Me.T2.Enabled = False
        Me.T2.Location = New System.Drawing.Point(3, 28)
        Me.T2.Name = "T2"
        Me.T2.RowCount = 8
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.T2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.T2.Size = New System.Drawing.Size(569, 242)
        Me.T2.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 24)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "報表列印"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 24)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "進出貨管理"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "規格設定"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "供應商資訊"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "讀取"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "產品資訊"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 24)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "庫存查詢"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "修改"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(477, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "管理級"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(70, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 24)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "用戶設定"
        '
        'L33
        '
        Me.L33.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L33.AutoSize = True
        Me.L33.Location = New System.Drawing.Point(503, 100)
        Me.L33.Name = "L33"
        Me.L33.Size = New System.Drawing.Size(15, 14)
        Me.L33.TabIndex = 12
        Me.L33.UseVisualStyleBackColor = True
        '
        'L61
        '
        Me.L61.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L61.AutoSize = True
        Me.L61.Location = New System.Drawing.Point(275, 175)
        Me.L61.Name = "L61"
        Me.L61.Size = New System.Drawing.Size(15, 14)
        Me.L61.TabIndex = 17
        Me.L61.UseVisualStyleBackColor = True
        '
        'L51
        '
        Me.L51.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L51.AutoSize = True
        Me.L51.Location = New System.Drawing.Point(275, 150)
        Me.L51.Name = "L51"
        Me.L51.Size = New System.Drawing.Size(15, 14)
        Me.L51.TabIndex = 15
        Me.L51.UseVisualStyleBackColor = True
        '
        'L41
        '
        Me.L41.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L41.AutoSize = True
        Me.L41.Location = New System.Drawing.Point(275, 125)
        Me.L41.Name = "L41"
        Me.L41.Size = New System.Drawing.Size(15, 14)
        Me.L41.TabIndex = 11
        Me.L41.UseVisualStyleBackColor = True
        '
        'L31
        '
        Me.L31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L31.AutoSize = True
        Me.L31.Location = New System.Drawing.Point(275, 100)
        Me.L31.Name = "L31"
        Me.L31.Size = New System.Drawing.Size(15, 14)
        Me.L31.TabIndex = 8
        Me.L31.UseVisualStyleBackColor = True
        '
        'L21
        '
        Me.L21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L21.AutoSize = True
        Me.L21.Location = New System.Drawing.Point(275, 75)
        Me.L21.Name = "L21"
        Me.L21.Size = New System.Drawing.Size(15, 14)
        Me.L21.TabIndex = 5
        Me.L21.UseVisualStyleBackColor = True
        '
        'L11
        '
        Me.L11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L11.AutoSize = True
        Me.L11.Location = New System.Drawing.Point(275, 50)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(15, 14)
        Me.L11.TabIndex = 3
        Me.L11.UseVisualStyleBackColor = True
        '
        'L01
        '
        Me.L01.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L01.AutoSize = True
        Me.L01.Location = New System.Drawing.Point(275, 25)
        Me.L01.Name = "L01"
        Me.L01.Size = New System.Drawing.Size(15, 14)
        Me.L01.TabIndex = 22
        Me.L01.UseVisualStyleBackColor = True
        '
        'L62
        '
        Me.L62.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L62.AutoSize = True
        Me.L62.Location = New System.Drawing.Point(388, 175)
        Me.L62.Name = "L62"
        Me.L62.Size = New System.Drawing.Size(15, 14)
        Me.L62.TabIndex = 24
        Me.L62.UseVisualStyleBackColor = True
        Me.L62.Visible = False
        '
        'L52
        '
        Me.L52.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L52.AutoSize = True
        Me.L52.Location = New System.Drawing.Point(388, 150)
        Me.L52.Name = "L52"
        Me.L52.Size = New System.Drawing.Size(15, 14)
        Me.L52.TabIndex = 23
        Me.L52.UseVisualStyleBackColor = True
        Me.L52.Visible = False
        '
        'L42
        '
        Me.L42.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L42.AutoSize = True
        Me.L42.Location = New System.Drawing.Point(388, 125)
        Me.L42.Name = "L42"
        Me.L42.Size = New System.Drawing.Size(15, 14)
        Me.L42.TabIndex = 12
        Me.L42.UseVisualStyleBackColor = True
        '
        'L32
        '
        Me.L32.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L32.AutoSize = True
        Me.L32.Location = New System.Drawing.Point(388, 100)
        Me.L32.Name = "L32"
        Me.L32.Size = New System.Drawing.Size(15, 14)
        Me.L32.TabIndex = 9
        Me.L32.UseVisualStyleBackColor = True
        '
        'L22
        '
        Me.L22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L22.AutoSize = True
        Me.L22.Location = New System.Drawing.Point(388, 75)
        Me.L22.Name = "L22"
        Me.L22.Size = New System.Drawing.Size(15, 14)
        Me.L22.TabIndex = 6
        Me.L22.UseVisualStyleBackColor = True
        '
        'L12
        '
        Me.L12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L12.AutoSize = True
        Me.L12.Location = New System.Drawing.Point(388, 50)
        Me.L12.Name = "L12"
        Me.L12.Size = New System.Drawing.Size(15, 14)
        Me.L12.TabIndex = 4
        Me.L12.UseVisualStyleBackColor = True
        '
        'L02
        '
        Me.L02.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.L02.AutoSize = True
        Me.L02.Location = New System.Drawing.Point(388, 25)
        Me.L02.Name = "L02"
        Me.L02.Size = New System.Drawing.Size(15, 14)
        Me.L02.TabIndex = 25
        Me.L02.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.addBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReviseBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.DelBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.OKBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.CancelBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 512)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(575, 44)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'addBtn
        '
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Location = New System.Drawing.Point(3, 3)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(92, 38)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "新增"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'ReviseBtn
        '
        Me.ReviseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReviseBtn.Location = New System.Drawing.Point(101, 3)
        Me.ReviseBtn.Name = "ReviseBtn"
        Me.ReviseBtn.Size = New System.Drawing.Size(92, 38)
        Me.ReviseBtn.TabIndex = 1
        Me.ReviseBtn.Text = "修改"
        Me.ReviseBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelBtn.Location = New System.Drawing.Point(199, 3)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(92, 38)
        Me.DelBtn.TabIndex = 2
        Me.DelBtn.Text = "刪除"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.Location = New System.Drawing.Point(297, 3)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(92, 38)
        Me.OKBtn.TabIndex = 3
        Me.OKBtn.Text = "確認"
        Me.OKBtn.UseVisualStyleBackColor = False
        Me.OKBtn.Visible = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.Location = New System.Drawing.Point(395, 3)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(92, 38)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "取消"
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'Data_User_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(976, 608)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 13.875!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Data_User_Form"
        Me.Text = "用戶設定"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LoginDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ControlTable.ResumeLayout(False)
        Me.ControlTable.PerformLayout()
        Me.T1.ResumeLayout(False)
        Me.T1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.T2.ResumeLayout(False)
        Me.T2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ControlTable As TableLayoutPanel
    Friend WithEvents T1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AccessText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UserNameText As TextBox
    Friend WithEvents UserIDText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents T2 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents L11 As CheckBox
    Friend WithEvents L21 As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents L31 As CheckBox
    Friend WithEvents L41 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents L51 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents L61 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents L01 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents addBtn As Button
    Friend WithEvents ReviseBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents LoginDGV As DataGridView
    Friend WithEvents LoginID As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents Access As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents L0 As DataGridViewTextBoxColumn
    Friend WithEvents L1 As DataGridViewTextBoxColumn
    Friend WithEvents L2 As DataGridViewTextBoxColumn
    Friend WithEvents L3 As DataGridViewTextBoxColumn
    Friend WithEvents L4 As DataGridViewTextBoxColumn
    Friend WithEvents L5 As DataGridViewTextBoxColumn
    Friend WithEvents L6 As DataGridViewTextBoxColumn
    Friend WithEvents L02 As CheckBox
    Friend WithEvents L12 As CheckBox
    Friend WithEvents L22 As CheckBox
    Friend WithEvents L32 As CheckBox
    Friend WithEvents L52 As CheckBox
    Friend WithEvents L62 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents L42 As CheckBox
    Friend WithEvents L33 As CheckBox
End Class
