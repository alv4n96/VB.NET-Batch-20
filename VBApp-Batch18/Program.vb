Imports System
Imports VBApp_Batch18.PartOne
Imports VBApp_Batch18.PartTwo

Module Program
    Sub Main(args As String())

        ModulePartTwo.InitEmployee()




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
