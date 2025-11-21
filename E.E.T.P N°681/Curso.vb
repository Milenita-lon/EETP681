Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Curso

    Dim conexion As New MySqlConnection("server=localhost; user id=root; password=escuela; database=escuela;")


    ' Diccionario de especialidades por curso
    Dim especialidades As New Dictionary(Of String, String) From {
        {"1° A", "NIVEL BÁSICO"},
        {"1° B", "NIVEL BÁSICO"},
        {"2° A", "NIVEL BÁSICO"},
        {"2° B", "NIVEL BÁSICO"},
        {"3° A", "INFORMÁTICA"},
        {"3° B", "MECÁNICA"},
        {"4° A", "INFORMÁTICA"},
        {"4° B", "MECÁNICA"},
        {"5° A", "INFORMÁTICA"},
        {"5° B", "MECÁNICA"},
        {"6° A", "INFORMÁTICA"},
        {"6° B", "MECÁNICA"}
    }

    ' Diccionario de preceptores por curso
    Dim preceptores As New Dictionary(Of String, String) From {
        {"1° A", "IVO TROD"},
        {"1° B", "IVO TROD"},
        {"2° A", "IVO TROD"},
        {"2° B", "IVO TROD"},
        {"3° A", "IVO TROD"},
        {"3° B", "IVO TROD"},
        {"4° A", "CAROLINA RODRIGUEZ"},
        {"4° B", "CAROLINA RODRIGUEZ"},
        {"5° A", "CAROLINA RODRIGUEZ"},
        {"5° B", "CAROLINA RODRIGUEZ"},
        {"6° A", "CAROLINA RODRIGUEZ"},
        {"6° B", "CAROLINA RODRIGUEZ"}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar cursos en el ComboBox
        cbmCurso.Items.AddRange(especialidades.Keys.ToArray())

    End Sub

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCursos()
    End Sub

    ' 🔹 Carga los cursos en el ComboBox
    Private Sub CargarCursos()
        Try
            conexion.Close()
            conexion.Open()
            Dim cmd As New MySqlCommand("SELECT id_curso, nombre_curso FROM curso", conexion)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                cbmCurso.Items.Add(reader("nombre_curso").ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("Error al cargar cursos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub


    Private Sub cbmCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmCurso.SelectedIndexChanged
        Dim cursoSeleccionado As String = cbmCurso.SelectedItem.ToString()

        ' Mostrar especialidad
        If especialidades.ContainsKey(cursoSeleccionado) Then
            lblEspecialidad.Text = especialidades(cursoSeleccionado)
        Else
            lblEspecialidad.Text = "Sin especialidad"
        End If

        ' Mostrar preceptor
        If preceptores.ContainsKey(cursoSeleccionado) Then
            lblPreceptor.Text = preceptores(cursoSeleccionado)
        Else
            lblPreceptor.Text = "Sin preceptor"
        End If

        CargarAlumnosDelCurso()

    End Sub

    Private Sub DataGridViewCursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCursos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridViewCursos.Rows(e.RowIndex)
        End If
    End Sub

    ' 🔹 Carga los alumnos del curso seleccionado en el DataGridView
    Private Sub CargarAlumnosDelCurso()
        Try
            conexion.Open()

            ' Obtener el ID del curso seleccionado
            Dim cursoSeleccionado = cbmCurso.SelectedItem
            Dim nombreCurso As String = cbmCurso.SelectedItem.ToString()
            Dim consulta As String = "SELECT a.id, a.nombre, a.apellido , a.dni, a.direccion, a.telefono, a.correo
                          FROM alumnos a
                          INNER JOIN curso c ON a.id_curso = c.id
                          WHERE c.anio = @nombreCurso"

            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@nombreCurso", nombreCurso)

            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            DataGridViewCursos.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Function ExportarDataGridViewAPDF(dgv As DataGridView)
        Try
            ' Crear un documento PDF horizontal
            Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
            If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                Return False
            End If
            Dim writer As iTextSharp.text.pdf.PdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New IO.FileStream(saveFileDialog.FileName, IO.FileMode.Create))
            doc.Open()
            ' Crear una tabla PDF con el mismo número de columnas que el DataGridView
            Dim pdfTable As New iTextSharp.text.pdf.PdfPTable(dgv.Columns.Count)
            ' Agregar los encabezados de columna
            For Each column As DataGridViewColumn In dgv.Columns
                Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(column.HeaderText))
                pdfTable.AddCell(cell)
            Next
            ' Agregar las filas de datos
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                    Next
                End If
            Next
            ' Agregar la tabla al documento PDF
            doc.Add(pdfTable)
            doc.Close()
            MessageBox.Show("Exportación a PDF exitosa.")
        Catch ex As Exception
            MessageBox.Show("Error al exportar a PDF: " & ex.Message)
        End Try
        Return True
    End Function

    Private Sub btndescargapdf_Click(sender As Object, e As EventArgs) Handles btndescargapdf.Click
        ' Llama a la función para exportar a PDF
        ExportarDataGridViewAPDF(DataGridViewCursos)
    End Sub

End Class




