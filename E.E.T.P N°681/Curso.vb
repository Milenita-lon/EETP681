Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SQLite

Public Class Curso

    ' 🔹 Conexión a SQLite (archivo local)
    Dim conexion As New SQLiteConnection("Data Source=escuela.db;Version=3;")

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

    ' Diccionario de preceptores
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

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCursos()
    End Sub

    ' 🔹 Carga cursos desde SQLite
    Private Sub CargarCursos()
        Try
            cbmCurso.Items.Clear()
            conexion.Open()

            Dim cmd As New SQLiteCommand("SELECT nombre_curso FROM curso", conexion)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

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
        lblEspecialidad.Text = If(especialidades.ContainsKey(cursoSeleccionado),
                                  especialidades(cursoSeleccionado),
                                  "Sin especialidad")

        ' Mostrar preceptor
        lblPreceptor.Text = If(preceptores.ContainsKey(cursoSeleccionado),
                               preceptores(cursoSeleccionado),
                               "Sin preceptor")

        CargarAlumnosDelCurso()
    End Sub

    ' 🔹 Cargar alumnos desde SQLite
    Private Sub CargarAlumnosDelCurso()
        Try
            conexion.Open()

            Dim cursoSeleccionado As String = cbmCurso.SelectedItem.ToString()

            Dim consulta As String =
                "SELECT a.id, a.nombre, a.apellido, a.dni, a.direccion, a.telefono, a.correo
                 FROM alumnos a
                 INNER JOIN curso c ON a.id_curso = c.id_curso
                 WHERE c.nombre_curso = @curso"

            Dim adaptador As New SQLiteDataAdapter(consulta, conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@curso", cursoSeleccionado)

            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DataGridViewCursos.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' 🔹 Exportar a PDF (sin cambios, funciona igual)
    Function ExportarDataGridViewAPDF(dgv As DataGridView)
        Try
            Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 10, 10)
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"

            If saveFileDialog.ShowDialog() <> DialogResult.OK Then
                Return False
            End If

            Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(
                doc, New IO.FileStream(saveFileDialog.FileName, IO.FileMode.Create))

            doc.Open()

            Dim pdfTable As New iTextSharp.text.pdf.PdfPTable(dgv.Columns.Count)

            For Each column As DataGridViewColumn In dgv.Columns
                pdfTable.AddCell(New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(column.HeaderText)))
            Next

            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                    Next
                End If
            Next

            doc.Add(pdfTable)
            doc.Close()
            MessageBox.Show("PDF generado con éxito.")

        Catch ex As Exception
            MessageBox.Show("Error al exportar a PDF: " & ex.Message)
        End Try

        Return True
    End Function

    Private Sub btndescargapdf_Click(sender As Object, e As EventArgs) Handles btndescargapdf.Click
        ExportarDataGridViewAPDF(DataGridViewCursos)
    End Sub

End Class
