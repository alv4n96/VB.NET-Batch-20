Namespace PartTwo
    Module ModuleArray
        Function GetArray() As Integer()
            Dim arr() As Integer = New Integer(2) {1, 2, 3}
            Return arr
        End Function

        Sub DisplayArray()
            Dim arr() As Integer
            arr = GetArray()

            For i = 0 To arr.Length - 1
                Console.Write(($"{arr(i)} "))

            Next
        End Sub

        Sub InitLIstGeneric()
            Dim listCode As New List(Of String) From {"CodeId", "CodeX", "CodingId"}
            For Each list In listCode
                Console.WriteLine(list)
            Next
        End Sub

    End Module
End Namespace
