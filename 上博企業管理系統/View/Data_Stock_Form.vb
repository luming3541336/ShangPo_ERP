

Imports System.ComponentModel

Public Class StockForm
    Private Sub loadStockBackGround_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles loadStockBackGround.DoWork
        Dim controller As Data_Stock_Controller = New Data_Stock_Controller
        e.Result = {controller.Load_Stock, e.Argument}
    End Sub

    Private Sub Data_Stock_Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim processForm As Status_Normal_Form = New Status_Normal_Form("載入中，請稍後")
        processForm.Show()
        loadStockBackGround.RunWorkerAsync(processForm)
    End Sub

    Private Sub loadStockBackGround_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles loadStockBackGround.RunWorkerCompleted
        Dim listData As List(Of Data_Stock_Model.StockData) = New List(Of Data_Stock_Model.StockData)
        listData = e.Result(0)
        For Each data As Data_Stock_Model.StockData In listData
            StockDGV.Rows.Add(data.InsertTime, data.Name, data.SupplierName, data.Specification, data.Width, data.Length, data.CBM, data.Count, data.Remark, data.CasePlace, IIf(data.State, "已結案", "未結案"))
        Next

        StockDGV.Sort(CaseName, ListSortDirection.Ascending)
        e.Result(1).Dispose
    End Sub

End Class