Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports WindowsApp1.Form1

Public Class VolConfiguration
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Add "Delete" button column
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.HeaderText = "Delete"
        deleteButton.Name = "DeleteButton"
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        DGVC.Columns.Add(deleteButton)

        ' Add "Modify" button column
        Dim modifyButton As New DataGridViewButtonColumn()
        modifyButton.HeaderText = "Modify"
        modifyButton.Name = "ModifyButton"
        modifyButton.Text = "Modify"
        modifyButton.UseColumnTextForButtonValue = True
        DGVC.Columns.Add(modifyButton)

        ' Read the data from the file and add rows to the DataGridView
        Dim filePath As String = "vol.bin"
        Dim volList As New List(Of vol)()

        Using fileStream As New FileStream(filePath, FileMode.Open)
            Dim formatter As New BinaryFormatter()
            While fileStream.Position < fileStream.Length
                Dim vol1 As vol = CType(formatter.Deserialize(fileStream), vol)
                volList.Add(vol1)
            End While

            For Each vol1 As vol In volList
                DGVC.Rows.Add(vol1.vol_id, vol1.depart, vol1.destination, vol1.places, vol1.prix)
            Next
        End Using
    End Sub

    Private Sub DGVC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVC.CellContentClick

        ' Handle Delete button
        If e.ColumnIndex = DGVC.Columns("DeleteButton").Index Then
            DGVC.Rows.RemoveAt(e.RowIndex) ' Remove the selected row
            MessageBox.Show("Row deleted.", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ' Handle Modify button
        If e.ColumnIndex = DGVC.Columns("ModifyButton").Index Then

            Form1.Placepage(VolCreationvb)
        End If

    End Sub

End Class