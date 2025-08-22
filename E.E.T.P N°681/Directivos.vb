
Imports MySql.Data.MySqlClient

Partial Class Directivos
    Inherits System.Windows.Forms.Form

    '========================
    ' LÓGICA DEL FORMULARIO
    '========================

    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=escuela;database=escuela")

    Private Sub Directivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDirectivos()
    End Sub

    Private Sub CargarDirectivos()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT id, nombre, apellido, dni, direccion, telefono, correo FROM directivos"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            DataGridViewDirectivos.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar directivos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.Open()
            Dim consulta As String = "INSERT INTO directivos (nombre, apellido, dni, direccion, telefono, correo) VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @correo)"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
            comando.Parameters.AddWithValue("@dni", txtDni.Text)
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
            comando.ExecuteNonQuery()
            MessageBox.Show("Directivo agregado correctamente.")
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al agregar directivo: " & ex.Message)
        Finally
            conexion.Close()
        End Try

        CargarDirectivos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DataGridViewDirectivos.SelectedRows.Count > 0 Then
            Dim id As Integer = DataGridViewDirectivos.CurrentRow.Cells("id").Value
            Try
                conexion.Open()
                Dim consulta As String = "UPDATE directivos SET nombre=@nombre, apellido=@apellido, dni=@dni, direccion=@direccion, telefono=@telefono, correo=@correo WHERE id=@id"
                Dim comando As New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
                comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
                comando.Parameters.AddWithValue("@dni", txtDni.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
                comando.Parameters.AddWithValue("@id", id)
                comando.ExecuteNonQuery()
                MessageBox.Show("Directivos actualizado correctamente.")
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar directivo: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        Else
            MessageBox.Show("Seleccione un directivo para editar.")
        End If

        CargarDirectivos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridViewDirectivos.SelectedRows.Count > 0 Then
            Dim id As Integer = DataGridViewDirectivos.CurrentRow.Cells("id").Value
            If MessageBox.Show("¿Está seguro de eliminar este directivo?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    conexion.Open()
                    Dim consulta As String = "DELETE FROM directivos WHERE id=@id"
                    Dim comando As New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id", id)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Directivo eliminado correctamente.")
                    LimpiarCampos()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar directivo: " & ex.Message)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un directivo para eliminar.")
        End If

        CargarDirectivos()
    End Sub

    Private Sub DataGridViewDirectivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDirectivos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridViewDirectivos.Rows(e.RowIndex)
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

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class