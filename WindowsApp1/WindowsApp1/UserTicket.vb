Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports WindowsApp1.Form1

Public Class UserTicket

    ' Event handler for form load


    Private Sub UserTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add a "Delete" button column to the DataGridView
        Dim deleteButtonColumn As New DataGridViewButtonColumn() With {
            .HeaderText = "Action",
            .Text = "Delete",
            .UseColumnTextForButtonValue = True,
            .Name = "DeleteButton"
        }
        DGV.Columns.Add(deleteButtonColumn)
        DGV.Dock = DockStyle.Fill
        ' Read the data from the file and add rows to the DataGridView
        Dim ticketList As New List(Of buille)()
        Dim filePath3 As String = "buille.bin"
        Using fileStream As New FileStream(filePath3, FileMode.Open)
            Dim formatter As New BinaryFormatter()
            While fileStream.Position < fileStream.Length
                Dim ticket As buille = CType(formatter.Deserialize(fileStream), buille)
                ticketList.Add(ticket)
            End While


            For Each ticket As buille In ticketList
                If Form1.user1.passportId = ticket.passportId Then
                    DGV.Rows.Add(ticket.idB, ticket.vol_id, ticket.passportId, ticket.distination, ticket.prix)
                End If


            Next
        End Using

    End Sub

    ' Event handler for DataGridView cell click
    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso DGV.Columns(e.ColumnIndex).Name = "DeleteButton" Then
            ' Confirm deletion
            Dim confirmResult As DialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo)

            Dim filePath3 As String = "buille.bin"
            Using fileStream As New FileStream(filePath3, FileMode.Open)
                Dim formatter As New BinaryFormatter()

            End Using
        End If
    End Sub

    



    ' Event handler for navigating to another page

End Class
