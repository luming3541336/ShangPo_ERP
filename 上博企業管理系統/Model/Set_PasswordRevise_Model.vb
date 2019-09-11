Public Class Set_PasswordRevise_Model
    Protected Const SELECT_PASSWORD_FOR_LOGINID_SQL = "SELECT Password FROM LoginData WHERE LoginID = @id"
    Protected Const UPDATE_PASSWORD_SQL = "UPDATE LoginData SET Password = '@pd' WHERE LoginID = @id"
End Class
