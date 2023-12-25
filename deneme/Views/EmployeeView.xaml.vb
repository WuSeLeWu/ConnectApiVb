Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.XtraRichEdit.Model
Imports Microsoft.EntityFrameworkCore
Imports Newtonsoft.Json

Public Class EmployeeView
    Private ReadOnly viewModel As EmployeeVM
    Private ReadOnly apiService As ApiConnect

    Public Sub New()
        InitializeComponent()
        apiService = New ApiConnect()
        viewModel = New EmployeeVM()
        DataContext = viewModel
    End Sub

    Private Sub btnOpenEmployee_Click(sender As Object, e As RoutedEventArgs)
        viewModel.OpenWindowCommand()
    End Sub

    'Public Sub btnEdit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
    '    Dim button As Button = DirectCast(sender, Button)
    '    Dim id As Integer = Convert.ToInt32(button.Tag)
    '    viewModel.BtnEditCommand(id)
    'End Sub

    Private Async Sub TableView_RowUpdated(sender As Object, e As DevExpress.Xpf.Grid.RowEventArgs)
        Try

            Dim update As New EmployeeUpdate() With {
                .Address = e.Row.Address,
                .Email = e.Row.Email,
                .EmployeeId = e.Row.Id,
                .IsActive = e.Row.IsActive,
                .Phone = e.Row.Phone,
                .Username = e.Row.Username
            }


            Await apiService.UpdateDataAsync("Employee/Update", update)
        Catch ex As Exception
            MessageBox.Show("Bir hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As RoutedEventArgs)
        Dim selectedCompany As CompanyModel = TryCast(companyBox.SelectedItem, CompanyModel)
        Dim selectedDepartment As DepartmentModel = TryCast(departmentBox.SelectedItem, DepartmentModel)
        Dim gender As Integer = 0

        If male.IsChecked Then
            gender = 0
        ElseIf female.IsChecked Then
            gender = 1
        End If

        If selectedCompany IsNot Nothing Then
            Dim companyId As Integer = selectedCompany.Id
            Dim departmentId As Integer = selectedDepartment.Id


            If Convert.ToInt64(txtId.Text) = 0 Then
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
            Else
                Dim active As Boolean = False
                Dim content As String = activeBox.SelectedItem.ToString()

                If content = "Active" Then
                    active = 1 ' Eğer ComboBox'ta "Aktif" seçilmişse true yapılır
                End If
                Dim roleInstance As New EmployeeUpdate With {
                        .EmployeeId = txtId.Text,
                        .Address = txtAddress.Text,
                        .Email = txtMail.Text,
                        .Phone = txtPhone.Text,
                        .Username = txtUsername.Text,
                        .IsActive = active
                }



                Await viewModel.Update(roleInstance)
            End If
        Else
            MessageBox.Show("Company Boş Değer Döndürdü")

        End If
    End Sub

    Private Async Sub Information_Click(sender As Object, e As RoutedEventArgs)
        If Not String.IsNullOrEmpty(txtInformation.Text) AndAlso Int64.TryParse(txtInformation.Text, Nothing) Then
            Dim textId As Int64 = Convert.ToInt64(txtInformation.Text)
            Dim employeeInfo = Await viewModel.LoadEmployeeInformation(textId)
            Dim isActive = employeeInfo.data.IsActive
            activeBox.Visibility = Visibility.Visible
            txtActive.Visibility = Visibility.Visible


            If employeeInfo IsNot Nothing AndAlso employeeInfo.success Then
                Dim data = employeeInfo.data

                If employeeInfo.data.Gender = 0 Then
                    male.IsChecked = True
                Else
                    female.IsChecked = True
                End If


                If isActive Then
                    activeBox.Text = "Active"
                Else
                    activeBox.Text = "Passive"
                End If



                txtId.Text = data.Id
                txtAddress.Text = data.Address
                txtBirthYear.Text = data.BirthYear
                txtIdentity.Text = data.IdNumber
                txtMail.Text = data.Email
                txtPhone.Text = data.Phone
                txtName.Text = data.Name
                txtSurname.Text = data.Surname
                txtUsername.Text = data.Username
                departmentBox.Text = data.DepartmentName
                companyBox.Text = data.CompanyName

                departmentBox.IsEnabled = False
                companyBox.IsEnabled = False
                txtBirthYear.IsEnabled = False
                txtIdentity.IsEnabled = False
                txtName.IsEnabled = False
                txtSurname.IsEnabled = False
                male.IsEnabled = False
                female.IsEnabled = False



            Else
                MessageBox.Show("Belirtilen ID ile ilgili çalışan bilgisi bulunamadı.")
            End If
        Else
            MessageBox.Show("Geçerli bir ID numarası giriniz.")
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As RoutedEventArgs)
        Clear()
    End Sub

    Private Sub Clear()
        txtInformation.Text = String.Empty
        txtId.Text = 0
        txtAddress.Text = String.Empty
        txtBirthYear.Text = String.Empty
        txtIdentity.Text = String.Empty
        txtMail.Text = String.Empty
        txtPhone.Text = String.Empty
        txtName.Text = String.Empty
        txtSurname.Text = String.Empty
        txtUsername.Text = String.Empty
        departmentBox.Text = String.Empty
        companyBox.Text = String.Empty


        departmentBox.IsEnabled = True
        companyBox.IsEnabled = True
        txtBirthYear.IsEnabled = True
        txtIdentity.IsEnabled = True
        txtName.IsEnabled = True
        txtSurname.IsEnabled = True
        male.IsEnabled = True
        female.IsEnabled = True
        activeBox.Visibility = Visibility.Collapsed
        txtActive.Visibility = Visibility.Collapsed
    End Sub
End Class

