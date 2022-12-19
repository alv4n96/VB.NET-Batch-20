Module ModuleDecision

    Sub OddEvenNumber()
        Dim num As Integer

        Console.Write("Masukkan angka : ")
        num = Console.ReadLine()

        If num Mod 2 = 0 Then
            Console.WriteLine("Angka Genap")
        Else
            Console.WriteLine("Angka Ganjil")
        End If
    End Sub

    Sub GradeIfElse()
        Dim grade As Integer
        Console.Write("Masukkan nilai : ")
        grade = Console.ReadLine()

        If grade < 50 Then
            Console.WriteLine("E")
        ElseIf (grade >= 50) And (grade <= 60) Then
            Console.WriteLine("D")
        Else
            Console.WriteLine("Gagal")
        End If
    End Sub

    Sub GradeCase()
        Dim grade As Integer
        Console.Write("Masukkan Nilai : ")
        grade = Console.ReadLine()

        Select Case grade
            Case <= 50
                Console.WriteLine("F")
            Case 51 To 60
                Console.WriteLine("E")
            Case 61 To 70
                Console.WriteLine("D")
            Case 71 To 80
                Console.WriteLine("B")
            Case 81 To 90
                Console.WriteLine("A")
            Case 91 To 100
                Console.WriteLine("A+")
            Case Else
                Console.WriteLine("Masukkan nilai yang sesuai!")
        End Select
    End Sub

    Sub WhoIsTheGreatest()
        Dim num As Integer
        Dim rnd As New Random()
        Console.Write("Masukkan nilai antara (1-10) : ")
        num = Console.ReadLine()

        If (num > 10) Or (num < 0) Then
            Console.WriteLine("Masukkan nilai yang sesuai!")
        Else
            Dim guess As Integer = rnd.NextInt64(1, 11)
            Console.WriteLine("Your input : " & num & vbCrLf & "and computer got : " & guess)
            If (num > guess) Then
                Console.WriteLine("You Win!")
            ElseIf (num = guess) Then
                Console.WriteLine("It's Draw!")
            Else
                Console.WriteLine("Computer Win!")
            End If
        End If

    End Sub
End Module
