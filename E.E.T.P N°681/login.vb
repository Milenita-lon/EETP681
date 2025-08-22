Public Class login
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        usuariologin.Text = "USUARIO"
        usuariologin.ForeColor = Color.DimGray

        passwordlogin.Text = "CONTRASEÑA"
        passwordlogin.ForeColor = Color.DimGray

    End Sub

    'placeholder para usuario'
    Private Sub usuariologin_Click(sender As Object, e As EventArgs) Handles usuariologin.Click

        If usuariologin.Text = "USUARIO" Then
            usuariologin.Text = ""
            usuariologin.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub usuariologin_Leave(sender As Object, e As EventArgs) Handles usuariologin.Leave

        If String.IsNullOrWhiteSpace(usuariologin.Text) Then
            usuariologin.Text = "USUARIO"
            usuariologin.ForeColor = Color.Gray
        End If
    End Sub

    'placeholder para contraseña'
    Private Sub passwordlogin_Click(sender As Object, e As EventArgs) Handles passwordlogin.Click

        If passwordlogin.Text = "CONTRASEÑA" Then
            passwordlogin.Text = ""
            passwordlogin.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub passwordlogin_Leave(sender As Object, e As EventArgs) Handles passwordlogin.Leave

        If String.IsNullOrWhiteSpace(passwordlogin.Text) Then
            passwordlogin.Text = "CONTRASEÑA"
            passwordlogin.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub cerralogin_Click(sender As Object, e As EventArgs) Handles cerralogin.Click
        Me.Close()
    End Sub


    Private Sub accederlogin_Click(sender As Object, e As EventArgs) Handles accederlogin.Click
        Form1.Show()
    End Sub
End Class