Imports System.Data.SQLite

Public Class Notas

    Dim conexion As New SQLiteConnection("Data Source=escuela.db;Version=3;")

    Private Sub notasalum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCursos()
        CargarMateriasPorCurso(1)
        CargarAlumnosYNotas(1, 1)
        CargarTrimestres()
    End Sub

    ' === CARGA DE CURSOS ===
    Private Sub CargarCursos()
        Try
            conexion.Open()
            Dim query As String = "SELECT id, (anio || '° Año ' || division) AS curso_completo FROM curso;"
            Dim adaptador As New SQLiteDataAdapter(query, conexion)
            Dim tablaCursos As New DataTable()
            adaptador.Fill(tablaCursos)

            Cbmnotasalum.DropDownStyle = ComboBoxStyle.DropDownList
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
            Dim comando As New SQLiteCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)

            Dim adaptador As New SQLiteDataAdapter(comando)
            Dim tablaMaterias As New DataTable()
            adaptador.Fill(tablaMaterias)

            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList
            cmbMateria.DisplayMember = "nombre"
            cmbMateria.ValueMember = "id"
            cmbMateria.DataSource = tablaMaterias

            DataGridViewNotas.DataSource = Nothing

        Catch ex As Exception
            MessageBox.Show("Error al cargar materias: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA DE ALUMNOS Y NOTAS ===
    Private Sub cmbMateria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMateria.SelectionChangeCommitted
        If Cbmnotasalum.SelectedValue IsNot Nothing AndAlso cmbMateria.SelectedValue IsNot Nothing Then
            CargarAlumnosYNotas(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
        End If
    End Sub

    Private Sub CargarAlumnosYNotas(idCurso As Integer, idMateria As Integer)
        If cmbTrimestre.SelectedValue Is Nothing Then Exit Sub

        Dim idtrimestre As Integer = CInt(cmbTrimestre.SelectedValue)

        Try
            conexion.Open()

            Dim query As String =
            "
            SELECT a.id AS ID_Alumno,
                   m.id AS ID_Materia,
                   (a.apellido || ', ' || a.nombre) AS Alumno,
                   m.nombre AS Materia,
                   COALESCE(am.nota, '') AS Nota
            FROM alumnos a
            INNER JOIN materia m ON m.id_curso = a.id_curso
            LEFT JOIN alumno_materia am 
                   ON am.id_alumno = a.id 
                  AND am.id_materia = m.id
                  AND am.id_trimestre = @id_trimestre
            WHERE a.id_curso = @idCurso AND m.id = @idMateria
            ORDER BY a.apellido;
            "

            Dim comando As New SQLiteCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)
            comando.Parameters.AddWithValue("@idMateria", idMateria)
            comando.Parameters.AddWithValue("@id_trimestre", idtrimestre)

            Dim adaptador As New SQLiteDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DataGridViewNotas.DataSource = tabla

            DataGridViewNotas.Columns("ID_Alumno").Visible = False
            DataGridViewNotas.Columns("ID_Materia").Visible = False
            DataGridViewNotas.Columns("Alumno").Width = 300
            DataGridViewNotas.Columns("Nota").Width = 80

        Catch ex As Exception
            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === GUARDAR NOTA EDITADA ===
    Private Sub DataGridViewNotas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewNotas.CellEndEdit
        If e.ColumnIndex = DataGridViewNotas.Columns("Nota").Index Then
            Try
                conexion.Open()

                Dim idAlumno As Integer = Convert.ToInt32(DataGridViewNotas.Rows(e.RowIndex).Cells("ID_Alumno").Value)
                Dim idMateria As Integer = Convert.ToInt32(DataGridViewNotas.Rows(e.RowIndex).Cells("ID_Materia").Value)
                Dim idtrimestre As Integer = CInt(cmbTrimestre.SelectedValue)
                Dim notaTexto As String = DataGridViewNotas.Rows(e.RowIndex).Cells("Nota").Value.ToString().Trim()

                Dim notaDecimal As Decimal
                If Not Decimal.TryParse(notaTexto, notaDecimal) Then
                    MessageBox.Show("La nota ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CargarAlumnosYNotas(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
                    Exit Sub
                End If

                ' SQLite no tiene ON DUPLICATE KEY
                ' → Usamos INSERT OR REPLACE
                Dim query As String =
                "
                INSERT OR REPLACE INTO alumno_materia (id_alumno, id_materia, id_trimestre, nota)
                VALUES (@id_alumno, @id_materia, @id_trimestre, @nota);
                "

                Dim comando As New SQLiteCommand(query, conexion)
                comando.Parameters.AddWithValue("@id_alumno", idAlumno)
                comando.Parameters.AddWithValue("@id_materia", idMateria)
                comando.Parameters.AddWithValue("@id_trimestre", idtrimestre)
                comando.Parameters.AddWithValue("@nota", notaDecimal)
                comando.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error al guardar la nota: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End If
    End Sub

    Private Sub cmbTrimestre_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbTrimestre.SelectionChangeCommitted
        If Cbmnotasalum.SelectedValue IsNot Nothing AndAlso cmbMateria.SelectedValue IsNot Nothing Then
            CargarAlumnosYNotas(CInt(Cbmnotasalum.SelectedValue), CInt(cmbMateria.SelectedValue))
        End If
    End Sub

    Private Sub CargarTrimestres()
        cmbTrimestre.DropDownStyle = ComboBoxStyle.DropDownList

        Dim tabla As New DataTable()
        tabla.Columns.Add("id", GetType(Integer))
        tabla.Columns.Add("nombre", GetType(String))

        tabla.Rows.Add(1, "1° Trimestre")
        tabla.Rows.Add(2, "2° Trimestre")
        tabla.Rows.Add(3, "3° Trimestre")

        cmbTrimestre.ValueMember = "id"
        cmbTrimestre.DisplayMember = "nombre"
        cmbTrimestre.DataSource = tabla
    End Sub

    ' === BOTÓN PROMOCIONAR ===

    Private Sub botonPromocionar_MouseHover(sender As Object, e As EventArgs) Handles botonPromocionar.MouseLeave
        botonPromocionar.BackColor = Color.DodgerBlue
    End Sub

    Private Sub botonPromocionar_Click(sender As Object, e As EventArgs) Handles botonPromocionar.Click

        botonPromocionar.Enabled = False
        Dim conexionLocal As New SQLiteConnection("Data Source=escuela.db;Version=3;")
        Dim promovidos As Integer = 0
        Dim egresados As Integer = 0
        Dim trans As SQLiteTransaction = Nothing

        Try
            conexionLocal.Open()
            trans = conexionLocal.BeginTransaction()

            ' SQLite NO permite DELETE ... JOIN → lo adapté con subconsultas
            ' El resto se mantiene TAL CUAL

            Dim sqlContarProm As String =
            "
            SELECT COUNT(*) FROM (
              SELECT a.id
              FROM alumnos a
              JOIN curso c ON a.id_curso = c.id
              WHERE c.anio < 6
              AND NOT EXISTS (
                 SELECT 1 FROM materia m 
                 WHERE m.id_curso = a.id_curso
                 AND (
                     SELECT MIN(nota)
                     FROM alumno_materia am
                     WHERE am.id_alumno = a.id 
                       AND am.id_materia = m.id
                       AND am.id_trimestre IN (1,2,3)
                 ) < 6
              )
            ) AS t;
            "

            Dim cmdCP As New SQLiteCommand(sqlContarProm, conexionLocal, trans)
            promovidos = Convert.ToInt32(cmdCP.ExecuteScalar())

            ' EGRESADOS
            Dim sqlContarEgr As String =
            "
            SELECT COUNT(*) FROM (
              SELECT a.id
              FROM alumnos a
              JOIN curso c ON a.id_curso = c.id
              WHERE c.anio = 6
              AND NOT EXISTS (
                 SELECT 1 FROM materia m 
                 WHERE m.id_curso = a.id_curso
                 AND (
                     SELECT MIN(nota)
                     FROM alumno_materia am
                     WHERE am.id_alumno = a.id 
                       AND am.id_materia = m.id
                       AND am.id_trimestre IN (1,2,3)
                 ) < 6
              )
            ) AS t;
            "

            Dim cmdCE As New SQLiteCommand(sqlContarEgr, conexionLocal, trans)
            egresados = Convert.ToInt32(cmdCE.ExecuteScalar())

            ' PROMOVER
            Dim sqlPromover As String =
            "
            UPDATE alumnos
            SET id_curso = (
                SELECT id FROM curso 
                WHERE anio = (SELECT anio FROM curso WHERE id = alumnos.id_curso) + 1
                AND division = (SELECT division FROM curso WHERE id = alumnos.id_curso)
            )
            WHERE id IN (
                SELECT a.id
                FROM alumnos a
                JOIN curso c ON a.id_curso = c.id
                WHERE c.anio < 6
                AND NOT EXISTS (
                    SELECT 1 FROM materia m 
                    WHERE m.id_curso = a.id_curso
                    AND (
                        SELECT MIN(nota)
                        FROM alumno_materia am
                        WHERE am.id_alumno = a.id 
                        AND am.id_materia = m.id
                        AND am.id_trimestre IN (1,2,3)
                    ) < 6
                )
            );
            "

            Dim cmdProm As New SQLiteCommand(sqlPromover, conexionLocal, trans)
            cmdProm.ExecuteNonQuery()

            ' BORRAR NOTAS EGRESADOS (SQLite no permite JOIN DELETE)
            Dim sqlDelNotas As String =
            "
            DELETE FROM alumno_materia
            WHERE id_alumno IN (
                SELECT a.id
                FROM alumnos a
                JOIN curso c ON c.id = a.id_curso
                WHERE c.anio = 6
            );
            "

            Dim cmdNotas As New SQLiteCommand(sqlDelNotas, conexionLocal, trans)
            cmdNotas.ExecuteNonQuery()

            ' BORRAR ASISTENCIAS EGRESADOS
            Dim sqlDelAsist As String =
            "
            DELETE FROM asistencias
            WHERE id_alumnos IN (
                SELECT a.id
                FROM alumnos a
                JOIN curso c ON c.id = a.id_curso
                WHERE c.anio = 6
            );
            "

            Dim cmdAsist As New SQLiteCommand(sqlDelAsist, conexionLocal, trans)
            cmdAsist.ExecuteNonQuery()

            ' BORRAR ALUMNOS EGRESADOS
            Dim sqlDelAlumnos As String =
            "
            DELETE FROM alumnos
            WHERE id IN (
                SELECT a.id
                FROM alumnos a
                JOIN curso c ON c.id = a.id_curso
                WHERE c.anio = 6
            );
            "

            Dim cmdAlumno As New SQLiteCommand(sqlDelAlumnos, conexionLocal, trans)
            cmdAlumno.ExecuteNonQuery()

            trans.Commit()

            MessageBox.Show("PROMOCIÓN COMPLETADA" & vbCrLf & vbCrLf &
                "Alumnos promovidos: " & promovidos & vbCrLf &
                "Egresados eliminados: " & egresados,
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information
            )

        Catch ex As Exception
            Try
                If trans IsNot Nothing Then trans.Rollback()
            Catch
            End Try

            MessageBox.Show("Error: " & ex.Message)

        Finally
            If conexionLocal.State = ConnectionState.Open Then conexionLocal.Close()
            botonPromocionar.Enabled = True
        End Try

    End Sub

End Class
