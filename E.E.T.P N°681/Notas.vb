Imports MySql.Data.MySqlClient

Public Class Notas
    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")

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
            Dim query As String = "SELECT id, CONCAT(anio, '° Año ', division) AS curso_completo FROM curso;"
            Dim adaptador As New MySqlDataAdapter(query, conexion)
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
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tablaMaterias As New DataTable()
            adaptador.Fill(tablaMaterias)

            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList
            cmbMateria.DisplayMember = "nombre"
            cmbMateria.ValueMember = "id"
            cmbMateria.DataSource = tablaMaterias

            ' Limpia el grid cuando se cambia de curso
            DataGridViewNotas.DataSource = Nothing

        Catch ex As Exception
            MessageBox.Show("Error al cargar materias: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' === CARGA DE ALUMNOS Y NOTAS SEGÚN CURSO Y MATERIA ===
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

            Dim query As String = "
            SELECT a.id AS ID_Alumno,
                   m.id AS ID_Materia,
                   CONCAT(a.apellido, ', ', a.nombre) AS Alumno,
                   m.nombre AS Materia,
                   IFNULL(am.nota, '') AS Nota
            FROM alumnos a
            INNER JOIN materia m ON m.id_curso = a.id_curso
            LEFT JOIN alumno_materia am 
                   ON am.id_alumno = a.id 
                  AND am.id_materia = m.id
                  AND am.id_trimestre = @id_trimestre
            WHERE a.id_curso = @idCurso AND m.id = @idMateria
            ORDER BY a.apellido;
        "

            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)
            comando.Parameters.AddWithValue("@idMateria", idMateria)
            comando.Parameters.AddWithValue("@id_trimestre", idtrimestre)

            Dim adaptador As New MySqlDataAdapter(comando)
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

                Dim query As String = "
                INSERT INTO alumno_materia (id_alumno, id_materia, id_trimestre, nota)
                VALUES (@id_alumno, @id_materia, @id_trimestre, @nota)
                ON DUPLICATE KEY UPDATE nota = @nota;
            "

                Dim comando As New MySqlCommand(query, conexion)
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

    Private Sub btnPromocionar_MouseHover(sender As Object, e As EventArgs) Handles botonPromocionar.MouseLeave
        botonPromocionar.BackColor = Color.DodgerBlue
    End Sub

    Private Sub botonPromocionar_Click(sender As Object, e As EventArgs) Handles botonPromocionar.Click

        ' Evitar doble ejecución
        botonPromocionar.Enabled = False

        Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")
        Dim promovidos As Integer = 0
        Dim egresados As Integer = 0

        Try
            conexion.Open()

            ' ==========================================================
            ' 1️⃣ CONTAR ALUMNOS QUE PROMOCIONAN (1º → 5º)
            ' ==========================================================
            Dim sqlContarPromovidos As String =
            "SELECT COUNT(*) FROM (" &
            "   SELECT a.id AS idAlumno " &
            "   FROM alumnos a " &
            "   JOIN curso c ON a.id_curso = c.id " &
            "   WHERE c.anio < 6 " &
            "   AND NOT EXISTS ( " &
            "       SELECT 1 FROM materia m " &
            "       WHERE m.id_curso = a.id_curso " &
            "       AND (SELECT MIN(nota) FROM alumno_materia am " &
            "            WHERE am.id_alumno = a.id " &
            "              AND am.id_materia = m.id " &
            "              AND am.id_trimestre IN (1,2,3)) < 6 " &
            "   )" &
            ") AS t;"

            Dim cmdCountProm As New MySqlCommand(sqlContarPromovidos, conexion)
            promovidos = Convert.ToInt32(cmdCountProm.ExecuteScalar())

            ' ==========================================================
            ' 2️⃣ CONTAR EGRESADOS (6º)
            ' ==========================================================
            Dim sqlContarEgresados As String =
            "SELECT COUNT(*) FROM (" &
            "   SELECT a.id AS idAlumno " &
            "   FROM alumnos a " &
            "   JOIN curso c ON a.id_curso = c.id " &
            "   WHERE c.anio = 6 " &
            "   AND NOT EXISTS ( " &
            "       SELECT 1 FROM materia m " &
            "       WHERE m.id_curso = a.id_curso " &
            "       AND (SELECT MIN(nota) FROM alumno_materia am " &
            "            WHERE am.id_alumno = a.id " &
            "              AND am.id_materia = m.id " &
            "              AND am.id_trimestre IN (1,2,3)) < 6 " &
            "   )" &
            ") AS t;"

            Dim cmdCountEgr As New MySqlCommand(sqlContarEgresados, conexion)
            egresados = Convert.ToInt32(cmdCountEgr.ExecuteScalar())


            ' ==========================================================
            ' 3️⃣ PROMOVER ALUMNOS DE AÑO (1 → 5)
            ' ==========================================================
            Dim sqlPromover As String =
            "UPDATE alumnos al " &
            "JOIN curso c ON al.id_curso = c.id " &
            "JOIN ( " &
            "   SELECT a.id AS idAlumno " &
            "   FROM alumnos a " &
            "   WHERE NOT EXISTS ( " &
            "       SELECT 1 FROM materia m " &
            "       WHERE m.id_curso = a.id_curso " &
            "       AND (SELECT MIN(nota) FROM alumno_materia am " &
            "            WHERE am.id_alumno = a.id " &
            "              AND am.id_materia = m.id " &
            "              AND am.id_trimestre IN (1,2,3)) < 6 " &
            "   )" &
            ") AS t ON t.idAlumno = al.id " &
            "SET al.id_curso = ( " &
            "   SELECT id FROM curso WHERE anio = c.anio + 1 AND division = c.division " &
            ") " &
            "WHERE c.anio < 6;"

            Dim cmdPromover As New MySqlCommand(sqlPromover, conexion)
            cmdPromover.ExecuteNonQuery()


            ' ==========================================================
            ' 4️⃣ ELIMINAR EGRESADOS (6º)
            ' ==========================================================
            Dim sqlEliminar As String =
            "DELETE al FROM alumnos al " &
            "JOIN curso c ON al.id_curso = c.id " &
            "JOIN ( " &
            "   SELECT a.id AS idAlumno " &
            "   FROM alumnos a " &
            "   WHERE NOT EXISTS ( " &
            "       SELECT 1 FROM materia m " &
            "       WHERE m.id_curso = a.id_curso " &
            "       AND (SELECT MIN(nota) FROM alumno_materia am " &
            "            WHERE am.id_alumno = a.id " &
            "              AND am.id_materia = m.id " &
            "              AND am.id_trimestre IN (1,2,3)) < 6 " &
            "   )" &
            ") AS t ON t.idAlumno = al.id " &
            "WHERE c.anio = 6;"

            Dim cmdEliminar As New MySqlCommand(sqlEliminar, conexion)
            cmdEliminar.ExecuteNonQuery()


            ' ==========================================================
            ' 5️⃣ MENSAJE FINAL
            ' ==========================================================
            MessageBox.Show(
            "*PROMOCIÓN COMPLETADA*" & vbCrLf & vbCrLf &
            "Alumnos promovidos: " & promovidos & vbCrLf &
            "Egresados eliminados: " & egresados,
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
            botonPromocionar.Enabled = True 'si falla, lo activo otra vez

        Finally
            conexion.Close()
        End Try

    End Sub


End Class
