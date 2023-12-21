Public Class EmployeeModel
    Public Property Id As Long
    'Public Property CompanyDepartmentId As Long
    Public Property DepartmentName As String
    Public Property Address As String
    Public Property Name As String
    Public Property Surname As String
    Public Property Username As String
    'Public Property Gender As Gender
    Public Property Email As String
    Public Property Phone As String
    Public Property IdNumber As String
    Public Property BirthYear As String
    Public Property IsActive As Boolean?
    'Public Property ImageSrc As String
    Public Property Roles As List(Of String)
End Class

Public Enum Gender
    Male = 0
    Female = 1
End Enum

