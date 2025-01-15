Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Microsoft.VisualBasic.ApplicationServices
Imports Org.BouncyCastle
Imports Org.BouncyCastle.Asn1
Imports WindowsApp1.Form1

Public Class VolCreationvb
    Function IsValidId(input As String) As Boolean

        Return input.Length = 4
    End Function
    Function IsValidplaces(input As String) As Boolean

        Return input > 100 And input < 300
    End Function
    Function IsValidprice(input As String) As Boolean

        Return input > 100
    End Function

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim addVol As Boolean = True
        If String.IsNullOrEmpty(ID.Text) Then
            MessageBox.Show("vol id est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        ElseIf Not IsValidId(ID.Text) Then
            addVol = False
            MessageBox.Show("seulment 4 character", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If String.IsNullOrEmpty(Depart.Text) Then
            MessageBox.Show("location de depart est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        ElseIf Not Form1.IsOnlyLetters(Depart.Text) Then
            MessageBox.Show("Utilisez uniquement des lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        End If
        If String.IsNullOrEmpty(dist.Text) Then
            MessageBox.Show("distination est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        ElseIf Not Form1.IsOnlyLetters(dist.Text) Then
            MessageBox.Show("Utilisez uniquement des lettres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        End If
        Dim places As Integer = Convert.ToInt32(nb.Text)
        If String.IsNullOrEmpty(nb.Text) Then
            MessageBox.Show("nomber de places est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        ElseIf Not IsValidplaces(places) Then
            MessageBox.Show("nomber des place invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        End If

        Dim price = Convert.ToDouble(prix.Text)
        If String.IsNullOrEmpty(prix.Text) Then
            MessageBox.Show("prix est obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        ElseIf Not IsValidprice(price) Then
            MessageBox.Show("prix unvalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            addVol = False
        End If
        If addVol Then

            Dim newVol As vol
            newVol.vol_id = ID.Text
            newVol.depart = Depart.Text
            newVol.destination = dist.Text
            newVol.places = places
            newVol.prix = price
            Dim insertVol As Boolean = True
            Dim filePath As String = "vol.bin"

            Dim volList As New List(Of vol)()
            Using fileStream As New FileStream(filePath, FileMode.Open)
                Dim formatter As New BinaryFormatter()
                While fileStream.Position < fileStream.Length
                    Dim vol1 As vol = CType(formatter.Deserialize(fileStream), vol)
                    volList.Add(vol1)
                End While
                For Each vol1 As vol In volList
                    If newVol.vol_id = vol1.vol_id Then
                        MessageBox.Show("Le volume existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        insertVol = False
                        Exit For
                    End If
                Next

                If insertVol Then
                    formatter.Serialize(fileStream, newvol)
                End If
            End Using
        End If
    End Sub

End Class