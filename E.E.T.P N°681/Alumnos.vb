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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.Open()
            Dim consulta As String = "INSERT INTO alumnos (nombre, apellido, dni, direccion, telefono, correo, id_curso) VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @correo, @id_curso)"
            Dim comando As New MySqlCommand(consulta, conexion)
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
        If DataGridView1.SelectedRows.Count > 0 Then
            Try
                conexion.Open()
                Dim consulta As String = "UPDATE alumnos SET nombre=@nombre, apellido=@apellido, dni=@dni, direccion=@direccion, telefono=@telefono, correo=@correo WHERE id_curso=@id_curso"
                Dim comando As New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
                comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
                comando.Parameters.AddWithValue("@dni", txtDni.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
                comando.Parameters.AddWithValue("@id_curso", CInt(ComboBox1.SelectedValue))
                comando.ExecuteNonQuery()
                MessageBox.Show("Alumno actualizado correctamente.")
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar alumno: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        Else
            MessageBox.Show("Seleccione un alumno para editar.")
        End If

        CargarAlumnos(CInt(ComboBox1.SelectedValue))
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            If MessageBox.Show("¿Está seguro de eliminar este alumno?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    conexion.Open()
                    Dim consulta As String = "DELETE FROM alumnos WHERE id_curso=@id_curso"
                    Dim comando As New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id_curso", CInt(ComboBox1.SelectedValue))
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Alumno eliminado correctamente.")
                    LimpiarCampos()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar alumno: " & ex.Message)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un alumno para eliminar.")
        End If

        CargarAlumnos(CInt(ComboBox1.SelectedValue))
    End Sub

    Private Sub DataGridViewDirectivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
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

    Private Sub LabelTitulo_Click(sender As Object, e As EventArgs) Handles LabelTitulo.Click

    End Sub
End Class
