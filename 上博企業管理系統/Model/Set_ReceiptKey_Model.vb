Public Class Set_ReceiptKey_Model
    Protected Const SELECT_RECEIPTDATA_SQL = "SELECT * FROM ReceiptData WHERE ReceiptID = @id"
    Protected Const UPDATE_RECEIPTDATA_SQL = "UPDATE ReceiptData SET ReceiptOrder = @order, ReceiptType = @type, ReceiptDate = @date, InsertDate = @insertDate, Status = @status WHERE ReceiptID = @id"
    Protected Const INSERT_RECEIPTDATA_SQL = "INSERT INTO ReceiptData(ReceiptOrder,ReceiptType,ReceiptDate,InsertDate,Status) VALUES(N'@order',@type,N'@date',N'@insertDate',@status);SELECT @@IDENTITY as id"

    Protected Const SELECT_RECEIPTKEY_SQL = "SELECT * FROM ReceiptKey WHERE ReceiptKeyID = @id"
    Protected Const INSERT_RECEIPTKEY_SQL = "INSERT INTO ReceiptKey(ReceiptID,Room,Item,Location,ReceiptCount,Remark) VALUES(N'@id',N'@room',N'@item',N'@locaion',@count,N'@remark')"
    Protected Const UPDATE_RECEIPTKEY_SQL = "UPDATE ReceiptKey SET Room = N'@room' , Item = N'@item' , Location = N'@location' , ReceiptCount = @count, Remark = N'@remark' WHERE ReceiptKeyID = @id"
End Class
