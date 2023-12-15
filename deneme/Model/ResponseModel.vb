Public Class ResponseModel(Of T)
    Public Property data As T
    Public Property success As Boolean
    Public Property errors As List(Of Object)
End Class
