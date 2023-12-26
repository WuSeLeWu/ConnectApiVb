Imports Newtonsoft.Json
Imports System.Windows.Forms

Public Class LoginWindow
    Private Async Sub LoginBtn_Click(sender As Object, e As RoutedEventArgs)
        Dim model = New UserModel()
        model.UsernameOrEmail = txtUserName.Text
        model.Password = txtPassword.Password

        Dim connect = New ApiConnect()

        ' Giriş bilgileri ile API'ye istek gönder ve ResponseModel(Of TokenModel) olarak verileri al
        Dim response As ResponseModel(Of TokenModel) = Await connect.Login(model)

        If response IsNot Nothing Then
            If Not response.success Then
                ' Yanlış giriş durumu
                Dim errorMessages As String = String.Join(Environment.NewLine, response.errors)
                errorMessage.Text = $"{errorMessages}"
            Else
                ' Doğru giriş
                Dim tokenModel As TokenModel = response.data ' İlk veriyi alabilirsiniz

                ' Örnek olarak:
                Repo.SessionManager.CompanyId = tokenModel.CompanyId
                Repo.SessionManager.Token = tokenModel.Token
                Repo.SessionManager.Eposta = txtUserName.Text
                Repo.SessionManager.Id = tokenModel.Id

                Dim longList As List(Of Long) = tokenModel.RolId
                Dim stringList As List(Of String) = longList.Select(Function(id) id.ToString()).ToList()
                Repo.SessionManager.RolIdList = stringList

                Repo.SessionManager.DepartmentId = tokenModel.DepartmentId

                ' Ana pencereyi aç ya da işlemleri devam ettir
                Dim mainWindow As MainWindow = New MainWindow()
                mainWindow.Show()

                Close()
            End If
        Else
            ' API'ye istek gönderilirken bir sorun oluştu
            errorMessage.Text = "API ile bağlantıda bir sorun oluştu!"
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class


