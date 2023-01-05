Imports System.Data.SqlClient

Namespace Day05
    Public Class FirstAdoNet
        Public Shared Sub GetRegion()
            'Call koneksi ke db via connection string
            Dim connectionString As String =
                "Data Source =localhost;Initial Catalog=NorthWind;" &
                "Integrated Security =True"

            Dim sqlRegion As String =
                "SELECT RegionID, RegionDescription FROM dbo.Region " &
                "ORDER BY RegionID DESC;"

            'Create connection ke DB via connection String
            Using cnn As New SqlConnection(connectionString)
                'Create Command
                Dim command As New SqlCommand(sqlRegion, cnn)

                'open Connection
                Try
                    cnn.Open()
                    'Call ExecuteReader then result store in sqldatareader
                    Dim dataReader As SqlDataReader = command.ExecuteReader()

                    Do While dataReader.Read()
                        Console.WriteLine($"RegionId : {dataReader(0)}, RegionDescription : {dataReader(1)}")
                    Loop

                    dataReader.Close()
                    cnn.Close()

                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End Using
        End Sub
    End Class
End Namespace
