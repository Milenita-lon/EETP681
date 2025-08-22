Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Alumnos

    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Open()

            ' Construimos el texto del curso como "3° Año A"
            Dim query As String = "SELECT id, 
                                          CONCAT(anio, '° Año ', division) AS curso_completo 
                                   FROM curso;"
            Dim comando As New MySqlCommand(query, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            Dim tablaCursos As New DataTable()
            tablaCursos.Load(lector)

            ' Configuración del ComboBox
            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox1.DisplayMember = "curso_completo" ' lo que se ve (ej: "3° Año A")
            ComboBox1.ValueMember = "id"        ' valor real (id_curso)
            ComboBox1.DataSource = tablaCursos

            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' Cuando cambia el curso seleccionado → mostramos alumnos
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing AndAlso IsNumeric(ComboBox1.SelectedValue) Then
            CargarAlumnos(CInt(ComboBox1.SelectedValue))
        End If
    End Sub

    Private Sub CargarAlumnos(idCurso As Integer)
        Try
            conexion.Open()
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
