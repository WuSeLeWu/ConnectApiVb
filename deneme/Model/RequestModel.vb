Public Class RequestModel
    Public Property Id As Int64
    Public Property ProductId As Long
    Public Property ProductName As String
    Public Property MeasuringUnitName As String

    Public Property ApprovingEmployeeId As Long
    Public Property ApprovingEmployeeName As String
    Public Property ApprovingEmployeeSurname As String
    Public Property RequestEmployeeId As Long
    Public Property RequestEmployeeName As String
    Public Property RequestEmployeeSurname As String
    Public Property Details As String
    Public Property Quantity As Double
    Public Property CreatedDate As DateTime?

    Public Property State As Status
End Class

