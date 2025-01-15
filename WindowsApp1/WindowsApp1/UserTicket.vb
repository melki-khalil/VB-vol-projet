Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

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
        ' Add sample data to the DataGridView
        Dim ticket1 As Form1.buille
        ticket1.idB = 125
        ticket1.vol_id = 515
        ticket1.passportId = "25413625"
        ticket1.distination = "France"
        ticket1.prix = 521.0
        DGV.Rows.Add(ticket1.idB, ticket1.vol_id, ticket1.passportId, ticket1.distination, ticket1.prix)

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
