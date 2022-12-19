Namespace PartOne
    Public Class Employee
        Public empId As Integer
        Public firstName As String
        Public lastName As String
        Public joinDate As DateTime
        Public basicSalary As Double
        'Public role As String

        Public Overrides Function ToString() As String
            Return $"EmpId       : {empId}, 
First Name  : {firstName},
Last Name   : {lastName},
Join Date   : {joinDate},
Basic Salary: {basicSalary}"
        End Function


    End Class
End Namespace
