<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Set_Sale_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Set_Sale_Form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.prodDGV = New System.Windows.Forms.DataGridView()
        Me.purchasePID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salePID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodPIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodRemainAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fitDGV = New System.Windows.Forms.DataGridView()
        Me.purchaseFID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saleFID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Specification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FitCBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitPIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitRemainAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fitRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.purchaseNoText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saleTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.loadBackGround = New System.ComponentModel.BackgroundWorker()
        Me.CurrentCaseLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.prodDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.fitDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.prodDGV)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'prodDGV
        '
        Me.prodDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.prodDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.prodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prodDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.purchasePID, Me.salePID, Me.prodName, Me.prodSupplier, Me.prodClass, Me.prodWidth, Me.prodLength, Me.prodCBM, Me.prodPIC, Me.prodCount, Me.prodRemainAmount, Me.prodRemark})
        resources.ApplyResources(Me.prodDGV, "prodDGV")
        Me.prodDGV.Name = "prodDGV"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.prodDGV.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.prodDGV.RowTemplate.Height = 38
        '
        'purchasePID
        '
        resources.ApplyResources(Me.purchasePID, "purchasePID")
        Me.purchasePID.Name = "purchasePID"
        '
        'salePID
        '
        resources.ApplyResources(Me.salePID, "salePID")
        Me.salePID.Name = "salePID"
        '
        'prodName
        '
        resources.ApplyResources(Me.prodName, "prodName")
        Me.prodName.Name = "prodName"
        Me.prodName.ReadOnly = True
        '
        'prodSupplier
        '
        resources.ApplyResources(Me.prodSupplier, "prodSupplier")
        Me.prodSupplier.Name = "prodSupplier"
        Me.prodSupplier.ReadOnly = True
        '
        'prodClass
        '
        resources.ApplyResources(Me.prodClass, "prodClass")
        Me.prodClass.Name = "prodClass"
        Me.prodClass.ReadOnly = True
        '
        'prodWidth
        '
        resources.ApplyResources(Me.prodWidth, "prodWidth")
        Me.prodWidth.Name = "prodWidth"
        Me.prodWidth.ReadOnly = True
        '
        'prodLength
        '
        resources.ApplyResources(Me.prodLength, "prodLength")
        Me.prodLength.Name = "prodLength"
        Me.prodLength.ReadOnly = True
        '
        'prodCBM
        '
        resources.ApplyResources(Me.prodCBM, "prodCBM")
        Me.prodCBM.Name = "prodCBM"
        Me.prodCBM.ReadOnly = True
        '
        'prodPIC
        '
        resources.ApplyResources(Me.prodPIC, "prodPIC")
        Me.prodPIC.Name = "prodPIC"
        '
        'prodCount
        '
        resources.ApplyResources(Me.prodCount, "prodCount")
        Me.prodCount.Name = "prodCount"
        '
        'prodRemainAmount
        '
        resources.ApplyResources(Me.prodRemainAmount, "prodRemainAmount")
        Me.prodRemainAmount.Name = "prodRemainAmount"
        Me.prodRemainAmount.ReadOnly = True
        '
        'prodRemark
        '
        resources.ApplyResources(Me.prodRemark, "prodRemark")
        Me.prodRemark.Name = "prodRemark"
        Me.prodRemark.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.fitDGV)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'fitDGV
        '
        Me.fitDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.fitDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.fitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fitDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.purchaseFID, Me.saleFID, Me.fitName, Me.fitSupplier, Me.Specification, Me.FitWidth, Me.FitLength, Me.FitCBM, Me.fitPIC, Me.fitCount, Me.fitRemainAmount, Me.fitRemark})
        resources.ApplyResources(Me.fitDGV, "fitDGV")
        Me.fitDGV.Name = "fitDGV"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.fitDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.fitDGV.RowTemplate.Height = 38
        '
        'purchaseFID
        '
        resources.ApplyResources(Me.purchaseFID, "purchaseFID")
        Me.purchaseFID.Name = "purchaseFID"
        '
        'saleFID
        '
        resources.ApplyResources(Me.saleFID, "saleFID")
        Me.saleFID.Name = "saleFID"
        '
        'fitName
        '
        resources.ApplyResources(Me.fitName, "fitName")
        Me.fitName.Name = "fitName"
        Me.fitName.ReadOnly = True
        '
        'fitSupplier
        '
        resources.ApplyResources(Me.fitSupplier, "fitSupplier")
        Me.fitSupplier.Name = "fitSupplier"
        '
        'Specification
        '
        resources.ApplyResources(Me.Specification, "Specification")
        Me.Specification.Name = "Specification"
        '
        'FitWidth
        '
        resources.ApplyResources(Me.FitWidth, "FitWidth")
        Me.FitWidth.Name = "FitWidth"
        '
        'FitLength
        '
        resources.ApplyResources(Me.FitLength, "FitLength")
        Me.FitLength.Name = "FitLength"
        '
        'FitCBM
        '
        resources.ApplyResources(Me.FitCBM, "FitCBM")
        Me.FitCBM.Name = "FitCBM"
        '
        'fitPIC
        '
        resources.ApplyResources(Me.fitPIC, "fitPIC")
        Me.fitPIC.Name = "fitPIC"
        '
        'fitCount
        '
        resources.ApplyResources(Me.fitCount, "fitCount")
        Me.fitCount.Name = "fitCount"
        '
        'fitRemainAmount
        '
        resources.ApplyResources(Me.fitRemainAmount, "fitRemainAmount")
        Me.fitRemainAmount.Name = "fitRemainAmount"
        Me.fitRemainAmount.ReadOnly = True
        '
        'fitRemark
        '
        resources.ApplyResources(Me.fitRemark, "fitRemark")
        Me.fitRemark.Name = "fitRemark"
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.SlateGray
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.purchaseNoText)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.saleTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.CurrentCaseLabel)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'purchaseNoText
        '
        resources.ApplyResources(Me.purchaseNoText, "purchaseNoText")
        Me.purchaseNoText.BackColor = System.Drawing.Color.White
        Me.purchaseNoText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.purchaseNoText.Name = "purchaseNoText"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'saleTime
        '
        resources.ApplyResources(Me.saleTime, "saleTime")
        Me.saleTime.Name = "saleTime"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'FlowLayoutPanel2
        '
        resources.ApplyResources(Me.FlowLayoutPanel2, "FlowLayoutPanel2")
        Me.FlowLayoutPanel2.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel2.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'loadBackGround
        '
        '
        'CurrentCaseLabel
        '
        resources.ApplyResources(Me.CurrentCaseLabel, "CurrentCaseLabel")
        Me.CurrentCaseLabel.BackColor = System.Drawing.Color.White
        Me.CurrentCaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentCaseLabel.Name = "CurrentCaseLabel"
        '
        'Set_Sale_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "Set_Sale_Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.prodDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.fitDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents purchaseNoText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents saleTime As DateTimePicker
    Friend WithEvents fitDGV As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents loadBackGround As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents prodDGV As DataGridView
    Friend WithEvents purchasePID As DataGridViewTextBoxColumn
    Friend WithEvents salePID As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodSupplier As DataGridViewTextBoxColumn
    Friend WithEvents prodClass As DataGridViewTextBoxColumn
    Friend WithEvents prodWidth As DataGridViewTextBoxColumn
    Friend WithEvents prodLength As DataGridViewTextBoxColumn
    Friend WithEvents prodCBM As DataGridViewTextBoxColumn
    Friend WithEvents prodPIC As DataGridViewTextBoxColumn
    Friend WithEvents prodCount As DataGridViewTextBoxColumn
    Friend WithEvents prodRemainAmount As DataGridViewTextBoxColumn
    Friend WithEvents prodRemark As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents purchaseFID As DataGridViewTextBoxColumn
    Friend WithEvents saleFID As DataGridViewTextBoxColumn
    Friend WithEvents fitName As DataGridViewTextBoxColumn
    Friend WithEvents fitSupplier As DataGridViewTextBoxColumn
    Friend WithEvents Specification As DataGridViewTextBoxColumn
    Friend WithEvents FitWidth As DataGridViewTextBoxColumn
    Friend WithEvents FitLength As DataGridViewTextBoxColumn
    Friend WithEvents FitCBM As DataGridViewTextBoxColumn
    Friend WithEvents fitPIC As DataGridViewTextBoxColumn
    Friend WithEvents fitCount As DataGridViewTextBoxColumn
    Friend WithEvents fitRemainAmount As DataGridViewTextBoxColumn
    Friend WithEvents fitRemark As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentCaseLabel As Label
End Class
