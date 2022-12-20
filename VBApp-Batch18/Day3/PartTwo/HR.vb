Namespace PartTwo
    Public Class HR
        Implements IHR
        Public Sub DisplayEmployee(listEmps As List(Of Employee)) Implements IHR.DisplayEmployee
            For Each Employee In listEmps
                Console.WriteLine(Employee)
            Next
        End Sub


        Public Function InitEmployee() As List(Of Employee) Implements IHR.InitEmployee
            Dim listEmp As New List(Of Employee) From {
                New Employee(1, "Kang", "Dian", DateTime.Now, 5_000_000),
                New Employee("koh", "Ericson", DateTime.Now(), 5_500_000),
                New Programmer("Anton", "Pratama", #03/03/2015#, 6_000_000, 500_000),
                New Programmer("Budi", "Junaedi", #08/15/2016#, 6_000_000, 500_000),
                New Programmer("Charlie", "Van Dijk", #09/05/2017#, 6_000_000, 500_000),
                New Sales("Dian", "Permana", #10/12/2017#, 3_000_000, 500_000, 200_000),
                New Sales("Fatur", "Rohman", #01/15/2019#, 3_000_000, 350_000, 250_000),
                New QA("Ellise", "Toon", #01/15/2019#, 4_500_000, 10_000),
                New QA("Gita", "Gutawa", #03/01/2019#, 4_500_000, 10_000)
            }

            'Dim emp3 As New Programmer("koh", "Alip", DateTime.Now(), 5_600, 100)
            'listEmp.Add(emp3)

            Return listEmp
        End Function

        Public Function FindEmployeeById(listEmps As List(Of Employee), Id As Integer) As Employee Implements IHR.FindEmployeeById
            Dim emp As Employee = Nothing

            For Each list In listEmps
                If (list.EmpId.Equals(Id)) Then
                    emp = list
                End If
            Next

            Return emp
        End Function

        Public Function GetTotalSalary(listEmps As List(Of Employee)) As Double Implements IHR.GetTotalSalary
            Dim total As Double

            For Each emp In listEmps
                total += emp.TotalSalary
            Next

            Return total
        End Function

        Public Function TotalEmployeeByRole(role As String, listEmps As List(Of Employee)) As Integer Implements IHR.TotalEmployeeByRole
            Dim total As Integer

            For Each emp In listEmps
                If TypeName(emp) = role Then
                    total += 1
                End If
            Next

            Return total
        End Function

        Public Function TotalEmployeeSalaryByRole(role As String, listEmps As List(Of Employee)) As Double Implements IHR.TotalEmployeeSalaryByRole
            Dim total As Integer

            For Each emp In listEmps
                If TypeName(emp) = role Then
                    total += emp.TotalSalary
                End If
            Next

            Return total
        End Function
    End Class

End Namespace
