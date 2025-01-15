Imports WindowsApp1.Form1
Public Class Form2widget

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Brn_eng.Click
        If Form1.user1.role = "a" Then

            Form1.Placepage(VolCreationvb)
        Else
            MessageBox.Show("vous n'avey pas privilèges d'administrateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_compt.Click
        If Form1.user1.passportId = "" Then
            Form1.Placepage(Form3signin)
        Else
            Form1.Placepage(UserProfile)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_gestion.Click
        If Form1.user1.role = "a" Then

            Form1.Placepage(VolConfiguration)
        Else
            MessageBox.Show("vous n'avey pas privilèges d'administrateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_achat.Click
        Form1.Placepage(TicketBuying)
    End Sub
End Class