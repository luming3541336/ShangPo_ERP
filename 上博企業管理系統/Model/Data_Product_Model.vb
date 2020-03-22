Imports System.ComponentModel

Public Class Data_Product_Model
    Protected Const SELECT_Supplier_SQL = "SELECT * FROM SupplierData"
    Protected Const SELECT_ProdData_SQL = "SELECT * FROM ProdData"
    Protected Const INSERT_ProdData_SQL = "INSERT INTO ProdData(ProdName,Unit) VALUES(N'@name',N'@unit'); SELECT @@IDENTITY"
    Protected Const UPDATE_ProdData_SQL = "UPDATE ProdData SET @statement WHERE ProdID = @id"
    Protected Const DELETE_ProdData_SQL = "DELETE FROM ProdData WHERE ProdID = @id"

    Protected Const SELECT_ProdModel_SQL = "SELECT *,SupplierData.Name FROM ProdModel,SupplierData WHERE ProdID = @id AND ProdModel.SuID = SupplierData.SuID"
    Protected Const INSERT_ProdModel_SQL = "INSERT INTO ProdModel(ProdID,SuID,Model,Price) VALUES(@id,@suId,N'@model',@price); SELECT @@IDENTITY "
    Protected Const UPDATE_ProdModel_SQL = "UPDATE ProdModel SET @statement WHERE ProdModelID = @id"
    Protected Const DELETE_ProdModel_SQL = "DELETE FROM ProdModel WHERE ProdModelID = @id"
End Class
Public Class ProdData
    Private intProdID As Integer
    Private strName As String
    Private strUnit As String
    Private changeProperty As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Property ProdID As Integer
        Get
            Return intProdID
        End Get
        Set(value As Integer)
            If intProdID <> value Then
                intProdID = value
                If changeProperty.ContainsKey("ProdID") Then
                    changeProperty("ProdID") = value
                Else
                    changeProperty.Add("ProdID", value)
                End If
            End If
        End Set
    End Property
    Property ProdName As String
        Get
            Return strName
        End Get
        Set(value As String)
            If strName <> value Then
                strName = value
                If changeProperty.ContainsKey("ProdName") Then
                    changeProperty("ProdName") = value
                Else
                    changeProperty.Add("ProdName", value)
                End If
            End If
        End Set
    End Property
    Property Unit As String
        Get
            Return strUnit
        End Get
        Set(value As String)
            If strUnit <> value Then
                strUnit = value
                If changeProperty.ContainsKey("Unit") Then
                    changeProperty("Unit") = value
                Else
                    changeProperty.Add("Unit", value)
                End If
            End If
        End Set
    End Property
    Public Function GetChargedProperty() As Dictionary(Of String, String)
        Return changeProperty
    End Function
    Public Sub ClearChangeProperty()
        changeProperty.Clear()
    End Sub
End Class
Public Class ProdModel
    Private intModelID As Integer
    Private intProdID As Integer
    Private intSuID As Integer
    Private strModel As String
    Private intPrice As Integer
    Private changeProperty As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Property ProdModelID As Integer
        Get
            Return intModelID
        End Get
        Set(value As Integer)
            If intModelID <> value Then
                intModelID = value
                If changeProperty.ContainsKey("ProdModelID") Then
                    changeProperty("ProdModelID") = value
                Else
                    changeProperty.Add("ProdModelID", value)
                End If
            End If
        End Set
    End Property
    Property ProdID As Integer
        Get
            Return intProdID
        End Get
        Set(value As Integer)
            If intProdID <> value Then
                intProdID = value
                If changeProperty.ContainsKey("ProdID") Then
                    changeProperty("ProdID") = value
                Else
                    changeProperty.Add("ProdID", value)
                End If
            End If
        End Set
    End Property
    Property Name As String 'SupplierData
    Property SuID As Integer
        Get
            Return intSuID
        End Get
        Set(value As Integer)
            If intSuID <> value Then
                intSuID = value
                If changeProperty.ContainsKey("SuID") Then
                    changeProperty("SuID") = value
                Else
                    changeProperty.Add("SuID", value)
                End If
            End If
        End Set
    End Property
    Property Model As String
        Get
            Return strModel
        End Get
        Set(value As String)
            If strModel <> value Then
                strModel = value
                If changeProperty.ContainsKey("Model") Then
                    changeProperty("Model") = value
                Else
                    changeProperty.Add("Model", value)
                End If
            End If
        End Set
    End Property
    Property Price As Integer
        Get
            Return intPrice
        End Get
        Set(value As Integer)
            If intPrice <> value Then
                intPrice = value
                If changeProperty.ContainsKey("Price") Then
                    changeProperty("Price") = value
                Else
                    changeProperty.Add("Price", value)
                End If
            End If
        End Set
    End Property
    Public Function GetChargedProperty() As Dictionary(Of String, String)
        Return changeProperty
    End Function
    Public Sub ClearChangeProperty()
        changeProperty.Clear()
    End Sub
End Class
Public Class SupplierData
    Property SuID As Integer
    Property Name As String
End Class