Imports System.Data.SQLite

Public Class Asistencias

    Dim conexion As New SQLiteConnection("Data Source=escuela.db;Version=3;")

    Private Sub Asistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCursos()
        CargarMateriasPorCurso(1)
        DateTimePickerFecha.Value = DateTime.Now
        CargarAlumnosAsistencia(1, 1)
    End Sub

    ' === CARGA CURSOS ===
    Private Sub CargarCursos()
        Try
            conexion.Open()
            Dim query As String = "SELECT id, (anio || '° Año ' || division) AS curso_completo FROM curso;"
            Dim adaptador As New SQLiteDataAdapter(query, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            Cbmnotasalum.DisplayMember = "curso_completo"
            Cbmnotasalum.ValueMember = "id"
            Cbmnotasalum.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA MATERIAS ===
    Private Sub CargarMateriasPorCurso(idCurso As Integer)
        Try
            conexion.Open()

            Dim query As String =
                "SELECT id, nombre 
                 FROM materia 
                 WHERE id_curso = @idCurso 
                 ORDER BY nombre;"

            Dim comando As New SQLiteCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)

            Dim adaptador As New SQLiteDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            cmbMateria.DisplayMember = "nombre"
            cmbMateria.ValueMember = "id"
            cmbMateria.DataSource = tabla

            DataGridViewAsistencia.DataSource = Nothing

        Catch ex As Exception
            MessageBox.Show("Error al cargar materias: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA ASISTENCIA ===
    Private Sub CargarAlumnosAsistencia(idCurso As Integer, idMateria As Integer)
        Try
            conexion.Open()

            Dim fecha = DateTimePickerFecha.Value.ToString("yyyy-MM-dd")

            Dim query As String =
                "SELECT a.id AS ID_Alumno,
                        m.id AS ID_Materia,
                        (a.apellido || ', ' || a.nombre) AS Alumno,
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
                 WHERE a.id_curso = @idCurso
                   AND m.id = @idMateria
                 ORDER BY a.apellido;"

            Dim comando As New SQLiteCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)
            comando.Parameters.AddWithValue("@idMateria", idMateria)
            comando.Parameters.AddWithValue("@fecha", fecha)

            Dim adaptador As New SQLiteDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DataGridViewAsistencia.DataSource = tabla

            If DataGridViewAsistencia.Columns.Contains("ID_Alumno") Then DataGridViewAsistencia.Columns("ID_Alumno").Visible = False
            If DataGridViewAsistencia.Columns.Contains("ID_Materia") Then DataGridViewAsistencia.Columns("ID_Materia").Visible = False
            If DataGridViewAsistencia.Columns.Contains("Fecha") Then DataGridViewAsistencia.Columns("Fecha").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error al cargar asistencia: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === GUARDAR ASISTENCIA (SQLite no tiene ON DUPLICATE) ===
    Private Sub DataGridViewAsistencia_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) _
        Handles DataGridViewAsistencia.CellEndEdit

        Dim col = DataGridViewAsistencia.Columns(e.ColumnIndex).Name
        If col <> "Asistencia" AndAlso col <> "Conducta" AndAlso col <> "Participacion" Then
            Exit Sub
        End If

        Try
            conexion.Open()

            Dim idAlumno As Integer = DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Alumno").Value
            Dim idMateria As Integer = DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Materia").Value
            Dim fecha As String = DateTimePickerFecha.Value.ToString("yyyy-MM-dd")

            Dim asistencia = DataGridViewAsistencia.Rows(e.RowIndex).Cells("Asistencia").Value?.ToString()
            Dim conducta = DataGridViewAsistencia.Rows(e.RowIndex).Cells("Conducta").Value?.ToString()
            Dim participacion = DataGridViewAsistencia.Rows(e.RowIndex).Cells("Participacion").Value?.ToString()

            ' =====================================
            '   INSERT OR REPLACE → funciona como
            '   ON DUPLICATE KEY UPDATE
            ' =====================================
            Dim query As String =
                "INSERT OR REPLACE INTO asistencias
                (id_alumnos, id_materia, fecha, asistencia, conducta, participacion)
                 VALUES
                (@id_alumnos, @id_materia, @fecha, @asistencia, @conducta, @participacion);"

            Dim comando As New SQLiteCommand(query, conexion)
            comando.Parameters.AddWithValue("@id_alumnos", idAlumno)
            comando.Parameters.AddWithValue("@id_materia", idMateria)
            comando.Parameters.AddWithValue("@fecha", fecha)
            comando.Parameters.AddWithValue("@asistencia", asistencia)
            comando.Parameters.AddWithValue("@conducta", conducta)
            comando.Parameters.AddWithValue("@participacion", participacion)

            comando.ExecuteNonQuery()

            CargarAlumnosAsistencia(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))

        Catch ex As Exception
            MessageBox.Show("Error al guardar asistencia: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

End Class
