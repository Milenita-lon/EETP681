Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Alumnos

    ' Cadena de conexión (cambiá los valores a los de tu servidor)
    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Open()

            ' Traemos los cursos
            Dim query As String = "SELECT id, anio, division FROM curso;"
            Dim comando As New MySqlCommand(query, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox1.DisplayMember = "anio" + "division"
            ComboBox1.ValueMember = "id"

            Dim tablaCursos As New DataTable()
            tablaCursos.Load(lector)

            ComboBox1.DataSource = tablaCursos

            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al conectar con MySQL: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' Cuando cambia el curso seleccionado, cargamos alumnos
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing AndAlso IsNumeric(ComboBox1.SelectedValue) Then
            CargarAlumnos(CInt(ComboBox1.SelectedValue))
        End If
    End Sub

    Private Sub CargarAlumnos(idCurso As Integer)
        Try
            conexion.Open()

            ' Traemos todos los campos de alumnos para ese curso
            Dim query As String = "SELECT nombre, apellido, dni, direccion, telefono, correo 
                                   FROM alumnos 
                                   WHERE id_curso = @idCurso;"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tablaAlumnos As New DataTable()
            adaptador.Fill(tablaAlumnos)

            DataGridView1.DataSource = tablaAlumnos

        Catch ex As Exception
            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class