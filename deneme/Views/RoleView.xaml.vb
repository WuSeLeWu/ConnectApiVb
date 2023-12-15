Imports DevExpress.Pdf
Imports Newtonsoft.Json
Imports System.Data

Public Class RoleView
    Private ReadOnly viewModel As RoleVM

    Public Sub New()
        InitializeComponent()
        viewModel = New RoleVM()
        DataContext = viewModel
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        viewModel.GetRoles()
    End Sub

    Private Async Sub btnSave_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim roleInstance As New RoleModel With {
        .Id = Convert.ToInt64(txtId.Text),
        .Name = txtName.Text
    }

        If roleInstance.Id = 0 Then
            Await viewModel.SaveRole(roleInstance)
        Else
            Await viewModel.UpdateRole(roleInstance)
        End If

        txtId.Text = 0.ToString()
        txtName.Text = ""
    End Sub


    Private Async Sub btnDelete_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim role = TryCast((TryCast(sender, FrameworkElement))?.DataContext, RoleModel)
        If role IsNot Nothing Then
            Await viewModel.DeleteRole(role.Id)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim role = TryCast((TryCast(sender, FrameworkElement))?.DataContext, RoleModel)
        If role IsNot Nothing Then
            txtId.Text = role.Id.ToString()
            txtName.Text = role.Name
        End If
    End Sub
End Class
