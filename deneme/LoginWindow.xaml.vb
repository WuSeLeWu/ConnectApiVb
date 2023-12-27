Imports Newtonsoft.Json
Imports System.Windows.Forms

Public Class LoginWindow
    Private Async Sub LoginBtn_Click(sender As Object, e As RoutedEventArgs)
        Dim model = New UserModel()
        model.UsernameOrEmail = txtUserName.Text
        model.Password = txtPassword.Password

        Dim connect = New ApiConnect()
        Dim response As ResponseModel(Of TokenModel) = Await connect.Login(model)

        If response IsNot Nothing Then
            If Not response.success Then

                Dim errorMessages As String = String.Join(Environment.NewLine, response.errors)
                errorMessage.Text = $"{errorMessages}"
            Else

                Dim tokenModel As TokenModel = response.data


                Repo.SessionManager.CompanyId = tokenModel.CompanyId
                Repo.SessionManager.Token = tokenModel.Token
                Repo.SessionManager.Eposta = txtUserName.Text
                Repo.SessionManager.Id = tokenModel.Id

                Dim longList As List(Of Long) = tokenModel.RolId
                Dim stringList As List(Of String) = longList.Select(Function(id) id.ToString()).ToList()
                Repo.SessionManager.RolIdList = stringList

                Repo.SessionManager.DepartmentId = tokenModel.DepartmentId


                Dim mainWindow As MainWindow = New MainWindow()
                Dim homePage As New HomeView()
                mainWindow.MainFrame.Content = homePage
                mainWindow.Show()

                Close()
            End If
        Else

            errorMessage.Text = "Sunucu ile bağlantıda bir sorun oluştu!"
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Minimized
    End Sub

    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        If e.ChangedButton = MouseButton.Left Then
            Me.DragMove()
        End If
    End Sub
End Class


