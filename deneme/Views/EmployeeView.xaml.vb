Imports System.Data
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
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

    Public Sub btnEdit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim id As Integer = Convert.ToInt32(button.Tag)
        viewModel.BtnEditCommand(id)
    End Sub

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

End Class

