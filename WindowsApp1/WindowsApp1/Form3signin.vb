Imports WindowsApp1.Form1
Public Class Form3signin
    Private Sub submit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles signup.Click
        Dim signUp As Form = New Form4make_account
        Form1.Placepage(signUp)
    End Sub

    Private Sub submit_Click_1(sender As Object, e As EventArgs) Handles submit.Click
        If String.IsNullOrEmpty(email.Text) Then
            MessageBox.Show("L'email est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Form1.IsValidEmail(email.Text) Then
            MessageBox.Show("Votre email n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If String.IsNullOrEmpty(pw.Text) Then
            MessageBox.Show("Le mot de passe est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class