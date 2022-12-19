Namespace PartTwo
    Module ModulePartTwo
        Sub InitEmployee()
            'create object employee with encapsulation
            Dim emp1 As New Employee(1, "Kang", "Dian", DateTime.Now, 5_000)
            Console.WriteLine(emp1.ToString())

            Console.WriteLine()

            emp1.FirstName = "Code"
            emp1.BasicSalary = 6_000
            Console.WriteLine(emp1.ToString())

            Console.WriteLine()

            Dim emp2 As New Employee("koh", "Ericson", DateTime.Now(), 5_500)
            Console.WriteLine(emp2.ToString())

            Console.WriteLine()

            'create obj programmer
            Dim emp3 As New Programmer("koh", "Alip", DateTime.Now(), 5_600, 100)
            Console.WriteLine(emp3.ToString())

            Console.WriteLine()

            emp3.BasicSalary = 5_000
            Console.WriteLine(emp3.ToString())

            Console.WriteLine()

            emp3.Transportasi = 250
            emp3.BasicSalary = 7_000
            Console.WriteLine(emp3.ToString())
            Console.WriteLine()

            emp3.BasicSalary = 7_000
            emp3.Transportasi = 500
            Console.WriteLine(emp3.ToString())


        End Sub
    End Module
End Namespace
