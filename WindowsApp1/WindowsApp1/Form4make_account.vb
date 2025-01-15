Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Collections.Generic
Imports WindowsApp1.Form1
Imports System.Runtime.Serialization

Public Class Form4make_account


    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        Dim insertClient = True
        Dim addClient As Boolean = True
        'conditions
        If String.IsNullOrEmpty(nom.Text) Then
            MessageBox.Show("Le nom est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        ElseIf Not Form1.IsOnlyLetters(nom.Text) Then
            MessageBox.Show("Utilisez uniquement des lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If

        If String.IsNullOrEmpty(pre.Text) Then
            MessageBox.Show("Le prénom est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        ElseIf Not Form1.IsOnlyLetters(pre.Text) Then
            MessageBox.Show("Utilisez uniquement des lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If

        If String.IsNullOrEmpty(email.Text) Then
            MessageBox.Show("L'email est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        ElseIf Not Form1.IsValidEmail(email.Text) Then
            MessageBox.Show("Votre email n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If

        If String.IsNullOrEmpty(pw.Text) Then
            MessageBox.Show("Le mot de passe est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        ElseIf Not String.Equals(pw.Text, cpw.Text) Then
            MessageBox.Show("Les mots de passe ne correspondent pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If
        If String.IsNullOrEmpty(passport.Text) Then
            MessageBox.Show("Passport code est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        ElseIf Not Form1.IsValidPassport(passport.Text) Then
            MessageBox.Show("Passport code n'est pas vaalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If
        If addClient Then
            Dim newUser As utilisateur
            newUser.passportId = passport.Text
            newUser.email = email.Text
            newUser.nom = nom.Text
            newUser.prenom = pre.Text
            newUser.MP = pw.Text

            If Form1.user1.role = "a" Then
                newUser.role = "a"
            Else
                newUser.role = "u"
            End If

            Dim userList As New List(Of utilisateur)()
            Dim filePath2 As String = "user.bin"
            Using fileStream As New FileStream(filePath2, FileMode.Open)
                Dim formatter As New BinaryFormatter()
                While fileStream.Position < fileStream.Length
                    Dim user As utilisateur = CType(formatter.Deserialize(fileStream), utilisateur)
                    userList.Add(user)
                End While
                For Each user As utilisateur In userList
                    If newUser.passportId = user.passportId Then
                        MessageBox.Show("L'utilisteur si deja exist", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        insertClient = False
                        Exit For
                    End If

                Next
                If insertClient Then
                    formatter.Serialize(fileStream, newUser)
                End If
            End Using








        End If

    End Sub


End Class