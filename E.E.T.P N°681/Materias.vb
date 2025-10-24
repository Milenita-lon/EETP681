Public Class Materias
    ' Diccionario cursos → lista de materias
    Private materiasPorCurso As New Dictionary(Of String, List(Of String)) From {
        {"1° A", New List(Of String) From {"Matemática", "Lengua y Literatura", "Biología", "Geografía", "Formación Ética y Ciudadana", "Lengua Extranjera: Inglés", "Educación Física", "Educación Artística: Música", "Educación Tecnológica", "Dibujo Técnico", "Taller de Metalmecánica", "Taller de Carpintería", "Taller de Electricidad"}},
        {"1° B", New List(Of String) From {"Matemática", "Lengua y Literatura", "Biología", "Geografía", "Formación Ética y Ciudadana", "Lengua Extranjera: Inglés", "Educación Física", "Educación Artística: Música", "Educación Tecnológica", "Dibujo Técnico", "Taller de Metalmecánica", "Taller de Carpintería", "Taller de Electricidad"}},
        {"2° A", New List(Of String) From {"Historia", "Formación Ética y Ciudadana", "Lengua y Literatura", "Lengua Extranjera: Inglés", "Educación Física", "Educación Artística: Plástica", "Físico Química", "Matemática", "Educación Tecnológica", "Dibujo Técnico", "Taller de Metalmecánica", "Taller de Carpintería", "Taller de Electricidad"}},
        {"2° B", New List(Of String) From {"Historia", "Formación Ética y Ciudadana", "Lengua y Literatura", "Lengua Extranjera: Inglés", "Educación Física", "Educación Artística: Plástica", "Físico Química", "Matemática", "Educación Tecnológica", "Dibujo Técnico", "Taller de Metalmecánica", "Taller de Carpintería", "Taller de Electricidad"}},
        {"3° A", New List(Of String) From {"Historia", "Formación Ética y Ciudadana", "Lengua y Literatura", "Lengua Extranjera: Inglés", "Educación Física", "Física", "TIC", "Matemática", "Materiales y Procesos", "Dibujo Técnico", "Taller", "Software I", "Hardware I"}},
        {"3° B", New List(Of String) From {"Historia", "Formación Ética y Ciudadana", "Lengua y Lieratura", "Lengua Extranjera: Inglés", "Educación Física", "Física", "Química", "Matemática", "Conocimiento de los Materiales", "Representación Gráfica e Interpretación de Planos", "Taller de Electricidad"}},
        {"4° A", New List(Of String) From {"Geografía", "Formación Ética y Ciudadana", "Lengua y Literatur", "Lengua Extranjera: Inglés", "Educación Física", "Economía", "Matemática", "Fundamentos de Gestión", "Automatización y Control", "Taller", "Software II", "Hardware II"}},
        {"4° B", New List(Of String) From {"Geografía", "Formación Ética y Ciudadana", "Lengua y Literatura", "Lengua Extranjera: Inglés", "Educación Física", "Mecánica Técnica", "Gestión y Comercialización", "Matemática", "Laboratorio de Ensayo de Materiales", "Representación Gráfica e Interpretación de Planos", "Introducción a los Circuitos Eléctricos", "Taller Electricidad", "Taller Mecánica"}},
        {"5° A", New List(Of String) From {"Formación Ética y Ciudadana", "Lengua", "Inglés Técnico", "Educación Física", "Procesos Productivos", "Marco Jurídico de los Procesos Productivos", "Organización y Gestión", "Taller", "Software III", "Hardware III", "Programación"}},
        {"5° B", New List(Of String) From {"Formación Ética y Ciudadana", "Lengua", "Inglés Técnico", "Educación Física", "Termodinámica y Máquinas Térmicas", "Organización Industrial", "Matemática", "Procesos de Fabricación Industrial", "Electrónica", "Máquinas y Comandos Eléctricos", "Elementos de Transporte y Transmisión Mecánica", "Taller Automatización", "Taller CNC"}},
        {"6° A", New List(Of String) From {"Formación Ética y Ciudadana", "Lengua", "Inglés Técnico", "Proyecto Tecnológico", "Matemática Aplicada", "Organización y Gestión Comercial", "Redes", "Software IV", "Hardware IV", "Programación II", "Prácticas Profesionalizantes"}},
        {"6° B", New List(Of String) From {"Formación Ética y Ciudadana", "Lengua", "Inglés Técnico", "Economía", "Marco Jurídico", "Matemática", "Instalaciones Eléctricas", "Proyecto y Diseño de Dispositivos Electromecánicos", "Sistema de Control y Automatización Industrial", "Mantenimiento y Ensayos de Equipos Electromecánicos", "Taller Montaje Electromecánico", "Taller CNC", "Prácticas Profesionalizantes"}}
    }

    Private Sub FormMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los cursos en el ComboBox
        cbmCurso.Items.AddRange(materiasPorCurso.Keys.ToArray())

        ' Configurar DataGridView: una sola columna “Materia”
        dgvMaterias.Columns.Clear()
        dgvMaterias.Columns.Add("Materia", "Materia")
        dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub cmbCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbmCurso.SelectedIndexChanged
        Dim curso As String = cbmCurso.SelectedItem.ToString()

        ' Limpiar filas previas
        dgvMaterias.Rows.Clear()

        ' Llenar DataGridView con las materias del curso
        If materiasPorCurso.ContainsKey(curso) Then
            For Each mat As String In materiasPorCurso(curso)
                dgvMaterias.Rows.Add(mat)
            Next
        End If
    End Sub

End Class