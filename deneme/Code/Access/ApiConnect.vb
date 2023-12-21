Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp
Imports Newtonsoft.Json

Public Class ApiConnect
    Private ReadOnly _client As HttpClient

    Public Sub New()
        _client = New HttpClient()
        _client.BaseAddress = New Uri("https://localhost:7064/")
        _client.DefaultRequestHeaders.Accept.Clear()
        _client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
    End Sub


    Public Async Function Login(loginVM As UserModel) As Task(Of ResponseModel(Of TokenModel))
        Try
            Dim jsonData As String = JsonConvert.SerializeObject(loginVM)
            Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await _client.PostAsync("Employee/LoginData", content)

            If response.IsSuccessStatusCode Then
                Dim responseData As String = Await response.Content.ReadAsStringAsync()
                Dim tokenModel = JsonConvert.DeserializeObject(Of ResponseModel(Of TokenModel))(responseData)

                ' API'den gelen veri, ResponseModel(Of TokenModel) yapısına uygunsa doğrudan kullanılabilir.
                Return tokenModel
            Else
                ' Başarısız yanıtı işle
                Return Nothing
            End If
        Catch ex As Exception
            ' Hata durumunu işle
            Return Nothing
        End Try
    End Function





    Public Async Function FetchDataAsync(ByVal apiUrl As String) As Task(Of String)
        Dim request As New HttpRequestMessage(HttpMethod.Get, apiUrl)

        Dim token As String = Repo.SessionManager.GetToken()
        request.Headers.Authorization = New AuthenticationHeaderValue("Bearer", token)

        Dim response As HttpResponseMessage = Await _client.SendAsync(request)

        If response.IsSuccessStatusCode Then
            Dim content As String = Await response.Content.ReadAsStringAsync()
            Return content
        Else
            ' Hata işleme
            Dim errorMessage As String = "An unknown error occurred."
            If response.Content IsNot Nothing Then
                errorMessage = Await response.Content.ReadAsStringAsync()
            End If

            ' Hata mesajını işle
            ' ...

            Return errorMessage
        End If
    End Function



    Public Async Function SaveDataAsync(Of T)(ByVal apiUrl As String, ByVal data As T) As Task(Of HttpResponseMessage)
        Dim token As String = Repo.SessionManager.GetToken()

        _client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)

        Dim jsonData As String = JsonConvert.SerializeObject(data)
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await _client.PostAsync(apiUrl, content)

        Return response
    End Function


    Public Async Function UpdateDataAsync(Of T)(ByVal apiUrl As String, ByVal data As T) As Task(Of HttpResponseMessage)
        Dim token As String = Repo.SessionManager.GetToken()

        _client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)

        Dim jsonData As String = JsonConvert.SerializeObject(data)
        Dim content As New StringContent(jsonData.ToString(), Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await _client.PutAsync(apiUrl, content)

        Return response
    End Function


    Public Async Function DeleteDataAsync(ByVal apiUrl As String) As Task(Of HttpResponseMessage)
        Dim token As String = Repo.SessionManager.GetToken()

        _client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)

        Dim response As HttpResponseMessage = Await _client.DeleteAsync(apiUrl)

        Return response
    End Function



End Class
