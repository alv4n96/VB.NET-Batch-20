Module ModuleVariable

    'Primitive Data Type : '

    Sub StoreVariable()
        Dim number As Integer = 200
        Dim myName As String = "BootCamp .NET"

        Console.WriteLine("Number : " & number & ", My Name : " & myName)

    End Sub
    Sub StoreConstant()
        Const PHI = 3.14159

        Console.WriteLine("Phi : " & PHI)

    End Sub

    Sub SwapTwoVariable()
        Dim a, b, c, temp As Integer

        Console.Write("Value A : ")
        a = Console.ReadLine()

        Console.Write("Value B : ")
        b = Console.ReadLine()

        Console.Write("Value C : ")
        c = Console.ReadLine()

        Console.WriteLine("Before a = " & a & ", b = " & b & ", c = " & c)
        temp = c
        c = a
        a = b
        b = temp
        Console.WriteLine("Before a = " & a & ", b = " & b & ", c = " & c)

    End Sub
End Module
