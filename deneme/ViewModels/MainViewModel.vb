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


    'Public Property pageName As String
    '    Get
    '        Return _pages
    '    End Get
    '    Set(value As String)
    '        _pageModel.PageName = value
    '        OnPropertyChanged(NameOf(Pages))
    '    End Set
    'End Property
    ' API'den veri çekme metodu burada olacak
    'Public Async Function LoadPagesFromAPI() As Task

    '    Dim response As String = Await apiService.FetchDataAsync("Page/GetAll")
    '    Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of PageModel)))(response)
    '    ' Gelen verileri Model sınıfına dönüştürme
    '    Pages = ConvertToPageModels(apiResponse)
    'End Function

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

    ' Veri dönüşümü için yardımcı metot
    'Private Function ConvertToPageModels(data1 As Object) As List(Of PageModel)
    '    If TypeOf data1.data Is List(Of PageModel) Then
    '        Dim pageModels = TryCast(data1.Data, List(Of PageModel))
    '        Return pageModels
    '    Else
    '        ' Dönüşüm yapılamadı, uygun bir işlem yapılabilir
    '        ' Örneğin, boş bir liste dönebilir veya hata durumunu işleyebilirsiniz
    '        Return New List(Of PageModel)()
    '    End If
    'End Function

    Private Function ConvertToPageModels(data1 As List(Of PageModel)) As List(Of PageModel)
        Dim pageModels As New List(Of PageModel)()

        Try
            For Each page As PageModel In data1
                ' Her bir PageModel nesnesini alınan veriye göre oluşturun
                Dim newPageModel As New PageModel() With {
                .Id = page.Id,
                .Url = page.Url,
                .PageName = page.PageName,
                .Content = page.Content
            }

                ' Alt sayfaları döngü içinde ekleme örneği:
                If page.LowerPages IsNot Nothing AndAlso page.LowerPages.Any() Then
                    newPageModel.LowerPages = New List(Of PageModel)()

                    For Each lowerPage In page.LowerPages
                        newPageModel.LowerPages.Add(New PageModel() With {
                        .Id = lowerPage.Id,
                        .Url = lowerPage.Url,
                        .PageName = lowerPage.PageName,
                        .Content = lowerPage.Content
                    })
                    Next
                End If

                ' Oluşturulan PageModel'i List'e ekleme
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


