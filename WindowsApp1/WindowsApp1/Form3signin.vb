Imports WindowsApp1.Form1
Public Class Form3signin
    Private Sub submit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles signup.Click
        Dim signUp As Form = New Form4make_account
        Form1.Placepage(signUp)
    End Sub
End Class