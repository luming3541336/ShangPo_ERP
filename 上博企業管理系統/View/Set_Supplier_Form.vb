Imports System.Data.SqlClient

Public Class AddSupplier
    Public AddResult As SupplierData = Nothing
    Private conDB As DBController = New DBController
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameText.Focus()
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        'Dim con As Connection = New Connection
        'Dim DataReader As SqlDataReader = con.ExecuteSQL("INSERT INTO SupplierData(Number,Name,ID,Address,Contact,Phone) Values(N'" & NumberText.Text &
        '                                                 "',N'" & NameText.Text & "','" & IDText.Text & "',N'" & AddressText.Text & "',N'" & ContactText.Text & "','" & PhoneText.Text &
        '                                                 "'); SELECT @@IDENTITY AS 'SuID';").ExecuteReader
        conDB._insert("SupplierData", {"Number", "Name", "CpyID", "Address", "Contact", "Phone"})
        conDB._value({NumberText.Text, NameText.Text, IDText.Text, AddressText.Text, ContactText.Text, PhoneText.Text})
        Dim DataReader As SqlDataReader = conDB.toInsert("SuID").ExecuteReader
        If DataReader.HasRows Then
            Do While DataReader.Read
                AddResult = New SupplierData(DataReader("SuID"), NumberText.Text, NameText.Text, CType(IIf(IDText.Text = "", 0, IDText.Text), Integer), AddressText.Text, ContactText.Text, PhoneText.Text)
            Loop
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub


End Class