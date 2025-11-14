Imports MySql.Data.MySqlClient

Public Class Asistencias
    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")

    Private Sub Asistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCursos()
        CargarMateriasPorCurso(1)
        ' Asegurarse de que el DateTimePicker tenga un valor válido
        DateTimePickerFecha.Value = DateTime.Now
        CargarAlumnosAsistencia(1, 1)
    End Sub

    ' === CARGA DE CURSOS ===
    Private Sub CargarCursos()
        Try
            conexion.Open()
            Dim query As String = "SELECT id, CONCAT(anio, '° Año ', division) AS curso_completo FROM curso;"
            Dim adaptador As New MySqlDataAdapter(query, conexion)
            Dim tablaCursos As New DataTable()
            adaptador.Fill(tablaCursos)

            Cbmnotasalum.DisplayMember = "curso_completo"
            Cbmnotasalum.ValueMember = "id"
            Cbmnotasalum.DataSource = tablaCursos

        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA DE MATERIAS SEGÚN CURSO ===
    Private Sub Cbmnotasalum_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbmnotasalum.SelectionChangeCommitted
        If Cbmnotasalum.SelectedValue IsNot Nothing Then
            CargarMateriasPorCurso(CInt(Cbmnotasalum.SelectedValue))
        End If
    End Sub

    Private Sub CargarMateriasPorCurso(idCurso As Integer)
        Try
            conexion.Open()
            Dim query As String = "SELECT id, nombre FROM materia WHERE id_curso = @idCurso ORDER BY nombre;"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tablaMaterias As New DataTable()
            adaptador.Fill(tablaMaterias)

            cmbMateria.DisplayMember = "nombre"
            cmbMateria.ValueMember = "id"
            cmbMateria.DataSource = tablaMaterias

            DataGridViewAsistencia.DataSource = Nothing

        Catch ex As Exception
            MessageBox.Show("Error al cargar materias: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA DE ASISTENCIA ===
    Private Sub cmbMateria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMateria.SelectionChangeCommitted
        If Cbmnotasalum.SelectedValue IsNot Nothing AndAlso cmbMateria.SelectedValue IsNot Nothing Then
            CargarAlumnosAsistencia(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
        End If
    End Sub

    Private Sub DateTimePickerFecha_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFecha.ValueChanged
        If Cbmnotasalum.SelectedValue IsNot Nothing AndAlso cmbMateria.SelectedValue IsNot Nothing Then
            CargarAlumnosAsistencia(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
        End If
    End Sub

    Private Sub CargarAlumnosAsistencia(idCurso As Integer, idMateria As Integer)
        Try
            conexion.Open()

            Dim fecha As String = DateTimePickerFecha.Value.ToString("yyyy-MM-dd")

            Dim query As String = "
                SELECT a.id AS ID_Alumno,
                       m.id AS ID_Materia,
                       CONCAT(a.apellido, ', ', a.nombre) AS Alumno,
                       IFNULL(asist.asistencia, '') AS Asistencia,
                       IFNULL(asist.conducta, '') AS Conducta,
                       IFNULL(asist.participacion, '') AS Participacion,
                       @fecha AS Fecha
                FROM alumnos a
                INNER JOIN materia m ON m.id_curso = a.id_curso
                LEFT JOIN asistencias asist 
                       ON asist.id_alumnos = a.id
                      AND asist.id_materia = m.id
                      AND asist.fecha = @fecha
                WHERE a.id_curso = @idCurso AND m.id = @idMateria
                ORDER BY a.apellido;
            "

            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)
            comando.Parameters.AddWithValue("@idMateria", idMateria)
            comando.Parameters.AddWithValue("@fecha", fecha)

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DataGridViewAsistencia.DataSource = tabla

            ' Ajustes visuales
            If DataGridViewAsistencia.Columns.Contains("ID_Alumno") Then DataGridViewAsistencia.Columns("ID_Alumno").Visible = False
            If DataGridViewAsistencia.Columns.Contains("ID_Materia") Then DataGridViewAsistencia.Columns("ID_Materia").Visible = False
            If DataGridViewAsistencia.Columns.Contains("Fecha") Then DataGridViewAsistencia.Columns("Fecha").Visible = False
            If DataGridViewAsistencia.Columns.Contains("Alumno") Then DataGridViewAsistencia.Columns("Alumno").Width = 250

        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === GUARDAR ASISTENCIA ===
    Private Sub DataGridViewAsistencia_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAsistencia.CellEndEdit
        ' Solo guardamos si se editó una columna relevante
        Dim nombreCol As String = DataGridViewAsistencia.Columns(e.ColumnIndex).Name
        If nombreCol <> "Asistencia" AndAlso nombreCol <> "Conducta" AndAlso nombreCol <> "Participacion" Then
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim idAlumno As Integer = CInt(DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Alumno").Value)
            Dim idMateria As Integer = CInt(DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Materia").Value)
            Dim fecha As String = DateTimePickerFecha.Value.ToString("yyyy-MM-dd")

            ' Tomamos los valores actuales de la fila (si vienen nulos, los convertimos a "")
            Dim asistencia As String = If(IsDBNull(DataGridViewAsistencia.Rows(e.RowIndex).Cells("Asistencia").Value), "", DataGridViewAsistencia.Rows(e.RowIndex).Cells("Asistencia").Value.ToString())
            Dim conducta As String = If(IsDBNull(DataGridViewAsistencia.Rows(e.RowIndex).Cells("Conducta").Value), "", DataGridViewAsistencia.Rows(e.RowIndex).Cells("Conducta").Value.ToString())
            Dim participacion As String = If(IsDBNull(DataGridViewAsistencia.Rows(e.RowIndex).Cells("Participacion").Value), "", DataGridViewAsistencia.Rows(e.RowIndex).Cells("Participacion").Value.ToString())

            Dim query As String = "
                INSERT INTO asistencias (id_alumnos, id_materia, fecha, asistencia, conducta, participacion)
                VALUES (@id_alumnos, @id_materia, @fecha, @asistencia, @conducta, @participacion)
                ON DUPLICATE KEY UPDATE 
                    asistencia = @asistencia,
                    conducta = @conducta,
                    participacion = @participacion;
            "

            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@id_alumnos", idAlumno)
            comando.Parameters.AddWithValue("@id_materia", idMateria)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@asistencia", asistencia)
            comando.Parameters.AddWithValue("@conducta", conducta)
            comando.Parameters.AddWithValue("@participacion", participacion)

            comando.ExecuteNonQuery()

            ' Opcional: recargar la fila para asegurar coherencia con la BD
            CargarAlumnosAsistencia(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))

        Catch ex As Exception
            MessageBox.Show("Error al guardar asistencia: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
