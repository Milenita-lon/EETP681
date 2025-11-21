Imports MySql.Data.MySqlClient

Public Class login

    ' Variables públicas para guardar datos del login
    Public Shared profesorApellido As String = ""
    Public Shared secretarioApellido As String = ""

    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuariologin.Text = "USUARIO"
        usuariologin.ForeColor = Color.DimGray
        passwordlogin.Text = "CONTRASEÑA"
        passwordlogin.ForeColor = Color.DimGray
    End Sub

    ' Placeholder para usuario
    Private Sub usuariologin_Click(sender As Object, e As EventArgs) Handles usuariologin.Click
        If usuariologin.Text = "USUARIO" Then
            usuariologin.Text = ""
            usuariologin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub usuariologin_Leave(sender As Object, e As EventArgs) Handles usuariologin.Leave
        If String.IsNullOrWhiteSpace(usuariologin.Text) Then
            usuariologin.Text = "USUARIO"
            usuariologin.ForeColor = Color.DimGray
        End If
    End Sub

    ' Placeholder para contraseña
    Private Sub passwordlogin_Click(sender As Object, e As EventArgs) Handles passwordlogin.Click
        If passwordlogin.Text = "CONTRASEÑA" Then
            passwordlogin.Text = ""
            passwordlogin.ForeColor = Color.Black
            passwordlogin.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordlogin_Leave(sender As Object, e As EventArgs) Handles passwordlogin.Leave
        If String.IsNullOrWhiteSpace(passwordlogin.Text) Then
            passwordlogin.Text = "CONTRASEÑA"
            passwordlogin.ForeColor = Color.DimGray
            passwordlogin.UseSystemPasswordChar = False
        End If
    End Sub

    ' Botón cerrar
    Private Sub cerralogin_Click(sender As Object, e As EventArgs) Handles cerralogin.Click
        Me.Close()
    End Sub

    ' Botón acceder
    Private Sub accederlogin_Click(sender As Object, e As EventArgs) Handles accederlogin.Click
        Dim usuario As String = usuariologin.Text.Trim()
        Dim contrasena As String = passwordlogin.Text.Trim()

        If usuario = "" Or usuario = "USUARIO" Or contrasena = "" Or contrasena = "CONTRASEÑA" Then
            MessageBox.Show("Por favor, complete ambos campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conexion.Close()
            conexion.Open()

            ' 1 — Verificar ADMINISTRADOR
            Dim cmdAdmin As New MySqlCommand("SELECT * FROM usuario WHERE usuario=@usuario AND contrasena=@pass", conexion)
            cmdAdmin.Parameters.AddWithValue("@usuario", usuario)
            cmdAdmin.Parameters.AddWithValue("@pass", contrasena)

            Dim readerAdmin As MySqlDataReader = cmdAdmin.ExecuteReader()

            If readerAdmin.HasRows Then
                readerAdmin.Close()
                conexion.Close()
                Me.Hide()
                Form1.Show()
                Exit Sub
            End If
            readerAdmin.Close()

            ' 2 — Verificar PROFESOR
            Dim cmdProf As New MySqlCommand("SELECT apellido, nombre FROM profesores WHERE apellido=@apellido AND dni=@dni", conexion)
            cmdProf.Parameters.AddWithValue("@apellido", usuario)
            cmdProf.Parameters.AddWithValue("@dni", contrasena)

            Dim readerProf As MySqlDataReader = cmdProf.ExecuteReader()

            If readerProf.Read() Then
                profesorApellido = readerProf("apellido").ToString()
                readerProf.Close()
                conexion.Close()
                Me.Hide()
                FormProfesores.Show()
                Exit Sub
            End If
            readerProf.Close()

            ' 3 — Verificar SECRETARIO
            Dim cmdSec As New MySqlCommand("SELECT apellido, nombre FROM secretarios WHERE apellido=@apellido AND dni=@dni", conexion)
            cmdSec.Parameters.AddWithValue("@apellido", usuario)
            cmdSec.Parameters.AddWithValue("@dni", contrasena)

            Dim readerSec As MySqlDataReader = cmdSec.ExecuteReader()

            If readerSec.Read() Then
                secretarioApellido = readerSec("apellido").ToString()
                readerSec.Close()
                conexion.Close()
                Me.Hide()
                FormSecretarios.Show()
                Exit Sub
            End If
            readerSec.Close()

            ' 4 — Si no coincide con ningún rol
            conexion.Close()
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
