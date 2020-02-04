<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Product_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Product_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProdNameText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SearchCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchText = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.ControlLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ReviseBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LoadingPic = New System.Windows.Forms.PictureBox()
        Me.ViewDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.ControlLayout.SuspendLayout()
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ControlLayout, 0, 0)
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(843, 648)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ProdNameText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.ComboBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox7)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 41)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(837, 76)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "產品名稱："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdNameText
        '
        Me.ProdNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdNameText.Location = New System.Drawing.Point(111, 2)
        Me.ProdNameText.Margin = New System.Windows.Forms.Padding(2)
        Me.ProdNameText.Name = "ProdNameText"
        Me.ProdNameText.ReadOnly = True
        Me.ProdNameText.Size = New System.Drawing.Size(170, 33)
        Me.ProdNameText.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(285, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "供應商："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(376, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 32)
        Me.ComboBox2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(552, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "產品編號："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(661, 2)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(170, 33)
        Me.TextBox5.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(2, 45)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 24)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "計算單位："
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"才", "樘"})
        Me.ComboBox1.Location = New System.Drawing.Point(112, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(61, 32)
        Me.ComboBox1.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(178, 45)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "單價："
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(249, 40)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(153, 33)
        Me.TextBox7.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 602)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(839, 1)
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
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(2, 604)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(839, 42)
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
        Me.SearchCB.Items.AddRange(New Object() {"產品名稱", "產品簡稱"})
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
        Me.SearchBtn.Size = New System.Drawing.Size(70, 36)
        Me.SearchBtn.TabIndex = 7
        Me.SearchBtn.Text = "查詢"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'ControlLayout
        '
        Me.ControlLayout.AutoSize = True
        Me.ControlLayout.Controls.Add(Me.AddBtn)
        Me.ControlLayout.Controls.Add(Me.ReviseBtn)
        Me.ControlLayout.Controls.Add(Me.DelBtn)
        Me.ControlLayout.Controls.Add(Me.OKBtn)
        Me.ControlLayout.Controls.Add(Me.CancelBtn)
        Me.ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ControlLayout.Location = New System.Drawing.Point(2, 2)
        Me.ControlLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.ControlLayout.Name = "ControlLayout"
        Me.ControlLayout.Size = New System.Drawing.Size(839, 34)
        Me.ControlLayout.TabIndex = 5
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
        Me.Panel4.Location = New System.Drawing.Point(2, 126)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(839, 472)
        Me.Panel4.TabIndex = 6
        '
        'LoadingPic
        '
        Me.LoadingPic.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LoadingPic.Image = Global.上博企業管理系統.My.Resources.Resources.loading
        Me.LoadingPic.Location = New System.Drawing.Point(391, 216)
        Me.LoadingPic.Margin = New System.Windows.Forms.Padding(2)
        Me.LoadingPic.Name = "LoadingPic"
        Me.LoadingPic.Size = New System.Drawing.Size(68, 36)
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
        Me.ViewDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
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
        Me.ViewDGV.Size = New System.Drawing.Size(839, 472)
        Me.ViewDGV.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "產品名稱"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 111
        '
        'Column2
        '
        Me.Column2.HeaderText = "供應商"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 92
        '
        'Column3
        '
        Me.Column3.HeaderText = "產品代號"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 111
        '
        'Column4
        '
        Me.Column4.HeaderText = "計算單位"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 111
        '
        'Column5
        '
        Me.Column5.HeaderText = "單價"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 73
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(2, 122)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(839, 1)
        Me.Panel3.TabIndex = 8
        '
        'Data_Product_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(843, 648)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("微軟正黑體", 14.25!)
        Me.Name = "Data_Product_Form"
        Me.Text = "產品設定"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ControlLayout.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.LoadingPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents ProdNameText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents SearchCB As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchText As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents ControlLayout As FlowLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents ReviseBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LoadingPic As PictureBox
    Friend WithEvents ViewDGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
End Class
