Imports System.Collections.ObjectModel
Imports Newtonsoft.Json

Public Class RoleVM
    Private ReadOnly apiService As ApiConnect
    Public Property Roles As ObservableCollection(Of RoleModel)

    Public Sub New()
        apiService = New ApiConnect()
        Roles = New ObservableCollection(Of RoleModel)()
        GetRoles()
    End Sub

    Public Async Sub GetRoles()
        Roles.Clear()
        Dim response As String = Await apiService.FetchDataAsync("Role/GetAll")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of RoleModel)))(response)

        If apiResponse.success Then
            For Each employee As RoleModel In apiResponse.data
                Roles.Add(employee)
            Next
        End If
    End Sub

    Public Async Function SaveRole(ByVal role As RoleModel) As Task
        Roles.Clear()
        Await apiService.SaveDataAsync("Role/Create", role)
        GetRoles()
    End Function

    Public Async Function UpdateRole(ByVal role As RoleModel) As Task
        Roles.Clear()
        Await apiService.UpdateDataAsync("Role/Update", role)
        GetRoles()
    End Function

    Public Async Function DeleteRole(ByVal id As Int64) As Task
        Roles.Clear()
        Await apiService.DeleteDataAsync($"Role/DeletePermanent/{id}")
        GetRoles()
    End Function
End Class
