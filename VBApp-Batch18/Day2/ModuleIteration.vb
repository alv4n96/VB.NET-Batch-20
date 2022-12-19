Module ModuleIteration

    'Do While'
    Sub DoWhile()
        Dim i As Integer = 1
        Do While i <= 10
            Console.WriteLine(i)
            i += 1
        Loop
    End Sub

    'Do While EXIT'
    Sub DoWhileExit()
        Dim i As Integer = 1
        Do While i <= 10
            If (i = 8) Then
                Exit Do
            Else
                i += 1
            End If
            Console.WriteLine(i)
        Loop
    End Sub

    'For Loop'
    Sub ForLoop()
        Dim num As Integer = 10
        For i = 1 To num
            'For j = 1 To i
            For j = 1 To num - i
                'cetak horizontal'
                Console.Write(i)
            Next
            Console.WriteLine()
        Next
    End Sub

End Module
