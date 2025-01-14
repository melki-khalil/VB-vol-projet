Public Class Form4make_account


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If String.IsNullOrEmpty(nom.Text) Then
            MessageBox.Show("Le nom est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Form1.IsOnlyLetters(nom.Text) Then
            MessageBox.Show("Utilisez uniquement des lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If String.IsNullOrEmpty(pre.Text) Then
            MessageBox.Show("Le prénom est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Form1.IsOnlyLetters(pre.Text) Then
            MessageBox.Show("Utilisez uniquement des lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If String.IsNullOrEmpty(email.Text) Then
            MessageBox.Show("L'email est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not Form1.IsValidEmail(email.Text) Then
            MessageBox.Show("Votre email n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If String.IsNullOrEmpty(pw.Text) Then
            MessageBox.Show("Le mot de passe est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf Not String.Equals(pw.Text, cpw.Text) Then
            MessageBox.Show("Les mots de passe ne correspondent pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub
End Class