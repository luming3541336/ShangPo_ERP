<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Supplier_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Supplier_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LoadDataCustomerWorker = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuNameText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuAbbrText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuNumberText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CpyIDText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContactText = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SearchCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.ContorlLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ReviseBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LoadingPic = New System.Windows.Forms.PictureBox()
        Me.ViewDGV = New System.Windows.Forms.DataGridView()
        Me.SuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuAbbr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CpyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.ContorlLayout.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.LoadingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "add-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "delete-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "pencil-red-icon.png")
        '
        'LoadDataCustomerWorker
        '
        Me.LoadDataCustomerWorker.WorkerReportsProgress = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ContorlLayout, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(962, 492)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SuNameText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.SuAbbrText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.SuNumberText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.CpyIDText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.AddressText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.ContactText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.PhoneText)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 41)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(956, 111)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名稱："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SuNameText
        '
        Me.SuNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SuNameText.Location = New System.Drawing.Point(73, 2)
        Me.SuNameText.Margin = New System.Windows.Forms.Padding(2)
        Me.SuNameText.Name = "SuNameText"
        Me.SuNameText.ReadOnly = True
        Me.SuNameText.Size = New System.Drawing.Size(188, 33)
        Me.SuNameText.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(265, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "簡稱："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SuAbbrText
        '
        Me.SuAbbrText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SuAbbrText.Location = New System.Drawing.Point(336, 2)
        Me.SuAbbrText.Margin = New System.Windows.Forms.Padding(2)
        Me.SuAbbrText.Name = "SuAbbrText"
        Me.SuAbbrText.ReadOnly = True
        Me.SuAbbrText.Size = New System.Drawing.Size(119, 33)
        Me.SuAbbrText.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(459, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "代號："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SuNumberText
        '
        Me.SuNumberText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SuNumberText.Location = New System.Drawing.Point(530, 2)
        Me.SuNumberText.Margin = New System.Windows.Forms.Padding(2)
        Me.SuNumberText.Name = "SuNumberText"
        Me.SuNumberText.ReadOnly = True
        Me.SuNumberText.Size = New System.Drawing.Size(129, 33)
        Me.SuNumberText.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(663, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "統一編號："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CpyIDText
        '
        Me.CpyIDText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CpyIDText.Location = New System.Drawing.Point(772, 2)
        Me.CpyIDText.Margin = New System.Windows.Forms.Padding(2)
        Me.CpyIDText.Name = "CpyIDText"
        Me.CpyIDText.ReadOnly = True
        Me.CpyIDText.Size = New System.Drawing.Size(176, 33)
        Me.CpyIDText.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "地址："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressText
        '
        Me.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressText.Location = New System.Drawing.Point(73, 39)
        Me.AddressText.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.ReadOnly = True
        Me.AddressText.Size = New System.Drawing.Size(586, 33)
        Me.AddressText.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(663, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 24)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "聯絡人："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContactText
        '
        Me.ContactText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContactText.Location = New System.Drawing.Point(753, 39)
        Me.ContactText.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactText.Name = "ContactText"
        Me.ContactText.ReadOnly = True
        Me.ContactText.Size = New System.Drawing.Size(141, 33)
        Me.ContactText.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 80)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "電話："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneText
        '
        Me.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneText.Location = New System.Drawing.Point(73, 76)
        Me.PhoneText.Margin = New System.Windows.Forms.Padding(2)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.ReadOnly = True
        Me.PhoneText.Size = New System.Drawing.Size(176, 33)
        Me.PhoneText.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 448)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(958, 1)
        Me.Panel2.TabIndex = 3
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel3.Controls.Add(Me.SearchCB)
        Me.FlowLayoutPanel3.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel3.Controls.Add(Me.SearchText)
        Me.FlowLayoutPanel3.Controls.Add(Me.SearchBtn)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(2, 450)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(958, 40)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 8)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "查詢類別："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchCB
        '
        Me.SearchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchCB.FormattingEnabled = True
        Me.SearchCB.Items.AddRange(New Object() {"名稱", "代號", "簡稱", "統一編號"})
        Me.SearchCB.Location = New System.Drawing.Point(111, 2)
        Me.SearchCB.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchCB.Name = "SearchCB"
        Me.SearchCB.Size = New System.Drawing.Size(150, 32)
        Me.SearchCB.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(265, 8)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "查詢內容："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchText
        '
        Me.SearchText.Location = New System.Drawing.Point(374, 2)
        Me.SearchText.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchText.Name = "SearchText"
        Me.SearchText.Size = New System.Drawing.Size(252, 33)
        Me.SearchText.TabIndex = 6
        '
        'SearchBtn
        '
        Me.SearchBtn.AutoSize = True
        Me.SearchBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(630, 2)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(60, 36)
        Me.SearchBtn.TabIndex = 7
        Me.SearchBtn.Text = "查詢"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'ContorlLayout
        '
        Me.ContorlLayout.AutoSize = True
        Me.ContorlLayout.Controls.Add(Me.AddBtn)
        Me.ContorlLayout.Controls.Add(Me.ReviseBtn)
        Me.ContorlLayout.Controls.Add(Me.DelBtn)
        Me.ContorlLayout.Controls.Add(Me.OKBtn)
        Me.ContorlLayout.Controls.Add(Me.CancelBtn)
        Me.ContorlLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContorlLayout.Location = New System.Drawing.Point(2, 2)
        Me.ContorlLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.ContorlLayout.Name = "ContorlLayout"
        Me.ContorlLayout.Size = New System.Drawing.Size(958, 34)
        Me.ContorlLayout.TabIndex = 5
        '
        'AddBtn
        '
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddBtn.ImageKey = "add-icon.png"
        Me.AddBtn.ImageList = Me.ImageList1
        Me.AddBtn.Location = New System.Drawing.Point(2, 2)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(84, 30)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "新增"
        Me.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ReviseBtn
        '
        Me.ReviseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReviseBtn.ForeColor = System.Drawing.Color.White
        Me.ReviseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReviseBtn.ImageKey = "pencil-red-icon.png"
        Me.ReviseBtn.ImageList = Me.ImageList1
        Me.ReviseBtn.Location = New System.Drawing.Point(90, 2)
        Me.ReviseBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ReviseBtn.Name = "ReviseBtn"
        Me.ReviseBtn.Size = New System.Drawing.Size(84, 30)
        Me.ReviseBtn.TabIndex = 1
        Me.ReviseBtn.Text = "修改"
        Me.ReviseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReviseBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelBtn.ForeColor = System.Drawing.Color.White
        Me.DelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DelBtn.ImageKey = "delete-icon.png"
        Me.DelBtn.ImageList = Me.ImageList1
        Me.DelBtn.Location = New System.Drawing.Point(178, 2)
        Me.DelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(84, 30)
        Me.DelBtn.TabIndex = 2
        Me.DelBtn.Text = "移除"
        Me.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'OKBtn
        '
        Me.OKBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OKBtn.ForeColor = System.Drawing.Color.White
        Me.OKBtn.Location = New System.Drawing.Point(266, 2)
        Me.OKBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(84, 30)
        Me.OKBtn.TabIndex = 3
        Me.OKBtn.Text = "確認"
        Me.OKBtn.UseVisualStyleBackColor = False
        Me.OKBtn.Visible = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.Location = New System.Drawing.Point(354, 2)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(84, 30)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "取消"
        Me.CancelBtn.UseVisualStyleBackColor = False
        Me.CancelBtn.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LoadingPic)
        Me.Panel4.Controls.Add(Me.ViewDGV)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(2, 161)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(958, 283)
        Me.Panel4.TabIndex = 6
        '
        'LoadingPic
        '
        Me.LoadingPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LoadingPic.Image = Global.上博企業管理系統.My.Resources.Resources.loading
        Me.LoadingPic.Location = New System.Drawing.Point(459, 148)
        Me.LoadingPic.Margin = New System.Windows.Forms.Padding(2)
        Me.LoadingPic.Name = "LoadingPic"
        Me.LoadingPic.Size = New System.Drawing.Size(34, 28)
        Me.LoadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPic.TabIndex = 5
        Me.LoadingPic.TabStop = False
        '
        'ViewDGV
        '
        Me.ViewDGV.AllowUserToAddRows = False
        Me.ViewDGV.AllowUserToDeleteRows = False
        Me.ViewDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ViewDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ViewDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SuID, Me.SuName, Me.SuAbbr, Me.SuNumber, Me.CpyID, Me.Address, Me.Contact, Me.Phone})
        Me.ViewDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewDGV.Location = New System.Drawing.Point(0, 0)
        Me.ViewDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewDGV.Name = "ViewDGV"
        Me.ViewDGV.ReadOnly = True
        Me.ViewDGV.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.ViewDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewDGV.RowTemplate.Height = 24
        Me.ViewDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewDGV.Size = New System.Drawing.Size(958, 283)
        Me.ViewDGV.TabIndex = 3
        '
        'SuID
        '
        Me.SuID.HeaderText = "Column1"
        Me.SuID.Name = "SuID"
        Me.SuID.ReadOnly = True
        Me.SuID.Visible = False
        Me.SuID.Width = 99
        '
        'SuName
        '
        Me.SuName.HeaderText = "名稱"
        Me.SuName.Name = "SuName"
        Me.SuName.ReadOnly = True
        Me.SuName.Width = 73
        '
        'SuAbbr
        '
        Me.SuAbbr.HeaderText = "簡稱"
        Me.SuAbbr.Name = "SuAbbr"
        Me.SuAbbr.ReadOnly = True
        Me.SuAbbr.Width = 73
        '
        'SuNumber
        '
        Me.SuNumber.HeaderText = "代號"
        Me.SuNumber.Name = "SuNumber"
        Me.SuNumber.ReadOnly = True
        Me.SuNumber.Width = 73
        '
        'CpyID
        '
        Me.CpyID.HeaderText = "統一編號"
        Me.CpyID.Name = "CpyID"
        Me.CpyID.ReadOnly = True
        Me.CpyID.Width = 111
        '
        'Address
        '
        Me.Address.HeaderText = "地址"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 73
        '
        'Contact
        '
        Me.Contact.HeaderText = "聯絡人"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        Me.Contact.Width = 92
        '
        'Phone
        '
        Me.Phone.HeaderText = "電話"
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Width = 73
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 157)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(958, 1)
        Me.Panel3.TabIndex = 8
        '
        'Data_Supplier_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(962, 492)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Name = "Data_Supplier_Form"
        Me.Text = "供應商設定"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ContorlLayout.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.LoadingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadDataCustomerWorker As ComponentModel.BackgroundWorker
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SuAbbrText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SuNumberText As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents SearchCB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchText As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents ContorlLayout As FlowLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents ReviseBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LoadingPic As PictureBox
    Friend WithEvents ViewDGV As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SuNameText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CpyIDText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AddressText As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ContactText As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents SuID As DataGridViewTextBoxColumn
    Friend WithEvents SuName As DataGridViewTextBoxColumn
    Friend WithEvents SuAbbr As DataGridViewTextBoxColumn
    Friend WithEvents SuNumber As DataGridViewTextBoxColumn
    Friend WithEvents CpyID As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
End Class
