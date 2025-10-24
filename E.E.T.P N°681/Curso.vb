Imports MySql.Data.MySqlClient
Public Class Curso

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

    Private Sub cmbCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmCurso.SelectedIndexChanged
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
    End Sub
End Class



