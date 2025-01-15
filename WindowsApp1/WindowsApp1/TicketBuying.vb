Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports WindowsApp1.Form1
Public Class TicketBuying


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Create a new button column
        Dim btnAdd As New DataGridViewButtonColumn()
        btnAdd.HeaderText = "Action"
        btnAdd.Name = "AddButton"
        btnAdd.Text = "Acheter"
        btnAdd.UseColumnTextForButtonValue = True

        DGVT.Columns.Add(btnAdd)



    End Sub

    ' Handle the button click event
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVT.CellContentClick
        ' Check if the clicked cell is part of the button column
        If e.ColumnIndex = DGVT.Columns("AddButton").Index AndAlso e.RowIndex >= 0 Then
            Dim newticket As buille
            Dim selectedRow As DataGridViewRow = DGVT.Rows(e.RowIndex)
            newticket.vol_id = selectedRow.Cells("id").Value.ToString()
            newticket.distination = selectedRow.Cells("distination").Value.ToString()
            newticket.passportId = Form1.user1.passportId
            newticket.prix = selectedRow.Cells("prix").Value.ToString()

            Dim ticketList As New List(Of buille)()
            Dim filePath3 As String = "buille.bin"
            Using fileStream As New FileStream(filePath3, FileMode.Open)
                Dim formatter As New BinaryFormatter()
                While fileStream.Position < fileStream.Length
                    Dim ticket As buille = CType(formatter.Deserialize(fileStream), buille)
                    ticketList.Add(ticket)
                End While
                Dim rnd As New Random()
                newticket.idB = rnd.Next(100, 10000)

                For Each ticket As buille In ticketList
                    While newticket.idB = ticket.idB
                        newticket.idB = rnd.Next(100, 10000)
                    End While


                Next
                formatter.Serialize(fileStream, newticket)
            End Using


            MessageBox.Show($": {newticket.vol_id}, with the name: {newticket.idB} has been added ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub find_Click(sender As Object, e As EventArgs) Handles find.Click
        DGVT.Rows.Clear()

        Dim distination As String = lock.Text
        Dim filePath As String = "vol.bin"

        Dim volList As New List(Of vol)()
        Using fileStream As New FileStream(filePath, FileMode.Open)
            Dim formatter As New BinaryFormatter()
            While fileStream.Position < fileStream.Length
                Dim vol1 As vol = CType(formatter.Deserialize(fileStream), vol)
                volList.Add(vol1)
            End While

            For Each vol1 As vol In volList
                If distination = "" Then
                    DGVT.Rows.Add(vol1.vol_id, vol1.depart, vol1.destination, vol1.places, vol1.prix)

                ElseIf distination = vol1.destination Then
                    DGVT.Rows.Add(vol1.vol_id, vol1.depart, vol1.destination, vol1.places, vol1.prix)

                End If
            Next
        End Using
    End Sub
End Class