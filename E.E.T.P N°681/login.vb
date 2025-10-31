Imports MySql.Data.MySqlClient

Public Class login

    ' Variable pública para guardar el nombre del profesor logueado
    Public Shared profesorApellido As String = ""

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
            conexion.Open()

            ' Primero verificamos si es administrador
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

            ' Si no es admin, verificamos si es profesor
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
            Else
                readerProf.Close()
                conexion.Close()
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

End Class
