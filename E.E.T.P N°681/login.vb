Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cerralogin_Click(sender As Object, e As EventArgs) Handles cerralogin.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usuariologin.TextChanged

    End Sub

    Private Sub accederlogin_Click(sender As Object, e As EventArgs) Handles accederlogin.Click
        Form1.Show()
    End Sub
End Class