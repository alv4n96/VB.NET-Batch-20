Namespace PartTwo
    Public Interface IHR

        Function InitEmployee() As List(Of Employee)

        Function FindEmployeeById(listEmps As List(Of Employee), Id As Integer) As Employee

        Sub DisplayEmployee(listEmps As List(Of Employee))

        Function GetTotalSalary(listEmps As List(Of Employee)) As Double

        Function TotalEmployeeByRole(role As String, listEmps As List(Of Employee)) As Integer

        Function TotalEmployeeSalaryByRole(role As String, listEmps As List(Of Employee)) As Double
    End Interface

End Namespace

