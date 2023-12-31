﻿Imports System.Collections.ObjectModel
Imports DevExpress.Pdf
Imports Newtonsoft.Json

Public Class EmployeeVM

    Private ReadOnly apiService As ApiConnect

    Public Property Users As ObservableCollection(Of EmployeeModel)
    Public Property Companies As ObservableCollection(Of CompanyModel)
    Public Property Departments As ObservableCollection(Of DepartmentModel)
    Public Property RequestsByEmployee As ObservableCollection(Of RequestModel)

    Public Sub New()
        apiService = New ApiConnect()
        Users = New ObservableCollection(Of EmployeeModel)()
        Companies = New ObservableCollection(Of CompanyModel)()
        Departments = New ObservableCollection(Of DepartmentModel)()
        RequestsByEmployee = New ObservableCollection(Of RequestModel)()
    End Sub

    Public Async Sub LoadUsers()
        Users.Clear()

        Dim response As String = Await apiService.FetchDataAsync("Employee/GetAll")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of EmployeeModel)))(response)

        If apiResponse.success Then
            For Each employee As EmployeeModel In apiResponse.data
                Users.Add(employee)

            Next
        End If
    End Sub

    Public Async Function LoadCompanies() As Task
        Companies.Clear()

        Dim response As String = Await apiService.FetchDataAsync("Company/GetAll")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of CompanyModel)))(response)

        If apiResponse.success Then
            For Each company In apiResponse.data
                Companies.Add(company)
            Next
        End If
    End Function

    Public Async Function LoadDepartments() As Task
        Departments.Clear()

        Dim response As String = Await apiService.FetchDataAsync("Department/GetAll")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of DepartmentModel)))(response)

        If apiResponse.success Then
            For Each department In apiResponse.data
                Departments.Add(department)
            Next
        End If
    End Function

    Public Async Function LoadRequestByEmployeeId(identity As String) As Task
        RequestsByEmployee.Clear()

        Dim response As String = Await apiService.FetchDataAsync($"Request/GetByIdentity/{identity}")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of List(Of RequestModel)))(response)

        If apiResponse.success Then
            For Each department In apiResponse.data
                RequestsByEmployee.Add(department)
            Next
        End If
    End Function

    Public Async Function LoadEmployeeInformation(identity As String) As Task(Of ResponseModel(Of EmployeeModel))
        Dim response As String = Await apiService.FetchDataAsync($"Employee/GetByIdentity/{identity}")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of EmployeeModel))(response)

        Return apiResponse
    End Function

    Public Async Function Save(ByVal role As EmployeeCreate) As Task
        Await apiService.SaveDataAsync("Employee/Create", role)
    End Function

    Public Async Function Update(ByVal role As EmployeeUpdate) As Task
        Await apiService.UpdateDataAsync("Employee/Update", role)
    End Function

End Class
