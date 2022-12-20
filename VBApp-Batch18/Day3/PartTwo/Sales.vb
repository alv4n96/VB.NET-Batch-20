Namespace PartTwo
    Public Class Sales : Inherits Employee

        Private _bonus As Double
        Private _commission As Double

        Public Sub New(firstName As String, lastName As String,
                       joinDate As Date, basicSalary As Double,
                       Optional bonus As Double = Nothing,
                       Optional commission As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _bonus = bonus
            _commission = commission
            MyBase.TotalSalary = MyBase.TotalSalary + bonus + commission
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}
Bonus           : {Bonus},
Comission       : {Commission},
Nett Salary     : {Nett()},
Gross Salary    : {Gross()},
Total Salary    : {TotalSalary}"
        End Function

        Public Overrides Function Gross() As Double
            Static grossSalary = TotalSalary

            Return grossSalary
        End Function

        Public Overrides Function Nett() As Double
            Static pph = 0.1 * TotalSalary
            Static ppn = 0.2 * TotalSalary
            Static nettSalary = TotalSalary - (pph + ppn)

            Return nettSalary
        End Function

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Commission + Bonus
            End Set
        End Property

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                TotalSalary = value + Commission + BasicSalary
            End Set
        End Property

        Public Property Commission As Double
            Get
                Return _commission
            End Get
            Set(value As Double)
                _commission = value
                TotalSalary = value + Bonus + BasicSalary
            End Set
        End Property
    End Class
End Namespace
