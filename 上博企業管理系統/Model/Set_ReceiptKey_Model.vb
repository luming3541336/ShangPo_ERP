﻿Public Class Set_ReceiptKey_Model
    Protected Const SELECT_RECEIPTDATA_SQL = "SELECT * FROM ReceiptData WHERE ReceiptID = @id"
    Protected Const UPDATE_RECEIPTDATA_SQL = "UPDATE ReceiptData SET ReceiptOrder =N'@order', ReceiptType = @type, ReceiptDate = @date, InsertDate = N'@insertDate', Status = @status ,Contact = N'@contact', Place = N'@place',ReturnDate = @returnDate ,ReturnUser = N'@returnUser' WHERE ReceiptID = @id"
    Protected Const INSERT_RECEIPTDATA_SQL = "INSERT INTO ReceiptData(CaseID,ReceiptOrder,ReceiptType,InsertDate,Status,Place,Contact,ReturnDate,ReturnUser) VALUES(@id,N'@order',@type,N'@insertDate',@status,N'@place',N'@contact',@returnDate,N'@returnUser');SELECT @@IDENTITY as id"
    Protected Const SELECT_RECEIPTDATA_COUNT_SQL = "SELECT COUNT(ReceiptOrder)  AS OrderCount FROM ReceiptData WHERE ReceiptOrder LIKE N'@order%'"
    Protected Const DELETE_RECEIPTDATA_SQL = "DELETE FROM ReceiptFile Where ReceiptID = @id;DELETE  FROM ReceiptKey WHERE ReceiptID = @id;DELETE FROM ReceiptData WHERE ReceiptID = @id"

    Protected Const SELECT_RECEIPTKEY_SQL = "SELECT * FROM ReceiptKey WHERE ReceiptID = @id"
    Protected Const INSERT_RECEIPTKEY_SQL = "INSERT INTO ReceiptKey(ReceiptID,Room,Item,Location,ReceiptCount,Remark) VALUES(N'@id',N'@room',N'@item',N'@location',@count,N'@remark');SELECT @@IDENTITY as id"
    Protected Const UPDATE_RECEIPTKEY_SQL = "UPDATE ReceiptKey SET Room = N'@room' , Item = N'@item' , Location = N'@location' , ReceiptCount = @count, Remark = N'@remark' WHERE ReceiptKeyID = @id"
    Protected Const DELETE_RECEIPTKEY_SQL = "DELETE FROM ReceiptKey Where ReceiptKeyID = @id"

    Protected Const SELECT_RECEIPTFILE_SQL = "SELECT * FROM ReceiptFile WHERE ReceiptID = @id"
    Protected Const INSERT_RECEIPTFILE_SQL = "INSERT INTO ReceiptFile(ReceiptID, ReceiptFileName,ReceiptFilePath) VALUES(@id,N'@fileName',N'@filePath')"
    Protected Const DELETE_RECEIPTFILE_SQL = "DELETE FROM ReceiptFile Where ReceiptFileID = @id"
End Class
