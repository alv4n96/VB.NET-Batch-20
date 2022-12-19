Imports System.ComponentModel

Module ModuleDateTime
    Sub ShowDate()
        Dim date1 As Date = #12/15/2022 10:53:01 AM#

        Console.WriteLine("Date 1 : " & date1)

        Dim currentDate As Date = Date.Now
        currentDate = currentDate.AddDays(2)
        Console.WriteLine("Lusa adalah " & currentDate)

        Dim sDay, sMonth, sYear As Integer
        sDay = Day(currentDate)
        sMonth = Month(currentDate)
        sYear = Year(currentDate)

        Console.WriteLine("Hari " & sDay & " Bulan " & sMonth & " Tahun " & sYear)


    End Sub

End Module
