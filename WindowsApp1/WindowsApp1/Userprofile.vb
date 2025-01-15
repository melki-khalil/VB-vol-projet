Imports System.Data.SqlClient

Public Class UserProfile




    ' Event handler for form load
    Private Sub UserProfile_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim deleteButtonColumn As New DataGridViewButtonColumn() With {
        .HeaderText = "Action",
        .Text = "Delete",
        .UseColumnTextForButtonValue = True,
        .Name = "DeleteButton"
    }
        DGV.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add a "Delete" button column to the DataGridView



        Dim deleteButtonColumn As New DataGridViewButtonColumn() With {
            .HeaderText = "Action",
            .Text = "Delete",
            .UseColumnTextForButtonValue = True,
            .Name = "DeleteButton"
        }
        DGV.Columns.Add(deleteButtonColumn)

        '
        DGV.Rows.Add("25", "15", "Khalil@melki.com", "Tunisie", "10:30")
        nom.Text += " " + Form1.user1.nom
        prenom.Text += "" + Form1.user1.prenom

    End Sub

    '"Gestionnaire d'événements pour le clic sur une cellule de DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        ' 
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso DGV.Columns(e.ColumnIndex).Name = "DeleteButton" Then
            ' Confirmer la  supperimation
            Dim confirmResult As DialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.Yes Then
                ' Supprimer la ligne
                DGV.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

End Class
