Public Class Form4
    Public Player1 As String
    Public Player2 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player1 = TextBox1.Text
        Player2 = TextBox2.Text
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class