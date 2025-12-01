Imports System.Data.SQLite

Public Class login

    ' Variables públicas
    Public Shared profesorApellido As String = ""
    Public Shared secretarioApellido As String = ""

    ' CONEXIÓN A SQLITE
    ' Asegurate que escuela.db esté en la carpeta de la app
    Dim rutaDB As String = Application.StartupPath & "\escuela.db"
    Dim conexion As New SQLiteConnection("Data Source=" & rutaDB & ";Version=3;")

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usuariologin.Text = "USUARIO"
        usuariologin.ForeColor = Color.DimGray
        passwordlogin.Text = "CONTRASEÑA"
        passwordlogin.ForeColor = Color.DimGray
    End Sub

    ' Placeholder usuario
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

    ' Placeholder contraseña
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

    ' ACCEDER
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

            ' ADMINISTRADOR
            Dim cmdAdmin As New SQLiteCommand("SELECT * FROM usuario WHERE usuario=@usuario AND contrasena=@pass", conexion)
            cmdAdmin.Parameters.AddWithValue("@usuario", usuario)
            cmdAdmin.Parameters.AddWithValue("@pass", contrasena)

            Dim readerAdmin As SQLiteDataReader = cmdAdmin.ExecuteReader()

            If readerAdmin.HasRows Then
                readerAdmin.Close()
                conexion.Close()
                Me.Hide()
                Form1.Show()
                Exit Sub
            End If
            readerAdmin.Close()

            ' PROFESOR
            Dim cmdProf As New SQLiteCommand("SELECT apellido, nombre FROM profesores WHERE apellido=@apellido AND dni=@dni", conexion)
            cmdProf.Parameters.AddWithValue("@apellido", usuario)
            cmdProf.Parameters.AddWithValue("@dni", contrasena)

            Dim readerProf As SQLiteDataReader = cmdProf.ExecuteReader()

            If readerProf.Read() Then
                profesorApellido = readerProf("apellido").ToString()
                readerProf.Close()
                conexion.Close()
                Me.Hide()
                FormProfesores.Show()
                Exit Sub
            End If
            readerProf.Close()

            ' SECRETARIO
            Dim cmdSec As New SQLiteCommand("SELECT apellido, nombre FROM secretarios WHERE apellido=@apellido AND dni=@dni", conexion)
            cmdSec.Parameters.AddWithValue("@apellido", usuario)
            cmdSec.Parameters.AddWithValue("@dni", contrasena)

            Dim readerSec As SQLiteDataReader = cmdSec.ExecuteReader()

            If readerSec.Read() Then
                secretarioApellido = readerSec("apellido").ToString()
                readerSec.Close()
                conexion.Close()
                Me.Hide()
                FormSecretarios.Show()
                Exit Sub
            End If
            readerSec.Close()

            ' Ningún rol coincide
            conexion.Close()
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
