Imports Newtonsoft.Json

Public Class EmployeeView
    Private ReadOnly viewModel As EmployeeVM

    Public Sub New()
        InitializeComponent()
        viewModel = New EmployeeVM()
        DataContext = viewModel
    End Sub

    Private Sub Btn_Load_Click(sender As Object, e As RoutedEventArgs)
        viewModel.LoadUsers()
    End Sub

    Private Sub btnOpenEmployee_Click(sender As Object, e As RoutedEventArgs)
        viewModel.OpenWindowCommand()
    End Sub

    Public Sub btnEdit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim id As Integer = Convert.ToInt32(button.Tag)
        viewModel.BtnEditCommand(id)
    End Sub

End Class

