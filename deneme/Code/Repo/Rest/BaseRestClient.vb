Imports System.Text.Json
Imports RestSharp
Imports RestSharp.Serializers.Json

Public MustInherit Class BaseRestClient
    Public Shared BASE_URL As String = "https://localhost:7131/api"
    Protected client As RestClient

    Public Sub New()
        client = New RestClient(BASE_URL, configureSerialization:=Function(s) s.UseSystemTextJson(New JsonSerializerOptions With {.PropertyNamingPolicy = Nothing}))
    End Sub
End Class
