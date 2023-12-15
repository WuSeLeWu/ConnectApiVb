Imports DevExpress.XtraPrinting.Native


Public Class Repo
    Public Class SessionManager
        Private Shared sessionData As New Dictionary(Of String, String)()

        Public Shared Property CompanyId As String
            Get
                Return GetSessionValue("CompanyId")
            End Get
            Set(value As String)
                SetSessionValue("CompanyId", value)
            End Set
        End Property
        Public Shared Property Token As String
            Get
                Return GetSessionValue("Token")
            End Get
            Set(value As String)
                SetSessionValue("Token", value)
            End Set
        End Property

        Public Shared Property Eposta As String
            Get
                Return GetSessionValue("Eposta")
            End Get
            Set(value As String)
                SetSessionValue("Eposta", value)
            End Set
        End Property

        Public Shared Property RolIdList As List(Of String)
            Get
                Dim rolIdString As String = GetSessionValue("RolId")
                Return rolIdString.Split(","c).ToList()
            End Get
            Set(value As List(Of String))
                SetSessionValue("RolId", String.Join(",", value))
            End Set
        End Property


        Public Shared Property Id As String
            Get
                Return GetSessionValue("Id")
            End Get
            Set(value As String)
                SetSessionValue("Id", value)
            End Set
        End Property


        Public Shared Property DepartmentId As String
            Get
                Return GetSessionValue("DepartmentId")
            End Get
            Set(value As String)
                SetSessionValue("DepartmentId", value)
            End Set
        End Property

        ' Diğer oturum özelliklerini benzer şekilde tanımlayabilirsiniz.

        Private Shared Function GetSessionValue(key As String) As String
            If sessionData.ContainsKey(key) Then
                Return sessionData(key)
            Else
                Return String.Empty
            End If
        End Function

        Private Shared Sub SetSessionValue(key As String, value As String)
            sessionData(key) = value
        End Sub

        Public Shared Function GetToken() As String
            Return Token
        End Function
    End Class


End Class


