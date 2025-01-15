Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Microsoft.VisualBasic.ApplicationServices
Imports WindowsApp1
Imports WindowsApp1.Form1
Public Class Form1

    <Serializable> Public Structure utilisateur
        Dim passportId As String
        Dim nom As String
        Dim prenom As String
        Dim email As String
        Dim MP As String
        Dim role As Char

    End Structure
    <Serializable> Public Structure vol
        Dim vol_id As Integer
        Dim vol As String
        Dim depart As String
        Dim destination As String
        Dim temp As DateTime
        Dim prix As Double
    End Structure
    <Serializable> Public Structure buille
        Dim idB As Integer
        Dim vol_id As Integer
        Dim passportId As Integer
        Dim temp As DateTime
        Dim prix As Double

    End Structure
    'function section
    'Vérifiez si la chaîne d'entrée contient uniquement des lettres
    Function IsOnlyLetters(input As String) As Boolean
        Dim letters As String = "^[A-Za-z]+$"
        Return input.All(Function(c) Char.IsLetter(c))
    End Function

    ' Vérifie si la chaîne d'entrée est une adresse e-mail valide
    Function IsValidEmail(email As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern)
    End Function

    ' Vérifie si la chaîne d'entrée est l' id passport est valide
    Function IsValidPassport(input As String) As Boolean
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return (IsNumeric(input) And input.Length = 8)
    End Function

    'end of the function section
    ' public variables
    Public user1 As utilisateur

    'end of section
    'call form method
    Public Sub Placepage(app As Form)
        Panel1.Controls.Clear()
        app.TopLevel = False
        app.FormBorderStyle = FormBorderStyle.None
        app.Dock = DockStyle.Fill
        Panel1.Controls.Add(app)
        app.Show()
    End Sub

    Private Sub Form1main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePath As String = "vol.bin"
        Dim user As utilisateur
        user.passportId = "20254896"
        user.nom = "mazniw"
        user.prenom = "salah"
        user.email = "MazniSAlah@gmail.com"
        user.MP = "password"
        user.role = "a"

        Using fileStream As New FileStream(filePath, FileMode.Open)
            Dim formatter As New BinaryFormatter()

        End Using
        Dim filePath2 As String = "user.bin"
        Using fileStream As New FileStream(filePath2, FileMode.Open)
            Dim formatter As New BinaryFormatter()
            user1 = CType(formatter.Deserialize(fileStream), utilisateur)


        End Using
        Dim filePath3 As String = "buille.bin"
        Using fileStream As New FileStream(filePath3, FileMode.Open)
            Dim formatter As New BinaryFormatter()

        End Using
        If user.email = "" Then
            ProfileToolStripMenuItem.Visible = False
            MonBilleToolStripMenuItem.Visible = False
            LoToolStripMenuItem.Visible = False
        Else
            ProfileToolStripMenuItem.Visible = True
            MonBilleToolStripMenuItem.Visible = True
            LoToolStripMenuItem.Visible = True
        End If
        Placepage(Form2widget)
    End Sub

    Private Sub AccuileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccuileToolStripMenuItem.Click
        Placepage(Form2widget)
    End Sub




    Private Sub ManCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManCompteToolStripMenuItem.Click
        If user1.email = "" Then
            Placepage(Form3signin)

        End If

    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Placepage(UserProfile)
    End Sub
End Class

