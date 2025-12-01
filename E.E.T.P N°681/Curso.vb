Imports System.Data.SQLite

Public Class Curso

    ' Conexión SQLite
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

    ' 🔹 Cargar cursos desde SQLite
    Private Sub CargarCursos()
        Try
            cbmCurso.Items.Clear()
            conexion.Open()

            ' Construimos nombre como “1° A”, “3° B”, etc.
            Dim cmd As New SQLiteCommand("
                SELECT id, (anio || '° ' || division) AS nombre_curso
                FROM curso
                ORDER BY anio, division;
            ", conexion)

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

        ' Especialidad
        lblEspecialidad.Text = If(especialidades.ContainsKey(cursoSeleccionado),
                                  especialidades(cursoSeleccionado),
                                  "Sin especialidad")

        ' Preceptor
        lblPreceptor.Text = If(preceptores.ContainsKey(cursoSeleccionado),
                               preceptores(cursoSeleccionado),
                               "Sin preceptor")

        ' Cargar alumnos del curso
        CargarAlumnosDelCurso()
    End Sub

    ' 🔹 Cargar alumnos según el curso seleccionado
    Private Sub CargarAlumnosDelCurso()
        Try
            conexion.Open()

            Dim cursoSeleccionado As String = cbmCurso.SelectedItem.ToString()

            ' Separar el texto “3° A” → anio=3, division="A"
            Dim partes() As String = cursoSeleccionado.Split(" "c)
            Dim anio As Integer = CInt(partes(0).Replace("°", ""))
            Dim division As String = partes(1)

            Dim consulta As String =
                "
                SELECT a.id, a.nombre, a.apellido, a.dni, a.direccion, a.telefono, a.correo
                FROM alumnos a
                INNER JOIN curso c ON a.id_curso = c.id
                WHERE c.anio = @anio AND c.division = @division
                ORDER BY a.apellido, a.nombre;
                "

            Dim adaptador As New SQLiteDataAdapter(consulta, conexion)
            adaptador.SelectCommand.Parameters.AddWithValue("@anio", anio)
            adaptador.SelectCommand.Parameters.AddWithValue("@division", division)

            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            DataGridViewCursos.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    ' 🔹 Exportar a PDF (no requiere cambios)
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
