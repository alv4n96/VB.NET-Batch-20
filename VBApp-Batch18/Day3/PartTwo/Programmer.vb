Namespace PartTwo
    Public Class Programmer : Inherits Employee

        Private _transportasi As Double

        Public Sub New(firstName As String, lastName As String,
                       joinDate As Date, basicSalary As Double,
                       Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.TotalSalary + transportasi
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}
TjTransportasi  : {Transportasi},
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

        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = value + BasicSalary
            End Set
        End Property

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Transportasi
            End Set
        End Property

    End Class
End Namespace
