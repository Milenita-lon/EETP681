<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panelsuperiorcurso = New Panel()
        Label1 = New Label()
        cbmCurso = New ComboBox()
        lblEspecialidad = New Label()
        lblPreceptor = New Label()
        btndescargapdf = New Button()
        DataGridViewCursos = New DataGridView()
        Panelsuperiorcurso.SuspendLayout()
        CType(DataGridViewCursos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panelsuperiorcurso
        ' 
        Panelsuperiorcurso.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        Panelsuperiorcurso.Controls.Add(Label1)
        Panelsuperiorcurso.Dock = DockStyle.Top
        Panelsuperiorcurso.Location = New Point(0, 0)
        Panelsuperiorcurso.Name = "Panelsuperiorcurso"
        Panelsuperiorcurso.Size = New Size(830, 100)
        Panelsuperiorcurso.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(326, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 59)
        Label1.TabIndex = 0
        Label1.Text = "CURSOS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cbmCurso
        ' 
        cbmCurso.Anchor = AnchorStyles.None
        cbmCurso.FormattingEnabled = True
        cbmCurso.Location = New Point(112, 161)
        cbmCurso.Name = "cbmCurso"
        cbmCurso.Size = New Size(121, 23)
        cbmCurso.TabIndex = 1
        ' 
        ' lblEspecialidad
        ' 
        lblEspecialidad.Anchor = AnchorStyles.None
        lblEspecialidad.AutoSize = True
        lblEspecialidad.BackColor = SystemColors.Control
        lblEspecialidad.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEspecialidad.ForeColor = Color.Black
        lblEspecialidad.Location = New Point(357, 159)
        lblEspecialidad.Name = "lblEspecialidad"
        lblEspecialidad.Size = New Size(112, 21)
        lblEspecialidad.TabIndex = 2
        lblEspecialidad.Text = "ESPECIALIDAD"
        ' 
        ' lblPreceptor
        ' 
        lblPreceptor.Anchor = AnchorStyles.None
        lblPreceptor.AutoSize = True
        lblPreceptor.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPreceptor.Location = New Point(577, 159)
        lblPreceptor.Name = "lblPreceptor"
        lblPreceptor.Size = New Size(93, 21)
        lblPreceptor.TabIndex = 3
        lblPreceptor.Text = "PRECEPTOR"
        ' 
        ' btndescargapdf
        ' 
        btndescargapdf.Anchor = AnchorStyles.None
        btndescargapdf.BackColor = Color.FromArgb(CByte(4), CByte(36), CByte(64))
        btndescargapdf.FlatStyle = FlatStyle.Flat
        btndescargapdf.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btndescargapdf.ForeColor = Color.White
        btndescargapdf.Location = New Point(357, 577)
        btndescargapdf.Name = "btndescargapdf"
        btndescargapdf.Size = New Size(138, 25)
        btndescargapdf.TabIndex = 2
        btndescargapdf.Text = "Descargar PDF"
        btndescargapdf.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewCursos
        ' 
        DataGridViewCursos.Anchor = AnchorStyles.None
        DataGridViewCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCursos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCursos.BackgroundColor = Color.White
        DataGridViewCursos.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(51), CByte(102))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(230), CByte(240), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewCursos.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCursos.EnableHeadersVisualStyles = False
        DataGridViewCursos.GridColor = SystemColors.ScrollBar
        DataGridViewCursos.Location = New Point(88, 205)
        DataGridViewCursos.Name = "DataGridViewCursos"
        DataGridViewCursos.RowHeadersVisible = False
        DataGridViewCursos.RowHeadersWidth = 51
        DataGridViewCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewCursos.Size = New Size(656, 345)
        DataGridViewCursos.TabIndex = 6
        ' 
        ' Curso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(830, 591)
        Controls.Add(DataGridViewCursos)
        Controls.Add(btndescargapdf)
        Controls.Add(lblPreceptor)
        Controls.Add(lblEspecialidad)
        Controls.Add(cbmCurso)
        Controls.Add(Panelsuperiorcurso)
        FormBorderStyle = FormBorderStyle.None
        Name = "Curso"
        Text = "Curso"
        Panelsuperiorcurso.ResumeLayout(False)
        Panelsuperiorcurso.PerformLayout()
        CType(DataGridViewCursos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panelsuperiorcurso As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbmCurso As ComboBox
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents lblPreceptor As Label
    Friend WithEvents DataGridViewCursos As DataGridView
    Friend WithEvents btndescargapdf As Button
End Class
