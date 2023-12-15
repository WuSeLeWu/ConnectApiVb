Imports System.Globalization
Imports System.Runtime.Intrinsics
Imports DevExpress.Mvvm

Public Class MainViewModel
    Inherits ViewModelBase

    Private ReadOnly _repo As Repo

    Public Sub New()
        _repo = New Repo()
    End Sub

    Public Property Eposta As String
        Get
            Return _repo.SessionManager.Eposta
        End Get
        Set(value As String)
            _repo.SessionManager.Eposta = value
        End Set
    End Property
End Class


