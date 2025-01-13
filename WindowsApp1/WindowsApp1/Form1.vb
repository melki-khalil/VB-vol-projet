Imports WindowsApp1
Public Class Form1

    Public Structure utilisateur
        Dim nom As String
        Dim prenom As String
        Dim email As String
        Dim MP As String
        Dim role As Char
    End Structure
    Public Structure vol
        Dim vol_id As Integer
        Dim vol As String
        Dim depart As String
        Dim destination As String
        Dim temp As DateTime
    End Structure

    Dim user As utilisateur
    Public Sub Placepage(app As Form)
        Panel1.Controls.Clear()
        app.TopLevel = False
        app.FormBorderStyle = FormBorderStyle.None
        app.Dock = DockStyle.Fill
        Panel1.Controls.Add(app)
        app.Show()
    End Sub

    Private Sub Form1main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If user.email = "" Then
            Placepage(profile)
        Else
            Placepage(Form3signin)
        End If

    End Sub
End Class
