Imports System.Data.SqlClient

Public Class UserProfile






    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passport.Text += ": " + Form1.user1.nom
        nom.Text += ": " + Form1.user1.nom
        prenom.Text += ": " + Form1.user1.prenom
        If Form1.user1.role = "a" Then
            ticket.Visible = False
        Else
            addAdmin.Visible = False
        End If

    End Sub


    Private Sub ticket_Click(sender As Object, e As EventArgs) Handles ticket.Click
        Form1.Placepage(UserTicket)
    End Sub

    Private Sub addAdmin_Click(sender As Object, e As EventArgs) Handles addAdmin.Click
        Form1.Placepage(Form4make_account)
    End Sub
End Class
