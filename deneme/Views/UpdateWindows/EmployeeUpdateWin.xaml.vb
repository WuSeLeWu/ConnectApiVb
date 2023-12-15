Imports Newtonsoft.Json

Public Class EmployeeUpdateWin

    Private ReadOnly apiService As ApiConnect
    Public Event StatusOK As EventHandler
    Private ReadOnly employeeId As Integer

    Public Sub New(id As Integer)
        InitializeComponent()
        apiService = New ApiConnect()
        employeeId = id
        GetEmployee()
    End Sub


    Private Async Sub GetEmployee()
        Dim response As String = Await apiService.FetchDataAsync($"Employee/GetById/{employeeId}")
        Dim apiResponse = JsonConvert.DeserializeObject(Of ResponseModel(Of EmployeeModel))(response)

        If apiResponse.success Then
            Dim employeeData = apiResponse.data

            activeBox.Items.Add("Aktif")
            activeBox.Items.Add("Aktif Değil")

            If employeeData.IsActive Then
                activeBox.SelectedItem = "Aktif"
            Else
                activeBox.SelectedItem = "Aktif Değil"
            End If

            txtAddress.Text = employeeData.Address
            txtId.Text = employeeData.Id
            txtMail.Text = employeeData.Email
            txtPhone.Text = employeeData.Phone
            txtUsername.Text = employeeData.Username
        End If
    End Sub
    Private Async Function Update(ByVal role As EmployeeUpdate) As Task
        Await apiService.UpdateDataAsync("Employee/Update", role)
    End Function

    Private Async Sub btnSave_Click(sender As Object, e As RoutedEventArgs)
        Dim active As Boolean = False ' Varsayılan olarak false olarak başlatılır
        Dim content As String = activeBox.SelectedItem.ToString()

        If content = "Aktif" Then
            active = 1 ' Eğer ComboBox'ta "Aktif" seçilmişse true yapılır
        End If

        Dim employee As New EmployeeUpdate With {
        .IsActive = active,
        .Username = txtUsername.Text,
        .Phone = txtPhone.Text,
        .Address = txtAddress.Text,
        .Email = txtMail.Text,
        .EmployeeId = txtId.Text
    }

        Await Update(employee)
        MessageBox.Show("Geldi")
        RaiseEvent StatusOK(Me, EventArgs.Empty)
        Close()
    End Sub


    Private Sub ButtonClose_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
