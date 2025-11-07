Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class notasalum
    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")

    Private Sub notasalum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCursos()
    End Sub

    ' 🔹 Carga los cursos en el ComboBox
    Private Sub CargarCursos()
        Try
            conexion.Close()
            conexion.Open()
            Dim query As String = "SELECT id, 
                                          CONCAT(anio, '° Año ', division) AS curso_completo 
                                   FROM curso;"
            Dim comando As New MySqlCommand(query, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()
            Dim tablanotas As New DataTable()
            tablanotas.Load(lector)

            ' Configuración del ComboBox
            Cbmnotasalum.DropDownStyle = ComboBoxStyle.DropDownList
            Cbmnotasalum.DisplayMember = "curso_completo" ' lo que se ve (ej: "3° Año A")
            Cbmnotasalum.ValueMember = "id"        ' valor real (id_curso)
            Cbmnotasalum.DataSource = tablanotas

            lector.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Class