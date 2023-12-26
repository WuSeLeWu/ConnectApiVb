Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.Intrinsics
Imports DevExpress.Mvvm
Imports Newtonsoft.Json

Public Class MainViewModel
    Inherits ViewModelBase
    Implements INotifyPropertyChanged

    Private ReadOnly _repo As Repo
    Private ReadOnly apiService As ApiConnect

    Public Sub New()
        apiService = New ApiConnect()
        _repo = New Repo()
        PageDataList = New ObservableCollection(Of PageModel)()
        LoadPagesFromAPI()
    End Sub

    Public Property Eposta As String
        Get
            Return _repo.SessionManager.Eposta
        End Get
        Set(value As String)
            _repo.SessionManager.Eposta = value
        End Set
    End Property

    Public Property Tag As String
        Get
            Dim eposta As String = _repo.SessionManager.Eposta
            Return eposta.Substring(0, 2).ToUpper()
        End Get
        Set(value As String)
            _repo.SessionManager.Eposta = value
        End Set
    End Property


    '**********************************************

    Private _pages As List(Of PageModel)

    Private ReadOnly _pageModel As List(Of PageModel)

    Public Property PageDataList As ObservableCollection(Of PageModel)
    Public Property Pages As List(Of PageModel)
        Get
            Return _pages
        End Get
        Set(value As List(Of PageModel))
            _pages = value
            OnPropertyChanged(NameOf(Pages))
        End Set
    End Property

    Private _lowerPages As List(Of PageModel)
    Public Property LowerPages As List(Of PageModel)
        Get
            Return _lowerPages
        End Get
        Set(value As List(Of PageModel))
            _lowerPages = value
            OnPropertyChanged(NameOf(LowerPages))
        End Set
    End Property

    Public Async Sub LoadPagesFromAPI()

        Try

            Dim response As String = Await apiService.FetchDataAsync("Page/GetAll")
            Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of PageModel)))(response)

            ' Gelen verileri Model sınıfına dönüştürme
            Dim pageModels = ConvertToPageModels(apiResponse.data)

            ' Verileri YourPageModelCollection'a ekleme
            For Each page In pageModels
                PageDataList.Add(page)
            Next
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message)
        End Try
    End Sub

    Private Function ConvertToPageModels(data1 As List(Of PageModel)) As List(Of PageModel)
        Dim pageModels As New List(Of PageModel)()

        Try
            For Each page As PageModel In data1
                Dim newPageModel As New PageModel() With {
                .Id = page.Id,
                .Url = page.Url,
                .PageName = page.PageName,
                .Content = page.Content,
                .Icon = page.Icon
            }

                If page.LowerPages IsNot Nothing AndAlso page.LowerPages.Any() Then
                    newPageModel.LowerPages = ConvertToPageModels(page.LowerPages)
                End If

                pageModels.Add(newPageModel)
            Next
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try

        Return pageModels
    End Function





    ' INotifyPropertyChanged için gerekli event ve metotlar
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class


