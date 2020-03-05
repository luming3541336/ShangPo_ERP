Public Class Set_ReceiptCom_Model
    Protected Const SELECT_RECEIPTCOM_SQL = "SELECT * FROM ReceiptCom WHERE ReceiptID = @id"
    Protected Const INSERT_RECEIPTCOM_SQL = "INSERT INTO ReceiptCom(ReceiptID,Item,Count,Unit,Price,TotalAmount,Remark) VALUES(N'@id',N'@item',@count,N'@unit',@price,@totalAmount,N'@remark');SELECT @@IDENTITY as id"
    Protected Const UPDATE_RECEIPTCOM_SQL = "UPDATE ReceiptCom SET Unit = N'@unit' , Item = N'@item' , TotalAmount = @totalAmount , Count = @count,Price = @price, Remark = N'@remark' WHERE ReceiptComID = @id"
    Protected Const DELETE_RECEIPTCOM_SQL = "DELETE FROM ReceiptCom Where ReceiptComID = @id"
End Class
Public Structure ReceiptCom
    Property ReceiptComID As Integer
    Property ReceiptID As Integer
    Property Item As String
    Property Count As Integer
    Property Unit As String
    Property Price As Integer
    Property TotalAmount As Integer
    Property Remark As String
End Structure