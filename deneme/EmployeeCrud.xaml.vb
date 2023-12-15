Imports System.ComponentModel.Design
Imports System.Globalization
Imports DevExpress.Pdf
Imports Newtonsoft.Json

Public Class EmployeeCrud

    Private ReadOnly apiService As ApiConnect
    Public Event StatusOK As EventHandler
    Private ReadOnly viewModel As EmployeeVM
    Public Sub New()
        InitializeComponent()
        apiService = New ApiConnect()
        viewModel = New EmployeeVM()
        DataContext = viewModel
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub


    Private Async Sub btnSave_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim selectedCompany As CompanyModel = TryCast(companyBox.SelectedItem, CompanyModel)
        Dim selectedDepartment As DepartmentModel = TryCast(departmentBox.SelectedItem, DepartmentModel)
        Dim gender As Integer = 0

        If selectedCompany IsNot Nothing Then
            Dim companyId As Integer = selectedCompany.Id
            Dim departmentId As Integer = selectedDepartment.Id
            Dim selectedGenderItem As ComboBoxItem = TryCast(txtGender.SelectedItem, ComboBoxItem)
            Dim content As String = selectedGenderItem.Content.ToString()
            If content = "Female" Then
                gender = 1
            End If
            Dim roleInstance As New EmployeeCreate With {
            .Name = txtName.Text,
            .Surname = txtSurname.Text,
            .CompanyId = companyId,
            .Address = txtAddress.Text,
            .BirthYear = txtBirthYear.Text,
            .DepartmentId = departmentId,
            .Email = txtMail.Text,
            .Gender = gender,
            .IdNumber = txtIdentity.Text,
            .Phone = txtPhone.Text,
            .Username = txtUsername.Text
        }

            Await viewModel.Save(roleInstance)

            RaiseEvent StatusOK(Me, EventArgs.Empty)
            Close()

        End If
    End Sub

End Class
