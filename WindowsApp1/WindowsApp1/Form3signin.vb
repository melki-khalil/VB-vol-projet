Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports WindowsApp1.Form1
Public Class Form3signin
    Private Sub submit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles signup.Click
        Dim signUp As Form = New Form4make_account
        Form1.Placepage(signUp)
    End Sub
    Dim addClient As Boolean = True
    Private Sub submit_Click_1(sender As Object, e As EventArgs) Handles submit.Click
        If String.IsNullOrEmpty(pasport.Text) Then
            MessageBox.Show("L'email est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        ElseIf Not Form1.IsValidPassport(pasport.Text) Then
            MessageBox.Show("Votre email n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If

        If String.IsNullOrEmpty(pw.Text) Then
            MessageBox.Show("Le mot de passe est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addClient = False
        End If

        If addClient Then
            Dim userList As New List(Of utilisateur)()
            Dim filePath2 As String = "user.bin"
            Using fileStream As New FileStream(filePath2, FileMode.Open)
                Dim formatter As New BinaryFormatter()
                While fileStream.Position < fileStream.Length
                    Dim user As utilisateur = CType(formatter.Deserialize(fileStream), utilisateur)
                    userList.Add(user)
                End While
                For Each user As utilisateur In userList
                    If pasport.Text = user.passportId Then
                        If pw.Text = user.MP Then
                            Form1.user1 = user



                            Form1.Placepage(Form2widget)

                        Else
                            MessageBox.Show("Le passport ou mot de pass n'est pas valid", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Exit For
                        End If

                    End If

                Next
            End Using
        End If

    End Sub
End Class