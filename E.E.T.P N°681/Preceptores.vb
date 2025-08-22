
Imports MySql.Data.MySqlClient

Partial Class Preceptores
    Inherits System.Windows.Forms.Form

    '========================
    ' LÓGICA DEL FORMULARIO
    '========================

    Dim conexion As New MySqlConnection("server=localhost;user id=root;password=escuela;database=escuela")

    Private Sub Preceptores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPreceptores()
    End Sub

    Private Sub CargarPreceptores()
        Try
            conexion.Open()
            Dim consulta As String = "SELECT id, nombre, apellido, dni, direccion, telefono, correo FROM preceptores"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            DataGridViewPreceptores.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al cargar preceptores: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            conexion.Open()
            Dim consulta As String = "INSERT INTO preceptores (nombre, apellido, dni, direccion, telefono, correo) VALUES (@nombre, @apellido, @dni, @direccion, @telefono, @correo)"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
            comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
            comando.Parameters.AddWithValue("@dni", txtDni.Text)
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
            comando.ExecuteNonQuery()
            MessageBox.Show("Preceptor agregado correctamente.")
            LimpiarCampos()
            CargarPreceptores()
        Catch ex As Exception
            MessageBox.Show("Error al agregar preceptor: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If DataGridViewPreceptores.SelectedRows.Count > 0 Then
            Dim id As Integer = DataGridViewPreceptores.CurrentRow.Cells("id").Value
            Try
                conexion.Open()
                Dim consulta As String = "UPDATE preceptores SET nombre=@nombre, apellido=@apellido, dni=@dni, direccion=@direccion, telefono=@telefono, correo=@correo WHERE id=@id"
                Dim comando As New MySqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
                comando.Parameters.AddWithValue("@apellido", txtApellido.Text)
                comando.Parameters.AddWithValue("@dni", txtDni.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
                comando.Parameters.AddWithValue("@correo", txtCorreo.Text)
                comando.Parameters.AddWithValue("@id", id)
                comando.ExecuteNonQuery()
                MessageBox.Show("Preceptor actualizado correctamente.")
                LimpiarCampos()
                CargarPreceptores()
            Catch ex As Exception
                MessageBox.Show("Error al actualizar preceptor: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        Else
            MessageBox.Show("Seleccione un preceptor para editar.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If DataGridViewPreceptores.SelectedRows.Count > 0 Then
            Dim id As Integer = DataGridViewPreceptores.CurrentRow.Cells("id").Value
            If MessageBox.Show("¿Está seguro de eliminar este profesor?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    conexion.Open()
                    Dim consulta As String = "DELETE FROM preceptores WHERE id=@id"
                    Dim comando As New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id", id)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Preceptor eliminado correctamente.")
                    LimpiarCampos()
                    CargarPreceptores()
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar preceptor: " & ex.Message)
                Finally
                    conexion.Close()
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un preceptor para eliminar.")
        End If
    End Sub

    Private Sub DataGridViewPreceptores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPreceptores.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridViewPreceptores.Rows(e.RowIndex)
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