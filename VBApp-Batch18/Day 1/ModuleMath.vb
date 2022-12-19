Imports System.Runtime.InteropServices

Module ModuleMath

    Sub TriangleCount(base As Double, high As Double)
        Dim res As Double

        res = 0.5 * base * high

        Console.WriteLine("Hasil luas segititga dari Alas " & base & " dan tinggi " & high)
        Console.WriteLine("adalah " & res)
    End Sub

    Sub OperationMath()
        Dim y As Double
        y = 12 + (15 + 3) - 2 ^ 3 / 4 * 5
        Console.WriteLine(y)
    End Sub

    Sub BagiSisa()
        Dim num1, num2, bagi, sisa As Double

        Console.Write("enter number 1 : ")
        num1 = Console.ReadLine()
        Console.Write("enter number 2 : ")
        num2 = Console.ReadLine()

        'result
        bagi = num1 \ num2
        sisa = num1 Mod num2

        Console.WriteLine("Hasil bagi : " & bagi & ", dan sisa : " & sisa)


    End Sub



End Module
