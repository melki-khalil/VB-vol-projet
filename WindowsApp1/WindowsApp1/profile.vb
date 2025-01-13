Imports System.Data.SqlClient

Public Class Profile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Use .mdf file for SQL Server
        Dim connectionString As String = "Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ranar\Documents\2IG\VB-vol-projet\WindowsApp1\Aeroport.mdf;Integrated Security=True;Connect Timeout=30"
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()
            MessageBox.Show("Connected to the database.")

            ' Example query
            Dim query As String = "SELECT * FROM YourTable"
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Loop through results
            While reader.Read()
                Console.WriteLine(reader("ColumnName").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
