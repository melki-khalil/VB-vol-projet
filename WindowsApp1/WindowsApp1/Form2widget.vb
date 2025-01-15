Public Class Form2widget
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Brn_eng.Click
        Form1.Placepage(VolCreationvb)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_compt.Click
        Form1.Placepage(UserProfile)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_gestion.Click
        Form1.Placepage(VolConfiguration)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_achat.Click
        Form1.Placepage(TicketBuying)
    End Sub
End Class