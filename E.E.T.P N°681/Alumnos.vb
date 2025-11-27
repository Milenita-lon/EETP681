Imports System.Data.SQLite

Public Class Alumnos

    ' Cambiar la conexión a SQLite ↓↓↓
    Dim conexion As New SQLiteConnection("Data Source=escuela.db;Version=3;")

    Private Sub Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Close()
            conexion.Open()

            Dim query As String =
                "SELECT id,
                        (anio || '° Año ' || division) AS curso_completo
                 FROM curso;"

            Dim comando As New SQLiteCommand(query, conexion)
            Dim lector As SQLiteDataReader = comando.ExecuteReader()
            Dim tablaCursos As New DataTable()
            tablaCursos.Load(lector)

            ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox1.DisplayMember = "curso_completo"
            ComboBox1.ValueMember = "id"
            ComboBox1.DataSource = tablaCursos

            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue IsNot Nothing AndAlso IsNumeric(ComboBox1.SelectedValue) Then
            CargarAlumnos(CInt(ComboBox1.SelectedValue))
        End If
    End Sub

    Private Sub CargarAlumnos(idCurso As Integer)
        Try
            conexion.Open()
            Dim query As String =
                "SELECT id, nombre, apellido, dni, direccion, telefono, correo
                 FROM alumnos
                 WHERE id_curso = @idCurso;"

            Dim comando As New SQLiteCommand(query, conexion)
            comando.Parameters.AddWithValue("@idCurso", idCurso)

            Dim adaptador As New SQLiteDataAdapter(comando)
            Dim tablaAlumnos As New DataTable()
            adaptador.Fill(tablaAlumnos)

            DataGridViewAlumnos.DataSource = tablaAlumnos

        Catch ex As Exception
            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.Close()
            conexion.Open()

            Dim consulta As String =
                "INSERT INTO alumnos (nombre, apellido, dni, direccion, telefono, correo, id_curso)
                 VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @correo, @id_curso)"

            Dim comando As New SQLiteCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
            comando.Parameters.AddWithValue("@dni", txtDni.Text)
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
            comando.Parameters.AddWithValue("@id_curso", CInt(ComboBox1.SelectedValue))

            comando.ExecuteNonQuery()
            MessageBox.Show("Alumno agregado correctamente.")
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al agregar alumno: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        CargarAlumnos(CInt(ComboBox1.SelectedValue))
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If DataGridViewAlumnos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un alumno para editar.")
            Exit Sub
        End If

        Dim idAlumno As Integer = CInt(DataGridViewAlumnos.SelectedRows(0).Cells("id").Value)

        Try
            conexion.Open()

            Dim consulta As String =
                "UPDATE alumnos
                 SET nombre=@nombre, apellido=@apellido, dni=@dni, direccion=@direccion,
                     telefono=@telefono, correo=@correo
                 WHERE id = @id"

            Dim comando As New SQLiteCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
            comando.Parameters.AddWithValue("@dni", txtDni.Text)
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
            comando.Parameters.AddWithValue("@id", idAlumno)

            comando.ExecuteNonQuery()
            MessageBox.Show("Alumno actualizado correctamente.")
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar alumno: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        CargarAlumnos(CInt(ComboBox1.SelectedValue))
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        If DataGridViewAlumnos.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un alumno para eliminar.")
            Exit Sub
        End If

        Dim idAlumno As Integer = CInt(DataGridViewAlumnos.SelectedRows(0).Cells("id").Value)

        If MessageBox.Show("¿Está seguro de eliminar este alumno?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                conexion.Open()

                ' 1 – BORRAR NOTAS
                Dim sqlNotas As String =
                    "DELETE FROM alumno_materia WHERE id_alumno = @id;"
                Dim cmdNotas As New SQLiteCommand(sqlNotas, conexion)
                cmdNotas.Parameters.AddWithValue("@id", idAlumno)
                cmdNotas.ExecuteNonQuery()

                ' 1.5 – BORRAR TRIMESTRES
                Dim sqlTrim As String =
                    "DELETE FROM trimestre WHERE id_alumnos = @id;"
                Dim cmdTrim As New SQLiteCommand(sqlTrim, conexion)
                cmdTrim.Parameters.AddWithValue("@id", idAlumno)
                cmdTrim.ExecuteNonQuery()

                ' 2 – BORRAR ASISTENCIAS
                Dim sqlAsist As String =
                    "DELETE FROM asistencias WHERE id_alumnos = @id;"
                Dim cmdAsist As New SQLiteCommand(sqlAsist, conexion)
                cmdAsist.Parameters.AddWithValue("@id", idAlumno)
                cmdAsist.ExecuteNonQuery()

                ' 3 – BORRAR ALUMNO
                Dim sqlAlum As String =
                    "DELETE FROM alumnos WHERE id = @id;"
                Dim cmdAlum As New SQLiteCommand(sqlAlum, conexion)
                cmdAlum.Parameters.AddWithValue("@id", idAlumno)
                cmdAlum.ExecuteNonQuery()

                MessageBox.Show("Alumno eliminado correctamente.")
                LimpiarCampos()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar alumno: " & ex.Message)
            Finally
                conexion.Close()
            End Try

            CargarAlumnos(CInt(ComboBox1.SelectedValue))
        End If
    End Sub

    Private Sub DataGridViewAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAlumnos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridViewAlumnos.Rows(e.RowIndex)
            txtNombre.Text = fila.Cells("nombre").Value.ToString()
            txtApellido.Text = fila.Cells("apellido").Value.ToString()
            txtDni.Text = fila.Cells("dni").Value.ToString()
            txtDireccion.Text = fila.Cells("direccion").Value.ToString()
            txtTelefono.Text = fila.Cells("telefono").Value.ToString()
            txtCorreo.Text = fila.Cells("correo").Value.ToString()
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDni.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
    End Sub

End Class
