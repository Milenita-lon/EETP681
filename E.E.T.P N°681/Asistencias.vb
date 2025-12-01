Imports System.Data.SQLite

Public Class Asistencias

    Dim conexion As New SQLiteConnection("Data Source=escuela.db;Version=3;")

    Private Sub Asistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Asegurar índice único para que INSERT OR REPLACE/UPSERT funcione
            EnsureUniqueIndexForAsistencias()

            CargarCursos()

            ' Seleccionar primer curso si existe
            If Cbmnotasalum.Items.Count > 0 Then
                Cbmnotasalum.SelectedIndex = 0
            End If

            ' Cargar materias para el curso seleccionado (si existe)
            Dim idCursoDefault As Integer = If(Cbmnotasalum.SelectedValue IsNot Nothing AndAlso IsNumeric(Cbmnotasalum.SelectedValue),
                                               CInt(Cbmnotasalum.SelectedValue), 1)
            CargarMateriasPorCurso(idCursoDefault)

            ' Seleccionar primera materia si existe
            If cmbMateria.Items.Count > 0 Then
                cmbMateria.SelectedIndex = 0
            End If

            DateTimePickerFecha.Value = DateTime.Now

            ' Cargar asistencia con valores seleccionados si están disponibles
            Dim idMat As Integer = If(cmbMateria.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbMateria.SelectedValue), CInt(cmbMateria.SelectedValue), idCursoDefault)
            Dim idCur As Integer = If(Cbmnotasalum.SelectedValue IsNot Nothing AndAlso IsNumeric(Cbmnotasalum.SelectedValue), CInt(Cbmnotasalum.SelectedValue), idCursoDefault)
            CargarAlumnosAsistencia(idCur, idMat)

        Catch ex As Exception
            Debug.WriteLine("Asistencias_Load(): " & ex.Message)
        End Try

    End Sub

    ' Asegura que exista un índice único sobre (id_alumnos,id_materia,fecha)
    Private Sub EnsureUniqueIndexForAsistencias()
        Try
            conexion.Open()
            Dim sql As String = "CREATE UNIQUE INDEX IF NOT EXISTS idx_asistencias_unique ON asistencias(id_alumnos, id_materia, fecha);"
            Using cmd As New SQLiteCommand(sql, conexion)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' No fatal, sólo informar para debug
            Debug.WriteLine("No se pudo crear índice único: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA CURSOS ===
    Private Sub CargarCursos()
        Try
            conexion.Open()

            Dim query As String =
                "SELECT id, (anio || '° ' || division) AS curso_completo
                 FROM curso
                 ORDER BY anio, division;"

            Dim adaptador As New SQLiteDataAdapter(query, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            Cbmnotasalum.DisplayMember = "curso_completo"
            Cbmnotasalum.ValueMember = "id"
            Cbmnotasalum.DataSource = tabla

        Catch ex As Exception
            Debug.WriteLine("CargarCursos(): " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

    ' === evento: cuando cambia curso, recargar materias y asistencia ===
    Private Sub Cbmnotasalum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbmnotasalum.SelectedIndexChanged
        If Cbmnotasalum.SelectedValue Is Nothing OrElse Not IsNumeric(Cbmnotasalum.SelectedValue) Then
            Return
        End If

        Dim idCurso As Integer = CInt(Cbmnotasalum.SelectedValue)
        CargarMateriasPorCurso(idCurso)

        ' seleccionar primera materia si existe
        If cmbMateria.Items.Count > 0 Then
            cmbMateria.SelectedIndex = 0
        End If

        If cmbMateria.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbMateria.SelectedValue) Then
            CargarAlumnosAsistencia(idCurso, CInt(cmbMateria.SelectedValue))
        End If
    End Sub

    ' === evento: cuando cambia materia, recargar asistencia ===
    Private Sub cmbMateria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMateria.SelectedIndexChanged
        If Cbmnotasalum.SelectedValue Is Nothing OrElse cmbMateria.SelectedValue Is Nothing Then Return
        If Not IsNumeric(Cbmnotasalum.SelectedValue) OrElse Not IsNumeric(cmbMateria.SelectedValue) Then Return

        CargarAlumnosAsistencia(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
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

            Using comando As New SQLiteCommand(query, conexion)
                comando.Parameters.AddWithValue("@idCurso", idCurso)

                Dim adaptador As New SQLiteDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)

                cmbMateria.DisplayMember = "nombre"
                cmbMateria.ValueMember = "id"
                cmbMateria.DataSource = tabla
            End Using

            DataGridViewAsistencia.DataSource = Nothing

        Catch ex As Exception
            Debug.WriteLine("CargarMateriasPorCurso(): " & ex.Message)
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
                 INNER JOIN materia m 
                     ON m.id_curso = a.id_curso AND m.id = @idMateria
                 LEFT JOIN asistencias asist
                       ON asist.id_alumnos = a.id
                      AND asist.id_materia = m.id
                      AND asist.fecha = @fecha
                 WHERE a.id_curso = @idCurso
                 ORDER BY a.apellido;"

            Using comando As New SQLiteCommand(query, conexion)
                comando.Parameters.AddWithValue("@idCurso", idCurso)
                comando.Parameters.AddWithValue("@idMateria", idMateria)
                comando.Parameters.AddWithValue("@fecha", fecha)

                Dim adaptador As New SQLiteDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DataGridViewAsistencia.DataSource = tabla
            End Using

            If DataGridViewAsistencia.Columns.Contains("ID_Alumno") Then DataGridViewAsistencia.Columns("ID_Alumno").Visible = False
            If DataGridViewAsistencia.Columns.Contains("ID_Materia") Then DataGridViewAsistencia.Columns("ID_Materia").Visible = False
            If DataGridViewAsistencia.Columns.Contains("Fecha") Then DataGridViewAsistencia.Columns("Fecha").Visible = False

        Catch ex As Exception
            ' Errores benignos que no deben mostrarse
            If ex.Message.Contains("state of the object") Then
                Debug.WriteLine("Aviso ignorado: " & ex.Message)
                Return
            End If

            ' Otros errores sí se muestran
            MessageBox.Show("Error al cargar asistencia: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === GUARDAR ASISTENCIA ===
    Private Sub DataGridViewAsistencia_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) _
        Handles DataGridViewAsistencia.CellEndEdit

        Dim col = DataGridViewAsistencia.Columns(e.ColumnIndex).Name
        If col <> "Asistencia" AndAlso col <> "Conducta" AndAlso col <> "Participacion" Then
            Exit Sub
        End If

        Try
            If DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Alumno").Value Is Nothing OrElse
               DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Materia").Value Is Nothing Then
                Return
            End If

            conexion.Open()

            Dim idAlumno As Integer = CInt(DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Alumno").Value)
            Dim idMateria As Integer = CInt(DataGridViewAsistencia.Rows(e.RowIndex).Cells("ID_Materia").Value)
            Dim fecha As String = DateTimePickerFecha.Value.ToString("yyyy-MM-dd")

            Dim asistencia = If(DataGridViewAsistencia.Rows(e.RowIndex).Cells("Asistencia").Value IsNot Nothing,
                                DataGridViewAsistencia.Rows(e.RowIndex).Cells("Asistencia").Value.ToString(), String.Empty)
            Dim conducta = If(DataGridViewAsistencia.Rows(e.RowIndex).Cells("Conducta").Value IsNot Nothing,
                              DataGridViewAsistencia.Rows(e.RowIndex).Cells("Conducta").Value.ToString(), String.Empty)
            Dim participacion = If(DataGridViewAsistencia.Rows(e.RowIndex).Cells("Participacion").Value IsNot Nothing,
                                   DataGridViewAsistencia.Rows(e.RowIndex).Cells("Participacion").Value.ToString(), String.Empty)

            ' Usamos UPSERT explícito (requiere índice/constraint único)
            Dim query As String =
                "INSERT INTO asistencias (id_alumnos, id_materia, fecha, asistencia, conducta, participacion)
                 VALUES (@id_alumnos, @id_materia, @fecha, @asistencia, @conducta, @participacion)
                 ON CONFLICT(id_alumnos, id_materia, fecha) DO UPDATE SET
                     asistencia=excluded.asistencia,
                     conducta=excluded.conducta,
                     participacion=excluded.participacion;"

            Using comando As New SQLiteCommand(query, conexion)
                comando.Parameters.AddWithValue("@id_alumnos", idAlumno)
                comando.Parameters.AddWithValue("@id_materia", idMateria)
                comando.Parameters.AddWithValue("@fecha", fecha)
                comando.Parameters.AddWithValue("@asistencia", asistencia)
                comando.Parameters.AddWithValue("@conducta", conducta)
                comando.Parameters.AddWithValue("@participacion", participacion)

                comando.ExecuteNonQuery()
            End Using

            ' Recargar la fila actual para reflejar cualquier cambio
            If Cbmnotasalum.SelectedValue IsNot Nothing AndAlso cmbMateria.SelectedValue IsNot Nothing Then
                CargarAlumnosAsistencia(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar asistencia: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub

End Class
