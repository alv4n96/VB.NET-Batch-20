Imports System
Imports VBApp_Batch18.PartOne
Imports VBApp_Batch18.PartTwo

Module Program
    Sub Main(args As String())

        ModulePartTwo.InitEmployee()


        'ModuleArray.DisplayArray()




        'Dim num1 As Double
        'num1 = 10
        'Dim num2 As Double
        'num2 = 4
        'Console.WriteLine("Hello World!")

        'ModuleDecision.OddEvenNumber()
        'ModuleDecision.GradeIfElse()
        'ModuleDecision.GradeCase()
        'ModuleDecision.WhoIsTheGreatest()

        'ModuleDateTime.ShowDate()

        'ModuleIteration.DoWhileExit()
        'ModuleIteration.ForLoop()


        'call method SayMyName'
        'SayMyName()

        'call method from module variable'
        'ModuleVariable.StoreConstant()

        'ModuleVariable.SwapTwoVariable()

        'ModuleMath.TriangleCount(num1, num2)

        'ModuleMath.OperationMath()

        'ModuleMath.BagiSisa()

        'Call interface & implementation
        'Interface Kiri & Implementation Kanan
        'Dim IHr As IHR = New HR

        'Dim listEmp = IHr.InitEmployee()

        'IHr.DisplayEmployee(listEmp)
        ''Dim emp = IHr.FindEmployeeById(listEmp, 1)
        'Console.WriteLine()
        'Console.WriteLine($"Total Salary all employees : {IHr.GetTotalSalary(listEmp)}")
        'Console.WriteLine()
        'Console.WriteLine($"Total Employee Programmer : {IHr.TotalEmployeeByRole(role:="Programmer", listEmps:=listEmp)}")
        'Console.WriteLine($"Total Employee Sales : {IHr.TotalEmployeeByRole(role:="Sales", listEmps:=listEmp)}")
        'Console.WriteLine($"Total Employee QA : {IHr.TotalEmployeeByRole(role:="QA", listEmps:=listEmp)}")
        'Console.WriteLine()
        'Console.WriteLine($"Total Salary By Role is Programmer : {IHr.TotalEmployeeSalaryByRole(role:="Programmer", listEmps:=listEmp)}")
        'Console.WriteLine($"Total Salary By Role is Sales : {IHr.TotalEmployeeSalaryByRole(role:="Sales", listEmps:=listEmp)}")
        'Console.WriteLine($"Total Salary By Role is QA : {IHr.TotalEmployeeSalaryByRole(role:="QA", listEmps:=listEmp)}")
        'Console.WriteLine()

        'If emp IsNot Nothing Then
        '    Console.WriteLine($"Employee Found : {emp}")
        'Else
        '    Console.WriteLine("Employee NOT FOUND!")
        'End If

    End Sub

    Sub SayMyName()
        'declaration variable'
        Dim myName As String
        Console.Write("Enter your name : ")
        myName = Console.ReadLine

        'display result'
        Console.WriteLine("Your name : " & myName)
    End Sub
End Module
