Namespace PartTwo
    Public Class QA
        Inherits Employee
        Private _makan As Double

        Public Sub New(firstName As String, lastName As String,
                       joinDate As Date, basicSalary As Double,
                       Optional makan As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            Me.Makan = makan
            MyBase.TotalSalary = MyBase.TotalSalary + makan
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}
TjMakan         : {Makan},
Total Salary    : {TotalSalary}"
        End Function

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Makan
            End Set
        End Property

        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
                TotalSalary = value + BasicSalary
            End Set
        End Property
    End Class
End Namespace
