<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Me.UserIDText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.PasswordText = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.RememberCheckBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LoginBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserIDText
        '
        Me.UserIDText.Depth = 0
        Me.UserIDText.Hint = "帳號"
        Me.UserIDText.Location = New System.Drawing.Point(49, 90)
        Me.UserIDText.Margin = New System.Windows.Forms.Padding(2)
        Me.UserIDText.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserIDText.Name = "UserIDText"
        Me.UserIDText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserIDText.SelectedText = ""
        Me.UserIDText.SelectionLength = 0
        Me.UserIDText.SelectionStart = 0
        Me.UserIDText.Size = New System.Drawing.Size(191, 23)
        Me.UserIDText.TabIndex = 1
        Me.UserIDText.UseSystemPasswordChar = False
        '
        'PasswordText
        '
        Me.PasswordText.Depth = 0
        Me.PasswordText.Hint = "密碼"
        Me.PasswordText.Location = New System.Drawing.Point(49, 117)
        Me.PasswordText.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordText.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordText.SelectedText = ""
        Me.PasswordText.SelectionLength = 0
        Me.PasswordText.SelectionStart = 0
        Me.PasswordText.Size = New System.Drawing.Size(191, 23)
        Me.PasswordText.TabIndex = 2
        Me.PasswordText.UseSystemPasswordChar = False
        '
        'RememberCheckBox
        '
        Me.RememberCheckBox.AutoSize = True
        Me.RememberCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.RememberCheckBox.Depth = 0
        Me.RememberCheckBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.RememberCheckBox.Location = New System.Drawing.Point(49, 159)
        Me.RememberCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.RememberCheckBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.RememberCheckBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.RememberCheckBox.Name = "RememberCheckBox"
        Me.RememberCheckBox.Ripple = True
        Me.RememberCheckBox.Size = New System.Drawing.Size(75, 30)
        Me.RememberCheckBox.TabIndex = 3
        Me.RememberCheckBox.Text = "記住我"
        Me.RememberCheckBox.UseVisualStyleBackColor = False
        '
        'LoginBtn
        '
        Me.LoginBtn.BackColor = System.Drawing.Color.Maroon
        Me.LoginBtn.Depth = 0
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Location = New System.Drawing.Point(187, 158)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Primary = True
        Me.LoginBtn.Size = New System.Drawing.Size(53, 28)
        Me.LoginBtn.TabIndex = 4
        Me.LoginBtn.Text = "登入"
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrorLabel.Location = New System.Drawing.Point(55, 142)
        Me.ErrorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(105, 17)
        Me.ErrorLabel.TabIndex = 6
        Me.ErrorLabel.Text = "*帳號或密碼錯誤"
        Me.ErrorLabel.Visible = False
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(291, 209)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.RememberCheckBox)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UserIDText)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "使用者登入"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserIDText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PasswordText As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RememberCheckBox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents LoginBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ErrorLabel As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
