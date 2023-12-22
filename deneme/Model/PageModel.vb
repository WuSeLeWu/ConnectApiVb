Imports System.Collections.ObjectModel

Public Class PageModel
    Public Property Id As Integer
    Public Property Url As String
    Public Property PageName As String
    Public Property Content As String
    Public Property Icon As String
    Public Property LowerPages As List(Of PageModel)
End Class

